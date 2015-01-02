using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using Index = VfpClient.VfpConnection.SchemaColumnNames.Index;
using PrimaryKey = VfpClient.VfpConnection.SchemaColumnNames.PrimaryKey;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class PrimaryKeySchemaProvider : SchemaProviderBase {
            public PrimaryKeySchemaProvider()
                : base(VfpConnection.SchemaNames.PrimaryKeys, GetRestrictions(), null) {
            }

            private static string[] GetRestrictions() {
                return new[] { PrimaryKey.TableName };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var primaryKeys = connection.OleDbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, null);
                ModifyColumns(primaryKeys);

                var schema = primaryKeys.Clone();

                schema.TableName = Name;
                schema.Columns.Add(PrimaryKey.AutoInc, typeof(bool));

                if (!connection.IsDbc || primaryKeys.Rows.Count == 0) {
                    return schema;
                }

                // using indexes just so that the restrictionValues can be applied to the primaryKeys 
                var indexes = connection.GetSchema(VfpConnection.SchemaNames.Indexes, restrictionValues);

                if (indexes.Rows.Count == 0) {
                    return schema;
                }

                var list = from primaryKey in primaryKeys.AsEnumerable()
                           from index in indexes.AsEnumerable()
                           where primaryKey.Field<string>(PrimaryKey.IndexName).Equals(index.Field<string>(Index.IndexName), StringComparison.InvariantCultureIgnoreCase)
                               && primaryKey.Field<string>(PrimaryKey.TableName).Equals(index.Field<string>(Index.TableName), StringComparison.InvariantCultureIgnoreCase)
                               && primaryKey.Field<string>(PrimaryKey.FieldName).Equals(index.Field<string>(Index.FieldName), StringComparison.InvariantCultureIgnoreCase)
                           select new {
                               Row = primaryKey,
                               AutoIncrement = index.Field<bool>(PrimaryKey.AutoInc)
                           };

                foreach (var item in list) {
                    var dataArray = item.Row.ItemArray.ToList();

                    dataArray.Add(item.AutoIncrement);
                    schema.Rows.Add(dataArray.ToArray());
                }

                schema.TableName = Name;
                FormatColumnValues(schema, new[] { PrimaryKey.TableName, PrimaryKey.FieldName, PrimaryKey.IndexName });

                return schema;
            }

            protected override IEnumerable<string> GetRequiredColumns() {
                yield return PrimaryKey.TableName;
                yield return PrimaryKey.FieldName;
                yield return PrimaryKey.IndexName;
                yield return PrimaryKey.Ordinal;
            }

            protected override void RenameColumns(DataTable dataTable) {
                dataTable.Columns["PK_NAME"].ColumnName = PrimaryKey.IndexName;
                dataTable.Columns["TABLE_NAME"].ColumnName = PrimaryKey.TableName;
                dataTable.Columns["COLUMN_NAME"].ColumnName = PrimaryKey.FieldName;
                dataTable.Columns["ORDINAL"].ColumnName = PrimaryKey.Ordinal;
            }
        }
    }
}