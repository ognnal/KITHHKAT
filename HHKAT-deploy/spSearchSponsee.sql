USE [HHKAT]
GO

/****** Object:  StoredProcedure [dbo].[spSearchSponsee]    Script Date: 6/5/2015 5:54:36 PM ******/
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


