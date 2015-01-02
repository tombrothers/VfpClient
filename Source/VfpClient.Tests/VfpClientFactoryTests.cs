using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpClientFactoryTests {
        [TestMethod]
        public void CreateCommandTest() {
            Assert.AreEqual(typeof(VfpCommand), VfpClientFactory.Instance.CreateCommand().GetType());
        }

        [TestMethod]
        public void CreateCommandBuilderTest() {
            Assert.AreEqual(typeof(VfpCommandBuilder), VfpClientFactory.Instance.CreateCommandBuilder().GetType());
        }

        [TestMethod]
        public void CreateConnectionTest() {
            Assert.AreEqual(typeof(VfpConnection), VfpClientFactory.Instance.CreateConnection().GetType());
        }

        [TestMethod]
        public void CreateConnectionStringBuilderTest() {
            Assert.AreEqual(typeof(VfpConnectionStringBuilder), VfpClientFactory.Instance.CreateConnectionStringBuilder().GetType());
        }

        [TestMethod]
        public void CreateDataAdapterTest() {
            Assert.AreEqual(typeof(VfpDataAdapter), VfpClientFactory.Instance.CreateDataAdapter().GetType());
        }

        [TestMethod]
        public void CreateParameterTest() {
            Assert.AreEqual(typeof(VfpParameter), VfpClientFactory.Instance.CreateParameter().GetType());
        }
    }
}
