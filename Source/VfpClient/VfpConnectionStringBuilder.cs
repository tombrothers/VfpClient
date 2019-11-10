using System;
using System.ComponentModel;
using System.Data.Common;
using System.IO;
using System.Linq;
using static System.String;

namespace VfpClient {
    public class VfpConnectionStringBuilder : DbConnectionStringBuilder {
        public const string DefaultProvider = "VFPOLEDB";
        private const string AnsiKey = "Ansi";
        private const string CollatingSequenceKey = "Collating Sequence";
        private const string DataSourceKey = "Data Source";
        private const string DeletedKey = "Deleted";
        private const string NullKey = "Null";
        private const string ProviderKey = "Provider";

        public new string ConnectionString {
            get => base.ConnectionString;
            set {
                var connectionString = value;

                if(MissingDataSource(connectionString)) {
                    connectionString = $"{DataSourceKey}={connectionString}";
                }

                base.ConnectionString = connectionString;

                EnsureProviderIsSet();
            }
        }

        [DisplayName(ProviderKey)]
        public string Provider {
            get => ContainsKey(ProviderKey) ? this[ProviderKey] as string : Empty;
            set => this[ProviderKey] = value;
        }

        [DisplayName(DataSourceKey)]
        public string DataSource {
            get => ContainsKey(DataSourceKey) ? this[DataSourceKey] as string : Empty;
            set {
                this[DataSourceKey] = value;

                EnsureProviderIsSet();
            }
        }

        [DisplayName(CollatingSequenceKey)]
        [DefaultValue(Collation.MACHINE)]
        [TypeConverter(typeof(CollationEnumConverter))]
        public Collation CollatingSequence {
            get => GetCollation();
            set => base[CollatingSequenceKey] = value;
        }

        [DisplayName(AnsiKey)]
        [DefaultValue(true)]
        [Description("Set as false to have string comparisons match based on the length of the shorter string.")]
        public bool Ansi {
            get => GetBooleanValue(AnsiKey, true);
            set => this[AnsiKey] = value;
        }

        [DisplayName(DeletedKey)]
        [DefaultValue(true)]
        [Description("Set as false to include deleted records when querying data.")]
        public bool Deleted {
            get => GetBooleanValue(DeletedKey, true);
            set => this[DeletedKey] = value;
        }

        [DisplayName(NullKey)]
        [DefaultValue(true)]
        [Description("")]
        public bool Null {
            get => GetBooleanValue(NullKey, true);
            set => this[NullKey] = value;
        }

        [Browsable(false)]
        public string Database { get; private set; }

        [Browsable(false)]
        public bool IsDbc { get; private set; }

        public override object this[string keyword] {
            get => base[keyword];
            set {
                base[keyword] = value;

                if(!keyword.Equals(DataSourceKey, StringComparison.InvariantCultureIgnoreCase)) {
                    return;
                }

                var dataSource = value as string;
                var fileName = Empty;

                if(!IsNullOrEmpty(dataSource)) {
                    fileName = GetFileName(dataSource);
                    IsDbc = fileName.EndsWith(".dbc", true, null);

                    if(!IsDbc) {
                        fileName = Empty;
                    }
                }

                Database = fileName;
            }
        }

        private static string GetFileName(string dataSource) {
            if(IsNullOrEmpty(dataSource) || Path.GetInvalidPathChars().Any(dataSource.Contains)) {
                return Empty;
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
            Database = Empty;
            IsDbc = false;

            base.Clear();
        }

        public void EnsureProviderIsSet() {
            if(IsNullOrEmpty(ConnectionString)) {
                return;
            }

            if(!IsNullOrEmpty(Provider)) {
                return;
            }

            Provider = DefaultProvider;
        }

        private static bool MissingDataSource(string connectionString) =>
            IsNullOrEmpty(connectionString) || !connectionString.Contains("=");

        private Collation GetCollation() =>
            GetCollation(ContainsKey(CollatingSequenceKey) ? this[CollatingSequenceKey].ToString() : null);

        private static Collation GetCollation(string collationText) {
            var collation = Collation.MACHINE;

            if(collationText != null) {
                collation = (Collation)Enum.Parse(typeof(Collation), collationText, true);
            }

            return collation;
        }

        private bool GetBooleanValue(string key, bool defaultValue = false) {
            if(!TryGetValue(key, out var value)) {
                return defaultValue;
            }

            return bool.TryParse(value.ToString(), out var result) && result;
        }
    }
}