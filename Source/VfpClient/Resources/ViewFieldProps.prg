CREATE CURSOR curOutput(ViewName v(254), FieldName v(254), Caption M, Comment M, DefaultValue M, DisplayClass M, DisplayClassLibrary M, ;
						Format M, InputMask M, RuleExpression M, RuleText M, KeyField L, Updatable L, UpdateName M, DataType M, FieldType C)

IF EMPTY(DBC())
	RETURN
ENDIF 

CREATE CURSOR curViews(ViewName v(254))
{0}

USE IN SELECT("VfpClientAlias")
SELECT curViews
SCAN
	SELECT 0
	USE (curViews.ViewName) AGAIN ALIAS VfpClientAlias NODATA
	
	FOR lnIndex = 1 TO AFIELDS(laFields)
		lcFieldName = laFields[lnIndex, 1]
		lcViewField = curViews.ViewName + "." + lcFieldName
		
		INSERT INTO curOutput ;
			VALUES(curViews.ViewName, ;
				lcFieldName, ;
				DBGETPROP(lcViewField, "FIELD", "Caption"), ;
				DBGETPROP(lcViewField, "FIELD", "Comment"), ;
				DBGETPROP(lcViewField, "FIELD", "DefaultValue"), ;
				DBGETPROP(lcViewField, "FIELD", "DisplayClass"), ;
				DBGETPROP(lcViewField, "FIELD", "DisplayClassLibrary"), ;
				DBGETPROP(lcViewField, "FIELD", "Format"), ;
				DBGETPROP(lcViewField, "FIELD", "InputMask"), ;
				DBGETPROP(lcViewField, "FIELD", "RuleExpression"), ;
				DBGETPROP(lcViewField, "FIELD", "RuleText"), ;
				DBGETPROP(lcViewField, "FIELD", "KeyField"), ;
				DBGETPROP(lcViewField, "FIELD", "Updatable"), ;
				DBGETPROP(lcViewField, "FIELD", "UpdateName"), ;
				DBGETPROP(lcViewField, "FIELD", "DataType"), ;
				TYPE("VfpClientAlias." + lcFieldName))
	NEXT
	
	USE  
ENDSCAN

FOR lnIndex = 1 TO AUSED(laUsed) 
	IF UPPER(laUsed[lnIndex, 1]) != "CUROUTPUT"
		USE IN (laUsed[lnIndex, 1])
	ENDIF 
NEXT  

SELECT curOutput