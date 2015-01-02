using System;
using System.Data;

namespace VfpClient.Tests.Schema {
    class IndexSchemaProviderExpected {
        public static DataTable GetSchemaWithTableNameAndFieldName() {
            DataTable dataTable = new DataTable("Indexes");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("PrimaryKey", typeof(System.Boolean));
            dataTable.Columns.Add("Unique", typeof(System.Boolean));
            dataTable.Columns.Add("Ordinal", typeof(System.Int64));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Expression", typeof(System.String));
            dataTable.Columns.Add("AutoInc", typeof(System.Boolean));
            dataTable.Columns.Add("Candidate", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["IndexName"] = "Categoryid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Categoryid";
            row["Expression"] = "categoryid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithIndexName() {
            DataTable dataTable = new DataTable("Indexes");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("PrimaryKey", typeof(System.Boolean));
            dataTable.Columns.Add("Unique", typeof(System.Boolean));
            dataTable.Columns.Add("Ordinal", typeof(System.Int64));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Expression", typeof(System.String));
            dataTable.Columns.Add("AutoInc", typeof(System.Boolean));
            dataTable.Columns.Add("Candidate", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["IndexName"] = "Categoryid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Categoryid";
            row["Expression"] = "categoryid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["IndexName"] = "Categoryid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Categoryid";
            row["Expression"] = "categoryid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithTableName() {
            DataTable dataTable = new DataTable("Indexes");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("PrimaryKey", typeof(System.Boolean));
            dataTable.Columns.Add("Unique", typeof(System.Boolean));
            dataTable.Columns.Add("Ordinal", typeof(System.Int64));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Expression", typeof(System.String));
            dataTable.Columns.Add("AutoInc", typeof(System.Boolean));
            dataTable.Columns.Add("Candidate", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["IndexName"] = "Categoryid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Categoryid";
            row["Expression"] = "categoryid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["IndexName"] = "Categorynm";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Categoryname";
            row["Expression"] = "UPPER(categoryname)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("Indexes");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("PrimaryKey", typeof(System.Boolean));
            dataTable.Columns.Add("Unique", typeof(System.Boolean));
            dataTable.Columns.Add("Ordinal", typeof(System.Int64));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Expression", typeof(System.String));
            dataTable.Columns.Add("AutoInc", typeof(System.Boolean));
            dataTable.Columns.Add("Candidate", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["IndexName"] = "Categoryid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Categoryid";
            row["Expression"] = "categoryid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["IndexName"] = "Categoryid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Categoryid";
            row["Expression"] = "categoryid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["IndexName"] = "Categorynm";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Categoryname";
            row["Expression"] = "UPPER(categoryname)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["IndexName"] = "City";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "City";
            row["Expression"] = "UPPER(city)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["IndexName"] = "Companynam";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Companyname";
            row["Expression"] = "UPPER(companyname)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["IndexName"] = "Companynam";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Companyname";
            row["Expression"] = "UPPER(companyname)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["TableName"] = "CustomerCustomerDemo";
            row["IndexName"] = "Customerid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Customerid";
            row["Expression"] = "ALLTRIM(UPPER(customerid))";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["IndexName"] = "Customerid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Customerid";
            row["Expression"] = "customerid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["IndexName"] = "Customerid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Customerid";
            row["Expression"] = "customerid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["TableName"] = "CustomerCustomerDemo";
            row["IndexName"] = "Custtypeid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Customertypeid";
            row["Expression"] = "ALLTRIM(UPPER(customertypeid))";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["TableName"] = "CustomerDemographics";
            row["IndexName"] = "Custtypeid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Customertypeid";
            row["Expression"] = "ALLTRIM(UPPER(customertypeid))";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["IndexName"] = "Employeeid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Employeeid";
            row["Expression"] = "employeeid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["TableName"] = "EmployeeTerritories";
            row["IndexName"] = "Employeeid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Employeeid";
            row["Expression"] = "employeeid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["IndexName"] = "Employeeid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Employeeid";
            row["Expression"] = "employeeid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["IndexName"] = "Lastname";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Lastname";
            row["Expression"] = "UPPER(lastname)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["IndexName"] = "Orderdate";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Orderdate";
            row["Expression"] = "orderdate";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["IndexName"] = "Orderid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Orderid";
            row["Expression"] = "orderid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["IndexName"] = "Orderid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Orderid";
            row["Expression"] = "orderid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["IndexName"] = "Postalcode";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Postalcode";
            row["Expression"] = "UPPER(postalcode)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 19

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["IndexName"] = "Postalcode";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Postalcode";
            row["Expression"] = "UPPER(postalcode)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 20

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["IndexName"] = "Postalcode";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Postalcode";
            row["Expression"] = "postalcode";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 21

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["IndexName"] = "Primarykey";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Orderid";
            row["Expression"] = "STR(orderid)+STR(productid)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 22

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["IndexName"] = "Primarykey";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 2;
            row["FieldName"] = "Productid";
            row["Expression"] = "STR(orderid)+STR(productid)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 23

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["IndexName"] = "Productid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Productid";
            row["Expression"] = "productid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 24

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["IndexName"] = "Productid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Productid";
            row["Expression"] = "productid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 25

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["IndexName"] = "Productnam";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Productname";
            row["Expression"] = "UPPER(productname)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 26

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["IndexName"] = "Region";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Region";
            row["Expression"] = "UPPER(region)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 27

            row = dataTable.NewRow();
            row["TableName"] = "Region";
            row["IndexName"] = "Regionid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Regionid";
            row["Expression"] = "regionid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 28

            row = dataTable.NewRow();
            row["TableName"] = "Territories";
            row["IndexName"] = "Regionid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Regionid";
            row["Expression"] = "regionid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 29

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["IndexName"] = "Reportsto";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Reportsto";
            row["Expression"] = "reportsto";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 30

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["IndexName"] = "Shippeddat";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Shippeddate";
            row["Expression"] = "shippeddate";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 31

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["IndexName"] = "Shipperid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Shipvia";
            row["Expression"] = "shipvia";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 32

            row = dataTable.NewRow();
            row["TableName"] = "Shippers";
            row["IndexName"] = "Shipperid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Shipperid";
            row["Expression"] = "shipperid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 33

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["IndexName"] = "Supplierid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Supplierid";
            row["Expression"] = "supplierid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 34

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["IndexName"] = "Supplierid";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Supplierid";
            row["Expression"] = "supplierid";
            row["AutoInc"] = true;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 35

            row = dataTable.NewRow();
            row["TableName"] = "EmployeeTerritories";
            row["IndexName"] = "Territoryi";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Territoryid";
            row["Expression"] = "territoryid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 36

            row = dataTable.NewRow();
            row["TableName"] = "Territories";
            row["IndexName"] = "Territoryi";
            row["PrimaryKey"] = true;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Territoryid";
            row["Expression"] = "ALLTRIM(UPPER(territoryid))";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
