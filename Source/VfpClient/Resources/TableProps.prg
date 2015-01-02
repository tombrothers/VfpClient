CREATE CURSOR curOutput(TableName v(254), Comment M, DeleteTrigger M, InsertTrigger M, Path M, PrimaryKey M, RuleExpression M, RuleText M, UpdateTrigger M)

IF EMPTY(DBC())
	RETURN
ENDIF 

CREATE CURSOR curTables(TableName v(254))
{0}

USE IN SELECT("VfpClientAlias")
SELECT curTables
SCAN
	SELECT 0
	USE (curTables.TableName) AGAIN ALIAS VfpClientAlias
	
	INSERT INTO curOutput ;
		VALUES(curTables.TableName, ;
			DBGETPROP(curTables.TableName, "TABLE", "Comment"), ;
			DBGETPROP(curTables.TableName, "TABLE", "DeleteTrigger"), ;
			DBGETPROP(curTables.TableName, "TABLE", "InsertTrigger"), ;
			DBGETPROP(curTables.TableName, "TABLE", "Path"), ;
			DBGETPROP(curTables.TableName, "TABLE", "PrimaryKey"), ;
			DBGETPROP(curTables.TableName, "TABLE", "RuleExpression"), ;
			DBGETPROP(curTables.TableName, "TABLE", "RuleText"), ;
			DBGETPROP(curTables.TableName, "TABLE", "UpdateTrigger"))
	
	USE  
ENDSCAN

SELECT curTables
USE 

USE IN SELECT("VfpClientAlias")
SELECT curOutput