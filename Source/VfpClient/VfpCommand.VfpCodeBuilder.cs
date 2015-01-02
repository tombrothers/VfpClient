using System;
using System.Text;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace VfpClient {
    public partial class VfpCommand {
        public const string VariablePrefix = "__vfpClient_";

        private static class VfpCodeBuilder {
            public static string Build(VfpCommand command) {
                if (IsExecScript(command)) {
                    return command.Parameters[0].Value.ToString();
                }

                var output = new StringBuilder();

                WriteParameters(command, output);
                WriteCommandText(command, output);

                var vfpCode = output.ToString();
                vfpCode = vfpCode.Trim(Environment.NewLine.ToCharArray());

                return vfpCode.Trim();
            }

            private static void WriteCommandText(VfpCommand command, StringBuilder output) {
                var text = command.CommandText;

                for (var index = command.Parameters.Count - 1; index >= 0; index--) {
                    var parameter = command.Parameters[index];

                    text = text.Replace("@" + parameter.ParameterName,
                                        GetParameterName(parameter.ParameterName));
                }

                text = text.Trim(Environment.NewLine.ToCharArray())
                           .Replace("\n", string.Empty);

                text = AddSemiColons(text);
                text = ReplaceQuestionMarks(command.Parameters, text);

                output.Append(Environment.NewLine);
                output.Append(Environment.NewLine);
                output.Append(text);
            }

            private static string AddSemiColons(string text) {
                if (string.IsNullOrEmpty(text)) {
                    return text;
                }

                var lines = new List<string>();

                foreach (var line in text.Split('\r').Select(x => x).Where(x => !string.IsNullOrEmpty(x))) {
                    lines.Add(line + (line.TrimStart().StartsWith(VariablePrefix) ? string.Empty : " ;"));
                }

                text = string.Join(Environment.NewLine, lines);

                if (text.EndsWith(";")) {
                    text = text.Substring(0, text.LastIndexOf(";"));
                }

                return text;
            }

            private static string ReplaceQuestionMarks(VfpParameterCollection parameters, string commandText) {
                if (parameters.Count == 0 || !commandText.Contains("?")) {
                    return commandText;
                }

                var items = commandText.Split(new[] { '?' });

                if (parameters.Count != (commandText.Split(new[] { '?' }).Length - 1)) {
                    return commandText;
                }

                for (int index = items.Length - 1; index > 0; index--) {
                    items[index] = GetParameterName(parameters[index - 1].ParameterName) + items[index];
                }

                return string.Join(string.Empty, items);
            }

            private static void WriteParameters(VfpCommand command, StringBuilder output) {
                foreach (VfpParameter parameter in command.Parameters) {
                    output.Append(Environment.NewLine);

                    var parameterName = GetParameterName(parameter.ParameterName);

                    if (parameter.Value == null || parameter.Value == DBNull.Value) {
                        output.Append(string.Format("{0} = NULL", parameterName));
                    }
                    else {
                        switch (parameter.VfpType) {
                            case VfpType.Logical:
                                output.Append(string.Format("{0} = {1}", parameterName, ((bool)parameter.Value) ? ".t." : ".f."));
                                break;
                            case VfpType.Character:
                            case VfpType.Varchar:
                            case VfpType.Memo:
                                var parameterValue = parameter.Value.ToString();

                                if (parameterValue.Length > VfpMapping.MaximumCharacterFieldSize || parameterValue.IndexOf(Environment.NewLine) >= 0) {
                                    output.AppendLine(string.Format(@"
TEXT TO {0} NOSHOW
{1}
ENDTEXT"
                                        , parameterName, parameterValue));
                                }
                                else {
                                    output.Append(string.Format("{0} = '{1}'", parameterName, parameterValue.Replace("'", "' + chr(39) + '")));
                                }
                                break;
                            case VfpType.Date:
                                output.Append(string.Format("{0} = CTOD('{1}')", parameterName, ((DateTime)parameter.Value).ToShortDateString()));
                                break;
                            case VfpType.DateTime:
                                output.Append(string.Format("{0} = CTOT('{1}')", parameterName, parameter.Value));
                                break;
                            default:
                                if (typeof(byte[]) == parameter.Value.GetType()) {
                                    var fileName = Path.GetTempFileName();

                                    File.WriteAllBytes(fileName, (byte[])parameter.Value);

                                    output.Append(string.Format("{0} = FILETOSTR('{1}')", parameterName, fileName));
                                }
                                else {
                                    output.Append(string.Format("{0} = {1}", parameterName, parameter.Value));
                                }

                                break;
                        }
                    }
                }
            }

            private static bool IsExecScript(IDbCommand command) {
                return command.CommandType == CommandType.StoredProcedure && command.CommandText.Equals("ExecScript", StringComparison.InvariantCultureIgnoreCase);
            }

            private static string GetParameterName(string parameterName) {
                return VariablePrefix + parameterName;
            }
        }
    }
}