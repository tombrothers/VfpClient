using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        private readonly VfpConnection _connection;
        private IEnumerable<ISchemaProvider> _providers;

        public IEnumerable<ISchemaProvider> Providers {
            get { return _providers ?? (_providers = GetProviders().ToList()); }
        }

        public SchemaManager(VfpConnection connection) {
            _connection = connection;
        }

        public DataTable GetSchema() {
            return GetSchema(VfpConnection.SchemaNames.MetaDataCollections);
        }

        public DataTable GetSchema(string collectionName) {
            return GetSchema(collectionName, null);
        }

        public DataTable GetSchema(string collectionName, string[] restrictionValues) {
            var stopwatch = Stopwatch.StartNew();

            if (VfpClientTracing.Tracer.ShouldTraceVerbose()) {
                VfpClientTracing.Tracer.TraceVerbose(string.Format("{0} collectionName={1}", MethodBase.GetCurrentMethod().Name, collectionName));
            }

            if (_connection.State != ConnectionState.Open) {
                throw new VfpException(Resources.VfpConnection_OpenConnectionForGetSchema);
            }

            if (string.IsNullOrEmpty(collectionName)) {
                throw new VfpException(string.Format(Resources.VfpConnection_GetSchemaUnknownCollection, string.Empty));
            }

            DataTable dataTable = null;

            foreach (var provider in Providers.Where(provider => provider.CanExecute(collectionName))) {
                if (restrictionValues != null && (provider.Restrictions == null || restrictionValues.Length > provider.Restrictions.Length)) {
                    throw new VfpException(string.Format(Resources.VfpConnection_GetSchemaWrongRestrictions, collectionName, provider.Restrictions.Length));
                }

                dataTable = provider.GetSchema(_connection, restrictionValues);
                break;
            }

            if (dataTable == null) {
                switch (collectionName.ToLower()) {
                    case "reservedwords":
                        dataTable = _connection.OleDbConnection.GetSchema(collectionName, restrictionValues);
                        break;
                    default:
                        throw new VfpException(string.Format(Resources.VfpConnection_GetSchemaUnknownCollection, collectionName));
                }
            }

            stopwatch.Stop();

            if (VfpClientTracing.Tracer.ShouldTraceVerbose()) {
                VfpClientTracing.Tracer.TraceVerbose(string.Format("{0} collectionName={1} : Duration={2}", MethodBase.GetCurrentMethod().Name, collectionName, stopwatch.Elapsed));
            }

            return dataTable;
        }

        private IEnumerable<ISchemaProvider> GetProviders() {
            yield return new CandidateKeySchemaProvider();
            yield return new DataTypesSchemaProvider();
            yield return new DataSourceInformationSchemaProvider();
            yield return new ForeignKeySchemaProvider();
            yield return new IndexSchemaProvider();
            yield return new MetaDataCollectionSchemaProvider();
            yield return new PrimaryKeySchemaProvider();
            yield return new ProcedureParameterSchemaProvider();
            yield return new ProcedureSchemaProvider();
            yield return new ProcedureColumnSchemaProvider();
            yield return new RestrictionSchemaProvider();
            yield return new TableFieldSchemaProvider();
            yield return new TableSchemaProvider();
            yield return new ViewFieldSchemaProvider();
            yield return new ViewSchemaProvider();
        }
    }
}