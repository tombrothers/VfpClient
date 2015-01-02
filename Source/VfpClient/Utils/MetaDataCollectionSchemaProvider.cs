using System.Data;
using MetaDataCollection = VfpClient.VfpConnection.SchemaColumnNames.MetaDataCollection;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class MetaDataCollectionSchemaProvider : SchemaProviderBase {
            public MetaDataCollectionSchemaProvider()
                : base(VfpConnection.SchemaNames.MetaDataCollections) {
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var dataTable = new DataTable(Name);

                #region columns

                dataTable.Columns.Add(MetaDataCollection.CollectionName);
                dataTable.Columns.Add(MetaDataCollection.NumberOfRestrictions, typeof(int));

                #endregion columns

                #region rows

                DataRow row;

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.MetaDataCollections;
                row[MetaDataCollection.NumberOfRestrictions] = 0;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.DataSourceInformation;
                row[MetaDataCollection.NumberOfRestrictions] = 0;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.DataTypes;
                row[MetaDataCollection.NumberOfRestrictions] = 0;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.Restrictions;
                row[MetaDataCollection.NumberOfRestrictions] = 0;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.ReservedWords;
                row[MetaDataCollection.NumberOfRestrictions] = 0;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.Tables;
                row[MetaDataCollection.NumberOfRestrictions] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.TableFields;
                row[MetaDataCollection.NumberOfRestrictions] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.Views;
                row[MetaDataCollection.NumberOfRestrictions] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.ViewFields;
                row[MetaDataCollection.NumberOfRestrictions] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.Indexes;
                row[MetaDataCollection.NumberOfRestrictions] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.CandidateKeys;
                row[MetaDataCollection.NumberOfRestrictions] = 2;
                dataTable.Rows.Add(row);

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.ForeignKeys;
                row[MetaDataCollection.NumberOfRestrictions] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.PrimaryKeys;
                row[MetaDataCollection.NumberOfRestrictions] = 1;
                dataTable.Rows.Add(row);

                #endregion row

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.Procedures;
                row[MetaDataCollection.NumberOfRestrictions] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #region row

                row = dataTable.NewRow();
                row[MetaDataCollection.CollectionName] = VfpConnection.SchemaNames.ProcedureParameters;
                row[MetaDataCollection.NumberOfRestrictions] = 2;
                dataTable.Rows.Add(row);

                #endregion row

                #endregion rows

                return dataTable;
            }
        }
    }
}