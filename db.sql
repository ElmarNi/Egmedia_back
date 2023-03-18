/****** Object:  Database [EGmedia]    Script Date: 3/19/2023 2:06:00 AM ******/
CREATE DATABASE [EGmedia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EGmedia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EGmedia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EGmedia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\EGmedia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EGmedia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EGmedia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EGmedia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EGmedia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EGmedia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EGmedia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EGmedia] SET ARITHABORT OFF 
GO
ALTER DATABASE [EGmedia] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EGmedia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EGmedia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EGmedia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EGmedia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EGmedia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EGmedia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EGmedia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EGmedia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EGmedia] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EGmedia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EGmedia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EGmedia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EGmedia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EGmedia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EGmedia] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EGmedia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EGmedia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EGmedia] SET  MULTI_USER 
GO
ALTER DATABASE [EGmedia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EGmedia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EGmedia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EGmedia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EGmedia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EGmedia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EGmedia] SET QUERY_STORE = OFF
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[about]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[about](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_about] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[advantages]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[advantages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[IconUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_advantages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[banners]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banners](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WhatFor] [nvarchar](max) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_banners] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contactMessages]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contactMessages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[IsResponsed] [bit] NOT NULL,
 CONSTRAINT [PK_contactMessages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[offers]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[offers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[IsResponsed] [bit] NOT NULL,
 CONSTRAINT [PK_offers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projectCategories]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projectCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_projectCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[projects]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[projects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[ProjectCategoryId] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Home_ImageUrl] [nvarchar](max) NULL,
	[ShowInHome] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_projects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[serviceImages]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[serviceImages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
 CONSTRAINT [PK_serviceImages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[services]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Heading] [nvarchar](max) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[CategoryIconUrl] [nvarchar](max) NULL,
	[CategoryImageUrl] [nvarchar](max) NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sliders]    Script Date: 3/19/2023 2:06:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sliders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Header_First_Word] [nvarchar](max) NOT NULL,
	[Header_Second_Word] [nvarchar](max) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[Aside_Header] [nvarchar](max) NOT NULL,
	[Aside_ImageUrl] [nvarchar](max) NULL,
	[Date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_sliders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210323135628_Initial and added about table', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210323141607_Added Project and Project categories', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210323142120_Added datetime to projects', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210323144206_Added Slider', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210323144341_Slider first and second word', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210323144440_Slider deleted', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210323144507_slider added', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210324093913_projects added home page image', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210324095442_added advatages', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210327163431_updated advantage fontawasome icon to image', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210328160011_Service, Service image and service category is created for db', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210328161220_services all 3 tables names changed', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210402095508_Contact messages added to db', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210402103955_is responsed added to contact message', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210402132617_removed is responsed', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210403100518_get price offer added', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210404120926_offer added', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210411195347_Added image to service categories', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210411201106_added icon img to service categories', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210413103640_added user', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210413104424_removed first and lastname from user', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210416170854_user deleted', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210416171854_identity', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210503165054_added isresponded to contact message', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210510185408_Inital', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210512210009_added status to pr cats', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210512210307_portfoliocategory changed to projectcategory in projects', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210512221209_added showinhome and status to projects', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210512221357_portfolios to projects in p cats', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210526140158_added status to service categories', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210611062354_added status column to service', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210611062600_removed status from services', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210616074456_service cats added to services', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210616074958_service cat-s removed from db', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210616075054_status added to service', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210701120553_Added Banner Model', N'2.1.14-servicing-32113')
GO
SET IDENTITY_INSERT [dbo].[about] ON 

INSERT [dbo].[about] ([Id], [Content]) VALUES (1, N'<p>Lorem <strong>Ipsum </strong>is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry&#39;s standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</p>
')
SET IDENTITY_INSERT [dbo].[about] OFF
GO
SET IDENTITY_INSERT [dbo].[advantages] ON 

INSERT [dbo].[advantages] ([Id], [Content], [IconUrl]) VALUES (1, N'Münasib qiymətə yüksək keyfiyyətli xidmət', N'advantages/58b87c4a-d0e9-4212-9a53-95c4b7836a25diploma (2).png')
INSERT [dbo].[advantages] ([Id], [Content], [IconUrl]) VALUES (2, N'Biznesinizi inkişaf etdirin və satışlarınızı artırın', N'advantages/ed88a336-2ba2-4724-93c2-f65f42128230money-growth.png')
INSERT [dbo].[advantages] ([Id], [Content], [IconUrl]) VALUES (3, N'Hər zaman sizə texniki dəstək göstərməyə hazırıq', N'advantages/429d772c-7e76-4be6-bef5-3bfd08f8c3e9support.png')
INSERT [dbo].[advantages] ([Id], [Content], [IconUrl]) VALUES (4, N'Bizimlə işləmək sadədir. İşimizi ciddiyə alırıq', N'advantages/51cbd1ec-6064-4abf-8fb5-80e6d31f2d57support (1).png')
SET IDENTITY_INSERT [dbo].[advantages] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'56d60159-f484-448c-a7ae-f12ca402dfae', N'admin', N'ADMIN', N'59978de1-8167-4f65-b75d-f384021ed051')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ce933678-e2ee-4f10-8606-304e857f38d3', N'56d60159-f484-448c-a7ae-f12ca402dfae')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'ce933678-e2ee-4f10-8606-304e857f38d3', N'egmedia@admin', N'EGMEDIA@ADMIN', NULL, NULL, 0, N'AQAAAAEAACcQAAAAELrLvNcllR5oBzRe12WcxUBIvqzki3mno0ge7+YuJOkXiAaAOxW5cTGpdqbBs17Hrw==', N'4AFWRTHOHZPLWZYCRR7S7SBOJM2MKFXR', N'94e20da5-aae8-4db1-84ee-647134e08e48', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[banners] ON 

INSERT [dbo].[banners] ([Id], [WhatFor], [ImageUrl]) VALUES (1, N'Haqqımızda', N'banners/6f0a9b0e-8b82-4a5a-8026-5bd20f035d93contact-bg.jpg')
INSERT [dbo].[banners] ([Id], [WhatFor], [ImageUrl]) VALUES (2, N'Xidmətlər', N'banners/63762f15-1d9e-47c9-8fda-40643b475d0acontact-bg.jpg')
INSERT [dbo].[banners] ([Id], [WhatFor], [ImageUrl]) VALUES (3, N'Portfolio', N'banners/7c3daad1-821a-4657-8bbb-3400145fc666contact-bg.jpg')
INSERT [dbo].[banners] ([Id], [WhatFor], [ImageUrl]) VALUES (5, N'Əlaqə', N'banners/647dab77-601e-4475-a953-0973b4ff3021contact-bg.jpg')
SET IDENTITY_INSERT [dbo].[banners] OFF
GO
SET IDENTITY_INSERT [dbo].[contactMessages] ON 

INSERT [dbo].[contactMessages] ([Id], [Fullname], [Email], [PhoneNumber], [Message], [Date], [IsResponsed]) VALUES (3, N'Elmar İbrahimli', N'elmarni@code.edu.az', N'994775202012', N'sal', CAST(N'2021-06-29T11:01:26.0475786' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[contactMessages] OFF
GO
SET IDENTITY_INSERT [dbo].[offers] ON 

INSERT [dbo].[offers] ([Id], [Fullname], [Email], [PhoneNumber], [Message], [Date], [IsResponsed]) VALUES (2, N'Elmar', N'elmarni@code.edu.az', N'12312312', N'amdksmlakdsmx', CAST(N'2021-06-29T10:46:28.7065639' AS DateTime2), 1)
INSERT [dbo].[offers] ([Id], [Fullname], [Email], [PhoneNumber], [Message], [Date], [IsResponsed]) VALUES (3, N'kjn', N'jbkjb@jhvhjm.com', N'68465', N'jkbkm ', CAST(N'2021-07-05T01:27:22.7270979' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[offers] OFF
GO
SET IDENTITY_INSERT [dbo].[projectCategories] ON 

INSERT [dbo].[projectCategories] ([Id], [Name], [Status]) VALUES (1, N'Category update', 1)
INSERT [dbo].[projectCategories] ([Id], [Name], [Status]) VALUES (2, N'Category 2', 1)
INSERT [dbo].[projectCategories] ([Id], [Name], [Status]) VALUES (3, N'Category 3', 1)
INSERT [dbo].[projectCategories] ([Id], [Name], [Status]) VALUES (4, N'Category Create', 0)
SET IDENTITY_INSERT [dbo].[projectCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[projects] ON 

INSERT [dbo].[projects] ([Id], [Name], [ImageUrl], [ProjectCategoryId], [Date], [Home_ImageUrl], [ShowInHome], [Status]) VALUES (12, N'Project ', N'projects/46d4c36f-6b4e-4eb6-9636-389022b653a6Project-Management-Mantenimiento-1.jpg', 1, CAST(N'2021-05-14T19:25:38.5780564' AS DateTime2), N'projects/d4c266f4-71dd-464b-b82b-d2955b7b9cafportfolio-big.jpg', 1, 1)
INSERT [dbo].[projects] ([Id], [Name], [ImageUrl], [ProjectCategoryId], [Date], [Home_ImageUrl], [ShowInHome], [Status]) VALUES (13, N'Project 1', N'projects/edd5c035-7ec2-41c8-86b0-427b0808cd55Project-Management-Mantenimiento-1.jpg', 1, CAST(N'2021-05-14T19:25:55.5357886' AS DateTime2), N'projects/e2a9b6ca-d099-4639-9277-94fa58ad62a7work-2.jpg', 1, 1)
INSERT [dbo].[projects] ([Id], [Name], [ImageUrl], [ProjectCategoryId], [Date], [Home_ImageUrl], [ShowInHome], [Status]) VALUES (14, N'Project 1', N'projects/1c44de12-eabb-4d47-b16f-b6092e545cfeProject-Management-Mantenimiento-1.jpg', 2, CAST(N'2021-05-14T19:26:15.4848968' AS DateTime2), N'projects/41e1a5a4-f1f1-41ea-8b75-03ec362059ebwork-3.jpg', 1, 1)
INSERT [dbo].[projects] ([Id], [Name], [ImageUrl], [ProjectCategoryId], [Date], [Home_ImageUrl], [ShowInHome], [Status]) VALUES (15, N'Project 1', N'projects/ce965f4d-a0b3-4022-9d82-80e18b088714Project-Management-Mantenimiento-1.jpg', 2, CAST(N'2021-05-14T19:26:35.4328240' AS DateTime2), N'projects/b3321a44-abc0-4b44-9586-ecb9db95ef91work-4.jpg', 1, 1)
INSERT [dbo].[projects] ([Id], [Name], [ImageUrl], [ProjectCategoryId], [Date], [Home_ImageUrl], [ShowInHome], [Status]) VALUES (16, N'Project 1', N'projects/5630a55e-470e-4a09-8172-e7645e0a00fcuntitled-1-1024x576.png', 3, CAST(N'2021-05-24T16:15:58.5795389' AS DateTime2), N'projects/c30f67c5-6312-40c2-a7b8-e629dd683aa4work-5.jpg', 1, 1)
INSERT [dbo].[projects] ([Id], [Name], [ImageUrl], [ProjectCategoryId], [Date], [Home_ImageUrl], [ShowInHome], [Status]) VALUES (17, N'Project 1', N'projects/56257279-f045-48ab-bc18-6437a7d855e2work-6.jpg', 3, CAST(N'2021-05-14T19:27:11.8819935' AS DateTime2), N'projects/1b56a851-4618-4f22-b6ba-774f8854d3a7work-6.jpg', 1, 1)
SET IDENTITY_INSERT [dbo].[projects] OFF
GO
SET IDENTITY_INSERT [dbo].[serviceImages] ON 

INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (25, N'service/d69670c6-cb3d-47f9-af66-40fcf17c999d0b5587fb-31c6-4180-ad26-2c2ac9da6fadservice-1.jpg', 9)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (26, N'service/d7f6dcc5-a437-4eec-80ca-8c4f222c4432services-1-565x401.jpg', 9)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (27, N'service/eca5e1d7-fd5a-437f-999f-6b6d84e73743services-2-565x401.jpg', 9)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (28, N'service/15a7892f-9f6b-4c1c-9602-1bfd5582b9acservices-3-565x401.jpg', 9)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (29, N'service/d3b72493-43b7-4a10-acba-1dcd4688d596services-4-565x401.jpg', 9)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (30, N'service/a372d751-d50a-4bb8-8e7f-c351eb7b59f9services-5-565x401.jpg', 9)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (31, N'service/d008ab22-5e2b-4d94-9e45-875511206850services-6-565x401.jpg', 9)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (32, N'service/b1e45d76-a16e-48ff-b5b5-c52d4118ce460b5587fb-31c6-4180-ad26-2c2ac9da6fadservice-1.jpg', 10)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (33, N'service/022d3e8b-8795-45ab-b693-b79fddb3fce3services-1-565x401.jpg', 10)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (34, N'service/ae09ec2c-30ee-47ba-a620-2f18bcd21ca2services-2-565x401.jpg', 10)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (35, N'service/051b08a0-e543-45b1-a516-db9728eec2e8services-3-565x401.jpg', 10)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (36, N'service/8f1ccb40-fb2a-4f8a-a00b-56b564dee8fdservices-4-565x401.jpg', 10)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (37, N'service/5f2bcb16-aba0-4a83-829a-a578ebf94e14services-5-565x401.jpg', 10)
INSERT [dbo].[serviceImages] ([Id], [ImageUrl], [ServiceId]) VALUES (38, N'service/a5e1502d-468a-48b1-9bc5-9a52a2deaab6services-6-565x401.jpg', 10)
SET IDENTITY_INSERT [dbo].[serviceImages] OFF
GO
SET IDENTITY_INSERT [dbo].[services] ON 

INSERT [dbo].[services] ([Id], [Heading], [Content], [CategoryIconUrl], [CategoryImageUrl], [CategoryName], [Status]) VALUES (9, N'Veb saytların hazırlanması', N'<p>Digital <strong>advertising </strong>services help media &amp; entertainment companies address the profound evolution sweeping across the industry. We bring essential expertise, tools and services to help <em>businesses </em>transition to the new <u>multimedia </u>advertising model, while offering a complete suite of services across the spectrum of digital capabilities, in order to transform media.</p>
', N'serviceIcons/3fb0c891-4abd-4c62-bc85-9efbae0881167b71e55c-1271-4c5a-bfee-f535da7e4c87c031e04c-fb06-45f7-b34c-0c6ab409a8bccoding.png', N'serviceCategories/b1f5da50-c5de-4fd2-ac79-c79f1b583c750b5587fb-31c6-4180-ad26-2c2ac9da6fadservice-1.jpg', N'Veb sayt', 1)
INSERT [dbo].[services] ([Id], [Heading], [Content], [CategoryIconUrl], [CategoryImageUrl], [CategoryName], [Status]) VALUES (10, N'Some Heading DBC 3', N'<p>Digital <strong>advertising </strong>services help media &amp; entertainment companies address the profound evolution sweeping across the industry. We bring essential expertise, tools and services to help <em>businesses </em>transition to the new <u>multimedia </u>advertising model, while offering a complete suite of services across the spectrum of digital capabilities, in order to transform media.</p>
', N'serviceIcons/95ea4b2e-d32e-413d-8fe6-2dc93c227bb77b71e55c-1271-4c5a-bfee-f535da7e4c87c031e04c-fb06-45f7-b34c-0c6ab409a8bccoding.png', N'serviceCategories/6980c032-b75f-47a4-9498-46956b32a6610b5587fb-31c6-4180-ad26-2c2ac9da6fadservice-1.jpg', N'Service DBC 3', 1)
SET IDENTITY_INSERT [dbo].[services] OFF
GO
SET IDENTITY_INSERT [dbo].[sliders] ON 

INSERT [dbo].[sliders] ([Id], [Header_First_Word], [Header_Second_Word], [Content], [ImageUrl], [Aside_Header], [Aside_ImageUrl], [Date]) VALUES (4, N'Mobil tətbiqlərin', N'hazırlanması', N'<p>İşinizə yeni m&uuml;ştərilər cəlb etmək &uuml;&ccedil;&uuml;n mobil marketinqdən istifadə etmirsinizsə, narahat olmayın rəqibləriniz onsuz da istifadə edir və sizin əvəzinizə&nbsp;bu m&uuml;ştəriləri əldə edirlər.</p>
', N'slider/a2a3a7e4-bdf6-449c-8903-7fcca0829aceslider1.jpg', N'Mobil tətbiqlər', N'slider/c0d8f15c-4f52-4180-acd5-1a6f6cd33a30Untitled_design-removebg-preview (1).png', CAST(N'2021-07-21T22:39:12.0084558' AS DateTime2))
INSERT [dbo].[sliders] ([Id], [Header_First_Word], [Header_Second_Word], [Content], [ImageUrl], [Aside_Header], [Aside_ImageUrl], [Date]) VALUES (5, N'Dizayn', N'və mətbəə', N'<p>Qrafik dizayn işləri veb dizayn da daxil olmaqla b&uuml;t&uuml;n korporativ işləri əhatə edir.</p>

<p>Professional qrafik dizayn xidmətləri şirkətinizin keyfiyyətini və işinizə qoyduğunuz dəyəri əks etdirir.</p>
', N'slider/6878d220-8dcb-4bc2-baf3-7b824e2a98b5a2a3a7e4-bdf6-449c-8903-7fcca0829aceslider1.jpg', N'Mətbəə ', N'slider/8a92715e-0f19-48b6-a08e-3f1c0659d3e8Untitled design (3).png', CAST(N'2021-07-21T22:39:30.7434946' AS DateTime2))
INSERT [dbo].[sliders] ([Id], [Header_First_Word], [Header_Second_Word], [Content], [ImageUrl], [Aside_Header], [Aside_ImageUrl], [Date]) VALUES (6, N'Veb saytların', N'hazırlanması', N'<p>Veb saytınız sizi 7/24 təbliğ edir. He&ccedil; bir iş&ccedil;i bunu edə bilməz.&nbsp;</p>

<p>İndi sifariş edin sizində x&uuml;susi və g&ouml;z oxşayan veb saytınız olsun.</p>
', N'slider/c17de797-ce91-44d9-bf22-585f2d4cec3ba2a3a7e4-bdf6-449c-8903-7fcca0829aceslider1.jpg', N'Veb sayt', N'slider/b69f0d2b-0470-4479-bdb0-9a86ac5d7a2cUntitled design (2).png', CAST(N'2021-07-21T22:39:32.8809796' AS DateTime2))
SET IDENTITY_INSERT [dbo].[sliders] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_projects_ProjectCategoryId]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE NONCLUSTERED INDEX [IX_projects_ProjectCategoryId] ON [dbo].[projects]
(
	[ProjectCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_serviceImages_ServiceId]    Script Date: 3/19/2023 2:06:01 AM ******/
CREATE NONCLUSTERED INDEX [IX_serviceImages_ServiceId] ON [dbo].[serviceImages]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[contactMessages] ADD  DEFAULT ((0)) FOR [IsResponsed]
GO
ALTER TABLE [dbo].[projectCategories] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[projects] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Date]
GO
ALTER TABLE [dbo].[projects] ADD  DEFAULT ((0)) FOR [ShowInHome]
GO
ALTER TABLE [dbo].[projects] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[services] ADD  DEFAULT (N'') FOR [CategoryName]
GO
ALTER TABLE [dbo].[services] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[projects]  WITH CHECK ADD  CONSTRAINT [FK_projects_projectCategories_ProjectCategoryId] FOREIGN KEY([ProjectCategoryId])
REFERENCES [dbo].[projectCategories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[projects] CHECK CONSTRAINT [FK_projects_projectCategories_ProjectCategoryId]
GO
ALTER TABLE [dbo].[serviceImages]  WITH CHECK ADD  CONSTRAINT [FK_serviceImages_services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[serviceImages] CHECK CONSTRAINT [FK_serviceImages_services_ServiceId]
GO
ALTER DATABASE [EGmedia] SET  READ_WRITE 
GO
