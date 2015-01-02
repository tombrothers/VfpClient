using System;
using System.ComponentModel;
using System.Data.Common;
using System.IO;
using System.Linq;

namespace VfpClient {
    public class VfpConnectionStringBuilder : DbConnectionStringBuilder {
        public new string ConnectionString {
            get { return base.ConnectionString; }
            set {
                var connectionString = value;

                if (MissingDataSource(connectionString)) {
                    connectionString = "Data Source=" + connectionString;
                }

                base.ConnectionString = connectionString;
            }
        }

        [DisplayName("Data Source")]
        public string DataSource {
            get { return ContainsKey("Data Source") ? this["Data Source"] as string : string.Empty; }
            set { this["Data Source"] = value; }
        }

        private const string CollatingSequenceKey = "Collating Sequence";
        [DisplayName("Collating Sequence")]
        [DefaultValue(Collation.MACHINE)]
        [TypeConverter(typeof(CollationEnumConverter))]
        public Collation CollatingSequence {
            get { return GetCollation(); }
            set { base[CollatingSequenceKey] = value; }
        }

        [DisplayName("Ansi")]
        [DefaultValue(true)]
        [Description("Set as false to have string comparisons match based on the length of the shorter string.")]
        public bool Ansi {
            get { return GetBooleanValue("Ansi", true); }
            set { this["Ansi"] = value; }
        }

        [DisplayName("Deleted")]
        [DefaultValue(true)]
        [Description("Set as false to include deleted records when querying data.")]
        public bool Deleted {
            get { return GetBooleanValue("Deleted", true); }
            set { this["Deleted"] = value; }
        }

        [DisplayName("Null")]
        [DefaultValue(true)]
        [Description("")]
        public bool Null {
            get { return GetBooleanValue("Null", true); }
            set { this["Null"] = value; }
        }

        [Browsable(false)]
        public string Database { get; private set; }

        [Browsable(false)]
        public bool IsDbc { get; private set; }

        public override object this[string keyword] {
            get { return base[keyword]; }
            set {
                base[keyword] = value;

                if (!keyword.Equals("Data Source", StringComparison.InvariantCultureIgnoreCase)) {
                    return;
                }

                var dataSource = value as string;
                var fileName = string.Empty;

                if (!string.IsNullOrEmpty(dataSource)) {
                    fileName = GetFileName(dataSource);
                    IsDbc = fileName.EndsWith(".dbc", true, null);

                    if (!IsDbc) {
                        fileName = string.Empty;
                    }
                }

                Database = fileName;
            }
        }

        private static string GetFileName(string dataSource) {
            if (string.IsNullOrEmpty(dataSource) || Path.GetInvalidPathChars().Any(dataSource.Contains)) {
                return string.Empty;
            }

            return Path.GetFileName(dataSource);
        }

        public VfpConnectionStringBuilder()
            : this(null) {
        }

        public VfpConnectionStringBuilder(string connectionString) {
            Clear();
            ConnectionString = connectionString;
        }

        public override void Clear() {
            Database = string.Empty;
            IsDbc = false;
            base.Clear();
        }

        private static bool MissingDataSource(string connectionString) {
            return string.IsNullOrEmpty(connectionString) || !connectionString.Contains("=");
        }

        private Collation GetCollation() {
            return GetCollation(ContainsKey(CollatingSequenceKey) ? this[CollatingSequenceKey].ToString() : null);
        }

        private static Collation GetCollation(string collationText) {
            var collation = Collation.MACHINE;

            if (collationText != null) {
                collation = (Collation)Enum.Parse(typeof(Collation), collationText, true);
            }

            return collation;
        }

        private bool GetBooleanValue(string key, bool defaultValue = false) {
            bool result;
            object value;

            if (!TryGetValue(key, out value)) {
                return defaultValue;
            }

            return bool.TryParse(value.ToString(), out result) && result;
        }
    }
}