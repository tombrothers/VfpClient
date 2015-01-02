using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpParameterCollectionTests : TestBase {
        [TestMethod]
        public void CountTest() {
            using (var command = GetConnection().CreateCommand()) {
                command.CommandText = "=DBGETPROP(\"customers\", \"TABLE\", \"path\"";
                Assert.AreEqual(0, command.Parameters.Count);
            }
        }
    }
}