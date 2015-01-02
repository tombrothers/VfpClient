using System;
using System.Data;

namespace VfpClient.Tests.Schema {
    public class ProcedureColumnSchemaProviderExpected {
        public static DataTable GetSchemaWithProcedureNameReferentialIntegrity() {
            DataTable dataTable = new DataTable("");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int16));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));

            #endregion columns

            return dataTable;
        }

        public static DataTable GetSchemaWithReferentialIntegrity() {
            DataTable dataTable = new DataTable("");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int16));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["FieldName"] = "Productname";
            row["Ordinal"] = 0;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 40;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["FieldName"] = "Total";
            row["Ordinal"] = 1;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Productname";
            row["Ordinal"] = 0;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 40;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Unitprice";
            row["Ordinal"] = 1;
            row["DataType"] = 6;
            row["VfpTypeName"] = "Currency";
            row["VfpType"] = 3;
            row["Width"] = 8;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Quantity";
            row["Ordinal"] = 2;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Discount";
            row["Ordinal"] = 3;
            row["DataType"] = 131;
            row["VfpTypeName"] = "Numeric";
            row["VfpType"] = 7;
            row["Width"] = 19;
            row["Decimal"] = 5;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Extendedprice";
            row["Ordinal"] = 4;
            row["DataType"] = 6;
            row["VfpTypeName"] = "Currency";
            row["VfpType"] = 3;
            row["Width"] = 8;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["FieldName"] = "Orderid";
            row["Ordinal"] = 0;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["FieldName"] = "Orderdate";
            row["Ordinal"] = 1;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["FieldName"] = "Requireddate";
            row["Ordinal"] = 2;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["FieldName"] = "Shippeddate";
            row["Ordinal"] = 3;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["FieldName"] = "Shippeddate";
            row["Ordinal"] = 0;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["FieldName"] = "Orderid";
            row["Ordinal"] = 1;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["FieldName"] = "Subtotal";
            row["Ordinal"] = 2;
            row["DataType"] = 6;
            row["VfpTypeName"] = "Currency";
            row["VfpType"] = 3;
            row["Width"] = 8;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["FieldName"] = "Year";
            row["Ordinal"] = 3;
            row["DataType"] = 131;
            row["VfpTypeName"] = "Numeric";
            row["VfpType"] = 7;
            row["Width"] = 19;
            row["Decimal"] = 0;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Country";
            row["Ordinal"] = 0;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 15;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Lastname";
            row["Ordinal"] = 1;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 20;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Firstname";
            row["Ordinal"] = 2;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 10;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Shippeddate";
            row["Ordinal"] = 3;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 19

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Orderid";
            row["Ordinal"] = 4;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 20

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Saleamount";
            row["Ordinal"] = 5;
            row["DataType"] = 6;
            row["VfpTypeName"] = "Currency";
            row["VfpType"] = 3;
            row["Width"] = 8;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithProcedureName() {
            DataTable dataTable = new DataTable("");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int16));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["FieldName"] = "Productname";
            row["Ordinal"] = 0;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 40;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["FieldName"] = "Total";
            row["Ordinal"] = 1;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int16));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["FieldName"] = "Productname";
            row["Ordinal"] = 0;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 40;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["FieldName"] = "Total";
            row["Ordinal"] = 1;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Productname";
            row["Ordinal"] = 0;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 40;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Unitprice";
            row["Ordinal"] = 1;
            row["DataType"] = 6;
            row["VfpTypeName"] = "Currency";
            row["VfpType"] = 3;
            row["Width"] = 8;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Quantity";
            row["Ordinal"] = 2;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Discount";
            row["Ordinal"] = 3;
            row["DataType"] = 131;
            row["VfpTypeName"] = "Numeric";
            row["VfpType"] = 7;
            row["Width"] = 19;
            row["Decimal"] = 5;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["FieldName"] = "Extendedprice";
            row["Ordinal"] = 4;
            row["DataType"] = 6;
            row["VfpTypeName"] = "Currency";
            row["VfpType"] = 3;
            row["Width"] = 8;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["FieldName"] = "Orderid";
            row["Ordinal"] = 0;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["FieldName"] = "Orderdate";
            row["Ordinal"] = 1;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["FieldName"] = "Requireddate";
            row["Ordinal"] = 2;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["FieldName"] = "Shippeddate";
            row["Ordinal"] = 3;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["FieldName"] = "Shippeddate";
            row["Ordinal"] = 0;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["FieldName"] = "Orderid";
            row["Ordinal"] = 1;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["FieldName"] = "Subtotal";
            row["Ordinal"] = 2;
            row["DataType"] = 6;
            row["VfpTypeName"] = "Currency";
            row["VfpType"] = 3;
            row["Width"] = 8;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["FieldName"] = "Year";
            row["Ordinal"] = 3;
            row["DataType"] = 131;
            row["VfpTypeName"] = "Numeric";
            row["VfpType"] = 7;
            row["Width"] = 19;
            row["Decimal"] = 0;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Country";
            row["Ordinal"] = 0;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 15;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Lastname";
            row["Ordinal"] = 1;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 20;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Firstname";
            row["Ordinal"] = 2;
            row["DataType"] = 129;
            row["VfpTypeName"] = "Character";
            row["VfpType"] = 1;
            row["Width"] = 10;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Shippeddate";
            row["Ordinal"] = 3;
            row["DataType"] = 133;
            row["VfpTypeName"] = "Date";
            row["VfpType"] = 4;
            row["Width"] = 6;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 19

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Orderid";
            row["Ordinal"] = 4;
            row["DataType"] = 3;
            row["VfpTypeName"] = "Integer";
            row["VfpType"] = 13;
            row["Width"] = 4;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 20

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["FieldName"] = "Saleamount";
            row["Ordinal"] = 5;
            row["DataType"] = 6;
            row["VfpTypeName"] = "Currency";
            row["VfpType"] = 3;
            row["Width"] = 8;
            row["Decimal"] = 255;
            row["Nullable"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}