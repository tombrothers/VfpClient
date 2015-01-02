using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.Data.Framework;
using Microsoft.VisualStudio.Data.Framework.AdoDotNet;

namespace VfpClient.Design {
    internal class VfpConnectionSupport : AdoDotNetConnectionSupport {
        private VfpDataViewSupport _viewSupport;
        private VfpDataObjectSupport _objectSupport;

        protected override object CreateService(IServiceContainer container, Type serviceType) {
            if (serviceType == typeof(DataViewSupport)) {
                if (_viewSupport == null) {
                    _viewSupport = new VfpDataViewSupport();
                }

                return _viewSupport;
            }

            if (serviceType == typeof(DataObjectSupport)) {
                if (_objectSupport == null) {
                    _objectSupport = new VfpDataObjectSupport();
                }

                return _objectSupport;
            }

            return base.CreateService(container, serviceType);
        }
    }
}