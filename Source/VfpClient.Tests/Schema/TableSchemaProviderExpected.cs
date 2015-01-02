using System.Data;

namespace VfpClient.Tests.Schema {
    class TableSchemaProviderExpected {
        public static DataTable GetSchemaWithTableName() {
            DataTable dataTable = new DataTable("Tables");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DeleteTrigger", typeof(System.String));
            dataTable.Columns.Add("InsertTrigger", typeof(System.String));
            dataTable.Columns.Add("Path", typeof(System.String));
            dataTable.Columns.Add("PrimaryKey", typeof(System.String));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("UpdateTrigger", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_customers()";
            row["InsertTrigger"] = "";
            row["Path"] = "customers.dbf";
            row["PrimaryKey"] = "customerid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_customers()";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("Tables");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DeleteTrigger", typeof(System.String));
            dataTable.Columns.Add("InsertTrigger", typeof(System.String));
            dataTable.Columns.Add("Path", typeof(System.String));
            dataTable.Columns.Add("PrimaryKey", typeof(System.String));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("UpdateTrigger", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_categories()";
            row["InsertTrigger"] = "";
            row["Path"] = "categories.dbf";
            row["PrimaryKey"] = "categoryid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_categories()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "CustomerCustomerDemo";
            row["Comment"] = "";
            row["DeleteTrigger"] = "";
            row["InsertTrigger"] = "";
            row["Path"] = "customercustomerdemo.dbf";
            row["PrimaryKey"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "CustomerDemographics";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_customerdemographics()";
            row["InsertTrigger"] = "";
            row["Path"] = "customerdemographics.dbf";
            row["PrimaryKey"] = "custtypeid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_customerdemographics()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_customers()";
            row["InsertTrigger"] = "";
            row["Path"] = "customers.dbf";
            row["PrimaryKey"] = "customerid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_customers()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_employees()";
            row["InsertTrigger"] = "";
            row["Path"] = "employees.dbf";
            row["PrimaryKey"] = "employeeid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_employees()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["TableName"] = "EmployeeTerritories";
            row["Comment"] = "";
            row["DeleteTrigger"] = "";
            row["InsertTrigger"] = "";
            row["Path"] = "employeeterritories.dbf";
            row["PrimaryKey"] = "";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["Comment"] = "";
            row["DeleteTrigger"] = "";
            row["InsertTrigger"] = "";
            row["Path"] = "orderdetails.dbf";
            row["PrimaryKey"] = "primarykey";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_orders()";
            row["InsertTrigger"] = "";
            row["Path"] = "orders.dbf";
            row["PrimaryKey"] = "orderid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_orders()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_products()";
            row["InsertTrigger"] = "";
            row["Path"] = "products.dbf";
            row["PrimaryKey"] = "productid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_products()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["TableName"] = "Region";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_region()";
            row["InsertTrigger"] = "";
            row["Path"] = "region.dbf";
            row["PrimaryKey"] = "regionid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_region()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["TableName"] = "Shippers";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_shippers()";
            row["InsertTrigger"] = "";
            row["Path"] = "shippers.dbf";
            row["PrimaryKey"] = "shipperid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_shippers()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_suppliers()";
            row["InsertTrigger"] = "";
            row["Path"] = "suppliers.dbf";
            row["PrimaryKey"] = "supplierid";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_suppliers()";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["TableName"] = "Territories";
            row["Comment"] = "";
            row["DeleteTrigger"] = "__ri_delete_territories()";
            row["InsertTrigger"] = "";
            row["Path"] = "territories.dbf";
            row["PrimaryKey"] = "territoryi";
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["UpdateTrigger"] = "__ri_update_territories()";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}