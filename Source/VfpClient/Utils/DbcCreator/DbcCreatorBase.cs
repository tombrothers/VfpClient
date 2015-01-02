using System;
using System.Data;
using System.IO;
using System.Linq;

namespace VfpClient.Utils.DbcCreator {
    public abstract class DbcCreatorBase<T> : IDisposable {
        protected bool _disposed;
        protected readonly VfpConnection _connection;
        protected readonly ITableConverter<T> _tableConverter;
        protected readonly IDbcFilesProvider _dbcFilesProvider;
        public string DbcPath { get; private set; }

        protected DbcCreatorBase(string dbcPath, ITableConverter<T> tableConverter, IDbcFilesProvider dbcFilesProvider) {
            DbcPath = ArgumentUtility.CheckNotNullOrEmpty("dbcPath", dbcPath);
            _tableConverter = ArgumentUtility.CheckNotNull("tableConverter", tableConverter);
            _dbcFilesProvider = ArgumentUtility.CheckNotNull("dbcFilesProvider", dbcFilesProvider);

            CreateDbc(dbcFilesProvider);
            _connection = new VfpConnection("provider=vfpoledb;exclusive=off;OLE DB Services=0;data source=" + DbcPath);
        }

        public virtual void Add(T source) {
            Add(source, _tableConverter.Convert(source));
        }

        public virtual void Add(T source, Table table) {
            CreateTable(table);
            CreateIndexes(table);
        }

        protected void CreateTable(Table table) {
            using (var command = _connection.CreateCommand()) {
                command.CommandText = VfpCodeTableConverter.GetVfpCode(table);

                _connection.DoConnected(() => command.ExecuteNonQuery());
            }
        }

        protected void CreateIndexes(Table table) {
            if (!table.Indexes.Any()) {
                return;
            }

            IndexNameFixer.Evaluate(table.Indexes);

            foreach (var index in table.Indexes) {
                CreateIndex(table, index);
            }
        }

        private void CreateIndex(Table table, Index index) {
            using (var command = _connection.CreateCommand()) {
                command.CommandText = VfpCodeIndexConverter.GetVfpCode(table, index);

                _connection.DoConnected(() => command.ExecuteNonQuery());
            }
        }

        private void CreateDbc(IDbcFilesProvider dbcFilesProvider) {
            EnsureDirectoryExists();

            File.WriteAllBytes(DbcPath, dbcFilesProvider.Dbc);
            File.WriteAllBytes(Path.ChangeExtension(DbcPath, "dct"), dbcFilesProvider.Dct);
            File.WriteAllBytes(Path.ChangeExtension(DbcPath, "dcx"), dbcFilesProvider.Dcx);
        }

        private void EnsureDirectoryExists() {
            var directory = Path.GetDirectoryName(DbcPath);

            VfpClientTracing.Tracer.TraceVerbose("DbcCreatorBase - DbcPath - " + DbcPath);

            if (directory == null || Directory.Exists(directory)) {
                return;
            }

            Directory.CreateDirectory(directory);
        }

        ~DbcCreatorBase() {
            Dispose(false);
        }

        void IDisposable.Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (_disposed) {
                return;
            }

            _disposed = true;

            if (!disposing || _connection == null) {
                return;
            }

            if (_connection.State == ConnectionState.Open) {
                _connection.Close();
            }

            _connection.Dispose();
        }
    }
}