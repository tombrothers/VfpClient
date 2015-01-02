using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace VfpClient.Utils.DbcCreator {
    public class DataTableToTableConverter : ITableConverter<DataTable> {
        public Table Convert(DataTable dataTable) {
            if (dataTable == null) {
                throw new ArgumentNullException("dataTable");
            }

            return GetTable(dataTable);
        }

        private static Table GetTable(DataTable dataTable) {
            return new Table {
                Name = dataTable.TableName,
                Fields = dataTable.Columns.Cast<DataColumn>().Select(GetField).ToArray(),
                Indexes = GetIndexes(dataTable)
            };
        }

        private static IEnumerable<Index> GetIndexes(DataTable dataTable) {
            var list = new List<Index>();

            AddIndexes(list, dataTable.ChildRelations.Cast<DataRelation>(), true);
            AddIndexes(list, dataTable.ParentRelations.Cast<DataRelation>(), false);
            AddPrimaryKey(list, dataTable);

            return list;
        }

        private static void AddPrimaryKey(List<Index> list, DataTable dataTable) {
            if (!dataTable.PrimaryKey.Any()) {
                return;
            }

            var primaryKeyExpression = GetIndexExpression(dataTable.PrimaryKey);
            var existing = list.Find(x => x.Expression == primaryKeyExpression);

            if (existing == null) {
                list.Add(new Index {
                    Name = "PK",
                    Expression = primaryKeyExpression,
                });
            }
        }

        private static void AddIndexes(List<Index> list, IEnumerable<DataRelation> dataRelations, bool isChildRelation) {
            var childRelations = dataRelations.Select(x => GetIndex(x, isChildRelation)).ToArray();

            if (childRelations.Any()) {
                list.AddRange(childRelations);
            }
        }

        private static Index GetIndex(DataRelation dataRelation, bool isChildRelation) {
            var columns = isChildRelation ? dataRelation.ParentColumns : dataRelation.ChildColumns;

            return new Index { Name = dataRelation.RelationName, Expression = GetIndexExpression(columns) };
        }

        private static string GetIndexExpression(DataColumn[] columns) {
            if (columns.Length == 1) {
                return GetFieldExpression(columns[0], false);
            }

            return string.Join("+", columns.Select(x => GetFieldExpression(x, true)).Where(x => !string.IsNullOrEmpty(x)).ToArray());
        }

        private static string GetFieldExpression(DataColumn column, bool isMultiPartExpression) {
            if (column.DataType == typeof(string)) {
                var maxLength = GetStringLength(column);

                return maxLength > VfpMapping.MaximumCharacterFieldSizeThatCanBeIndex ? string.Empty : column.ColumnName;
            }

            return isMultiPartExpression ? "STR(" + column.ColumnName + ")" : column.ColumnName;
        }

        private static Field GetField(DataColumn dataColumn) {
            var typeCode = Type.GetTypeCode(dataColumn.DataType);
            var field = new Field {
                Name = dataColumn.ColumnName,
                Nullable = dataColumn.AllowDBNull
            };

            switch (typeCode) {
                case TypeCode.Boolean:
                    field.VfpType = VfpType.Logical;
                    break;
                case TypeCode.Char:
                case TypeCode.String:
                    field.Width = GetStringLength(dataColumn);
                    field.VfpType = VfpMapping.GetVfpStringType(field.Width);
                    break;
                case TypeCode.SByte:
                case TypeCode.Byte:
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Int32:
                    field.VfpType = VfpType.Integer;
                    break;
                case TypeCode.UInt32:
                case TypeCode.Int64:
                case TypeCode.UInt64:
                case TypeCode.Decimal:
                    field.VfpType = VfpType.Numeric;
                    field.Width = VfpMapping.MaximumNumericFieldSize;
                    field.Decimal = GetPrecision(dataColumn);
                    break;
                case TypeCode.Single:
                    field.VfpType = VfpType.Float;
                    field.Width = VfpMapping.MaximumNumericFieldSize;
                    field.Decimal = GetPrecision(dataColumn);
                    break;
                case TypeCode.Double:
                    field.VfpType = VfpType.Double;
                    field.Decimal = GetPrecision(dataColumn);
                    break;
                case TypeCode.DateTime:
                    field.VfpType = VfpType.DateTime;
                    break;
                default:
                    if (dataColumn.DataType == typeof(byte[])) {
                        field.VfpType = VfpType.Blob;
                    }
                    else if (dataColumn.DataType == typeof(Guid)) {
                        field.VfpType = VfpType.Character;
                        field.Width = VfpMapping.GuidStringWidth;
                    }
                    else {
                        throw new NotSupportedException(dataColumn.DataType.ToString());
                    }

                    break;
            }

            return field;
        }

        private static int GetPrecision(DataColumn column) {
            if (column.Table.Rows.Count == 0) {
                return Math.Max(column.MaxLength, 0);
            }

            var values = column.Table
                               .AsEnumerable()
                               .Select(x => x.IsNull(column) ? string.Empty : x[column].ToString())
                               .Where(x => x.IndexOf('.') >= 0)
                               .Where(x => !x.EndsWith("."));

            if (!values.Any()) {
                return 0;
            }

            return values.Select(x => x.Substring(x.IndexOf('.') + 1).Length).Max();
        }

        private static int GetStringLength(DataColumn column) {
            if (column.Table.Rows.Count == 0) {
                return Math.Max(column.MaxLength, VfpMapping.MaximumCharacterFieldSize);
            }

            var calculatedLength = column.Table
                                         .AsEnumerable()
                                         .Select(row => row.IsNull(column) ? string.Empty : row[column].ToString())
                                         .Select(x => x.Length)
                                         .Max();

            if (calculatedLength > 0) {
                return calculatedLength;
            }

            return column.MaxLength <= 0 ? VfpMapping.MaximumCharacterFieldSize : column.MaxLength;
        }
    }
}