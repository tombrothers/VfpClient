using System;
using System.Data;
using System.Linq;
using Microsoft.VisualStudio.Data.Framework.AdoDotNet;

namespace VfpClient.Design {
    internal class VfpMappedObjectConverter : AdoDotNetMappedObjectConverter {
        protected override object ConvertToMappedMember(string typeName, string mappedMemberName, object[] underlyingValues, object[] parameters) {
            if (typeName == null) {
                throw new ArgumentNullException("typeName");
            }

            if (mappedMemberName == null) {
                throw new ArgumentNullException("mappedMemberName");
            }


            if (mappedMemberName.Equals("UserDataType", StringComparison.OrdinalIgnoreCase)) {
                var vfpTypeName = (string)underlyingValues[0];
                var width = underlyingValues[1] is DBNull ? 0 : (int)underlyingValues[1];
                var @decimal = underlyingValues[2] is DBNull ? 0 : (int)underlyingValues[2];

                VfpClientTracing.Tracer.TraceVerbose("VfpMappedObjectConverter-UserDataType-vfpTypeName = " + vfpTypeName);

                return string.Format(vfpTypeName.ToVfpType().ToFieldType(), width, @decimal);
            }

            try {
                VfpClientTracing.Tracer.TraceError(string.Format("VfpMappedObjectConverter.ConvertToMappedMember({0}, {1}, {2}, {3}",
                                                   typeName,
                                                   mappedMemberName,
                                                   underlyingValues == null ? "null" : string.Join("|", underlyingValues.Cast<string>().ToArray()),
                                                   parameters == null ? "null" : string.Join("|", parameters.Cast<string>().ToArray())));

                var result = base.ConvertToMappedMember(typeName, mappedMemberName, underlyingValues, parameters);

                return result;
            }
            catch (Exception ex) {
                VfpClientTracing.Tracer.TraceError(ex);
                return null;
            }
        }

        protected override DbType GetDbTypeFromNativeType(string nativeType) {
            return nativeType.ToVfpType().ToDbType();
        }

        protected override Type GetFrameworkTypeFromNativeType(string nativeType) {
            return nativeType.ToVfpType().ToType();
        }

        protected override int GetProviderTypeFromNativeType(string nativeType) {
            return (int)nativeType.ToVfpType();
        }
    }
}