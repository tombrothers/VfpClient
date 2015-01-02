using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal abstract class SchemaProviderBase : ISchemaProvider {
            public string Name { get; private set; }
            public string[] Restrictions { get; private set; }
            public SchemaColumn[] Columns { get; private set; }

            protected SchemaProviderBase(string schemaName)
                : this(schemaName, null, null) {
            }

            protected SchemaProviderBase(string schemaName, string[] restrictions, SchemaColumn[] columns) {
                Name = schemaName;
                Restrictions = restrictions;
                Columns = columns;
            }

            public abstract DataTable GetSchema(VfpConnection connection, string[] restrictionValues);

            public bool CanExecute(string schemaName) {
                return schemaName.Equals(Name, StringComparison.InvariantCultureIgnoreCase);
            }

            protected DataTable CreateSchemaStructure() {
                var table = new DataTable(Name);

                Columns.ForEach(x => {
                    var column = new DataColumn {
                        DataType = x.Type,
                        ColumnName = x.Name,
                        AutoIncrement = false,
                        Caption = x.Name,
                        ReadOnly = true,
                        Unique = false
                    };

                    table.Columns.Add(column);
                });

                return table;
            }

            protected DataTable FilterOleDbSchema(DataTable oleDbSchema) {
                var toBeRemovedColumns = new LinkedList<DataColumn>();

                foreach (DataColumn column in oleDbSchema.Columns) {
                    column.ColumnName = GetVfpColumnNameFromOleDbColumnName(column.ColumnName);
                    column.Caption = column.ColumnName;

                    if (column.Caption.EndsWith("Schema")
                            || column.Caption.EndsWith("Catalog")
                            || column.Caption.Equals("ProcedureType")
                            || column.Caption.Equals("DateCreated")
                            || column.Caption.Equals("DateModified")) {
                        toBeRemovedColumns.AddFirst(column);
                    }
                }

                foreach (var column in toBeRemovedColumns) {
                    oleDbSchema.Columns.Remove(column);
                }

                return oleDbSchema;
            }

            protected string GetVfpColumnNameFromOleDbColumnName(string oleDbColumnName) {
                return oleDbColumnName.ToProper().Replace("_", string.Empty);
            }

            protected void FormatColumnValues(DataTable table, string[] columns) {
                foreach (DataRow row in table.Rows) {
                    foreach (var column in columns) {
                        var dataColumn = table.Columns[column];
                        var @readonly = dataColumn.ReadOnly;

                        dataColumn.ReadOnly = false;
                        row[column] = row[column].ToString().ToProperIfAllLowerCase();
                        dataColumn.ReadOnly = @readonly;
                    }
                }
            }

            protected virtual void ModifyColumns(DataTable dataTable) {
                if (dataTable == null) {
                    return;
                }

                RenameColumns(dataTable);
                RemoveUnNeededColumns(dataTable);
            }

            protected void RemoveUnNeededColumns(DataTable dataTable) {
                if (dataTable == null) {
                    return;
                }

                var columnNames = GetRequiredColumns().ToList();

                for (var index = dataTable.Columns.Count - 1; index >= 0; index--) {
                    var column = dataTable.Columns[index];

                    if (!columnNames.Contains(column.ColumnName)) {
                        dataTable.Columns.Remove(column);
                    }
                }
            }

            protected virtual IEnumerable<string> GetRequiredColumns() {
                return new List<string>();
            }

            protected virtual void RenameColumns(DataTable dataTable) {
            }
        }
    }
}