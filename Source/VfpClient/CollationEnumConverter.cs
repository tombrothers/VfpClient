using System;
using System.ComponentModel;
using System.Globalization;

namespace VfpClient {
    internal class CollationEnumConverter : EnumConverter {
        private readonly Type _enumType;

        public CollationEnumConverter(Type enumType)
            : base(enumType) {
            _enumType = enumType;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType) {
            return destType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destType) {
            if (value == null) {
                value = Collation.MACHINE;
            }

            return value.ToString();
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType) {
            return srcType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
            return Enum.Parse(_enumType, (string)value, true);
        }
    }
}