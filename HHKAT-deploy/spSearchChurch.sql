USE [HHKAT]
GO

/****** Object:  StoredProcedure [dbo].[spSearchChurch]    Script Date: 6/5/2015 5:54:23 PM ******/
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


