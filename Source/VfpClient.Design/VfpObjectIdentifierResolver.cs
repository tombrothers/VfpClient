using System;
using System.Diagnostics;
using Microsoft.VisualStudio.Data.Services;
using Microsoft.VisualStudio.Data.Framework;
using Microsoft.VisualStudio.Data.Services.SupportEntities;

namespace VfpClient.Design {
    internal class VfpObjectIdentifierResolver : DataObjectIdentifierResolver {
        public override object[] ExpandIdentifier(string typeName, object[] partialIdentifier) {
            if (typeName == null) {
                throw new ArgumentNullException("typeName");
            }

            VfpClientTracing.Tracer.TraceVerbose("VfpObjectIdentifierResolver-ExpandIdentifier-typeName = " + typeName);

            // Find the type in the data object support model
            IVsDataObjectType type = null;
            var objectSupportModel = Site.GetService(typeof(IVsDataObjectSupportModel)) as IVsDataObjectSupportModel;

            Debug.Assert(objectSupportModel != null);
            if (objectSupportModel != null &&
                objectSupportModel.Types.ContainsKey(typeName)) {
                type = objectSupportModel.Types[typeName];
            }
            if (type == null) {
                throw new ArgumentException("Invalid type " + typeName + ".");
            }

            // Create an identifier array of the correct full length
            var identifier = new object[type.Identifier.Count];

            // If the input identifier is not null, copy it to the full
            // identifier array.  If the input identifier's length is less
            // than the full length we assume the more specific parts are
            // specified and thus copy into the rightmost portion of the
            // full identifier array.
            if (partialIdentifier != null) {
                if (partialIdentifier.Length > type.Identifier.Count) {
                    throw new ArgumentException("Invalid partial identifier.");
                }

                partialIdentifier.CopyTo(identifier, type.Identifier.Count - partialIdentifier.Length);
            }

            // Get the data source information service
            IVsDataSourceInformation sourceInformation = Site.GetService(typeof(IVsDataSourceInformation)) as IVsDataSourceInformation;

            Debug.Assert(sourceInformation != null);

            if (sourceInformation == null) {
                // This should never occur
                return identifier;
            }

            // Now expand the identifier as required
            if (type.Identifier.Count > 0) {
                // Fill in the current database if not specified
                if (!(identifier[0] is string)) {
                    identifier[0] = sourceInformation[DataSourceInformation.DefaultCatalog] as string;
                }
            }

            if (type.Identifier.Count > 1) {
                // Fill in the default schema if not specified
                if (!(identifier[1] is string)) {
                    identifier[1] = sourceInformation[DataSourceInformation.DefaultSchema] as string;
                }
            }

            return identifier;
        }
    }
}