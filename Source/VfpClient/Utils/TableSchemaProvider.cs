using System;
using System.Data;
using System.Linq;
using Table = VfpClient.VfpConnection.SchemaColumnNames.Table;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class TableSchemaProvider : SchemaProviderBase {
            public TableSchemaProvider()
                : base(VfpConnection.SchemaNames.Tables, GetRestrictions(), GetColumns()) {
            }

            private static string[] GetRestrictions() {
                return new[] { Table.TableName };
            }

            private static SchemaColumn[] GetColumns() {
                return new[] {               
                    new SchemaColumn(Table.TableName, typeof(string), false),
                    new SchemaColumn(Table.Comment, typeof(string), true),
                    new SchemaColumn(Table.DeleteTrigger, typeof(string), true),
                    new SchemaColumn(Table.InsertTrigger, typeof(string), true),
                    new SchemaColumn(Table.Path, typeof(string), true),
                    new SchemaColumn(Table.PrimaryKey, typeof(string), true),
                    new SchemaColumn(Table.RuleExpression, typeof(string), true),
                    new SchemaColumn(Table.RuleText, typeof(string), true),
                    new SchemaColumn(Table.UpdateTrigger, typeof(string), true)
                };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var schema = CreateSchemaStructure();
                var tableName = restrictionValues == null || restrictionValues.Length < 1 ? null : restrictionValues[0];
                var tableSchema = connection.OleDbConnection.GetSchema(Name, new[] { null, null, tableName, "TABLE" });

                if (tableSchema.Rows.Count == 0) {
                    return schema;
                }

                var props = GetProps(connection, tableSchema).AsEnumerable().ToList();
                var propColumns = Columns.Where(x => x.UseGetDbProp).ToArray();

                foreach (DataRow row in tableSchema.Rows) {
                    var schemaTableName = row.Field<string>("TABLE_NAME");
                    var schemaRow = schema.NewRow();

                    schemaRow[Table.TableName] = schemaTableName;

                    if (connection.IsDbc) {
                        var propRow = props.Single(x => x.Field<string>(Table.TableName).Equals(schemaTableName, StringComparison.OrdinalIgnoreCase));

                        propColumns.ForEach(x => schemaRow[x.Name] = propRow[x.Name]);
                    }

                    schema.Rows.Add(schemaRow);
                }

                FormatColumnValues(schema, new[] { Table.TableName });

                return schema;
            }

            private static DataTable GetProps(VfpConnection connection, DataTable schema) {
                var tableNames = schema.AsEnumerable().Select(x => x.Field<string>("TABLE_NAME")).Distinct();
                var inserts = string.Join(Environment.NewLine, tableNames.Select(x => string.Format("INSERT INTO curTables VALUES('{0}')", x)).ToArray());
                var vfpCode = string.Format(Resources.TableProps, inserts);

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