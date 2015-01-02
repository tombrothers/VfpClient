using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Index = VfpClient.VfpConnection.SchemaColumnNames.Index;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class IndexSchemaProvider : SchemaProviderBase {
            public IndexSchemaProvider()
                : base(VfpConnection.SchemaNames.Indexes, GetRestrictions(), null) {
            }

            private static string[] GetRestrictions() {
                return new[] { Index.TableName, Index.IndexName };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var tableName = GetTableName(restrictionValues);
                var indexName = GetIndexName(restrictionValues);

                VfpClientTracing.Tracer.TraceVerbose(string.Format("IndexSchemaProvider - Table: {0} | Index: {1}", tableName, indexName));

                var schema = connection.OleDbConnection.GetSchema(Name, new[] { null, null, indexName, null, tableName });

                ModifyColumns(schema);

                if (schema.Rows.Count == 0) {
                    return schema;
                }

                UpdateAutoIncAndCandidate(connection, schema);

                FormatColumnValues(schema, new[] { Index.TableName, Index.FieldName, Index.IndexName });

                return schema;
            }

            private static void UpdateAutoIncAndCandidate(VfpConnection connection, DataTable schema) {
                var tableNames = schema.AsEnumerable().Select(x => x.Field<string>(Index.TableName)).Distinct();
                var inserts = string.Join(Environment.NewLine, tableNames.Select(x => string.Format("INSERT INTO curTables VALUES('{0}')", x)).ToArray());
                var vfpCode = string.Format(Resources.IndexSchemaAutoIncCandidate, inserts);

                schema.AsEnumerable().ToList().ForEach(row => {
                    row[Index.AutoInc] = false;
                    row[Index.Candidate] = false;
                });

                connection.ExecuteScript(vfpCode);

                using (var command = connection.CreateCommand()) {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM curOutput";

#if DEBUG
                    var dt = new DataTable();
                    var da = new VfpDataAdapter(command);
                    da.Fill(dt);
#endif

                    using (var reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            var tableName = reader.GetString(0);
                            var fieldName = reader.GetString(1);
                            var isAutoInc = !string.IsNullOrEmpty(fieldName);
                            var indexName = reader.GetString(2);
                            var rows = schema.AsEnumerable().Where(x => x.Field<string>(Index.TableName) == tableName);

                            if (string.IsNullOrEmpty(fieldName)) {
                                rows = rows.Where(x => x.Field<string>(Index.IndexName).ToUpper() == indexName);
                            }
                            else {
                                rows = rows.Where(x => x.Field<string>(Index.FieldName).ToUpper() == fieldName);
                            }

                            rows.ToList().ForEach(row => {
                                row[Index.AutoInc] = isAutoInc;
                                row[Index.Candidate] = !isAutoInc;
                            });
                        }
                    }

                    command.CommandText = "USE";
                    command.ExecuteNonQuery();
                }
            }

            protected override void ModifyColumns(DataTable indexes) {
                base.ModifyColumns(indexes);
                indexes.Columns.Add(Index.AutoInc, typeof(bool));
                indexes.Columns.Add(Index.Candidate, typeof(bool));
            }

            protected override IEnumerable<string> GetRequiredColumns() {
                yield return Index.TableName;
                yield return Index.IndexName;
                yield return Index.PrimaryKey;
                yield return Index.Unique;
                yield return Index.Ordinal;
                yield return Index.FieldName;
                yield return Index.Expression;
                yield return Index.AutoInc;
                yield return Index.Candidate;
            }

            protected override void RenameColumns(DataTable indexes) {
                indexes.Columns["TABLE_NAME"].ColumnName = Index.TableName;
                indexes.Columns["INDEX_NAME"].ColumnName = Index.IndexName;
                indexes.Columns["PRIMARY_KEY"].ColumnName = Index.PrimaryKey;
                indexes.Columns["UNIQUE"].ColumnName = Index.Unique;
                indexes.Columns["ORDINAL_POSITION"].ColumnName = Index.Ordinal;
                indexes.Columns["COLUMN_NAME"].ColumnName = Index.FieldName;
                indexes.Columns["EXPRESSION"].ColumnName = Index.Expression;
            }

            private static string GetIndexName(string[] restrictionValues) {
                return restrictionValues == null || restrictionValues.Length < 2 ? null : restrictionValues[1];
            }

            private static string GetTableName(string[] restrictionValues) {
                return restrictionValues == null || restrictionValues.Length < 1 ? null : restrictionValues[0];
            }
        }
    }
}