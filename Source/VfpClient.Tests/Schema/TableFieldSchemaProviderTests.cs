using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests.Schema {
    [TestClass]
    public class TableFieldSchemaProviderTests : TestBase {
        [TestMethod]
        public void TableFieldSchemaProviderTests_GetSchemaWithTableNameAndFieldNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields, new string[] { "categories", "categoryid" });
                var expected = TableFieldSchemaProviderExpected.GetSchemaWithTableNameAndFieldName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableNameAndFieldName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void TableFieldSchemaProviderTests_GetSchemaWithFieldNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields, new string[] { null, "categoryid" });
                var expected = TableFieldSchemaProviderExpected.GetSchemaWithFieldName();

                //DataTableHelper.WriteDataTableCode("SchemaWithFieldName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void TableFieldSchemaProviderTests_GetSchemaWithTableNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields, new[] { "categories" });
                var expected = TableFieldSchemaProviderExpected.GetSchemaWithTableName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void TableFieldSchemaProviderTests_GetSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields);
                var expected = TableFieldSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}