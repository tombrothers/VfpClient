using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests.Schema {
    [TestClass]
    public class ProcedureSchemaProviderTests : TestBase {
        [TestMethod]
        public void ProcedureSchemaProviderTests_GetSchemaWithProcedureNameReferentialIntegrityTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures, new[] { "ridelete", "true" });
                var expected = ProcedureSchemaProviderExpected.GetSchemaWithProcedureNameReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureNameReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ProcedureSchemaProviderTests_GetSchemaWithReferentialIntegrityTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures, new[] { null, "true" });
                var expected = ProcedureSchemaProviderExpected.GetSchemaWithReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ProcedureSchemaProviderTests_GetSchemaWithProcedureNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures, new[] { "custorderhist" });
                var expected = ProcedureSchemaProviderExpected.GetSchemaWithProcedureName();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ProcedureSchemaProviderTests_GetSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures);
                var expected = ProcedureSchemaProviderExpected.GetSchema();
                
                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}