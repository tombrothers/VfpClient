namespace VfpClient.Utils {
    internal partial class VfpCommandParameterRewritter {
        internal class ParameterNameToQuestionMarkRewriter : RewriterBase {
            public ParameterNameToQuestionMarkRewriter(VfpCommand vfpCommand)
                : base(vfpCommand) {
            }

            public override void Rewrite() {
                foreach (var parameter in GetOrderedParameters()) {
                    VfpCommand.CommandText = VfpCommand.CommandText.Replace(VfpParameter.ParamerterNamePrefix + parameter.ParameterName, "?");
                }
            }
        }
    }
}