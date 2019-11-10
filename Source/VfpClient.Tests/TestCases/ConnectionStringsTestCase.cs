namespace VfpClient.Tests.TestCases {
    public class ConnectionStringsTestCase {
        public string ConnectionString { get; }
        public string DataSource { get; }
        public string Database { get; }
        public bool IsDbc { get; }
        public string Provider { get; }
        public string ExpectedConnectionString { get; }

        public ConnectionStringsTestCase(string connectionString, string expectedConnectionString, string dataSource, string database, bool isDbc, string provider) {
            ConnectionString = connectionString;
            ExpectedConnectionString = expectedConnectionString;
            DataSource = dataSource;
            Database = database;
            IsDbc = isDbc;
            Provider = provider;
        }
    }
}
