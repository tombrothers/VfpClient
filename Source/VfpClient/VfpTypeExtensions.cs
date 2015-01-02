namespace VfpClient {
    public static class VfpTypeExtensions {
        public static bool IsStringType(this VfpType vfpType) {
            return vfpType == VfpType.BinaryCharacter ||
                   vfpType == VfpType.BinaryMemo ||
                   vfpType == VfpType.BinaryVarchar ||
                   vfpType == VfpType.Character ||
                   vfpType == VfpType.Memo ||
                   vfpType == VfpType.Varchar;
        }
    }
}