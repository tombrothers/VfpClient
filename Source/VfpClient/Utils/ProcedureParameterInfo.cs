namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class ProcedureParameterInfo {
            public string Name { get; private set; }
            public string DataType { get; private set; }

            public ProcedureParameterInfo(string name, string dataType) {
                Name = name;
                DataType = dataType;
            }
        }
    }
}