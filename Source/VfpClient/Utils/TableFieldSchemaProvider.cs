using System;
using System.Data;
using System.Linq;
using System.Data.OleDb;
using TableField = VfpClient.VfpConnection.SchemaColumnNames.TableField;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class TableFieldSchemaProvider : SchemaProviderBase {
            public TableFieldSchemaProvider()
                : base(VfpConnection.SchemaNames.TableFields, GetRestrictions(), GetColumns()) {
            }

            private static string[] GetRestrictions() {
                return new[] { TableField.TableName, TableField.FieldName };
            }

            private static SchemaColumn[] GetColumns() {
                return new[] {               
                    new SchemaColumn(TableField.TableName, typeof(string), false),
                    new SchemaColumn(TableField.FieldName, typeof(string), false),
                    new SchemaColumn(TableField.VfpType, typeof(int), false),
                    new SchemaColumn(TableField.VfpTypeName, typeof(string), false),
                    new SchemaColumn(TableField.Width, typeof(int), false),
                    new SchemaColumn(TableField.Decimal, typeof(int), false),
                    new SchemaColumn(TableField.Ordinal, typeof(int), false),
                    new SchemaColumn(TableField.Nullable, typeof(bool), false),
                    new SchemaColumn(TableField.Caption, typeof(string), true),
                    new SchemaColumn(TableField.Comment, typeof(string), true),
                    new SchemaColumn(TableField.DefaultValue, typeof(string), true),
                    new SchemaColumn(TableField.DisplayClass, typeof(string), true),
                    new SchemaColumn(TableField.DisplayClassLibrary, typeof(string), true),
                    new SchemaColumn(TableField.Format, typeof(string), true),
                    new SchemaColumn(TableField.InputMask, typeof(string), true),
                    new SchemaColumn(TableField.RuleExpression, typeof(string), true),
                    new SchemaColumn(TableField.RuleText, typeof(string), true)
                };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var tableName = restrictionValues == null || restrictionValues.Length < 1 ? null : restrictionValues[0];
                var fieldName = restrictionValues == null || restrictionValues.Length < 2 ? null : restrictionValues[1];
                var schema = CreateSchemaStructure();
                var tableSchema = connection.OleDbConnection.GetSchema("Tables", new[] { null, null, tableName, "TABLE" });

                if (tableSchema.Rows.Count == 0) {
                    return schema;
                }

                var props = GetProps(connection, tableSchema).AsEnumerable().ToList();
                var propColumns = Columns.Where(x => x.UseGetDbProp).ToArray();

                foreach (DataRow row in tableSchema.Rows) {
                    var schemaTableName = row.Field<string>("TABLE_NAME");
                    var oleDbColumnSchema = connection.OleDbConnection.GetSchema("Columns", new[] { null, null, schemaTableName, fieldName });

                    foreach (DataRow fieldRow in oleDbColumnSchema.Rows) {
                        var schemaFieldName = fieldRow.Field<string>("COLUMN_NAME");
                        
                        if (fieldName != null && !fieldName.Equals(schemaFieldName, StringComparison.OrdinalIgnoreCase)) {
                            continue;
                        }

                        var schemaRow = schema.NewRow();

                        schemaRow[TableField.FieldName] = fieldRow["COLUMN_NAME"];
                        schemaRow[TableField.TableName] = fieldRow["TABLE_NAME"];
                        schemaRow[TableField.Nullable] = fieldRow["IS_NULLABLE"];

                        var propRow = props.Single(x => x.Field<string>(TableField.TableName).Equals(schemaTableName, StringComparison.OrdinalIgnoreCase) &&
                                                        x.Field<string>(TableField.FieldName).Equals(schemaFieldName, StringComparison.OrdinalIgnoreCase));

                        var vfpType = ((OleDbType)Convert.ToInt32(fieldRow["DATA_TYPE"])).ToVfpType();
                        var propVfpType = propRow.Field<string>("FieldType").ToVfpType();
                        
                        if (!vfpType.IsStringType() && propVfpType.IsStringType()) {
                            vfpType = propVfpType;
                        }
                        
                        schemaRow[TableField.Ordinal] = fieldRow["ORDINAL_POSITION"];

                        if (fieldRow["CHARACTER_MAXIMUM_LENGTH"].ToString().Equals(string.Empty)) {
                            schemaRow[TableField.Width] = fieldRow["NUMERIC_PRECISION"];
                        }
                        else {
                            var maxLength = Convert.ToInt32(fieldRow["CHARACTER_MAXIMUM_LENGTH"]);

                            if (maxLength == int.MaxValue && (vfpType == VfpType.Character || vfpType == VfpType.Varchar)) {
                                vfpType = VfpType.Memo;
                            }

                            schemaRow[TableField.Width] = maxLength;
                        }

                        schemaRow[TableField.Decimal] = fieldRow["NUMERIC_SCALE"];
                        schemaRow[TableField.VfpType] = vfpType;
                        schemaRow[TableField.VfpTypeName] = vfpType.ToVfpTypeName();

                        if (connection.IsDbc) {
                            propColumns.ForEach(x => schemaRow[x.Name] = propRow[x.Name]);
                        }

                        schema.Rows.Add(schemaRow);
                    }
                }

                FormatColumnValues(schema, new[] { TableField.TableName, TableField.FieldName });

                return schema;
            }

            private static DataTable GetProps(VfpConnection connection, DataTable schema) {
                var tableNames = schema.AsEnumerable().Select(x => x.Field<string>("TABLE_NAME")).Distinct();
                var inserts = string.Join(Environment.NewLine, tableNames.Select(x => string.Format("INSERT INTO curTables VALUES('{0}')", x)).ToArray());
                var vfpCode = string.Format(Resources.TableFieldProps, inserts);

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