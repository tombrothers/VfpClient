using System.Linq;
using System.Text.RegularExpressions;

namespace VfpClient.Utils {
    internal partial class VfpCommandParameterRewritter {
        internal class ParameterOrderingRewriter : RewriterBase {
            public ParameterOrderingRewriter(VfpCommand vfpCommand)
                : base(vfpCommand) {
            }

            public override void Rewrite() {
                var parameterNames = GetOrderedParameters()
                                         .Select(x => VfpParameter.ParamerterNamePrefix + x.ParameterName)
                                         .ToArray();

                if (!parameterNames.Any()) {
                    return;
                }

                var matches = GetCommandTextMatches(string.Join("|", parameterNames))
                                  .Cast<Match>()
                                  .Select(x => new { ParameterName = x.Value.Substring(1), x.Index })
                                  .ToList();

                if (!matches.Any()) {
                    // if there are absolutely no matches the command text isn't using named parameters
                    return;
                }

                var orderdParameters = (from p in VfpCommand.Parameters.Cast<VfpParameter>()
                                        join m in matches on p.ParameterName equals m.ParameterName
                                        orderby m.Index
                                        select p).ToList();

                VfpCommand.Parameters.Clear();
                orderdParameters.ForEach(x => VfpCommand.Parameters.Add(new VfpParameter(x)));
            }
        }
    }
}