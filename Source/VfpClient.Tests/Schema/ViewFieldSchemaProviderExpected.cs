using System;
using System.Data;

namespace VfpClient.Tests.Schema {
    class ViewFieldSchemaProviderExpected {
        public static DataTable GetSchemaWithViewNameAndFieldName() {
            DataTable dataTable = new DataTable("ViewFields");

            #region columns

            dataTable.Columns.Add("ViewName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("KeyField", typeof(System.Boolean));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("Updatable", typeof(System.Boolean));
            dataTable.Columns.Add("UpdateName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "categoryid";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithFieldName() {
            DataTable dataTable = new DataTable("ViewFields");

            #region columns

            dataTable.Columns.Add("ViewName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("KeyField", typeof(System.Boolean));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("Updatable", typeof(System.Boolean));
            dataTable.Columns.Add("UpdateName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "categoryid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_By_Category";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "Categories.categoryid";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithViewName() {
            DataTable dataTable = new DataTable("ViewFields");

            #region columns

            dataTable.Columns.Add("ViewName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("KeyField", typeof(System.Boolean));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("Updatable", typeof(System.Boolean));
            dataTable.Columns.Add("UpdateName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Productid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "northwind!Products.productid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Supplierid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.supplierid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "categoryid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Quantityperunit";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 20;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.quantityperunit";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Unitprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.unitprice";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Unitsinstock";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.unitsinstock";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Unitsonorder";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.unitsonorder";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Reorderlevel";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.reorderlevel";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Discontinued";
            row["VfpType"] = 6;
            row["VfpTypeName"] = "Logical";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.discontinued";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Categoryname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Categories.categoryname";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("ViewFields");

            #region columns

            dataTable.Columns.Add("ViewName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("KeyField", typeof(System.Boolean));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("Updatable", typeof(System.Boolean));
            dataTable.Columns.Add("UpdateName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Productid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "northwind!Products.productid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Supplierid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.supplierid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "categoryid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Quantityperunit";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 20;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.quantityperunit";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Unitprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.unitprice";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Unitsinstock";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.unitsinstock";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Unitsonorder";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.unitsonorder";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Reorderlevel";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.reorderlevel";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Discontinued";
            row["VfpType"] = 6;
            row["VfpTypeName"] = "Logical";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Products.discontinued";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ViewName"] = "Alphabetical_List_Of_Products";
            row["FieldName"] = "Categoryname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "northwind!Categories.categoryname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["ViewName"] = "Category_Sales_For_1997";
            row["FieldName"] = "Categoryname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Product_Sales_For_1997.categoryname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["ViewName"] = "Category_Sales_For_1997";
            row["FieldName"] = "Categorysales";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "categorysales";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["ViewName"] = "Current_Product_List";
            row["FieldName"] = "Productid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "productid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["ViewName"] = "Current_Product_List";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["ViewName"] = "Customer_And_Suppliers_By_City";
            row["FieldName"] = "City";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.city";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["ViewName"] = "Customer_And_Suppliers_By_City";
            row["FieldName"] = "Companyname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.companyname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["ViewName"] = "Customer_And_Suppliers_By_City";
            row["FieldName"] = "Contactname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 30;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.contactname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["ViewName"] = "Customer_And_Suppliers_By_City";
            row["FieldName"] = "Relationship";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 9;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "relationship";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 19

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Shipname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "shipname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 20

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Shipaddress";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 60;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "shipaddress";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 21

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Shipcity";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "shipcity";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 22

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Shipregion";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "shipregion";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 23

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Shippostalcode";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "shippostalcode";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 24

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Shipcountry";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "shipcountry";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 25

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Customerid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 5;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "customerid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 26

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Customername";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "customername";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 27

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Address";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 60;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "address";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 28

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "City";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "city";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 29

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Region";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "region";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 30

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Postalcode";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 12;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "postalcode";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 31

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Country";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 13;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "country";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 32

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Salesperson";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 31;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 14;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "salesperson";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 33

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Orderid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 15;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "orderid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 34

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Orderdate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 16;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "orderdate";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 35

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Requireddate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 17;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "requireddate";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 36

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Shippeddate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 18;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "shippeddate";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 37

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Shippername";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 19;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "shippername";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 38

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Productid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 20;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "productid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 39

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 21;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 40

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Unitprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 22;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "unitprice";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 41

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Quantity";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 23;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "quantity";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 42

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Discount";
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["Width"] = 20;
            row["Decimal"] = 5;
            row["Ordinal"] = 24;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "discount";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 43

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Extendedprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 25;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "extendedprice";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 44

            row = dataTable.NewRow();
            row["ViewName"] = "Invoices";
            row["FieldName"] = "Freight";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 26;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "freight";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 45

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Details_Extended";
            row["FieldName"] = "Orderid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "OrderDetails.orderid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 46

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Details_Extended";
            row["FieldName"] = "Productid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "OrderDetails.productid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 47

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Details_Extended";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 48

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Details_Extended";
            row["FieldName"] = "Unitprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "OrderDetails.unitprice";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 49

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Details_Extended";
            row["FieldName"] = "Quantity";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "OrderDetails.quantity";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 50

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Details_Extended";
            row["FieldName"] = "Discount";
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["Width"] = 20;
            row["Decimal"] = 5;
            row["Ordinal"] = 6;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "OrderDetails.discount";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 51

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Details_Extended";
            row["FieldName"] = "Extendedprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "extendedprice";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 52

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Subtotals";
            row["FieldName"] = "Orderid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "OrderDetails.orderid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 53

            row = dataTable.NewRow();
            row["ViewName"] = "Order_Subtotals";
            row["FieldName"] = "Subtotal";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "subtotal";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 54

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Orderid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "Orders.orderid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 55

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Customerid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 5;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.customerid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 56

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Employeeid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.employeeid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 57

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Orderdate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.orderdate";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 58

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Requireddate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.requireddate";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 59

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Shippeddate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shippeddate";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 60

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Shipvia";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shipvia";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 61

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Freight";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.freight";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 62

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Shipname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shipname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 63

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Shipaddress";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 60;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shipaddress";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 64

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Shipcity";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shipcity";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 65

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Shipregion";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 12;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shipregion";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 66

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Shippostalcode";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 13;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shippostalcode";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 67

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Shipcountry";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 14;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shipcountry";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 68

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Companyname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 15;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.companyname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 69

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Address";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 60;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 16;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.address";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 70

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "City";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 17;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.city";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 71

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Region";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 18;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.region";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 72

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Postalcode";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 19;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.postalcode";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 73

            row = dataTable.NewRow();
            row["ViewName"] = "Orders_Qry";
            row["FieldName"] = "Country";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 20;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.country";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 74

            row = dataTable.NewRow();
            row["ViewName"] = "Product_Sales_For_1997";
            row["FieldName"] = "Categoryname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "categoryname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 75

            row = dataTable.NewRow();
            row["ViewName"] = "Product_Sales_For_1997";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 76

            row = dataTable.NewRow();
            row["ViewName"] = "Product_Sales_For_1997";
            row["FieldName"] = "Productsales";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "productsales";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 77

            row = dataTable.NewRow();
            row["ViewName"] = "Products_Above_Average_Price";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 78

            row = dataTable.NewRow();
            row["ViewName"] = "Products_Above_Average_Price";
            row["FieldName"] = "Unitprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.unitprice";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 79

            row = dataTable.NewRow();
            row["ViewName"] = "Products_By_Category";
            row["FieldName"] = "Categoryname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Categories.categoryname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 80

            row = dataTable.NewRow();
            row["ViewName"] = "Products_By_Category";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 81

            row = dataTable.NewRow();
            row["ViewName"] = "Products_By_Category";
            row["FieldName"] = "Quantityperunit";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 20;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.quantityperunit";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 82

            row = dataTable.NewRow();
            row["ViewName"] = "Products_By_Category";
            row["FieldName"] = "Unitsinstock";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.unitsinstock";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 83

            row = dataTable.NewRow();
            row["ViewName"] = "Products_By_Category";
            row["FieldName"] = "Discontinued";
            row["VfpType"] = 6;
            row["VfpTypeName"] = "Logical";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.discontinued";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 84

            row = dataTable.NewRow();
            row["ViewName"] = "Quarterly_Orders";
            row["FieldName"] = "Customerid";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 5;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "Customers.customerid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 85

            row = dataTable.NewRow();
            row["ViewName"] = "Quarterly_Orders";
            row["FieldName"] = "Companyname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.companyname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 86

            row = dataTable.NewRow();
            row["ViewName"] = "Quarterly_Orders";
            row["FieldName"] = "City";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.city";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 87

            row = dataTable.NewRow();
            row["ViewName"] = "Quarterly_Orders";
            row["FieldName"] = "Country";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.country";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 88

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_By_Category";
            row["FieldName"] = "Categoryid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "Categories.categoryid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 89

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_By_Category";
            row["FieldName"] = "Categoryname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 15;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Categories.categoryname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 90

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_By_Category";
            row["FieldName"] = "Productname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.productname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 91

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_By_Category";
            row["FieldName"] = "Productsales";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "productsales";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 92

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_Totals_By_Amount";
            row["FieldName"] = "Saleamount";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "saleamount";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 93

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_Totals_By_Amount";
            row["FieldName"] = "Orderid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = true;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "Orders.orderid";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 94

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_Totals_By_Amount";
            row["FieldName"] = "Companyname";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Customers.companyname";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 95

            row = dataTable.NewRow();
            row["ViewName"] = "Sales_Totals_By_Amount";
            row["FieldName"] = "Shippeddate";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Orders.shippeddate";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 96

            row = dataTable.NewRow();
            row["ViewName"] = "Summary_Of_Sales_By_Quarter";
            row["FieldName"] = "Year";
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["Width"] = 5;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "year";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 97

            row = dataTable.NewRow();
            row["ViewName"] = "Summary_Of_Sales_By_Quarter";
            row["FieldName"] = "Quarter";
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["Width"] = 9;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "quarter";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 98

            row = dataTable.NewRow();
            row["ViewName"] = "Summary_Of_Sales_By_Quarter";
            row["FieldName"] = "Total";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "total";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 99

            row = dataTable.NewRow();
            row["ViewName"] = "Summary_Of_Sales_By_Year";
            row["FieldName"] = "Year";
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["Width"] = 5;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "year";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 100

            row = dataTable.NewRow();
            row["ViewName"] = "Summary_Of_Sales_By_Year";
            row["FieldName"] = "Total";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "total";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 101

            row = dataTable.NewRow();
            row["ViewName"] = "Ten_Most_Expensive_Products";
            row["FieldName"] = "Tenmostexpensiveproducts";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 40;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = false;
            row["UpdateName"] = "tenmostexpensiveproducts";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 102

            row = dataTable.NewRow();
            row["ViewName"] = "Ten_Most_Expensive_Products";
            row["FieldName"] = "Unitprice";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = true;
            row["Caption"] = "";
            row["Comment"] = "";
            row["DisplayClass"] = "";
            row["DisplayClassLibrary"] = "";
            row["DefaultValue"] = "";
            row["KeyField"] = false;
            row["RuleExpression"] = "";
            row["RuleText"] = "";
            row["Updatable"] = true;
            row["UpdateName"] = "Products.unitprice";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
