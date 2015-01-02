using System.Data.Common;

namespace VfpClient {
    public class VfpClientFactory : DbProviderFactory {
        public static readonly VfpClientFactory Instance = new VfpClientFactory();

        public override DbCommand CreateCommand() {
            return new VfpCommand();
        }

        public override DbCommandBuilder CreateCommandBuilder() {
            return new VfpCommandBuilder();
        }

        public override DbConnection CreateConnection() {
            return new VfpConnection();
        }

        public override DbConnectionStringBuilder CreateConnectionStringBuilder() {
            return new VfpConnectionStringBuilder();
        }

        public override DbDataAdapter CreateDataAdapter() {
            return new VfpDataAdapter();
        }

        public override DbParameter CreateParameter() {
            return new VfpParameter();
        }
    }
}