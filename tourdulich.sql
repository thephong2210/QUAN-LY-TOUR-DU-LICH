USE [master]
GO
/****** Object:  Database [tourdulich]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[chiphi]    Script Date: 02/12/2021 9:15:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiphi](
	[maChiPhi] [int] IDENTITY(1,1) NOT NULL,
	[tongChiPhi] [float] NOT NULL,
	[maSoDoan] [int] NOT NULL,
	[tenChiPhi] [nvarchar](50) NOT NULL,
	[trangThai] [int] NOT NULL,
 CONSTRAINT [PK__chiphi__079686358A2E956F] PRIMARY KEY CLUSTERED 
(
	[maChiPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dangky]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[diadiemden]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[diadiemthamquan]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[diadiemtour]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[doandulich]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[giatour]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[khachhang]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[loaihinhdulich]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[loaikhachhang]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[nhanvien]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[thamgiadoan]    Script Date: 02/12/2021 9:15:49 PM ******/
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
/****** Object:  Table [dbo].[tour]    Script Date: 02/12/2021 9:15:49 PM ******/
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
SET IDENTITY_INSERT [dbo].[chiphi] ON 

INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (6, 200000, 2, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (7, 500000, 2, N'di chuyển', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (8, 200000, 3009, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (9, 500000, 3009, N'di chuyển', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (10, 300000, 3010, N'ăn uống', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (11, 500000, 3010, N'ăn trưa', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (12, 300000, 3010, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (13, 500000, 3010, N'ăn trưa', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (14, 800000, 3010, N'di chuyển tiếp', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (15, 900000, 3011, N'Ăn trưa', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (16, 100000, 3011, N'Di chuyển', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (17, 900000, 3012, N'Ăn trưa', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (18, 100000, 3012, N'Di chuyển', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (19, 1000000, 3012, N'Khách sạn', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (20, 100000, 3013, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (21, 100233, 3013, N'thiết bị quay', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (22, 1500000, 3014, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (23, 500000, 3014, N'vé xem vườn hoa', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1002, 111, 2, N'ssss', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1003, 111, 2, N'cccc', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1004, 1000, 4005, N'ccccccc', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1005, 20023, 4005, N'ccccccc', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1006, 20000, 2, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1007, 30000, 2, N'đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1008, 200000, 4007, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1009, 20000, 4007, N'di chuyển', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1010, 1000000, 4007, N'quà lưu niệm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1011, 200000, 4008, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1012, 35000, 4008, N'quà lưu', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1013, 203000, 4009, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1014, 203002, 4009, N'đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1015, 200000, 4010, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1016, 250000, 4010, N'quà lưu niệm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1017, 92000, 4011, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1018, 30000, 4011, N'đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1019, 20000, 4012, N'hoa hồng', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1020, 260000, 4012, N'ăn uống', 1)
SET IDENTITY_INSERT [dbo].[chiphi] OFF
GO
SET IDENTITY_INSERT [dbo].[dangky] ON 

INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3012, 1003, 3017, 1005, CAST(N'2021-12-01' AS Date), 3014, 3, 1500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3013, 1004, 3017, 1002, CAST(N'2021-12-01' AS Date), 3014, 15, 1500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3014, 1004, 3017, 1001, CAST(N'2021-12-01' AS Date), 3014, 1, 1500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3015, 1002, 3015, 1003, CAST(N'2021-12-09' AS Date), 3010, 8, NULL, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (3016, 1005, 3014, 1004, CAST(N'2021-12-06' AS Date), 3012, 3, NULL, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4009, 1004, 3013, 1001, CAST(N'2021-12-02' AS Date), 3013, 1, NULL, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4010, 1002, 3013, 1003, CAST(N'2021-12-02' AS Date), 3013, 3, NULL, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4011, 1002, 3014, 1001, CAST(N'2021-12-02' AS Date), 3012, 1, NULL, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4012, 1003, 3014, 1003, CAST(N'2021-12-10' AS Date), 3012, 5, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4013, 1004, 3017, 1004, CAST(N'2021-12-02' AS Date), 3014, 5, 1500, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4014, 2002, 3013, 1002, CAST(N'2021-12-03' AS Date), 3013, 5, 1500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4015, 1002, 3013, 1002, CAST(N'2021-12-02' AS Date), 4004, 4, 1500000, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4016, 1003, 3013, 1001, CAST(N'2021-12-05' AS Date), 4004, 1, 1500000, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4017, 2002, 3013, 1002, CAST(N'2021-12-02' AS Date), 4011, 3, 1500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4018, 1004, 3014, 1003, CAST(N'2021-12-03' AS Date), 4008, 5, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4019, 1003, 3016, 1005, CAST(N'2021-12-04' AS Date), 4009, 15, 3000000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4020, 1002, 3016, 1001, CAST(N'2021-12-02' AS Date), 4009, 1, 3000000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4021, 2001, 3013, 1002, CAST(N'2021-12-02' AS Date), 4011, 10, 1500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4022, 1002, 3016, 1002, CAST(N'2021-12-02' AS Date), 4007, 10, 3000000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4023, 1005, 3016, 1003, CAST(N'2021-12-02' AS Date), 4007, 5, 3000000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4024, 2003, 3016, 1003, CAST(N'2021-12-02' AS Date), 4010, 10, 3000000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4025, 1005, 3017, 1005, CAST(N'2021-12-02' AS Date), 4012, 5, 1500, 1)
SET IDENTITY_INSERT [dbo].[dangky] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemden] ON 

INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (2003, N'Đà Lạt', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (2004, N'Củ Chi', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (2005, N'Quảng Bình', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (2006, N'Hà Nội', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (2007, N'Đà Nẵng', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (2008, N'Vũng Tàu', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (2009, N'Nha Trang', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (3001, N'Quảng Ninh', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (3002, N'Phan Rang', 1)
SET IDENTITY_INSERT [dbo].[diadiemden] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemthamquan] ON 

INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2014, N'Hồ Xuân Hương', 2)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2015, N'Chè Cầu Đất', 2)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2016, N'Trường Cao đẳng Đà Lạt', 2)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2017, N'Thung lũng tình yêu', 2)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2018, N'Nhà văn hóa Đà Lạt', 2)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2019, N'Chợ đêm Đà Lạt', 2)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2022, N'Chè Cầu Đất', 2003)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2023, N'Hồ Xuân Hương', 2003)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2024, N'Thung lũng tình yêu', 2003)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2025, N'Trường Cao Đẳng Đà Lạt', 2003)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2026, N'Chợ đêm Đà Lạt', 2003)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2027, N'Vườn hoa Đà Lạt', 2003)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2028, N'Địa đạo Củ Chi', 2004)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2041, N'Khu du lịch Ozo Quảng Bình', 2005)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2042, N'Khu du lịch sao biển Quảng Bình', 2005)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2043, N'Khu du lịch suối Moọc Quảng Bình', 2005)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2044, N'Biển Nhật Lệ', 2005)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2045, N'Bãi Đá Nhảy', 2005)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2046, N'Cồn cát Quang Phú', 2005)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2047, N'Quảng trường Ba Đình', 2006)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2048, N'Văn Miếu Quốc Tử Giám', 2006)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2049, N'Chùa Trấn Quốc', 2006)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2050, N'Hồ Gươm', 2006)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2051, N'Hồ Tây', 2006)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2052, N'Biển Mỹ Khê', 2007)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2053, N'Bán đảo Sơn Trà', 2007)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2054, N'Núi Ngũ Hành Sơn', 2007)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2055, N'Ghềnh Bàng', 2007)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2056, N'Bãi Trước', 2008)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2057, N'Bãi Sau', 2008)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2058, N'Côn Đảo', 2008)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2059, N'Đền Lớn', 2008)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2060, N'Vịnh Ninh Vân', 2009)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2061, N'Viện Hải Dương học', 2009)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2062, N'Tháp bà Ponagar', 2009)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2063, N'Đảo Điệp Sơn', 2009)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2064, N'Vịnh Vân Phong', 2009)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3001, N'Động phong nha', 2010)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3002, N'Động Phong Nha', 3001)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3004, N'Núi Chúa', 3002)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3005, N'Vườn nho Ba Mọi', 3002)
SET IDENTITY_INSERT [dbo].[diadiemthamquan] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemtour] ON 

INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4028, 2, N'Biển Mỹ Khê')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4029, 2, N'Núi Ngũ Hành Sơn')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4030, 3013, N'Biển Mỹ Khê')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4031, 3013, N'Núi Ngũ Hành Sơn')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4033, 3014, N'Địa đạo Củ Chi')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4036, 3015, N'Biển Mỹ Khê')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4037, 3015, N'Núi Ngũ Hành Sơn')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4038, 3015, N'Ghềnh Bàng')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4039, 3016, N'Hồ Xuân Hương')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4040, 3016, N'Thung lũng tình yêu')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4041, 3016, N'Chợ đêm Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5008, 3017, N'Văn Miếu Quốc Tử Giám')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5009, 3017, N'Chùa Trấn Quốc')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5010, 3017, N'Hồ Tây')
SET IDENTITY_INSERT [dbo].[diadiemtour] OFF
GO
SET IDENTITY_INSERT [dbo].[doandulich] ON 

INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4004, N'abc', 4, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-08T12:00:00.0000000' AS DateTime2), N'abc', 3013, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4005, N'ccccccc', 0, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-08T12:00:00.0000000' AS DateTime2), N'ccccccc', 3013, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4006, N'Đoàn Đại học Sài Gòn TTX', 0, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T12:00:00.0000000' AS DateTime2), N'đẹp lắm', 3015, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4007, N'Đoàn anh em xóm 2', 15, 3, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), N'xóm 2 ae vui vẻ', 3016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4008, N'Đoàn Đại học Hoa Sen ttp1', 5, 2, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), N'ổn lắm', 3014, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4009, N'Công ty ANM', 16, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), N'Đoàn du lịch của công ty ANM VN', 3016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4010, N'Hội bà con Tây Ninh', 10, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-07T12:00:00.0000000' AS DateTime2), N'đây là hội bà con ở Tây Ninh', 3016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4011, N'KTX 1890 BEST', 13, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-03T12:00:00.0000000' AS DateTime2), N'ktx chiều mưa', 3013, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4012, N'Đoàn du lịch tự lập 2', 5, 1, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-03T12:00:00.0000000' AS DateTime2), N'Aloaloalo', 3017, 1)
SET IDENTITY_INSERT [dbo].[doandulich] OFF
GO
SET IDENTITY_INSERT [dbo].[giatour] ON 

INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3008, 2, 3000000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3009, 3013, 1500000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3010, 3014, 500000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3011, 3015, 5000000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3012, 3016, 3000000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3013, 3017, 5500000, N'mới tạo')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (4001, 3017, 1500, N'khuyen mai off')
SET IDENTITY_INSERT [dbo].[giatour] OFF
GO
SET IDENTITY_INSERT [dbo].[khachhang] ON 

INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (1002, N'Nguyễn Văn Nam', N'744545454', N'23 Nguyen Trai Q5 TP HCM', N'Nam', N'0933432343', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (1003, N'Mesto', N'123515868', N'31 Queens Street', N'Nam', N'0242312324', N'Anh', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (1004, N'Trần Văn Hùng', N'333433334', N'98 Tran Dinh Xu ', N'Nam', N'0343423433', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (1005, N'Trần Thị Ba', N'212222221', N'88 An Duong Vuong', N'Nữ', N'0734543454', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2001, N'Huỳnh Hoa', N'231323561', N'34 Tran Nhan Tong', N'Nữ', N'0342343433', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2002, N'Trần Lê Tuyết Ánh', N'234526727', N'90 Nguyen Van Cu', N'Nữ', N'0562346263', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2003, N'Abraham', N'231515343', N'23 Nguyen Trai', N'Nữ', N'0343423423', N'Norway', 1)
SET IDENTITY_INSERT [dbo].[khachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[loaihinhdulich] ON 

INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1001, N'Du lịch đi động', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1002, N'Du lịch kết hợp nghề nghiệp', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1003, N'Du lịch cá nhân', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1004, N'Du lịch bụi', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1005, N'Du lịch mở', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (2001, N'Du lịch sinh thái', 1)
SET IDENTITY_INSERT [dbo].[loaihinhdulich] OFF
GO
SET IDENTITY_INSERT [dbo].[loaikhachhang] ON 

INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang], [trangThai]) VALUES (1001, N'Cá nhân', 1)
INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang], [trangThai]) VALUES (1002, N'Đơn vị', 1)
INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang], [trangThai]) VALUES (1003, N'Đội nhóm', 1)
INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang], [trangThai]) VALUES (1004, N'Gia đình', 1)
INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang], [trangThai]) VALUES (1005, N'Doanh nghiệp', 1)
INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang], [trangThai]) VALUES (1006, N'Chuyên group', 1)
SET IDENTITY_INSERT [dbo].[loaikhachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2002, N'Trần Trọng Ninh', N'Lơ xe', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2003, N'Nguyễn Ngọc Quỳnh Như', N'Tiếp viên', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2004, N'Giang Thế Phong', N'Tài xế', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2005, N'Nguyễn Thương Mến', N'Bán vé', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3001, N'Hồ Văn Tài', N'Bảo vệ', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3002, N'Nguyễn Văn Hùng', N'Tài xế', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3003, N'Trần Suy', N'Tiếp viên', 1)
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
GO
SET IDENTITY_INSERT [dbo].[thamgiadoan] ON 

INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1021, 2002, 4007, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1022, 2004, 4007, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1023, 2003, 4007, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1024, 2005, 4008, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1025, 3002, 4008, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1026, 3001, 4012, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-03T12:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[thamgiadoan] OFF
GO
SET IDENTITY_INSERT [dbo].[tour] ON 

INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3013, N'Nha Trang - Đà Nẵng', N'quá đẹp luôn', 1002, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-08T12:00:00.0000000' AS DateTime2), 2007, 3009, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3014, N'Sài Gòn - Củ Chi', N'huyền bí', 1001, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 2004, 3010, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3015, N'Sài Gòn - Đà Nẵng', N'rất vui', 1005, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T12:00:00.0000000' AS DateTime2), 2007, 3011, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3016, N'Tây Ninh - Đà Lạt', N'mát mẻ, trong lành', 1003, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-07T12:00:00.0000000' AS DateTime2), 2003, 3012, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3017, N'Đà Lạt - Hà Nội', N'cổ kính', 1002, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), 2006, 4001, 1)
SET IDENTITY_INSERT [dbo].[tour] OFF
GO
ALTER TABLE [dbo].[chiphi] ADD  CONSTRAINT [DF_chiphi_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[dangky] ADD  CONSTRAINT [DF_dangky_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[diadiemden] ADD  CONSTRAINT [DF_diadiemden_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[doandulich] ADD  CONSTRAINT [DF_doandulich_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[khachhang] ADD  CONSTRAINT [DF_khachhang_trangThai]  DEFAULT ((1)) FOR [trangThai]
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
