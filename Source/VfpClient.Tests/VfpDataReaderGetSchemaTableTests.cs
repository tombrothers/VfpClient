using VfpClient.Tests.Fixtures;
using Xunit;

namespace VfpClient.Tests {
    public class VfpDataReaderGetSchemaTableTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public VfpDataReaderGetSchemaTableTests(NorthwindDataFixture fixture) {
            this.fixture = fixture;
        }

        [Fact]
        public void AutoIncTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Orders";
                using(var reader = command.ExecuteReader()) {
                    var expected = VfpDataReaderGetSchemaTableExpected.GetAutoInc();
                    var actual = reader.GetSchemaTable();
                    //DataTableHelper.WriteDataTableCode("AutoInc", actual);
                    DataTableHelper.AssertDataTablesAreEqual(expected, actual);
                }
            });
        }

        [Fact]
        public void NoAutoIncTest() {
            this.fixture.ExecuteCommand(command => {
                command.CommandText = "Select * from Customers";

                using(var reader = command.ExecuteReader()) {
                    var expected = VfpDataReaderGetSchemaTableExpected.GetNoAutoInc();
                    var actual = reader.GetSchemaTable();
                    //DataTableHelper.WriteDataTableCode("NoAutoInc", actual);
                    DataTableHelper.AssertDataTablesAreEqual(expected, actual);
                }
            });
        }
    }
}