using VfpClient.Tests.Attributes;
using VfpClient.Tests.TestCases;
using Xunit;
using static System.String;

namespace VfpClient.Tests {
    public class VfpConnectionStringBuilderTests {
        [Theory]
        [ConnectionStrings]
        public void Constructor_WithConnectionString_ShouldSetProperties(ConnectionStringsTestCase testCase) {
            var builder = new VfpConnectionStringBuilder(testCase.ConnectionString);

            Assert.Equal(testCase.ExpectedConnectionString, builder.ConnectionString, true);
            Assert.Equal(testCase.DataSource, builder.DataSource);
            Assert.Equal(testCase.Database, builder.Database);
            Assert.Equal(testCase.IsDbc, builder.IsDbc);
            Assert.Equal(testCase.Provider, builder.Provider);
        }

        [Fact]
        public void Constructor_Default_ShouldHaveEmptyProperties() {
            var builder = new VfpConnectionStringBuilder();

            Assert.Equal(Empty, builder.ConnectionString, true);
            Assert.Equal(Empty, builder.DataSource);
            Assert.Equal(Empty, builder.Database);
            Assert.False(builder.IsDbc);
            Assert.Equal(Empty, builder.Provider);
        }

        [Theory]
        [ConnectionStrings]
        public void ConnectionString_ShouldSetProperties(ConnectionStringsTestCase testCase) {
            var builder = new VfpConnectionStringBuilder {
                ConnectionString = testCase.ConnectionString
            };

            Assert.Equal(testCase.ExpectedConnectionString, builder.ConnectionString, true);
            Assert.Equal(testCase.DataSource, builder.DataSource);
            Assert.Equal(testCase.Database, builder.Database);
            Assert.Equal(testCase.IsDbc, builder.IsDbc);
            Assert.Equal(testCase.Provider, builder.Provider);
        }

        [Fact]
        public void CollatingSequence_ShouldDefaultToInput() {
            var builder = new VfpConnectionStringBuilder();

            Assert.Equal(Collation.MACHINE, builder.CollatingSequence);
        }

        [Theory]
        [EnumData(typeof(Collation))]
        public void CollatingSequence_ShouldSetCollatingSequence(Collation collatingSequence) {
            var builder = new VfpConnectionStringBuilder {
                CollatingSequence = collatingSequence
            };

            Assert.Equal(collatingSequence, builder.CollatingSequence);
        }

        [Fact]
        public void Ansi_ShouldDefaultToTrue() {
            var builder = new VfpConnectionStringBuilder();

            Assert.True(builder.Ansi);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Ansi_ShouldSetAnsi(bool ansi) {
            var builder = new VfpConnectionStringBuilder {
                Ansi = ansi
            };

            Assert.Equal(ansi, builder.Ansi);
        }

        [Fact]
        public void Deleted_ShouldDefaultToTrue() {
            var builder = new VfpConnectionStringBuilder();

            Assert.True(builder.Deleted);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Deleted_ShouldSetDeleted(bool deleted) {
            var builder = new VfpConnectionStringBuilder {
                Deleted = deleted
            };

            Assert.Equal(deleted, builder.Deleted);
        }

        [Fact]
        public void Null_ShouldDefaultToTrue() {
            var builder = new VfpConnectionStringBuilder();

            Assert.True(builder.Null);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Null_ShouldSetNull(bool @null) {
            var builder = new VfpConnectionStringBuilder {
                Null = @null
            };

            Assert.Equal(@null, builder.Null);
        }
    }
}
