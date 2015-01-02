using System.Data;
using System.Diagnostics;

namespace VfpClient.Utils.DbcCreator {
    public class DataTableDbcCreator : DbcCreatorBase<DataTable> {
        public DataTableDbcCreator(string dbcPath)
            : this(dbcPath, new DataTableToTableConverter(), new DbcFilesProvider()) {
        }

        public DataTableDbcCreator(string dbcPath, ITableConverter<DataTable> tableConverter, IDbcFilesProvider dbcFilesProvider)
            : base(dbcPath, tableConverter, dbcFilesProvider) {
        }

        public void Add(DataSet dataSet) {
            if (dataSet == null) {
                return;
            }

            foreach (DataTable dataTable in dataSet.Tables) {
                Add(dataTable);
            }
        }

        public override void Add(DataTable source, Table table) {
            if (source == null) {
                return;
            }

            var stopwatch = Stopwatch.StartNew();

            CreateTable(table);
            InsertData(source);
            CreateIndexes(table);

            stopwatch.Stop();

            if (VfpClientTracing.Tracer.ShouldTraceVerbose()) {
                VfpClientTracing.Tracer.TraceVerbose(string.Format(" {0} Add Table={1} : Duration={2}", GetType().Name, source.TableName, stopwatch.Elapsed));
            }
        }

        private void InsertData(DataTable dataTable) {
            _connection.DoConnected(() => {
                using (var command = _connection.CreateCommand()) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "XmlToCursor";
                    command.Parameters.Add(new VfpParameter("xml", dataTable.ToXmlToCursorFormattedXml()));
                    command.Parameters.Add(new VfpParameter("cursor", "curXmlTemp"));
                    command.ExecuteNonQuery();

                    command.CommandType = CommandType.Text;
                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO '" + dataTable.TableName + "' SELECT * FROM curXmlTemp";
                    command.ExecuteNonQuery();

                    command.CommandText = "USE IN curXmlTemp";
                }
            });
        }
    }
}