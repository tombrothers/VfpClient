using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using VfpClient.Utils;

namespace VfpClient {
    public partial class VfpConnection : DbConnection {
        protected internal OleDbConnection OleDbConnection { get; private set; }
        private readonly VfpConnectionStringBuilder _vfpConnectionStringBuilder;
        private readonly SchemaManager _schemaManager;
        public Action<VfpCommandExecutionDetails> CommandExecuting;
        public Action<VfpCommandExecutionDetails> CommandFinished;
        public Action<VfpCommandExecutionDetails> CommandFailed;

        public override string ConnectionString {
            get { return _vfpConnectionStringBuilder.ConnectionString; }
            set {
                if (State != ConnectionState.Closed) {
                    throw new VfpException(Resources.VfpConnection_CannotChangeConnectionString);
                }

                SetConnectionString(value);
            }
        }

        public bool IsDbc {
            get { return _vfpConnectionStringBuilder.IsDbc; }
        }

        public override int ConnectionTimeout {
            get { return OleDbConnection.ConnectionTimeout; }
        }

        public override string DataSource {
            get { return _vfpConnectionStringBuilder.DataSource; }
        }

        public override string Database {
            get { return IsDbc ? _vfpConnectionStringBuilder.Database : string.Empty; }
        }

        public override string ServerVersion {
            get { return OleDbConnection.ServerVersion; }
        }

        public override ConnectionState State {
            get { return OleDbConnection.State; }
        }

        protected override DbProviderFactory DbProviderFactory {
            get { return VfpClientFactory.Instance; }
        }

        public VfpConnection()
            : this(null) {
        }

        public VfpConnection(string connectionString) {
            _vfpConnectionStringBuilder = new VfpConnectionStringBuilder();
            OleDbConnection = new OleDbConnection();
            OleDbConnection.StateChange += OleDbConnection_StateChange;

            SetConnectionString(connectionString);
            _schemaManager = new SchemaManager(this);

            CommandExecuting = details => VfpClientTracing.Tracer.TraceInformation(details.ToTraceString());
            CommandFailed = details => VfpClientTracing.Tracer.TraceError(details.ToTraceString());
            CommandFinished = details => VfpClientTracing.Tracer.TraceInformation(details.ToTraceString());
        }

        void OleDbConnection_StateChange(object sender, StateChangeEventArgs e) {
            this.OnStateChange(e);
        }

        private void SetConnectionString(string connectionString) {
            _vfpConnectionStringBuilder.ConnectionString = connectionString;

            var oleDbConnectionStringBuilder = new OleDbConnectionStringBuilder(_vfpConnectionStringBuilder.ConnectionString) {
                Provider = "VFPOLEDB"
            };

            OleDbConnection.ConnectionString = oleDbConnectionStringBuilder.ConnectionString;
        }

        public new VfpTransaction BeginTransaction() {
            return (VfpTransaction)base.BeginTransaction();
        }

        public new VfpTransaction BeginTransaction(IsolationLevel isolationLevel) {
            return (VfpTransaction)base.BeginTransaction(isolationLevel);
        }

        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel) {
            try {
                var oleDbTransaction = OleDbConnection.BeginTransaction(isolationLevel);
                var vfpTransaction = new VfpTransaction(oleDbTransaction, this);

                return vfpTransaction;
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override void ChangeDatabase(string databaseName) {
            if (databaseName.Equals(Database)) {
                return;
            }

            if (State == ConnectionState.Closed) {
                throw new VfpException(Resources.VfpConnection_CannotChangeDatabase);
            }

            Close();
            _vfpConnectionStringBuilder.DataSource = databaseName;
            ConnectionString = _vfpConnectionStringBuilder.ConnectionString;
            Open();
        }

        public override void Close() {
            try {
                OleDbConnection.Close();
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public new VfpCommand CreateCommand() {
            return (VfpCommand)CreateDbCommand();
        }

        protected override DbCommand CreateDbCommand() {
            return new VfpCommand(OleDbConnection.CreateCommand(), this);
        }

        public override DataTable GetSchema() {
            try {
                return _schemaManager.GetSchema();
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override DataTable GetSchema(string collectionName) {
            try {
                return _schemaManager.GetSchema(collectionName, null);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override DataTable GetSchema(string collectionName, string[] restrictionValues) {
            try {
                return _schemaManager.GetSchema(collectionName, restrictionValues);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override void Open() {
            try {
                if (String.IsNullOrWhiteSpace(OleDbConnection.ConnectionString)) {
                    SetConnectionString(_vfpConnectionStringBuilder.ConnectionString);
                }

                OleDbConnection.Open();

                if (!_vfpConnectionStringBuilder.Null) {
                    using (var command = CreateCommand()) {
                        command.CommandText = "SET NULL OFF";
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override void EnlistTransaction(System.Transactions.Transaction transaction) {
            try {
                OleDbConnection.EnlistTransaction(transaction);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                OleDbConnection.StateChange -= OleDbConnection_StateChange;
                OleDbConnection.Dispose();
            }

            base.Dispose(disposing);
        }

        public void Pack(string tableName) {
            ArgumentUtility.CheckNotNullOrEmpty("tableName", tableName);

            ExecuteScript(String.Format(Resources.PackTable, tableName));
        }

        public void Zap(string tableName) {
            ArgumentUtility.CheckNotNullOrEmpty("tableName", tableName);

            ExecuteScript(String.Format(Resources.ZapTable, tableName));
        }

        public void ExecuteScript(string vfpCode) {
            using (var command = CreateCommand()) {
                command.CommandText = "ExecScript";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new VfpParameter("x", vfpCode));

                DoConnected(() => command.ExecuteNonQuery());
            }
        }

        public void DoConnected(Action action) {
            ArgumentUtility.CheckNotNull("action", action);

            var closeConnection = false;

            if (State == ConnectionState.Closed) {
                Open();
                closeConnection = true;
            }
            try {
                action();
            }
            finally {
                if (closeConnection) {
                    Close();
                }
            }
        }

        internal void RaiseExecuting(VfpCommandExecutionDetails executionEventArgs) {
            RaiseExecutionAction(CommandExecuting, executionEventArgs);
        }

        internal void RaiseFinished(VfpCommandExecutionDetails executionEventArgs) {
            RaiseExecutionAction(CommandFinished, executionEventArgs);
        }

        internal void RaiseFailed(VfpCommandExecutionDetails executionEventArgs) {
            RaiseExecutionAction(CommandFailed, executionEventArgs);
        }

        private static void RaiseExecutionAction(Action<VfpCommandExecutionDetails> action, VfpCommandExecutionDetails executionEventArgs) {
            if (action == null) {
                return;
            }

            action(executionEventArgs);
        }
    }
}