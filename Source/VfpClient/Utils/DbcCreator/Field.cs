namespace VfpClient.Utils.DbcCreator {
    public class Field {
        public string Name { get; set; }
        public VfpType VfpType { get; set; }
        public bool Nullable { get; set; }
        public int Width { get; set; }
        public int Decimal { get; set; }
    }
}