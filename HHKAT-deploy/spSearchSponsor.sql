USE [HHKAT]
GO

/****** Object:  StoredProcedure [dbo].[spSearchSponsor]    Script Date: 6/5/2015 5:54:41 PM ******/
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


