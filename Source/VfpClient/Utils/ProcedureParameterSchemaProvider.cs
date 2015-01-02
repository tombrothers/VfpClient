using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Procedure = VfpClient.VfpConnection.SchemaColumnNames.Procedure;
using ProcedureParameter = VfpClient.VfpConnection.SchemaColumnNames.ProcedureParameter;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class ProcedureParameterSchemaProvider : SchemaProviderBase {
            public ProcedureParameterSchemaProvider()
                : base(VfpConnection.SchemaNames.ProcedureParameters, GetRestrictions(), null) {
            }

            private static string[] GetRestrictions() {
                return new[] { ProcedureParameter.ProcedureName, "IncludeReferentialIntegrity" };
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var schema = CreateEmptyProcedureParametersDataTable();

                if (!connection.IsDbc) {
                    return schema;
                }

                var procedures = connection.GetSchema(VfpConnection.SchemaNames.Procedures, restrictionValues);

                if (procedures.Rows.Count == 0) {
                    return schema;
                }

                foreach (DataRow row in procedures.Rows) {
                    var name = row[Procedure.ProcedureName].ToString();
                    var code = row[Procedure.ProcedureDefinition].ToString();

                    if (string.IsNullOrEmpty(code)) {
                        continue;
                    }

                    code = RemoveParameterName(name, code);
                    code = GetParameterCode(code);

                    AddParameters(schema, name, GetParameters(code));
                }

                ParseHungarianNotation(schema);
                SetDataType(schema);

                FormatColumnValues(schema, new[] { ProcedureParameter.ProcedureName, ProcedureParameter.ParameterName });

                return schema;
            }

            private static void SetDataType(DataTable parameters) {
                foreach (DataRow row in parameters.Rows) {
                    VfpType vfpType;

                    if (row.IsNull(ProcedureParameter.VfpType)) {
                        vfpType = row.Field<string>(ProcedureParameter.VfpTypeName).ToVfpType();
                    }
                    else {
                        vfpType = (VfpType)row.Field<int>(ProcedureParameter.VfpType);

                        if (!Enum.IsDefined(typeof(VfpType), vfpType)) {
                            vfpType = VfpType.Variant;
                        }
                    }

                    if (vfpType == VfpType.Variant) {
                        // set unknown datatypes to varchar
                        vfpType = VfpType.Varchar;
                    }

                    row[ProcedureParameter.VfpType] = vfpType;
                    row[ProcedureParameter.VfpTypeName] = vfpType.ToVfpTypeName();
                    row[ProcedureParameter.DataType] = vfpType.ToDbType();
                }
            }

            private static void ParseHungarianNotation(DataTable parameters) {
                // only parse the rows that have a VfpTypeName of variant
                var rows = parameters.AsEnumerable()
                                     .Where(row => row.Field<string>(ProcedureParameter.VfpTypeName).Equals("variant", StringComparison.InvariantCultureIgnoreCase))
                                     .ToList();

                foreach (var row in rows) {
                    var parameterName = row.Field<string>(ProcedureParameter.ParameterName);

                    if (parameterName.Length > 2 && parameterName.StartsWith("t", StringComparison.InvariantCultureIgnoreCase)) {
                        var typeCharacter = parameterName.Substring(1, 1).ToLower();

                        // set "c" (character) to "v" (varchar - string)
                        if (typeCharacter == "c") {
                            typeCharacter = "v";
                        }

                        var vfpType = typeCharacter.ToVfpType();
                        row[ProcedureParameter.VfpType] = vfpType;
                        row[ProcedureParameter.VfpTypeName] = vfpType.ToVfpTypeName();
                    }
                }
            }

            private static void AddParameters(DataTable parameters, string procedureName, IEnumerable<ProcedureParameterInfo> list) {
                var ordinal = 0;

                foreach (var item in list) {
                    var dataRow = parameters.NewRow();

                    dataRow[ProcedureParameter.ProcedureName] = procedureName;
                    dataRow[ProcedureParameter.ParameterName] = item.Name;
                    dataRow[ProcedureParameter.VfpTypeName] = item.DataType;
                    dataRow[ProcedureParameter.Ordinal] = ++ordinal;

                    parameters.Rows.Add(dataRow);
                }
            }

            private DataTable CreateEmptyProcedureParametersDataTable() {
                var dataTable = new DataTable(Name);

                dataTable.Columns.Add(ProcedureParameter.ProcedureName);
                dataTable.Columns.Add(ProcedureParameter.ParameterName);
                dataTable.Columns.Add(ProcedureParameter.VfpTypeName);
                dataTable.Columns.Add(ProcedureParameter.VfpType, typeof(int));
                dataTable.Columns.Add(ProcedureParameter.Ordinal, typeof(int));
                dataTable.Columns.Add(ProcedureParameter.DataType, typeof(int));

                return dataTable;
            }

            private static IEnumerable<ProcedureParameterInfo> GetParameters(string code) {
                return code.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(CreateProcedureParameter).ToList();
            }

            private static ProcedureParameterInfo CreateProcedureParameter(string parameter) {
                var index = parameter.IndexOf(" as ", StringComparison.CurrentCultureIgnoreCase);
                var parameterInfo = new string[2];

                if (index > 0) {
                    parameterInfo[0] = parameter.Substring(0, index).Trim();
                    parameterInfo[1] = parameter.Substring(index + 4).Trim().ToLower();
                }
                else {
                    parameterInfo[0] = parameter;
                    parameterInfo[1] = "variant";
                }

                parameterInfo[0] = RemoveParameterTokens(parameterInfo[0]);
                parameterInfo[1] = RemoveParameterTokens(parameterInfo[1]);

                return new ProcedureParameterInfo(parameterInfo[0], parameterInfo[1]);
            }

            private static string RemoveParameterTokens(string parameter) {
                foreach (var token in GetParameterTokens()) {
                    if (parameter.StartsWith(token, StringComparison.CurrentCultureIgnoreCase)) {
                        parameter = parameter.Substring(token.Length);
                        break;
                    }
                }

                if (parameter.EndsWith(")")) {
                    parameter = parameter.Substring(0, parameter.Length - 1);
                }

                return parameter.Trim();
            }

            private static string GetParameterCode(string code) {
                var codeLines = code.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var parameterCodeLines = new List<string>();
                var startTokenFound = false;

                foreach (var codeLine in codeLines) {
                    var line = codeLine.Trim();

                    // skip comment lines
                    if (IsCommentLine(line)) {
                        continue;
                    }

                    if (!startTokenFound) {
                        startTokenFound = HasParameterToken(line);
                    }

                    if (startTokenFound) {
                        // check to see if the loop needs to continue due to a line continuation character
                        if (line.EndsWith(";")) {
                            // add the line minus the trailing semi-clone... add a space just to be safe
                            parameterCodeLines.Add(line.Substring(0, line.Length - 1) + " ");
                            continue;
                        }

                        parameterCodeLines.Add(line);
                    }

                    break;
                }

                return string.Join(" ", parameterCodeLines.ToArray());
            }

            private static bool HasParameterToken(string line) {
                return GetParameterTokens().Any(token => line.StartsWith(token, StringComparison.CurrentCultureIgnoreCase));
            }

            private static IEnumerable<string> GetParameterTokens() {
                yield return "(";
                yield return "lparameters ";
                yield return "parameters ";
            }

            private static bool IsCommentLine(string line) {
                return line.StartsWith("*") || line.StartsWith("&&");
            }

            private static string RemoveParameterName(string name, string code) {
                var start = code.IndexOf(name, StringComparison.CurrentCultureIgnoreCase);

                if (start == -1) {
                    // should never happen
                    throw new VfpException("Cannot locate parameter name.");
                }

                start += name.Length;

                return code.Substring(start);
            }
        }
    }
}