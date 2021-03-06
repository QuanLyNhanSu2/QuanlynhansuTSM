CREATE DATABASE QUANLYNHANSU
GO

USE [QUANLYNHANSU]
GO
/****** Object:  Table [dbo].[Phongban]    Script Date: 03/19/2017 00:17:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phongban](
	[PhongbanID] [int] IDENTITY(1,1) NOT NULL,
	[Tenphongban] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Dienthoai] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[PhongbanID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Phongban] ON
INSERT [dbo].[Phongban] ([PhongbanID], [Tenphongban], [Diachi], [Dienthoai]) VALUES (1, N'Kế hoạch', N'H9-201', N'02103746281')
INSERT [dbo].[Phongban] ([PhongbanID], [Tenphongban], [Diachi], [Dienthoai]) VALUES (2, N'Tài chính', N'H9-312', N'02101827396')
INSERT [dbo].[Phongban] ([PhongbanID], [Tenphongban], [Diachi], [Dienthoai]) VALUES (3, N'Kế toán', N'H5-308', N'02105812048')
INSERT [dbo].[Phongban] ([PhongbanID], [Tenphongban], [Diachi], [Dienthoai]) VALUES (4, N'Giám đốc', N'H3-219', N'02102476184')
INSERT [dbo].[Phongban] ([PhongbanID], [Tenphongban], [Diachi], [Dienthoai]) VALUES (5, N'Nhân sự', N'H6-512', N'02101987294')
INSERT [dbo].[Phongban] ([PhongbanID], [Tenphongban], [Diachi], [Dienthoai]) VALUES (6, N'Tiếp thị', N'H5-123', N'0210284736')
SET IDENTITY_INSERT [dbo].[Phongban] OFF
/****** Object:  Table [dbo].[Nhomquyen]    Script Date: 03/19/2017 00:17:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhomquyen](
	[NhomquyenID] [int] IDENTITY(1,1) NOT NULL,
	[Tenquyen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[NhomquyenID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Nhomquyen] ON
INSERT [dbo].[Nhomquyen] ([NhomquyenID], [Tenquyen]) VALUES (1, N'Quản trị tối cao')
INSERT [dbo].[Nhomquyen] ([NhomquyenID], [Tenquyen]) VALUES (2, N'Người điều hành chung')
INSERT [dbo].[Nhomquyen] ([NhomquyenID], [Tenquyen]) VALUES (3, N'Người điều hành module')
INSERT [dbo].[Nhomquyen] ([NhomquyenID], [Tenquyen]) VALUES (4, N'Thành viên')
INSERT [dbo].[Nhomquyen] ([NhomquyenID], [Tenquyen]) VALUES (5, N'Khách truy cập')
SET IDENTITY_INSERT [dbo].[Nhomquyen] OFF
/****** Object:  Table [dbo].[Chucvu]    Script Date: 03/19/2017 00:17:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chucvu](
	[ChucvuID] [int] IDENTITY(1,1) NOT NULL,
	[Tenchucvu] [nvarchar](50) NULL,
	[Mota] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[ChucvuID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Chucvu] ON
INSERT [dbo].[Chucvu] ([ChucvuID], [Tenchucvu], [Mota]) VALUES (1, N'Nhân viên', N'Nhân viên làm việc cho công ty')
INSERT [dbo].[Chucvu] ([ChucvuID], [Tenchucvu], [Mota]) VALUES (2, N'Tổng giám đốc', N'Chịu trách nhiệm toàn bộ các vấn đề thuộc Tổng giám đốc')
INSERT [dbo].[Chucvu] ([ChucvuID], [Tenchucvu], [Mota]) VALUES (3, N'Trưởng phòng nhân sự', N'Quản trị nguồn nhân lực trong công ty')
INSERT [dbo].[Chucvu] ([ChucvuID], [Tenchucvu], [Mota]) VALUES (4, N'Trưởng phòng tài chính', N'Quản trị nguồn tài chính của công ty')
INSERT [dbo].[Chucvu] ([ChucvuID], [Tenchucvu], [Mota]) VALUES (5, N'Trưởng phòng tiếp thị ', N'Hoạch định chiến lược kinh doanh và tiếp thị của công ty')
INSERT [dbo].[Chucvu] ([ChucvuID], [Tenchucvu], [Mota]) VALUES (6, N'Kế toán trưởng', N'Quản lý chung, trông coi (kiểm soát) mọi hoạt động có liên quan đến lĩnh vực tài chính, kế toán')
INSERT [dbo].[Chucvu] ([ChucvuID], [Tenchucvu], [Mota]) VALUES (7, N'Trưởng phòng kế hoạch', N'Vạch ra kế hoạch của công ty')
SET IDENTITY_INSERT [dbo].[Chucvu] OFF
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 03/19/2017 00:17:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[TaikhoanID] [int] IDENTITY(1,1) NOT NULL,
	[NhomquyenID] [int] NULL,
	[Tentaikhoan] [varchar](20) NULL,
	[Matkhau] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[TaikhoanID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Taikhoan] ON
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (1, 2, N'HVKTQS', N'123456')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (2, 3, N'TH13C', N'456789')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (3, 1, N'ADMIN', N'111111')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (4, 2, N'MTA', N'222222')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (5, 5, N'TSM', N'333333')
INSERT [dbo].[Taikhoan] ([TaikhoanID], [NhomquyenID], [Tentaikhoan], [Matkhau]) VALUES (6, 3, N'QLNS', N'444444')
SET IDENTITY_INSERT [dbo].[Taikhoan] OFF
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 03/19/2017 00:17:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[NhanvienID] [int] NOT NULL,
	[PhongbanID] [int] NULL,
	[ChucvuID] [int] NULL,
	[Tennhanvien] [nvarchar](50) NULL,
	[Gioitinh] [bit] NULL,
	[SoCMND] [varchar](20) NULL,
	[Ngaysinh] [datetime] NULL,
	[Noisinh] [nvarchar](50) NULL,
	[Dienthoai] [varchar](20) NULL,
	[Dantoc] [nvarchar](50) NULL,
	[Tongiao] [nvarchar](50) NULL,
	[Ghichu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[NhanvienID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Nhanvien] ([NhanvienID], [PhongbanID], [ChucvuID], [Tennhanvien], [Gioitinh], [SoCMND], [Ngaysinh], [Noisinh], [Dienthoai], [Dantoc], [Tongiao], [Ghichu]) VALUES (1, 3, 6, N'Ngô Xuân Dương', 1, N'123456789', CAST(0x000088F700000000 AS DateTime), NULL, N'01647564853', N'Kinh', N'Không', NULL)
INSERT [dbo].[Nhanvien] ([NhanvienID], [PhongbanID], [ChucvuID], [Tennhanvien], [Gioitinh], [SoCMND], [Ngaysinh], [Noisinh], [Dienthoai], [Dantoc], [Tongiao], [Ghichu]) VALUES (2, 4, 2, N'Ninh Thị Nguyên', 0, N'342343443', CAST(0x0000891900000000 AS DateTime), NULL, N'01928473554', N'Kinh', N'Không', NULL)
INSERT [dbo].[Nhanvien] ([NhanvienID], [PhongbanID], [ChucvuID], [Tennhanvien], [Gioitinh], [SoCMND], [Ngaysinh], [Noisinh], [Dienthoai], [Dantoc], [Tongiao], [Ghichu]) VALUES (3, 2, 4, N'Phí Thị Kim Liên', 0, N'343242343', CAST(0x0000892C00000000 AS DateTime), NULL, N'01284637465', N'Kinh', N'Không', NULL)
INSERT [dbo].[Nhanvien] ([NhanvienID], [PhongbanID], [ChucvuID], [Tennhanvien], [Gioitinh], [SoCMND], [Ngaysinh], [Noisinh], [Dienthoai], [Dantoc], [Tongiao], [Ghichu]) VALUES (4, 5, 3, N'Đào Văn Tuyền', 1, N'786587657', CAST(0x0000895700000000 AS DateTime), N'Hải Dương', N'01648191811', N'Kinh', N'Không', NULL)
INSERT [dbo].[Nhanvien] ([NhanvienID], [PhongbanID], [ChucvuID], [Tennhanvien], [Gioitinh], [SoCMND], [Ngaysinh], [Noisinh], [Dienthoai], [Dantoc], [Tongiao], [Ghichu]) VALUES (5, 6, 5, N'Hà Thị Quyết', 0, N'433243232', CAST(0x000089B300000000 AS DateTime), NULL, N'01234827467', N'Kinh', N'Không', NULL)
INSERT [dbo].[Nhanvien] ([NhanvienID], [PhongbanID], [ChucvuID], [Tennhanvien], [Gioitinh], [SoCMND], [Ngaysinh], [Noisinh], [Dienthoai], [Dantoc], [Tongiao], [Ghichu]) VALUES (6, 1, 7, N'Nguyễn Đức Mạnh', 1, N'213214334', CAST(0x000089F600000000 AS DateTime), N'Phú Thọ', N'0986747373', N'Kinh', N'Không', NULL)
/****** Object:  Table [dbo].[Taikhoan_Nhanvien]    Script Date: 03/19/2017 00:17:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan_Nhanvien](
	[TaikhoanID] [int] NULL,
	[NhanvienID] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (3, 2)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (2, 1)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (6, 3)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (1, 4)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (2, 5)
INSERT [dbo].[Taikhoan_Nhanvien] ([TaikhoanID], [NhanvienID]) VALUES (4, 6)
/****** Object:  ForeignKey [FK__Nhanvien__Chucvu__09DE7BCC]    Script Date: 03/19/2017 00:17:11 ******/
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD FOREIGN KEY([ChucvuID])
REFERENCES [dbo].[Chucvu] ([ChucvuID])
GO
/****** Object:  ForeignKey [FK__Nhanvien__Phongb__08EA5793]    Script Date: 03/19/2017 00:17:11 ******/
ALTER TABLE [dbo].[Nhanvien]  WITH CHECK ADD FOREIGN KEY([PhongbanID])
REFERENCES [dbo].[Phongban] ([PhongbanID])
GO
/****** Object:  ForeignKey [FK__Taikhoan__Nhomqu__1273C1CD]    Script Date: 03/19/2017 00:17:11 ******/
ALTER TABLE [dbo].[Taikhoan]  WITH CHECK ADD FOREIGN KEY([NhomquyenID])
REFERENCES [dbo].[Nhomquyen] ([NhomquyenID])
GO
/****** Object:  ForeignKey [FK__Taikhoan___Nhanv__15502E78]    Script Date: 03/19/2017 00:17:11 ******/
ALTER TABLE [dbo].[Taikhoan_Nhanvien]  WITH CHECK ADD FOREIGN KEY([NhanvienID])
REFERENCES [dbo].[Nhanvien] ([NhanvienID])
GO
/****** Object:  ForeignKey [FK__Taikhoan___Taikh__145C0A3F]    Script Date: 03/19/2017 00:17:11 ******/
ALTER TABLE [dbo].[Taikhoan_Nhanvien]  WITH CHECK ADD FOREIGN KEY([TaikhoanID])
REFERENCES [dbo].[Taikhoan] ([TaikhoanID])
GO
