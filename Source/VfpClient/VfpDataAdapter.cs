using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;

namespace VfpClient {
    public class VfpDataAdapter : DbDataAdapter, ICloneable {
        private readonly VfpConnection _vfpConnection;

        public new VfpCommand DeleteCommand {
            get { return (VfpCommand)base.DeleteCommand; }
            set { base.DeleteCommand = value; }
        }

        public new VfpCommand InsertCommand {
            get { return (VfpCommand)base.InsertCommand; }
            set { base.InsertCommand = value; }
        }

        public new VfpCommand SelectCommand {
            get { return (VfpCommand)base.SelectCommand; }
            set { base.SelectCommand = value; }
        }

        public new VfpCommand UpdateCommand {
            get { return (VfpCommand)base.UpdateCommand; }
            set { base.UpdateCommand = value; }
        }

        public event VfpRowUpdatingEventHandler RowUpdating;
        public event VfpRowUpdatedEventHandler RowUpdated;

        internal VfpDataAdapter(VfpDataAdapter other) {
            SelectCommand = (VfpCommand)((ICloneable)other.SelectCommand).Clone();
            _vfpConnection = other._vfpConnection;
        }

        public VfpDataAdapter() {
            _vfpConnection = null;
        }

        public VfpDataAdapter(VfpCommand selectCommand) {
            _vfpConnection = null;
            SelectCommand = selectCommand;
        }

        public VfpDataAdapter(string selectCommandText, VfpConnection selectCommandConnection) {
            _vfpConnection = selectCommandConnection;
            SelectCommand = new VfpCommand(selectCommandText, selectCommandConnection);
        }

        public VfpDataAdapter(string selectCommandText, string selectCommandConnection) {
            _vfpConnection = new VfpConnection(selectCommandConnection);
            SelectCommand = new VfpCommand(selectCommandText, _vfpConnection);
        }

        protected override int Fill(DataTable[] dataTables, IDataReader dataReader, int startRecord, int maxRecords) {
            var result = VfpCommand.Execute(SelectCommand,
                                 VfpCommandMethod.DataAdapterFill,
                                 () => base.Fill(dataTables, new VfpDataReader((DbDataReader)dataReader), startRecord, maxRecords));

            foreach (var dataTable in dataTables) {
                TrimEndAllStringColumn(dataTable);
            }

            return result;
        }

        private static void TrimEndAllStringColumn(DataTable dataTable) {
            if (dataTable.Columns.Count == 0 || dataTable.Rows.Count == 0) {
                return;
            }

            foreach (DataColumn dataColumn in dataTable.Columns) {
                if (dataColumn.DataType != typeof(string)) {
                    continue;
                }

                foreach (var dataRow in dataTable.Rows.Cast<DataRow>().Where(dataRow => !dataRow.IsNull(dataColumn))) {
                    dataRow[dataColumn.ColumnName] = dataRow[dataColumn.ColumnName].ToString().TrimEnd();
                }
            }

            dataTable.AcceptChanges();
        }

        public override int Fill(DataSet dataSet) {
            try {
                return base.Fill(dataSet);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType) {
            try {
                return base.FillSchema(dataSet, schemaType);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override IDataParameter[] GetFillParameters() {
            try {
                return base.GetFillParameters();
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public new int Update(DataTable dataTable) {
            try {
                return base.Update(dataTable);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public override int Update(DataSet dataSet) {
            try {
                return base.Update(dataSet);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public new int Update(DataSet dataSet, string tableName) {
            try {
                return base.Update(dataSet, tableName);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        public new int Update(DataRow[] dataRows) {
            try {
                return base.Update(dataRows);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        protected override int Update(DataRow[] dataRows, DataTableMapping tableMapping) {
            try {
                return base.Update(dataRows, tableMapping);
            }
            catch (OleDbException e) {
                throw new VfpException(e.Message, e);
            }
        }

        object ICloneable.Clone() {
            return new VfpDataAdapter(this);
        }

        protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping) {
            return new VfpRowUpdatedEventArgs(dataRow, command, statementType, tableMapping);
        }

        protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping) {
            return new VfpRowUpdatingEventArgs(dataRow, command, statementType, tableMapping);
        }

        protected override void OnRowUpdating(RowUpdatingEventArgs rowUpdatingEventArgs) {
            var rowUpdating = RowUpdating;
            var vfpRowUpdatingEventArgs = rowUpdatingEventArgs as VfpRowUpdatingEventArgs;

            if (rowUpdating != null && vfpRowUpdatingEventArgs != null) {
                rowUpdating(this, (vfpRowUpdatingEventArgs));
            }

            base.OnRowUpdating(rowUpdatingEventArgs);
        }

        protected override void OnRowUpdated(RowUpdatedEventArgs rowUpdatedEventArgs) {
            var rowUpdated = RowUpdated;
            var vfpRowUpdatedEventArgs = rowUpdatedEventArgs as VfpRowUpdatedEventArgs;

            if (rowUpdated != null && vfpRowUpdatedEventArgs != null) {
                rowUpdated(this, vfpRowUpdatedEventArgs);
            }

            base.OnRowUpdated(rowUpdatedEventArgs);
        }
    }
}