USE [master]
GO
/****** Object:  Database [tourdulich]    Script Date: 10/23/2021 11:49:10 AM ******/
CREATE DATABASE [tourdulich]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tourdulich', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\tourdulich.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'tourdulich_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\tourdulich_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [tourdulich] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [tourdulich].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [tourdulich] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [tourdulich] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [tourdulich] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [tourdulich] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [tourdulich] SET ARITHABORT OFF 
GO
ALTER DATABASE [tourdulich] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [tourdulich] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [tourdulich] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [tourdulich] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [tourdulich] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [tourdulich] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [tourdulich] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [tourdulich] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [tourdulich] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [tourdulich] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [tourdulich] SET  DISABLE_BROKER 
GO
ALTER DATABASE [tourdulich] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [tourdulich] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [tourdulich] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [tourdulich] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [tourdulich] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [tourdulich] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [tourdulich] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [tourdulich] SET RECOVERY FULL 
GO
ALTER DATABASE [tourdulich] SET  MULTI_USER 
GO
ALTER DATABASE [tourdulich] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [tourdulich] SET DB_CHAINING OFF 
GO
ALTER DATABASE [tourdulich] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [tourdulich] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [tourdulich]
GO
/****** Object:  Table [dbo].[chiphi]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiphi](
	[maChiPhi] [int] IDENTITY(1,1) NOT NULL,
	[tongChiPhi] [float] NOT NULL,
	[maSoDoan] [int] NOT NULL,
	[maLoaiChiPhi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maChiPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dangky]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangky](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maSoKhachHang] [int] NOT NULL,
	[maLoaiKhachHang] [int] NOT NULL,
	[ngayDangKy] [date] NOT NULL,
	[maSoDoan] [int] NOT NULL,
	[maSoTour] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[diadiemthamquan]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diadiemthamquan](
	[maDiaDiem] [int] IDENTITY(1,1) NOT NULL,
	[tenDiaDiem] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maDiaDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[doandulich]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doandulich](
	[maSoDoan] [int] IDENTITY(1,1) NOT NULL,
	[tenGoiDoan] [nvarchar](100) NOT NULL,
	[soLuongKhachHang] [int] NOT NULL,
	[SoLuongNhanVien] [int] NOT NULL,
	[thoiGianKhoiHanh] [datetime2](6) NOT NULL,
	[thoiGianKetThuc] [datetime2](6) NOT NULL,
	[chiTiet] [nvarchar](max) NOT NULL,
	[maTour] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoDoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[giatour]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giatour](
	[maGiaTour] [int] NOT NULL,
	[gia] [float] NOT NULL,
	[dieuKien] [nvarchar](100) NOT NULL,
	[ThoiGianBatDau] [date] NULL,
	[ThoiGianKetThuc] [date] NULL,
	[maSoTour] [int] NULL,
 CONSTRAINT [PK__giatour__3213E83F08E9F493] PRIMARY KEY CLUSTERED 
(
	[maGiaTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khachhang](
	[maSoKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[hoTenKhachHang] [nvarchar](100) NOT NULL,
	[soCMND] [nvarchar](100) NOT NULL,
	[diaChi] [nvarchar](100) NOT NULL,
	[gioiTinh] [nvarchar](100) NOT NULL,
	[SDT] [nvarchar](100) NOT NULL,
	[quocTich] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[loaichiphi]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaichiphi](
	[maLoaiChiPhi] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiChiPhi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiChiPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[loaihinhdulich]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaihinhdulich](
	[maLoaiHinhDuLich] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiHinhDuLich] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiHinhDuLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[maNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[tenNhanVien] [nvarchar](100) NOT NULL,
	[nhiemVu] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tour]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tour](
	[maSoTour] [int] IDENTITY(1,1) NOT NULL,
	[tenGoiTour] [nvarchar](100) NOT NULL,
	[dacDiem] [nvarchar](100) NOT NULL,
	[maLoaiHinhDuLich] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[thamgiadoan]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thamgiadoan](
	[maThamGia] [int] IDENTITY(1,1) NOT NULL,
	[maNhanVien] [int] NOT NULL,
	[maSoDoan] [int] NOT NULL,
	[thoiGianBatDau] [datetime2](6) NOT NULL,
	[thoiGianKetThuc] [datetime2](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maThamGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThamQuan]    Script Date: 10/23/2021 11:49:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThamQuan](
	[maSoTour] [int] NULL,
	[ThuTu] [int] NULL,
	[maDiaDiem] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[dangky] ON 

INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [maSoTour]) VALUES (1, 1, 1, CAST(N'2008-01-01' AS Date), 1, NULL)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [maSoTour]) VALUES (2, 1, 1, CAST(N'2008-01-01' AS Date), 1, NULL)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [maSoTour]) VALUES (3, 1, 1, CAST(N'2008-01-01' AS Date), 1, NULL)
SET IDENTITY_INSERT [dbo].[dangky] OFF
SET IDENTITY_INSERT [dbo].[diadiemthamquan] ON 

INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (1, N'Thiền Viện Trúc Lâm')
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (2, N'Chè Cầu Ðất')
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (3, N'Khu di tích địa đạo Củ Chi')
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (4, N'Chùa Bửu Long')
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (5, N'Núi hàm Rồng')
SET IDENTITY_INSERT [dbo].[diadiemthamquan] OFF
SET IDENTITY_INSERT [dbo].[doandulich] ON 

INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maTour]) VALUES (1, N'Ðoàn Ðại học Sài Gòn', 20, 3, CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', NULL)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maTour]) VALUES (2, N'Sài Gòn - Ðà Lạt', 20, 3, CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', NULL)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maTour]) VALUES (3, N'Ðoàn anh em cây khế', 20, 3, CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', NULL)
SET IDENTITY_INSERT [dbo].[doandulich] OFF
INSERT [dbo].[giatour] ([maGiaTour], [gia], [dieuKien], [ThoiGianBatDau], [ThoiGianKetThuc], [maSoTour]) VALUES (1, 5000000, N'Bình thường', NULL, NULL, NULL)
INSERT [dbo].[giatour] ([maGiaTour], [gia], [dieuKien], [ThoiGianBatDau], [ThoiGianKetThuc], [maSoTour]) VALUES (2, 10000000, N'Tết nguyên đán', NULL, NULL, NULL)
INSERT [dbo].[giatour] ([maGiaTour], [gia], [dieuKien], [ThoiGianBatDau], [ThoiGianKetThuc], [maSoTour]) VALUES (3, 2000000, N'Ðồng giá 2 triệu', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[khachhang] ON 

INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (1, N'Nguyễn Thị Bé Ba', N'2453453454', N'41 Nguyễn Trãi, Phường 1, Quận 5, TP HCM', N'Nữ', N'0961231232', N'Việt Nam')
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (2, N'Nguyễn Văn Nam', N'3342454443', N'41/343 Nguyễn Biểu, Phường 1, Quận 5, TP HCM', N'Nam', N'0962342343', N'Việt Nam')
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (3, N'Trần Văn', N'2939499392', N'273 An Dương Vương, Phường 3, Quận 5, TP HCM', N'Nam', N'0913332327', N'Việt Nam')
SET IDENTITY_INSERT [dbo].[khachhang] OFF
SET IDENTITY_INSERT [dbo].[loaichiphi] ON 

INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (1, N'Chi phí ăn uống')
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (2, N'Chi phí phương tiện')
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (3, N'Chi phí quà')
SET IDENTITY_INSERT [dbo].[loaichiphi] OFF
SET IDENTITY_INSERT [dbo].[loaihinhdulich] ON 

INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (1, N'Du lịch di động')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (2, N'Du lịch kết hợp nghề nghiệp')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (3, N'Du lịch xã hội và gia đình')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (4, N'Du lịch khám phá')
SET IDENTITY_INSERT [dbo].[loaihinhdulich] OFF
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (1, N'Nguyễn Ngọc Quỳnh Như', N'Thu tiền bảo kê')
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (2, N'Giang Thế Phong', N'Lơ xe')
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (3, N'Trần Trọng Ninh', N'Tài xế')
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
SET IDENTITY_INSERT [dbo].[tour] ON 

INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich]) VALUES (2, N'TP Hồ Chí Minh - Ðà Lạt', N'Rất dễ chơi', 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich]) VALUES (3, N'Phan Rang - Bình Ðịnh', N'Rất dễ choi', 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich]) VALUES (4, N'Củ Chi - TP Hồ Chí Minh', N'Rất dễ choi', 1)
SET IDENTITY_INSERT [dbo].[tour] OFF
SET IDENTITY_INSERT [dbo].[thamgiadoan] ON 

INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (1, 1, 1, CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (2, 1, 2, CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (3, 1, 3, CAST(N'2008-01-01 00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[thamgiadoan] OFF
ALTER TABLE [dbo].[chiphi]  WITH CHECK ADD  CONSTRAINT [FK_chiphi_doandulich] FOREIGN KEY([maSoDoan])
REFERENCES [dbo].[doandulich] ([maSoDoan])
GO
ALTER TABLE [dbo].[chiphi] CHECK CONSTRAINT [FK_chiphi_doandulich]
GO
ALTER TABLE [dbo].[chiphi]  WITH CHECK ADD  CONSTRAINT [FK_chiphi_loaichiphi] FOREIGN KEY([maLoaiChiPhi])
REFERENCES [dbo].[loaichiphi] ([maLoaiChiPhi])
GO
ALTER TABLE [dbo].[chiphi] CHECK CONSTRAINT [FK_chiphi_loaichiphi]
GO
ALTER TABLE [dbo].[dangky]  WITH CHECK ADD  CONSTRAINT [FK_dangky_doandulich] FOREIGN KEY([maSoDoan])
REFERENCES [dbo].[doandulich] ([maSoDoan])
GO
ALTER TABLE [dbo].[dangky] CHECK CONSTRAINT [FK_dangky_doandulich]
GO
ALTER TABLE [dbo].[dangky]  WITH CHECK ADD  CONSTRAINT [FK_dangky_khachhang] FOREIGN KEY([maSoKhachHang])
REFERENCES [dbo].[khachhang] ([maSoKhachHang])
GO
ALTER TABLE [dbo].[dangky] CHECK CONSTRAINT [FK_dangky_khachhang]
GO
ALTER TABLE [dbo].[dangky]  WITH CHECK ADD  CONSTRAINT [FK_dangky_tour] FOREIGN KEY([maSoTour])
REFERENCES [dbo].[tour] ([maSoTour])
GO
ALTER TABLE [dbo].[dangky] CHECK CONSTRAINT [FK_dangky_tour]
GO
ALTER TABLE [dbo].[doandulich]  WITH CHECK ADD  CONSTRAINT [FK_doandulich_tour] FOREIGN KEY([maTour])
REFERENCES [dbo].[tour] ([maSoTour])
GO
ALTER TABLE [dbo].[doandulich] CHECK CONSTRAINT [FK_doandulich_tour]
GO
ALTER TABLE [dbo].[giatour]  WITH CHECK ADD  CONSTRAINT [FK_giatour_tour] FOREIGN KEY([maSoTour])
REFERENCES [dbo].[tour] ([maSoTour])
GO
ALTER TABLE [dbo].[giatour] CHECK CONSTRAINT [FK_giatour_tour]
GO
ALTER TABLE [dbo].[tour]  WITH CHECK ADD  CONSTRAINT [FK_tour_loaihinhdulich] FOREIGN KEY([maLoaiHinhDuLich])
REFERENCES [dbo].[loaihinhdulich] ([maLoaiHinhDuLich])
GO
ALTER TABLE [dbo].[tour] CHECK CONSTRAINT [FK_tour_loaihinhdulich]
GO
ALTER TABLE [dbo].[thamgiadoan]  WITH CHECK ADD  CONSTRAINT [FK_thamgiadoan_doandulich] FOREIGN KEY([maSoDoan])
REFERENCES [dbo].[doandulich] ([maSoDoan])
GO
ALTER TABLE [dbo].[thamgiadoan] CHECK CONSTRAINT [FK_thamgiadoan_doandulich]
GO
ALTER TABLE [dbo].[thamgiadoan]  WITH CHECK ADD  CONSTRAINT [FK_thamgiadoan_nhanvien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[nhanvien] ([maNhanVien])
GO
ALTER TABLE [dbo].[thamgiadoan] CHECK CONSTRAINT [FK_thamgiadoan_nhanvien]
GO
ALTER TABLE [dbo].[ThamQuan]  WITH CHECK ADD  CONSTRAINT [FK_ThamQuan_diadiemthamquan] FOREIGN KEY([maDiaDiem])
REFERENCES [dbo].[diadiemthamquan] ([maDiaDiem])
GO
ALTER TABLE [dbo].[ThamQuan] CHECK CONSTRAINT [FK_ThamQuan_diadiemthamquan]
GO
ALTER TABLE [dbo].[ThamQuan]  WITH CHECK ADD  CONSTRAINT [FK_ThamQuan_tour] FOREIGN KEY([maSoTour])
REFERENCES [dbo].[tour] ([maSoTour])
GO
ALTER TABLE [dbo].[ThamQuan] CHECK CONSTRAINT [FK_ThamQuan_tour]
GO
USE [master]
GO
ALTER DATABASE [tourdulich] SET  READ_WRITE 
GO
