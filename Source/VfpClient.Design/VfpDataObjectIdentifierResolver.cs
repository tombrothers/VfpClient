using System;
using System.IO;
using Microsoft.VisualStudio.Data.Framework;

namespace VfpClient.Design {
    internal class VfpDataObjectIdentifierResolver : DataObjectIdentifierResolver {
        public override object[] ExpandIdentifier(string typeName, object[] partialIdentifier) {
            if (typeName == null) {
                throw new ArgumentNullException("typeName");
            }

            var length = GetArrayLength(typeName);
            var identifier = new object[length];

            if (partialIdentifier != null) {
                if (partialIdentifier.Length > length) {
                    throw new InvalidOperationException();
                }

                partialIdentifier.CopyTo(identifier, length - partialIdentifier.Length);
            }

            FixIdentifier(typeName, identifier);

            return identifier;
        }

        private static void FixIdentifier(string typeName, object[] identifier) {
            switch (typeName) {
                case VfpDataObjectTypes.Root:
                    break;
                case VfpDataObjectTypes.Table:
                case VfpDataObjectTypes.View:
                    identifier[2] = Path.GetExtension((string)identifier[2]).Substring(1);
                    break;
                //case VfpDataObjectTypes.TableField:
                //case VfpDataObjectTypes.Index:
                //case VfpDataObjectTypes.ForeignKey:
                //case VfpDataObjectTypes.ViewField:
                //    return 4;
                //case VfpDataObjectTypes.IndexColumn:
                //case VfpDataObjectTypes.ForeignKeyColumn:
                //    return 5;
                default:
                    throw new NotSupportedException();
            }
        }

        private static int GetArrayLength(string typeName) {
            switch (typeName) {
                case VfpDataObjectTypes.Root:
                    return 0;
                case VfpDataObjectTypes.Table:
                case VfpDataObjectTypes.View:
                    return 3;
                case VfpDataObjectTypes.TableField:
                case VfpDataObjectTypes.Index:
                case VfpDataObjectTypes.ForeignKey:
                case VfpDataObjectTypes.ViewField:
                    return 4;
                case VfpDataObjectTypes.IndexColumn:
                case VfpDataObjectTypes.ForeignKeyColumn:
                    return 5;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}