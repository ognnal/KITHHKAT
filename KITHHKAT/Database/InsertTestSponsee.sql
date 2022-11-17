USE HHKAT
GO

DECLARE @COUNTER AS INT

SET @COUNTER = 200

WHILE @COUNTER < 500000
BEGIN

INSERT INTO [SponseeInfo](
	   [SponseeID]
      ,[FirstName]
      ,[LastName]
      ,[DOB]
      ,[Gender]
      ,[Grade]
      ,[ShoeSize]
      ,[ShirtSize]
      ,[PantsSize]
      ,[DateJoinCOJ]
      ,[ChurchID]
      ,[Photo]
      ,[UserModified]
      ,[DateModified])
SELECT
CONCAT('SponseeID', @COUNTER),	
'FirstName',	
'LastName',	
'2007-11-21 00:00:00.000',	
'F',	
13,	
6,	
14,	
18,	
'2014-10-15 00:00:00.000',	
concat('ChurchID',@COUNTER%30),	
NULL,	
concat('User', @Counter),	
getdate()

SET @COUNTER = @COUNTER + 1
END
