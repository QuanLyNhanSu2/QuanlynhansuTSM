USE [master]
GO
/****** Object:  Database [Quanlynhansu]    Script Date: 2/16/2017 8:44:20 AM ******/
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
/****** Object:  Table [dbo].[Baohiem]    Script Date: 2/16/2017 8:44:20 AM ******/
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
/****** Object:  Table [dbo].[Chucvu]    Script Date: 2/16/2017 8:44:21 AM ******/
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
/****** Object:  Table [dbo].[CTHopdong]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHopdong](
	[CTHopdongID] [int] IDENTITY(1,1) NOT NULL,
	[NhanvienID] [int] NULL,
	[HopdongID] [int] NULL,
	[Ngaybatdau] [datetime] NULL,
	[Ngayketthuc] [datetime] NULL,
	[Luongcoban] [float] NULL,
 CONSTRAINT [PK_CTHopdong] PRIMARY KEY CLUSTERED 
(
	[CTHopdongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTKhenthuong]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTKhenthuong](
	[CTKhenthuongID] [int] IDENTITY(1,1) NOT NULL,
	[Ngayquyetdinh] [datetime] NULL,
	[NhanvienID] [int] NULL,
	[KhenthuongID] [int] NULL,
	[Noidung] [nvarchar](200) NULL,
	[Hinhthuc] [nvarchar](200) NULL,
 CONSTRAINT [PK_CTKhenthuong] PRIMARY KEY CLUSTERED 
(
	[CTKhenthuongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTKyluat]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTKyluat](
	[CTKyluatID] [int] IDENTITY(1,1) NOT NULL,
	[KyluatID] [int] NULL,
	[NhanvienID] [int] NULL,
	[Ngaykyluat] [datetime] NULL,
	[Hinhthuc] [nvarchar](200) NULL,
	[Nguyennhan] [nvarchar](200) NULL,
 CONSTRAINT [PK_CTKyluat] PRIMARY KEY CLUSTERED 
(
	[CTKyluatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTNgoaingu]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTNgoaingu](
	[CTNgoainguID] [int] IDENTITY(1,1) NOT NULL,
	[NhanvienID] [int] NULL,
	[NgoainguID] [int] NULL,
	[Trinhdo] [nvarchar](50) NULL,
 CONSTRAINT [PK_CTNgoaingu] PRIMARY KEY CLUSTERED 
(
	[CTNgoainguID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTTrinhdo]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTTrinhdo](
	[CTTrinhdoID] [int] IDENTITY(1,1) NOT NULL,
	[NhanvienID] [int] NULL,
	[TrinhdoID] [int] NULL,
	[Chuyenmon] [nvarchar](50) NULL,
	[Ngaycap] [datetime] NULL,
	[Truong] [nvarchar](50) NULL,
 CONSTRAINT [PK_CTTrinhdo] PRIMARY KEY CLUSTERED 
(
	[CTTrinhdoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dantoc]    Script Date: 2/16/2017 8:44:21 AM ******/
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
/****** Object:  Table [dbo].[Hopdong]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hopdong](
	[HopdongID] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Hopdong] PRIMARY KEY CLUSTERED 
(
	[HopdongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khenthuong]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khenthuong](
	[KhenthuongID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khenthuong] PRIMARY KEY CLUSTERED 
(
	[KhenthuongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kyluat]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kyluat](
	[KyluatID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kyluat] PRIMARY KEY CLUSTERED 
(
	[KyluatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Luong]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luong](
	[LuongID] [int] IDENTITY(1,1) NOT NULL,
	[NhanvienID] [int] NULL,
	[PhongbanID] [int] NULL,
	[Thang] [int] NULL,
	[Nam] [int] NULL,
	[Luongcoban] [float] NULL,
	[Songaytangca] [int] NULL,
	[Luongtangca] [float] NULL,
	[Tienbaohiem] [float] NULL,
	[Thuclanh] [float] NULL,
 CONSTRAINT [PK_Luong] PRIMARY KEY CLUSTERED 
(
	[LuongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ngoaingu]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ngoaingu](
	[NgoainguID] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ngoaingu] PRIMARY KEY CLUSTERED 
(
	[NgoainguID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nguoidung]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nguoidung](
	[NguoidungID] [int] IDENTITY(1,1) NOT NULL,
	[NhanvienID] [int] NULL,
	[PhanquyenID] [int] NULL,
	[Matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_Nguoidung] PRIMARY KEY CLUSTERED 
(
	[NguoidungID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 2/16/2017 8:44:21 AM ******/
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
	[BaohiemID] [varchar](50) NULL,
	[SotheATM] [varchar](20) NULL,
	[DantocID] [int] NULL,
	[TongiaoID] [int] NULL,
	[PhongbanID] [int] NULL,
	[ChucvuID] [int] NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[NhanvienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phanquyen]    Script Date: 2/16/2017 8:44:21 AM ******/
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
/****** Object:  Table [dbo].[Phongban]    Script Date: 2/16/2017 8:44:21 AM ******/
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
/****** Object:  Table [dbo].[Tongiao]    Script Date: 2/16/2017 8:44:21 AM ******/
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
/****** Object:  Table [dbo].[Trinhdo]    Script Date: 2/16/2017 8:44:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trinhdo](
	[TrinhdoID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_Trinhdo] PRIMARY KEY CLUSTERED 
(
	[TrinhdoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CTHopdong]  WITH CHECK ADD  CONSTRAINT [FK_CTHopdong_Hopdong] FOREIGN KEY([HopdongID])
REFERENCES [dbo].[Hopdong] ([HopdongID])
GO
ALTER TABLE [dbo].[CTHopdong] CHECK CONSTRAINT [FK_CTHopdong_Hopdong]
GO
ALTER TABLE [dbo].[CTHopdong]  WITH CHECK ADD  CONSTRAINT [FK_CTHopdong_Nhanvien] FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[CTHopdong] CHECK CONSTRAINT [FK_CTHopdong_Nhanvien]
GO
ALTER TABLE [dbo].[CTKhenthuong]  WITH CHECK ADD  CONSTRAINT [FK_CTKhenthuong_Khenthuong] FOREIGN KEY([KhenthuongID])
REFERENCES [dbo].[Khenthuong] ([KhenthuongID])
GO
ALTER TABLE [dbo].[CTKhenthuong] CHECK CONSTRAINT [FK_CTKhenthuong_Khenthuong]
GO
ALTER TABLE [dbo].[CTKhenthuong]  WITH CHECK ADD  CONSTRAINT [FK_CTKhenthuong_Nhanvien] FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[CTKhenthuong] CHECK CONSTRAINT [FK_CTKhenthuong_Nhanvien]
GO
ALTER TABLE [dbo].[CTKyluat]  WITH CHECK ADD  CONSTRAINT [FK_CTKyluat_Kyluat] FOREIGN KEY([KyluatID])
REFERENCES [dbo].[Kyluat] ([KyluatID])
GO
ALTER TABLE [dbo].[CTKyluat] CHECK CONSTRAINT [FK_CTKyluat_Kyluat]
GO
ALTER TABLE [dbo].[CTKyluat]  WITH CHECK ADD  CONSTRAINT [FK_CTKyluat_Nhanvien] FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[CTKyluat] CHECK CONSTRAINT [FK_CTKyluat_Nhanvien]
GO
ALTER TABLE [dbo].[CTNgoaingu]  WITH CHECK ADD  CONSTRAINT [FK_CTNgoaingu_Ngoaingu] FOREIGN KEY([NgoainguID])
REFERENCES [dbo].[Ngoaingu] ([NgoainguID])
GO
ALTER TABLE [dbo].[CTNgoaingu] CHECK CONSTRAINT [FK_CTNgoaingu_Ngoaingu]
GO
ALTER TABLE [dbo].[CTNgoaingu]  WITH CHECK ADD  CONSTRAINT [FK_CTNgoaingu_Nhanvien] FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[CTNgoaingu] CHECK CONSTRAINT [FK_CTNgoaingu_Nhanvien]
GO
ALTER TABLE [dbo].[CTTrinhdo]  WITH CHECK ADD  CONSTRAINT [FK_CTTrinhdo_Nhanvien] FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[CTTrinhdo] CHECK CONSTRAINT [FK_CTTrinhdo_Nhanvien]
GO
ALTER TABLE [dbo].[CTTrinhdo]  WITH CHECK ADD  CONSTRAINT [FK_CTTrinhdo_Trinhdo] FOREIGN KEY([TrinhdoID])
REFERENCES [dbo].[Trinhdo] ([TrinhdoID])
GO
ALTER TABLE [dbo].[CTTrinhdo] CHECK CONSTRAINT [FK_CTTrinhdo_Trinhdo]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_Nhanvien] FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_Nhanvien]
GO
ALTER TABLE [dbo].[Luong]  WITH CHECK ADD  CONSTRAINT [FK_Luong_Phongban] FOREIGN KEY([PhongbanID])
REFERENCES [dbo].[Phongban] ([PhongbanID])
GO
ALTER TABLE [dbo].[Luong] CHECK CONSTRAINT [FK_Luong_Phongban]
GO
ALTER TABLE [dbo].[Nguoidung]  WITH CHECK ADD  CONSTRAINT [FK_Nguoidung_Nhanvien] FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
ALTER TABLE [dbo].[Nguoidung] CHECK CONSTRAINT [FK_Nguoidung_Nhanvien]
GO
ALTER TABLE [dbo].[Nguoidung]  WITH CHECK ADD  CONSTRAINT [FK_Nguoidung_Phanquyen] FOREIGN KEY([PhanquyenID])
REFERENCES [dbo].[Phanquyen] ([PhanquyenID])
GO
ALTER TABLE [dbo].[Nguoidung] CHECK CONSTRAINT [FK_Nguoidung_Phanquyen]
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
USE [master]
GO
ALTER DATABASE [Quanlynhansu] SET  READ_WRITE 
GO
