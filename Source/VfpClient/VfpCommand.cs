using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Threading;
using VfpClient.Utils;

namespace VfpClient {
    public partial class VfpCommand : DbCommand, ICloneable {
        private static int _globalCommandId;
        private VfpTransaction _vfpTransaction;
        private VfpConnection _vfpConnection;
        private readonly VfpCommandParameterRewritter _vfpCommandParameterRewritter;
        protected internal OleDbCommand OleDbCommand { get; private set; }
        public int CommandId { get; private set; }

        public override string CommandText {
            get { return OleDbCommand.CommandText; }
            set { OleDbCommand.CommandText = value; }
        }

        public override int CommandTimeout {
            get { return OleDbCommand.CommandTimeout; }
            set { OleDbCommand.CommandTimeout = value; }
        }

        public override CommandType CommandType {
            get { return OleDbCommand.CommandType; }
            set { OleDbCommand.CommandType = value; }
        }

        public new VfpConnection Connection {
            get { return (VfpConnection)DbConnection; }
            set { DbConnection = value; }
        }

        protected override DbConnection DbConnection {
            get { return _vfpConnection; }
            set {
                if (value == null) {
                    _vfpConnection = null;
                    OleDbCommand.Connection = null;
                }
                else {
                    _vfpConnection = (VfpConnection)value;
                    OleDbCommand.Connection = _vfpConnection.OleDbConnection;
                }
            }
        }

        protected override DbParameterCollection DbParameterCollection {
            get { return Parameters; }
        }

        public new VfpParameterCollection Parameters {
            get { return new VfpParameterCollection(OleDbCommand.Parameters); }
        }

        public new VfpTransaction Transaction {
            get { return (VfpTransaction)DbTransaction; }
            set { DbTransaction = value; }
        }

        protected override DbTransaction DbTransaction {
            get { return _vfpTransaction; }
            set {
                _vfpTransaction = (VfpTransaction)value;

                if (_vfpTransaction != null) {
                    OleDbCommand.Transaction = _vfpTransaction.OleDbTransaction;
                }
            }
        }

        public override bool DesignTimeVisible {
            get { return OleDbCommand.DesignTimeVisible; }
            set { OleDbCommand.DesignTimeVisible = value; }
        }

        public override UpdateRowSource UpdatedRowSource {
            get { return OleDbCommand.UpdatedRowSource; }
            set { OleDbCommand.UpdatedRowSource = value; }
        }

        protected internal VfpCommand(VfpCommand vfpCommand)
            : this(vfpCommand.OleDbCommand.Clone(), vfpCommand._vfpConnection) {
        }

        public VfpCommand()
            : this(new OleDbCommand(), null) {
        }

        public VfpCommand(string commandText)
            : this(new OleDbCommand(commandText), null) {
        }

        public VfpCommand(string commandText, VfpConnection vfpConnection)
            : this(new OleDbCommand(commandText), vfpConnection) {
        }

        protected internal VfpCommand(OleDbCommand oleDbCommand, VfpConnection vfpConnection) {
            CommandId = Interlocked.Increment(ref _globalCommandId);
            _vfpCommandParameterRewritter = new VfpCommandParameterRewritter();
            OleDbCommand = oleDbCommand;
            Connection = vfpConnection;

            if (OleDbCommand.Transaction != null) {
                _vfpTransaction = new VfpTransaction(OleDbCommand.Transaction, _vfpConnection);
            }
        }

        public override void Cancel() {
            try {
                OleDbCommand.Cancel();
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        protected override DbParameter CreateDbParameter() {
            return new VfpParameter(OleDbCommand.CreateParameter());
        }

        public new VfpParameter CreateParameter() {
            return (VfpParameter)CreateDbParameter();
        }

        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior) {
            return Execute(vfpCommand => new VfpDataReader(vfpCommand.OleDbCommand.ExecuteReader(behavior)), VfpCommandMethod.ExecuteReader);
        }

        public new VfpDataReader ExecuteReader() {
            return Execute(vfpCommand => new VfpDataReader(vfpCommand.OleDbCommand.ExecuteReader()), VfpCommandMethod.ExecuteReader);
        }

        public new VfpDataReader ExecuteReader(CommandBehavior behavior) {
            return Execute(vfpCommand => (VfpDataReader)vfpCommand.ExecuteDbDataReader(behavior), VfpCommandMethod.ExecuteReader);
        }

        public override int ExecuteNonQuery() {
            return Execute(vfpCommand => vfpCommand.OleDbCommand.ExecuteNonQuery(), VfpCommandMethod.ExecuteNonQuery);
        }

        public override object ExecuteScalar() {
            return Execute(vfpCommand => vfpCommand.OleDbCommand.ExecuteScalar(), VfpCommandMethod.ExecuteScalar);
        }

        private T Execute<T>(Func<VfpCommand, T> executeFunc, VfpCommandMethod method) {
            var vfpCommand = GetCommand();

            if (VfpClientTracing.Tracer.HasSourceLevel(SourceLevels.Information)) {
                return ExecuteWithTracing(vfpCommand, method, () => executeFunc(vfpCommand));
            }

            return ExecuteWithoutTracing(() => executeFunc(vfpCommand));
        }

        internal static T Execute<T>(VfpCommand vfpCommand, VfpCommandMethod method, Func<T> executeFunc) {
            if (VfpClientTracing.Tracer.HasSourceLevel(SourceLevels.Information)) {
                return ExecuteWithTracing(vfpCommand, method, executeFunc);
            }

            return ExecuteWithoutTracing(executeFunc);
        }

        private static T ExecuteWithoutTracing<T>(Func<T> executeFunc) {
            try {
                return executeFunc();
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        private static T ExecuteWithTracing<T>(VfpCommand vfpCommand, VfpCommandMethod method, Func<T> executeFunc) {
            var executionEventArgs = new VfpCommandExecutionDetails(vfpCommand, method);

            executionEventArgs.Status = VfpCommandExecutionStatus.Executing;
            vfpCommand.Connection.RaiseExecuting(executionEventArgs);

            var sw = new Stopwatch();

            try {
                try {
                    sw.Start();

                    var result = executeFunc();

                    sw.Stop();
                    executionEventArgs.Result = result;
                    executionEventArgs.Duration = sw.Elapsed;
                    executionEventArgs.Status = VfpCommandExecutionStatus.Finished;
                    vfpCommand.Connection.RaiseFinished(executionEventArgs);

                    return result;
                }
                catch (OleDbException oleDbException) {
                    throw new VfpException(oleDbException.Message, oleDbException);
                }
            }
            catch (Exception ex) {
                executionEventArgs.Result = ex;
                executionEventArgs.Status = VfpCommandExecutionStatus.Failed;
                vfpCommand.Connection.RaiseFailed(executionEventArgs);

                throw;
            }
        }

        private VfpCommand GetCommand() {
            if (Parameters.Count == 0) {
                return this;
            }

            var vfpCommand = new VfpCommand(this);

            _vfpCommandParameterRewritter.Rewrite(vfpCommand);

            return vfpCommand;
        }

        public override void Prepare() {
            try {
                OleDbCommand.Prepare();
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        object ICloneable.Clone() {
            return new VfpCommand(this);
        }

        public string ToVfpCode() {
            return VfpCodeBuilder.Build(this);
        }
    }
}