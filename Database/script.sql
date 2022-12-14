USE [master]
GO
/****** Object:  Database [FStoreDB]    Script Date: 11/17/2022 10:48:30 AM ******/
CREATE DATABASE [FStoreDB]
 GO
ALTER DATABASE [FStoreDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FStoreDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FStoreDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FStoreDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FStoreDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FStoreDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FStoreDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FStoreDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FStoreDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FStoreDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FStoreDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FStoreDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FStoreDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FStoreDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FStoreDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FStoreDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FStoreDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FStoreDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FStoreDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FStoreDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FStoreDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FStoreDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FStoreDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FStoreDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FStoreDB] SET RECOVERY FULL 
GO
ALTER DATABASE [FStoreDB] SET  MULTI_USER 
GO
ALTER DATABASE [FStoreDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FStoreDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FStoreDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FStoreDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FStoreDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FStoreDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FStoreDB', N'ON'
GO
ALTER DATABASE [FStoreDB] SET QUERY_STORE = OFF
GO
USE [FStoreDB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/17/2022 10:48:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 11/17/2022 10:48:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Role] [varchar](10) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
	[Actived] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 11/17/2022 10:48:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/17/2022 10:48:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/17/2022 10:48:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (1, N'Sedan')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (2, N'HatchBack')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (3, N'SUV')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (4, N'Crossover')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (5, N'Minivan')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (6, N'Coupe')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (7, N'Convertible')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (8, N'Pickup')
INSERT [dbo].[Category] ([CategoryId], [CategoryName]) VALUES (9, N'Limousine')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Member] ON 

INSERT [dbo].[Member] ([MemberId], [Email], [Role], [CompanyName], [City], [Country], [Password], [Actived]) VALUES (1, N'admin@fstore.com', N'admin', N'FSoft', N'HCM', N'Vietnam', N'admin@@', 1)
INSERT [dbo].[Member] ([MemberId], [Email], [Role], [CompanyName], [City], [Country], [Password], [Actived]) VALUES (2, N'user0@fstore.com', N'member', N'Apple', N'California', N'US', N'12345', 1)
INSERT [dbo].[Member] ([MemberId], [Email], [Role], [CompanyName], [City], [Country], [Password], [Actived]) VALUES (4, N'user1@fstore.com', N'member', N'IKEA', N'Amsterdam', N'Sweden', N'12345', 1)
SET IDENTITY_INSERT [dbo].[Member] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2022-11-12T00:00:00.000' AS DateTime), NULL, NULL, 200.0000)
INSERT [dbo].[Order] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (3, 2, CAST(N'2022-11-17T10:46:58.307' AS DateTime), NULL, NULL, 12.0000)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 2, 30000.0000, 1, 0.1)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 3, 25000.0000, 2, 0.2)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock], [Deleted]) VALUES (2, 1, N'Camry 2022', N'1515 kg', 30000.0000, 15, 0)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock], [Deleted]) VALUES (3, 3, N'VinFast SUV', N'2000 kg', 25000.0000, 10, 0)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock], [Deleted]) VALUES (4, 6, N'Lamborghini Aventador', N'2500 kg', 100000.0000, 5, 0)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock], [Deleted]) VALUES (5, 9, N'Mercedes Benz Stretch ', N'4000 kg', 200000.0000, 3, 0)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock], [Deleted]) VALUES (6, 5, N'Voyah Dreamer ', N'1500 kg', 40000.0000, 9, 0)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
/****** Object:  Index [UQ__Member__0CF04B199B7A2D66]    Script Date: 11/17/2022 10:48:30 AM ******/
ALTER TABLE [dbo].[Member] ADD UNIQUE NONCLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Member__A9D10534D23A56EC]    Script Date: 11/17/2022 10:48:30 AM ******/
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order]  DEFAULT (getdate()) FOR [OrderDate]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([MemberId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
USE [master]
GO
ALTER DATABASE [FStoreDB] SET  READ_WRITE 
GO
