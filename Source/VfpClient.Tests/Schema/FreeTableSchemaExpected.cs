using System;
using System.Data;

namespace VfpClient.Tests.Schema {
    class FreeTableSchemaExpected {
        public static DataTable GetDataTypesSchema() {
            DataTable dataTable = new DataTable("DataTypes");

            #region columns

            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("ColumnSize", typeof(System.Int64));
            dataTable.Columns.Add("CreateFormat", typeof(System.String));
            dataTable.Columns.Add("CreateParameters", typeof(System.String));
            dataTable.Columns.Add("DataType", typeof(System.String));
            dataTable.Columns.Add("IsAutoIncrementable", typeof(System.Boolean));
            dataTable.Columns.Add("IsFixedLength", typeof(System.Boolean));
            dataTable.Columns.Add("IsFixedPrecisionScale", typeof(System.Boolean));
            dataTable.Columns.Add("IsLong", typeof(System.Boolean));
            dataTable.Columns.Add("IsNullable", typeof(System.Boolean));
            dataTable.Columns.Add("IsSearchable", typeof(System.Boolean));
            dataTable.Columns.Add("IsSearchableWithLike", typeof(System.Boolean));
            dataTable.Columns.Add("MaximumScale", typeof(System.Int16));
            dataTable.Columns.Add("MinimumScale", typeof(System.Int16));
            dataTable.Columns.Add("LiteralPrefix", typeof(System.String));
            dataTable.Columns.Add("LiteralSuffix", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["ColumnSize"] = 10;
            row["CreateFormat"] = "I";
            row["CreateParameters"] = DBNull.Value;
            row["DataType"] = "System.Int32";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = true;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = DBNull.Value;
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["VfpType"] = 11;
            row["VfpTypeName"] = "Float";
            row["ColumnSize"] = 20;
            row["CreateFormat"] = "F({0}, {1})";
            row["CreateParameters"] = "width, decimal places";
            row["DataType"] = "System.Decimal";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = false;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = 19;
            row["MinimumScale"] = 0;
            row["LiteralPrefix"] = DBNull.Value;
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["ColumnSize"] = 20;
            row["CreateFormat"] = "N({0}, {1})";
            row["CreateParameters"] = "width, decimal places";
            row["DataType"] = "System.Decimal";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = false;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = 19;
            row["MinimumScale"] = 0;
            row["LiteralPrefix"] = DBNull.Value;
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["VfpType"] = 10;
            row["VfpTypeName"] = "Double";
            row["ColumnSize"] = 15;
            row["CreateFormat"] = "B({0})";
            row["CreateParameters"] = "decimal places";
            row["DataType"] = "System.Double";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = true;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = DBNull.Value;
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["ColumnSize"] = 19;
            row["CreateFormat"] = "Y";
            row["CreateParameters"] = DBNull.Value;
            row["DataType"] = "System.Decimal";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = true;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = "$";
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["ColumnSize"] = 10;
            row["CreateFormat"] = "D";
            row["CreateParameters"] = DBNull.Value;
            row["DataType"] = "System.DateTime";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = true;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = "{";
            row["LiteralSuffix"] = "}";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["VfpType"] = 5;
            row["VfpTypeName"] = "DateTime";
            row["ColumnSize"] = 19;
            row["CreateFormat"] = "T";
            row["CreateParameters"] = DBNull.Value;
            row["DataType"] = "System.DateTime";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = true;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = "{";
            row["LiteralSuffix"] = "}";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["VfpType"] = 6;
            row["VfpTypeName"] = "Logical";
            row["ColumnSize"] = 1;
            row["CreateFormat"] = "L";
            row["CreateParameters"] = DBNull.Value;
            row["DataType"] = "System.Boolean";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = true;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = DBNull.Value;
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["VfpType"] = 12;
            row["VfpTypeName"] = "General";
            row["ColumnSize"] = 2147483647;
            row["CreateFormat"] = "G";
            row["CreateParameters"] = DBNull.Value;
            row["DataType"] = "System.Byte[]";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = false;
            row["IsFixedPrecisionScale"] = false;
            row["IsLong"] = true;
            row["IsNullable"] = true;
            row["IsSearchable"] = false;
            row["IsSearchableWithLike"] = false;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = DBNull.Value;
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["ColumnSize"] = 2147483647;
            row["CreateFormat"] = "M";
            row["CreateParameters"] = DBNull.Value;
            row["DataType"] = "System.String";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = false;
            row["IsFixedPrecisionScale"] = false;
            row["IsLong"] = true;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = true;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = "'";
            row["LiteralSuffix"] = "'";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["ColumnSize"] = 254;
            row["CreateFormat"] = "C({0})";
            row["CreateParameters"] = "length";
            row["DataType"] = "System.String";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = true;
            row["IsFixedPrecisionScale"] = false;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = true;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = "'";
            row["LiteralSuffix"] = "'";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["VfpType"] = 17;
            row["VfpTypeName"] = "Varchar";
            row["ColumnSize"] = 254;
            row["CreateFormat"] = "V({0})";
            row["CreateParameters"] = "max length";
            row["DataType"] = "System.String";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = false;
            row["IsFixedPrecisionScale"] = false;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = true;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = "'";
            row["LiteralSuffix"] = "'";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["VfpType"] = 0;
            row["VfpTypeName"] = "Blob";
            row["ColumnSize"] = 2147483647;
            row["CreateFormat"] = "W";
            row["CreateParameters"] = DBNull.Value;
            row["DataType"] = "System.Byte[]";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = false;
            row["IsFixedPrecisionScale"] = false;
            row["IsLong"] = true;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = true;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = "0h";
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["VfpType"] = 8;
            row["VfpTypeName"] = "Varbinary";
            row["ColumnSize"] = 254;
            row["CreateFormat"] = "Q({0})";
            row["CreateParameters"] = "max length";
            row["DataType"] = "System.Byte[]";
            row["IsAutoIncrementable"] = false;
            row["IsFixedLength"] = false;
            row["IsFixedPrecisionScale"] = false;
            row["IsLong"] = false;
            row["IsNullable"] = true;
            row["IsSearchable"] = true;
            row["IsSearchableWithLike"] = true;
            row["MaximumScale"] = DBNull.Value;
            row["MinimumScale"] = DBNull.Value;
            row["LiteralPrefix"] = "0h";
            row["LiteralSuffix"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetCandidateKeySchemaWithTableNameAndNoTablesWithMultipleCandidateKeys() {
            DataTable dataTable = new DataTable("");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["IndexName"] = "Flagfield";
            row["FieldName"] = "Flagfield";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetCandidateKeySchemaWithTableName() {
            DataTable dataTable = new DataTable("CandidateKeys");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["IndexName"] = "Flagfield";
            row["FieldName"] = "Flagfield";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetCandidateKeySchema() {
            DataTable dataTable = new DataTable("CandidateKeys");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["IndexName"] = "Flagfield";
            row["FieldName"] = "Flagfield";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["IndexName"] = "Ifield";
            row["FieldName"] = "Ifield";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "Candidates";
            row["IndexName"] = "Key1";
            row["FieldName"] = "Key1";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Candidates";
            row["IndexName"] = "Key2";
            row["FieldName"] = "Key2";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetForeignKeySchema() {
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

        public static DataTable GetPrimaryKeySchema() {
            DataTable dataTable = new DataTable("PrimaryKeys");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("Ordinal", typeof(System.Int64));
            dataTable.Columns.Add("IndexName", typeof(System.String));
            dataTable.Columns.Add("AutoInc", typeof(System.Boolean));

            #endregion columns

            return dataTable;
        }

        public static DataTable GetIndexSchema() {
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
            row["TableName"] = "Sample_C";
            row["IndexName"] = "Dsid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Dsid";
            row["Expression"] = "dsid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["IndexName"] = "Dsid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Dsid";
            row["Expression"] = "dsid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["IndexName"] = "Flagfield";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Flagfield";
            row["Expression"] = "UPPER(flagfield)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["IndexName"] = "Flagfield";
            row["PrimaryKey"] = false;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Flagfield";
            row["Expression"] = "UPPER(flagfield)";
            row["AutoInc"] = false;
            row["Candidate"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["IndexName"] = "Flagid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Flagid";
            row["Expression"] = "flagid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["IndexName"] = "Flagid";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Flagid";
            row["Expression"] = "flagid";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["IndexName"] = "Flaglabel";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Flaglabel";
            row["Expression"] = "UPPER(flaglabel)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["IndexName"] = "Flaglabel";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Flaglabel";
            row["Expression"] = "UPPER(flaglabel)";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["IndexName"] = "Ifield";
            row["PrimaryKey"] = false;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Ifield";
            row["Expression"] = "ifield";
            row["AutoInc"] = false;
            row["Candidate"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["TableName"] = "Candidates";
            row["IndexName"] = "Key1";
            row["PrimaryKey"] = false;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Key1";
            row["Expression"] = "key1";
            row["AutoInc"] = false;
            row["Candidate"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["TableName"] = "Candidates";
            row["IndexName"] = "Key2";
            row["PrimaryKey"] = false;
            row["Unique"] = true;
            row["Ordinal"] = 1;
            row["FieldName"] = "Key2";
            row["Expression"] = "key2";
            row["AutoInc"] = false;
            row["Candidate"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["IndexName"] = "Sequence";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Sequence";
            row["Expression"] = "sequence";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["IndexName"] = "Sequence";
            row["PrimaryKey"] = false;
            row["Unique"] = false;
            row["Ordinal"] = 1;
            row["FieldName"] = "Sequence";
            row["Expression"] = "sequence";
            row["AutoInc"] = false;
            row["Candidate"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetProcedureParameterSchema() {
            DataTable dataTable = new DataTable("ProcedureParameters");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ParameterName", typeof(System.String));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("DataType", typeof(System.Int32));

            #endregion columns

            return dataTable;
        }

        public static DataTable GetProcedureSchema() {
            DataTable dataTable = new DataTable("Procedures");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ProcedureDefinition", typeof(System.String));
            dataTable.Columns.Add("Description", typeof(System.String));
            dataTable.Columns.Add("ReferentialIntegrity", typeof(System.Boolean));

            #endregion columns

            return dataTable;
        }

        public static DataTable GetTableFieldSchema() {
            DataTable dataTable = new DataTable("TableFields");

            #region columns

            dataTable.Columns.Add("TableName", typeof(System.String));
            dataTable.Columns.Add("FieldName", typeof(System.String));
            dataTable.Columns.Add("VfpType", typeof(System.Int32));
            dataTable.Columns.Add("VfpTypeName", typeof(System.String));
            dataTable.Columns.Add("Width", typeof(System.Int32));
            dataTable.Columns.Add("Decimal", typeof(System.Int32));
            dataTable.Columns.Add("Ordinal", typeof(System.Int32));
            dataTable.Columns.Add("Nullable", typeof(System.Boolean));
            dataTable.Columns.Add("Caption", typeof(System.String));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("DefaultValue", typeof(System.String));
            dataTable.Columns.Add("DisplayClass", typeof(System.String));
            dataTable.Columns.Add("DisplayClassLibrary", typeof(System.String));
            dataTable.Columns.Add("Format", typeof(System.String));
            dataTable.Columns.Add("InputMask", typeof(System.String));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Wfield";
            row["VfpType"] = 12;
            row["VfpTypeName"] = "General";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Cfield";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Cfield2";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Yfield";
            row["VfpType"] = 3;
            row["VfpTypeName"] = "Currency";
            row["Width"] = 8;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Dfield";
            row["VfpType"] = 4;
            row["VfpTypeName"] = "Date";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Tfield";
            row["VfpType"] = 5;
            row["VfpTypeName"] = "DateTime";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Bfield";
            row["VfpType"] = 10;
            row["VfpTypeName"] = "Double";
            row["Width"] = 8;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Ffield";
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["Width"] = 10;
            row["Decimal"] = 0;
            row["Ordinal"] = 8;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Gfield";
            row["VfpType"] = 12;
            row["VfpTypeName"] = "General";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Ifield";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Lfield";
            row["VfpType"] = 6;
            row["VfpTypeName"] = "Logical";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 11;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Nfield";
            row["VfpType"] = 7;
            row["VfpTypeName"] = "Numeric";
            row["Width"] = 10;
            row["Decimal"] = 0;
            row["Ordinal"] = 12;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Qfield";
            row["VfpType"] = 12;
            row["VfpTypeName"] = "General";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 13;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Vfield";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 14;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Vfield2";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 15;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Mfield";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 16;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["TableName"] = "Alltypes";
            row["FieldName"] = "Mfield2";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 17;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["TableName"] = "Candidates";
            row["FieldName"] = "Key1";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["TableName"] = "Candidates";
            row["FieldName"] = "Key2";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 19

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Flaglabel";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 50;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 20

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Flagfield";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 21

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Flagvalue";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 250;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 22

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Sequence";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 23

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Descript";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 24

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Active";
            row["VfpType"] = 6;
            row["VfpTypeName"] = "Logical";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 25

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Flagid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 26

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Dsid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 27

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Property";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 28

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["FieldName"] = "Tt";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 1;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 29

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Flaglabel";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 50;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 1;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 30

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Flagfield";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 10;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 2;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 31

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Flagvalue";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 250;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 3;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 32

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Sequence";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 4;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 33

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Descript";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 5;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 34

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Active";
            row["VfpType"] = 6;
            row["VfpTypeName"] = "Logical";
            row["Width"] = DBNull.Value;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 6;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 35

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Flagid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 7;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 36

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Dsid";
            row["VfpType"] = 13;
            row["VfpTypeName"] = "Integer";
            row["Width"] = 4;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 8;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 37

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Property";
            row["VfpType"] = 15;
            row["VfpTypeName"] = "Memo";
            row["Width"] = 2147483647;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 9;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 38

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["FieldName"] = "Tt";
            row["VfpType"] = 1;
            row["VfpTypeName"] = "Character";
            row["Width"] = 1;
            row["Decimal"] = DBNull.Value;
            row["Ordinal"] = 10;
            row["Nullable"] = false;
            row["Caption"] = DBNull.Value;
            row["Comment"] = DBNull.Value;
            row["DefaultValue"] = DBNull.Value;
            row["DisplayClass"] = DBNull.Value;
            row["DisplayClassLibrary"] = DBNull.Value;
            row["Format"] = DBNull.Value;
            row["InputMask"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetTableSchema() {
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
            row["TableName"] = "Alltypes";
            row["Comment"] = DBNull.Value;
            row["DeleteTrigger"] = DBNull.Value;
            row["InsertTrigger"] = DBNull.Value;
            row["Path"] = DBNull.Value;
            row["PrimaryKey"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            row["UpdateTrigger"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["TableName"] = "Candidates";
            row["Comment"] = DBNull.Value;
            row["DeleteTrigger"] = DBNull.Value;
            row["InsertTrigger"] = DBNull.Value;
            row["Path"] = DBNull.Value;
            row["PrimaryKey"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            row["UpdateTrigger"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C";
            row["Comment"] = DBNull.Value;
            row["DeleteTrigger"] = DBNull.Value;
            row["InsertTrigger"] = DBNull.Value;
            row["Path"] = DBNull.Value;
            row["PrimaryKey"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            row["UpdateTrigger"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["TableName"] = "Sample_C1";
            row["Comment"] = DBNull.Value;
            row["DeleteTrigger"] = DBNull.Value;
            row["InsertTrigger"] = DBNull.Value;
            row["Path"] = DBNull.Value;
            row["PrimaryKey"] = DBNull.Value;
            row["RuleExpression"] = DBNull.Value;
            row["RuleText"] = DBNull.Value;
            row["UpdateTrigger"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetViewFieldSchema() {
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

            return dataTable;
        }

        public static DataTable GetViewSchema() {
            DataTable dataTable = new DataTable("Views");

            #region columns

            dataTable.Columns.Add("ViewName", typeof(System.String));
            dataTable.Columns.Add("AllowSimultaneousFetch", typeof(System.Boolean));
            dataTable.Columns.Add("BatchUpdateCount", typeof(System.Int32));
            dataTable.Columns.Add("Comment", typeof(System.String));
            dataTable.Columns.Add("CompareMemo", typeof(System.Boolean));
            dataTable.Columns.Add("ConnectName", typeof(System.String));
            dataTable.Columns.Add("FetchAsNeeded", typeof(System.Boolean));
            dataTable.Columns.Add("FetchMemo", typeof(System.Boolean));
            dataTable.Columns.Add("FetchSize", typeof(System.Int32));
            dataTable.Columns.Add("MaxRecords", typeof(System.Int32));
            dataTable.Columns.Add("Offline", typeof(System.Boolean));
            dataTable.Columns.Add("ParameterList", typeof(System.String));
            dataTable.Columns.Add("Prepared", typeof(System.Boolean));
            dataTable.Columns.Add("RuleExpression", typeof(System.String));
            dataTable.Columns.Add("RuleText", typeof(System.String));
            dataTable.Columns.Add("SendUpdates", typeof(System.Boolean));
            dataTable.Columns.Add("ShareConnection", typeof(System.Boolean));
            dataTable.Columns.Add("SourceType", typeof(System.Int32));
            dataTable.Columns.Add("SQL", typeof(System.String));
            dataTable.Columns.Add("Tables", typeof(System.String));
            dataTable.Columns.Add("UpdateType", typeof(System.Int32));
            dataTable.Columns.Add("UseMemoSize", typeof(System.Int32));
            dataTable.Columns.Add("WhereType", typeof(System.Int32));

            #endregion columns

            return dataTable;
        }
    }
}