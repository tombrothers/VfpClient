CREATE CURSOR curOutput(TableName v(254), FieldName v(254), Caption M, Comment M, DefaultValue M, DisplayClass M, DisplayClassLibrary M, Format M, InputMask M, RuleExpression M, RuleText M, FieldType C)

LOCAL llIsDbc

llIsDbc = !EMPTY(DBC())

CREATE CURSOR curTables(TableName v(254))
{0}

USE IN SELECT("VfpClientAlias")
SELECT curTables
SCAN
	SELECT 0
	USE (curTables.TableName) AGAIN ALIAS VfpClientAlias
	
	FOR lnIndex = 1 TO AFIELDS(laFields)
		lcFieldName = laFields[lnIndex, 1]
		lcTableField = curTables.TableName + "." + lcFieldName
		
		IF llIsDbc
			INSERT INTO curOutput ;
				VALUES(curTables.TableName, ;
					lcFieldName, ;
					DBGETPROP(lcTableField, "FIELD", "Caption"), ;
					DBGETPROP(lcTableField, "FIELD", "Comment"), ;
					DBGETPROP(lcTableField, "FIELD", "DefaultValue"), ;
					DBGETPROP(lcTableField, "FIELD", "DisplayClass"), ;
					DBGETPROP(lcTableField, "FIELD", "DisplayClassLibrary"), ;
					DBGETPROP(lcTableField, "FIELD", "Format"), ;
					DBGETPROP(lcTableField, "FIELD", "InputMask"), ;
					DBGETPROP(lcTableField, "FIELD", "RuleExpression"), ;
					DBGETPROP(lcTableField, "FIELD", "RuleText"), ;
					TYPE("VfpClientAlias." + lcFieldName))
		ELSE
			INSERT INTO curOutput ;
				VALUES(curTables.TableName, ;
					lcFieldName, ;
					"", ;
					"", ;
					"", ;
					"", ;
					"", ;
					"", ;
					"", ;
					"", ;
					"", ;
					TYPE("VfpClientAlias." + lcFieldName))
		ENDIF
	NEXT
	
	USE  
ENDSCAN

SELECT curTables
USE 

USE IN SELECT("VfpClientAlias")
SELECT curOutput