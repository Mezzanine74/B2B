USE [master]
GO
/****** Object:  Database [B2B]    Script Date: 15/01/2020 02:18:06 ******/
CREATE DATABASE [B2B]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'B2B', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\B2B.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'B2B_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\B2B_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [B2B] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [B2B].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [B2B] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [B2B] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [B2B] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [B2B] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [B2B] SET ARITHABORT OFF 
GO
ALTER DATABASE [B2B] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [B2B] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [B2B] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [B2B] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [B2B] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [B2B] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [B2B] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [B2B] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [B2B] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [B2B] SET  DISABLE_BROKER 
GO
ALTER DATABASE [B2B] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [B2B] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [B2B] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [B2B] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [B2B] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [B2B] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [B2B] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [B2B] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [B2B] SET  MULTI_USER 
GO
ALTER DATABASE [B2B] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [B2B] SET DB_CHAINING OFF 
GO
ALTER DATABASE [B2B] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [B2B] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [B2B] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'B2B', N'ON'
GO
ALTER DATABASE [B2B] SET QUERY_STORE = OFF
GO
USE [B2B]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
	[PasswordRaw] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Marka] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_OdemeSekli] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PeriodOfMaxSellAmount]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PeriodOfMaxSellAmount](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_MaxSatisMiktariPeriyodu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductInformation]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductInformation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[BrandId] [int] NULL,
	[Status] [bit] NULL,
	[StockCode] [int] NULL,
	[StockTypeId] [int] NULL,
	[PaymentMethodId] [int] NULL,
	[VATId] [int] NULL,
	[SellIfNotInStock] [bit] NULL,
	[ShowInMainPage] [bit] NULL,
	[UserComment] [bit] NULL,
	[ShowOrder] [int] NULL,
	[SupplierId] [int] NULL,
	[ManufacturerCode] [nvarchar](50) NULL,
	[ProductSpecialistId] [int] NULL,
	[MaxSellCount] [int] NULL,
	[PeriodOfMaxSellAmountId] [int] NULL,
	[ShortDescription] [nvarchar](100) NULL,
	[KeyWords] [nvarchar](100) NULL,
 CONSTRAINT [PK_UrunBilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductSpecialist]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductSpecialist](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_UrunSorumlusu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockType]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_StokTipi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubTestPersonDescription]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubTestPersonDescription](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BaseId] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[Lang] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_SubTestPersonDescription] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubTestPersonSurname]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubTestPersonSurname](
	[Lang] [nvarchar](2) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BaseId] [int] NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_SubTestPersonSurname] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Tedarikci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestPerson]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestPerson](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](100) NULL,
	[DescriptionMLId] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Surname] [nvarchar](100) NOT NULL,
	[SurnameMLId] [int] NOT NULL,
	[TestSexId] [int] NOT NULL,
 CONSTRAINT [PK_TestPerson] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestSex]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestSex](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TestSex] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VAT]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAT](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_KdvOrani] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 15/01/2020 02:18:06 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 15/01/2020 02:18:06 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 15/01/2020 02:18:06 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleId]    Script Date: 15/01/2020 02:18:06 ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 15/01/2020 02:18:06 ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 15/01/2020 02:18:06 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SubTestPersonDescription]    Script Date: 15/01/2020 02:18:06 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_SubTestPersonDescription] ON [dbo].[SubTestPersonDescription]
(
	[BaseId] ASC,
	[Lang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SubTestPersonSurname]    Script Date: 15/01/2020 02:18:06 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_SubTestPersonSurname] ON [dbo].[SubTestPersonSurname]
(
	[BaseId] ASC,
	[Lang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_TestPerson]    Script Date: 15/01/2020 02:18:06 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_TestPerson] ON [dbo].[TestPerson]
(
	[DescriptionMLId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ProductInformation]  WITH CHECK ADD  CONSTRAINT [FK_ProductInformation_Brand] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brand] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductInformation] CHECK CONSTRAINT [FK_ProductInformation_Brand]
GO
ALTER TABLE [dbo].[ProductInformation]  WITH CHECK ADD  CONSTRAINT [FK_ProductInformation_PaymentMethod] FOREIGN KEY([PaymentMethodId])
REFERENCES [dbo].[PaymentMethod] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductInformation] CHECK CONSTRAINT [FK_ProductInformation_PaymentMethod]
GO
ALTER TABLE [dbo].[ProductInformation]  WITH CHECK ADD  CONSTRAINT [FK_ProductInformation_PeriodOfMaxSellAmount] FOREIGN KEY([PeriodOfMaxSellAmountId])
REFERENCES [dbo].[PeriodOfMaxSellAmount] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductInformation] CHECK CONSTRAINT [FK_ProductInformation_PeriodOfMaxSellAmount]
GO
ALTER TABLE [dbo].[ProductInformation]  WITH CHECK ADD  CONSTRAINT [FK_ProductInformation_ProductSpecialist] FOREIGN KEY([ProductSpecialistId])
REFERENCES [dbo].[ProductSpecialist] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductInformation] CHECK CONSTRAINT [FK_ProductInformation_ProductSpecialist]
GO
ALTER TABLE [dbo].[ProductInformation]  WITH CHECK ADD  CONSTRAINT [FK_ProductInformation_StockType] FOREIGN KEY([StockTypeId])
REFERENCES [dbo].[StockType] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductInformation] CHECK CONSTRAINT [FK_ProductInformation_StockType]
GO
ALTER TABLE [dbo].[ProductInformation]  WITH CHECK ADD  CONSTRAINT [FK_ProductInformation_Supplier] FOREIGN KEY([SupplierId])
REFERENCES [dbo].[Supplier] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductInformation] CHECK CONSTRAINT [FK_ProductInformation_Supplier]
GO
ALTER TABLE [dbo].[ProductInformation]  WITH CHECK ADD  CONSTRAINT [FK_ProductInformation_VAT] FOREIGN KEY([VATId])
REFERENCES [dbo].[VAT] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ProductInformation] CHECK CONSTRAINT [FK_ProductInformation_VAT]
GO
ALTER TABLE [dbo].[SubTestPersonDescription]  WITH CHECK ADD  CONSTRAINT [FK_SubTestPersonDescription_TestPerson1] FOREIGN KEY([BaseId])
REFERENCES [dbo].[TestPerson] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubTestPersonDescription] CHECK CONSTRAINT [FK_SubTestPersonDescription_TestPerson1]
GO
ALTER TABLE [dbo].[SubTestPersonSurname]  WITH CHECK ADD  CONSTRAINT [FK_SubTestPersonSurname_TestPerson] FOREIGN KEY([BaseId])
REFERENCES [dbo].[TestPerson] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SubTestPersonSurname] CHECK CONSTRAINT [FK_SubTestPersonSurname_TestPerson]
GO
ALTER TABLE [dbo].[TestPerson]  WITH CHECK ADD  CONSTRAINT [FK_TestPerson_TestSex] FOREIGN KEY([TestSexId])
REFERENCES [dbo].[TestSex] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[TestPerson] CHECK CONSTRAINT [FK_TestPerson_TestSex]
GO
/****** Object:  StoredProcedure [dbo].[SpTestPersonList]    Script Date: 15/01/2020 02:18:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SpTestPersonList] 
	-- Add the parameters for the stored procedure here
	@Lang nvarChar(2) = N'en'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        
	dbo.TestPerson.Id, 
	ISNULL(subDescription.Description, N'') AS Description, 
	dbo.TestPerson.DescriptionMLId, 
	dbo.TestPerson.Name, 
	ISNULL(subSurname.Description, N'') AS Surname, 
	dbo.TestPerson.SurnameMLId, dbo.TestPerson.TestSexId
	FROM dbo.TestPerson 
		LEFT OUTER JOIN (SELECT Lang, Id, BaseId, Description FROM dbo.SubTestPersonSurname Where Lang = @Lang) subSurname ON dbo.TestPerson.Id = subSurname.BaseId 
		LEFT OUTER JOIN (SELECT Lang, Id, BaseId, Description FROM dbo.SubTestPersonDescription Where Lang = @Lang) subDescription ON dbo.TestPerson.Id = subDescription.BaseId 

END
GO
USE [master]
GO
ALTER DATABASE [B2B] SET  READ_WRITE 
GO
