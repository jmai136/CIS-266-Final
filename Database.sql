USE [GroupFinal266]
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByYear]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spSelectCarByYear]
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByPrice]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spSelectCarByPrice]
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByModel]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spSelectCarByModel]
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByMiles]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spSelectCarByMiles]
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByMake]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spSelectCarByMake]
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByColor]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spSelectCarByColor]
GO
/****** Object:  StoredProcedure [dbo].[spRegisterUser]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spRegisterUser]
GO
/****** Object:  StoredProcedure [dbo].[spGetAllComments]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spGetAllComments]
GO
/****** Object:  StoredProcedure [dbo].[spFillByCarMake]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP PROCEDURE [dbo].[spFillByCarMake]
GO
ALTER TABLE [dbo].[Listing] DROP CONSTRAINT [FK_Listing_Sellers]
GO
ALTER TABLE [dbo].[Listing] DROP CONSTRAINT [FK_Listing_Cars]
GO
ALTER TABLE [dbo].[Comments] DROP CONSTRAINT [FK_Listing_Comments]
GO
ALTER TABLE [dbo].[Listing] DROP CONSTRAINT [DF__Listing__Creatio__2C3393D0]
GO
/****** Object:  Table [dbo].[Sellers]    Script Date: 6/18/2023 9:44:02 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sellers]') AND type in (N'U'))
DROP TABLE [dbo].[Sellers]
GO
/****** Object:  Table [dbo].[Listing]    Script Date: 6/18/2023 9:44:02 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Listing]') AND type in (N'U'))
DROP TABLE [dbo].[Listing]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 6/18/2023 9:44:02 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Comments]') AND type in (N'U'))
DROP TABLE [dbo].[Comments]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 6/18/2023 9:44:02 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cars]') AND type in (N'U'))
DROP TABLE [dbo].[Cars]
GO
/****** Object:  Table [dbo].[Buyers]    Script Date: 6/18/2023 9:44:02 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Buyers]') AND type in (N'U'))
DROP TABLE [dbo].[Buyers]
GO
USE [master]
GO
/****** Object:  Database [GroupFinal266]    Script Date: 6/18/2023 9:44:02 PM ******/
DROP DATABASE [GroupFinal266]
GO
/****** Object:  Database [GroupFinal266]    Script Date: 6/18/2023 9:44:02 PM ******/
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
/****** Object:  Table [dbo].[Buyers]    Script Date: 6/18/2023 9:44:02 PM ******/
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
/****** Object:  Table [dbo].[Cars]    Script Date: 6/18/2023 9:44:02 PM ******/
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
/****** Object:  Table [dbo].[Comments]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[CommentText] [varchar](256) NOT NULL,
	[ListingID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Listing]    Script Date: 6/18/2023 9:44:02 PM ******/
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
/****** Object:  Table [dbo].[Sellers]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sellers](
	[SellerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](45) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Hash] [nvarchar](max) NOT NULL,
	[Salt] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[SellerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'1HGCG1650Y1081994', 2000, N'Honda', N'Accord', 2500.0000, N'Black', 150000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'4JGBB5GB6BA625034', 2011, N'Mercedes', N'ML', 64000.0000, N'Black', 40000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'5TBDT44155S779931', 2005, N'Toyota', N'Tundra', 17000.0000, N'Black', 90000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'BH192778439YW1298', 2007, N'BMW', N'Z4', 8000.0000, N'Red', 110000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'BJ2738132YQ784329', 2012, N'Toyota', N'Highlander', 13000.0000, N'Blue', 190000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'BK1JE72B3U9284701', 2015, N'BMW', N'M3', 30000.0000, N'Silver', 50000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'BO2783263LQ198232', 2009, N'BMW', N'330i', 2000.0000, N'Black', 110000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'DU4783243JK483274', 2017, N'Honda', N'Civic', 37000.0000, N'Black', 30000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'HF2844HFJFHSLAOQ2', 2008, N'Honda', N'Civic', 6000.0000, N'Green', 90000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'HFJD176368193DH12', 2018, N'Mercedes', N'EQS', 45000.0000, N'White', 20000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'HI187326782VS2873', 2020, N'Mercedes', N'GLS', 110000.0000, N'White', 8000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'IO84327842CF47383', 2016, N'Toyota', N'Prius', 21000.0000, N'Blue', 71000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'JT2AE92W2K3207818', 1992, N'Toyota', N'Corolla', 2000.0000, N'Red', 140000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'KI43872943QM78493', 2009, N'BMW', N'328i', 3000.0000, N'Silver', 100000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'LA78432GU47832978', 2022, N'Toyota', N'GR86', 32000.0000, N'Red', 22000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'NL19748292VD19732', 2010, N'Toyota', N'Tacoma', 20000.0000, N'Grey', 90000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'OW78493VG27483928', 2001, N'BMW', N'Z3', 10000.0000, N'Blue', 90000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'PI8947389BH894320', 2006, N'Honda', N'Ridgeline', 15000.0000, N'Blue', 120000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'QP89438JI94327943', 2014, N'Mercedes', N'CLA', 34000.0000, N'Silver', 15000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'RT26378218NJ84932', 2016, N'Toyota', N'Corolla', 9000.0000, N'Green', 100000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'SK48932743ER84732', 2018, N'Honda', N'Odyssey', 42000.0000, N'Silver', 9000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'UW8937892NJ893214', 2004, N'Mercedes', N'CLA', 9000.0000, N'Green', 83000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'UY784932LO8439239', 2014, N'Toyota', N'Celica', 8000.0000, N'Silver', 132000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'VE78439243BH32894', 2006, N'Toyota', N'Avalon', 7000.0000, N'Silver', 120000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'VG73293LU78432784', 2015, N'BMW', N'640i', 26000.0000, N'Red', 66000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'WB10419AX4ZM61551', 2004, N'BMW', N'R1150', 293.1040, N'Black', 3405)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'WID28374910YU1293', 2016, N'Toyota', N'GT86', 16000.0000, N'Blue', 45000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'WO1987329VG187382', 2019, N'Honda', N'CR-V', 25000.0000, N'Silver', 10000)
INSERT [dbo].[Cars] ([CarVIN], [CarYear], [CarMake], [CarModel], [CarPrice], [CarColor], [CarMiles]) VALUES (N'ZY4738924KL493278', 2003, N'Honda', N'Accord', 4000.0000, N'Red', 140000)
GO
SET IDENTITY_INSERT [dbo].[Listing] ON 

INSERT [dbo].[Listing] ([ListingID], [SellerID], [CarVIN], [Description], [CreationDateTime]) VALUES (1, 1, N'1HGCG1650Y1081994', N'Seller: Hoshi Kask; Car: 2000 Honda Accord marked at $2500', CAST(N'2023-06-17T16:11:00' AS SmallDateTime))
INSERT [dbo].[Listing] ([ListingID], [SellerID], [CarVIN], [Description], [CreationDateTime]) VALUES (2, 3, N'BK1JE72B3U9284701', N'Seller: Énna Bashkim; Car: 2000 BMW M3 marked at $30000', CAST(N'2023-06-19T11:57:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Listing] OFF
GO
SET IDENTITY_INSERT [dbo].[Sellers] ON 

INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (1, N'Hoshi', N'Kask', N'zzm4h94sr1a@icznn.com', N'u3AeOX ^ 686 & h', N'침˂ଣ晕춝䦤�倜㾸쳺扡Ӣꮇ㨯㉣籄逹엂ඏ䎒퉅릚ꬫㅥฃ掕洞첥', N'YKZFcdMyI4wHLRBUQuoRmxcJwFGBppT6HAVzj6fsS75A3ZWvB1qDfNO3QW4MFy9Hj7S9iV66gJBctvN5cgYQUMSRbIocZkqnPr3X')
INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (2, N'Zachariah', N'Nasato', N'wosita5469@aaorsi.com', N'z85ArZ0R@80#', N'䀻뢤狐愥䳆丧⯢닂倣Ⓜ㏅窞遰嚴퀜ᘟ�產땳ꝰ͇娖⃰證劓⻎惡欱⟮믷', N'鯓ᄤ流煻鶡⢒쀆졖㴩埝릌澈ᯏ붜㠣꛼䎽Ɯ蕩ꢢጱ騡㣋荼뙥ﳋ욌଄蜤⩈ꍕᮅ潾ឣ譠﷜綮䍔뿹犢☧鄲⢎Ꟙ☖ู쇸鰿蜺ꯥ禃힯뮹냫옃ۜ맇്∵瞣㴷箔݄钱絈⩽ڷ圳쭎貄鹭濛ﻅꤔ䧔臶낦䭰搦퉎ፅ區찶㤗쀱鼷峼�㺦讳␰醏㟘�䣍麋ꁖ턝똕ꏄ䦈풻⤄븉鲬峨馡趶茾⧰垜')
INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (3, N'Énna', N'Bashkim', N'xullowebratre-1583@yopmail.com', N'$07*R2E1Vc9*', N'5葂葪豿ઢ豷붺㓌殌ᔿ霭ራ螴籴�ᖩꖩ⌮㓖偶ﳭ衣౦猧�䃋꺋ၸ쐈␝噫̧', N'᷼帮唯䜬稝�쥧긇霃܈똥覵︌댖ಏʨ᝞蹌삗爡쎞逦쯘㑀龉半姬嗝톬酰萏স慨赂閪ᚗ峇ꨎ礕史埪஌闵鶸豭줩㜁䬘᫥꨺⭝嵞ွ틯韥咫䜐븛ᥱ轼ⓕᓎċ㙗鹥寺봭ﯴ纭瓟荼ꍅ꼁䑷Ể�ㆭᤱ鸚繞삅酴흳礍★邾ؤꎗ樯띹铺ꐴ풣煛⡗쌃쵨ꬉ歹뵪�蟆뎳䭘鄵庈ᲁ빺↍嚮㟈拍驾ᦃ店埸ꟶ')
INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (4, N'Truls', N'Dipti', N'tiseubahatu-8500@yopmail.com', N'$Re5wr8679Fc', N'캳㉢홒퇢�䀓깤쐓䒠㪮ះ桗뉢῅蹓䧑夭믌膏�輗⒔ㇲ弎繟뜯堈㚀欧', N'唣꨹낭喴蠖⒛②㊲ﻯ䓮椕崫㉲昄Ȕ讠嘁왳뙾쿟蕙錇ব翘�◖ꏩ邔샯欏씔䚁苪꒟䪹蹲峘逿ࢵ䁩灉ݒ皿嘑餙ᒫ៣ᶩ譂ꡒ㩜᦬蛘規ꬬ㮩潕犢㒇卶簕ꀸ퐕츇ꄺ᜼슮걸뉊ࡸ叜埬횔൶⮄精랳닩맚ᵨꆭ鴐돖묕탺ꎓ戰ꕙ퐁ㅽ驴錦ᘫဖ륽씽ⱘ屪ᗙ圓纒萧גּ⮁몓堂茟昅ꡨ虽蝻輸쳆虾坭骂')
INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (5, N'Adaeze', N'Charlton', N'caximmecocri-2788@yopmail.com', N'mpV1h339t&2L', N'ᒫFꩱ۔瓍ꍠ콳相ᝐ㍆藳ἶ牸��ϋ淲諰㠲ⵂ蜎勷귔萆ᇗʌ틣', N'땴胪䲔ᬉ宑麵䓁ꊵɘ퀐膔掎ꑚ￴�澯隮횻কⵊⱮ戋戡跥श髴㖝響䬵햱驾�⾍ꎫ䀡켺۵襱甋䁱䇚孩瞱⋠렞哭䰹귝졠��쎣✹櫇ⰳ₈Ę퉥゘⠁扵䁷㳜纀菲磒㍆䬍쫽烣臙킼멍嵽庾敵༈뢄邋軝鯏㶙䯓鲲僧닸퇰캘啜聯㣟狃릳棡䀔⻦砣忺年�⮃沀龨⬶殡㘒孄��햆簛ꕅቘᶑ⨿')
INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (6, N'Goran', N'Ilga', N'xeubrunenotru-3547@yopmail.com', N't416!aYrwhxj', N'찰ᓋꒇ陪ឡよ뒉堓씥㦩ꖞ괍厜꾕﬏딜뒜㑸抭˞䫹色࣡炯慠뒑뇗腷踿엇', N'◵빆ꫵ�塰㕭囀헲颽�㴨齤ꍬ矴ᶢꐢ慪뫨꒠䍻蘆鏧삢裸쇴郆�낇뜻赛�癊䮩伞䯋波⪵뜒Ჰ䦞氆簚丹っ칪敳㋟ⱏ␯誝ゥ䲘蝛홋�嚉鄁䒸끶袛첨︽̘伇ⴓ⒔汆ᛇ衐곋枬癝ɡ䙻眆熗와캫㼼띓驹⧁侴桽韲權ᮉ䉘�쬫ఠ죣䬴똰἗侕謌磰㲡콬⍯燮ᗢ⻿踨郪鐰者綣쎋�ା徢')
INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (7, N'Myrto', N'Vida', N'zougeiritreillei-2047@yopmail.com', N'iKX*&1dW26BI', N'賂눴던當ꐖ懲Ⓘɀⶊסּ⡪탈๚ᗂⷒ䙢娧㺯廙땳⳱Ꝃ㿢酼聯ގ䳝Ѳ㠝�', N'唹몥⥰轶꾊젮骘ﳑﶁ⫐㪝箒ᮃॏ槙櫛乔༰珈ݻȠ剉ﲄ궒誵㫤塩퉊㣐鎮做쐌六ꬉㄝ⦁Ḯ渔�藲ꙃ鸌Ȉᗬꎢ᧊�᧚옇﹛䞻吃㚞댔什钛�ᭃ䬱諞椱枦侷欻ꆟꄂ杗צּᬷ꽏䬎榄ｿῚㄓ얌衪ƙ媳ᭅ쵒�諁鱺뎖䐼ꚑ蜃寷밴긛蘷뉚웗ᘾ祻䩹土褄엢痕ꌖ�ꭴ罙晚ዷ芜虎꒞ហ퉥㮜ퟶ詻顺�')
INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (8, N'Zdenka', N'Calogerus', N'baruxafreda-6871@yopmail.com', N'31WWo5K@lof2', N'㾴謝燲턷覘荝ᓞꐛ�ꁕ왫岿忦장殃㳴䪔딒뺮뇛堤둠㍀焪�켉ᖡ骽⩄', N'雵멭➶퓣쬞쇇㊈몌餤㿭퍢欞⅖ꂷ깱訪ꗳ፷腽橡䟿뾧䙫竹繘୚䥍㼦ᑃ剠⫘Ḹ凒Ổ愉玘鮂錅뗫䰽踊핃맬꿄ﮠ쌴ᱚ抢囔ꁪ䱸ꭷꩍ፳癸匵￣ஶ道뙫爅辬리赊禆ꘕ튥枮鞕堟ⶼഠ悑⛹ꁟ腼᧥仜컟읿ຮꮗ禢텅輽幫�ㄷ᧢舿缙哷�겚�ᶭ阛梣鯩쑺�Ⱌ畅놆ᑊႄ樨�꩞Ἦ낵ӠⓈ䡎')
INSERT [dbo].[Sellers] ([SellerID], [FirstName], [LastName], [Email], [Password], [Hash], [Salt]) VALUES (9, N'Ezekiel', N'Byllaid', N'gatocaceujeu-6803@yopmail.com', N'UTqNC*5kF@12', N'琮跡랢Ḗ�鴌Ю偶菋⫄⚳삨嫕㍄髅Ↄ쌕സ憘赼Մ뮞殉缤⧌ᄮ壾', N'㠦顣仰亾䜮㓭ᳱ㎪ၓ阆墯⧃罋淝笏뇬蹼Ʈ⓱颥꬝꧝됣戥㗭ꘑ臌嘶ྙㄢ�✳縹�Ω⯾떡鉣ꌳ爛︒ﶯ䊭䈰蟟』쌝㚚廨ꌯ�狔䰬﮴類抒䋀䨳↟焓Ჷⷛ�铒菻褸䙓僊焺שׁ쇿씸噳顯怵谢⍅ଙꉲꠗ쯯橈ం鈦佞Գ㴥᥿탍編䱪�밉阔溴澃ꇘ娲댖쿒講渉ￋ霦家�쟟႙┚♀๶⡋')
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
/****** Object:  StoredProcedure [dbo].[spFillByCarMake]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spFillByCarMake]
	@CarVINs varchar(max)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM dbo.Listing WHERE CarVIN IN(@carVINS)
END
GO
/****** Object:  StoredProcedure [dbo].[spGetAllComments]    Script Date: 6/18/2023 9:44:02 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spRegisterUser]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Jude Mai>
-- Create date: <6/16/2023>
-- Description:	<Registering users>
-- =============================================
CREATE PROCEDURE [dbo].[spRegisterUser] 
	-- Add the parameters for the stored procedure here
	@FirstName NVARCHAR(MAX),
	@LastName NVARCHAR(MAX),
	@Email NVARCHAR(MAX),
	@Password NVARCHAR(MAX),
	@Salt NVARCHAR(MAX)
AS
BEGIN
	IF EXISTS 
		(SELECT TOP 1 [SellerID] FROM [GroupFinal266].[dbo].[Sellers] WHERE [Hash] = HASHBYTES('SHA2_512', CONCAT(@Password, (SELECT [Salt] FROM [GroupFinal266].[dbo].[Sellers] WHERE [Email]=@Email)))) 
	BEGIN 
		SELECT [SellerID] FROM [GroupFinal266].[dbo].[Sellers] 
		WHERE [Hash] = HASHBYTES('SHA2_512', CONCAT(@Password, (SELECT [Salt] FROM [GroupFinal266].[dbo].[Sellers] WHERE Email=@Email))) 
		END 
	ELSE 
		INSERT INTO [GroupFinal266].[dbo].[Sellers] ([FirstName], [LastName], [Email], [Password], [Hash], [Salt]) 
		VALUES (@FirstName, @LastName, @Email, @Password, HASHBYTES('SHA2_512', CONCAT(@Password, @Salt)), @Salt);
	END
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByColor]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectCarByColor]
(
	@CarColor varchar(30)
)
AS
	SET NOCOUNT ON;
SELECT CarVIN, CarYear, CarMake, CarModel, CarPrice, CarColor, CarMiles FROM dbo.Cars
WHERE CarColor = @CarColor
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByMake]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectCarByMake]
(
	@CarMake varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT        CarVIN, CarYear, CarMake, CarModel, CarPrice, CarColor, CarMiles
FROM            Cars
WHERE        (CarMake = @CarMake)
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByMiles]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectCarByMiles]
(
	@CarMiles int
)
AS
	SET NOCOUNT ON;
SELECT CarVIN, CarYear, CarMake, CarModel, CarPrice, CarColor, CarMiles FROM dbo.Cars
WHERE CarMiles <= @CarMiles
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByModel]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectCarByModel]
(
	@CarModel varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT CarVIN, CarYear, CarMake, CarModel, CarPrice, CarColor, CarMiles FROM dbo.Cars
WHERE CarModel = @CarModel
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByPrice]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectCarByPrice]
(
	@CarPrice varchar(50)
)
AS
	SET NOCOUNT ON;

BEGIN
	IF @CarPrice = '$5,000-' 
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarPrice] < 5000 
		ORDER BY [CarPrice]
	ELSE IF @CarPrice ='$5,000 - $9,999' 
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarPrice] >= 5000.00 AND [CarPrice] <= 9999.00
		ORDER BY [CarPrice]
	ELSE IF @CarPrice ='$10,000+' 
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarPrice] >= 10000.00
		ORDER BY [CarPrice]
	ELSE
		SELECT * FROM [GroupFinal266].[dbo].[Cars]
		ORDER BY [CarPrice]
END
GO
/****** Object:  StoredProcedure [dbo].[spSelectCarByYear]    Script Date: 6/18/2023 9:44:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spSelectCarByYear]
(
	@CarYear varchar(50)
)
AS
	SET NOCOUNT ON;
BEGIN
	IF @CarYear = '1969-' 
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarYear] < 1969
		ORDER BY [CarYear]
	ELSE IF @CarYear ='1969-1994' 
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarYear] >= 1969 AND [CarYear] <= 1994
		ORDER BY [CarYear]
	ELSE IF @CarYear ='1994-2001' 
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarYear] >= 1994 AND [CarYear] <= 2001
		ORDER BY [CarYear]
	ELSE IF @CarYear ='2001-2012' 
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarYear] >= 2001 AND [CarYear] <= 2012
		ORDER BY [CarYear]
	ELSE IF @CarYear ='2012-2022' 
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarYear] >= 2012 AND [CarYear] <= 2022
		ORDER BY [CarYear]
	ELSE IF @CarYear = '2022+'
		SELECT * FROM [GroupFinal266].[dbo].[Cars] WHERE [CarYear] > 2022
		ORDER BY [CarYear]
	ELSE
		SELECT * FROM [GroupFinal266].[dbo].[Cars]
		ORDER BY [CarYear]
END
GO
USE [master]
GO
ALTER DATABASE [GroupFinal266] SET  READ_WRITE 
GO
