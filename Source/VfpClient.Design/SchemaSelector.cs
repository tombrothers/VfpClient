using System;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.Data.Framework.AdoDotNet;
using Microsoft.VisualStudio.Data.Services;
using Microsoft.VisualStudio.Data.Services.SupportEntities;

namespace VfpClient.Design {
    internal class SchemaSelector : AdoDotNetObjectSelector {
        public SchemaSelector() {
        }

        public SchemaSelector(IVsDataConnection connection)
            : base(connection) {
        }

        protected override IVsDataReader SelectObjects(string typeName, object[] restrictions, string[] properties, object[] parameters) {
            if (typeName == null) {
                throw new ArgumentNullException("typeName");
            }

            VfpClientTracing.Tracer.TraceVerbose(string.Format("{0} typeName={1}", MethodBase.GetCurrentMethod().Name, typeName));
            VfpConnection vfpConnection = Site.GetLockedProviderObject() as VfpConnection;

            if (vfpConnection == null) {
                throw new NotSupportedException();
            }

            try {
                // Ensure the connection is open
                if (Site.State != DataConnectionState.Open) {
                    Site.Open();
                }

                var dataTable = vfpConnection.GetSchema(GetSchemaName(typeName), GetRestrictionsStringArray(restrictions));

                return new AdoDotNetReader(dataTable.CreateDataReader());
            }
            finally {
                Site.UnlockProviderObject();
            }
        }

        private static string GetSchemaName(string typeName) {
            switch (typeName.ToLower()) {
                case "table":
                    return "Tables";
                default:
                    return typeName;
            }
        }

        private static string[] GetRestrictionsStringArray(object[] restrictions) {
            return restrictions == null ? null : restrictions.Cast<string>().ToArray();
        }
    }
}