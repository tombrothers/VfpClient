using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests.Schema {
    [TestClass]
    public class RestrictionSchemaProviderTests : TestBase {
        [TestMethod]
        public void RestrictionSchemaProviderTests_GetSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Restrictions);
                var expected = RestrictionSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}