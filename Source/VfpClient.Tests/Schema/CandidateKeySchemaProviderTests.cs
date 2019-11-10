using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class CandidateKeySchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public CandidateKeySchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void CandidateKeySchemaProviderWithRestrictionTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                Assert.Throws<VfpException>(() => connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys, new string[] { "test", "test", "test" }));
            }
        }

        [Fact]
        public void CandidateKeySchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys);
                var expected = CandidateKeySchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}
