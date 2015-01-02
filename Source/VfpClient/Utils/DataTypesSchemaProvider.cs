using System;
using System.Data;
using DataTypes = VfpClient.VfpConnection.SchemaColumnNames.DataTypes;

namespace VfpClient.Utils {
    internal partial class SchemaManager {
        internal class DataTypesSchemaProvider : SchemaProviderBase {
            public DataTypesSchemaProvider()
                : base(VfpConnection.SchemaNames.DataTypes) {
            }

            public override DataTable GetSchema(VfpConnection connection, string[] restrictionValues) {
                ArgumentUtility.CheckNotNull("connection", connection);

                var dataTable = new DataTable(Name);

                #region columns

                dataTable.Columns.Add(DataTypes.VfpType, typeof(int));
                dataTable.Columns.Add(DataTypes.VfpTypeName);
                dataTable.Columns.Add(DataTypes.ColumnSize, typeof(long));
                dataTable.Columns.Add(DataTypes.CreateFormat);
                dataTable.Columns.Add(DataTypes.CreateParameters);
                dataTable.Columns.Add(DataTypes.DataType);
                dataTable.Columns.Add(DataTypes.IsAutoIncrementable, typeof(bool));
                dataTable.Columns.Add(DataTypes.IsFixedLength, typeof(bool));
                dataTable.Columns.Add(DataTypes.IsFixedPrecisionScale, typeof(bool));
                dataTable.Columns.Add(DataTypes.IsLong, typeof(bool));
                dataTable.Columns.Add(DataTypes.IsNullable, typeof(bool));
                dataTable.Columns.Add(DataTypes.IsSearchable, typeof(bool));
                dataTable.Columns.Add(DataTypes.IsSearchableWithLike, typeof(bool));
                dataTable.Columns.Add(DataTypes.MaximumScale, typeof(short));
                dataTable.Columns.Add(DataTypes.MinimumScale, typeof(short));
                dataTable.Columns.Add(DataTypes.LiteralPrefix);
                dataTable.Columns.Add(DataTypes.LiteralSuffix);

                #endregion columns

                #region rows

                DataRow row;

                #region row 0

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Integer;
                row[DataTypes.VfpTypeName] = VfpType.Integer.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 10;
                row[DataTypes.CreateFormat] = VfpType.Integer.ToFieldType();
                row[DataTypes.CreateParameters] = DBNull.Value;
                row[DataTypes.DataType] = VfpType.Integer.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = true;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = DBNull.Value;
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 1

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Float;
                row[DataTypes.VfpTypeName] = VfpType.Float.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 20;
                row[DataTypes.CreateFormat] = VfpType.Float.ToFieldType();
                row[DataTypes.CreateParameters] = "width, decimal places";
                row[DataTypes.DataType] = VfpType.Float.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = false;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = 19;
                row[DataTypes.MinimumScale] = 0;
                row[DataTypes.LiteralPrefix] = DBNull.Value;
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 2

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Numeric;
                row[DataTypes.VfpTypeName] = VfpType.Numeric.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 20;
                row[DataTypes.CreateFormat] = VfpType.Numeric.ToFieldType();
                row[DataTypes.CreateParameters] = "width, decimal places";
                row[DataTypes.DataType] = VfpType.Numeric.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = false;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = 19;
                row[DataTypes.MinimumScale] = 0;
                row[DataTypes.LiteralPrefix] = DBNull.Value;
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 3

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Double;
                row[DataTypes.VfpTypeName] = VfpType.Double.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 15;
                row[DataTypes.CreateFormat] = VfpType.Double.ToFieldType();
                row[DataTypes.CreateParameters] = "decimal places";
                row[DataTypes.DataType] = VfpType.Double.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = true;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = DBNull.Value;
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 4

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Currency;
                row[DataTypes.VfpTypeName] = VfpType.Currency.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 19;
                row[DataTypes.CreateFormat] = VfpType.Currency.ToFieldType();
                row[DataTypes.CreateParameters] = DBNull.Value;
                row[DataTypes.DataType] = VfpType.Currency.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = true;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = "$";
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 5

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Date;
                row[DataTypes.VfpTypeName] = VfpType.Date.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 10;
                row[DataTypes.CreateFormat] = VfpType.Date.ToFieldType();
                row[DataTypes.CreateParameters] = DBNull.Value;
                row[DataTypes.DataType] = VfpType.Date.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = true;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = "{";
                row[DataTypes.LiteralSuffix] = "}";
                dataTable.Rows.Add(row);

                #endregion row

                #region row 6

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.DateTime;
                row[DataTypes.VfpTypeName] = VfpType.DateTime.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 19;
                row[DataTypes.CreateFormat] = VfpType.DateTime.ToFieldType();
                row[DataTypes.CreateParameters] = DBNull.Value;
                row[DataTypes.DataType] = VfpType.DateTime.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = true;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = "{";
                row[DataTypes.LiteralSuffix] = "}";
                dataTable.Rows.Add(row);

                #endregion row

                #region row 7

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Logical;
                row[DataTypes.VfpTypeName] = VfpType.Logical.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 1;
                row[DataTypes.CreateFormat] = VfpType.Logical.ToFieldType();
                row[DataTypes.CreateParameters] = DBNull.Value;
                row[DataTypes.DataType] = VfpType.Logical.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = true;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = DBNull.Value;
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 8

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.General;
                row[DataTypes.VfpTypeName] = VfpType.General.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 2147483647;
                row[DataTypes.CreateFormat] = VfpType.General.ToFieldType();
                row[DataTypes.CreateParameters] = DBNull.Value;
                row[DataTypes.DataType] = VfpType.General.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = false;
                row[DataTypes.IsFixedPrecisionScale] = false;
                row[DataTypes.IsLong] = true;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = false;
                row[DataTypes.IsSearchableWithLike] = false;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = DBNull.Value;
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 9

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Memo;
                row[DataTypes.VfpTypeName] = VfpType.Memo.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 2147483647;
                row[DataTypes.CreateFormat] = VfpType.Memo.ToFieldType();
                row[DataTypes.CreateParameters] = DBNull.Value;
                row[DataTypes.DataType] = VfpType.Memo.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = false;
                row[DataTypes.IsFixedPrecisionScale] = false;
                row[DataTypes.IsLong] = true;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = true;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = "'";
                row[DataTypes.LiteralSuffix] = "'";
                dataTable.Rows.Add(row);

                #endregion row

                #region row 10

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Character;
                row[DataTypes.VfpTypeName] = VfpType.Character.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 254;
                row[DataTypes.CreateFormat] = VfpType.Character.ToFieldType();
                row[DataTypes.CreateParameters] = "length";
                row[DataTypes.DataType] = VfpType.Character.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = true;
                row[DataTypes.IsFixedPrecisionScale] = false;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = true;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = "'";
                row[DataTypes.LiteralSuffix] = "'";
                dataTable.Rows.Add(row);

                #endregion row

                #region row 11

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Varchar;
                row[DataTypes.VfpTypeName] = VfpType.Varchar.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 254;
                row[DataTypes.CreateFormat] = VfpType.Varchar.ToFieldType();
                row[DataTypes.CreateParameters] = "max length";
                row[DataTypes.DataType] = VfpType.Varchar.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = false;
                row[DataTypes.IsFixedPrecisionScale] = false;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = true;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = "'";
                row[DataTypes.LiteralSuffix] = "'";
                dataTable.Rows.Add(row);

                #endregion row

                #region row 12

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Blob;
                row[DataTypes.VfpTypeName] = VfpType.Blob.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 2147483647;
                row[DataTypes.CreateFormat] = VfpType.Blob.ToFieldType();
                row[DataTypes.CreateParameters] = DBNull.Value;
                row[DataTypes.DataType] = VfpType.Blob.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = false;
                row[DataTypes.IsFixedPrecisionScale] = false;
                row[DataTypes.IsLong] = true;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = true;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = "0h";
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #region row 13

                row = dataTable.NewRow();
                row[DataTypes.VfpType] = VfpType.Varbinary;
                row[DataTypes.VfpTypeName] = VfpType.Varbinary.ToVfpTypeName();
                row[DataTypes.ColumnSize] = 254;
                row[DataTypes.CreateFormat] = VfpType.Varbinary.ToFieldType();
                row[DataTypes.CreateParameters] = "max length";
                row[DataTypes.DataType] = VfpType.Varbinary.ToType().FullName;
                row[DataTypes.IsAutoIncrementable] = false;
                row[DataTypes.IsFixedLength] = false;
                row[DataTypes.IsFixedPrecisionScale] = false;
                row[DataTypes.IsLong] = false;
                row[DataTypes.IsNullable] = true;
                row[DataTypes.IsSearchable] = true;
                row[DataTypes.IsSearchableWithLike] = true;
                row[DataTypes.MaximumScale] = DBNull.Value;
                row[DataTypes.MinimumScale] = DBNull.Value;
                row[DataTypes.LiteralPrefix] = "0h";
                row[DataTypes.LiteralSuffix] = DBNull.Value;
                dataTable.Rows.Add(row);

                #endregion row

                #endregion rows

                return dataTable;
            }
        }
    }
}