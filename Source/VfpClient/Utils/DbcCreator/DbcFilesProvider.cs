namespace VfpClient.Utils.DbcCreator {
    public class DbcFilesProvider : IDbcFilesProvider {
        public byte[] Dbc {
            get { return Resources.BlankDbc; }
        }

        public byte[] Dct {
            get { return Resources.BlankDct; }
        }

        public byte[] Dcx {
            get { return Resources.BlankDcx; }
        }
    }
}