using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class ProcedureColumnSchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public ProcedureColumnSchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void ProcedureColumnSchemaProviderTests_GetSchemaWithProcedureNameReferentialIntegrityTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureColumns, new[] { "ridelete", "true" });
                var expected = ProcedureColumnSchemaProviderExpected.GetSchemaWithProcedureNameReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureNameReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureColumnSchemaProviderTests_GetSchemaWithReferentialIntegrityTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureColumns, new[] { null, "true" });
                var expected = ProcedureColumnSchemaProviderExpected.GetSchemaWithReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureColumnSchemaProviderTests_GetSchemaWithProcedureNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureColumns, new[] { "custorderhist" });
                var expected = ProcedureColumnSchemaProviderExpected.GetSchemaWithProcedureName();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureColumnSchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureColumns);
                var expected = ProcedureColumnSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}