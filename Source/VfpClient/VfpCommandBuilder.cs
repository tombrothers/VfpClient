using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Globalization;
using System.Reflection;

namespace VfpClient {
    public class VfpCommandBuilder : DbCommandBuilder {
        public override string QuotePrefix {
            get { return string.Empty; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    throw new VfpException(Resources.VfpCommandBuilder_InvalidQuotePrefix);
                }

                base.QuotePrefix = value ?? string.Empty;
            }
        }

        public override string QuoteSuffix {
            get { return string.Empty; }
            set {
                if (!string.IsNullOrEmpty(value)) {
                    throw new VfpException(Resources.VfpCommandBuilder_InvalidQuoteSuffix);
                }

                base.QuoteSuffix = value ?? string.Empty;
            }
        }

        public new VfpDataAdapter DataAdapter {
            get { return base.DataAdapter as VfpDataAdapter; }
            set { base.DataAdapter = value; }
        }

        public VfpCommandBuilder() {
        }

        public VfpCommandBuilder(VfpDataAdapter adapter) {
            DataAdapter = adapter;
        }

        public override string QuoteIdentifier(string unquotedIdentifier) {
            return unquotedIdentifier;
        }

        public override string UnquoteIdentifier(string quotedIdentifier) {
            return quotedIdentifier;
        }

        protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause) {
            var vfpParameter = (VfpParameter)parameter;

            vfpParameter.VfpType = ((OleDbType)row.Field<int>(SchemaTableColumn.ProviderType)).ToVfpType();
        }

        protected override string GetParameterName(string parameterName) {
            return "@" + parameterName;
        }

        protected override DataTable GetSchemaTable(DbCommand sourceCommand) {
            var vfpCommand = (VfpCommand)sourceCommand;

            using (var vfpDataReader = vfpCommand.ExecuteReader(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo)) {
                return vfpDataReader.GetSchemaTable();
            }
        }

        protected override string GetParameterPlaceholder(int parameterOrdinal) {
            return "@p" + parameterOrdinal.ToString(CultureInfo.InvariantCulture);
        }

        protected override string GetParameterName(int parameterOrdinal) {
            return "@p" + parameterOrdinal.ToString(CultureInfo.InvariantCulture);
        }

        protected override void SetRowUpdatingHandler(DbDataAdapter dbDataAdapter) {
            var vfpDataAdapter = (VfpDataAdapter)dbDataAdapter;

            if (dbDataAdapter == DataAdapter) {
                // removal case
                vfpDataAdapter.RowUpdating -= VfpRowUpdatingHandler;
                vfpDataAdapter.RowUpdated -= VfpRowUpdatedHandler;
            }
            else {
                // adding case
                vfpDataAdapter.RowUpdating += VfpRowUpdatingHandler;
                vfpDataAdapter.RowUpdated += VfpRowUpdatedHandler;
            }
        }

        private static void VfpRowUpdatedHandler(object sender, VfpRowUpdatedEventArgs ruevent) {
            if (ruevent.Status == UpdateStatus.Continue && ruevent.StatementType == StatementType.Insert) { 
                
            }
        }

        private void VfpRowUpdatingHandler(object sender, VfpRowUpdatingEventArgs ruevent) {
            RowUpdatingHandler(ruevent);

            if (ruevent.Errors != null) {
                VfpClientTracing.Tracer.TraceError(string.Format("{0}.{1} : {2}", GetType().Name, MethodBase.GetCurrentMethod().Name, ruevent.Errors));
            }
        }

        public new VfpCommand GetDeleteCommand() {
            return GetDeleteCommand(true);
        }

        public new VfpCommand GetDeleteCommand(bool useColumnsForParameterNames) {
            return (VfpCommand)base.GetDeleteCommand(useColumnsForParameterNames);
        }

        public new VfpCommand GetInsertCommand() {
            return GetInsertCommand(true);
        }

        public new VfpCommand GetInsertCommand(bool useColumnsForParameterNames) {
            return (VfpCommand)base.GetInsertCommand(useColumnsForParameterNames);
        }

        public new VfpCommand GetUpdateCommand() {
            return GetUpdateCommand(true);
        }

        public new VfpCommand GetUpdateCommand(bool useColumnsForParameterNames) {
            return (VfpCommand)base.GetUpdateCommand(useColumnsForParameterNames);
        }
    }
}