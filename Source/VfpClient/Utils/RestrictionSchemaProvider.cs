using System.Data;
using Restriction = VfpClient.VfpConnection.SchemaColumnNames.Restriction;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class RestrictionSchemaProvider : SchemaProviderBase {
            public RestrictionSchemaProvider()
                : base(VfpConnection.SchemaNames.Restrictions) {
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var dataTable = new DataTable(Name);

                #region columns

                dataTable.Columns.Add(Restriction.CollectionName);
                dataTable.Columns.Add(Restriction.RestrictionName);
                dataTable.Columns.Add(Restriction.RestrictionNumber, typeof(int));

                #endregion columns

                #region rows

                DataRow row;

                #region row 0

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.CandidateKeys;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.CandidateKey.TableName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 1

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.CandidateKeys;
                row[Restriction.RestrictionName] = "NoTablesWithMultipleCandidateKeys";
                row[Restriction.RestrictionNumber] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 2

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.ForeignKeys;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.ForeignKey.PrimaryKeyTableName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 3

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.ForeignKeys;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.ForeignKey.ForeignKeyTableName;
                row[Restriction.RestrictionNumber] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 4

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.Indexes;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.Index.TableName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 5

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.Indexes;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.Index.IndexName;
                row[Restriction.RestrictionNumber] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 6

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.PrimaryKeys;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.PrimaryKey.TableName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 7

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.ProcedureParameters;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.ProcedureParameter.ProcedureName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 8

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.ProcedureParameters;
                row[Restriction.RestrictionName] = "IncludeReferentialIntegrity";
                row[Restriction.RestrictionNumber] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 9

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.Procedures;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.Procedure.ProcedureName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 10

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.Procedures;
                row[Restriction.RestrictionName] = "IncludeReferentialIntegrity";
                row[Restriction.RestrictionNumber] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 11

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.TableFields;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.TableField.TableName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 12

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.TableFields;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.TableField.FieldName;
                row[Restriction.RestrictionNumber] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 13

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.Tables;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.Table.TableName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 14

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.ViewFields;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.ViewField.ViewName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 15

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.ViewFields;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.ViewField.FieldName;
                row[Restriction.RestrictionNumber] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 16

                row = dataTable.NewRow();
                row[Restriction.CollectionName] = VfpConnection.SchemaNames.Views;
                row[Restriction.RestrictionName] = VfpConnection.SchemaColumnNames.View.ViewName;
                row[Restriction.RestrictionNumber] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #endregion rows

                return dataTable;
            }
        }
    }
}