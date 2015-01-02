using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpDataReaderGetSchemaTableTests : TestBase {
        [TestMethod]
        public void AutoIncTest() {
            CommandAction(command => {
                command.CommandText = "Select * from Orders";
                using (var reader = command.ExecuteReader()) {
                    var expected = VfpDataReaderGetSchemaTableExpected.GetAutoInc();
                    var actual = reader.GetSchemaTable();
                    //DataTableHelper.WriteDataTableCode("AutoInc", actual);
                    DataTableHelper.AssertDataTablesAreEqual(expected, actual);
                }
            });
        }

        [TestMethod]
        public void NoAutoIncTest() {
            CommandAction(command => {
                command.CommandText = "Select * from Customers";

                using (var reader = command.ExecuteReader()) {
                    var expected = VfpDataReaderGetSchemaTableExpected.GetNoAutoInc();
                    var actual = reader.GetSchemaTable();
                    //DataTableHelper.WriteDataTableCode("NoAutoInc", actual);
                    DataTableHelper.AssertDataTablesAreEqual(expected, actual);
                }
            });
        }
    }
}