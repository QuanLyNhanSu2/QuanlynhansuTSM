USE [master]
GO
/****** Object:  Database [Quanlynhansu]    Script Date: 2/16/2017 9:35:44 AM ******/
CREATE DATABASE [Quanlynhansu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quanlynhansu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DUONGTHAN\MSSQL\DATA\Quanlynhansu.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Quanlynhansu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DUONGTHAN\MSSQL\DATA\Quanlynhansu_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Quanlynhansu] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanlynhansu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanlynhansu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quanlynhansu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quanlynhansu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quanlynhansu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quanlynhansu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quanlynhansu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quanlynhansu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quanlynhansu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quanlynhansu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quanlynhansu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quanlynhansu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quanlynhansu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quanlynhansu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quanlynhansu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quanlynhansu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quanlynhansu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quanlynhansu] SET  MULTI_USER 
GO
ALTER DATABASE [Quanlynhansu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quanlynhansu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quanlynhansu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quanlynhansu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Quanlynhansu] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Quanlynhansu]
GO
/****** Object:  Table [dbo].[Baohiem]    Script Date: 2/16/2017 9:35:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Baohiem](
	[BaohiemID] [varchar](50) NOT NULL,
	[Ngaycap] [datetime] NULL,
	[Ngayhethan] [datetime] NULL,
	[Noicap] [nvarchar](50) NULL,
 CONSTRAINT [PK_Baohiem] PRIMARY KEY CLUSTERED 
(
	[BaohiemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Chucvu]    Script Date: 2/16/2017 9:35:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chucvu](
	[ChucvuID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Luongcoban] [float] NULL,
 CONSTRAINT [PK_Chucvu] PRIMARY KEY CLUSTERED 
(
	[ChucvuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dantoc]    Script Date: 2/16/2017 9:35:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dantoc](
	[DantocID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Dantoc] PRIMARY KEY CLUSTERED 
(
	[DantocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 2/16/2017 9:35:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[NhanvienID] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](50) NULL,
	[SoCMND] [int] NULL,
	[Ngaysinh] [datetime] NULL,
	[Noisinh] [nvarchar](50) NULL,
	[Dienthoai] [varchar](20) NULL,
	[Hokhau] [nvarchar](50) NULL,
	[Choohiennay] [nvarchar](100) NULL,
	[Ngayvaolam] [datetime] NULL,
	[SotheATM] [varchar](20) NULL,
	[DantocID] [int] NULL,
	[TongiaoID] [int] NULL,
	[PhongbanID] [int] NULL,
	[ChucvuID] [int] NULL,
	[BaohiemID] [varchar](50) NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[NhanvienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phanquyen]    Script Date: 2/16/2017 9:35:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phanquyen](
	[PhanquyenID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Phanquyen] PRIMARY KEY CLUSTERED 
(
	[PhanquyenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phongban]    Script Date: 2/16/2017 9:35:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phongban](
	[PhongbanID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Dienthoai] [varchar](50) NULL,
	[Fax] [varchar](50) NULL,
 CONSTRAINT [PK_Phongban] PRIMARY KEY CLUSTERED 
(
	[PhongbanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tongiao]    Script Date: 2/16/2017 9:35:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tongiao](
	[TongiaoID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tongiao] PRIMARY KEY CLUSTERED 
(
	[TongiaoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 2/16/2017 9:35:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[PhanquyenID] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Baohiem] FOREIGN KEY([BaohiemID])
REFERENCES [dbo].[Baohiem] ([BaohiemID])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Baohiem]
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Chucvu] FOREIGN KEY([ChucvuID])
REFERENCES [dbo].[Chucvu] ([ChucvuID])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Chucvu]
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Dantoc] FOREIGN KEY([DantocID])
REFERENCES [dbo].[Dantoc] ([DantocID])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Dantoc]
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Phongban] FOREIGN KEY([PhongbanID])
REFERENCES [dbo].[Phongban] ([PhongbanID])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Phongban]
GO
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_Nhanvien_Tongiao] FOREIGN KEY([TongiaoID])
REFERENCES [dbo].[Tongiao] ([TongiaoID])
GO
ALTER TABLE [dbo].[Nhanvien] CHECK CONSTRAINT [FK_Nhanvien_Tongiao]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Phanquyen] FOREIGN KEY([PhanquyenID])
REFERENCES [dbo].[Phanquyen] ([PhanquyenID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Phanquyen]
GO
USE [master]
GO
ALTER DATABASE [Quanlynhansu] SET  READ_WRITE 
GO
