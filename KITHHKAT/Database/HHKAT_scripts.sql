USE [HHKAT]
GO
/****** Object:  User [@@@@@@@]    Script Date: 5/5/2015 6:49:36 PM ******/
CREATE USER [@@@@@@@] FOR LOGIN [@@@@@@@] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [@@@@@@@1]    Script Date: 5/5/2015 6:49:36 PM ******/
CREATE USER [@@@@@@@1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [@@@@@@@2]    Script Date: 5/5/2015 6:49:36 PM ******/
CREATE USER [@@@@@@@2] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [@@@@@@@]
GO
ALTER ROLE [db_owner] ADD MEMBER [@@@@@@@1]
GO
ALTER ROLE [db_owner] ADD MEMBER [@@@@@@@2]
GO
ALTER ROLE [db_datareader] ADD MEMBER [@@@@@@@2]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [@@@@@@@2]
GO
/****** Object:  Schema [Reference]    Script Date: 5/5/2015 6:49:36 PM ******/
CREATE SCHEMA [Reference]
GO
/****** Object:  Schema [report]    Script Date: 5/5/2015 6:49:36 PM ******/
CREATE SCHEMA [report]
GO
/****** Object:  Schema [warehouse]    Script Date: 5/5/2015 6:49:36 PM ******/
CREATE SCHEMA [warehouse]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteChurchInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDeleteChurchInfo]
@ChurchID AS nvarchar(15),
@UserModified AS nvarchar(50)
AS
BEGIN

BEGIN TRANSACTION

Update [dbo].[ChurchInfo]
set UserModified = @UserModified,
DateModified = getdate()
WHERE ChurchID = @ChurchID

DELETE FROM [dbo].[ChurchInfo]
WHERE @ChurchID = ChurchID

IF @@ROWCOUNT = 1
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION


END

GO
/****** Object:  StoredProcedure [dbo].[spDeletePrimaryLanguage]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDeletePrimaryLanguage] 
	-- Add the parameters for the stored procedure here
	@PrimaryLanguage as nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

DELETE FROM [HHKAT].[Reference].[PrimaryLanguage]
WHERE [PrimaryLanguage] = @PrimaryLanguage

END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteRelationshipInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDeleteRelationshipInfo]

	@RelationshipID int,
	@UserModified nvarchar(50)

AS
BEGIN

BEGIN TRANSACTION

DELETE FROM ContributionsInfo
WHERE RelationshipID = @RelationshipID

Update RelationshipInfo
set UserModified = @UserModified,
DateModified = getdate()
WHERE RelationshipID = @RelationshipID

DELETE FROM RelationshipInfo
WHERE RelationshipID = @RelationshipID

IF @@ROWCOUNT = 1
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION

END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteSponseeInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDeleteSponseeInfo]
@SponseeID AS nvarchar(15),
@UserModified nvarchar(50)
AS
BEGIN

BEGIN TRANSACTION

Update [dbo].[SponseeInfo]
set UserModified = @UserModified,
DateModified = getdate()
WHERE SponseeID = @SponseeID

DELETE FROM [dbo].[SponseeInfo]
WHERE @SponseeID = SponseeID

IF @@ROWCOUNT = 1
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION


END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteSponsorInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDeleteSponsorInfo]
@SponsorID AS nvarchar(15),
@UserModified nvarchar(50)
AS
BEGIN

BEGIN TRANSACTION

DELETE FROM [dbo].[HHKContributionsInfo]
WHERE @SponsorID = SponsorID

Update [dbo].[SponsorInfo]
set UserModified = @UserModified,
DateModified = getdate()
WHERE SponsorID = @SponsorID


DELETE FROM [dbo].[SponsorInfo]
WHERE @SponsorID = SponsorID

IF @@ROWCOUNT = 1
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION


END

GO
/****** Object:  StoredProcedure [dbo].[spGetChurchCount]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetChurchCount]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT COUNT(*) FROM [dbo].[ChurchInfo]

END

GO
/****** Object:  StoredProcedure [dbo].[spGetHHKContributions]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetHHKContributions] 
	-- Add the parameters for the stored procedure here
	@SponsorID nvarchar(15)
AS
BEGIN

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [HHKContributionID]
      ,[SponsorID]
      ,[TransactionDate]
      ,[UserModified]
      ,[TransactionAmount]
  FROM [HHKAT].[dbo].[HHKContributionsInfo]
  WHERE [SponsorID] = @SponsorID


END

GO
/****** Object:  StoredProcedure [dbo].[spGetMonthBirthday]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetMonthBirthday]
@month as int
AS
BEGIN

SELECT 
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
FROM [SponseeInfo]
	WHERE month([DOB]) = @month

END

GO
/****** Object:  StoredProcedure [dbo].[spGetRelationshipContributions]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetRelationshipContributions] 
	@RelationshipID nvarchar(50)
AS
BEGIN

SELECT
	   [ContributionID]
      ,[RelationshipID]
      ,[TransactionDate]
      ,[UserModified]
      ,[TransactionAmount]
	  FROM [dbo].[ContributionsInfo]
	  WHERE [RelationshipID] = @RelationshipID
END

GO
/****** Object:  StoredProcedure [dbo].[spGetRelationshipCount]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetRelationshipCount]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT COUNT(*) FROM [dbo].[RelationshipInfo]

END

GO
/****** Object:  StoredProcedure [dbo].[spGetSponseeCount]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetSponseeCount]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT COUNT(*) FROM [dbo].[SponseeInfo]

END

GO
/****** Object:  StoredProcedure [dbo].[spGetSponsorCount]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetSponsorCount]

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT COUNT(*) FROM [dbo].[SponsorInfo]

END

GO
/****** Object:  StoredProcedure [dbo].[spGetUnmatchedSponsees]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetUnmatchedSponsees]

AS
BEGIN

	SET NOCOUNT ON;

SELECT 
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
      ,[DateModified]
FROM SponseeInfo
WHERE SponseeID NOT IN 
(SELECT SponseeID FROM RelationshipInfo)
--Or Select SEI.* FROM SponseeInfo SEI Inner Join RelationshipInfo RI ON SEI.ID=RI.ID


END

GO
/****** Object:  StoredProcedure [dbo].[spGetUnmatchedSponseesCount]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetUnmatchedSponseesCount]

AS
BEGIN

	SET NOCOUNT ON;

SELECT 
	  COUNT(*)
FROM SponseeInfo
WHERE SponseeID NOT IN 
(SELECT SponseeID FROM RelationshipInfo)
--Or Select SEI.* FROM SponseeInfo SEI Inner Join RelationshipInfo RI ON SEI.ID=RI.ID


END

GO
/****** Object:  StoredProcedure [dbo].[spGetUnmatchedSponsors]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetUnmatchedSponsors]

AS
BEGIN

	SET NOCOUNT ON;

SELECT 
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
	  ,[PrimaryLanguage]
FROM SponsorInfo
WHERE SponsorID NOT IN 
(SELECT SponsorID FROM RelationshipInfo)
--Or Select SRI.* FROM SponsorInfo SRI Inner Join RelationshipInfo RI ON SRI.ID=RI.ID


END

GO
/****** Object:  StoredProcedure [dbo].[spInsertChurchInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertChurchInfo] (
	@ChurchID nvarchar(15),
	@ChurchName nvarchar(50),
	@Area nvarchar(50),
	@District nvarchar(50),
	@City nvarchar(50),
	@UserModified nvarchar(50)
	)
AS
BEGIN

INSERT INTO ChurchInfo(
	ChurchID,
	ChurchName,
	Area,
	District,
	City,
	UserModified,
	DateModified
	)
VALUES(
	@ChurchID,
	@ChurchName,
	@Area,
	@District,
	@City,
	@UserModified,
	getdate()
	)

END



GO
/****** Object:  StoredProcedure [dbo].[spInsertContribution]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertContribution]
@RelationshipID INT,
@TransactionAmount money,
@UserModified nvarchar(50)
AS
BEGIN

SET NOCOUNT ON

INSERT INTO ContributionsInfo
(
RelationshipID
,TransactionAmount
,UserModified
,TransactionDate

)
VALUES
(
@RelationshipID,
@TransactionAmount,
@UserModified,
getdate()
)

END



GO
/****** Object:  StoredProcedure [dbo].[spInsertHHKContribution]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertHHKContribution]
@SponsorID nvarchar(15),
@TransactionAmount money,
@UserModified nvarchar(50)
AS
BEGIN

SET NOCOUNT ON

INSERT INTO HHKContributionsInfo
(
SponsorID
,TransactionAmount
,UserModified
,TransactionDate

)
VALUES
(
@SponsorID,
@TransactionAmount,
@UserModified,
getdate()
)

END



GO
/****** Object:  StoredProcedure [dbo].[spInsertPrimaryLanguage]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertPrimaryLanguage] 
	-- Add the parameters for the stored procedure here
	@PrimaryLanguage as nvarchar(50),
	@LanguageReceiptText as nvarchar(max) 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

INSERT INTO [HHKAT].[Reference].[PrimaryLanguage] (
		[PrimaryLanguage]
	   ,[LanguageReceiptText]
		)
	  VALUES(
		@PrimaryLanguage,
		@LanguageReceiptText
		)

END

GO
/****** Object:  StoredProcedure [dbo].[spInsertRelationship]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertRelationship] (
	@SponsorID nvarchar(15),
	@SponseeID nvarchar(15),
	@UserModified nvarchar(50)
)
AS
BEGIN

	IF EXISTS (SELECT 1 FROM RelationshipInfo WHERE SponseeID = @SponseeID)
		BEGIN
			RAISERROR (15600,-1,-1, 'Relationship Exists');
		END
	ELSE
		BEGIN
		INSERT INTO RelationshipInfo(
			SponsorID,
			SponseeID,
			StartDate,
			UserModified,
			DateModified
			)
		VALUES(
			@SponsorID,
			@SponseeID,
			GetDate(),
			@UserModified,
			GetDate()
			)
		END
	
END



GO
/****** Object:  StoredProcedure [dbo].[spInsertSponseeInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertSponseeInfo] 
	@SponseeID nvarchar(15),
	@FirstName nvarchar(50),
	@LastName nvarchar(50) ,
	@DOB date ,
	@Gender nchar(1) ,
	@Grade nchar(2) ,
	@ShoeSize int ,
	@ShirtSize int ,
	@PantsSize int ,
	@DateJoinCOJ date ,
	@ChurchID nvarchar(15),
	@Photo nvarchar(100),
	@AppPath nvarchar(255),
	@UserModified nvarchar(50)
AS
BEGIN

INSERT INTO SponseeInfo(
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
	,[AppPath]
	,[UserModified]
	,[DateModified])
VALUES(
	@SponseeID,
	@FirstName,
	@LastName,
	@DOB,
	@Gender,
	@Grade,
	@ShoeSize,
	@ShirtSize,
	@PantsSize,
	@DateJoinCOJ,
	@ChurchID,
	@Photo,
	@AppPath,
	@UserModified,
	getdate()
	)

END



GO
/****** Object:  StoredProcedure [dbo].[spInsertSponsorInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertSponsorInfo] (
	@SponsorID nvarchar(15) ,
	@FirstName nvarchar(50) ,
	@LastName nvarchar(50) ,
	@AlternateName nvarchar(50) ,
	@Email nvarchar(50) ,
	@Address nvarchar(50) ,
	@City nvarchar(50) ,
	@State nvarchar(50) ,
	@PhoneNum nvarchar(50),
	@UserModified nvarchar(50),
	@PrimaryLanguage nvarchar(50)
	)
	
AS
BEGIN

IF (
     CHARINDEX(' ',LTRIM(RTRIM(@Email))) = 0 
AND  LEFT(LTRIM(@Email),1) <> '@' 
AND  RIGHT(RTRIM(@Email),1) <> '.' 
AND  CHARINDEX('.',@Email ,CHARINDEX('@',@Email)) - CHARINDEX('@',@Email ) > 1 
AND  LEN(LTRIM(RTRIM(@Email ))) - LEN(REPLACE(LTRIM(RTRIM(@Email)),'@','')) = 1 
AND  CHARINDEX('.',REVERSE(LTRIM(RTRIM(@Email)))) >= 3 
AND  (CHARINDEX('.@',@Email ) = 0 AND CHARINDEX('..',@Email ) = 0)
)
BEGIN
INSERT INTO SponsorInfo(
	SponsorID,
	FirstName,
	LastName,
	AlternateName,
	Email,
	Address,
	City,
	State,
	PhoneNum,
	UserModified, 
	DateModified,
	PrimaryLanguage
	)
VALUES(
	@SponsorID,
	@FirstName,
	@LastName,
	@AlternateName,
	@Email,
	@Address,
	@City,
	@State,
	@PhoneNum,
	@UserModified,
	getdate(),
	@PrimaryLanguage
	)
	END
ELSE
   RAISERROR(15600,-1,-1, 'Invalid Email Address')

END



GO
/****** Object:  StoredProcedure [dbo].[spSearchChurch]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSearchChurch]

	@ChurchID nvarchar(15),
	@ChurchName nvarchar(50),
	@Area nvarchar(50),
	@District nvarchar(50),
	@City nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

Declare @ParamDefinition AS nvarchar(2000)  = 
   '@ChurchID nvarchar(15),
	@ChurchName nvarchar(50),
	@Area nvarchar(50),
	@District nvarchar(50),
	@City nvarchar(50)'

DECLARE @dynamicSQL nvarchar(max)
SET @dynamicSQL = 
'SELECT
	   [ChurchID]
      ,[ChurchName]
      ,[Area]
      ,[District]
      ,[City]
      ,[UserModified]
      ,[DateModified]
FROM 
	ChurchInfo
WHERE 1=1'

 IF @ChurchID IS NOT NULL AND len(@ChurchID) <> 0
         SET @dynamicSQL += ' And (ChurchID LIKE ''' + '%' + @ChurchID + '%' + ''')'
 IF @ChurchName IS NOT NULL AND len(@ChurchName) <> 0
         SET @dynamicSQL += ' And (ChurchName LIKE ''' + '%' + @ChurchName + '%' + ''')'
 IF @Area IS NOT NULL AND len(@Area) <> 0
         SET @dynamicSQL += ' And (Area LIKE ''' + '%' + @Area + '%' + ''')'
 IF @District IS NOT NULL AND len(@District) <> 0
         SET @dynamicSQL += ' And (District LIKE ''' + '%' + @District + '%' + ''')'
 IF @City IS NOT NULL AND len(@City) <> 0
         SET @dynamicSQL += ' And (City LIKE ''' + '%' + @City + '%' + ''')'

--PRINT @dynamicSQL

EXECUTE sp_executesql 
@dynamicSQL 
,@ParamDefinition
,@ChurchID
,@ChurchName
,@Area 
,@District
,@City

END

GO
/****** Object:  StoredProcedure [dbo].[spSearchRelationship]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSearchRelationship]

	@RelationshipID nvarchar(15) = NULL,
	@SponsorID nvarchar(15) = NULL,
	@SponseeID nvarchar(15) = NULL,
	@SponseeFirstName nvarchar(50) = NULL,
	@SponseeLastName nvarchar(50) = NULL,
	@ChurchName nvarchar(50) = NULL,
	@SponsorFirstName nvarchar(50) = NULL,
	@SponsorLastName nvarchar(50) = NULL

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

Declare @ParamDefinition AS NVarchar(2000)  = 
   '@RelationshipID nvarchar(15),
	@SponsorID nvarchar(15),
	@SponseeID nvarchar(15),
	@SponseeFirstName nvarchar(50),
	@SponseeLastName nvarchar(50),
	@ChurchName nvarchar(50),
	@SponsorFirstName nvarchar(50),
	@SponsorLastName nvarchar(50)
	'

DECLARE @dynamicSQL nvarchar(max)
SET @dynamicSQL = 
'SELECT
	RI.RelationshipID,
	RI.SponseeID,
	SEI.FirstName as [Sponsee First Name],
	SEI.LastName as [Sponsee Last Name],
	RI.SponsorID,
	SRI.FirstName as [Sponsor First Name],
	SRI.LastName as [Sponsor Last Name],
	CI.ChurchName,
	RI.Letter

FROM RelationshipInfo RI
	INNER JOIN SponseeInfo SEI
ON RI.SponseeID=SEI.SponseeID
	INNER JOIN SponsorInfo SRI
ON RI.SponsorID = SRI.SponsorID
	INNER JOIN ChurchInfo CI
ON CI.ChurchID = SEI.ChurchID
WHERE 1=1'

IF @RelationshipID IS NOT NULL AND len(rtrim(ltrim(@RelationshipID))) <> 0
        SET @dynamicSQL += ' And (RI.RelationshipID LIKE ''' + '%' + @RelationshipID + '%' + ''')'
IF @SponsorID IS NOT NULL AND len(rtrim(ltrim(@SponsorID))) <> 0
        SET @dynamicSQL += ' And (RI.SponsorID LIKE ''' + '%' + @SponsorID + '%' + ''')'
IF @SponseeID IS NOT NULL AND len(rtrim(ltrim(@SponseeID))) <> 0
        SET @dynamicSQL += ' And (RI.SponseeID LIKE ''' + '%' + @SponseeID + '%' + ''')'
IF @SponseeFirstName IS NOT NULL AND len(rtrim(ltrim(@SponseeFirstName))) <> 0 
		SET @dynamicSQL += ' And (SEI.FirstName LIKE ''' + '%' + @SponseeFirstName + '%' + ''')'
IF @SponseeLastName IS NOT NULL AND len(rtrim(ltrim(@SponseeLastName))) <> 0 
		SET @dynamicSQL += ' And (SEI.LastName LIKE ''' + '%' + @SponseeLastName + '%' + ''')'
IF @ChurchName IS NOT NULL AND len(rtrim(ltrim(@ChurchName))) <> 0 
		SET @dynamicSQL += ' And (CI.ChurchName LIKE ''' + '%' + @ChurchName + '%' + ''')'
IF @SponsorFirstName IS NOT NULL AND len(rtrim(ltrim(@SponsorFirstName))) <> 0 
		SET @dynamicSQL += ' And (SRI.FirstName LIKE ''' + '%' + @SponsorFirstName + '%' + ''')'
IF @SponsorLastName  IS NOT NULL AND len(rtrim(ltrim(@SponsorLastName ))) <> 0 
		SET @dynamicSQL += ' And (SRI.LastName LIKE ''' + '%' + @SponsorLastName + '%' + ''')'

SET @dynamicSQL += 'Order By RI.DateModified DESC'	 
--PRINT @dynamicSQL 

EXECUTE sp_executesql 
@dynamicSQL 
,@ParamDefinition
,@RelationshipID
,@SponsorID
,@SponseeID 
,@SponseeFirstName
,@SponseeLastName
,@ChurchName
,@SponsorFirstName
,@SponsorLastName
END

GO
/****** Object:  StoredProcedure [dbo].[spSearchSponsee]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSearchSponsee]

	@SponseeID nvarchar(15),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@DOB datetime,
	@Grade nchar(2),
	@DateJoinCOJ datetime,
	@ChurchID nvarchar(15)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

Declare @ParamDefinition AS NVarchar(2000)  = 
   '@SponseeID nvarchar(15),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@DOB datetime,
	@Grade nchar(2),
	@DateJoinCOJ datetime,
	@ChurchID nvarchar(15)'

DECLARE @dynamicSQL nvarchar(max)
SET @dynamicSQL = 
'SELECT
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
	  ,[AppPath]
      ,[UserModified]
      ,[DateModified]
	FROM 
		SponseeInfo
	WHERE 1=1'

 IF @SponseeID IS NOT NULL AND len(rtrim(ltrim(@SponseeID))) <> 0
         SET @dynamicSQL += ' And (SponseeID LIKE ''' + '%' + @SponseeID + '%' + ''')'
 IF @FirstName IS NOT NULL AND len(rtrim(ltrim(@FirstName))) <> 0
         SET @dynamicSQL += ' And (FirstName LIKE ''' + '%' + @FirstName + '%' + ''')'
 IF @LastName IS NOT NULL AND len(rtrim(ltrim(@LastName))) <> 0
         SET @dynamicSQL += ' And (LastName LIKE ''' + '%' + @LastName + '%' + ''')'
 IF @DOB IS NOT NULL AND len(rtrim(ltrim(@DOB))) <> 0
         SET @dynamicSQL += ' And (DOB >= @DOB)'
 IF @Grade IS NOT NULL AND len(rtrim(ltrim(@Grade))) <> 0
         SET @dynamicSQL += ' And (Grade = @Grade)'
 IF @DateJoinCOJ IS NOT NULL AND len(rtrim(ltrim(@DateJoinCOJ))) <> 0
         SET @dynamicSQL += ' And (DateJoinCOJ >= @DateJoinCOJ)'
 IF @ChurchID IS NOT NULL AND len(rtrim(ltrim(@ChurchID))) <> 0
         SET @dynamicSQL += ' And (ChurchID LIKE ''' + '%' + @ChurchID + '%' + ''')'


--PRINT @dynamicSQL

EXECUTE sp_executesql 
@dynamicSQL 
,@ParamDefinition
,@SponseeID 
,@FirstName 
,@LastName
,@DOB 
,@Grade 
,@DateJoinCOJ 
,@ChurchID 

END

GO
/****** Object:  StoredProcedure [dbo].[spSearchSponsor]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spSearchSponsor]

	@SponsorID nvarchar(15),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@City nvarchar(50),
	@State nchar(2),
	@PrimaryLanguage nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

Declare @ParamDefinition AS NVarchar(2000)  = 
   '@SponsorID nvarchar(15),
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@City nvarchar(50),
	@State nchar(2),
	@PrimaryLanguage nvarchar(50)'

DECLARE @dynamicSQL nvarchar(max)
SET @dynamicSQL = 
'SELECT
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
      ,[PrimaryLanguage] 
	FROM 
		SponsorInfo
	WHERE 1=1'

 IF @SponsorID IS NOT NULL AND len(rtrim(ltrim(@SponsorID))) <> 0
         SET @dynamicSQL += ' And (SponsorID LIKE ''' + '%' + @SponsorID + '%' + ''')'
 IF @FirstName IS NOT NULL AND len(rtrim(ltrim(@FirstName))) <> 0
         SET @dynamicSQL += ' And (FirstName LIKE ''' + '%' + @FirstName + '%' + ''')'
 IF @LastName IS NOT NULL AND len(rtrim(ltrim(@LastName))) <> 0
         SET @dynamicSQL += ' And (LastName LIKE ''' + '%' + @LastName + '%' + ''')'
 IF @City IS NOT NULL AND len(rtrim(ltrim(@City))) <> 0
         SET @dynamicSQL += ' And (City LIKE ''' + '%' + @City + '%' + ''')'
 IF @State IS NOT NULL AND len(rtrim(ltrim(@State))) <> 0
         SET @dynamicSQL += ' And (State LIKE ''' + '%' + @State + '%' + ''')'
 IF @PrimaryLanguage IS NOT NULL AND len(rtrim(ltrim(@PrimaryLanguage))) <> 0
         SET @dynamicSQL += ' And (PrimaryLanguage = @PrimaryLanguage)'

--PRINT @dynamicSQL

EXECUTE sp_executesql 
@dynamicSQL 
,@ParamDefinition
,@SponsorID
,@FirstName
,@LastName 
,@City
,@State
,@PrimaryLanguage 

END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateChurchInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdateChurchInfo] (
	@ChurchID nvarchar(15),
	@ChurchName nvarchar(50),
	@Area nvarchar(50),
	@District nvarchar(50),
	@City nvarchar(50),
	@UserModified nvarchar(50)
	)
AS
BEGIN

UPDATE ChurchInfo
SET
	ChurchName = @ChurchName
	,Area = @Area
	,District = @District
	,City = @City
	,UserModified = @UserModified
	,DateModified = getdate()
WHERE 
	ChurchID = @ChurchID
END




GO
/****** Object:  StoredProcedure [dbo].[spUpdateContribution]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdateContribution]
	@ContributionID INTEGER,
	@RelationshipID INT,
	@TransactionDate DATETIME,
	@TransactionAmount money,
	@UserModified nvarchar(50),
	@EditContribReason nvarchar(50)
AS
BEGIN
	UPDATE [dbo].[ContributionsInfo]
	SET TransactionAmount=@TransactionAmount,
		UserModified=@UserModified,
		TransactionDate=@TransactionDate,
		EditContribReason=@EditContribReason
	WHERE @ContributionID = [ContributionID]
	AND   @RelationshipID = [RelationshipID]

END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateHHKContribution]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdateHHKContribution]
	@HHKContributionID INTEGER,
	@SponsorID nvarchar(15),
	@TransactionDate DATETIME,
	@TransactionAmount money,
	@UserModified nvarchar(50),
	@EditContribReason nvarchar(50)
AS
BEGIN
	UPDATE [dbo].[HHKContributionsInfo]
	SET TransactionAmount=@TransactionAmount,
		UserModified=@UserModified,
		TransactionDate=@TransactionDate,
		EditContribReason=@EditContribReason
	WHERE @HHKContributionID = [HHKContributionID]
	AND   @SponsorID = [SponsorID]

END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateLetter]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdateLetter]
	@RelationshipID int,
	@Letter int,
	@UserModified nvarchar(50)
AS
BEGIN
	UPDATE [dbo].[RelationshipInfo]
	SET LETTER = @Letter,
	UserModified = @UserModified,
	DateModified = getdate()
	WHERE RelationshipID = @RelationshipID
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdatePrimaryLanguage]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdatePrimaryLanguage]
	@PrimaryLanguage nvarchar(50),
	@LanguageReceiptText nvarchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	UPDATE [Reference].[PrimaryLanguage]
	SET [LanguageReceiptText] = @LanguageReceiptText
    WHERE [PrimaryLanguage] = @PrimaryLanguage
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateSponseeInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdateSponseeInfo] 
	@SponseeID nvarchar(15),
	@FirstName nvarchar(50),
	@LastName nvarchar(50) ,
	@DOB date ,
	@Gender nchar(1) ,
	@Grade nchar(2) ,
	@ShoeSize int ,
	@ShirtSize int ,
	@PantsSize int ,
	@DateJoinCOJ date ,
	@ChurchID nvarchar(15),
	@Photo nvarchar(100),
	@AppPath nvarchar(255),
	@UserModified nvarchar(50)
AS
BEGIN

UPDATE SponseeInfo
SET 
[FirstName] = @FirstName,
[LastName] = @LastName,
[DOB] = @DOB,
[Gender] = @Gender,
[Grade] = @Grade,
[ShoeSize] = @ShoeSize,
[ShirtSize] = @ShirtSize,
[PantsSize] = @PantsSize,
[DateJoinCOJ] = @DateJoinCOJ,
[ChurchID] = @ChurchID,
[Photo] = @Photo,
[AppPath] = @AppPath,
[UserModified] = @UserModified,
[DateModified] = getdate()
WHERE
[SponseeID] = @SponseeID
END



GO
/****** Object:  StoredProcedure [dbo].[spUpdateSponsorInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spUpdateSponsorInfo] (
	@SponsorID nvarchar(15) ,
	@FirstName nvarchar(50) ,
	@LastName nvarchar(50) ,
	@AlternateName nvarchar(50) ,
	@Email nvarchar(50) ,
	@Address nvarchar(50) ,
	@City nvarchar(50) ,
	@State nvarchar(50) ,
	@PhoneNum nvarchar(50),
	@UserModified nvarchar(50),
	@PrimaryLanguage nvarchar(50)
	)
AS
BEGIN

UPDATE SponsorInfo
SET 
      [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[AlternateName] = @AlternateName
      ,[Email] = @Email
      ,[Address] = @Address
      ,[City] = @City
      ,[State] = @State
      ,[PhoneNum] = @PhoneNum
      ,[DateModified] = getdate()
      ,[UserModified] = @UserModified
      ,[PrimaryLanguage] = @PrimaryLanguage
WHERE
	   [SponsorID] = @SponsorID
END



GO
/****** Object:  StoredProcedure [report].[spGetSponseeInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spGetSponseeInfo]
	-- Add the parameters for the stored procedure here
	@SponseeID nvarchar(15)
AS
BEGIN
	SELECT 
		SEI.[SponseeID]
		,SEI.[FirstName]
		,SEI.[LastName]
		,SRI.[SponsorID]
		,SRI.[FirstName]
		,SRI.[LastName]
		,[Photo]
		,[DOB]
		,[Gender]
		,[Grade]
		,[ShoeSize]
		,[ShirtSize]
		,[PantsSize]
		,[DateJoinCOJ]
		,[ChurchID]
	FROM 
		[dbo].[SponseeInfo] SEI
		LEFT JOIN [dbo].[RelationshipInfo] RI
		ON SEI.[SponseeID] = RI.[SponseeID]
		LEFT JOIN [dbo].[SponsorInfo] SRI
		ON SRI.[SponsorID] = RI.[SponsorID]

	WHERE SEI.[SponseeID] = @SponseeID

END

GO
/****** Object:  StoredProcedure [report].[spMonthBirthday]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spMonthBirthday]
@month as int
AS
BEGIN

SELECT 
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
FROM [SponseeInfo]
	WHERE month([DOB]) = @month

END



GO
/****** Object:  StoredProcedure [report].[spMonthlyReceiptSponseeList]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [report].[spMonthlyReceiptSponseeList]
	@SponsorID nvarchar(15)
AS
BEGIN

SET NOCOUNT ON

SELECT 
	RI.RelationshipID,
	RI.SponseeID,
	SEI.FirstName,
	SEI.LastName
FROM relationshipinfo ri
	JOIN SponseeInfo SEI
		ON SEI.SponseeID = ri.SponseeID
WHERE RI.SponsorID = @SponsorID

END


GO
/****** Object:  StoredProcedure [report].[spMonthlyReceiptSponsorContributions]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spMonthlyReceiptSponsorContributions]
	@SponsorID nvarchar(15),
	@year int
AS
BEGIN

SET NOCOUNT ON


SELECT 
P.MonthName,
ISNULL([Sum COJ Amount],0.00) AS [Sum COJ Amount],
ISNULL([Sum HHK Amount],0.00) AS [Sum HHK Amount]
FROM
	(
	SELECT 
		M.MonthName,
		M.MonthInt,
		SUM(CI.TransactionAmount) AS [Sum COJ Amount]
	FROM 
		[dbo].[ContributionsInfo] CI
		INNER JOIN [dbo].[RelationshipInfo] RI
			ON RI.RelationshipID = CI.RelationshipID AND RI.SponsorID = @SponsorID
		RIGHT OUTER JOIN [Reference].[Month] M
			ON  M.[MonthInt] = month(CI.TransactionDate)
	and year(CI.TransactionDate) = @year
	GROUP BY 
		M.MonthName
		,M.[MonthInt]
	) P 
INNER JOIN (
SELECT 
	M.MonthName,
	SUM(HCI.TransactionAmount) AS [Sum HHK Amount]
FROM 
	[Reference].[Month] M
	LEFT OUTER JOIN [dbo].[HHKContributionsInfo] HCI
		ON M.[MonthInt] = month(HCI.TransactionDate) AND HCI.SponsorID = @SponsorID
and year(HCI.TransactionDate) = @year
GROUP BY 
	M.MonthName
) O
ON O.MonthName = P.MonthName
Order By 
	P.MonthInt


END




GO
/****** Object:  StoredProcedure [report].[spMonthlyReceiptSponsorInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spMonthlyReceiptSponsorInfo] 
	@SponsorID nvarchar(15)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
	   SRI.FirstName
      ,SRI.LastName
      ,SRI.AlternateName
      ,SRI.Email
      ,SRI.Address
      ,SRI.City
      ,SRI.State
	  ,SRI.SponsorID
	FROM
		SponsorInfo SRI
	WHERE
		SRI.SponsorID = @SponsorID


END

GO
/****** Object:  StoredProcedure [report].[spMonthlyReceiptSponsorLetter]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spMonthlyReceiptSponsorLetter] 
	@SponsorID nvarchar(15)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT 
		PL.PrimaryLanguage,
		PL.LanguageReceiptText
	FROM
			SponsorInfo SRI
		INNER JOIN
			Reference.PrimaryLanguage PL
		ON SRI.PrimaryLanguage = PL.PrimaryLanguage
	WHERE
		SRI.SponsorID = @SponsorID


END


GO
/****** Object:  StoredProcedure [report].[spMonthlyReceiptYearlyContributionTotal]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spMonthlyReceiptYearlyContributionTotal]
	-- Add the parameters for the stored procedure here
	@SponsorID nvarchar(15),
	@year int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT SUM(AMOUNT)
FROM
		(
	SELECT 
			SUM(CI.TransactionAmount) AS [Amount]
	FROM 
			[dbo].[ContributionsInfo] CI
			INNER JOIN [dbo].[RelationshipInfo] RI
				ON RI.RelationshipID = CI.RelationshipID 
	WHERE RI.SponsorID = @SponsorID
		and year(CI.TransactionDate) = @year
	UNION ALL
	SELECT 
		SUM(HCI.TransactionAmount) AS [Amount]
	FROM 
		[dbo].[HHKContributionsInfo] HCI
	WHERE HCI.SponsorID = @SponsorID
	and year(HCI.TransactionDate) = @year) p 


END

GO
/****** Object:  StoredProcedure [report].[spWarehouseChurch]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spWarehouseChurch]

AS
BEGIN

SELECT [ChurchID]
      ,[ChurchName]
      ,[Area]
      ,[District]
      ,[City]
      ,[DateModified]
      ,[UserModified]
      ,[Action]
  FROM [HHKAT].[warehouse].[ChurchInfo]
  Order By 
  [DateModified]

END


GO
/****** Object:  StoredProcedure [report].[spWarehouseContributions]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spWarehouseContributions]

AS
BEGIN

SELECT [ContributionID]
      ,[RelationshipID]
      ,[TransactionDate]
      ,[UserModified]
      ,[TransactionAmount]
      ,[Action]
	  ,[EditContribReason]
  FROM [HHKAT].[warehouse].[ContributionsInfo]
  Order By 
  [TransactionDate]

END


GO
/****** Object:  StoredProcedure [report].[spWarehouseHHKContributions]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spWarehouseHHKContributions]

AS
BEGIN

SELECT [HHKContributionID]
      ,[SponsorID]
      ,[TransactionDate]
      ,[UserModified]
      ,[TransactionAmount]
      ,[Action]
	  ,[EditContribReason]
  FROM [HHKAT].[warehouse].[HHKContributionsInfo]
  Order By 
  [TransactionDate]

END



GO
/****** Object:  StoredProcedure [report].[spWarehouseRelationship]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spWarehouseRelationship]

AS
BEGIN

SELECT [RelationshipID]
      ,[SponsorID]
      ,[SponseeID]
      ,[StartDate]
      ,[EndDate]
      ,[DateModified]
      ,[UserModified]
      ,[Action]
      ,[Letter]
  FROM [HHKAT].[warehouse].[RelationshipInfo]
  Order By 
  [DateModified]

END


GO
/****** Object:  StoredProcedure [report].[spWarehouseSponsee]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spWarehouseSponsee]

AS
BEGIN

SELECT [SponseeID]
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
	  ,[AppPath]
      ,[UserModified]
      ,[DateModified]
      ,[Action]
  FROM [HHKAT].[warehouse].[SponseeInfo]
  Order By 
  [DateModified]

END


GO
/****** Object:  StoredProcedure [report].[spWarehouseSponsor]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [report].[spWarehouseSponsor]

AS
BEGIN

SELECT [SponsorID]
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
      ,[Action]
      ,[PrimaryLanguage]
  FROM [HHKAT].[warehouse].[SponsorInfo]
  Order By 
  [DateModified]

END


GO
/****** Object:  Table [dbo].[ChurchInfo]    Script Date: 5/5/2015 6:49:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChurchInfo](
	[ChurchID] [nvarchar](15) NOT NULL,
	[ChurchName] [nvarchar](50) NOT NULL,
	[Area] [nvarchar](50) NOT NULL,
	[District] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NULL,
	[UserModified] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NOT NULL,
 CONSTRAINT [PK_ChurchInfo] PRIMARY KEY CLUSTERED 
(
	[ChurchID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ContributionsInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContributionsInfo](
	[ContributionID] [int] IDENTITY(7,1) NOT NULL,
	[RelationshipID] [int] NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[UserModified] [nvarchar](50) NOT NULL,
	[TransactionAmount] [money] NOT NULL,
	[EditContribReason] [nvarchar](50) NULL,
 CONSTRAINT [PK_ContributionsInfo] PRIMARY KEY CLUSTERED 
(
	[ContributionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HHKContributionsInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HHKContributionsInfo](
	[HHKContributionID] [int] IDENTITY(7,7) NOT NULL,
	[SponsorID] [nvarchar](15) NULL,
	[TransactionDate] [datetime] NULL,
	[UserModified] [nvarchar](50) NULL,
	[TransactionAmount] [money] NULL,
	[EditContribReason] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[HHKContributionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RelationshipInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelationshipInfo](
	[RelationshipID] [int] IDENTITY(1,1) NOT NULL,
	[SponsorID] [nvarchar](15) NOT NULL,
	[SponseeID] [nvarchar](15) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[UserModified] [nvarchar](50) NULL,
	[DateModified] [datetime] NULL,
	[LETTER] [int] NULL,
 CONSTRAINT [PK_RelationshipInfo] PRIMARY KEY CLUSTERED 
(
	[RelationshipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SponseeInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SponseeInfo](
	[SponseeID] [nvarchar](15) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Gender] [nchar](1) NULL,
	[Grade] [nchar](2) NULL,
	[ShoeSize] [int] NULL,
	[ShirtSize] [int] NULL,
	[PantsSize] [int] NULL,
	[DateJoinCOJ] [datetime] NOT NULL,
	[ChurchID] [nvarchar](15) NOT NULL,
	[Photo] [nvarchar](100) NULL,
	[UserModified] [nvarchar](50) NULL,
	[DateModified] [datetime] NULL,
	[AppPath] [nvarchar](255) NULL,
 CONSTRAINT [PK_SponseeInfo] PRIMARY KEY CLUSTERED 
(
	[SponseeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SponsorInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SponsorInfo](
	[SponsorID] [nvarchar](15) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AlternateName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[State] [nchar](2) NOT NULL,
	[PhoneNum] [nchar](10) NULL,
	[DateModified] [datetime] NOT NULL,
	[UserModified] [nvarchar](50) NOT NULL,
	[PrimaryLanguage] [nvarchar](50) NULL,
 CONSTRAINT [PK_SponsorInfo] PRIMARY KEY CLUSTERED 
(
	[SponsorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[ActivityReportTypes]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[ActivityReportTypes](
	[ActivityReportTypesID] [int] IDENTITY(1,1) NOT NULL,
	[ActivityReportTypesName] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ActivityReportTypesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[EditContribReason]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[EditContribReason](
	[EditContribReasonID] [int] IDENTITY(1,1) NOT NULL,
	[EditContribReason] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[Gender]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[Gender](
	[Gender] [nchar](1) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[Grade]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[Grade](
	[Grade] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[Month]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[Month](
	[MonthInt] [int] NULL,
	[MonthName] [nvarchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[PantsSize]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[PantsSize](
	[PantsSize] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[PrimaryLanguage]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[PrimaryLanguage](
	[PrimaryLanguage] [nvarchar](50) NOT NULL,
	[LanguageReceiptText] [nvarchar](max) NULL,
 CONSTRAINT [PK_PrimaryLanguage] PRIMARY KEY CLUSTERED 
(
	[PrimaryLanguage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [Reference].[ShirtSize]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[ShirtSize](
	[ShirtSize] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[ShoeSize]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[ShoeSize](
	[ShoeSize] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [Reference].[StateRef]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Reference].[StateRef](
	[StateRef] [nchar](2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [warehouse].[ChurchInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [warehouse].[ChurchInfo](
	[ChurchID] [nvarchar](15) NOT NULL,
	[ChurchName] [nvarchar](50) NOT NULL,
	[Area] [nvarchar](50) NOT NULL,
	[District] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[UserModified] [nvarchar](50) NULL,
	[Action] [nvarchar](30) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [warehouse].[ContributionsInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [warehouse].[ContributionsInfo](
	[ContributionID] [int] NOT NULL,
	[RelationshipID] [int] NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[UserModified] [nvarchar](50) NOT NULL,
	[TransactionAmount] [money] NOT NULL,
	[Action] [nvarchar](30) NOT NULL,
	[EditContribReason] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [warehouse].[HHKContributionsInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [warehouse].[HHKContributionsInfo](
	[HHKContributionID] [int] NOT NULL,
	[SponsorID] [nvarchar](15) NULL,
	[TransactionDate] [datetime] NULL,
	[UserModified] [nvarchar](50) NULL,
	[TransactionAmount] [money] NULL,
	[Action] [nvarchar](30) NULL,
	[EditContribReason] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [warehouse].[RelationshipInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [warehouse].[RelationshipInfo](
	[RelationshipID] [int] NOT NULL,
	[SponsorID] [nvarchar](15) NOT NULL,
	[SponseeID] [nvarchar](15) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[DateModified] [datetime] NULL,
	[UserModified] [nvarchar](50) NULL,
	[Action] [nvarchar](30) NOT NULL,
	[Letter] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [warehouse].[SponseeInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [warehouse].[SponseeInfo](
	[SponseeID] [nvarchar](15) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Gender] [nchar](1) NOT NULL,
	[Grade] [nchar](2) NULL,
	[ShoeSize] [int] NULL,
	[ShirtSize] [int] NULL,
	[PantsSize] [int] NULL,
	[DateJoinCOJ] [datetime] NOT NULL,
	[ChurchID] [nvarchar](15) NOT NULL,
	[Photo] [nvarchar](100) NULL,
	[UserModified] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[Action] [nvarchar](30) NOT NULL,
	[AppPath] [nvarchar](255) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [warehouse].[SponsorInfo]    Script Date: 5/5/2015 6:49:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [warehouse].[SponsorInfo](
	[SponsorID] [nvarchar](15) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[AlternateName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[State] [nchar](2) NOT NULL,
	[PhoneNum] [nvarchar](50) NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[UserModified] [nvarchar](50) NOT NULL,
	[Action] [nvarchar](30) NOT NULL,
	[PrimaryLanguage] [nvarchar](50) NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ChurchInfo] ADD  CONSTRAINT [DF_ChurchInfo_DateModified]  DEFAULT (getdate()) FOR [DateModified]
GO
ALTER TABLE [dbo].[ContributionsInfo] ADD  CONSTRAINT [DF_ContributionsInfo_TransactionDate]  DEFAULT (getdate()) FOR [TransactionDate]
GO
ALTER TABLE [dbo].[RelationshipInfo] ADD  CONSTRAINT [DF_RelationshipInfo_StartDate]  DEFAULT (getdate()) FOR [StartDate]
GO
ALTER TABLE [dbo].[RelationshipInfo] ADD  CONSTRAINT [letterDefault]  DEFAULT ((0)) FOR [LETTER]
GO
ALTER TABLE [dbo].[SponseeInfo] ADD  CONSTRAINT [DF_SponseeInfo_DateJoinCOJ]  DEFAULT (getdate()) FOR [DateJoinCOJ]
GO
ALTER TABLE [dbo].[SponseeInfo] ADD  CONSTRAINT [DF_SponseeInfo_UserModified]  DEFAULT (N'NN') FOR [UserModified]
GO
ALTER TABLE [dbo].[SponseeInfo] ADD  CONSTRAINT [DF_SponseeInfo_DateModified]  DEFAULT (getdate()) FOR [DateModified]
GO
ALTER TABLE [dbo].[SponsorInfo] ADD  CONSTRAINT [DF_SponsorInfo_DateModified]  DEFAULT (getdate()) FOR [DateModified]
GO
ALTER TABLE [dbo].[SponsorInfo] ADD  CONSTRAINT [DF_SponsorInfo_UserModified]  DEFAULT (N'NN') FOR [UserModified]
GO
ALTER TABLE [dbo].[ContributionsInfo]  WITH CHECK ADD  CONSTRAINT [FK_ContributionsInfo_RelationshipInfo] FOREIGN KEY([RelationshipID])
REFERENCES [dbo].[RelationshipInfo] ([RelationshipID])
GO
ALTER TABLE [dbo].[ContributionsInfo] CHECK CONSTRAINT [FK_ContributionsInfo_RelationshipInfo]
GO
ALTER TABLE [dbo].[HHKContributionsInfo]  WITH CHECK ADD  CONSTRAINT [Ffk_HHKContributionsInfoSponsorInfo] FOREIGN KEY([SponsorID])
REFERENCES [dbo].[SponsorInfo] ([SponsorID])
GO
ALTER TABLE [dbo].[HHKContributionsInfo] CHECK CONSTRAINT [Ffk_HHKContributionsInfoSponsorInfo]
GO
ALTER TABLE [dbo].[RelationshipInfo]  WITH CHECK ADD  CONSTRAINT [FK_RelationshipInfo_SponseeInfo] FOREIGN KEY([SponseeID])
REFERENCES [dbo].[SponseeInfo] ([SponseeID])
GO
ALTER TABLE [dbo].[RelationshipInfo] CHECK CONSTRAINT [FK_RelationshipInfo_SponseeInfo]
GO
ALTER TABLE [dbo].[RelationshipInfo]  WITH CHECK ADD  CONSTRAINT [FK_RelationshipInfo_SponsorInfo] FOREIGN KEY([SponsorID])
REFERENCES [dbo].[SponsorInfo] ([SponsorID])
GO
ALTER TABLE [dbo].[RelationshipInfo] CHECK CONSTRAINT [FK_RelationshipInfo_SponsorInfo]
GO
ALTER TABLE [dbo].[SponseeInfo]  WITH CHECK ADD  CONSTRAINT [FK_ChurchInfo_SponseeInfo] FOREIGN KEY([ChurchID])
REFERENCES [dbo].[ChurchInfo] ([ChurchID])
GO
ALTER TABLE [dbo].[SponseeInfo] CHECK CONSTRAINT [FK_ChurchInfo_SponseeInfo]
GO
ALTER TABLE [dbo].[SponsorInfo]  WITH CHECK ADD  CONSTRAINT [FK__SponsorInfo_PrimaryLanguage] FOREIGN KEY([PrimaryLanguage])
REFERENCES [Reference].[PrimaryLanguage] ([PrimaryLanguage])
GO
ALTER TABLE [dbo].[SponsorInfo] CHECK CONSTRAINT [FK__SponsorInfo_PrimaryLanguage]
GO
ALTER TABLE [dbo].[ChurchInfo]  WITH CHECK ADD  CONSTRAINT [CK_ChurchInfo_ChurchName_Alpha] CHECK  ((NOT [ChurchName] like '%[^A-Z ]%'))
GO
ALTER TABLE [dbo].[ChurchInfo] CHECK CONSTRAINT [CK_ChurchInfo_ChurchName_Alpha]
GO
ALTER TABLE [dbo].[ChurchInfo]  WITH CHECK ADD  CONSTRAINT [CK_ChurchInfo_City_Alpha] CHECK  ((NOT [CITY] like '%[^A-Z ]%'))
GO
ALTER TABLE [dbo].[ChurchInfo] CHECK CONSTRAINT [CK_ChurchInfo_City_Alpha]
GO
ALTER TABLE [dbo].[ContributionsInfo]  WITH CHECK ADD  CONSTRAINT [CK__Contribut__Trans] CHECK  (([TransactionAmount]>(0)))
GO
ALTER TABLE [dbo].[ContributionsInfo] CHECK CONSTRAINT [CK__Contribut__Trans]
GO
ALTER TABLE [dbo].[HHKContributionsInfo]  WITH CHECK ADD  CONSTRAINT [CK_HHKContributionsInfo_PositiveMoney] CHECK  (([TransactionAmount]>(0)))
GO
ALTER TABLE [dbo].[HHKContributionsInfo] CHECK CONSTRAINT [CK_HHKContributionsInfo_PositiveMoney]
GO
ALTER TABLE [dbo].[RelationshipInfo]  WITH CHECK ADD  CONSTRAINT [letterIsPositive] CHECK  (([LETTER]>=(0)))
GO
ALTER TABLE [dbo].[RelationshipInfo] CHECK CONSTRAINT [letterIsPositive]
GO
ALTER TABLE [dbo].[SponseeInfo]  WITH CHECK ADD  CONSTRAINT [CK_SponseeInfo_DOB] CHECK  (([DOB]<getdate()))
GO
ALTER TABLE [dbo].[SponseeInfo] CHECK CONSTRAINT [CK_SponseeInfo_DOB]
GO
ALTER TABLE [dbo].[SponseeInfo]  WITH CHECK ADD  CONSTRAINT [CK_SponseeInfo_FN_Alpha] CHECK  ((NOT [FirstName] like '%[^A-Z ]%'))
GO
ALTER TABLE [dbo].[SponseeInfo] CHECK CONSTRAINT [CK_SponseeInfo_FN_Alpha]
GO
ALTER TABLE [dbo].[SponseeInfo]  WITH CHECK ADD  CONSTRAINT [CK_SponseeInfo_LN_Alpha] CHECK  ((NOT [LastName] like '%[^A-Z ]%'))
GO
ALTER TABLE [dbo].[SponseeInfo] CHECK CONSTRAINT [CK_SponseeInfo_LN_Alpha]
GO
ALTER TABLE [dbo].[SponsorInfo]  WITH CHECK ADD  CONSTRAINT [CK_SponsorInfo_City_Alpha] CHECK  ((NOT [City] like '%[^A-Z ]%'))
GO
ALTER TABLE [dbo].[SponsorInfo] CHECK CONSTRAINT [CK_SponsorInfo_City_Alpha]
GO
ALTER TABLE [dbo].[SponsorInfo]  WITH CHECK ADD  CONSTRAINT [CK_SponsorInfo_FN_Alpha] CHECK  ((NOT [FirstName] like '%[^A-Z ]%'))
GO
ALTER TABLE [dbo].[SponsorInfo] CHECK CONSTRAINT [CK_SponsorInfo_FN_Alpha]
GO
ALTER TABLE [dbo].[SponsorInfo]  WITH CHECK ADD  CONSTRAINT [CK_SponsorInfo_LN_Alpha] CHECK  ((NOT [LastName] like '%[^A-Z ]%'))
GO
ALTER TABLE [dbo].[SponsorInfo] CHECK CONSTRAINT [CK_SponsorInfo_LN_Alpha]
GO
ALTER TABLE [dbo].[SponsorInfo]  WITH CHECK ADD  CONSTRAINT [CK_SponsorInfo_PhonNum_Num] CHECK  ((NOT [PhoneNum] like '%[^0-9]%'))
GO
ALTER TABLE [dbo].[SponsorInfo] CHECK CONSTRAINT [CK_SponsorInfo_PhonNum_Num]
GO
ALTER TABLE [dbo].[SponsorInfo]  WITH CHECK ADD  CONSTRAINT [CK_SponsorInfo_State_Alpha] CHECK  ((NOT [State] like '%[^A-Z ]%'))
GO
ALTER TABLE [dbo].[SponsorInfo] CHECK CONSTRAINT [CK_SponsorInfo_State_Alpha]
GO
