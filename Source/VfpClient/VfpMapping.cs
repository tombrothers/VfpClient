using System;
using System.Data;
using System.Data.OleDb;

namespace VfpClient {
    public static partial class VfpMapping {
        public static readonly int MaximumCharacterFieldSize = 254;
        public static readonly int MaximumCharacterFieldSizeThatCanBeIndex = 240;
        public static readonly int MaximumNumericFieldSize = 19;
        public static readonly int GuidStringWidth = 38;
        public static readonly int MaximumIndexNameLength = 10;

        public static VfpType GetVfpStringType(int stringLength, bool isFixedLength = false) { 
            if(stringLength > MaximumCharacterFieldSize) {
                return VfpType.Memo;
            }

            return isFixedLength ? VfpType.Character : VfpType.Varchar;
        }

        public static string GetDefaultValue(this VfpType vfpType) {
            switch (vfpType) {
                case VfpType.Logical:
                    return ".f.";
                case VfpType.BinaryCharacter:
                case VfpType.BinaryMemo:
                case VfpType.BinaryVarchar:
                case VfpType.Character:
                case VfpType.Memo:
                case VfpType.Varchar:
                    return "''";
                case VfpType.Currency:
                case VfpType.Numeric:
                case VfpType.Double:
                case VfpType.Float:
                case VfpType.Integer:
                case VfpType.AutoIncInteger:
                    return "0";
                case VfpType.Date:
                case VfpType.DateTime:
                    return "Date(1900, 1, 1)";
                default:
                    throw new NotImplementedException(vfpType.ToString());
            }
        }

        public static string ToFieldType(this VfpType vfpType) {
            if (!_vfpTypeToFieldType.ContainsKey(vfpType)) {
                throw new VfpException("Unable to convert VfpType " + vfpType + " to a Field Type");
            }

            return _vfpTypeToFieldType[vfpType];
        }

        public static Type ToType(this VfpType vfpType) {
            if (!_vfpTypeToClrType.ContainsKey(vfpType)) {
                throw new VfpException("Unable to convert VfpType " + vfpType + " to a Type");
            }

            return _vfpTypeToClrType[vfpType];
        }

        public static string ToVfpTypeName(this VfpType vfpType) {
            if (!_vfpTypeToVfpTypeName.ContainsKey(vfpType)) {
                throw new VfpException("Unable to convert VfpType " + vfpType + " to a VfpTypeName");
            }

            return _vfpTypeToVfpTypeName[vfpType];
        }

        public static DbType ToDbType(this VfpType vfpType) {
            if (!_vfpTypeToDbType.ContainsKey(vfpType)) {
                throw new VfpException("Unable to convert VfpType " + vfpType + " to a DbType");
            }

            return _vfpTypeToDbType[vfpType];
        }

        public static VfpType ToVfpType(this DbType dbType) {
            if (!_dbTypeToVfpType.ContainsKey(dbType)) {
                throw new VfpException("Unable to convert DbType " + dbType + " to a VfpType");
            }

            return _dbTypeToVfpType[dbType];
        }

        public static VfpType ToVfpType(this OleDbType oleDbType) {
            if (!_oleDbTypeToVfpType.ContainsKey(oleDbType)) {
                throw new VfpException("Unable to convert OleDbType " + oleDbType + " to a VfpType");
            }

            return _oleDbTypeToVfpType[oleDbType];
        }

        public static string ToVfpTypeName(this string type) {
            if (_vfpAbbrevToVfpTypeName.ContainsKey(type)) {
                return _vfpAbbrevToVfpTypeName[type];
            }

            if (_dbTypeNameToVfpTypeName.ContainsKey(type)) {
                return _dbTypeNameToVfpTypeName[type];
            }

            return string.Empty;
        }

        public static VfpType ToVfpType(this string type) {
            if (_vfpTypeNameToVfpType.ContainsKey(type)) {
                return _vfpTypeNameToVfpType[type];
            }

            if (_vfpAbbrevToVfpType.ContainsKey(type)) {
                return _vfpAbbrevToVfpType[type];
            }

            return VfpType.Variant;
        }
    }
}