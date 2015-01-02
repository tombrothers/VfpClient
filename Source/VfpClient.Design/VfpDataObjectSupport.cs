using Microsoft.VisualStudio.Data.Framework;

namespace VfpClient.Design {
    internal class VfpDataObjectSupport : DataObjectSupport {
        public VfpDataObjectSupport()
            : base("VfpClient.Design.VfpDataObjectSupport", typeof(VfpDataObjectSupport).Assembly) {
        }
    }
}