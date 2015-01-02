using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Procedure = VfpClient.VfpConnection.SchemaColumnNames.Procedure;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class ProcedureSchemaProvider : SchemaProviderBase {
            public ProcedureSchemaProvider()
                : base(VfpConnection.SchemaNames.Procedures, GetRestrictions(), null) {
            }

            private static string[] GetRestrictions() {
                return new[] { Procedure.ProcedureName, "IncludeReferentialIntegrity" };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var schema = connection.OleDbConnection.GetSchema(Name, new[] { null, null, GetProcedureName(restrictionValues), null });

                schema = FilterOleDbSchema(schema);
                schema = UpdateProcedureDefinition(schema);
                schema.Columns.Add(Procedure.ReferentialIntegrity, typeof(bool));

                if (!connection.IsDbc) {
                    return schema;
                }

                var includeReferentialIntegrity = GetIncludeReferentialIntegrity(restrictionValues);

                foreach (DataRow row in schema.Rows) {
                    row[Procedure.ReferentialIntegrity] = IsReferentialIntegrityProcedure(row[Procedure.ProcedureName].ToString());
                }

                if (schema.Rows.Count > 0 && !includeReferentialIntegrity) {
                    var query = schema.AsEnumerable().Where(row => !row.Field<bool>(Procedure.ReferentialIntegrity));

                    if (query.Any()) {
                        schema = query.CopyToDataTable();
                    }
                    else {
                        schema.Clear();
                    }
                }

                schema.TableName = Name;

                FormatColumnValues(schema, new[] { Procedure.ProcedureName });

                return schema;
            }

            private static DataTable UpdateProcedureDefinition(DataTable schema) {
                var tempColumnName = Procedure.ProcedureDefinition + "Temp";
                schema.Columns.Add(tempColumnName);

                foreach (DataRow row in schema.Rows) {
                    row[tempColumnName] = row[Procedure.ProcedureDefinition].ToString();
                }

                schema.Columns.Remove(Procedure.ProcedureDefinition);
                schema.Columns[tempColumnName].ColumnName = Procedure.ProcedureDefinition;

                return schema.DefaultView.ToTable(schema.TableName, false, new[] { Procedure.ProcedureName, Procedure.ProcedureDefinition, Procedure.Description });
            }

            private static bool GetIncludeReferentialIntegrity(string[] restrictionValues) {
                var includeReferentialIntegrityRestrictionValue = restrictionValues == null || restrictionValues.Length < 2 ? null : restrictionValues[1];
                var includeReferentialIntegrity = false;

                bool.TryParse(includeReferentialIntegrityRestrictionValue, out includeReferentialIntegrity);

                return includeReferentialIntegrity;
            }

            private static string GetProcedureName(string[] restrictionValues) {
                return restrictionValues == null || restrictionValues.Length < 1 ? null : restrictionValues[0];
            }

            private static bool IsReferentialIntegrityProcedure(string procedureName) {
                return GetReferentialIntegrityToken().Any(token => procedureName.StartsWith(token, StringComparison.CurrentCultureIgnoreCase));
            }

            private static IEnumerable<string> GetReferentialIntegrityToken() {
                yield return "__ri_update";
                yield return "__ri_delete";
                yield return "ridelete";
                yield return "riupdate";
                yield return "rierror";
                yield return "riopen";
                yield return "riend";
                yield return "rireuse";
            }
        }
    }
}