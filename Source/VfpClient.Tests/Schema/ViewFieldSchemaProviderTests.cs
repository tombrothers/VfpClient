using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class ViewFieldSchemaProviderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public ViewFieldSchemaProviderTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void ViewFieldSchemaProviderTests_GetSchemaWithViewNameAndFieldNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ViewFields, new string[] { "alphabetical_list_of_products", "categoryid" });
                var expected = ViewFieldSchemaProviderExpected.GetSchemaWithViewNameAndFieldName();

                //DataTableHelper.WriteDataTableCode("SchemaWithViewNameAndFieldName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ViewFieldSchemaProviderTests_GetSchemaWithFieldNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ViewFields, new string[] { null, "categoryid" });
                var expected = ViewFieldSchemaProviderExpected.GetSchemaWithFieldName();

                //DataTableHelper.WriteDataTableCode("SchemaWithFieldName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ViewFieldSchemaProviderTests_GetSchemaWithViewNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ViewFields, new[] { "alphabetical_list_of_products" });
                var expected = ViewFieldSchemaProviderExpected.GetSchemaWithViewName();

                //DataTableHelper.WriteDataTableCode("SchemaWithViewName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void ViewFieldSchemaProviderTests_GetSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ViewFields);
                var expected = ViewFieldSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}