using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace VfpClient {
    public partial class VfpDataReader : DbDataReader {
        private static DateTime NullFoxDate = new DateTime(1899, 12, 30, 00, 00, 00);

        private Dictionary<string, VfpType> _columnVfpTypes;
        private readonly DbDataReader _dbDataReader;

        public override int Depth {
            get {
                return Execute(() => _dbDataReader.Depth);
            }
        }

        public override int FieldCount {
            get {
                return Execute(() => _dbDataReader.FieldCount);
            }
        }

        public override bool HasRows {
            get {
                return Execute(() => _dbDataReader.HasRows);
            }
        }

        public override bool IsClosed {
            get {
                return Execute(() => _dbDataReader.IsClosed);
            }
        }

        public override int RecordsAffected {
            get {
                return Execute(() => _dbDataReader.RecordsAffected);
            }
        }

        public override object this[string name] {
            get {
                return Execute(() => GetValue(GetOrdinal(name)));
            }
        }

        public override object this[int ordinal] {
            get {
                return Execute(() => GetValue(ordinal));
            }
        }

        public override int VisibleFieldCount {
            get {
                return Execute(() => _dbDataReader.VisibleFieldCount);
            }
        }

        public VfpDataReader(DbDataReader dbDataReader) {
            ArgumentUtility.CheckNotNull("dbDataReader", dbDataReader);

            _dbDataReader = dbDataReader;
        }

        public override void Close() {
            Execute(() => _dbDataReader.Close());
        }

        public override bool GetBoolean(int ordinal) {
            return Execute(() => (bool)Convert.ChangeType(this[ordinal], typeof(bool)));
        }

        public override byte GetByte(int ordinal) {
            return Execute(() => (byte)Convert.ChangeType(this[ordinal], typeof(byte)));
        }

        public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) {
            return Execute(() => _dbDataReader.GetBytes(ordinal, dataOffset, buffer, bufferOffset, length));
        }

        public override char GetChar(int ordinal) {
            return Execute(() => _dbDataReader.GetChar(ordinal));
        }

        public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) {
            return Execute(() => _dbDataReader.GetChars(ordinal, dataOffset, buffer, bufferOffset, length));
        }

        public override string GetDataTypeName(int ordinal) {
            return Execute(() => _dbDataReader.GetDataTypeName(ordinal).ToVfpTypeName());
        }

        public override DateTime GetDateTime(int ordinal) {
            return Execute(() => _dbDataReader.GetDateTime(ordinal));
        }

        public override decimal GetDecimal(int ordinal) {
            return Execute(() => (decimal)Convert.ChangeType(this[ordinal], typeof(decimal)));
        }

        public override double GetDouble(int ordinal) {
            return Execute(() => (double)Convert.ChangeType(this[ordinal], typeof(double)));
        }

        public override IEnumerator GetEnumerator() {
            return Execute(() => _dbDataReader.GetEnumerator());
        }

        public override Type GetFieldType(int ordinal) {
            return Execute(() => _dbDataReader.GetFieldType(ordinal));
        }

        public override float GetFloat(int ordinal) {
            return Execute(() => (float)Convert.ChangeType(this[ordinal], typeof(float)));
        }

        public override Guid GetGuid(int ordinal) {
            return Execute(() => new Guid(GetString(ordinal)));
        }

        public override short GetInt16(int ordinal) {
            return Execute(() => (short)Convert.ChangeType(this[ordinal], typeof(short)));
        }

        public override int GetInt32(int ordinal) {
            return Execute(() => (int)Convert.ChangeType(this[ordinal], typeof(int)));
        }

        public override long GetInt64(int ordinal) {
            return Execute(() => (long)Convert.ChangeType(this[ordinal], typeof(long)));
        }

        public override string GetName(int ordinal) {
            return Execute(() => _dbDataReader.GetName(ordinal).ToProperIfAllLowerCase());
        }

        public override int GetOrdinal(string name) {
            return Execute(() => _dbDataReader.GetOrdinal(name));
        }

        public override DataTable GetSchemaTable() {
            return Execute(() => {
                var schema = _dbDataReader.GetSchemaTable();

                if (!schema.Columns.Contains("VfpType")) {
                    new SchemaFixer(this).Fix(schema);
                }

                return schema;
            });
        }

        public override string GetString(int ordinal) {
            return Execute(() => {
                var value = _dbDataReader[ordinal];
                string stringValue;

                if (value != null && value.GetType() == typeof(byte[])) {
                    stringValue = Encoding.Default.GetString((byte[])value);
                }
                else {
                    stringValue = (string)value;
                }

                return !string.IsNullOrEmpty(stringValue) ? stringValue.TrimEnd() : stringValue;
            });
        }

        public override object GetValue(int ordinal) {
            return Execute(() => {
                var value = _dbDataReader.GetValue(ordinal);

                if (value is string || (value is byte[] && IsStringType(ordinal))) {
                    return GetString(ordinal);
                }

                return _dbDataReader.GetValue(ordinal);
            });
        }

        public override int GetValues(object[] values) {
            ArgumentUtility.CheckNotNull("values", values);

            return Execute(() => {
                var total = Math.Min(values.Length, VisibleFieldCount);

                for (var index = 0; index < total; index++) {
                    values[index] = IsDBNull(index) ? DBNull.Value : GetValue(index);
                }

                return total;
            });
        }

        private bool IsStringType(int ordinal) {
            var columnName = GetName(ordinal).ToUpper();

            return GetColumnVfpTypes().ContainsKey(columnName) && GetColumnVfpTypes()[columnName].IsStringType();
        }

        private Dictionary<string, VfpType> GetColumnVfpTypes() {
            if (_columnVfpTypes == null) {
                _columnVfpTypes = GetSchemaTable().AsEnumerable()
                                                  .Select(x => new {
                                                      ColumnName = x.Field<string>("ColumnName").ToUpper(),
                                                      VfpType = (VfpType)x.Field<int>("VfpType")
                                                  })
                                                  .ToDictionary(x => x.ColumnName, x => x.VfpType);
            }

            return _columnVfpTypes;
        }

        public override bool IsDBNull(int ordinal)
        {
            return Execute(() =>
            {
                var isDBNull = _dbDataReader.IsDBNull(ordinal);
                var objvalue = _dbDataReader.GetValue(ordinal);

                if (objvalue is DateTime dateTime && (dateTime == NullFoxDate))
                {
                    isDBNull = true;
                }

                return isDBNull;
            });
        }

        public override bool NextResult() {
            return Execute(() => _dbDataReader.NextResult());
        }

        public override bool Read() {
            return Execute(() => _dbDataReader.Read());
        }

        protected static void Execute(Action action) {
            Execute(() => {
                action();

                return false;
            });
        }

        protected static T Execute<T>(Func<T> func) {
            try {
                return func();
            }
            catch (OleDbException exception) {
                throw new VfpException(exception.Message, exception);
            }
        }

        protected override void Dispose(bool disposing) {
            if (disposing && _dbDataReader != null) {
                _dbDataReader.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}