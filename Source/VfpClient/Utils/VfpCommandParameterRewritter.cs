using System.Collections.Generic;

namespace VfpClient.Utils {
    internal partial class VfpCommandParameterRewritter {
        public void Rewrite(VfpCommand vfpCommand) {
            ArgumentUtility.CheckNotNull("vfpCommand", vfpCommand);

            if (vfpCommand.Parameters.Count == 0) {
                return;
            }

            foreach (var rewriter in GetRewriters(vfpCommand)) {
                rewriter.Rewrite();
            }
        }

        private static IEnumerable<RewriterBase> GetRewriters(VfpCommand vfpCommand) {
            return new RewriterBase[] {
                           new DuplicateNameRewriter(vfpCommand),
                           new ParameterOrderingRewriter(vfpCommand),
                           new ParameterNameToQuestionMarkRewriter(vfpCommand)
                       };
        }
    }
}