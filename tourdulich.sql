USE [master]
GO
/****** Object:  Database [tourdulich]    Script Date: 01/12/2021 6:23:20 AM ******/
CREATE DATABASE [tourdulich]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tourdulich', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\tourdulich.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tourdulich_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\tourdulich_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
/****** Object:  Table [dbo].[chiphi]    Script Date: 01/12/2021 6:23:20 AM ******/
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
/****** Object:  Table [dbo].[dangky]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangky](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maSoKhachHang] [int] NOT NULL,
	[maTour] [int] NOT NULL,
	[maLoaiKhachHang] [int] NOT NULL,
	[ngayDangKy] [date] NOT NULL,
	[maSoDoan] [int] NOT NULL,
	[soLuongKhachHang] [int] NULL,
	[giaTourDangKy] [float] NULL,
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diadiemden]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diadiemden](
	[maDiaDiemDen] [int] IDENTITY(1,1) NOT NULL,
	[tenDiaDiemDen] [nvarchar](255) NOT NULL,
	[trangThai] [int] NOT NULL,
 CONSTRAINT [PK__diadiemd__9959D07E25BD4227] PRIMARY KEY CLUSTERED 
(
	[maDiaDiemDen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diadiemthamquan]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diadiemthamquan](
	[maDiaDiem] [int] IDENTITY(1,1) NOT NULL,
	[tenDiaDiem] [nvarchar](100) NOT NULL,
	[maDiaDiemDen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maDiaDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diadiemtour]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diadiemtour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maTour] [int] NOT NULL,
	[tenDiaDiemThamQuan] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doandulich]    Script Date: 01/12/2021 6:23:20 AM ******/
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
	[maSoTour] [int] NOT NULL,
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoDoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giatour]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giatour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maGiaTour] [int] NOT NULL,
	[gia] [float] NOT NULL,
	[dieuKien] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 01/12/2021 6:23:20 AM ******/
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
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaichiphi]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaichiphi](
	[maLoaiChiPhi] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiChiPhi] [nvarchar](100) NOT NULL,
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiChiPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaihinhdulich]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaihinhdulich](
	[maLoaiHinhDuLich] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiHinhDuLich] [nvarchar](100) NOT NULL,
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiHinhDuLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[loaikhachhang]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaikhachhang](
	[maLoaiKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiKhachHang] [nvarchar](100) NOT NULL,
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[maNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[tenNhanVien] [nvarchar](100) NOT NULL,
	[nhiemVu] [nvarchar](100) NOT NULL,
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thamgiadoan]    Script Date: 01/12/2021 6:23:20 AM ******/
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
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maThamGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tour]    Script Date: 01/12/2021 6:23:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tour](
	[maSoTour] [int] IDENTITY(1,1) NOT NULL,
	[tenGoiTour] [nvarchar](100) NOT NULL,
	[dacDiem] [nvarchar](100) NOT NULL,
	[maLoaiHinhDuLich] [int] NOT NULL,
	[thoiGianBatDau] [datetime2](6) NOT NULL,
	[thoiGianKetThuc] [datetime2](6) NOT NULL,
	[maDiaDiemDen] [int] NULL,
	[idGiaTour] [int] NULL,
	[trangThai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[dangky] ON 

INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (2001, 2, 6, 2, CAST(N'2021-12-02' AS Date), 2001, 23, NULL, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (2002, 1, 6, 2, CAST(N'2021-11-30' AS Date), 2001, 10, NULL, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3001, 3, 5, 1, CAST(N'2021-11-30' AS Date), 1004, 1, NULL, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3002, 2, 6, 2, CAST(N'2021-11-30' AS Date), 2001, 3, NULL, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3006, 2, 6, 2, CAST(N'2021-12-01' AS Date), 2001, 2, NULL, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3007, 2, 6, 2, CAST(N'2021-12-10' AS Date), 2001, 3, NULL, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3008, 3, 6, 2, CAST(N'2021-12-01' AS Date), 2001, 3, 200000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3009, 2, 5, 2, CAST(N'2021-12-01' AS Date), 1004, 3, 1000000, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3010, 1, 5, 1, CAST(N'2021-12-01' AS Date), 1004, 1, 1000000, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3011, 1, 5, 1, CAST(N'2021-12-01' AS Date), 1004, 1, 1000000, 0)
SET IDENTITY_INSERT [dbo].[dangky] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemden] ON 

INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (1, N'Đà Lạt', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (2, N'Củ Chi', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (3, N'TP Hồ Chí Minh', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (4, N'Sa Pa', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (1001, N'Hà Nội', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (1002, N'Xin Chào', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (1003, N'nmmm', 0)
SET IDENTITY_INSERT [dbo].[diadiemden] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemthamquan] ON 

INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3, N'Khu di tích địa đạo Củ Chi', 2)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (4, N'Chùa Bửu Long', 3)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (5, N'Núi hàm Rồng', 4)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (1001, N'Hồ Tây', 1001)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (1002, N'Hồ Gươm', 1001)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (1003, N'new dia diem', 1002)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (1004, N'alohahah', 1002)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (1005, N'alokkv', 1002)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (1006, N'nmnm', 1003)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2010, N'Thiền Viện Trúc Lâm', 1)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2011, N'Chè Cầu Ðất', 1)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2012, N'Hồ Xuân Hương', 1)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2013, N'Bưu điện Đà Lạt', 1)
SET IDENTITY_INSERT [dbo].[diadiemthamquan] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemtour] ON 

INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (14, 8, N'Chùa Bửu Long')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (20, 9, N'Thiền Viện Trúc Lâm')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (21, 9, N'Chè Cầu Ðất')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (23, 10, N'Thiền Viện Trúc Lâm')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (24, 10, N'Hồ Xuân Hương')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (1006, 7, N'Thiền Viện Trúc Lâm')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (1007, 7, N'Hồ Xuân Hương')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (1008, 6, N'Chùa Bửu Long')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (1011, 11, N'Thiền Viện Trúc Lâm')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (1012, 11, N'Chè Cầu Ðất')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (2006, 11, N'Chùa Bửu Long')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (3006, 5, N'Chè Cầu Ðất')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (3007, 5, N'Hồ Xuân Hương')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (3008, 5, N'Bưu điện Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4006, 2007, N'Khu di tích địa đạo Củ Chi')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4007, 2005, N'Chùa Bửu Long')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4008, 2006, N'Chè Cầu Ðất')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4009, 2006, N'Bưu điện Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4023, 3009, N'Núi hàm Rồng')
SET IDENTITY_INSERT [dbo].[diadiemtour] OFF
GO
SET IDENTITY_INSERT [dbo].[doandulich] ON 

INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (1, N'Ðoàn Ðại học Sài Gòn', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', 1, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (2, N'Sài Gòn - Ðà Lạt', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', 2, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (3, N'Ðoàn anh em cây khế', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', 3, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (1004, N'alone', 25, 10, CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-23T12:00:00.0000000' AS DateTime2), N'alone', 5, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (1005, N'ccccvc', 22, 10, CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), N'cvcvcvcv', 5, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (1006, N'vvvvvvvvv', 22, 10, CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), N'vvvvvvvvv', 5, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (1007, N'vvvvvvvv', 22, 10, CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), N'vvvvvvvvvvvvvvvv', 5, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (1008, N'bbbbbbbbb', 22, 10, CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), N'bbbbbbbb', 5, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (1009, N'qqqqqqqqq', 22, 10, CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), N'qqqqqqqqq', 5, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (2001, N'Traveloka staff', 30, 10, CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), N'vvvvvvvvvvvvvvvv', 6, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (3001, N'ecccccc', 22, 10, CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-20T12:00:00.0000000' AS DateTime2), N'vvvvvvvvvvvvvvvv', 3005, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (3002, N'eccccc', 22, 10, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), N'eccccc', 2006, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (3004, N'xxxxxxx', 0, 0, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), N'xxxxxxxxxx', 6, 1)
SET IDENTITY_INSERT [dbo].[doandulich] OFF
GO
SET IDENTITY_INSERT [dbo].[giatour] ON 

INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (1, 1, 5000000, N'Bình thường')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (4, 1, 2000000, N'cũng bình thường thôi mà thêm option nữa')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (5, 5, 1000000, N'mới')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (6, 6, 200000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (7, 7, 250000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (8, 8, 1231232, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (9, 9, 122222, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (10, 10, 10000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (1001, 11, 344545, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (2001, 11, 4534, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3001, 2007, 1000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3002, 2006, 10000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3005, 3009, 33000, N'mới tạo')
SET IDENTITY_INSERT [dbo].[giatour] OFF
GO
SET IDENTITY_INSERT [dbo].[khachhang] ON 

INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (1, N'Nguyễn Thị Bé Ba', N'2453453454', N'41 Nguyễn Trãi, Phường 1, Quận 5, TP HCM', N'Nữ', N'0961231232', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2, N'Nguyễn Văn Nam', N'3342454443', N'41/343 Nguyễn Biểu, Phường 1, Quận 5, TP HCM', N'Nam', N'0962342343', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (3, N'NInh dap trai1', N'2939499392', N'273 An Dương Vương, Phường 3, Quận 5, TP HCM', N'Nam', N'0913332327', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (1001, N'cccccccc', N'999999999', N'cccccccccccc', N'Nữ', N'0123456789', N'cccccccccccc', 1)
SET IDENTITY_INSERT [dbo].[khachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[loaichiphi] ON 

INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (1, N'Chi phí ăn uống', 1)
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (2, N'Chi phí phương tiện', 1)
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (3, N'Chi phí quà', 1)
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (1001, N'Chi phí best', 1)
SET IDENTITY_INSERT [dbo].[loaichiphi] OFF
GO
SET IDENTITY_INSERT [dbo].[loaihinhdulich] ON 

INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1, N'Du lịch di động', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (2, N'Du lịch kết hợp nghề nghiệp', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (3, N'Du lịch xã hội và gia đình', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (4, N'Du lịch khám phá', 1)
SET IDENTITY_INSERT [dbo].[loaihinhdulich] OFF
GO
SET IDENTITY_INSERT [dbo].[loaikhachhang] ON 

INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang], [trangThai]) VALUES (1, N'Cá nhân', 1)
INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang], [trangThai]) VALUES (2, N'Ðơn vị', 1)
SET IDENTITY_INSERT [dbo].[loaikhachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (1, N'Nguyễn Ngọc Quỳnh Như', N'Thu tiền bảo kê', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2, N'Giang Thế Phong', N'Lơ xe', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3, N'Trần Trọng Ninh', N'Tài xế', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (1001, N'xxxx', N'xxxx', 0)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2001, N'xxx', N'xxxx', 1)
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
GO
SET IDENTITY_INSERT [dbo].[thamgiadoan] ON 

INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1, 1, 1, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (2, 1, 2, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3, 1, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[thamgiadoan] OFF
GO
SET IDENTITY_INSERT [dbo].[tour] ON 

INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (5, N'Phan Rang - Đà Lạt', N'okeeee', 4, CAST(N'2021-10-31T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-05T12:00:00.0000000' AS DateTime2), 1, 5, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (6, N'Trường Đại học Sài Gòn', N'Toẹt vời', 4, CAST(N'2021-10-31T12:00:00.0000000' AS DateTime2), CAST(N'2021-10-31T12:00:00.0000000' AS DateTime2), 3, 6, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7, N'Đà Nẵng - Đà Lạt', N'vjp lắm', 1, CAST(N'2021-10-31T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-07T12:00:00.0000000' AS DateTime2), 1, 7, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (8, N'Sapa - TP Hồ Chí Minh', N'alooooo', 2, CAST(N'2021-10-31T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-04T12:00:00.0000000' AS DateTime2), 3, 8, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (9, N'Củ Chi - SaPa', N'dcccc', 1, CAST(N'2021-11-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-12T12:00:00.0000000' AS DateTime2), 1, 9, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (10, N'Hà Nội - Đà Lạt', N'đẹp quá, quá đẹp', 3, CAST(N'2021-10-31T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-04T12:00:00.0000000' AS DateTime2), 1, 10, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (2005, N'vnfghfgh', N'vvnfghfgh', 1, CAST(N'2021-11-26T12:00:00.0000000' AS DateTime2), CAST(N'2021-11-26T12:00:00.0000000' AS DateTime2), 3, NULL, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3006, N'vvbvbvb', N'vxvxvxvxv', 1, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), 1, 3002, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3008, N'nnnnnnnnnnn', N'nnnnnnnnnnn', 1, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), 1, 3004, 0)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3009, N'lalkaaslsad', N'lalkaaslsad', 1, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-09T12:00:00.0000000' AS DateTime2), 4, 3005, 1)
SET IDENTITY_INSERT [dbo].[tour] OFF
GO
ALTER TABLE [dbo].[dangky] ADD  CONSTRAINT [DF_dangky_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[diadiemden] ADD  CONSTRAINT [DF_diadiemden_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[doandulich] ADD  CONSTRAINT [DF_doandulich_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[khachhang] ADD  CONSTRAINT [DF_khachhang_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[loaichiphi] ADD  CONSTRAINT [DF_loaichiphi_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[loaihinhdulich] ADD  CONSTRAINT [DF_loaihinhdulich_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[loaikhachhang] ADD  CONSTRAINT [DF_loaikhachhang_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[nhanvien] ADD  CONSTRAINT [DF_nhanvien_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[thamgiadoan] ADD  CONSTRAINT [DF_thamgiadoan_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[tour] ADD  CONSTRAINT [DF_tour_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
USE [master]
GO
ALTER DATABASE [tourdulich] SET  READ_WRITE 
GO
