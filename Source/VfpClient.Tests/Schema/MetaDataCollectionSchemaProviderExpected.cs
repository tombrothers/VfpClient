using System.Data;

namespace VfpClient.Tests.Schema {
    class MetaDataCollectionSchemaProviderExpected {
        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("MetaDataCollections");

            #region columns

            dataTable.Columns.Add("CollectionName", typeof(System.String));
            dataTable.Columns.Add("NumberOfRestrictions", typeof(System.Int32));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["CollectionName"] = "MetaDataCollections";
            row["NumberOfRestrictions"] = 0;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["CollectionName"] = "DataSourceInformation";
            row["NumberOfRestrictions"] = 0;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["CollectionName"] = "DataTypes";
            row["NumberOfRestrictions"] = 0;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["CollectionName"] = "Restrictions";
            row["NumberOfRestrictions"] = 0;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["CollectionName"] = "ReservedWords";
            row["NumberOfRestrictions"] = 0;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["CollectionName"] = "Tables";
            row["NumberOfRestrictions"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["CollectionName"] = "TableFields";
            row["NumberOfRestrictions"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["CollectionName"] = "Views";
            row["NumberOfRestrictions"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["CollectionName"] = "ViewFields";
            row["NumberOfRestrictions"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["CollectionName"] = "Indexes";
            row["NumberOfRestrictions"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["CollectionName"] = "CandidateKeys";
            row["NumberOfRestrictions"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["CollectionName"] = "ForeignKeys";
            row["NumberOfRestrictions"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["CollectionName"] = "PrimaryKeys";
            row["NumberOfRestrictions"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["CollectionName"] = "Procedures";
            row["NumberOfRestrictions"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["CollectionName"] = "ProcedureParameters";
            row["NumberOfRestrictions"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
