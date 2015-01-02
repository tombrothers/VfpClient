using Microsoft.VisualStudio.Data.Framework;
using Microsoft.VisualStudio.Data.Services;

namespace VfpClient.Design {
    internal class VfpDSRefBuilder : DSRefBuilder {
        public VfpDSRefBuilder() {
        }

        public VfpDSRefBuilder(IVsDataConnection connection)
            : base(connection) {
        }
    }
}