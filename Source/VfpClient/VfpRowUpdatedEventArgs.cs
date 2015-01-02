using System.Data;
using System.Data.Common;

namespace VfpClient {
    public sealed class VfpRowUpdatedEventArgs : RowUpdatedEventArgs {
        public VfpRowUpdatedEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
            : base(row, command, statementType, tableMapping) {
        }

        public new VfpCommand Command {
            get { return base.Command as VfpCommand; }
        }
    }
}