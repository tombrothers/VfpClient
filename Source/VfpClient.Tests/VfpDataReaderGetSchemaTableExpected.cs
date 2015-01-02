using System;
using System.Data;

namespace VfpClient.Tests {
    class VfpDataReaderGetSchemaTableExpected {
        public static DataTable GetAutoInc() {
            DataTable dataTable = new DataTable("SchemaTable");

            #region columns

            dataTable.Columns.Add("ColumnName", typeof(System.String));
            dataTable.Columns.Add("ColumnOrdinal", typeof(System.Int32));
            dataTable.Columns.Add("ColumnSize", typeof(System.Int32));
            dataTable.Columns.Add("NumericPrecision", typeof(System.Int16));
            dataTable.Columns.Add("NumericScale", typeof(System.Int16));
            dataTable.Columns.Add("DataType", typeof(System.Type));
            dataTable.Columns.Add("ProviderType", typeof(System.Int32));
            dataTable.Columns.Add("IsLong", typeof(System.Boolean));
            dataTable.Columns.Add("AllowDBNull", typeof(System.Boolean));
            dataTable.Columns.Add("IsReadOnly", typeof(System.Boolean));
            dataTable.Columns.Add("IsRowVersion", typeof(System.Boolean));
            dataTable.Columns.Add("IsUnique", typeof(System.Boolean));
            dataTable.Columns.Add("IsKey", typeof(System.Boolean));
            dataTable.Columns.Add("IsAutoIncrement", typeof(System.Boolean));
            dataTable.Columns.Add("BaseSchemaName", typeof(System.String));
            dataTable.Columns.Add("BaseCatalogName", typeof(System.String));
            dataTable.Columns.Add("BaseTableName", typeof(System.String));
            dataTable.Columns.Add("BaseColumnName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ColumnName"] = "Orderid";
            row["ColumnOrdinal"] = 0;
            row["ColumnSize"] = 4;
            row["NumericPrecision"] = 10;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.Int32);
            row["ProviderType"] = 3;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = true;
            row["IsRowVersion"] = false;
            row["IsUnique"] = true;
            row["IsKey"] = true;
            row["IsAutoIncrement"] = true;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ColumnName"] = "Customerid";
            row["ColumnOrdinal"] = 1;
            row["ColumnSize"] = 5;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ColumnName"] = "Employeeid";
            row["ColumnOrdinal"] = 2;
            row["ColumnSize"] = 4;
            row["NumericPrecision"] = 10;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.Int32);
            row["ProviderType"] = 3;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ColumnName"] = "Orderdate";
            row["ColumnOrdinal"] = 3;
            row["ColumnSize"] = 6;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.DateTime);
            row["ProviderType"] = 133;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ColumnName"] = "Requireddate";
            row["ColumnOrdinal"] = 4;
            row["ColumnSize"] = 6;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.DateTime);
            row["ProviderType"] = 133;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ColumnName"] = "Shippeddate";
            row["ColumnOrdinal"] = 5;
            row["ColumnSize"] = 6;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.DateTime);
            row["ProviderType"] = 133;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ColumnName"] = "Shipvia";
            row["ColumnOrdinal"] = 6;
            row["ColumnSize"] = 4;
            row["NumericPrecision"] = 10;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.Int32);
            row["ProviderType"] = 3;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ColumnName"] = "Freight";
            row["ColumnOrdinal"] = 7;
            row["ColumnSize"] = 8;
            row["NumericPrecision"] = 19;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.Decimal);
            row["ProviderType"] = 6;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ColumnName"] = "Shipname";
            row["ColumnOrdinal"] = 8;
            row["ColumnSize"] = 40;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ColumnName"] = "Shipaddress";
            row["ColumnOrdinal"] = 9;
            row["ColumnSize"] = 60;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ColumnName"] = "Shipcity";
            row["ColumnOrdinal"] = 10;
            row["ColumnSize"] = 15;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["ColumnName"] = "Shipregion";
            row["ColumnOrdinal"] = 11;
            row["ColumnSize"] = 15;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["ColumnName"] = "Shippostalcode";
            row["ColumnOrdinal"] = 12;
            row["ColumnSize"] = 10;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["ColumnName"] = "Shipcountry";
            row["ColumnOrdinal"] = 13;
            row["ColumnSize"] = 15;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Orders";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetNoAutoInc() {
            DataTable dataTable = new DataTable("SchemaTable");

            #region columns

            dataTable.Columns.Add("ColumnName", typeof(System.String));
            dataTable.Columns.Add("ColumnOrdinal", typeof(System.Int32));
            dataTable.Columns.Add("ColumnSize", typeof(System.Int32));
            dataTable.Columns.Add("NumericPrecision", typeof(System.Int16));
            dataTable.Columns.Add("NumericScale", typeof(System.Int16));
            dataTable.Columns.Add("DataType", typeof(System.Type));
            dataTable.Columns.Add("ProviderType", typeof(System.Int32));
            dataTable.Columns.Add("IsLong", typeof(System.Boolean));
            dataTable.Columns.Add("AllowDBNull", typeof(System.Boolean));
            dataTable.Columns.Add("IsReadOnly", typeof(System.Boolean));
            dataTable.Columns.Add("IsRowVersion", typeof(System.Boolean));
            dataTable.Columns.Add("IsUnique", typeof(System.Boolean));
            dataTable.Columns.Add("IsKey", typeof(System.Boolean));
            dataTable.Columns.Add("IsAutoIncrement", typeof(System.Boolean));
            dataTable.Columns.Add("BaseSchemaName", typeof(System.String));
            dataTable.Columns.Add("BaseCatalogName", typeof(System.String));
            dataTable.Columns.Add("BaseTableName", typeof(System.String));
            dataTable.Columns.Add("BaseColumnName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ColumnName"] = "Customerid";
            row["ColumnOrdinal"] = 0;
            row["ColumnSize"] = 5;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = true;
            row["IsKey"] = true;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ColumnName"] = "Companyname";
            row["ColumnOrdinal"] = 1;
            row["ColumnSize"] = 40;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ColumnName"] = "Contactname";
            row["ColumnOrdinal"] = 2;
            row["ColumnSize"] = 30;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ColumnName"] = "Contacttitle";
            row["ColumnOrdinal"] = 3;
            row["ColumnSize"] = 30;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ColumnName"] = "Address";
            row["ColumnOrdinal"] = 4;
            row["ColumnSize"] = 60;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ColumnName"] = "City";
            row["ColumnOrdinal"] = 5;
            row["ColumnSize"] = 15;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ColumnName"] = "Region";
            row["ColumnOrdinal"] = 6;
            row["ColumnSize"] = 15;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ColumnName"] = "Postalcode";
            row["ColumnOrdinal"] = 7;
            row["ColumnSize"] = 10;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ColumnName"] = "Country";
            row["ColumnOrdinal"] = 8;
            row["ColumnSize"] = 15;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ColumnName"] = "Phone";
            row["ColumnOrdinal"] = 9;
            row["ColumnSize"] = 24;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ColumnName"] = "Fax";
            row["ColumnOrdinal"] = 10;
            row["ColumnSize"] = 24;
            row["NumericPrecision"] = 255;
            row["NumericScale"] = 255;
            row["DataType"] = typeof(System.String);
            row["ProviderType"] = 129;
            row["IsLong"] = false;
            row["AllowDBNull"] = true;
            row["IsReadOnly"] = false;
            row["IsRowVersion"] = false;
            row["IsUnique"] = false;
            row["IsKey"] = false;
            row["IsAutoIncrement"] = false;
            row["BaseSchemaName"] = DBNull.Value;
            row["BaseCatalogName"] = DBNull.Value;
            row["BaseTableName"] = "Customers";
            row["BaseColumnName"] = "";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}