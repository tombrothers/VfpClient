using System;
using System.Data;
using System.Globalization;
using System.Linq;
using ViewField = VfpClient.VfpConnection.SchemaColumnNames.ViewField;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class ViewFieldSchemaProvider : SchemaProviderBase {
            public ViewFieldSchemaProvider()
                : base(VfpConnection.SchemaNames.ViewFields, GetRestrictions(), GetColumns()) {
            }

            private static string[] GetRestrictions() {
                return new[] { ViewField.ViewName, ViewField.FieldName };
            }

            private static SchemaColumn[] GetColumns() {
                return new[] {               
                    new SchemaColumn(ViewField.ViewName, typeof(string), false),
                    new SchemaColumn(ViewField.FieldName, typeof(string), false),
                    new SchemaColumn(ViewField.VfpType, typeof(int), false),
                    new SchemaColumn("DataType", typeof(string), false),
                    new SchemaColumn(ViewField.Width, typeof(int), false),
                    new SchemaColumn(ViewField.Decimal, typeof(int), false),
                    new SchemaColumn(ViewField.Ordinal, typeof(int), false),
                    new SchemaColumn(ViewField.Nullable, typeof(bool), false),
                    new SchemaColumn(ViewField.Caption, typeof(string), true),
                    new SchemaColumn(ViewField.Comment, typeof(string), true),
                    new SchemaColumn(ViewField.DisplayClass, typeof(string), true),
                    new SchemaColumn(ViewField.DisplayClassLibrary, typeof(string), true),
                    new SchemaColumn(ViewField.DefaultValue, typeof(string), true),
                    new SchemaColumn(ViewField.KeyField, typeof(bool), true),
                    new SchemaColumn(ViewField.RuleExpression, typeof(string), true),
                    new SchemaColumn(ViewField.RuleText, typeof(string), true),
                    new SchemaColumn(ViewField.Updatable, typeof(bool), true),
                    new SchemaColumn(ViewField.UpdateName, typeof(string), true)
                };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var schema = CreateSchemaStructure();

                LoadViewFieldData(connection, restrictionValues, schema);

                schema.Columns["DataType"].ColumnName = ViewField.VfpTypeName;

                FormatColumnValues(schema, new[] { ViewField.ViewName, ViewField.FieldName });

                return schema;
            }

            private void LoadViewFieldData(VfpConnection connection, string[] restrictionValues, DataTable schema) {
                if (!connection.IsDbc) {
                    return;
                }

                var viewName = restrictionValues == null || restrictionValues.Length < 1 ? null : restrictionValues[0];
                var fieldName = restrictionValues == null || restrictionValues.Length < 2 ? null : restrictionValues[1];
                var viewsSchema = connection.OleDbConnection.GetSchema("Views", new[] { null, null, viewName });

                if (viewsSchema.Rows.Count == 0) {
                    return;
                }

                var props = GetProps(connection, viewsSchema).AsEnumerable().ToList();
                var propColumns = Columns.Where(x => x.UseGetDbProp).ToArray();

                foreach (DataRow row in viewsSchema.Rows) {
                    var schemaViewName = row.Field<string>("TABLE_NAME");
                    var oleDbColumnSchema = connection.OleDbConnection.GetSchema("Columns", new[] { null, null, schemaViewName, fieldName });

                    foreach (DataRow fieldRow in oleDbColumnSchema.Rows) {
                        var schemaFieldName = fieldRow.Field<string>("COLUMN_NAME");

                        if (fieldName != null &&
                            !fieldName.Equals(schemaFieldName, StringComparison.OrdinalIgnoreCase)) {
                            continue;
                        }

                        var propRow = props.Single(x => x.Field<string>(ViewField.ViewName).Equals(schemaViewName, StringComparison.OrdinalIgnoreCase) &&
                                                        x.Field<string>(ViewField.FieldName).Equals(schemaFieldName, StringComparison.OrdinalIgnoreCase));
                        var schemaRow = schema.NewRow();

                        schemaRow[ViewField.FieldName] = fieldRow["COLUMN_NAME"];
                        schemaRow[ViewField.ViewName] = fieldRow["TABLE_NAME"];
                        schemaRow[ViewField.Ordinal] = fieldRow["ORDINAL_POSITION"];
                        schemaRow[ViewField.Nullable] = fieldRow["IS_NULLABLE"];

                        FillDataTypeWidthDecimalColumn(schemaRow, propRow.Field<string>("DataType"));
                        propColumns.ForEach(x => schemaRow[x.Name] = propRow[x.Name]);

                        var vfpType = (VfpType) schemaRow[ViewField.VfpType];
                        var propVfpType = propRow.Field<string>("FieldType").ToVfpType();

                        if (!vfpType.IsStringType() && propVfpType.IsStringType()) {
                            schemaRow[ViewField.VfpType] = propVfpType;
                        }

                        schema.Rows.Add(schemaRow);
                    }
                }
            }

            private static void FillDataTypeWidthDecimalColumn(DataRow schemaRow, string dataTypeCode) {
                var openParanIndex = dataTypeCode.IndexOf('(');
                var closeParanIndex = dataTypeCode.IndexOf(')');
                var commaIndex = dataTypeCode.IndexOf(',');

                if (openParanIndex != -1 && closeParanIndex != -1) {
                    if (commaIndex != -1) {
                        schemaRow[ViewField.Width] = dataTypeCode.Substring(openParanIndex + 1, commaIndex - openParanIndex - 1);
                        schemaRow[ViewField.Decimal] = dataTypeCode.Substring(commaIndex + 1, closeParanIndex - commaIndex - 1);
                    }
                    else {
                        schemaRow[ViewField.Width] = dataTypeCode.Substring(openParanIndex + 1, closeParanIndex - openParanIndex - 1);
                    }
                }

                var vfpType = dataTypeCode[0].ToString(CultureInfo.CurrentCulture).ToVfpType();

                schemaRow[ViewField.VfpType] = vfpType;
                schemaRow["DataType"] = vfpType.ToVfpTypeName();
            }

            private static DataTable GetProps(VfpConnection connection, DataTable schema) {
                var tableNames = schema.AsEnumerable().Select(x => x.Field<string>("TABLE_NAME")).Distinct();
                var inserts = string.Join(Environment.NewLine, tableNames.Select(x => string.Format("INSERT INTO curViews VALUES('{0}')", x)).ToArray());
                var vfpCode = string.Format(Resources.ViewFieldProps, inserts);

                connection.ExecuteScript(vfpCode);

                using (var command = connection.CreateCommand()) {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM curOutput";

                    var props = new DataTable();
                    var adapter = new VfpDataAdapter(command);

                    adapter.Fill(props);

                    return props;
                }
            }
        }
    }
}