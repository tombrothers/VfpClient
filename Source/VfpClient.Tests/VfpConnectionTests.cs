using System;
using System.IO;
using VfpClient.Tests.Fixtures;
using VfpClient.Utils.DbcCreator;
using Xunit;

namespace VfpClient.Tests {
    public class VfpConnectionTests : IClassFixture<NorthwindDataFixture> {
        private readonly NorthwindDataFixture fixture;

        public VfpConnectionTests(NorthwindDataFixture fixture) {
            this.fixture = fixture;
        }

        [Fact(Skip = "unreliable")]
        public void PackTest() {
            var dbc = CreateTempDbc();
            var builder = new VfpConnectionStringBuilder(dbc);

            builder.Deleted = false;

            using(var connection = new VfpConnection(builder.ConnectionString)) {
                connection.Open();

                using(var command = connection.CreateCommand()) {
                    command.CommandText = "select count(*) from temp";

                    Assert.Equal(13, Convert.ToInt32(command.ExecuteScalar()));

                    command.CommandText = "delete from temp where upper(allt(TableName)) == 'CUSTOMERS'";
                    command.ExecuteNonQuery();

                    command.CommandText = "select count(*) from temp";

                    Assert.Equal(13, Convert.ToInt32(command.ExecuteScalar()));

                    connection.Pack("temp");

                    command.CommandText = "select count(*) from temp";

                    Assert.Equal(12, Convert.ToInt32(command.ExecuteScalar()));
                }

                connection.Close();
            }
        }

        [Fact(Skip = "unreliable")]
        public void ZapTest() {
            var dbc = CreateTempDbc();

            using(var connection = new VfpConnection(dbc)) {
                connection.Open();

                using(var command = connection.CreateCommand()) {
                    command.CommandText = "select count(*) from temp";

                    Assert.NotEqual(0, Convert.ToInt32(command.ExecuteScalar()));

                    connection.Zap("temp");

                    Assert.Equal(0, Convert.ToInt32(command.ExecuteScalar()));
                }

                connection.Close();
            }
        }

        private string CreateTempDbc() {
            var dbc = GetNewDbcFullPath();

            using(var connection = this.fixture.CreateConnection()) {
                var tables = connection.GetSchema(VfpConnection.SchemaNames.Tables);
                var dbcCreator = new DataTableDbcCreator(dbc);

                tables.TableName = "temp";

                dbcCreator.Add(tables);
            }

            return dbc;
        }

        private string GetNewDbcFullPath() {
            var directory = Path.Combine(Path.GetDirectoryName(this.fixture.DataDirectory), Guid.NewGuid().ToString().Substring(0, 8));

            Directory.CreateDirectory(directory);

            return Path.Combine(directory, "Sample.dbc");
        }
    }
}