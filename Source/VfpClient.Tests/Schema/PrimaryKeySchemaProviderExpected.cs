using System.Data;

namespace VfpClient.Tests.Schema {
    class PrimaryKeySchemaProviderExpected {
        public static DataTable GetSchemaWithTableName() {
            DataTable dataTable = new DataTable("PrimaryKeys");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Ordinal", typeof(System.Int64));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("AutoInc", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Customerid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Customerid";
            row["AutoInc"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("PrimaryKeys");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Ordinal", typeof(System.Int64));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("AutoInc", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Categories";
            row["FieldName"] = "Categoryid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Categoryid";
            row["AutoInc"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "CustomerDemographics";
            row["FieldName"] = "Customertypeid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Custtypeid";
            row["AutoInc"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "Customers";
            row["FieldName"] = "Customerid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Customerid";
            row["AutoInc"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Employees";
            row["FieldName"] = "Employeeid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Employeeid";
            row["AutoInc"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["FieldName"] = "Orderid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Primarykey";
            row["AutoInc"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["TableName"] = "OrderDetails";
            row["FieldName"] = "Productid";
            row["Ordinal"] = 2;
            row["IndexName"] = "Primarykey";
            row["AutoInc"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["TableName"] = "Orders";
            row["FieldName"] = "Orderid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Orderid";
            row["AutoInc"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["TableName"] = "Products";
            row["FieldName"] = "Productid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Productid";
            row["AutoInc"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["TableName"] = "Region";
            row["FieldName"] = "Regionid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Regionid";
            row["AutoInc"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["TableName"] = "Shippers";
            row["FieldName"] = "Shipperid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Shipperid";
            row["AutoInc"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["TableName"] = "Suppliers";
            row["FieldName"] = "Supplierid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Supplierid";
            row["AutoInc"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["TableName"] = "Territories";
            row["FieldName"] = "Territoryid";
            row["Ordinal"] = 1;
            row["IndexName"] = "Territoryi";
            row["AutoInc"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
