using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class TableFieldSchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public TableFieldSchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void TableFieldSchemaProviderTests_GetSchemaWithTableNameAndFieldNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields, new string[] { "categories", "categoryid" });
                var expected = TableFieldSchemaProviderExpected.GetSchemaWithTableNameAndFieldName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableNameAndFieldName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void TableFieldSchemaProviderTests_GetSchemaWithFieldNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields, new string[] { null, "categoryid" });
                var expected = TableFieldSchemaProviderExpected.GetSchemaWithFieldName();

                //DataTableHelper.WriteDataTableCode("SchemaWithFieldName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void TableFieldSchemaProviderTests_GetSchemaWithTableNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields, new[] { "categories" });
                var expected = TableFieldSchemaProviderExpected.GetSchemaWithTableName();

                //DataTableHelper.WriteDataTableCode("SchemaWithTableName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void TableFieldSchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.TableFields);
                var expected = TableFieldSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}