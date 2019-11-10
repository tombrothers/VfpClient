using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class ForeignKeySchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public ForeignKeySchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void ForeignKeySchemaProviderTests_GetSchemaWithTableNameNoForeignKeysTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ForeignKeys, new[] { "customers" });
                var expected = ForeignKeySchemaProviderExpected.GetSchemaWithTableNameNoForeignKeys();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableNameNoForeignKeys", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ForeignKeySchemaProviderTests_GetSchemaWithTableNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ForeignKeys, new[] { "orders" });
                var expected = ForeignKeySchemaProviderExpected.GetSchemaWithTableName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ForeignKeySchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ForeignKeys);
                var expected = ForeignKeySchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}