using System.Data;
using System.Linq;
using ProcedureColumn = VfpClient.VfpConnection.SchemaColumnNames.ProcedureColumn;
using ProcedureParameter = VfpClient.VfpConnection.SchemaColumnNames.ProcedureParameter;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class ProcedureColumnSchemaProvider : SchemaProviderBase {
            public ProcedureColumnSchemaProvider()
                : base(VfpConnection.SchemaNames.ProcedureColumns, GetRestrictions(), null) {
            }

            private static string[] GetRestrictions() {
                return new[] { ProcedureColumn.ProcedureName, "IncludeReferentialIntegrity" };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var schema = CreateEmptyDataTable();

                if (!connection.IsDbc) {
                    return schema;
                }

                var parameters = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters, restrictionValues);

                if (parameters.Rows.Count == 0) {
                    return schema;
                }

                var list = (from p in parameters.AsEnumerable()
                            group p by p.Field<string>(ProcedureParameter.ProcedureName) into g
                            select new {
                                ProcedureName = g.Key,
                                Parameters = g.Select(item => new {
                                    ParameterName = item.Field<string>(ProcedureParameter.ParameterName),
                                    VfpType = (VfpType)item.Field<int>(ProcedureParameter.VfpType)
                                }).ToList()
                            }).ToList();

                foreach (var item in list) {
                    using (var command = connection.CreateCommand()) {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = item.ProcedureName;
                        command.CommandText += "(";

                        if (item.Parameters.Count > 0) {
                            for (int index = 0, total = item.Parameters.Count; index < total; index++) {
                                if (index > 0) {
                                    command.CommandText += ", ";
                                }

                                var parameter = item.Parameters[index];
                                var value = parameter.VfpType.GetDefaultValue();
                                command.CommandText += value;
                            }
                        }
                        command.CommandText += ")";

                        try {
                            var reader = command.ExecuteReader(CommandBehavior.SchemaOnly);
                            var schemaTable = reader.GetSchemaTable();

                            AddSchemaRows(item.ProcedureName, schema, schemaTable);
                        }
                        catch (VfpException ex) {
                            VfpClientTracing.Tracer.TraceError(ex);
                        }
                    }
                }

                FormatColumnValues(schema, new[] { ProcedureColumn.ProcedureName, ProcedureColumn.FieldName });

                return schema;
            }

            private static void AddSchemaRows(string procedureName, DataTable columns, DataTable schema) {
                foreach (DataRow row in schema.Rows) {
                    DataRow newRow = columns.NewRow();

                    newRow[ProcedureColumn.FieldName] = row["ColumnName"];
                    newRow[ProcedureColumn.DataType] = row["ProviderType"];
                    newRow[ProcedureColumn.Nullable] = row["AllowDbNull"];
                    newRow[ProcedureColumn.Width] = row["ColumnSize"];
                    newRow[ProcedureColumn.Ordinal] = row["ColumnOrdinal"];
                    newRow[ProcedureColumn.ProcedureName] = procedureName;
                    newRow[ProcedureColumn.Decimal] = row["NumericScale"];
                    newRow[ProcedureColumn.VfpType] = row["VfpType"];
                    newRow[ProcedureColumn.VfpTypeName] = row["VfpTypeName"];

                    columns.Rows.Add(newRow);
                }
            }

            private static DataTable CreateEmptyDataTable() {
                var dataTable = new DataTable();

                dataTable.Columns.Add(ProcedureColumn.ProcedureName, typeof(string));
                dataTable.Columns.Add(ProcedureColumn.FieldName, typeof(string));
                dataTable.Columns.Add(ProcedureColumn.Ordinal, typeof(int));
                dataTable.Columns.Add(ProcedureColumn.DataType, typeof(int));
                dataTable.Columns.Add(ProcedureColumn.VfpTypeName, typeof(string));
                dataTable.Columns.Add(ProcedureColumn.VfpType, typeof(int));
                dataTable.Columns.Add(ProcedureColumn.Width, typeof(int));
                dataTable.Columns.Add(ProcedureColumn.Decimal, typeof(short));
                dataTable.Columns.Add(ProcedureColumn.Nullable, typeof(bool));

                return dataTable;
            }
        }
    }
}