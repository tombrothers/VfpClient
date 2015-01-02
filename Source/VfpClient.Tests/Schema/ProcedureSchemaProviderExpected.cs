using System;
using System.Data;

namespace VfpClient.Tests.Schema {
    class ProcedureSchemaProviderExpected {
        public static DataTable GetSchemaWithProcedureNameReferentialIntegrity() {
            DataTable dataTable = new DataTable("Procedures");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ProcedureDefinition", typeof(System.String));
            dataTable.Columns.Add("Description", typeof(System.String));
            dataTable.Columns.Add("ReferentialIntegrity", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Ridelete";
            row["ProcedureDefinition"] = @"procedure RIDELETE
local llRetVal
llRetVal=.t.
 IF (ISRLOCKED() and !deleted()) OR !RLOCK()
    llRetVal=.F.
  ELSE
    IF !deleted()
      DELETE
      IF CURSORGETPROP('BUFFERING') > 1
      	=TABLEUPDATE()
      ENDIF
    ENDIF not already deleted
  ENDIF
  UNLOCK RECORD (RECNO())
  llRetVal=pnerror=0
RETURN llRetVal

";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithReferentialIntegrity() {
            DataTable dataTable = new DataTable("Procedures");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ProcedureDefinition", typeof(System.String));
            dataTable.Columns.Add("Description", typeof(System.String));
            dataTable.Columns.Add("ReferentialIntegrity", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Ridelete";
            row["ProcedureDefinition"] = @"procedure RIDELETE
local llRetVal
llRetVal=.t.
 IF (ISRLOCKED() and !deleted()) OR !RLOCK()
    llRetVal=.F.
  ELSE
    IF !deleted()
      DELETE
      IF CURSORGETPROP('BUFFERING') > 1
      	=TABLEUPDATE()
      ENDIF
    ENDIF not already deleted
  ENDIF
  UNLOCK RECORD (RECNO())
  llRetVal=pnerror=0
RETURN llRetVal

";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riupdate";
            row["ProcedureDefinition"] = @"procedure RIUPDATE
lparameters tcFieldName,tcNewValue,tcCascadeParent
local llRetVal
llRetVal=.t.
 IF ISRLOCKED() OR !RLOCK()
    llRetVal=.F.
  ELSE
    IF EVAL(tcFieldName)<>tcNewValue
      PRIVATE pcCascadeParent
      pcCascadeParent=upper(iif(type(" + (char)34 + @"tcCascadeParent" + (char)34 + @")<>" + (char)34 + @"C" + (char)34 + @"," + (char)34 + @"" + (char)34 + @",tcCascadeParent))
      REPLACE (tcFieldName) WITH tcNewValue
      IF CURSORGETPROP('BUFFERING') > 1
      	=TABLEUPDATE()
      ENDIF
    ENDIF values don't already match
  ENDIF it's locked already, or I was able to lock it
  UNLOCK RECORD (RECNO())
  llRetVal=pnerror=0
return llRetVal

";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ProcedureName"] = "Rierror";
            row["ProcedureDefinition"] = @"procedure rierror
parameters tnErrNo,tcMessage,tcCode,tcProgram
local lnErrorRows,lnXX
lnErrorRows=alen(gaErrors,1)
if type('gaErrors[lnErrorRows,1]')<>" + (char)34 + @"L" + (char)34 + @"
  dimension gaErrors[lnErrorRows+1,alen(gaErrors,2)]
  lnErrorRows=lnErrorRows+1
endif
gaErrors[lnErrorRows,1]=tnErrNo
gaErrors[lnErrorRows,2]=tcMessage
gaErrors[lnErrorRows,3]=tcCode
gaErrors[lnErrorRows,4]=" + (char)34 + @"" + (char)34 + @"
lnXX=1
do while !empty(program(lnXX))
  gaErrors[lnErrorRows,4]=gaErrors[lnErrorRows,4]+" + (char)34 + @"," + (char)34 + @"+;
  program(lnXX)
  lnXX=lnXX+1
enddo
gaErrors[lnErrorRows,5]=pcParentDBF
gaErrors[lnErrorRows,6]=pnParentRec
gaErrors[lnErrorRows,7]=pcParentID
gaErrors[lnErrorRows,8]=pcParentExpr
gaErrors[lnErrorRows,9]=pcChildDBF
gaErrors[lnErrorRows,10]=pnChildRec
gaErrors[lnErrorRows,11]=pcChildID
gaErrors[lnErrorRows,12]=pcChildExpr
return tnErrNo


";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riopen";
            row["ProcedureDefinition"] = @"PROCEDURE riopen
PARAMETERS tcTable,tcOrder

LOCAL lcCurWkArea,lcNewWkArea,lnInUseSpot,lnOccurs,lnOccurance
lnInUseSpot=0
lnOccurs = OCCURS(UPPER(tcTable)+" + (char)34 + @"*" + (char)34 + @",UPPER(pcRIcursors))
FOR lnOccurance = 1 TO lnOccurs
	lnInUseSpot=ATC(tcTable+" + (char)34 + @"*" + (char)34 + @",pcRIcursors,lnOccurance)
	IF ISDIGIT(SUBSTR(pcRIcursors,lnInUseSpot-1,1)) OR;
		 EMPTY(SUBSTR(pcRIcursors,lnInUseSpot-1,1))
		EXIT
	ENDIF
	lnInUseSpot=0
ENDFOR

IF lnInUseSpot=0
  lcCurWkArea=select()
  SELECT 0
  lcNewWkArea=select()
  IF NOT EMPTY(tcOrder)
    USE (tcTable) AGAIN ORDER (tcOrder) ;
      ALIAS (" + (char)34 + @"__ri" + (char)34 + @"+LTRIM(STR(SELECT()))) share
  ELSE
    USE (tcTable) AGAIN ALIAS (" + (char)34 + @"__ri" + (char)34 + @"+LTRIM(STR(SELECT()))) share
  ENDIF
  if pnerror=0
    pcRIcursors=pcRIcursors+upper(tcTable)+" + (char)34 + @"?" + (char)34 + @"+STR(SELECT(),5)
  else
    lcNewWkArea=0
  endif something bad happened while attempting to open the file
ELSE
  lcNewWkArea=val(substr(pcRIcursors,lnInUseSpot+len(tcTable)+1,5))
  pcRIcursors = strtran(pcRIcursors,upper(tcTable)+" + (char)34 + @"*" + (char)34 + @"+str(lcNewWkArea,5),;
    upper(tcTable)+" + (char)34 + @"?" + (char)34 + @"+str(lcNewWkArea,5))
  IF NOT EMPTY(tcOrder)
    SET ORDER TO (tcOrder) IN (lcNewWkArea)
  ENDIF sent an order
  if pnerror<>0
    lcNewWkArea=0
  endif something bad happened while setting order
ENDIF
RETURN (lcNewWkArea)


";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ProcedureName"] = "Riend";
            row["ProcedureDefinition"] = @"PROCEDURE riend
PARAMETERS tlSuccess
local lnXX,lnSpot,lcWorkArea
IF tlSuccess
  END TRANSACTION
ELSE
  SET DELETED OFF
  ROLLBACK
  SET DELETED ON
ENDIF
IF EMPTY(pcRIolderror)
  ON ERROR
ELSE
  ON ERROR &pcRIolderror.
ENDIF
FOR lnXX=1 TO occurs(" + (char)34 + @"*" + (char)34 + @",pcRIcursors)
  lnSpot=atc(" + (char)34 + @"*" + (char)34 + @",pcRIcursors,lnXX)+1
  USE IN (VAL(substr(pcRIcursors,lnSpot,5)))
ENDFOR
IF pcOldCompat = " + (char)34 + @"ON" + (char)34 + @"
	SET COMPATIBLE ON
ENDIF
IF pcOldDele=" + (char)34 + @"OFF" + (char)34 + @"
  SET DELETED OFF
ENDIF
IF pcOldExact=" + (char)34 + @"ON" + (char)34 + @"
  SET EXACT ON
ENDIF
IF pcOldTalk=" + (char)34 + @"ON" + (char)34 + @"
  SET TALK ON
ENDIF
do case
  case empty(pcOldDBC)
    set data to
  case pcOldDBC<>DBC()
    set data to (pcOldDBC)
endcase
RETURN .T.


";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 5

            row = dataTable.NewRow();
            row["ProcedureName"] = "Rireuse";
            row["ProcedureDefinition"] = @"PROCEDURE rireuse
* rireuse.prg
PARAMETERS tcTableName,tcWkArea
pcRIcursors = strtran(pcRIcursors,upper(tcTableName)+" + (char)34 + @"?" + (char)34 + @"+str(tcWkArea,5),;
  upper(tcTableName)+" + (char)34 + @"*" + (char)34 + @"+str(tcWkArea,5))
RETURN .t.

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Categories
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 6

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Categories";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Categories
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE CATEGORYID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"CATEGORYID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"Products" + (char)34 + @"," + (char)34 + @"categoryid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=CATEGORYID
pcChildExpr=" + (char)34 + @"CATEGORYID" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"Products" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Categories
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 7

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Categories";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Categories
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Categories
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"CATEGORYID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"CATEGORYID" + (char)34 + @"
lcParentID=CATEGORYID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"Products" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO categoryid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=CATEGORYID
  pcChildExpr=" + (char)34 + @"CATEGORYID" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"Products" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Categories
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" CustomerDemographics
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 8

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Customerdemographics";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_CustomerDemographics
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE ALLTRIM(UPPER(CUSTOMERTYPEID)) TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"ALLTRIM(UPPER(CUSTOMERTYPEID))" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"CustomerCustomerDemo" + (char)34 + @"," + (char)34 + @"custtypeid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=ALLTRIM(UPPER(CUSTOMERTYPEID))
pcChildExpr=" + (char)34 + @"ALLTRIM(UPPER(CUSTOMERTYPEID))" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"CustomerCustomerDemo" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" CustomerDemographics
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 9

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Customerdemographics";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_CustomerDemographics
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" CustomerDemographics
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"ALLTRIM(UPPER(CUSTOMERTYPEID))" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"ALLTRIM(UPPER(CUSTOMERTYPEID))" + (char)34 + @"
lcParentID=ALLTRIM(UPPER(CUSTOMERTYPEID))
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"CustomerCustomerDemo" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO custtypeid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=ALLTRIM(UPPER(CUSTOMERTYPEID))
  pcChildExpr=" + (char)34 + @"ALLTRIM(UPPER(CUSTOMERTYPEID))" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"CustomerCustomerDemo" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" CustomerDemographics
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Customers
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 10

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Customers";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Customers
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE CUSTOMERID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"CUSTOMERID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"Orders" + (char)34 + @"," + (char)34 + @"customerid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=CUSTOMERID
pcChildExpr=" + (char)34 + @"CUSTOMERID" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"Orders" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE CUSTOMERID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"CUSTOMERID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"CustomerCustomerDemo" + (char)34 + @"," + (char)34 + @"customerid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=ALLTRIM(UPPER(CUSTOMERID))
pcChildExpr=" + (char)34 + @"ALLTRIM(UPPER(CUSTOMERID))" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"CustomerCustomerDemo" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Customers
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 11

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Customers";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Customers
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Customers
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"CUSTOMERID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"CUSTOMERID" + (char)34 + @"
lcParentID=CUSTOMERID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"Orders" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SELECT (lcChildWkArea)
  SCAN FOR CUSTOMERID=lcOldParentID
    pnChildRec=recno()
    pcChildID=CUSTOMERID
    pcChildExpr=" + (char)34 + @"CUSTOMERID" + (char)34 + @"
    IF NOT llRetVal
      EXIT
    ENDIF && not llretval
    llRetVal=riupdate(" + (char)34 + @"CUSTOMERID" + (char)34 + @",lcParentID," + (char)34 + @"CUSTOMERS" + (char)34 + @")
  ENDSCAN get all of the Orders records
  =rireuse(" + (char)34 + @"Orders" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"CUSTOMERID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"CUSTOMERID" + (char)34 + @"
lcParentID=CUSTOMERID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"CustomerCustomerDemo" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO customerid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=ALLTRIM(UPPER(CUSTOMERID))
  pcChildExpr=" + (char)34 + @"ALLTRIM(UPPER(CUSTOMERID))" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"CustomerCustomerDemo" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Customers
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Employees
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 12

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Employees";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Employees
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE EMPLOYEEID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"Employees" + (char)34 + @"," + (char)34 + @"reportsto" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=REPORTSTO
pcChildExpr=" + (char)34 + @"REPORTSTO" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"Employees" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE EMPLOYEEID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"Orders" + (char)34 + @"," + (char)34 + @"employeeid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=EMPLOYEEID
pcChildExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"Orders" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE EMPLOYEEID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"EmployeeTerritories" + (char)34 + @"," + (char)34 + @"employeeid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
SELECT (lcChildWkArea)
SEEK lcParentID
SCAN WHILE EMPLOYEEID=lcParentID AND llRetVal
  pnChildRec=recno()
  pcChildID=EMPLOYEEID
  pcChildExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
  llRetVal=ridelete()
ENDSCAN get all of the EmployeeTerritories records
=rireuse(" + (char)34 + @"EmployeeTerritories" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Employees
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 13

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Employees";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Employees
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Employees
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"EMPLOYEEID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
lcParentID=EMPLOYEEID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"Employees" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO reportsto IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=REPORTSTO
  pcChildExpr=" + (char)34 + @"REPORTSTO" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"Employees" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"EMPLOYEEID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
lcParentID=EMPLOYEEID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"Orders" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO employeeid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=EMPLOYEEID
  pcChildExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"Orders" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"EMPLOYEEID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
lcParentID=EMPLOYEEID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"EmployeeTerritories" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO employeeid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=EMPLOYEEID
  pcChildExpr=" + (char)34 + @"EMPLOYEEID" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"EmployeeTerritories" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Employees
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Orders
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 14

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Orders";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Orders
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE ORDERID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"ORDERID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"OrderDetails" + (char)34 + @"," + (char)34 + @"orderid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
SELECT (lcChildWkArea)
SEEK lcParentID
SCAN WHILE ORDERID=lcParentID AND llRetVal
  pnChildRec=recno()
  pcChildID=ORDERID
  pcChildExpr=" + (char)34 + @"ORDERID" + (char)34 + @"
  llRetVal=ridelete()
ENDSCAN get all of the OrderDetails records
=rireuse(" + (char)34 + @"OrderDetails" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Orders
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 15

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Orders";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Orders
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Orders
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"ORDERID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"ORDERID" + (char)34 + @"
lcParentID=ORDERID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"OrderDetails" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO orderid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=ORDERID
  pcChildExpr=" + (char)34 + @"ORDERID" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"OrderDetails" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Orders
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Products
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 16

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Products";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Products
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE PRODUCTID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"PRODUCTID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"OrderDetails" + (char)34 + @"," + (char)34 + @"productid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=PRODUCTID
pcChildExpr=" + (char)34 + @"PRODUCTID" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"OrderDetails" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Products
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 17

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Products";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Products
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Products
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"PRODUCTID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"PRODUCTID" + (char)34 + @"
lcParentID=PRODUCTID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"OrderDetails" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO productid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=PRODUCTID
  pcChildExpr=" + (char)34 + @"PRODUCTID" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"OrderDetails" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Products
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Region
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 18

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Region";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Region
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE REGIONID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"REGIONID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"Territories" + (char)34 + @"," + (char)34 + @"regionid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=REGIONID
pcChildExpr=" + (char)34 + @"REGIONID" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"Territories" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Region
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 19

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Region";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Region
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Region
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"REGIONID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"REGIONID" + (char)34 + @"
lcParentID=REGIONID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"Territories" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO regionid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=REGIONID
  pcChildExpr=" + (char)34 + @"REGIONID" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"Territories" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Region
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Shippers
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 20

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Shippers";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Shippers
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE SHIPPERID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"SHIPPERID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"Orders" + (char)34 + @"," + (char)34 + @"shipperid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=SHIPVIA
pcChildExpr=" + (char)34 + @"SHIPVIA" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"Orders" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Shippers
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 21

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Shippers";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Shippers
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Shippers
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"SHIPPERID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"SHIPPERID" + (char)34 + @"
lcParentID=SHIPPERID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"Orders" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO shipperid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=SHIPVIA
  pcChildExpr=" + (char)34 + @"SHIPVIA" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"Orders" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Shippers
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Suppliers
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 22

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Suppliers";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Suppliers
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE SUPPLIERID TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"SUPPLIERID" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"Products" + (char)34 + @"," + (char)34 + @"supplierid" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=SUPPLIERID
pcChildExpr=" + (char)34 + @"SUPPLIERID" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"Products" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Suppliers
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 23

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Suppliers";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Suppliers
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Suppliers
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"SUPPLIERID" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"SUPPLIERID" + (char)34 + @"
lcParentID=SUPPLIERID
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"Products" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO supplierid IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=SUPPLIERID
  pcChildExpr=" + (char)34 + @"SUPPLIERID" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"Products" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Suppliers
********************************************************************************

********************************************************************************
** " + (char)34 + @"Referential integrity delete trigger for" + (char)34 + @" Territories
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 24

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Delete_Territories";
            row["ProcedureDefinition"] = @"PROCEDURE __RI_DELETE_Territories
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcParentWkArea
LOCAL llDelHeaderarea
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
STORE ALLTRIM(UPPER(TERRITORYID)) TO lcParentID,pcParentID
pcParentExpr=" + (char)34 + @"ALLTRIM(UPPER(TERRITORYID))" + (char)34 + @"
lcChildWkArea=riopen(" + (char)34 + @"EmployeeTerritories" + (char)34 + @"," + (char)34 + @"territoryi" + (char)34 + @")
IF lcChildWkArea<=0
  IF _triggerlevel=1
    DO riend WITH .F.
  ENDIF at the end of the highest trigger level
  RETURN .F.
ENDIF not able to open the child work area
pcChildDBF=dbf(lcChildWkArea)
llRetVal=!SEEK(lcParentID,lcChildWkArea)
SELECT (lcChildWkArea)
pnChildRec=recno()
pcChildID=TERRITORYID
pcChildExpr=" + (char)34 + @"TERRITORYID" + (char)34 + @"
IF !llRetVal
  pnError = rierror(-1," + (char)34 + @"Delete restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
ENDIF
=rireuse(" + (char)34 + @"EmployeeTerritories" + (char)34 + @",lcChildWkArea)
IF NOT llRetVal
  IF _triggerlevel=1
    DO riend WITH llRetVal
  ENDIF at the end of the highest trigger level
  SELECT (lcStartArea)
  RETURN llRetVal
ENDIF
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Delete trigger for" + (char)34 + @" Territories
********************************************************************************

********************************************************************************
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 25

            row = dataTable.NewRow();
            row["ProcedureName"] = "__Ri_Update_Territories";
            row["ProcedureDefinition"] = @"procedure __RI_UPDATE_Territories
** " + (char)34 + @"Referential integrity update trigger for" + (char)34 + @" Territories
LOCAL llRetVal
llRetVal = .t.
PRIVATE pcParentDBF,pnParentRec,pcChildDBF,pnChildRec,pcParentID,pcChildID
PRIVATE pcParentExpr,pcChildExpr
STORE " + (char)34 + @"" + (char)34 + @" TO pcParentDBF,pcChildDBF,pcParentID,pcChildID,pcParentExpr,pcChildExpr
STORE 0 TO pnParentRec,pnChildRec
IF _triggerlevel=1
  BEGIN TRANSACTION
  PRIVATE pcRIcursors,pcRIwkareas,pcRIolderror,pnerror,;
  pcOldDele,pcOldExact,pcOldTalk,pcOldCompat,PcOldDBC
  pcOldTalk=SET(" + (char)34 + @"TALK" + (char)34 + @")
  SET TALK OFF
  pcOldDele=SET(" + (char)34 + @"DELETED" + (char)34 + @")
  pcOldExact=SET(" + (char)34 + @"EXACT" + (char)34 + @")
  pcOldCompat=SET(" + (char)34 + @"COMPATIBLE" + (char)34 + @")
  SET COMPATIBLE OFF
  SET DELETED ON
  SET EXACT OFF
  pcRIcursors=" + (char)34 + @"" + (char)34 + @"
  pcRIwkareas=" + (char)34 + @"" + (char)34 + @"
  pcRIolderror=ON(" + (char)34 + @"error" + (char)34 + @")
  pnerror=0
  ON ERROR pnerror=rierror(ERROR(),message(),message(1),program())
  IF TYPE('gaErrors(1)')<>" + (char)34 + @"U" + (char)34 + @"
    release gaErrors
  ENDIF
  PUBLIC gaErrors(1,12)
  pcOldDBC=DBC()
  SET DATA TO (" + (char)34 + @"NORTHWIND" + (char)34 + @")
ENDIF first trigger
LOCAL lcParentID && parent's value to be sought in child
LOCAL lcOldParentID && previous parent id value
LOCAL lcChildWkArea && child work area handle returned by riopen
LOCAL lcChildID && child's value to be sought in parent
LOCAL lcOldChildID && old child id value
LOCAL lcParentWkArea && parentwork area handle returned by riopen
LOCAL lcStartArea
lcStartArea=select()
llRetVal=.t.
lcParentWkArea=select()
SELECT (lcParentWkArea)
pcParentDBF=dbf()
pnParentRec=recno()
lcOldParentID=OLDVAL(" + (char)34 + @"ALLTRIM(UPPER(TERRITORYID))" + (char)34 + @")
pcParentID=lcOldParentID
pcParentExpr=" + (char)34 + @"ALLTRIM(UPPER(TERRITORYID))" + (char)34 + @"
lcParentID=ALLTRIM(UPPER(TERRITORYID))
IF lcParentID<>lcOldParentID
  lcChildWkArea=riopen(" + (char)34 + @"EmployeeTerritories" + (char)34 + @")
  IF lcChildWkArea<=0
    IF _triggerlevel=1
      DO riend WITH .F.
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN .F.
  ENDIF not able to open the child work area
  pcChildDBF=dbf(lcChildWkArea)
  SET ORDER TO territoryi IN (lcChildWkArea)
  llRetVal=!SEEK(lcOldParentID,lcChildWkArea)
  pnChildRec=recno()
  pcChildID=TERRITORYID
  pcChildExpr=" + (char)34 + @"TERRITORYID" + (char)34 + @"
  IF !llRetVal
    pnError = rierror(-1," + (char)34 + @"Update restrict rule violated." + (char)34 + @"," + (char)34 + @"" + (char)34 + @"," + (char)34 + @"" + (char)34 + @")
  ENDIF
  =rireuse(" + (char)34 + @"EmployeeTerritories" + (char)34 + @",lcChildWkArea)
  IF NOT llRetVal
    IF _triggerlevel=1
      DO riend WITH llRetVal
    ENDIF at the end of the highest trigger level
    SELECT (lcStartArea)
    RETURN llRetVal
  ENDIF
ENDIF this parent id changed
IF _triggerlevel=1
  do riend with llRetVal
ENDIF at the end of the highest trigger level
SELECT (lcStartArea)
RETURN llRetVal
** " + (char)34 + @"End of Referential integrity Update trigger for" + (char)34 + @" Territories
********************************************************************************
**__RI_FOOTER!@ Do NOT REMOVE or MODIFY this line!!!! @!__RI_FOOTER**

*------------------------------------------------
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = true;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 26

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["ProcedureDefinition"] = @"PROCEDURE CustOrderHist(tcCustomerID as String )
*------------------------------------------------
LOCAL lcCustomerID as String 
lcCustomerID = IIF(VARTYPE(tcCustomerID)!=" + (char)34 + @"C" + (char)34 + @"," + (char)34 + @"" + (char)34 + @",tcCustomerID)

SELECT ProductName, SUM(Quantity) AS Total ;
  FROM Products P, OrderDetails OD, Orders O, Customers C ;
  WHERE C.CustomerID = lcCustomerID ;
    AND C.CustomerID = O.CustomerID ;
    AND O.OrderID = OD.OrderID ;
    AND OD.ProductID = P.ProductID ;
  GROUP BY ProductName ;
  INTO CURSOR CustOrderHist

SETRESULTSET('CustOrderHist')
RETURN RECCOUNT('CustOrderHist')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 27

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["ProcedureDefinition"] = @"PROCEDURE CustOrdersDetail(tiOrderID as Integer )
*------------------------------------------------ 
LOCAL liOrderID as Integer 
liOrderID = IIF(VARTYPE(tiOrderID)!=" + (char)34 + @"N" + (char)34 + @",0,tiOrderID)

SELECT ProductName, ;
  ROUND(Od.UnitPrice, 2) AS UnitPrice, ;
  Quantity, ; 
  (Discount*100) AS Discount, ;
  ROUND(Quantity * (1 - Discount) * Od.UnitPrice, 2) AS ExtendedPrice ;
  FROM Products P, OrderDetails Od ;
  WHERE Od.ProductID = P.ProductID and Od.OrderID = liOrderID ;
  INTO CURSOR CustOrdersDetail

SETRESULTSET('CustOrdersDetail')
RETURN RECCOUNT('CustOrdersDetail')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 28

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["ProcedureDefinition"] = @"PROCEDURE CustOrdersOrders(tcCustomerID as String)
*------------------------------------------------
LOCAL lcCustomerID as String 
lcCustomerID = IIF(VARTYPE(tcCustomerID)!=" + (char)34 + @"C" + (char)34 + @"," + (char)34 + @"" + (char)34 + @",tcCustomerID)

SELECT OrderID, OrderDate, RequiredDate, ShippedDate ;
  FROM Orders ;
  WHERE CustomerID = lcCustomerID ;
  ORDER BY OrderID ;
  INTO CURSOR CustOrdersOrders

SETRESULTSET('CustOrdersOrders')
RETURN RECCOUNT('CustOrdersOrders')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 29

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["ProcedureDefinition"] = @"PROCEDURE SalesByYear(tdBeginning_Date as Date, tdEnding_Date as Date)
*---------------------------------------------------------------------------------
ldBeginning_Date= IIF(VARTYPE(tdBeginning_Date)!=" + (char)34 + @"D" + (char)34 + @",{^1901/01/01},tdBeginning_Date)
ldEnding_Date 	= IIF(VARTYPE(tdEnding_Date)!=" + (char)34 + @"D" + (char)34 + @",{^2101/01/01},tdEnding_Date)

SELECT Orders.ShippedDate, Orders.OrderID, Order_Subtotals.Subtotal, YEAR(ShippedDate) AS Year ;
  FROM Orders ;
  INNER JOIN Order_Subtotals ON Orders.OrderID = Order_Subtotals.OrderID ;
  WHERE BETWEEN(Orders.ShippedDate, ldBeginning_Date, ldEnding_Date) ;
  INTO CURSOR SalesByYear

SETRESULTSET('SalesByYear')
RETURN RECCOUNT('SalesByYear')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 30

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["ProcedureDefinition"] = @"PROCEDURE EmployeeSalesbyCountry(tdBeginning_Date as Date, tdEnding_Date as Date)
*---------------------------------------------------------------------------------
LOCAL ldBeginning_Date as Date, ldEnding_Date as Date
ldBeginning_Date = IIF(VARTYPE(tdBeginning_Date)!=" + (char)34 + @"D" + (char)34 + @",{^1901/01/01},tdBeginning_Date)
ldEnding_Date 	 = IIF(VARTYPE(tdEnding_Date)!=" + (char)34 + @"D" + (char)34 + @",{^2101/01/01},tdEnding_Date)

SELECT Employees.Country, Employees.LastName, ;
  Employees.FirstName, Orders.ShippedDate, ;
  Orders.OrderID, Order_Subtotals.Subtotal AS SaleAmount ;
  FROM Employees INNER JOIN ;
	(Orders INNER JOIN Order_Subtotals ON Orders.OrderID = Order_Subtotals.OrderID) ;
	ON Employees.EmployeeID = Orders.EmployeeID ;
  WHERE BETWEEN(Orders.ShippedDate, ldBeginning_Date, ldEnding_Date) ;
  INTO CURSOR SalesbyCountry

SETRESULTSET('SalesbyCountry')
RETURN RECCOUNT('SalesbyCountry')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchemaWithProcedureName() {
            DataTable dataTable = new DataTable("Procedures");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ProcedureDefinition", typeof(System.String));
            dataTable.Columns.Add("Description", typeof(System.String));
            dataTable.Columns.Add("ReferentialIntegrity", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["ProcedureDefinition"] = @"PROCEDURE CustOrderHist(tcCustomerID as String )
*------------------------------------------------
LOCAL lcCustomerID as String 
lcCustomerID = IIF(VARTYPE(tcCustomerID)!=" + (char)34 + @"C" + (char)34 + @"," + (char)34 + @"" + (char)34 + @",tcCustomerID)

SELECT ProductName, SUM(Quantity) AS Total ;
  FROM Products P, OrderDetails OD, Orders O, Customers C ;
  WHERE C.CustomerID = lcCustomerID ;
    AND C.CustomerID = O.CustomerID ;
    AND O.OrderID = OD.OrderID ;
    AND OD.ProductID = P.ProductID ;
  GROUP BY ProductName ;
  INTO CURSOR CustOrderHist

SETRESULTSET('CustOrderHist')
RETURN RECCOUNT('CustOrderHist')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }

        public static DataTable GetSchema() {
            DataTable dataTable = new DataTable("Procedures");

            #region columns

            dataTable.Columns.Add("ProcedureName", typeof(System.String));
            dataTable.Columns.Add("ProcedureDefinition", typeof(System.String));
            dataTable.Columns.Add("Description", typeof(System.String));
            dataTable.Columns.Add("ReferentialIntegrity", typeof(System.Boolean));

            #endregion columns

            #region rows

            DataRow row;

            #region row 0

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custorderhist";
            row["ProcedureDefinition"] = @"PROCEDURE CustOrderHist(tcCustomerID as String )
*------------------------------------------------
LOCAL lcCustomerID as String 
lcCustomerID = IIF(VARTYPE(tcCustomerID)!=" + (char)34 + @"C" + (char)34 + @"," + (char)34 + @"" + (char)34 + @",tcCustomerID)

SELECT ProductName, SUM(Quantity) AS Total ;
  FROM Products P, OrderDetails OD, Orders O, Customers C ;
  WHERE C.CustomerID = lcCustomerID ;
    AND C.CustomerID = O.CustomerID ;
    AND O.OrderID = OD.OrderID ;
    AND OD.ProductID = P.ProductID ;
  GROUP BY ProductName ;
  INTO CURSOR CustOrderHist

SETRESULTSET('CustOrderHist')
RETURN RECCOUNT('CustOrderHist')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 1

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersdetail";
            row["ProcedureDefinition"] = @"PROCEDURE CustOrdersDetail(tiOrderID as Integer )
*------------------------------------------------ 
LOCAL liOrderID as Integer 
liOrderID = IIF(VARTYPE(tiOrderID)!=" + (char)34 + @"N" + (char)34 + @",0,tiOrderID)

SELECT ProductName, ;
  ROUND(Od.UnitPrice, 2) AS UnitPrice, ;
  Quantity, ; 
  (Discount*100) AS Discount, ;
  ROUND(Quantity * (1 - Discount) * Od.UnitPrice, 2) AS ExtendedPrice ;
  FROM Products P, OrderDetails Od ;
  WHERE Od.ProductID = P.ProductID and Od.OrderID = liOrderID ;
  INTO CURSOR CustOrdersDetail

SETRESULTSET('CustOrdersDetail')
RETURN RECCOUNT('CustOrdersDetail')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 2

            row = dataTable.NewRow();
            row["ProcedureName"] = "Custordersorders";
            row["ProcedureDefinition"] = @"PROCEDURE CustOrdersOrders(tcCustomerID as String)
*------------------------------------------------
LOCAL lcCustomerID as String 
lcCustomerID = IIF(VARTYPE(tcCustomerID)!=" + (char)34 + @"C" + (char)34 + @"," + (char)34 + @"" + (char)34 + @",tcCustomerID)

SELECT OrderID, OrderDate, RequiredDate, ShippedDate ;
  FROM Orders ;
  WHERE CustomerID = lcCustomerID ;
  ORDER BY OrderID ;
  INTO CURSOR CustOrdersOrders

SETRESULTSET('CustOrdersOrders')
RETURN RECCOUNT('CustOrdersOrders')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 3

            row = dataTable.NewRow();
            row["ProcedureName"] = "Salesbyyear";
            row["ProcedureDefinition"] = @"PROCEDURE SalesByYear(tdBeginning_Date as Date, tdEnding_Date as Date)
*---------------------------------------------------------------------------------
ldBeginning_Date= IIF(VARTYPE(tdBeginning_Date)!=" + (char)34 + @"D" + (char)34 + @",{^1901/01/01},tdBeginning_Date)
ldEnding_Date 	= IIF(VARTYPE(tdEnding_Date)!=" + (char)34 + @"D" + (char)34 + @",{^2101/01/01},tdEnding_Date)

SELECT Orders.ShippedDate, Orders.OrderID, Order_Subtotals.Subtotal, YEAR(ShippedDate) AS Year ;
  FROM Orders ;
  INNER JOIN Order_Subtotals ON Orders.OrderID = Order_Subtotals.OrderID ;
  WHERE BETWEEN(Orders.ShippedDate, ldBeginning_Date, ldEnding_Date) ;
  INTO CURSOR SalesByYear

SETRESULTSET('SalesByYear')
RETURN RECCOUNT('SalesByYear')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #region row 4

            row = dataTable.NewRow();
            row["ProcedureName"] = "Employeesalesbycountry";
            row["ProcedureDefinition"] = @"PROCEDURE EmployeeSalesbyCountry(tdBeginning_Date as Date, tdEnding_Date as Date)
*---------------------------------------------------------------------------------
LOCAL ldBeginning_Date as Date, ldEnding_Date as Date
ldBeginning_Date = IIF(VARTYPE(tdBeginning_Date)!=" + (char)34 + @"D" + (char)34 + @",{^1901/01/01},tdBeginning_Date)
ldEnding_Date 	 = IIF(VARTYPE(tdEnding_Date)!=" + (char)34 + @"D" + (char)34 + @",{^2101/01/01},tdEnding_Date)

SELECT Employees.Country, Employees.LastName, ;
  Employees.FirstName, Orders.ShippedDate, ;
  Orders.OrderID, Order_Subtotals.Subtotal AS SaleAmount ;
  FROM Employees INNER JOIN ;
	(Orders INNER JOIN Order_Subtotals ON Orders.OrderID = Order_Subtotals.OrderID) ;
	ON Employees.EmployeeID = Orders.EmployeeID ;
  WHERE BETWEEN(Orders.ShippedDate, ldBeginning_Date, ldEnding_Date) ;
  INTO CURSOR SalesbyCountry

SETRESULTSET('SalesbyCountry')
RETURN RECCOUNT('SalesbyCountry')

ENDPROC
";
            row["Description"] = DBNull.Value;
            row["ReferentialIntegrity"] = false;
            dataTable.Rows.Add(row);

            #endregion row

            #endregion rows

            return dataTable;
        }
    }
}
