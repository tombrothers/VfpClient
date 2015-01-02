using System;
using System.Linq;

namespace VfpClient {
    public class VfpCommandExecutionDetails {
        public int CommandId { get; private set; }
        public VfpCommand Command { get; private set; }
        public VfpCommandMethod Method { get; private set; }
        public VfpCommandExecutionStatus Status { get; internal set; }
        public object Result { get; internal set; }
        public TimeSpan Duration { get; internal set; }

        internal VfpCommandExecutionDetails(VfpCommand command, VfpCommandMethod method) {
            CommandId = command.CommandId;
            Command = command;
            Method = method;
        }

        public string ToTraceString() {
            switch (Status) {
                case VfpCommandExecutionStatus.Executing:
                    return GetExecutingTraceString();
                case VfpCommandExecutionStatus.Finished:
                    return GetFinishedTraceString();
                case VfpCommandExecutionStatus.Failed:
                    return GetFailedTraceString();
                default:
                    throw new ArgumentOutOfRangeException("Unknown VfpCommand.ExecutionStatus:  " + Status);
            }
        }

        private string GetFailedTraceString() {
            return string.Format("[{0}|{1}] - Failed {2}:{3}{4}", DateTime.Now, Method, CommandId, Environment.NewLine, Result); 
        }

        private string GetFinishedTraceString() {
            return string.Format("[{0}|{1}] Finished {2} in {3}:  {4}", DateTime.Now, Method, CommandId, Duration, GetResultString()); 
        }

        private string GetExecutingTraceString() {
            return string.Format("[{0}|{1}] Executing {2}:{3}{4}", DateTime.Now, Method, CommandId, Environment.NewLine, Command.ToVfpCode()); 
        }

        private string GetResultString() {
            switch (Method) {
                case VfpCommandMethod.ExecuteNonQuery:
                case VfpCommandMethod.DataAdapterFill:
                    return GetExecuteRowsAffectedResult();
                case VfpCommandMethod.ExecuteReader:
                    return GetExecuteExecuteReader();
                case VfpCommandMethod.ExecuteScalar:
                    return GetExecuteExecuteScalarResult();
                default:
                    throw new ArgumentOutOfRangeException("Unknown VfpCommand.Method:  " + Method);
            }
        }

        private string GetExecuteExecuteScalarResult() {
            return string.Format("[{0}] {1}", Result.GetType(), Result);
        }

        private string GetExecuteExecuteReader() {
            var dataReader = (VfpDataReader)this.Result;

            return string.Format("[VfpDataReader({0})]",
                                 string.Join(", ", Enumerable.Range(0, dataReader.FieldCount).Select(i => dataReader.GetName(i) + ":" + dataReader.GetDataTypeName(i)).ToArray()));
        }

        private string GetExecuteRowsAffectedResult() {
            return string.Format("{0} rows affected", Result);
        }
    }
}