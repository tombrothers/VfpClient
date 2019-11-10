using Xunit;

namespace VfpClient.Tests {
    public class VfpClientFactoryTests {
        [Fact]
        public void CreateCommandTest() {
            Assert.Equal(typeof(VfpCommand), VfpClientFactory.Instance.CreateCommand().GetType());
        }

        [Fact]
        public void CreateCommandBuilderTest() {
            Assert.Equal(typeof(VfpCommandBuilder), VfpClientFactory.Instance.CreateCommandBuilder().GetType());
        }

        [Fact]
        public void CreateConnectionTest() {
            Assert.Equal(typeof(VfpConnection), VfpClientFactory.Instance.CreateConnection().GetType());
        }

        [Fact]
        public void CreateConnectionStringBuilderTest() {
            Assert.Equal(typeof(VfpConnectionStringBuilder), VfpClientFactory.Instance.CreateConnectionStringBuilder().GetType());
        }

        [Fact]
        public void CreateDataAdapterTest() {
            Assert.Equal(typeof(VfpDataAdapter), VfpClientFactory.Instance.CreateDataAdapter().GetType());
        }

        [Fact]
        public void CreateParameterTest() {
            Assert.Equal(typeof(VfpParameter), VfpClientFactory.Instance.CreateParameter().GetType());
        }
    }
}
