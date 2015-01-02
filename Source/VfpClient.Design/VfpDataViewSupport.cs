using Microsoft.VisualStudio.Data.Framework;

namespace VfpClient.Design {
    internal class VfpDataViewSupport : DataViewSupport {
        public VfpDataViewSupport()
            : base("VfpClient.Design.VfpDataViewSupport", typeof(VfpDataViewSupport).Assembly) {
        }
    }
}