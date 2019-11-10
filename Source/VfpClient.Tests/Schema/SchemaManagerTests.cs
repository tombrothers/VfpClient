using VfpClient.Tests.Fixtures;
using Xunit;
using Xunit.Abstractions;

namespace VfpClient.Tests.Schema {
    public class SchemaManagerTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public SchemaManagerTests(NorthwindDataFixture fixture, ITestOutputHelper testOutput) {
            testOutput.WriteLine($"Data Directory: {fixture.DataDirectory}");

            this.fixture = fixture;
        }

        [Fact]
        public void SchemaManagerTests_GetColumnsSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                Assert.Throws<VfpException>(() => connection.GetSchema("Columns"));
            }
        }

        [Fact]
        public void SchemaManagerTests_GetDataSourceInformationSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.DataSourceInformation);
                var expected = SchemaManagerExpected.GetDataSourceInformationSchema();

                //DataTableHelper.WriteDataTableCode("DataSourceInformationSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void SchemaManagerTests_GetReservedWordsSchemaTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ReservedWords);
                var expected = SchemaManagerExpected.GetReservedWordsSchema();

                //DataTableHelper.WriteDataTableCode("ReservedWordsSchema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [Fact]
        public void SchemaManagerTests_GetSchemaWithEmptyCollectionNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                Assert.Throws<VfpException>(() => connection.GetSchema(string.Empty));
            }
        }

        [Fact]
        public void SchemaManagerTests_GetSchemaWithNullCollectionNameTest() {
            using(var connection = this.fixture.CreateConnection()) {
                Assert.Throws<VfpException>(() => connection.GetSchema(null));
            }
        }

        [Fact]
        public void SchemaManagerTests_GetSchemaWithClosedConnectionTest() {
            using(var connection = this.fixture.CreateConnection()) {
                connection.Close();
                Assert.Throws<VfpException>(() => connection.GetSchema(VfpConnection.SchemaNames.CandidateKeys));
            }
        }
    }
}