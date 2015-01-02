using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpDataAdapterTests : TestBase {
        [TestMethod]
        public void VfpDataAdapterTests_UpdateTest() {
            using (var connection = GetConnection(TestContext.TestDeploymentDir)) {
                var transaction = connection.BeginTransaction();

                using (var command = connection.CreateCommand()) {
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

                    Assert.AreEqual("y", dataTable.Rows[0][0]);
                }

                transaction.Rollback();
            }
        }
    }
}