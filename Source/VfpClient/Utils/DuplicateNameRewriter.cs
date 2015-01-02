using System.Linq;
using System.Text.RegularExpressions;

namespace VfpClient.Utils {
    internal partial class VfpCommandParameterRewritter {
        internal class DuplicateNameRewriter : RewriterBase {
            public DuplicateNameRewriter(VfpCommand vfpCommand)
                : base(vfpCommand) {
            }

            public override void Rewrite() {
                foreach (var parameter in GetOrderedParameters()) {
                    var matches = GetParameterNameMatches(parameter.ParameterName);

                    if (matches.Count < 2) {
                        continue;
                    }

                    ReplaceDuplicates(parameter, matches);
                }
            }

            private void ReplaceDuplicates(VfpParameter parameter, MatchCollection matches) {
                // Ordering by descending index so that as CommandText changes are made they won't invalidate the next match.Index.
                foreach (var match in matches.Cast<Match>().OrderByDescending(x => x.Index)) {
                    var newParameter = new VfpParameter(parameter);
                    newParameter.ParameterName = GetUniqueParameterName(newParameter.ParameterName);
                    VfpCommand.Parameters.Add(newParameter);
                    VfpCommand.CommandText = GetCommandTextWithNewParameterName(match, newParameter.ParameterName);
                }

                VfpCommand.Parameters.Remove(parameter);
            }

            private string GetCommandTextWithNewParameterName(Match match, string newParameterName) {
                return VfpCommand.CommandText.Substring(0, match.Index) +
                        VfpParameter.ParamerterNamePrefix +
                        newParameterName + " " +
                        VfpCommand.CommandText.Substring(match.Index + GetMatchLength(match));
            }

            private int GetMatchLength(Match match) {
                if (SpecialCharacters.Contains(match.Value[match.Value.Length - 1])) {
                    return match.Length - 1;
                }

                return match.Length;
            }

            private string GetUniqueParameterName(string parameterName) {
                var index = 0;
                var newParameterName = parameterName;

                while (VfpCommand.Parameters.Contains(newParameterName)) {
                    index++;
                    newParameterName = parameterName + "_" + index;
                }

                return newParameterName;
            }
        }
    }
}