USE HHKAT
GO

DECLARE @COUNTER AS INT

SET @COUNTER = 500

WHILE @COUNTER < 1500
BEGIN

INSERT INTO [dbo].[SponsorInfo](
	   [SponsorID]
      ,[FirstName]
      ,[LastName]
      ,[AlternateName]
      ,[Email]
      ,[Address]
      ,[City]
      ,[State]
      ,[PhoneNum]
      ,[DateModified]
      ,[UserModified]
      ,[PrimaryLanguage])
SELECT
CONCAT('SponsorID', @COUNTER),	
'FirstName',	
'LastName',	
'AlternateName',	
concat('Email',@COUNTER,'@',@COUNTER,'.com'),	
concat('Address', @COUNTER),
'CityName',	
'AZ',	
1627384983+@COUNTER,
getdate(),
concat( 'User', @COUNTER),		
'English'

SET @COUNTER = @COUNTER + 1
END
