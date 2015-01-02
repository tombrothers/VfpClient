using System;
using System.Linq;
using System.Xml.Linq;

namespace VfpClient.Utils {
    public class ArrayXmlToCursor {
        private readonly XNamespace _xsd = "http://www.w3.org/2001/XMLSchema";
        private readonly XNamespace _msdata = "urn:schemas-microsoft-com:xml-msdata";
        private readonly Array _array;
        private const string Rootname = "VFPData";
        public const string CursorName = "curTempIdList";
        public const string ColumnName = "Id";
        public string Xml { get; private set; }
        public Type ArrayType { get; private set; }
        public Type ItemType { get; private set; }

        public ArrayXmlToCursor(Array array) {
            _array = ArgumentUtility.CheckNotNull("array", array);

            Xml = GetXml(array);
        }

        private string GetXml(Array array) {
            ArrayType = GetArrayType(array);
            ItemType = Type.GetType(ArrayType.FullName.Substring(0, ArrayType.FullName.LastIndexOf("[", StringComparison.InvariantCulture)));

            var xdoc = new XDocument();
            var root = new XElement(Rootname);

            xdoc.Add(root);

            var schema = GetSchemaElement();

            if (schema != null) {
                root.Add(schema);
            }

            foreach (var item in array) {
                if (item == null) {
                    root.Add(new XElement(CursorName));
                }
                else {
                    root.Add(new XElement(CursorName,
                                new XAttribute(ColumnName, item)));
                }
            }

            return xdoc.ToString();
        }

        private static Type GetArrayType(Array array) {
            var type = array.GetType();

            // Try to get the actual array type incase it requires schema information in the xml.
            if (type.FullName == "System.Object[]" && array.Length > 0) {
                type = Type.GetType(array.GetValue(0).GetType().FullName + "[]");
            }

            return type;
        }

        /* 
         Example:
         
         <xsd:schema id='VFPData' xmlns:xsd='http://www.w3.org/2001/XMLSchema' xmlns:msdata='urn:schemas-microsoft-com:xml-msdata'>
		        <xsd:element name='VFPData' msdata:IsDataSet='true'>
			        <xsd:complexType>
				        <xsd:choice maxOccurs='unbounded'>
					        <xsd:element name='curTempIdList' minOccurs='0' maxOccurs='unbounded'>
						        <xsd:complexType>
							        <xsd:attribute name='Id' use='required'>
								        <xsd:simpleType>
									        <xsd:restriction base='xsd:string'>
										        <xsd:maxLength value='254'/>
									        </xsd:restriction>
								        </xsd:simpleType>
							        </xsd:attribute>
						        </xsd:complexType>
					        </xsd:element>
				        </xsd:choice>
				        <xsd:anyAttribute namespace='http://www.w3.org/XML/1998/namespace' processContents='lax'/>
			        </xsd:complexType>
		        </xsd:element>
	        </xsd:schema>
          
         */
        private XElement GetSchemaElement() {
            var attribute = GetAttributeElement();

            if (attribute == null) {
                return null;
            }

            return new XElement(_xsd + "schema",
                    new XAttribute("id", Rootname),
                    new XAttribute(XNamespace.Xmlns + "xsd", _xsd.NamespaceName),
                    new XAttribute(XNamespace.Xmlns + "msdata", _msdata.NamespaceName),
                    new XElement(_xsd + "element",
                        new XAttribute("name", Rootname),
                        new XAttribute(_msdata + "IsDataSet", true),
                        new XElement(_xsd + "complexType",
                            new XElement(_xsd + "choice",
                                new XAttribute("maxOccurs", "unbounded"),
                                new XElement(_xsd + "element",
                                    new XAttribute("name", CursorName),
                                    new XAttribute("minOccurs", 0),
                                    new XAttribute("maxOccurs", "unbounded"),
                                    new XElement(_xsd + "complexType",
                                        attribute,
                                        new XElement(_xsd + "anyAttribute",
                                            new XAttribute("namespace", "http://www.w3.org/XML/1998/namespace"),
                                            new XAttribute("processContext", "lax"))))))));
        }

        private XElement GetAttributeElement() {
            switch (ArrayType.FullName) {
                case "System.Char[]":
                case "System.Guid[]":
                case "System.String[]":
                    return GetStringAttributeElement();
                case "System.Byte[]":
                case "System.Int16[]":
                case "System.Int32[]":
                case "System.SByte[]":
                case "System.UInt16[]":
                    return GetIntAttributeElement();
                case "System.DateTime[]":
                    return GetDateTimeAttributeElement();
                case "System.Boolean[]":
                    return GetBooleanAttributeElement();
                case "System.Decimal[]":
                case "System.Double[]":
                case "System.Int64[]":
                case "System.Single[]":
                case "System.UInt32[]":
                case "System.UInt64[]":
                    return GetNumericAttributeElement();
                default:
                    return null;
            }
        }

        // Example: <xsd:attribute name="id" type="xsd:boolean" use="required"/> 
        private XElement GetBooleanAttributeElement() {
            return new XElement(_xsd + "attribute",
                    new XAttribute("name", ColumnName),
                    new XAttribute("use", "required"),
                    new XAttribute("type", "xsd:boolean"));
        }

        // Example: <xsd:attribute name="id" type="xsd:dateTime" use="required"/> 
        private XElement GetDateTimeAttributeElement() {
            return new XElement(_xsd + "attribute",
                    new XAttribute("name", ColumnName),
                    new XAttribute("use", "required"),
                    new XAttribute("type", "xsd:dateTime"));
        }

        // Example: <xsd:attribute name="id" type="xsd:int" use="required"/>
        private XElement GetIntAttributeElement() {
            return new XElement(_xsd + "attribute",
                    new XAttribute("name", ColumnName),
                    new XAttribute("use", "required"),
                    new XAttribute("type", "xsd:int"));
        }

        /* 
            Example:

            <xsd:attribute name='Id' use='required'>
                <xsd:simpleType>
					<xsd:restriction base="xsd:decimal">
						<xsd:totalDigits value="19"/>
						<xsd:fractionDigits value="4"/>
					</xsd:restriction>
                </xsd:simpleType>
            </xsd:attribute>
         */
        private XElement GetNumericAttributeElement() {
            var values = GetStringArray();
            var fractionDigits = 0;
            var query = values.Select(x => x.ToString())
                              .Where(x => x.Contains("."))
                              .Select(x => x.Substring(x.IndexOf(".")))
                              .Select(x => x.Length);

            if (query.Any()) {
                fractionDigits = query.Max();
            }

            return new XElement(_xsd + "attribute",
                    new XAttribute("name", ColumnName),
                    new XAttribute("use", "required"),
                    new XElement(_xsd + "simpleType",
                        new XElement(_xsd + "restriction",
                        new XAttribute("base", "xsd:decimal"),
                        new XElement(_xsd + "totalDigits",
                            new XAttribute("value", 19)),
                        new XElement(_xsd + "fractionDigits",
                            new XAttribute("value", fractionDigits)))));
        }

        private string[] GetStringArray() {
            return _array.Length == 0 ? new string[] { } : _array.Cast<object>().Select((t, index) => _array.GetValue(index) == null ? null : _array.GetValue(index).ToString()).ToArray();
        }

        /* 
            Example:

            <xsd:attribute name='Id' use='required'>
                <xsd:simpleType>
                    <xsd:restriction base='xsd:string'>
                        <xsd:maxLength value='254'/>
                    </xsd:restriction>
                </xsd:simpleType>
            </xsd:attribute>
         */
        private XElement GetStringAttributeElement() {
            var maxLength = VfpMapping.MaximumCharacterFieldSize;
            var values = GetStringArray();

            if (values.Where(x => !string.IsNullOrEmpty(x)).Any(x => x.Length > VfpMapping.MaximumCharacterFieldSize)) {
                maxLength = int.MaxValue;
            }

            return new XElement(_xsd + "attribute",
                    new XAttribute("name", ColumnName),
                    new XAttribute("use", "required"),
                    new XElement(_xsd + "simpleType",
                        new XElement(_xsd + "restriction",
                        new XAttribute("base", "xsd:string"),
                        new XElement(_xsd + "maxLength",
                            new XAttribute("value", maxLength)))));
        }
    }
}