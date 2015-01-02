CREATE CURSOR curOutput(cTableName v(254), cAutoInc v(254), cCandidate v(254))
CREATE CURSOR curTables(cTableName v(254))
{0}


USE IN SELECT("VfpClientAlias")
SELECT curTables
SCAN
	SELECT 0
	USE (curTables.cTableName) AGAIN ALIAS VfpClientAlias
	
	FOR lnIndex = 1 TO AFIELDS(laFields)
		IF laFields[lnIndex, 18] > 0
			INSERT INTO curOutput VALUES(curTables.cTableName, laFields[lnIndex, 1], '')
			EXIT
		ENDIF
	NEXT
	
	USE  
ENDSCAN

DELETE FROM curTables WHERE cTableName IN (SELECT cTableName FROM curOutput)


SELECT curTables
SCAN 
	SELECT 0
	USE (curTables.cTableName) AGAIN ALIAS VfpClientAlias
	
	FOR lnTagIndex = 1 TO TAGCOUNT()
		IF CANDIDATE(lnTagIndex)
			lcTag = TAG(lnTagIndex)
			INSERT INTO curOutput VALUES(curTables.cTableName, '', lcTag)
		ENDIF 
	NEXT 
	
	USE  
ENDSCAN 

SELECT curTables
USE 

USE IN SELECT("VfpClientAlias")
SELECT curOutput