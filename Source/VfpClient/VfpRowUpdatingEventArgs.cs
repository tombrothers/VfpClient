using System.Data;
using System.Data.Common;

namespace VfpClient {
    public sealed class VfpRowUpdatingEventArgs : RowUpdatingEventArgs {
        public VfpRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
            : base(row, command, statementType, tableMapping) {
        }

        public new VfpCommand Command {
            get { return base.Command as VfpCommand; }
            set { base.Command = value; }
        }

        protected override IDbCommand BaseCommand {
            get { return base.BaseCommand; }
            set { base.BaseCommand = value as VfpCommand; }
        }
    }
}