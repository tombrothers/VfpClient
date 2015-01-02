using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using VfpClient.Utils;

namespace VfpClient {
    public static class ExtensionMethods {
        public static string ToXmlToCursorFormattedXml(this Array array) {
            return (new ArrayXmlToCursor(array)).Xml;
        }

        public static string ToXmlToCursorFormattedXml(this DataTable dataTable) {
            ArgumentUtility.CheckNotNull("dataTable", dataTable);

            using (var writer = new StringWriter()) {
                var tableNameIsEmpty = string.IsNullOrEmpty(dataTable.TableName);

                if (tableNameIsEmpty) {
                    dataTable.TableName = "VfpData";
                }

                dataTable.WriteXml(writer, XmlWriteMode.WriteSchema);

                var xml = writer.ToString()
                                .Replace("type=\"xs:unsignedByte\" minOccurs=\"0\" />", "type=\"xs:int\" minOccurs=\"0\" />")
                                .Replace("type=\"xs:short\" minOccurs=\"0\" />", "type=\"xs:int\" minOccurs=\"0\" />")
                                .Replace("type=\"xs:long\" minOccurs=\"0\" />", "type=\"xs:decimal\" minOccurs=\"0\" />");

                if (tableNameIsEmpty) {
                    dataTable.TableName = string.Empty;
                }

                return xml;
            }
        }

        internal static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action) {
            if (enumerable == null || action == null) {
                return;
            }

            foreach (var item in enumerable) {
                action(item);
            }
        }

        internal static string ToProperIfAllLowerCase(this string value) {
            if (string.IsNullOrEmpty(value)) {
                return value;
            }

            return value.All(x => char.IsLower(x) || char.IsDigit(x) || x == '_') ? value.ToProper() : value;
        }

        internal static string ToProper(this string value) {
            return string.IsNullOrEmpty(value) ? value : Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value.ToLower());
        }
    }
}