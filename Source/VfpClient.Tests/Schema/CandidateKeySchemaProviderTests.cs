using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests.Schema {
    [TestClass]
    public class CandidateKeySchemaProviderTests : TestBase {
        [TestMethod]
        [ExpectedException(typeof(VfpException))]
        public void CandidateKeySchemaProviderWithRestrictionTests_GetSchemaTest() {
            using (var connection = GetConnection()) {
                connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys, new string[] { "test", "test", "test" });
            }
        }

        [TestMethod]
        public void CandidateKeySchemaProviderTests_GetSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys);
                var expected = CandidateKeySchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}