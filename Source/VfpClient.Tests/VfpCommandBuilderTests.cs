using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpCommandBuilderTests : TestBase {
        [TestMethod]
        public void Test() {
            using (var connection = GetConnection()) {
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