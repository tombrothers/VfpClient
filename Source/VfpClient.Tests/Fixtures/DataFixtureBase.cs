using System;
using System.Data;
using System.IO;
using System.Reflection;
using static System.String;

namespace VfpClient.Tests.Fixtures {
    public abstract class DataFixtureBase : IDisposable {
        protected static readonly string RootDirectory;
        public string DataDirectory { get; }

        static DataFixtureBase() {
            RootDirectory = Path.GetDirectoryName(typeof(DataFixtureBase).GetTypeInfo().Assembly.Location);
        }

        protected DataFixtureBase() {
            this.DataDirectory = Path.Combine(RootDirectory, $"Data-{Guid.NewGuid().ToString().Substring(0, 8)}");

            Directory.CreateDirectory(this.DataDirectory);
        }

        public void ExecuteReader(string sql, Action<VfpDataReader> action) {
            ExecuteCommand(command => {
                command.CommandText = sql;

                using(var reader = command.ExecuteReader()) {
                    action(reader);
                }
            });
        }

        public void ExecuteCommand(string sql, Action<VfpCommand> action) {
            using(var connection = CreateConnection()) {
                using(var command = connection.CreateCommand()) {
                    command.CommandText = sql;

                    action(command);
                }
            }
        }

        public void ExecuteCommand(Action<VfpCommand> action) {
            using(var connection = CreateConnection()) {
                using(var command = connection.CreateCommand()) {
                    command.CommandType = CommandType.Text;

                    action(command);
                }
            }
        }

        public VfpConnection CreateConnection() {
            var connection = new VfpConnection(this.GetConnectionString());

            connection.Open();

            return connection;
        }

        protected virtual string GetConnectionString() => this.DataDirectory;

        public void Dispose() {
            if(IsNullOrWhiteSpace(this.DataDirectory) || !Directory.Exists(this.DataDirectory)) {
                return;
            }

            try {
                Directory.Delete(this.DataDirectory, true);
            }
            catch { 
            
            }
        }
    }
}
