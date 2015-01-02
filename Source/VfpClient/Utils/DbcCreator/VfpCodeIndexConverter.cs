namespace VfpClient.Utils.DbcCreator {
    internal static class VfpCodeIndexConverter {
        public static string GetVfpCode(Table table, Index index) {
            ArgumentUtility.CheckNotNull("table", table);
            ArgumentUtility.CheckNotNull("index", index);

            return string.Format("EXECSCRIPT([USE '{0}' IN SELECT(0) EXCLUSIVE] + CHR(13) + [INDEX ON {1} TAG {2} ADDITIVE])",
                                 table.Name,
                                 index.Expression,
                                 index.Name);
        }
    }
}