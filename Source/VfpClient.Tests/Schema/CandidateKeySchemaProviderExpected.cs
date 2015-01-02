using System.Data;

namespace VfpClient.Tests.Schema {
    class CandidateKeySchemaProviderExpected {
        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("CandidateKeys");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));

            #endregion columns

            return dataTable;
        }
    }
}
