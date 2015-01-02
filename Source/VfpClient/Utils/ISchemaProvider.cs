using System.Data;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal interface ISchemaProvider {
            string Name { get; }
            bool CanExecute(string schemaName);
            DataTable GetSchema(VfpConnection connection, string[] restrictionValues);
            string[] Restrictions { get; }
        }
    }
}