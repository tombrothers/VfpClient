using System.ComponentModel.Design;
using Microsoft.VisualStudio.Data.Framework;

namespace VfpClient.Design {
    internal class DataViewQueryCommandProvider : DataViewCommandProvider {
        protected override MenuCommand CreateCommand(int itemId, CommandID commandId, object[] parameters) {
            MenuCommand command = null;

            command = new DataViewMenuCommand(itemId, commandId, delegate { Test(); });

            if (command == null) {
                command = base.CreateCommand(itemId, commandId, parameters);
            }

            return command;
        }

        private void Test() {
        }
    }
}