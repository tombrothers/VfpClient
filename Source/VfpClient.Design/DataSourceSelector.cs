using System;
using System.Data;
using Microsoft.VisualStudio.Data.Framework.AdoDotNet;
using Microsoft.VisualStudio.Data.Services;
using Microsoft.VisualStudio.Data.Services.SupportEntities;

namespace VfpClient.Design {
    internal class DataSourceSelector : AdoDotNetObjectSelector {
        public DataSourceSelector() {
        }

        public DataSourceSelector(IVsDataConnection connection)
            : base(connection) {
        }

        protected override IVsDataReader SelectObjects(string typeName, object[] restrictions, string[] properties, object[] parameters) {
            VfpClientTracing.Tracer.TraceVerbose(String.Format("DataSourceSelector.SelectObjects typeName={0}", typeName));

            var dataTable = new DataTable();

            dataTable.Columns.Add("Name");

            var connectionStringBuilder = new VfpConnectionStringBuilder(Site.DisplayConnectionString);

            dataTable.Rows.Add(connectionStringBuilder.DataSource);

            return new AdoDotNetReader(dataTable.CreateDataReader());
        }
    }
}