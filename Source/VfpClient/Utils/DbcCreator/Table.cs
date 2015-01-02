using System.Collections.Generic;

namespace VfpClient.Utils.DbcCreator {
    public class Table {
        public string Name { get; set; }
        public IEnumerable<Field> Fields { get; set; }
        public IEnumerable<Index> Indexes { get; set; }
    }
}