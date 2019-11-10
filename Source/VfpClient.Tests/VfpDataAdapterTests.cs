using System.Data;
using System.Linq;
using VfpClient.Tests.Fixtures;
using Xunit;

namespace VfpClient.Tests {
    public class VfpDataAdapterTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public VfpDataAdapterTests(NorthwindDataFixture fixture) {
            this.fixture = fixture;
        }

        [Fact]
        public void VfpDataAdapterTests_UpdateTest() {
            using(var connection = this.fixture.CreateConnection()) {
                var transaction = connection.BeginTransaction();

                using(var command = connection.CreateCommand()) {
                    command.Transaction = transaction;
                    command.CommandText = "select * from customers";

                    var dataAdapter = new VfpDataAdapter(command);
                    new VfpCommandBuilder(dataAdapter);

                    var dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataTable.Rows[0][0] = "y";

                    var vfpCode = command.ToVfpCode();
                    var parameters = command.Parameters.Cast<VfpParameter>().ToList();

                    dataAdapter.Update(dataTable);

                    var dataTable2 = new DataTable();
                    dataAdapter.Fill(dataTable2);

                    Assert.Equal("y", dataTable.Rows[0][0]);
                }

                transaction.Rollback();
            }
        }
    }
}