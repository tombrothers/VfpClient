using System.Data;

namespace VfpClient.Tests.Schema {
    class ForeignKeySchemaProviderExpected {
        public static DataTable GetSchemaWithTableNameNoForeignKeys() {
            DataTable dataTable = new DataTable("Foreign_Keys");

            #region columns

            dataTable.Columns.Add("PkTableName", typeof(System.String));
            dataTable.Columns.Add("PkFieldName", typeof(System.String));
            dataTable.Columns.Add("FkTableName", typeof(System.String));
            dataTable.Columns.Add("FkFieldName", typeof(System.String));
            dataTable.Columns.Add("PkIndexName", typeof(System.String));
            dataTable.Columns.Add("FkIndexName", typeof(System.String));
            dataTable.Columns.Add("ForeignKeyName", typeof(System.String));

            #endregion columns

            return dataTable;
        }

        public static DataTable GetSchemaWithTableName() {
            DataTable dataTable = new DataTable("ForeignKeys");

            #region columns

            dataTable.Columns.Add("PkTableName", typeof(System.String));
            dataTable.Columns.Add("PkFieldName", typeof(System.String));
            dataTable.Columns.Add("FkTableName", typeof(System.String));
            dataTable.Columns.Add("FkFieldName", typeof(System.String));
            dataTable.Columns.Add("PkIndexName", typeof(System.String));
            dataTable.Columns.Add("FkIndexName", typeof(System.String));
            dataTable.Columns.Add("ForeignKeyName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["PkTableName"] = "Customers";
            row["PkFieldName"] = "Customerid";
            row["FkTableName"] = "Orders";
            row["FkFieldName"] = "Customerid";
            row["PkIndexName"] = "Customerid";
            row["FkIndexName"] = "Customerid";
            row["ForeignKeyName"] = "FK___Orders_customerid___Customers_customerid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["PkTableName"] = "Employees";
            row["PkFieldName"] = "Employeeid";
            row["FkTableName"] = "Orders";
            row["FkFieldName"] = "Employeeid";
            row["PkIndexName"] = "Employeeid";
            row["FkIndexName"] = "Employeeid";
            row["ForeignKeyName"] = "FK___Orders_employeeid___Employees_employeeid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["PkTableName"] = "Shippers";
            row["PkFieldName"] = "Shipperid";
            row["FkTableName"] = "Orders";
            row["FkFieldName"] = "Shipvia";
            row["PkIndexName"] = "Shipperid";
            row["FkIndexName"] = "Shipperid";
            row["ForeignKeyName"] = "FK___Orders_shipvia___Shippers_shipperid";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("ForeignKeys");

            #region columns

            dataTable.Columns.Add("PkTableName", typeof(System.String));
            dataTable.Columns.Add("PkFieldName", typeof(System.String));
            dataTable.Columns.Add("FkTableName", typeof(System.String));
            dataTable.Columns.Add("FkFieldName", typeof(System.String));
            dataTable.Columns.Add("PkIndexName", typeof(System.String));
            dataTable.Columns.Add("FkIndexName", typeof(System.String));
            dataTable.Columns.Add("ForeignKeyName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["PkTableName"] = "CustomerDemographics";
            row["PkFieldName"] = "Customertypeid";
            row["FkTableName"] = "CustomerCustomerDemo";
            row["FkFieldName"] = "Customertypeid";
            row["PkIndexName"] = "Custtypeid";
            row["FkIndexName"] = "Custtypeid";
            row["ForeignKeyName"] = "FK___CustomerCustomerDemo_customertypeid___CustomerDemographics_customertypeid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["PkTableName"] = "Customers";
            row["PkFieldName"] = "Customerid";
            row["FkTableName"] = "CustomerCustomerDemo";
            row["FkFieldName"] = "Customerid";
            row["PkIndexName"] = "Customerid";
            row["FkIndexName"] = "Customerid";
            row["ForeignKeyName"] = "FK___CustomerCustomerDemo_customerid___Customers_customerid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["PkTableName"] = "Employees";
            row["PkFieldName"] = "Employeeid";
            row["FkTableName"] = "Employees";
            row["FkFieldName"] = "Reportsto";
            row["PkIndexName"] = "Employeeid";
            row["FkIndexName"] = "Reportsto";
            row["ForeignKeyName"] = "FK___Employees_reportsto___Employees_employeeid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["PkTableName"] = "Territories";
            row["PkFieldName"] = "Territoryid";
            row["FkTableName"] = "EmployeeTerritories";
            row["FkFieldName"] = "Territoryid";
            row["PkIndexName"] = "Territoryi";
            row["FkIndexName"] = "Territoryi";
            row["ForeignKeyName"] = "FK___EmployeeTerritories_territoryid___Territories_territoryid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["PkTableName"] = "Employees";
            row["PkFieldName"] = "Employeeid";
            row["FkTableName"] = "EmployeeTerritories";
            row["FkFieldName"] = "Employeeid";
            row["PkIndexName"] = "Employeeid";
            row["FkIndexName"] = "Employeeid";
            row["ForeignKeyName"] = "FK___EmployeeTerritories_employeeid___Employees_employeeid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["PkTableName"] = "Orders";
            row["PkFieldName"] = "Orderid";
            row["FkTableName"] = "OrderDetails";
            row["FkFieldName"] = "Orderid";
            row["PkIndexName"] = "Orderid";
            row["FkIndexName"] = "Orderid";
            row["ForeignKeyName"] = "FK___OrderDetails_orderid___Orders_orderid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["PkTableName"] = "Products";
            row["PkFieldName"] = "Productid";
            row["FkTableName"] = "OrderDetails";
            row["FkFieldName"] = "Productid";
            row["PkIndexName"] = "Productid";
            row["FkIndexName"] = "Productid";
            row["ForeignKeyName"] = "FK___OrderDetails_productid___Products_productid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["PkTableName"] = "Customers";
            row["PkFieldName"] = "Customerid";
            row["FkTableName"] = "Orders";
            row["FkFieldName"] = "Customerid";
            row["PkIndexName"] = "Customerid";
            row["FkIndexName"] = "Customerid";
            row["ForeignKeyName"] = "FK___Orders_customerid___Customers_customerid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["PkTableName"] = "Employees";
            row["PkFieldName"] = "Employeeid";
            row["FkTableName"] = "Orders";
            row["FkFieldName"] = "Employeeid";
            row["PkIndexName"] = "Employeeid";
            row["FkIndexName"] = "Employeeid";
            row["ForeignKeyName"] = "FK___Orders_employeeid___Employees_employeeid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["PkTableName"] = "Shippers";
            row["PkFieldName"] = "Shipperid";
            row["FkTableName"] = "Orders";
            row["FkFieldName"] = "Shipvia";
            row["PkIndexName"] = "Shipperid";
            row["FkIndexName"] = "Shipperid";
            row["ForeignKeyName"] = "FK___Orders_shipvia___Shippers_shipperid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["PkTableName"] = "Suppliers";
            row["PkFieldName"] = "Supplierid";
            row["FkTableName"] = "Products";
            row["FkFieldName"] = "Supplierid";
            row["PkIndexName"] = "Supplierid";
            row["FkIndexName"] = "Supplierid";
            row["ForeignKeyName"] = "FK___Products_supplierid___Suppliers_supplierid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["PkTableName"] = "Categories";
            row["PkFieldName"] = "Categoryid";
            row["FkTableName"] = "Products";
            row["FkFieldName"] = "Categoryid";
            row["PkIndexName"] = "Categoryid";
            row["FkIndexName"] = "Categoryid";
            row["ForeignKeyName"] = "FK___Products_categoryid___Categories_categoryid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["PkTableName"] = "Region";
            row["PkFieldName"] = "Regionid";
            row["FkTableName"] = "Territories";
            row["FkFieldName"] = "Regionid";
            row["PkIndexName"] = "Regionid";
            row["FkIndexName"] = "Regionid";
            row["ForeignKeyName"] = "FK___Territories_regionid___Region_regionid";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
