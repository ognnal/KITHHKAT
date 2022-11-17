USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[ChurchInfo_OnD]    Script Date: 6/6/2015 11:37:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[ChurchInfo_OnD]
   ON  [dbo].[ChurchInfo]
   FOR DELETE
AS 
BEGIN

 INSERT warehouse.ChurchInfo(
	   [ChurchID]
      ,[ChurchName]
      ,[Area]
      ,[District]
      ,[City]
      ,[DateModified]
      ,[UserModified]
      ,[Action]
	  )
SELECT ChurchID
	  ,ChurchName
	  ,Area
	  ,District
	  ,City
	  ,DateModified
	  ,UserModified
	  ,'DELETE'
	  FROM deleted
END

GO


USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[ChurchInfo_OnI]    Script Date: 6/6/2015 11:38:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[ChurchInfo_OnI]
   ON  [dbo].[ChurchInfo]
   FOR INSERT
AS 
BEGIN

 INSERT warehouse.ChurchInfo(
	   [ChurchID]
      ,[ChurchName]
      ,[Area]
      ,[District]
      ,[City]
      ,[DateModified]
      ,[UserModified]
      ,[Action]
	  )
SELECT ChurchID
	  ,ChurchName
	  ,Area
	  ,District
	  ,City
	  ,DateModified
	  ,UserModified
	  ,'INSERT'
	  FROM inserted
END

GO


USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[ChurchInfo_OnU]    Script Date: 6/6/2015 11:38:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[ChurchInfo_OnU]
   ON  [dbo].[ChurchInfo]
   FOR UPDATE
AS 
BEGIN

 INSERT warehouse.ChurchInfo(
	   [ChurchID]
      ,[ChurchName]
      ,[Area]
      ,[District]
      ,[City]
      ,[DateModified]
      ,[UserModified]
      ,[Action]
	  )
SELECT ChurchID
	  ,ChurchName
	  ,Area
	  ,District
	  ,City
	  ,DateModified
	  ,UserModified
	  ,'UPDATE'
	  FROM inserted
END

GO

USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[ContributionsInfo_OnD]    Script Date: 6/6/2015 11:38:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[ContributionsInfo_OnD]
   ON  [dbo].[ContributionsInfo]
   FOR DELETE
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.ContributionsInfo(
	   ContributionID
      ,RelationshipID
      ,TransactionDate
      ,UserModified
      ,TransactionAmount
	  ,EditContribReason
	  ,Action
)
SELECT
	   ContributionID	  
	  ,RelationshipID	  
	  ,TransactionDate	
	  ,UserModified	  
	  ,TransactionAmount
	  ,EditContribReason
	  ,'DELETE'
FROM deleted
END

GO

USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[ContributionsInfo_OnI]    Script Date: 6/6/2015 11:38:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[ContributionsInfo_OnI]
   ON  [dbo].[ContributionsInfo]
   FOR INSERT
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.ContributionsInfo(
	   ContributionID
      ,RelationshipID
      ,TransactionDate
      ,UserModified
      ,TransactionAmount
	  ,EditContribReason
	  ,Action
)
SELECT
	   ContributionID	  
	  ,RelationshipID	  
	  ,TransactionDate	
	  ,UserModified	  
	  ,TransactionAmount
	  ,EditContribReason
	  ,'INSERT'
FROM inserted
END

GO

USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[ContributionsInfo_OnU]    Script Date: 6/6/2015 11:38:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[ContributionsInfo_OnU]
   ON  [dbo].[ContributionsInfo]
   FOR UPDATE
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.ContributionsInfo(
	   ContributionID
      ,RelationshipID
      ,TransactionDate
      ,UserModified
      ,TransactionAmount
	  ,EditContribReason
	  ,Action
)
SELECT
	   ContributionID	  
	  ,RelationshipID	  
	  ,TransactionDate	
	  ,UserModified	  
	  ,TransactionAmount
	  ,EditContribReason
	  ,'UPDATE'
FROM inserted
END

GO


USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[HHKContributionsInfo_OnD]    Script Date: 6/6/2015 11:39:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[HHKContributionsInfo_OnD]
   ON  [dbo].[HHKContributionsInfo]
   FOR DELETE
AS 
BEGIN

 INSERT warehouse.HHKContributionsInfo(
	HHKContributionID,
	SponsorID,
	TransactionDate,
	UserModified,
	TransactionAmount,
	EditContribReason,
	Action 
	  )
SELECT 
	  HHKContributionID
	  ,SponsorID
	  ,TransactionDate
	  ,UserModified
	  ,TransactionAmount
	  ,EditContribReason
	  ,'DELETE'
	  FROM deleted
END

GO


USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[HHKContributionsInfo_OnI]    Script Date: 6/6/2015 11:39:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[HHKContributionsInfo_OnI]
   ON  [dbo].[HHKContributionsInfo]
   FOR INSERT
AS 
BEGIN

 INSERT warehouse.HHKContributionsInfo(
	HHKContributionID,
	SponsorID,
	TransactionDate,
	UserModified,
	TransactionAmount,
	EditContribReason,
	Action 
	  )
SELECT 
	  HHKContributionID
	  ,SponsorID
	  ,TransactionDate
	  ,UserModified
	  ,TransactionAmount
	  ,EditContribReason
	  ,'INSERT'
	  FROM inserted
END

GO



USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[HHKContributionsInfo_OnU]    Script Date: 6/6/2015 11:39:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[HHKContributionsInfo_OnU]
   ON  [dbo].[HHKContributionsInfo]
   FOR UPDATE
AS 
BEGIN

 INSERT warehouse.HHKContributionsInfo(
	HHKContributionID,
	SponsorID,
	TransactionDate,
	UserModified,
	TransactionAmount,
	EditContribReason,
	Action 
	  )
SELECT 
	  HHKContributionID
	  ,SponsorID
	  ,TransactionDate
	  ,UserModified
	  ,TransactionAmount
	  ,EditContribReason
	  ,'UPDATE'
	  FROM inserted
END

GO





USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[RelationshipInfo_OnD]    Script Date: 6/6/2015 11:39:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[RelationshipInfo_OnD]
   ON  [dbo].[RelationshipInfo]
   FOR DELETE
AS 
BEGIN


 INSERT warehouse.RelationshipInfo(
	RelationshipID	
	,SponsorID	   
	,SponseeID		
	,StartDate	  
	,EndDate			
	,UserModified
	,DateModified
	,Letter
	,Action
)
SELECT
	 RelationshipID	
	,SponsorID	   
	,SponseeID		
	,StartDate	   
	,EndDate			
	,UserModified
	,DateModified
	,Letter
	,'DELETE'
FROM
	deleted	
END

GO

USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[RelationshipInfo_OnI]    Script Date: 6/6/2015 11:39:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[RelationshipInfo_OnI]
   ON  [dbo].[RelationshipInfo]
   FOR INSERT
AS 
BEGIN
 INSERT warehouse.RelationshipInfo(
	RelationshipID	
	,SponsorID	   
	,SponseeID		
	,StartDate	  
	,EndDate		
	,DateModified	
	,UserModified
	,Letter
	,Action
)
SELECT
	 RelationshipID	
	,SponsorID	   
	,SponseeID		
	,StartDate	   
	,EndDate			
	,DateModified	
	,UserModified
	,Letter	
	,'INSERT'
FROM
	inserted
END

GO



USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[RelationshipInfo_OnU]    Script Date: 6/6/2015 11:39:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[RelationshipInfo_OnU]
   ON  [dbo].[RelationshipInfo]
   AFTER UPDATE
AS 
BEGIN


 INSERT warehouse.RelationshipInfo(
	RelationshipID	
	,SponsorID	   
	,SponseeID		
	,StartDate	  
	,EndDate			
	,DateModified	
	,UserModified
	,Letter
	,Action
)
SELECT
	 RelationshipID	
	,SponsorID	   
	,SponseeID		
	,StartDate	   
	,EndDate			
	,DateModified	
	,UserModified		
	,Letter
	,'UPDATE'
FROM
	inserted
END

GO



USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[SponseeInfo_OnD]    Script Date: 6/6/2015 11:40:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[SponseeInfo_OnD]
   ON  [dbo].[SponseeInfo]
   FOR DELETE
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.SponseeInfo(
	 SponseeID
	,FirstName
	,LastName
	,DOB
	,Gender
	,Grade
	,ShoeSize
	,ShirtSize
	,PantsSize
	,DateJoinCOJ
	,ChurchID
	,Photo
	,AppPath
	,UserModified
	,DateModified
	,Action
)
SELECT
	 SponseeID
	,FirstName
	,LastName
	,DOB
	,Gender
	,Grade
	,ShoeSize
	,ShirtSize
	,PantsSize
	,DateJoinCOJ
	,ChurchID
	,Photo
	,AppPath
	,UserModified
	,DateModified
	,'DELETE'
	FROM deleted
END

GO








USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[SponseeInfo_OnI]    Script Date: 6/6/2015 11:40:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[SponseeInfo_OnI]
   ON  [dbo].[SponseeInfo]
   FOR INSERT
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.SponseeInfo(
	 SponseeID
	,FirstName
	,LastName
	,DOB
	,Gender
	,Grade
	,ShoeSize
	,ShirtSize
	,PantsSize
	,DateJoinCOJ
	,ChurchID
	,Photo
	,AppPath
	,UserModified
	,DateModified
	,Action
)
SELECT
	 SponseeID
	,FirstName
	,LastName
	,DOB
	,Gender
	,Grade
	,ShoeSize
	,ShirtSize
	,PantsSize
	,DateJoinCOJ
	,ChurchID
	,Photo
	,AppPath
	,UserModified
	,DateModified
	,'INSERT'
	FROM inserted
END

GO





USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[SponseeInfo_OnU]    Script Date: 6/6/2015 11:40:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[SponseeInfo_OnU]
   ON  [dbo].[SponseeInfo]
   FOR UPDATE
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.SponseeInfo(
	 SponseeID
	,FirstName
	,LastName
	,DOB
	,Gender
	,Grade
	,ShoeSize
	,ShirtSize
	,PantsSize
	,DateJoinCOJ
	,ChurchID
	,Photo
	,AppPath
	,UserModified
	,DateModified
	,Action
)
SELECT
	 SponseeID
	,FirstName
	,LastName
	,DOB
	,Gender
	,Grade
	,ShoeSize
	,ShirtSize
	,PantsSize
	,DateJoinCOJ
	,ChurchID
	,Photo
	,AppPath
	,UserModified
	,DateModified
	,'UPDATE'
	FROM inserted
END

GO





USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[SponsorInfo_OnD]    Script Date: 6/6/2015 11:40:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[SponsorInfo_OnD]
   ON  [dbo].[SponsorInfo]
   FOR DELETE
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.SponsorInfo(
	   SponsorID
      ,FirstName
      ,LastName
      ,AlternateName
      ,Email
      ,Address
      ,City
      ,State
      ,PhoneNum
      ,DateModified
      ,UserModified
	  ,PrimaryLanguage
	  ,Action
)
SELECT
	   SponsorID
      ,FirstName
      ,LastName
      ,AlternateName
      ,Email
      ,Address
      ,City
      ,State
      ,PhoneNum
      ,DateModified
      ,UserModified
	  ,PrimaryLanguage
	  ,'DELETE'
FROM deleted
END

GO





USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[SponsorInfo_OnI]    Script Date: 6/6/2015 11:40:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[SponsorInfo_OnI]
   ON  [dbo].[SponsorInfo]
   FOR INSERT
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.SponsorInfo(
	   SponsorID
      ,FirstName
      ,LastName
      ,AlternateName
      ,Email
      ,Address
      ,City
      ,State
      ,PhoneNum
      ,DateModified
      ,UserModified
	  ,PrimaryLanguage
	  ,Action
)
SELECT
	   SponsorID
      ,FirstName
      ,LastName
      ,AlternateName
      ,Email
      ,Address
      ,City
      ,State
      ,PhoneNum
      ,DateModified
      ,UserModified
	  ,PrimaryLanguage
	  ,'INSERT'
FROM inserted
END

GO






USE [HHKAT]
GO

/****** Object:  Trigger [dbo].[SponsorInfo_OnU]    Script Date: 6/6/2015 11:41:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[SponsorInfo_OnU]
   ON  [dbo].[SponsorInfo]
   FOR UPDATE
AS 
BEGIN
SET NOCOUNT ON;

 INSERT warehouse.SponsorInfo(
	   SponsorID
      ,FirstName
      ,LastName
      ,AlternateName
      ,Email
      ,Address
      ,City
      ,State
      ,PhoneNum
      ,DateModified
      ,UserModified
	  ,PrimaryLanguage
	  ,Action
)
SELECT
	   SponsorID
      ,FirstName
      ,LastName
      ,AlternateName
      ,Email
      ,Address
      ,City
      ,State
      ,PhoneNum
      ,DateModified
      ,UserModified
	  ,PrimaryLanguage
	  ,'UPDATE'
FROM 
	inserted
END

GO
























































