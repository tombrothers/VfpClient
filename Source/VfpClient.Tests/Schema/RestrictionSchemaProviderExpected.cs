using System.Data;

namespace VfpClient.Tests.Schema {
    class RestrictionSchemaProviderExpected {
        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("Restrictions");

            #region columns

            dataTable.Columns.Add("CollectionName", typeof(System.String));
            dataTable.Columns.Add("RestrictionName", typeof(System.String));
            dataTable.Columns.Add("RestrictionNumber", typeof(System.Int32));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["CollectionName"] = "CandidateKeys";
            row["RestrictionName"] = "TableName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["CollectionName"] = "CandidateKeys";
            row["RestrictionName"] = "NoTablesWithMultipleCandidateKeys";
            row["RestrictionNumber"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["CollectionName"] = "ForeignKeys";
            row["RestrictionName"] = "PkTableName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["CollectionName"] = "ForeignKeys";
            row["RestrictionName"] = "FkTableName";
            row["RestrictionNumber"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["CollectionName"] = "Indexes";
            row["RestrictionName"] = "TableName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["CollectionName"] = "Indexes";
            row["RestrictionName"] = "IndexName";
            row["RestrictionNumber"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["CollectionName"] = "PrimaryKeys";
            row["RestrictionName"] = "TableName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["CollectionName"] = "ProcedureParameters";
            row["RestrictionName"] = "ProcedureName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["CollectionName"] = "ProcedureParameters";
            row["RestrictionName"] = "IncludeReferentialIntegrity";
            row["RestrictionNumber"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["CollectionName"] = "Procedures";
            row["RestrictionName"] = "ProcedureName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["CollectionName"] = "Procedures";
            row["RestrictionName"] = "IncludeReferentialIntegrity";
            row["RestrictionNumber"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["CollectionName"] = "TableFields";
            row["RestrictionName"] = "TableName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["CollectionName"] = "TableFields";
            row["RestrictionName"] = "FieldName";
            row["RestrictionNumber"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["CollectionName"] = "Tables";
            row["RestrictionName"] = "TableName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["CollectionName"] = "ViewFields";
            row["RestrictionName"] = "ViewName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["CollectionName"] = "ViewFields";
            row["RestrictionName"] = "FieldName";
            row["RestrictionNumber"] = 2;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["CollectionName"] = "Views";
            row["RestrictionName"] = "ViewName";
            row["RestrictionNumber"] = 1;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
