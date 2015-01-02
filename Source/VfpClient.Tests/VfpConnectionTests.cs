using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VfpClient.Utils.DbcCreator;

namespace VfpClient.Tests {
    [TestClass]
    public class VfpConnectionTests : TestBase {
        [TestMethod]
        public void PackTest() {
            var dbc = CreateTempDbc();
            var builder = new VfpConnectionStringBuilder(dbc);

            builder.Deleted = false;

            using (var connection = new VfpConnection(builder.ConnectionString)) {
                connection.Open();

                using (var command = connection.CreateCommand()) {
                    command.CommandText = "select count(*) from temp";

                    Assert.AreEqual(13, Convert.ToInt32(command.ExecuteScalar()));

                    command.CommandText = "delete from temp where upper(allt(TableName)) == 'CUSTOMERS'";
                    command.ExecuteNonQuery();

                    command.CommandText = "select count(*) from temp";

                    Assert.AreEqual(13, Convert.ToInt32(command.ExecuteScalar()));

                    connection.Pack("temp");

                    command.CommandText = "select count(*) from temp";

                    Assert.AreEqual(12, Convert.ToInt32(command.ExecuteScalar()));
                }

                connection.Close();
            }
        }

        [TestMethod]
        public void ZapTest() {
            var dbc = CreateTempDbc();

            using (var connection = new VfpConnection(dbc)) {
                connection.Open();

                using (var command = connection.CreateCommand()) {
                    command.CommandText = "select count(*) from temp";

                    Assert.AreNotEqual(0, Convert.ToInt32(command.ExecuteScalar()));

                    connection.Zap("temp");

                    Assert.AreEqual(0, Convert.ToInt32(command.ExecuteScalar()));
                }

                connection.Close();
            }
        }

        private string CreateTempDbc() {
            var dbc = GetNewDbcFullPath();

            using (var connection = GetConnection()) {
                var tables = connection.GetSchema(VfpConnection.SchemaNames.Tables);
                var dbcCreator = new DataTableDbcCreator(dbc);

                tables.TableName = "temp";

                dbcCreator.Add(tables);
            }

            return dbc;
        }

        private string GetNewDbcFullPath() {
            var directory = Path.Combine(TestContext.TestDeploymentDir, Guid.NewGuid().ToString());

            Directory.CreateDirectory(directory);

            return Path.Combine(directory, "Sample.dbc");
        }
    }
}