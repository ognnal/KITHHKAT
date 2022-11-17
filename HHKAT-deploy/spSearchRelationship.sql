USE [HHKAT]
GO

/****** Object:  StoredProcedure [dbo].[spSearchRelationship]    Script Date: 6/5/2015 5:54:31 PM ******/
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


