using Microsoft.VisualStudio.Data.Framework.AdoDotNet;

namespace VfpClient.Design {
    internal class VfpConnectionProperties : AdoDotNetConnectionProperties {
        public override bool IsComplete {
            get {
                if (!ConnectionStringBuilder.ContainsKey("Data Source")) {
                    return false;
                }

                if (ConnectionStringBuilder["Data Source"] is string && (ConnectionStringBuilder["Data Source"] as string).Length > 0) {
                    return true;
                }

                return false;
            }
        }

        public override bool IsExtensible {
            get {
                return false;
            }
        }
    }
}