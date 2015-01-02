using System;
using System.Data;

namespace VfpClient.Tests.Schema {
    class SchemaManagerExpected {
        public static DataTable GetDataSourceInformationSchema() {
            DataTable dataTable = new DataTable("DataSourceInformation");

            #region columns

            dataTable.Columns.Add("CompositeIdentifierSeparatorPattern", typeof(System.String));
            dataTable.Columns.Add("DataSourceProductName", typeof(System.String));
            dataTable.Columns.Add("DataSourceProductVersion", typeof(System.String));
            dataTable.Columns.Add("DataSourceProductVersionNormalized", typeof(System.String));
            dataTable.Columns.Add("GroupByBehavior", typeof(System.Data.Common.GroupByBehavior));
            dataTable.Columns.Add("IdentifierPattern", typeof(System.String));
            dataTable.Columns.Add("IdentifierCase", typeof(System.Data.Common.IdentifierCase));
            dataTable.Columns.Add("OrderByColumnsInSelect", typeof(System.Boolean));
            dataTable.Columns.Add("ParameterMarkerFormat", typeof(System.String));
            dataTable.Columns.Add("ParameterMarkerPattern", typeof(System.String));
            dataTable.Columns.Add("ParameterNameMaxLength", typeof(System.Int32));
            dataTable.Columns.Add("ParameterNamePattern", typeof(System.String));
            dataTable.Columns.Add("QuotedIdentifierPattern", typeof(System.String));
            dataTable.Columns.Add("QuotedIdentifierCase", typeof(System.Data.Common.IdentifierCase));
            dataTable.Columns.Add("StatementSeparatorPattern", typeof(System.String));
            dataTable.Columns.Add("StringLiteralPattern", typeof(System.String));
            dataTable.Columns.Add("SupportedJoinOperators", typeof(System.Data.Common.SupportedJoinOperators));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["CompositeIdentifierSeparatorPattern"] = "!";
            row["DataSourceProductName"] = "Microsoft Visual FoxPro";
            row["DataSourceProductVersion"] = "09.00.0000.5815";
            row["DataSourceProductVersionNormalized"] = "09.00.0000.5815";
            row["GroupByBehavior"] = 3;
            row["IdentifierPattern"] = "[^0123456789 !\"#\\$%&'\\(\\)\\*\\+,-\\./:;<=>\\?@\\[\\\\\\]\\^`\\{\\|}~][^ !\"#\\$%&'\\(\\)\\*\\+,-\\./:;<=>\\?@\\[\\\\\\]\\^`\\{\\|}~]*";
            row["IdentifierCase"] = 1;
            row["OrderByColumnsInSelect"] = false;
            row["ParameterMarkerFormat"] = "{0}";
            row["ParameterMarkerPattern"] = @"@[\p{Lo}\p{Lu}\p{Ll}\p{Lm}_@#][\p{Lo}\p{Lu}\p{Ll}\p{Lm}\p{Nd}\uff3f_@#\$]*(?=\s+|$)";
            row["ParameterNameMaxLength"] = 128;
            row["ParameterNamePattern"] = @"^[\p{Lo}\p{Lu}\p{Ll}\p{Lm}_@#][\p{Lo}\p{Lu}\p{Ll}\p{Lm}\p{Nd}\uff3f_@#\$]*(?=\s+|$)";
            row["QuotedIdentifierPattern"] = "`(([^`]|``)*)`";
            row["QuotedIdentifierCase"] = 1;
            row["StatementSeparatorPattern"] = DBNull.Value;
            row["StringLiteralPattern"] = DBNull.Value;
            row["SupportedJoinOperators"] = DBNull.Value;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetReservedWordsSchema() {
            DataTable dataTable = new DataTable("ReservedWords");

            #region columns

            dataTable.Columns.Add("ReservedWord", typeof(System.String));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ReservedWord"] = "ABSOLUTE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ReservedWord"] = "ACTION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ReservedWord"] = "ADD";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ReservedWord"] = "ALL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ReservedWord"] = "ALLOCATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ReservedWord"] = "ALTER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ReservedWord"] = "AND";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ReservedWord"] = "ANY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ReservedWord"] = "ARE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ReservedWord"] = "AS";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ReservedWord"] = "ASC";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["ReservedWord"] = "ASSERTION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["ReservedWord"] = "AT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["ReservedWord"] = "AUTHORIZATION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["ReservedWord"] = "AVG";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["ReservedWord"] = "BEGIN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["ReservedWord"] = "BETWEEN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["ReservedWord"] = "BIT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["ReservedWord"] = "BIT_LENGTH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 19

            row = dataTable.NewRow();
            row["ReservedWord"] = "BOTH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 20

            row = dataTable.NewRow();
            row["ReservedWord"] = "BY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 21

            row = dataTable.NewRow();
            row["ReservedWord"] = "CASCADE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 22

            row = dataTable.NewRow();
            row["ReservedWord"] = "CASCADED";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 23

            row = dataTable.NewRow();
            row["ReservedWord"] = "CASE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 24

            row = dataTable.NewRow();
            row["ReservedWord"] = "CAST";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 25

            row = dataTable.NewRow();
            row["ReservedWord"] = "CATALOG";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 26

            row = dataTable.NewRow();
            row["ReservedWord"] = "CHAR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 27

            row = dataTable.NewRow();
            row["ReservedWord"] = "CHAR_LENGTH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 28

            row = dataTable.NewRow();
            row["ReservedWord"] = "CHARACTER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 29

            row = dataTable.NewRow();
            row["ReservedWord"] = "CHARACTER_LENGTH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 30

            row = dataTable.NewRow();
            row["ReservedWord"] = "CHECK";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 31

            row = dataTable.NewRow();
            row["ReservedWord"] = "CLOSE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 32

            row = dataTable.NewRow();
            row["ReservedWord"] = "COALESCE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 33

            row = dataTable.NewRow();
            row["ReservedWord"] = "COLLATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 34

            row = dataTable.NewRow();
            row["ReservedWord"] = "COLLATION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 35

            row = dataTable.NewRow();
            row["ReservedWord"] = "COLUMN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 36

            row = dataTable.NewRow();
            row["ReservedWord"] = "COMMIT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 37

            row = dataTable.NewRow();
            row["ReservedWord"] = "CONNECT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 38

            row = dataTable.NewRow();
            row["ReservedWord"] = "CONNECTION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 39

            row = dataTable.NewRow();
            row["ReservedWord"] = "CONSTRAINT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 40

            row = dataTable.NewRow();
            row["ReservedWord"] = "CONSTRAINTS";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 41

            row = dataTable.NewRow();
            row["ReservedWord"] = "CONTINUE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 42

            row = dataTable.NewRow();
            row["ReservedWord"] = "CONVERT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 43

            row = dataTable.NewRow();
            row["ReservedWord"] = "CORRESPONDING";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 44

            row = dataTable.NewRow();
            row["ReservedWord"] = "COUNT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 45

            row = dataTable.NewRow();
            row["ReservedWord"] = "CREATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 46

            row = dataTable.NewRow();
            row["ReservedWord"] = "CROSS";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 47

            row = dataTable.NewRow();
            row["ReservedWord"] = "CURRENT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 48

            row = dataTable.NewRow();
            row["ReservedWord"] = "CURRENT_DATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 49

            row = dataTable.NewRow();
            row["ReservedWord"] = "CURRENT_TIME";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 50

            row = dataTable.NewRow();
            row["ReservedWord"] = "CURRENT_TIMESTAMP";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 51

            row = dataTable.NewRow();
            row["ReservedWord"] = "CURRENT_USER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 52

            row = dataTable.NewRow();
            row["ReservedWord"] = "CURSOR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 53

            row = dataTable.NewRow();
            row["ReservedWord"] = "DATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 54

            row = dataTable.NewRow();
            row["ReservedWord"] = "DAY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 55

            row = dataTable.NewRow();
            row["ReservedWord"] = "DEALLOCATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 56

            row = dataTable.NewRow();
            row["ReservedWord"] = "DEC";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 57

            row = dataTable.NewRow();
            row["ReservedWord"] = "DECIMAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 58

            row = dataTable.NewRow();
            row["ReservedWord"] = "DECLARE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 59

            row = dataTable.NewRow();
            row["ReservedWord"] = "DEFAULT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 60

            row = dataTable.NewRow();
            row["ReservedWord"] = "DEFERRABLE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 61

            row = dataTable.NewRow();
            row["ReservedWord"] = "DEFERRED";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 62

            row = dataTable.NewRow();
            row["ReservedWord"] = "DELETE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 63

            row = dataTable.NewRow();
            row["ReservedWord"] = "DESC";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 64

            row = dataTable.NewRow();
            row["ReservedWord"] = "DESCRIBE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 65

            row = dataTable.NewRow();
            row["ReservedWord"] = "DESCRIPTOR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 66

            row = dataTable.NewRow();
            row["ReservedWord"] = "DIAGNOSTICS";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 67

            row = dataTable.NewRow();
            row["ReservedWord"] = "DISCONNECT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 68

            row = dataTable.NewRow();
            row["ReservedWord"] = "DISTINCT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 69

            row = dataTable.NewRow();
            row["ReservedWord"] = "DISTINCTROW";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 70

            row = dataTable.NewRow();
            row["ReservedWord"] = "DOMAIN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 71

            row = dataTable.NewRow();
            row["ReservedWord"] = "DOUBLE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 72

            row = dataTable.NewRow();
            row["ReservedWord"] = "DROP";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 73

            row = dataTable.NewRow();
            row["ReservedWord"] = "ELSE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 74

            row = dataTable.NewRow();
            row["ReservedWord"] = "END";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 75

            row = dataTable.NewRow();
            row["ReservedWord"] = "END-EXEC";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 76

            row = dataTable.NewRow();
            row["ReservedWord"] = "ESCAPE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 77

            row = dataTable.NewRow();
            row["ReservedWord"] = "EXCEPT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 78

            row = dataTable.NewRow();
            row["ReservedWord"] = "EXCEPTION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 79

            row = dataTable.NewRow();
            row["ReservedWord"] = "EXEC";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 80

            row = dataTable.NewRow();
            row["ReservedWord"] = "EXECUTE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 81

            row = dataTable.NewRow();
            row["ReservedWord"] = "EXISTS";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 82

            row = dataTable.NewRow();
            row["ReservedWord"] = "EXTERNAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 83

            row = dataTable.NewRow();
            row["ReservedWord"] = "EXTRACT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 84

            row = dataTable.NewRow();
            row["ReservedWord"] = "FALSE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 85

            row = dataTable.NewRow();
            row["ReservedWord"] = "FETCH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 86

            row = dataTable.NewRow();
            row["ReservedWord"] = "FIRST";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 87

            row = dataTable.NewRow();
            row["ReservedWord"] = "FLOAT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 88

            row = dataTable.NewRow();
            row["ReservedWord"] = "FOR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 89

            row = dataTable.NewRow();
            row["ReservedWord"] = "FOREIGN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 90

            row = dataTable.NewRow();
            row["ReservedWord"] = "FOUND";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 91

            row = dataTable.NewRow();
            row["ReservedWord"] = "FROM";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 92

            row = dataTable.NewRow();
            row["ReservedWord"] = "FULL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 93

            row = dataTable.NewRow();
            row["ReservedWord"] = "GET";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 94

            row = dataTable.NewRow();
            row["ReservedWord"] = "GLOBAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 95

            row = dataTable.NewRow();
            row["ReservedWord"] = "GO";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 96

            row = dataTable.NewRow();
            row["ReservedWord"] = "GOTO";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 97

            row = dataTable.NewRow();
            row["ReservedWord"] = "GRANT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 98

            row = dataTable.NewRow();
            row["ReservedWord"] = "GROUP";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 99

            row = dataTable.NewRow();
            row["ReservedWord"] = "HAVING";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 100

            row = dataTable.NewRow();
            row["ReservedWord"] = "HOUR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 101

            row = dataTable.NewRow();
            row["ReservedWord"] = "IDENTITY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 102

            row = dataTable.NewRow();
            row["ReservedWord"] = "IMMEDIATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 103

            row = dataTable.NewRow();
            row["ReservedWord"] = "IN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 104

            row = dataTable.NewRow();
            row["ReservedWord"] = "INDICATOR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 105

            row = dataTable.NewRow();
            row["ReservedWord"] = "INITIALLY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 106

            row = dataTable.NewRow();
            row["ReservedWord"] = "INNER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 107

            row = dataTable.NewRow();
            row["ReservedWord"] = "INPUT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 108

            row = dataTable.NewRow();
            row["ReservedWord"] = "INSENSITIVE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 109

            row = dataTable.NewRow();
            row["ReservedWord"] = "INSERT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 110

            row = dataTable.NewRow();
            row["ReservedWord"] = "INT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 111

            row = dataTable.NewRow();
            row["ReservedWord"] = "INTEGER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 112

            row = dataTable.NewRow();
            row["ReservedWord"] = "INTERSECT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 113

            row = dataTable.NewRow();
            row["ReservedWord"] = "INTERVAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 114

            row = dataTable.NewRow();
            row["ReservedWord"] = "INTO";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 115

            row = dataTable.NewRow();
            row["ReservedWord"] = "IS";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 116

            row = dataTable.NewRow();
            row["ReservedWord"] = "ISOLATION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 117

            row = dataTable.NewRow();
            row["ReservedWord"] = "JOIN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 118

            row = dataTable.NewRow();
            row["ReservedWord"] = "KEY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 119

            row = dataTable.NewRow();
            row["ReservedWord"] = "LANGUAGE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 120

            row = dataTable.NewRow();
            row["ReservedWord"] = "LAST";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 121

            row = dataTable.NewRow();
            row["ReservedWord"] = "LEADING";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 122

            row = dataTable.NewRow();
            row["ReservedWord"] = "LEFT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 123

            row = dataTable.NewRow();
            row["ReservedWord"] = "LEVEL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 124

            row = dataTable.NewRow();
            row["ReservedWord"] = "LIKE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 125

            row = dataTable.NewRow();
            row["ReservedWord"] = "LOCAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 126

            row = dataTable.NewRow();
            row["ReservedWord"] = "LOWER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 127

            row = dataTable.NewRow();
            row["ReservedWord"] = "MATCH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 128

            row = dataTable.NewRow();
            row["ReservedWord"] = "MAX";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 129

            row = dataTable.NewRow();
            row["ReservedWord"] = "MIN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 130

            row = dataTable.NewRow();
            row["ReservedWord"] = "MINUTE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 131

            row = dataTable.NewRow();
            row["ReservedWord"] = "MODULE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 132

            row = dataTable.NewRow();
            row["ReservedWord"] = "MONTH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 133

            row = dataTable.NewRow();
            row["ReservedWord"] = "NAMES";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 134

            row = dataTable.NewRow();
            row["ReservedWord"] = "NATIONAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 135

            row = dataTable.NewRow();
            row["ReservedWord"] = "NATURAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 136

            row = dataTable.NewRow();
            row["ReservedWord"] = "NCHAR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 137

            row = dataTable.NewRow();
            row["ReservedWord"] = "NEXT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 138

            row = dataTable.NewRow();
            row["ReservedWord"] = "NO";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 139

            row = dataTable.NewRow();
            row["ReservedWord"] = "NOT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 140

            row = dataTable.NewRow();
            row["ReservedWord"] = "NULL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 141

            row = dataTable.NewRow();
            row["ReservedWord"] = "NULLIF";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 142

            row = dataTable.NewRow();
            row["ReservedWord"] = "NUMERIC";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 143

            row = dataTable.NewRow();
            row["ReservedWord"] = "OCTET_LENGTH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 144

            row = dataTable.NewRow();
            row["ReservedWord"] = "OF";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 145

            row = dataTable.NewRow();
            row["ReservedWord"] = "ON";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 146

            row = dataTable.NewRow();
            row["ReservedWord"] = "ONLY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 147

            row = dataTable.NewRow();
            row["ReservedWord"] = "OPEN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 148

            row = dataTable.NewRow();
            row["ReservedWord"] = "OPTION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 149

            row = dataTable.NewRow();
            row["ReservedWord"] = "OR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 150

            row = dataTable.NewRow();
            row["ReservedWord"] = "ORDER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 151

            row = dataTable.NewRow();
            row["ReservedWord"] = "OUTER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 152

            row = dataTable.NewRow();
            row["ReservedWord"] = "OUTPUT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 153

            row = dataTable.NewRow();
            row["ReservedWord"] = "OVERLAPS";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 154

            row = dataTable.NewRow();
            row["ReservedWord"] = "PARTIAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 155

            row = dataTable.NewRow();
            row["ReservedWord"] = "POSITION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 156

            row = dataTable.NewRow();
            row["ReservedWord"] = "PRECISION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 157

            row = dataTable.NewRow();
            row["ReservedWord"] = "PREPARE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 158

            row = dataTable.NewRow();
            row["ReservedWord"] = "PRESERVE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 159

            row = dataTable.NewRow();
            row["ReservedWord"] = "PRIMARY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 160

            row = dataTable.NewRow();
            row["ReservedWord"] = "PRIOR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 161

            row = dataTable.NewRow();
            row["ReservedWord"] = "PRIVILEGES";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 162

            row = dataTable.NewRow();
            row["ReservedWord"] = "PROCEDURE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 163

            row = dataTable.NewRow();
            row["ReservedWord"] = "PUBLIC";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 164

            row = dataTable.NewRow();
            row["ReservedWord"] = "READ";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 165

            row = dataTable.NewRow();
            row["ReservedWord"] = "REAL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 166

            row = dataTable.NewRow();
            row["ReservedWord"] = "REFERENCES";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 167

            row = dataTable.NewRow();
            row["ReservedWord"] = "RELATIVE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 168

            row = dataTable.NewRow();
            row["ReservedWord"] = "RESTRICT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 169

            row = dataTable.NewRow();
            row["ReservedWord"] = "REVOKE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 170

            row = dataTable.NewRow();
            row["ReservedWord"] = "RIGHT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 171

            row = dataTable.NewRow();
            row["ReservedWord"] = "ROLLBACK";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 172

            row = dataTable.NewRow();
            row["ReservedWord"] = "ROWS";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 173

            row = dataTable.NewRow();
            row["ReservedWord"] = "SCHEMA";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 174

            row = dataTable.NewRow();
            row["ReservedWord"] = "SCROLL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 175

            row = dataTable.NewRow();
            row["ReservedWord"] = "SECOND";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 176

            row = dataTable.NewRow();
            row["ReservedWord"] = "SECTION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 177

            row = dataTable.NewRow();
            row["ReservedWord"] = "SELECT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 178

            row = dataTable.NewRow();
            row["ReservedWord"] = "SESSION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 179

            row = dataTable.NewRow();
            row["ReservedWord"] = "SESSION_USER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 180

            row = dataTable.NewRow();
            row["ReservedWord"] = "SET";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 181

            row = dataTable.NewRow();
            row["ReservedWord"] = "SIZE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 182

            row = dataTable.NewRow();
            row["ReservedWord"] = "SMALLINT";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 183

            row = dataTable.NewRow();
            row["ReservedWord"] = "SOME";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 184

            row = dataTable.NewRow();
            row["ReservedWord"] = "SQL";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 185

            row = dataTable.NewRow();
            row["ReservedWord"] = "SQLCODE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 186

            row = dataTable.NewRow();
            row["ReservedWord"] = "SQLERROR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 187

            row = dataTable.NewRow();
            row["ReservedWord"] = "SQLSTATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 188

            row = dataTable.NewRow();
            row["ReservedWord"] = "SUBSTRING";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 189

            row = dataTable.NewRow();
            row["ReservedWord"] = "SUM";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 190

            row = dataTable.NewRow();
            row["ReservedWord"] = "SYSTEM_USER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 191

            row = dataTable.NewRow();
            row["ReservedWord"] = "TABLE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 192

            row = dataTable.NewRow();
            row["ReservedWord"] = "TEMPORARY";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 193

            row = dataTable.NewRow();
            row["ReservedWord"] = "THEN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 194

            row = dataTable.NewRow();
            row["ReservedWord"] = "TIME";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 195

            row = dataTable.NewRow();
            row["ReservedWord"] = "TIMESTAMP";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 196

            row = dataTable.NewRow();
            row["ReservedWord"] = "TIMEZONE_HOUR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 197

            row = dataTable.NewRow();
            row["ReservedWord"] = "TIMEZONE_MINUTE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 198

            row = dataTable.NewRow();
            row["ReservedWord"] = "TO";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 199

            row = dataTable.NewRow();
            row["ReservedWord"] = "TRAILING";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 200

            row = dataTable.NewRow();
            row["ReservedWord"] = "TRANSACTION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 201

            row = dataTable.NewRow();
            row["ReservedWord"] = "TRANSLATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 202

            row = dataTable.NewRow();
            row["ReservedWord"] = "TRANSLATION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 203

            row = dataTable.NewRow();
            row["ReservedWord"] = "TRIGGER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 204

            row = dataTable.NewRow();
            row["ReservedWord"] = "TRIM";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 205

            row = dataTable.NewRow();
            row["ReservedWord"] = "TRUE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 206

            row = dataTable.NewRow();
            row["ReservedWord"] = "UNION";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 207

            row = dataTable.NewRow();
            row["ReservedWord"] = "UNIQUE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 208

            row = dataTable.NewRow();
            row["ReservedWord"] = "UNKNOWN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 209

            row = dataTable.NewRow();
            row["ReservedWord"] = "UPDATE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 210

            row = dataTable.NewRow();
            row["ReservedWord"] = "UPPER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 211

            row = dataTable.NewRow();
            row["ReservedWord"] = "USAGE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 212

            row = dataTable.NewRow();
            row["ReservedWord"] = "USER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 213

            row = dataTable.NewRow();
            row["ReservedWord"] = "USING";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 214

            row = dataTable.NewRow();
            row["ReservedWord"] = "VALUE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 215

            row = dataTable.NewRow();
            row["ReservedWord"] = "VALUES";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 216

            row = dataTable.NewRow();
            row["ReservedWord"] = "VARCHAR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 217

            row = dataTable.NewRow();
            row["ReservedWord"] = "VARYING";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 218

            row = dataTable.NewRow();
            row["ReservedWord"] = "VIEW";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 219

            row = dataTable.NewRow();
            row["ReservedWord"] = "WHEN";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 220

            row = dataTable.NewRow();
            row["ReservedWord"] = "WHENEVER";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 221

            row = dataTable.NewRow();
            row["ReservedWord"] = "WHERE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 222

            row = dataTable.NewRow();
            row["ReservedWord"] = "WITH";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 223

            row = dataTable.NewRow();
            row["ReservedWord"] = "WORK";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 224

            row = dataTable.NewRow();
            row["ReservedWord"] = "WRITE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 225

            row = dataTable.NewRow();
            row["ReservedWord"] = "YEAR";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 226

            row = dataTable.NewRow();
            row["ReservedWord"] = "ZONE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 227

            row = dataTable.NewRow();
            row["ReservedWord"] = "USE";
            dataTable.Rows.Add(row);

            #endregion row

            #region row 228

            row = dataTable.NewRow();
            row["ReservedWord"] = "MEMO";
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}