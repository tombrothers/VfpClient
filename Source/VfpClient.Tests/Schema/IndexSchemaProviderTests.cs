using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests.Schema {
    [TestClass]
    public class IndexSchemaProviderTests : TestBase {
        [TestMethod]
        public void IndexSchemaProviderTests_GetSchemaWithTableNameAndFieldNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes, new string[] { "categories", "categoryid" });
                var expected = IndexSchemaProviderExpected.GetSchemaWithTableNameAndFieldName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableNameAndFieldName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void IndexSchemaProviderTests_GetSchemaWithIndexNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes, new string[] { null, "categoryid" });
                var expected = IndexSchemaProviderExpected.GetSchemaWithIndexName();

                //DataTableHelper.WriteDataTableCode("SchemaWithIndexName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void IndexSchemaProviderTests_GetSchemaWithTableNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes, new[] { "categories" });
                var expected = IndexSchemaProviderExpected.GetSchemaWithTableName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void IndexSchemaProviderTests_GetSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes);
                var expected = IndexSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}