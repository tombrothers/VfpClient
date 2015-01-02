using System;
using System.Data;
using System.Linq;
using View = VfpClient.VfpConnection.SchemaColumnNames.View;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class ViewSchemaProvider : SchemaProviderBase {
            public ViewSchemaProvider()
                : base(VfpConnection.SchemaNames.Views, GetRestrictions(), GetColumns()) {
            }

            private static string[] GetRestrictions() {
                return new[] { View.ViewName };
            }

            private static SchemaColumn[] GetColumns() {
                return new[] {               
                new SchemaColumn(View.ViewName, typeof(string), false),
                new SchemaColumn(View.AllowSimultaneousFetch, typeof(bool), true),
                new SchemaColumn(View.BatchUpdateCount, typeof(int), true),
                new SchemaColumn(View.Comment, typeof(string), true),
                new SchemaColumn(View.CompareMemo, typeof(bool), true),
                new SchemaColumn(View.ConnectName, typeof(string), true),
                new SchemaColumn(View.FetchAsNeeded, typeof(bool), true),
                new SchemaColumn(View.FetchMemo, typeof(bool), true),
                new SchemaColumn(View.FetchSize, typeof(int), true),
                new SchemaColumn(View.MaxRecords, typeof(int), true),
                new SchemaColumn(View.Offline, typeof(bool), true),
                new SchemaColumn(View.ParameterList, typeof(string), true),
                new SchemaColumn(View.Prepared, typeof(bool), true),
                new SchemaColumn(View.RuleExpression, typeof(string), true),
                new SchemaColumn(View.RuleText, typeof(string), true),
                new SchemaColumn(View.SendUpdates, typeof(bool), true),
                new SchemaColumn(View.ShareConnection, typeof(bool), true),
                new SchemaColumn(View.SourceType, typeof(int), true),
                new SchemaColumn(View.Sql, typeof(string), true),
                new SchemaColumn(View.Tables, typeof(string), true),
                new SchemaColumn(View.UpdateType, typeof(int), true),
                new SchemaColumn(View.UseMemoSize, typeof(int), true),
                new SchemaColumn(View.WhereType, typeof(int), true)
            };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var schema = CreateSchemaStructure();

                if (!connection.IsDbc) {
                    return schema;
                }

                var viewName = restrictionValues == null || restrictionValues.Length < 1 ? null : restrictionValues[0];
                var viewsSchema = connection.OleDbConnection.GetSchema(Name, new[] { null, null, viewName });
                
                if (viewsSchema.Rows.Count == 0) {
                    return schema;
                }

                var props = GetProps(connection, viewsSchema).AsEnumerable().ToList();
                var propColumns = Columns.Where(x => x.UseGetDbProp).ToArray();

                foreach (DataRow row in viewsSchema.Rows) {
                    var schemaViewName = row.Field<string>("TABLE_NAME");
                    var schemaRow = schema.NewRow();

                    schemaRow[View.ViewName] = schemaViewName;

                    VfpClientTracing.Tracer.TraceVerbose("ViewName:  " + schemaViewName);

                    var propRow = props.Single(x => x.Field<string>(View.ViewName).Equals(schemaViewName, StringComparison.OrdinalIgnoreCase));
                    
                    propColumns.ForEach(x => schemaRow[x.Name] = propRow[x.Name]);
                    schema.Rows.Add(schemaRow);
                }

                FormatColumnValues(schema, new[] { View.ViewName });

                return schema;
            }

            private static DataTable GetProps(VfpConnection connection, DataTable schema) {
                var tableNames = schema.AsEnumerable().Select(x => x.Field<string>("TABLE_NAME")).Distinct();
                var inserts = string.Join(Environment.NewLine, tableNames.Select(x => string.Format("INSERT INTO curViews VALUES('{0}')", x)).ToArray());
                var vfpCode = string.Format(Resources.ViewProps, inserts);

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