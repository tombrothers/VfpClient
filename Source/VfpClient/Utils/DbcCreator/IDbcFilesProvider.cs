namespace VfpClient.Utils.DbcCreator {
    public interface IDbcFilesProvider {
        byte[] Dbc { get; }
        byte[] Dct { get; }
        byte[] Dcx { get; }
    }
}