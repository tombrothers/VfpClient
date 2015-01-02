using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Data.ConnectionUI;

namespace VfpClient.Design.ConnectionUI {
    internal abstract class ConnectionPropertiesBase : AdoDotNetConnectionProperties {
        public ConnectionPropertiesBase(string providerName)
            : base(providerName) {
        }

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

        protected override PropertyDescriptor DefaultProperty {
            get {
                return GetProperties(new Attribute[0])["Data Source"];
            }
        }

        public override bool IsExtensible {
            get {
                return false;
            }
        }

        protected override void Inspect(DbConnection connection) {
            if (connection.State != ConnectionState.Closed) {
                return;
            }

            connection.Open();
            connection.Close();
        }
    }
}