CREATE CURSOR curOutput(ViewName v(254), AllowSimultaneousFetch L, BatchUpdateCount N(19, 0), Comment M, CompareMemo L, ConnectName M, ;
						FetchAsNeeded L, FetchMemo L, FetchSize N(19, 0), MaxRecords N(19, 0), Offline L, ParameterList M, Prepared L, ;
						RuleExpression M, RuleText M, SendUpdates L, ShareConnection L, SourceType N(19, 0), SQL M, Tables M, ;
						UpdateType N(19, 0), UseMemoSize N(19, 0), WhereType N(19, 0))

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
	
	INSERT INTO curOutput ;
		VALUES(curViews.ViewName, ;
			DBGETPROP(curViews.ViewName, "VIEW", "AllowSimultaneousFetch"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "BatchUpdateCount"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "Comment"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "CompareMemo"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "ConnectName"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "FetchAsNeeded"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "FetchMemo"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "FetchSize"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "MaxRecords"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "Offline"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "ParameterList"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "Prepared"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "RuleExpression"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "RuleText"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "SendUpdates"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "ShareConnection"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "SourceType"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "SQL"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "Tables"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "UpdateType"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "UseMemoSize"), ;
			DBGETPROP(curViews.ViewName, "VIEW", "WhereType"))	

	USE  
ENDSCAN

FOR lnIndex = 1 TO AUSED(laUsed) 
	IF UPPER(laUsed[lnIndex, 1]) != "CUROUTPUT"
		USE IN (laUsed[lnIndex, 1])
	ENDIF 
NEXT  

SELECT curOutput