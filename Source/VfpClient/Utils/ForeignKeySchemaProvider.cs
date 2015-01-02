using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using ForeignKey = VfpClient.VfpConnection.SchemaColumnNames.ForeignKey;
using Index = VfpClient.VfpConnection.SchemaColumnNames.Index;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class ForeignKeySchemaProvider : SchemaProviderBase {
            public ForeignKeySchemaProvider()
                : base(VfpConnection.SchemaNames.ForeignKeys, GetRestrictions(), null) {
            }

            private static string[] GetRestrictions() {
                return new[] { ForeignKey.PrimaryKeyTableName, ForeignKey.ForeignKeyTableName };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var foreignKeys = connection.OleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, null);
                ModifyColumns(foreignKeys);

                if (!connection.IsDbc || foreignKeys.Rows.Count == 0) {
                    return foreignKeys;
                }

                // using indexes just so that the restrictionValues can be applied to the foreignKeys 
                var indexes = connection.GetSchema(VfpConnection.SchemaNames.Indexes, restrictionValues);

                if (indexes.Rows.Count == 0) {
                    return foreignKeys;
                }

                var query = from foreignKey in foreignKeys.AsEnumerable()
                            from index in indexes.AsEnumerable()
                            where foreignKey.Field<string>(ForeignKey.ForeignKeyIndexName).Equals(index.Field<string>(Index.IndexName), StringComparison.InvariantCultureIgnoreCase)
                                && foreignKey.Field<string>(ForeignKey.ForeignKeyTableName).Equals(index.Field<string>(Index.TableName), StringComparison.InvariantCultureIgnoreCase)
                                && foreignKey.Field<string>(ForeignKey.ForeignKeyFieldName).Equals(index.Field<string>(Index.FieldName), StringComparison.InvariantCultureIgnoreCase)
                            select foreignKey;

                if (!query.Any()) {
                    foreignKeys.Clear();
                    return foreignKeys;
                }

                var schema = query.CopyToDataTable();
                schema.TableName = Name;

                FormatColumnValues(schema,
                                        new[] { 
                                        ForeignKey.ForeignKeyTableName, 
                                        ForeignKey.ForeignKeyFieldName, 
                                        ForeignKey.ForeignKeyIndexName, 
                                        ForeignKey.PrimaryKeyTableName, 
                                        ForeignKey.PrimaryKeyFieldName, 
                                        ForeignKey.PrimaryKeyIndexName 
                                    });

                return schema;
            }

            protected override void ModifyColumns(DataTable foreignKeys) {
                base.ModifyColumns(foreignKeys);
                AddForeignKeyNameColumn(foreignKeys);
            }

            private void AddForeignKeyNameColumn(DataTable foreignKeys) {
                foreignKeys.Columns.Add(ForeignKey.ForeignKeyName,
                                        typeof(string),
                                        string.Format("'FK___' + {0} + '_' + {1} + '___' + {2} + '_' + {3}",
                                                      ForeignKey.ForeignKeyTableName,
                                                      ForeignKey.ForeignKeyFieldName,
                                                      ForeignKey.PrimaryKeyTableName,
                                                      ForeignKey.PrimaryKeyFieldName));
            }

            protected override IEnumerable<string> GetRequiredColumns() {
                yield return ForeignKey.PrimaryKeyTableName;
                yield return ForeignKey.PrimaryKeyFieldName;
                yield return ForeignKey.PrimaryKeyIndexName;
                yield return ForeignKey.ForeignKeyTableName;
                yield return ForeignKey.ForeignKeyFieldName;
                yield return ForeignKey.ForeignKeyIndexName;
            }

            protected override void RenameColumns(DataTable foreignKeys) {
                foreignKeys.Columns["PK_TABLE_NAME"].ColumnName = ForeignKey.PrimaryKeyTableName;
                foreignKeys.Columns["PK_COLUMN_NAME"].ColumnName = ForeignKey.PrimaryKeyFieldName;
                foreignKeys.Columns["PK_NAME"].ColumnName = ForeignKey.PrimaryKeyIndexName;
                foreignKeys.Columns["FK_TABLE_NAME"].ColumnName = ForeignKey.ForeignKeyTableName;
                foreignKeys.Columns["FK_COLUMN_NAME"].ColumnName = ForeignKey.ForeignKeyFieldName;
                foreignKeys.Columns["FK_NAME"].ColumnName = ForeignKey.ForeignKeyIndexName;
            }
        }
    }
}