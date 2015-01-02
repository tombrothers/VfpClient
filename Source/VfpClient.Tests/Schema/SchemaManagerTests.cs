using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests.Schema {
    [TestClass]
    public class SchemaManagerTests : TestBase {
        [TestMethod]
        [ExpectedException(typeof(VfpException))]
        public void SchemaManagerTests_GetColumnsSchemaTest() {
            using (var connection = GetConnection()) {
                connection.GetSchema("Columns");
            }
        }

        [TestMethod]
        public void SchemaManagerTests_GetDataSourceInformationSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.DataSourceInformation);
                var expected = SchemaManagerExpected.GetDataSourceInformationSchema();

                //DataTableHelper.WriteDataTableCode("DataSourceInformationSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
        
        [TestMethod]
        public void SchemaManagerTests_GetReservedWordsSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ReservedWords);
                var expected = SchemaManagerExpected.GetReservedWordsSchema();

                //DataTableHelper.WriteDataTableCode("ReservedWordsSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(VfpException))]
        public void SchemaManagerTests_GetSchemaWithEmptyCollectionNameTest() {
            using (var connection = GetConnection()) {
                connection.GetSchema(string.Empty);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(VfpException))]
        public void SchemaManagerTests_GetSchemaWithNullCollectionNameTest() {
            using (var connection = GetConnection()) {
                connection.GetSchema(null);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(VfpException))]
        public void SchemaManagerTests_GetSchemaWithClosedConnectionTest() {
            using (var connection = GetConnection()) {
                connection.Close();
                connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys);
            }
        }
    }
}