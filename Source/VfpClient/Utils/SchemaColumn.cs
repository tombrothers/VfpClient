using System;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class SchemaColumn {
            public string Name { get; private set; }
            public Type Type { get; private set; }
            public bool UseGetDbProp { get; private set; }

            public SchemaColumn(string name, Type type, bool useGetDbProp) {
                Name = name;
                Type = type;
                UseGetDbProp = useGetDbProp;
            }
        }
    }
}