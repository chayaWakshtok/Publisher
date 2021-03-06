USE [master]
GO
/****** Object:  Database [publishers]    Script Date: 26/11/2020 02:59:33 ******/
CREATE DATABASE [publishers]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'publishers', FILENAME = N'C:\Users\User\publishers.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'publishers_log', FILENAME = N'C:\Users\User\publishers_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [publishers] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [publishers].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [publishers] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [publishers] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [publishers] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [publishers] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [publishers] SET ARITHABORT OFF 
GO
ALTER DATABASE [publishers] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [publishers] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [publishers] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [publishers] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [publishers] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [publishers] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [publishers] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [publishers] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [publishers] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [publishers] SET  ENABLE_BROKER 
GO
ALTER DATABASE [publishers] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [publishers] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [publishers] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [publishers] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [publishers] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [publishers] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [publishers] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [publishers] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [publishers] SET  MULTI_USER 
GO
ALTER DATABASE [publishers] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [publishers] SET DB_CHAINING OFF 
GO
ALTER DATABASE [publishers] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [publishers] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [publishers] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [publishers] SET QUERY_STORE = OFF
GO
USE [publishers]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [publishers]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 26/11/2020 02:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Priority]    Script Date: 26/11/2020 02:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Priority](
	[PriorityId] [int] IDENTITY(1,1) NOT NULL,
	[PriorityValue] [int] NOT NULL,
	[PriorityDescription] [nvarchar](50) NULL,
	[Show] [int] NULL,
 CONSTRAINT [PK_Priority] PRIMARY KEY CLUSTERED 
(
	[PriorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publish]    Script Date: 26/11/2020 02:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publish](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NULL,
	[Priority] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Video] [nvarchar](max) NOT NULL,
	[TotalShow] [int] NULL,
 CONSTRAINT [PK_Publish] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 26/11/2020 02:59:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserPassword] [nvarchar](50) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[Username] [nvarchar](50) NULL,
	[CompanyId] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([CompanyId], [CompanyName], [Address], [Mail]) VALUES (1, N'תנובה', N'22', N'1212')
INSERT [dbo].[Company] ([CompanyId], [CompanyName], [Address], [Mail]) VALUES (2, N'חיה וקסשטוק', N'הרב הירש 15', N'c0556777462@gmail.com')
SET IDENTITY_INSERT [dbo].[Company] OFF
GO
SET IDENTITY_INSERT [dbo].[Priority] ON 

INSERT [dbo].[Priority] ([PriorityId], [PriorityValue], [PriorityDescription], [Show]) VALUES (1, 1, N'גבוה', 1)
INSERT [dbo].[Priority] ([PriorityId], [PriorityValue], [PriorityDescription], [Show]) VALUES (2, 2, N'בינוני', 1)
SET IDENTITY_INSERT [dbo].[Priority] OFF
GO
SET IDENTITY_INSERT [dbo].[Publish] ON 

INSERT [dbo].[Publish] ([Id], [CompanyId], [Priority], [StartDate], [EndDate], [Video], [TotalShow]) VALUES (3, 1, 1, CAST(N'2020-12-12' AS Date), CAST(N'2020-12-13' AS Date), N'c/web', 1)
SET IDENTITY_INSERT [dbo].[Publish] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [UserPassword], [IsAdmin], [Username], [CompanyId]) VALUES (1, N'1212', 1, N'tamar', NULL)
INSERT [dbo].[Users] ([UserID], [UserPassword], [IsAdmin], [Username], [CompanyId]) VALUES (2, N'207322868', 0, N'חיה', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Publish]  WITH CHECK ADD  CONSTRAINT [FK_Publish_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Publish] CHECK CONSTRAINT [FK_Publish_Company]
GO
ALTER TABLE [dbo].[Publish]  WITH CHECK ADD  CONSTRAINT [FK_Publish_Priority] FOREIGN KEY([Priority])
REFERENCES [dbo].[Priority] ([PriorityId])
GO
ALTER TABLE [dbo].[Publish] CHECK CONSTRAINT [FK_Publish_Priority]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Company]
GO
USE [master]
GO
ALTER DATABASE [publishers] SET  READ_WRITE 
GO
