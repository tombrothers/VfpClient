using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using VfpClient.Utils;

namespace VfpClient {
    public partial class VfpDataReader {
        internal class SchemaFixer {
            private readonly OleDbCommand _command;

            public SchemaFixer(VfpDataReader vfpDataReader) {
                _command = GetCommand(vfpDataReader);
            }

            public void Fix(DataTable schema) {
                if (_command == null || schema == null) {
                    return;
                }

                VfpClientTracing.Tracer.TraceVerbose("{SchemaFixer...}");

                var tableName = CommandTextParser.GetTableName(_command.CommandText);
                AddVfpType(schema, tableName);

                VfpClientTracing.Tracer.TraceVerbose("SchemaFixer:  " + _command.CommandText);

                if (string.IsNullOrEmpty(tableName)) {
                    VfpClientTracing.Tracer.TraceVerbose("{...SchemaFixer}");
                    return;
                }

                UpdateBaseTableName(schema, tableName);
                UpdatePrimaryKeyInformation(schema, tableName);
                FormatColumnValues(schema, new[] { SchemaTableColumn.ColumnName, SchemaTableColumn.BaseColumnName });
                VfpClientTracing.Tracer.TraceVerbose("{...SchemaFixer}");
            }

            private static void FormatColumnValues(DataTable table, string[] columns) {
                foreach (DataRow row in table.Rows) {
                    foreach (var column in columns) {
                        var dataColumn = table.Columns[column];
                        var @readonly = dataColumn.ReadOnly;

                        dataColumn.ReadOnly = false;
                        row[column] = row[column].ToString().ToProperIfAllLowerCase();
                        dataColumn.ReadOnly = @readonly;
                    }
                }
            }

            private void UpdatePrimaryKeyInformation(DataTable schema, string tableName) {
                using (var connection = new VfpConnection(_command.Connection.ConnectionString)) {
                    connection.Open();

                    var primaryKeys = connection.GetSchema(VfpConnection.SchemaNames.PrimaryKeys, new[] { tableName });

                    if (primaryKeys.Rows.Count != 1) {
                        return;
                    }

                    var primaryKeyFieldName = primaryKeys.Rows[0]["FieldName"].ToString().ToUpper();

                    foreach (DataRow dataRow in schema.Rows) {
                        var columnName = dataRow[SchemaTableColumn.ColumnName].ToString().ToUpper();

                        if (columnName != primaryKeyFieldName) {
                            continue;
                        }

                        ChangeColumnValue(dataRow, SchemaTableColumn.IsKey, true);
                        ChangeColumnValue(dataRow, SchemaTableColumn.IsUnique, true);

                        var isAutoInc = Convert.ToBoolean(primaryKeys.Rows[0]["AutoInc"]);

                        ChangeColumnValue(dataRow, SchemaTableOptionalColumn.IsAutoIncrement, isAutoInc);
                        ChangeColumnValue(dataRow, SchemaTableOptionalColumn.IsReadOnly, isAutoInc);

                        return;
                    }

                    connection.Close();
                }
            }

            private static void UpdateBaseTableName(DataTable schema, string tableName) {
                if (!string.IsNullOrEmpty(schema.Rows[0][SchemaTableColumn.BaseTableName] as string)) {
                    return;
                }

                foreach (DataRow row in schema.Rows) {
                    ChangeColumnValue(row, SchemaTableColumn.BaseTableName, tableName);
                }
            }

            private static void ChangeColumnValue(DataRow dataRow, string columnName, object value) {
                var dataColumn = dataRow.Table.Columns[columnName];
                var readOnly = dataColumn.ReadOnly;

                dataColumn.ReadOnly = false;
                dataRow[dataColumn] = value;
                dataColumn.ReadOnly = readOnly;
            }

            private void AddVfpType(DataTable schema, string tableName) {
                schema.Columns.Add("VfpType", typeof(int));
                schema.Columns.Add("VfpTypeName");

                var fields = GetFieldsDataTable(tableName);

                if (fields.Rows.Count != 0) {
                    var list = schema.AsEnumerable()
                                     .Join(fields.AsEnumerable(), x => x.Field<string>("ColumnName").ToUpper(), x => x.Field<string>("FieldName").ToUpper(), (s, f) => new { Schema = s, Fields = f })
                                     .ToArray();

                    foreach (var item in list) {
                        item.Schema["VfpType"] = item.Fields["VfpType"];
                        item.Schema["VfpTypeName"] = item.Fields["VfpTypeName"];
                    }
                }
                
                foreach (var row in schema.AsEnumerable().Where(x => string.IsNullOrEmpty(x.Field<string>("VfpTypeName")))) {
                    var vfpType = ((OleDbType) Convert.ToInt32(row[SchemaTableColumn.ProviderType])).ToVfpType();

                    row["VfpType"] = vfpType;
                    row["VfpTypeName"] = vfpType.ToVfpTypeName();
                }

                schema.Columns["VfpType"].ReadOnly = true;
                schema.Columns["VfpTypeName"].ReadOnly = true;
            }

            private DataTable GetFieldsDataTable(string tableName) {
                using (var connection = new VfpConnection(_command.Connection.ConnectionString)) {
                    connection.Open();

                    var dataTable = connection.GetSchema(VfpConnection.SchemaNames.TableFields, new[] { tableName });

                    if (dataTable.Rows.Count == 0) {
                        dataTable = connection.GetSchema(VfpConnection.SchemaNames.ViewFields, new[] { tableName });
                    }

                    connection.Close();

                    return dataTable;
                }
            }

            private static OleDbCommand GetCommand(VfpDataReader vfpDataReader) {
                if (vfpDataReader == null) {
                    return null;
                }

                var oleDbDataReader = vfpDataReader._dbDataReader as OleDbDataReader;

                if (oleDbDataReader == null) {
                    return null;
                }

                var propertyInfo = typeof(OleDbDataReader).GetProperty("Command", BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.Instance);

                return (OleDbCommand)propertyInfo.GetValue(oleDbDataReader, null);
            }
        }
    }
}