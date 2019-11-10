using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class IndexSchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public IndexSchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void IndexSchemaProviderTests_GetSchemaWithTableNameAndFieldNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes, new string[] { "categories", "categoryid" });
                var expected = IndexSchemaProviderExpected.GetSchemaWithTableNameAndFieldName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableNameAndFieldName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void IndexSchemaProviderTests_GetSchemaWithIndexNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes, new string[] { null, "categoryid" });
                var expected = IndexSchemaProviderExpected.GetSchemaWithIndexName();

                //DataTableHelper.WriteDataTableCode("SchemaWithIndexName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void IndexSchemaProviderTests_GetSchemaWithTableNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes, new[] { "categories" });
                var expected = IndexSchemaProviderExpected.GetSchemaWithTableName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void IndexSchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.Indexes);
                var expected = IndexSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}