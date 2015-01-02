using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VfpClient.Utils {
    internal partial class VfpCommandParameterRewritter {
        internal abstract class RewriterBase {
            public VfpCommand VfpCommand { get; private set; }
            protected readonly char[] SpecialCharacters = new[] { '%', '-', '=', '+', '<', '>', '/', '*', '^', '(', ')', ',' };
            private readonly char[] _regExCharacterRequiredEscape = new[] { '+', '*', '^', '(', ')', ',' };
            private readonly string _regEndsWithPattern;

            protected RewriterBase(VfpCommand vfpCommand) {
                ArgumentUtility.CheckNotNull("vfpCommand", vfpCommand);

                VfpCommand = vfpCommand;
                _regEndsWithPattern = GetSpecialCharactersPattern();
            }

            public abstract void Rewrite();

            private string GetSpecialCharactersPattern() {
                var stringBuilder = new StringBuilder();

                foreach (var specialCharacter in SpecialCharacters) {
                    if (stringBuilder.Length > 0) {
                        stringBuilder.Append("|");
                    }

                    if (_regExCharacterRequiredEscape.Contains(specialCharacter)) {
                        stringBuilder.Append("\\");
                    }

                    stringBuilder.Append(specialCharacter == ' ' ? 'w' : specialCharacter);
                }

                return "\\s|" + stringBuilder.ToString();
            }

            protected IEnumerable<VfpParameter> GetOrderedParameters() {
                return VfpCommand.Parameters
                                 .Cast<VfpParameter>()
                                 .Select((x, index) => new { Parameter = x, Ordinal = index })
                                 .OrderByDescending(x => x.Parameter.ParameterName.Length)
                                 .ThenBy(x => x.Ordinal)
                                 .Select(x => x.Parameter);
            }

            protected MatchCollection GetParameterNameMatches(string parameterName) {
                ArgumentUtility.CheckNotNullOrEmpty("parameterName", parameterName);

                return GetCommandTextMatches(VfpParameter.ParamerterNamePrefix + parameterName + @"(" + _regEndsWithPattern + ")");
            }

            protected MatchCollection GetCommandTextMatches(string pattern) {
                ArgumentUtility.CheckNotNullOrEmpty("pattern", pattern);

                return Regex.Matches(VfpCommand.CommandText, pattern, RegexOptions.IgnoreCase);
            }
        }
    }
}