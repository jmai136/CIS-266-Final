USE [master]
GO
/****** Object:  Database [GroupFinal266]    Script Date: 6/15/2023 1:32:33 PM ******/
CREATE DATABASE [GroupFinal266]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GroupFinal266', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GroupFinal266.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GroupFinal266_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\GroupFinal266_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GroupFinal266] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GroupFinal266].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GroupFinal266] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GroupFinal266] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GroupFinal266] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GroupFinal266] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GroupFinal266] SET ARITHABORT OFF 
GO
ALTER DATABASE [GroupFinal266] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GroupFinal266] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GroupFinal266] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GroupFinal266] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GroupFinal266] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GroupFinal266] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GroupFinal266] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GroupFinal266] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GroupFinal266] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GroupFinal266] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GroupFinal266] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GroupFinal266] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GroupFinal266] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GroupFinal266] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GroupFinal266] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GroupFinal266] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GroupFinal266] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GroupFinal266] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GroupFinal266] SET  MULTI_USER 
GO
ALTER DATABASE [GroupFinal266] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GroupFinal266] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GroupFinal266] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GroupFinal266] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GroupFinal266] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GroupFinal266] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GroupFinal266] SET QUERY_STORE = OFF
GO
USE [GroupFinal266]
GO
/****** Object:  Table [dbo].[Buyers]    Script Date: 6/15/2023 1:32:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buyers](
	[BuyerID] [int] IDENTITY(1,1) NOT NULL,
	[BuyerFName] [varchar](40) NOT NULL,
	[BuyerLName] [varchar](40) NOT NULL,
	[BuyerUserName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BuyerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 6/15/2023 1:32:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarVIN] [varchar](50) NOT NULL,
	[CarYear] [int] NOT NULL,
	[CarMake] [varchar](50) NOT NULL,
	[CarModel] [varchar](50) NOT NULL,
	[CarPrice] [money] NOT NULL,
	[CarColor] [varchar](30) NOT NULL,
	[CarMiles] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CarVIN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 6/15/2023 1:32:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[CommentText] [varchar](max) NOT NULL,
	[ListingID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Listing]    Script Date: 6/15/2023 1:32:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Listing](
	[ListingID] [int] IDENTITY(1,1) NOT NULL,
	[SellerID] [int] NOT NULL,
	[CarVIN] [varchar](50) NOT NULL,
	[Description] [varchar](500) NULL,
	[CreationDateTime] [smalldatetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ListingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sellers]    Script Date: 6/15/2023 1:32:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sellers](
	[SellerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](30) NOT NULL,
	[Email] [varchar](45) NOT NULL,
	[Password] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SellerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'1HGCG1650Y1081994', 2000, N'Honda', N'2000 Honda Accord', 169.4000, N'Black', 6843)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'4JGBB5GB6BA625034', 2011, N'Mercedes', N'2011 Mercedes Benz ML', 849.3000, N'Black', 7583)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'5TBDT44155S779931', 2005, N'Toyota', N'2005 Toyota Tundra', 438.6000, N'Black', 1974)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'WB10419AX4ZM61551', 2004, N'BMW', N'2004 BMW R1150', 293.1040, N'Black', 3405)
GO
SET IDENTITY_INSERT [dbo].[Sellers] ON 

INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password]) VALUES (1, N'Hoshi', N'Kask', N'zzm4h94sr1a@icznn.com', N'NPVöP¾_qöŒ>{oI€¥P3KVî D8~sBí''a&µÉâ\	T«ÅƒÍ„ü<¾®·wIªi{fæ')
SET IDENTITY_INSERT [dbo].[Sellers] OFF
GO
ALTER TABLE [dbo].[Listing] ADD  DEFAULT (getdate()) FOR [CreationDateTime]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Listing_Comments] FOREIGN KEY([ListingID])
REFERENCES [dbo].[Listing] ([ListingID])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Listing_Comments]
GO
ALTER TABLE [dbo].[Listing]  WITH CHECK ADD  CONSTRAINT [FK_Listing_Cars] FOREIGN KEY([CarVIN])
REFERENCES [dbo].[Cars] ([CarVIN])
GO
ALTER TABLE [dbo].[Listing] CHECK CONSTRAINT [FK_Listing_Cars]
GO
ALTER TABLE [dbo].[Listing]  WITH CHECK ADD  CONSTRAINT [FK_Listing_Sellers] FOREIGN KEY([SellerID])
REFERENCES [dbo].[Sellers] ([SellerID])
GO
ALTER TABLE [dbo].[Listing] CHECK CONSTRAINT [FK_Listing_Sellers]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllComments]    Script Date: 6/15/2023 1:32:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jude Mai>
-- Create date: <6/15/2023>
-- Description:	<Get all comments for selected listing ID>
-- =============================================
CREATE PROCEDURE [dbo].[spGetAllComments] @ListingID int
AS
SELECT * FROM Comments WHERE ListingID = @ListingID
GO
USE [master]
GO
ALTER DATABASE [GroupFinal266] SET  READ_WRITE 
GO
