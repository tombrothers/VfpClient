using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class ProcedureParameterSchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public ProcedureParameterSchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void ProcedureParameterSchemaProviderTests_GetSchemaWithProcedureNameReferentialIntegrityTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters, new[] { "riupdate", "true" });
                var expected = ProcedureParameterSchemaProviderExpected.GetSchemaWithProcedureNameReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureNameReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureParameterSchemaProviderTests_GetSchemaWithReferentialIntegrityTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters, new[] { null, "true" });
                var expected = ProcedureParameterSchemaProviderExpected.GetSchemaWithReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureParameterSchemaProviderTests_GetSchemaWithProcedureNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters, new[] { "custorderhist" });
                var expected = ProcedureParameterSchemaProviderExpected.GetSchemaWithProcedureName();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ProcedureParameterSchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters);
                var expected = ProcedureParameterSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}