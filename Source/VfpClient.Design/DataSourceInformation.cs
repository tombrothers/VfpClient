using System;
using System.IO;
using Microsoft.VisualStudio.Data.Framework.AdoDotNet;

namespace VfpClient.Design {
    internal class DataSourceInformation : AdoDotNetSourceInformation {
        protected override object RetrieveValue(string propertyName) {
            VfpClientTracing.Tracer.TraceVerbose(String.Format("DataSourceInformation.RetrieveValue propertyName={0}", propertyName));

            switch (propertyName) { 
                case "DefaultCatalog":
                    var vfpConnection = (VfpConnection)Connection;

                    if (vfpConnection.IsDbc) {
                        return Path.GetFileNameWithoutExtension(vfpConnection.Database);
                    }

                    break;
            }

            try {
                var value = base.RetrieveValue(propertyName);

                VfpClientTracing.Tracer.TraceVerbose(String.Format("DataSourceInformation.RetrieveValue propertyName={0} | value={1}", propertyName, value));

                return value;
            }
            catch (Exception ex) {
                VfpClientTracing.Tracer.TraceError(ex);
                
                throw;
            }
        }
    }
}