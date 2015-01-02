using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;

namespace VfpClient {
    public class VfpParameter : DbParameter, ICloneable {
        internal const string ParamerterNamePrefix = "@";

        internal OleDbParameter OleDbParameter { get; private set; }
        private VfpType _vfpType;

        public override DbType DbType {
            get { return OleDbParameter.DbType; }
            set {
                OleDbParameter.DbType = value;
                _vfpType = value.ToVfpType();
            }
        }

        public VfpType VfpType {
            get { return _vfpType; }
            set {
                _vfpType = value;
                OleDbParameter.DbType = value.ToDbType();
            }
        }

        public override ParameterDirection Direction {
            get { return OleDbParameter.Direction; }
            set { OleDbParameter.Direction = value; }
        }

        public override bool IsNullable {
            get { return OleDbParameter.IsNullable; }
            set { OleDbParameter.IsNullable = value; }
        }

        public override string ParameterName {
            get { return OleDbParameter.ParameterName; }
            set { OleDbParameter.ParameterName = GetValidParameterName(value); }
        }

        public override int Size {
            get { return OleDbParameter.Size; }
            set { OleDbParameter.Size = value; }
        }

        public override string SourceColumn {
            get { return OleDbParameter.SourceColumn; }
            set { OleDbParameter.SourceColumn = value; }
        }

        public override bool SourceColumnNullMapping {
            get { return OleDbParameter.SourceColumnNullMapping; }
            set { OleDbParameter.SourceColumnNullMapping = value; }
        }

        public override DataRowVersion SourceVersion {
            get { return OleDbParameter.SourceVersion; }
            set { OleDbParameter.SourceVersion = value; }
        }

        public override object Value {
            get { return OleDbParameter.Value; }
            set {
                OleDbParameter.Value = value;
                _vfpType = OleDbParameter.DbType.ToVfpType();
            }
        }

        public VfpParameter()
            : this(new OleDbParameter()) {
        }

        internal VfpParameter(VfpParameter vfpParameter) {
            OleDbParameter = (OleDbParameter)((ICloneable)vfpParameter.OleDbParameter).Clone();
            _vfpType = OleDbParameter.DbType.ToVfpType();
        }

        internal VfpParameter(OleDbParameter oleDbParameter) {
            OleDbParameter = oleDbParameter;
            _vfpType = OleDbParameter.DbType.ToVfpType();
        }

        public VfpParameter(string name, VfpType vfpType) {
            _vfpType = vfpType;

            OleDbParameter = new OleDbParameter {
                ParameterName = name,
                DbType = vfpType.ToDbType()
            };
        }

        public VfpParameter(string name, object value) {
            OleDbParameter = new OleDbParameter(GetValidParameterName(name), value);
            _vfpType = OleDbParameter.DbType.ToVfpType();
        }

        public override void ResetDbType() {
            ResetVfpType();
        }

        public void ResetVfpType() {
            OleDbParameter.ResetDbType();
            _vfpType = OleDbParameter.DbType.ToVfpType();
        }

        private static string GetValidParameterName(string parameterName) {
            if (string.IsNullOrEmpty(parameterName)) {
                return parameterName;
            }

            return parameterName.StartsWith(ParamerterNamePrefix) ? parameterName.Substring(1) : parameterName;
        }

        object ICloneable.Clone() {
            return new VfpParameter(this);
        }
    }
}