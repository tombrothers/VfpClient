using System.Data;

namespace VfpClient.Tests.TestCases {
    public class VfpTypeAndDbTypeTestCase {
        public VfpType VfpType { get; }
        public DbType DbType { get; }

        public VfpTypeAndDbTypeTestCase(VfpType vfpType, DbType dbType) {
            this.VfpType = vfpType;
            this.DbType = dbType;
        }
    }
}
