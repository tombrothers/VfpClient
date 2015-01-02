using System.Linq;
using System.Text;

namespace VfpClient.Utils.DbcCreator {
    internal static class VfpCodeTableConverter {
        public static string GetVfpCode(Table table) {
            ArgumentUtility.CheckNotNull("table", table);

            if (string.IsNullOrEmpty(table.Name)) {
                throw new VfpException("Missing Table Name");
            }

            if (table.Fields == null || !table.Fields.Any()) {
                throw new VfpException("Missing Fields");
            }

            var builder = new StringBuilder();

            builder.Append("CREATE TABLE '");
            builder.Append(table.Name);
            builder.Append("'(");

            foreach (var field in table.Fields) {
                builder.Append(VfpCodeFieldConverter.GetVfpCode(field));
                builder.Append(",");
            }

            builder.Length = builder.Length - 1;
            builder.Append(")");

            return builder.ToString();
        }
    }
}