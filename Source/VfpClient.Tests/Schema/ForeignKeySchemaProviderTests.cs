using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests.Schema {
    [TestClass]
    public class ForeignKeySchemaProviderTests : TestBase {
        [TestMethod]
        public void ForeignKeySchemaProviderTests_GetSchemaWithTableNameNoForeignKeysTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ForeignKeys, new[] { "customers" });
                var expected = ForeignKeySchemaProviderExpected.GetSchemaWithTableNameNoForeignKeys();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableNameNoForeignKeys", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ForeignKeySchemaProviderTests_GetSchemaWithTableNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ForeignKeys, new[] { "orders" });
                var expected = ForeignKeySchemaProviderExpected.GetSchemaWithTableName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ForeignKeySchemaProviderTests_GetSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ForeignKeys);
                var expected = ForeignKeySchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}