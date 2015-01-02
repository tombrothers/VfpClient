using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;

namespace VfpClient {
    public class VfpParameterCollection : DbParameterCollection {
        private readonly List<VfpParameter> _vfpParamCollection;
        private readonly OleDbParameterCollection _oleDbParameterCollection;

        public override int Count {
            get { return _oleDbParameterCollection.Count; }
        }

        public override bool IsFixedSize {
            get { return _oleDbParameterCollection.IsFixedSize; }
        }

        public override bool IsReadOnly {
            get { return _oleDbParameterCollection.IsReadOnly; }
        }

        public override bool IsSynchronized {
            get { return _oleDbParameterCollection.IsSynchronized; }
        }

        public override object SyncRoot {
            get { return new VfpParameter(_oleDbParameterCollection.SyncRoot as OleDbParameter); }
        }

        public new VfpParameter this[int index] {
            get { return (VfpParameter)base[index]; }
            set { base[index] = value; }
        }

        public new VfpParameter this[string parameterName] {
            get { return (VfpParameter)base[parameterName]; }
            set { base[parameterName] = value; }
        }

        internal VfpParameterCollection(OleDbParameterCollection oleDbParameterCollection) {
            _oleDbParameterCollection = oleDbParameterCollection;
            _vfpParamCollection = new List<VfpParameter>();
            _oleDbParameterCollection.Cast<OleDbParameter>().ForEach(x => _vfpParamCollection.Add(new VfpParameter(x)));
        }

        public VfpParameter Add(VfpParameter value) {
            _vfpParamCollection.Add(value);
            _oleDbParameterCollection.Add(value.OleDbParameter);

            return value;
        }

        public VfpParameter AddWithValue(string parameterName, object value) {
            return Add(new VfpParameter(parameterName, value));
        }

        public VfpParameter Add(string parameterName, VfpType vfpType) {
            return Add(new VfpParameter(parameterName, vfpType));
        }

        /*
        public VfpParameter Add(string parameterName, VfpType vfpType, int size) {
            return Add(new VfpParameter(parameterName, vfpType, size));
        }

        public VfpParameter Add(string parameterName, VfpType vfpType, int size, string sourceColumn) {
            return Add(new VfpParameter(parameterName, vfpType, size, sourceColumn));
        }
        */

        public override int Add(object parameter) {
            var vfpParameter = new VfpParameter((VfpParameter)parameter);

            _vfpParamCollection.Add(vfpParameter);
            _oleDbParameterCollection.Add(vfpParameter.OleDbParameter);

            return _vfpParamCollection.Count - 1;
        }

        public void AddRange(VfpParameter[] values) {
            _vfpParamCollection.AddRange(values);
            _oleDbParameterCollection.AddRange(values.Select(x => x.OleDbParameter).ToArray());
        }

        public override void AddRange(Array parameters) {
            parameters.Cast<VfpParameter>()
                      .ForEach(vfpParameter => {
                          _vfpParamCollection.Add(vfpParameter);
                          _oleDbParameterCollection.Add(vfpParameter.OleDbParameter);
                      });
        }

        public override void Clear() {
            _vfpParamCollection.Clear();
            _oleDbParameterCollection.Clear();
        }

        public override bool Contains(string parameterName) {
            return GetParameter(parameterName) != null;
        }

        public bool Contains(VfpParameter value) {
            return -1 != IndexOf(value);
        }

        public override bool Contains(object parameter) {
            return _vfpParamCollection.Contains((VfpParameter)parameter);
        }

        public void CopyTo(VfpParameter[] array, int index) {
            CopyTo((Array)array, index);
        }

        public override void CopyTo(Array array, int startIndex) {
            if (array == null) {
                return;
            }

            var vfpParameters = new VfpParameter[array.Length];
            _vfpParamCollection.CopyTo(vfpParameters, startIndex);

            for (int index = startIndex; index < startIndex + _vfpParamCollection.Count; ++index) {
                array.SetValue(vfpParameters.GetValue(index), index);
            }
        }

        public override IEnumerator GetEnumerator() {
            return _vfpParamCollection.GetEnumerator();
        }

        protected override DbParameter GetParameter(string parameterName) {
            return _vfpParamCollection.SingleOrDefault(x => x.ParameterName.Equals(parameterName));
        }

        protected override DbParameter GetParameter(int index) {
            return _vfpParamCollection[index];
        }

        public int IndexOf(VfpParameter value) {
            return _vfpParamCollection.IndexOf(value);
        }

        public override int IndexOf(string parameterName) {
            return IndexOf(GetParameter(parameterName));
        }

        public void Insert(int index, VfpParameter value) {
            _vfpParamCollection.Insert(index, value);
            _oleDbParameterCollection.Insert(index, value.OleDbParameter);
        }

        public override int IndexOf(object parameter) {
            if (parameter == null) {
                return -1;
            }

            return _vfpParamCollection.IndexOf((VfpParameter)parameter);
        }

        public override void Insert(int index, object parameter) {
            var vfpParameter = (VfpParameter)parameter;

            _vfpParamCollection.Insert(index, vfpParameter);
            _oleDbParameterCollection.Insert(index, vfpParameter.OleDbParameter);
        }

        public void Remove(VfpParameter value) {
            _vfpParamCollection.Remove(value);
            _oleDbParameterCollection.Remove(value.OleDbParameter);
        }

        public override void Remove(object parameter) {
            Remove((VfpParameter)parameter);
        }

        public override void RemoveAt(string parameterName) {
            _vfpParamCollection.RemoveAll(x => x.ParameterName.Equals(parameterName));
            _oleDbParameterCollection.RemoveAt(parameterName);
        }

        public override void RemoveAt(int index) {
            _vfpParamCollection.RemoveAt(index);
            _oleDbParameterCollection.RemoveAt(index);
        }

        protected override void SetParameter(string parameterName, DbParameter value) {
            var parameter = _vfpParamCollection.Select((x, index) => new { Parameter = x, Index = index })
                                                    .SingleOrDefault(x => x.Parameter.ParameterName.Equals(parameterName));

            if (parameter != null) {
                SetParameter(parameter.Index, value);
            }
        }

        protected override void SetParameter(int index, DbParameter parameter) {
            var vfpParameter = (VfpParameter)parameter;

            _vfpParamCollection[index] = vfpParameter;
            _oleDbParameterCollection[index] = vfpParameter.OleDbParameter;
        }
    }
}