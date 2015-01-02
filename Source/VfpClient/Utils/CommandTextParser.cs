using System.Linq;

namespace VfpClient.Utils {
    internal static partial class CommandTextParser {
        public static string GetTableName(string commandText) {
            var handler = new CommandTextHandler();
            var evaluator = new TokenEvaluator(handler);

            evaluator.Evaluate(commandText);

            if (handler.Command.Type != "Select") {
                return string.Empty;
            }

            var fromTable = handler.From.Items.FirstOrDefault();

            if (string.IsNullOrEmpty(fromTable) || fromTable.EndsWith(",")) {
                return string.Empty;
            }

            return fromTable;
        }
    }
}