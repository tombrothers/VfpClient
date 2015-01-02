namespace VfpClient.Utils.DbcCreator {
    public interface ITableConverter<in T> {
        Table Convert(T source);
    }
}