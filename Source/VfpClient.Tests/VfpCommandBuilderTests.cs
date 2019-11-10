using System.Data;
using System.Linq;
using VfpClient.Tests.Fixtures;
using Xunit;

namespace VfpClient.Tests {
    public class VfpCommandBuilderTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public VfpCommandBuilderTests(NorthwindDataFixture fixture) {
            this.fixture = fixture;
        }

        [Fact]
        public void Test() {
            using(var connection = this.fixture.CreateConnection()) {
                var dataAdapter = new VfpDataAdapter("Select * from orders", connection);
                var dataTable = new DataTable();

                dataAdapter.Fill(dataTable);

                var commandBuilder = new VfpCommandBuilder(dataAdapter);

                dataTable.Rows[0]["shipname"] = "test";

                var command = commandBuilder.GetUpdateCommand(true);
                var vfpCode = command.ToVfpCode();
                var parameters = command.Parameters.Cast<VfpParameter>().ToList();

                dataAdapter.Update(dataTable);
            }
        }
    }
}
