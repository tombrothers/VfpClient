using System;

namespace VfpClient.Utils.DbcCreator {
    internal static class VfpCodeFieldConverter {
        public static string GetVfpCode(Field field) {
            ArgumentUtility.CheckNotNull("field", field);

            return string.Format("{0} {1} {2} ", field.Name, GetFieldType(field), GetNull(field));
        }

        private static string GetNull(Field field) {
            return (field.Nullable ? " NULL" : " NOT NULL");
        }

        private static string GetFieldType(Field field) {
            var fieldType = string.Empty;

            switch (field.VfpType) {
                case VfpType.Logical:
                case VfpType.Integer:
                case VfpType.AutoIncInteger:
                case VfpType.Memo:
                case VfpType.BinaryMemo:
                case VfpType.General:
                case VfpType.DateTime:
                case VfpType.Date:
                case VfpType.Currency:
                case VfpType.Blob:
                    fieldType = field.VfpType.ToFieldType();
                    break;
                case VfpType.Character:
                case VfpType.BinaryCharacter:
                case VfpType.Varchar:
                case VfpType.BinaryVarchar:
                    var vfpType = VfpMapping.GetVfpStringType(field.Width);

                    if (vfpType == VfpType.Memo) {
                        fieldType = vfpType.ToFieldType();
                    }
                    else {
                        fieldType = string.Format(vfpType.ToFieldType(), field.Width);
                    }

                    break;
                case VfpType.Double:
                    fieldType = string.Format(field.VfpType.ToFieldType(), field.Decimal);
                    break;
                case VfpType.Varbinary:
                    fieldType = string.Format(field.VfpType.ToFieldType(), field.Width);
                    break;
                case VfpType.Numeric:
                case VfpType.Float:
                    fieldType = string.Format(field.VfpType.ToFieldType(), field.Width, field.Decimal);
                    break;
                default:
                    throw new NotSupportedException(field.VfpType.ToString());
            }

            return fieldType;
        }
    }
}