using System.Data;
using System.Linq;
using CandidateKey = VfpClient.VfpConnection.SchemaColumnNames.CandidateKey;
using Index = VfpClient.VfpConnection.SchemaColumnNames.Index;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class CandidateKeySchemaProvider : SchemaProviderBase {
            public CandidateKeySchemaProvider()
                : base(VfpConnection.SchemaNames.CandidateKeys, GetRestrictions(), null) {
            }

            private static string[] GetRestrictions() {
                return new[] { CandidateKey.TableName, "NoTablesWithMultipleCandidateKeys" };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var schema = connection.GetSchema(VfpConnection.SchemaNames.Indexes, restrictionValues);

                schema.DefaultView.RowFilter = Index.Candidate + " = true";
                schema = schema.DefaultView.ToTable(Name, true, CandidateKey.TableName, CandidateKey.IndexName, CandidateKey.FieldName);
                schema.TableName = Name;

                if (schema.Rows.Count == 0 || !ShouldExcludeTablesWithMultipleCandidateKeys(restrictionValues)) {
                    return schema;
                }

                var duplicates = schema.AsEnumerable()
                                       .Select(x => x.Field<string>(CandidateKey.TableName))
                                       .GroupBy(x => x)
                                       .Where(x => x.Count() > 1)
                                       .Select(x => x.Key)
                                       .Distinct()
                                       .ToList();

                var query = schema.AsEnumerable().Where(x => !duplicates.Contains(x.Field<string>(CandidateKey.TableName)));

                if (query.Any()) {
                    schema = query.CopyToDataTable();
                }

                return schema;
            }

            private bool ShouldExcludeTablesWithMultipleCandidateKeys(string[] restrictionValues) {
                var noTablesWithMultipleCandidateKeysRestrictionValue = restrictionValues == null || restrictionValues.Length < 2 ? null : restrictionValues[1];
                var noTablesWithMultipleCandidateKeys = false;

                bool.TryParse(noTablesWithMultipleCandidateKeysRestrictionValue, out noTablesWithMultipleCandidateKeys);

                return noTablesWithMultipleCandidateKeys;
            }
        }
    }
}