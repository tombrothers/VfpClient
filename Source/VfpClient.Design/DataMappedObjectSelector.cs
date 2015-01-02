using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.Data.Services;

namespace VfpClient.Design {
    internal class DataMappedObjectSelector : IVsDataMappedObjectSelector {
        public IList<T> SelectMappedObjects<T>(string specificTypeName, object[] restrictions, bool refresh) where T : IVsDataMappedObject {
            throw new NotImplementedException();
        }

        public IList<T> SelectMappedObjects<T>(object[] restrictions, bool refresh) where T : IVsDataMappedObject {
            throw new NotImplementedException();
        }

        public IList<T> SelectMappedObjects<T>(string specificTypeName, object[] restrictions) where T : IVsDataMappedObject {
            throw new NotImplementedException();
        }

        public IList<T> SelectMappedObjects<T>(object[] restrictions) where T : IVsDataMappedObject {
            throw new NotImplementedException();
        }

        public IList<T> SelectMappedObjects<T>(string specificTypeName) where T : IVsDataMappedObject {
            throw new NotImplementedException();
        }

        public IList<T> SelectMappedObjects<T>() where T : IVsDataMappedObject {
            throw new NotImplementedException();
        }

        public bool SupportsType<T>(string specificTypeName) where T : IVsDataMappedObject {
            throw new NotImplementedException();
        }

        public bool SupportsType<T>() where T : IVsDataMappedObject {
            throw new NotImplementedException();
        }
    }
}
