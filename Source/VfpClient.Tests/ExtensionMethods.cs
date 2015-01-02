using System.Data;

namespace VfpClient.Tests {
    internal static class ExtensionMethods {
        public static DataTable ToDataTable(this IDataReader dataReader) {
            var dataTable = new DataTable();

            dataTable.Load(dataReader);

            return dataTable;
        }
    }
}