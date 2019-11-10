using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class RestrictionSchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public RestrictionSchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void RestrictionSchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Restrictions);
                var expected = RestrictionSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}