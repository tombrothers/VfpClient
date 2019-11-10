using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class ProcedureSchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public ProcedureSchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void ProcedureSchemaProviderTests_GetSchemaWithProcedureNameReferentialIntegrityTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures, new[] { "ridelete", "true" });
                var expected = ProcedureSchemaProviderExpected.GetSchemaWithProcedureNameReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureNameReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureSchemaProviderTests_GetSchemaWithReferentialIntegrityTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures, new[] { null, "true" });
                var expected = ProcedureSchemaProviderExpected.GetSchemaWithReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureSchemaProviderTests_GetSchemaWithProcedureNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures, new[] { "custorderhist" });
                var expected = ProcedureSchemaProviderExpected.GetSchemaWithProcedureName();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureSchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Procedures);
                var expected = ProcedureSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}