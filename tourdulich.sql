USE [master]
GO
/****** Object:  Database [tourdulich]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[chiphi]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[dangky]    Script Date: 24/12/2021 4:40:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangky](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maSoKhachHang] [int] NOT NULL,
	[maTour] [int] NOT NULL,
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
/****** Object:  Table [dbo].[diadiemden]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[diadiemthamquan]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[diadiemtour]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[doandulich]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[giatour]    Script Date: 24/12/2021 4:40:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giatour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maGiaTour] [int] NOT NULL,
	[gia] [float] NOT NULL,
	[dieuKien] [nvarchar](100) NOT NULL,
	[ngayThem] [datetime] NULL,
 CONSTRAINT [PK__giatour__3213E83F42557906] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[loaichiphi]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[loaihinhdulich]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[nhanvien]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[thamgiadoan]    Script Date: 24/12/2021 4:40:21 PM ******/
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
/****** Object:  Table [dbo].[tour]    Script Date: 24/12/2021 4:40:21 PM ******/
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

INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1008, 200000, 4007, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1009, 20000, 4007, N'di chuyển', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1010, 1000000, 4007, N'quà lưu niệm', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1011, 12333, 4008, N'ăn uống', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1012, 35000, 4008, N'quà lưu', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1013, 203000, 4009, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1014, 203002, 4009, N'đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1015, 200000, 4010, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1016, 250000, 4010, N'quà lưu niệm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1017, 92000, 4011, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1018, 30000, 4011, N'đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1019, 20000, 4012, N'hoa hồng', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1020, 260000, 4012, N'ăn uống', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1021, 2000, 4013, N'ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1022, 30000, 4013, N'đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1023, 100000, 4008, N'Quà lưu niệm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1024, 100000, 4008, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1025, 45000, 4015, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1026, 50000, 4015, N'Đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (1027, 454545, 4015, N'Dọn dẹp', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (2002, 155000, 4010, N'Dọn dẹp', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (2003, 155000, 5005, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (2004, 20000, 5005, N'Quà lưu niệm', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (2005, 34443, 5005, N'tips tips tips', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (2006, 200000, 5005, N'tips tips tips', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (2007, 20000, 6004, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3002, 200000, 7004, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3003, 75000, 7004, N'Đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3004, 20000, 7005, N'Quà lưu niệm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3005, 50000, 7005, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3006, 155000, 7006, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3007, 78900, 7006, N'Đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3008, 75000, 7007, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3009, 200000, 7008, N'Quà lưu niệm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3010, 75000, 7008, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3011, 75000, 7009, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3012, 20000, 7010, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3013, 20000, 7010, N'Đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3014, 200000, 7011, N'Quà lưu niệm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3015, 20000, 7012, N'Quà lưu niệm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3016, 75000, 7013, N'Đi lại', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3017, 200000, 4014, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3018, 10000, 7015, N'Ăn uống', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3019, 20000, 7016, N'Ăn uống', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3020, 20000, 7017, N'Ăn uống', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3021, 20000, 7012, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3022, 20000, 7018, N'Ăn uống', 0)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3023, 100000, 7019, N'Ăn uống', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3024, 50000, 7019, N'Phí thêm', 1)
INSERT [dbo].[chiphi] ([maChiPhi], [tongChiPhi], [maSoDoan], [tenChiPhi], [trangThai]) VALUES (3025, 1000, 7019, N'Quà lưu niệm', 0)
SET IDENTITY_INSERT [dbo].[chiphi] OFF
GO
SET IDENTITY_INSERT [dbo].[dangky] ON 

INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4026, 1005, 3016, CAST(N'2021-12-03' AS Date), 4009, 1, 3000000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4027, 1002, 3013, CAST(N'2021-12-03' AS Date), 4011, 1, 35000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4028, 1005, 3013, CAST(N'2021-12-03' AS Date), 4011, 1, 35000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4029, 2001, 3013, CAST(N'2021-12-03' AS Date), 4011, 1, 35000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4030, 2004, 3013, CAST(N'2021-12-03' AS Date), 4011, 1, 35000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4031, 2004, 3013, CAST(N'2021-12-03' AS Date), 4011, 1, 35000, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4032, 1005, 3016, CAST(N'2021-12-02' AS Date), 4009, 1, 3000000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4033, 2001, 3016, CAST(N'2021-12-03' AS Date), 4009, 1, 3000000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4034, 1004, 3013, CAST(N'2021-12-03' AS Date), 4011, 1, 35000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4035, 1003, 4016, CAST(N'2021-12-08' AS Date), 4015, 1, 16666, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4036, 1004, 4016, CAST(N'2021-12-08' AS Date), 4015, 1, 16666, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (4037, 1002, 3013, CAST(N'2021-12-03' AS Date), 4011, 1, 35000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (5026, 1004, 4017, CAST(N'2021-12-16' AS Date), 5005, 1, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (5027, 2005, 4017, CAST(N'2021-12-17' AS Date), 5005, 1, 500000, 0)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (5028, 2005, 4017, CAST(N'2021-12-14' AS Date), 5005, 1, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (5029, 2001, 4017, CAST(N'2021-12-14' AS Date), 5005, 1, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (5030, 2005, 4017, CAST(N'2021-12-14' AS Date), 5005, 1, 1320000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (5031, 2003, 4016, CAST(N'2021-12-06' AS Date), 4015, 1, 343434, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (5032, 2008, 6009, CAST(N'2021-11-07' AS Date), 6004, 1, 1320000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6026, 2006, 7009, CAST(N'2021-02-07' AS Date), 7004, 1, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6027, 2001, 7009, CAST(N'2021-02-07' AS Date), 7004, 1, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6028, 1005, 7009, CAST(N'2021-02-07' AS Date), 7004, 1, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6029, 2004, 7009, CAST(N'2021-02-07' AS Date), 7004, 1, 899000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6030, 1003, 7010, CAST(N'2021-01-04' AS Date), 7005, 1, 699600, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6031, 1005, 7010, CAST(N'2021-01-05' AS Date), 7005, 1, 699600, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6032, 1004, 7011, CAST(N'2021-03-07' AS Date), 7006, 1, 699000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6033, 1005, 7011, CAST(N'2021-03-08' AS Date), 7006, 1, 699000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6034, 2005, 7011, CAST(N'2021-03-08' AS Date), 7006, 1, 699000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6035, 2001, 7011, CAST(N'2021-03-08' AS Date), 7006, 1, 699000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6036, 2005, 7012, CAST(N'2021-04-06' AS Date), 7007, 1, 789000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6037, 2004, 7012, CAST(N'2021-04-08' AS Date), 7007, 1, 789000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6038, 2003, 7012, CAST(N'2021-04-07' AS Date), 7007, 1, 789000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6039, 2008, 7012, CAST(N'2021-04-08' AS Date), 7007, 1, 789000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6040, 1005, 7013, CAST(N'2021-05-09' AS Date), 7008, 1, 776300, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6041, 2006, 7013, CAST(N'2021-05-09' AS Date), 7008, 1, 776300, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6042, 1005, 7014, CAST(N'2021-06-18' AS Date), 7009, 1, 578980, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6043, 2005, 7014, CAST(N'2021-06-18' AS Date), 7009, 1, 578980, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6044, 2006, 7014, CAST(N'2021-06-17' AS Date), 7009, 1, 578980, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6045, 2001, 7014, CAST(N'2021-06-17' AS Date), 7009, 1, 578980, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6046, 2002, 7014, CAST(N'2021-06-17' AS Date), 7009, 1, 578980, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6047, 1002, 7015, CAST(N'2021-07-21' AS Date), 7010, 1, 1200000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6048, 2003, 7015, CAST(N'2021-07-21' AS Date), 7010, 1, 1200000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6049, 2002, 7015, CAST(N'2021-07-22' AS Date), 7010, 1, 1200000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6050, 2001, 7016, CAST(N'2021-08-15' AS Date), 7011, 1, 870000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6051, 1005, 7016, CAST(N'2021-08-17' AS Date), 7011, 1, 870000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6052, 2006, 7016, CAST(N'2021-08-16' AS Date), 7011, 1, 870000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6053, 1005, 7017, CAST(N'2021-09-21' AS Date), 7012, 1, 322000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6054, 2002, 7017, CAST(N'2021-09-21' AS Date), 7012, 1, 322000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6055, 2008, 7017, CAST(N'2021-09-21' AS Date), 7012, 1, 322000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6056, 1004, 7017, CAST(N'2021-09-21' AS Date), 7012, 1, 322000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6057, 2001, 7018, CAST(N'2021-10-15' AS Date), 7013, 1, 1322000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6058, 1005, 7018, CAST(N'2021-10-14' AS Date), 7013, 1, 1322000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6059, 2002, 7018, CAST(N'2021-10-14' AS Date), 7013, 1, 1322000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6060, 1004, 4015, CAST(N'2021-11-04' AS Date), 4014, 1, 30000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6061, 1005, 4015, CAST(N'2021-11-04' AS Date), 4014, 1, 1500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6062, 2003, 4015, CAST(N'2021-11-05' AS Date), 4014, 1, 1500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6063, 3001, 7019, CAST(N'2021-12-24' AS Date), 7019, 1, 500000, 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [ngayDangKy], [maSoDoan], [soLuongKhachHang], [giaTourDangKy], [trangThai]) VALUES (6064, 1004, 7019, CAST(N'2021-12-24' AS Date), 7019, 1, 500000, 1)
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
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (3003, N'Bình Thuận', 1)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (3004, N'Thái Bìnhgsdf', 0)
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen], [trangThai]) VALUES (3005, N'Phú Quốc', 1)
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
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3006, N'Hồ nước ngọt Vĩnh Hảo', 3003)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3007, N'đảo đẹp', 3005)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3008, N'khu vui chơi', 3005)
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
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5011, 3018, N'Hồ Xuân Hương')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5012, 3018, N'Trường Cao Đẳng Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5013, 3018, N'Chợ đêm Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5017, 4011, N'Khu du lịch Ozo Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5018, 4011, N'Khu du lịch sao biển Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5019, 4011, N'Khu du lịch suối Moọc Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5020, 4012, N'Khu du lịch sao biển Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5021, 4012, N'Bãi Đá Nhảy')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5022, 4013, N'Khu du lịch sao biển Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5023, 4013, N'Bãi Đá Nhảy')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5024, 4012, N'Khu du lịch suối Moọc Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5025, 4012, N'Biển Nhật Lệ')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5026, 4012, N'Cồn cát Quang Phú')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5027, 4014, N'Khu du lịch Ozo Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5028, 4014, N'Khu du lịch sao biển Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5029, 4014, N'Bãi Đá Nhảy')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5033, 4015, N'Thung lũng tình yêu')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5034, 4015, N'Trường Cao Đẳng Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5035, 4015, N'Chợ đêm Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5036, 4015, N'Vườn hoa Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5037, 4016, N'Hồ Xuân Hương')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5038, 4016, N'Trường Cao Đẳng Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5039, 4016, N'Chợ đêm Đà Lạt')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5040, 4019, N' Viện Hải Dương học')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5041, 4019, N' Vịnh Vân Phong')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5042, 4019, N' Đảo Điệp Sơn')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5043, 4020, N' Khu du lịch suối Moọc Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5044, 4020, N' Biển Nhật Lệ')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5045, 4021, N' Tháp bà Ponagar')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5046, 4021, N' Viện Hải Dương học')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5047, 4022, N' Núi Chúa')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (6006, 4022, N' Vườn nho Ba Mọi')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (6007, 5010, N' Tháp bà Ponagar')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (6008, 5010, N' Đảo Điệp Sơn')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (6009, 5010, N' Viện Hải Dương học')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (7006, 5011, N' Vườn nho Ba Mọi')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (7007, 5011, N' Núi Chúa')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (7008, 6010, N' Núi Ngũ Hành Sơn')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (7009, 6010, N' Bán đảo Sơn Trà')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8006, 6011, N' Vịnh Ninh Vân')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8007, 6011, N' Viện Hải Dương học')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8008, 7010, N' Đảo Điệp Sơn')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8009, 7010, N' Tháp bà Ponagar')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8010, 7010, N' Vịnh Vân Phong')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8011, 7012, N' Khu du lịch sao biển Quảng Bình')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8012, 7012, N' Biển Nhật Lệ')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8013, 7012, N' Bãi Đá Nhảy')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8014, 7012, N' Vườn nho Ba Mọi')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8015, 7014, N' Địa đạo Củ Chi')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8016, 7014, N' Chè Cầu Đất')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8017, 7014, N' Thung lũng tình yêu')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8018, 7016, N' Hồ nước ngọt Vĩnh Hảo')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8019, 7016, N' Động Phong Nha')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8020, 7017, N' đảo đẹp')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8021, 7018, N' Biển Mỹ Khê')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8022, 7018, N' Núi Ngũ Hành Sơn')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8023, 7018, N' Ghềnh Bàng')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8024, 7019, N'Hồ Xuân Hương')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (8025, 7019, N'Trường Cao Đẳng Đà Lạt')
SET IDENTITY_INSERT [dbo].[diadiemtour] OFF
GO
SET IDENTITY_INSERT [dbo].[doandulich] ON 

INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4004, N'abc', 0, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-08T12:00:00.0000000' AS DateTime2), N'abc', 3013, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4005, N'ccccccc', 0, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-08T12:00:00.0000000' AS DateTime2), N'ccccccc', 3013, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4006, N'Đoàn Đại học Sài Gòn TTX', 0, 0, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T12:00:00.0000000' AS DateTime2), N'đẹp lắm', 3015, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4007, N'Đoàn anh em xóm 2', 0, 3, CAST(N'2021-12-02T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T00:00:00.0000000' AS DateTime2), N'xóm 2 ae vui vẻ lắm', 3016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4008, N'Đoàn Đại học Hoa Sen ttp1', 0, 3, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), N'ổn lắm', 3014, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4009, N'Công ty ANM', 3, 1, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), N'Đoàn du lịch của công ty ANM VN', 3016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4010, N'Hội bà con Tây Ninh', 0, 0, CAST(N'2021-12-02T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-06T00:00:00.0000000' AS DateTime2), N'đây là hội bà con ở Tây Ninh đây', 3016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4011, N'KTX 1890 BEST', 6, 1, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-03T12:00:00.0000000' AS DateTime2), N'ktx chiều mưa', 3013, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4012, N'Đoàn du lịch tự lập 2', 0, 1, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-03T12:00:00.0000000' AS DateTime2), N'Aloaloalo', 3017, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4013, N'đoàn mới', 0, 0, CAST(N'2021-10-04T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-06T00:00:00.0000000' AS DateTime2), N'ghi chus mớivvvvf', 3016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4014, N'Đại học Tây Đô', 3, 0, CAST(N'2021-11-04T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-07T00:00:00.0000000' AS DateTime2), N'ổn lắmmmm', 4015, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (4015, N'Đoàn anh em chí cốt MT', 3, 2, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-14T12:00:00.0000000' AS DateTime2), N'ghi chú nè', 4016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (5004, N'Đoàn vjp pro 2223', 0, 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-21T00:00:00.0000000' AS DateTime2), N'vjp pro 2333', 5010, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (5005, N'Đoàn vjp pro 2223', 4, 3, CAST(N'2021-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-17T00:00:00.0000000' AS DateTime2), N'vjp pro 2233', 4017, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (6004, N'doan thang 11', 1, 2, CAST(N'2021-11-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-14T00:00:00.0000000' AS DateTime2), N'scxccxc', 6009, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (6005, N'Đoàn khách vuituoi ', 0, 0, CAST(N'2021-11-21T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-23T00:00:00.0000000' AS DateTime2), N'luon vuituoi', 6010, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7004, N'đoàn tháng 2', 4, 0, CAST(N'2021-02-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-02-09T00:00:00.0000000' AS DateTime2), N'thang2s', 7009, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7005, N'đoàn tháng 1 ', 2, 0, CAST(N'2021-01-04T00:00:00.0000000' AS DateTime2), CAST(N'2021-01-06T00:00:00.0000000' AS DateTime2), N't1 đây', 7010, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7006, N'đoàn tháng 3', 4, 1, CAST(N'2021-03-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-03-10T00:00:00.0000000' AS DateTime2), N'd3', 7011, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7007, N'đoàn tháng 4', 4, 0, CAST(N'2021-04-06T00:00:00.0000000' AS DateTime2), CAST(N'2021-04-11T00:00:00.0000000' AS DateTime2), N'd4', 7012, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7008, N'đoàn tháng 5', 2, 0, CAST(N'2021-05-09T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-12T00:00:00.0000000' AS DateTime2), N'd5', 7013, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7009, N'đoàn tháng 6', 5, 0, CAST(N'2021-06-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-06-21T00:00:00.0000000' AS DateTime2), N'd6', 7014, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7010, N'đoàn tháng 7', 3, 0, CAST(N'2021-07-21T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-27T00:00:00.0000000' AS DateTime2), N'd7', 7015, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7011, N'đoàn tháng 8', 3, 0, CAST(N'2021-08-15T00:00:00.0000000' AS DateTime2), CAST(N'2021-08-19T00:00:00.0000000' AS DateTime2), N'd8', 7016, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7012, N'đoàn tháng 9', 4, 0, CAST(N'2021-09-21T00:00:00.0000000' AS DateTime2), CAST(N'2021-09-24T00:00:00.0000000' AS DateTime2), N'd9', 7017, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7013, N'đoàn tháng 10', 3, 1, CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-19T00:00:00.0000000' AS DateTime2), N'd10', 7018, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7014, N'Đoàn hoài niệm 16', 0, 0, CAST(N'2021-06-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-06-21T00:00:00.0000000' AS DateTime2), N'hoài niệm quá ae à', 7014, 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7015, N'Đoàn vjp pro ĐL-HN', 0, 0, CAST(N'2021-12-01T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T00:00:00.0000000' AS DateTime2), N'vjp', 3017, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7016, N'Đoàn vjp pro ĐL-HNccc', 0, 0, CAST(N'2021-12-01T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T00:00:00.0000000' AS DateTime2), N'cccc', 3017, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7017, N'Đoàn khách DLHN', 0, 0, CAST(N'2021-12-01T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T00:00:00.0000000' AS DateTime2), N'cccc', 3017, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7018, N'Đoàn khách vuituoi xccc', 0, 0, CAST(N'2021-12-01T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T00:00:00.0000000' AS DateTime2), N'zzzz', 3017, 0)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour], [trangThai]) VALUES (7019, N'đoàn hội CLB du lịch', 2, 3, CAST(N'2021-12-24T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-28T12:00:00.0000000' AS DateTime2), N'hội ae', 7019, 1)
SET IDENTITY_INSERT [dbo].[doandulich] OFF
GO
SET IDENTITY_INSERT [dbo].[giatour] ON 

INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (3008, 2, 3000000, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (3009, 3013, 1500000, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (3010, 3014, 500000, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (3011, 3015, 5000000, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (3012, 3016, 3000000, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (3013, 3017, 5500000, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4001, 3017, 1500, N'khuyen mai off', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4002, 3018, 100000, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4003, 4010, 3233, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4004, 4010, 23333, N'khuyến mãi', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4005, 4011, 100000, N'mới tạo', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4006, 4011, 20000, N'khuyến mãi 30% off', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4007, 4015, 100000, N'giá khởi điểm', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4008, 4015, 231231, N'kkkkkkk', CAST(N'2021-12-05T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4009, 4015, 30000, N'off giảm mạnh', CAST(N'2021-12-05T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4010, 3013, 35000, N'alohe', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4011, 4016, 16666, N'new', CAST(N'2021-12-04T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4012, 4016, 15000, N'ổn', CAST(N'2021-12-05T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4013, 4016, 343434, N'yess', CAST(N'2021-12-05T12:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4014, 4017, 1320000, N'giá gốc', CAST(N'2021-12-12T04:16:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4015, 4017, 1000000, N'sale off mạnh', CAST(N'2021-12-14T04:18:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4016, 4017, 500000, N'giá giảm mạnh lắm rồi nhé', CAST(N'2021-12-13T04:20:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4017, 4017, 0, N'sale off 100% ', CAST(N'2021-12-17T04:22:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4018, 4018, 1200000, N'giá mới ', CAST(N'2021-12-14T04:23:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4019, 4018, 90000, N'sale off mạnh', CAST(N'2021-12-21T04:24:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4020, 4021, 5000000, N'giá gốc', CAST(N'2021-12-13T04:25:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4021, 4020, 3344443, N'giá gốc đây nhé', CAST(N'2021-12-13T04:25:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4022, 4020, 1320000, N'sale off mạnh liền', CAST(N'2021-12-16T04:25:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (4023, 4019, 3000000, N'giá hợp lý', CAST(N'2021-12-20T04:26:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (5006, 5010, 1320000, N'giá gốc', CAST(N'2021-12-16T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (5007, 4019, 1320000, N'giá gốc', CAST(N'2021-12-22T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (5008, 6009, 1320000, N'giá gốc', CAST(N'2021-12-23T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6006, 7009, 500000, N'giá gốc', CAST(N'2021-02-20T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6007, 7009, 899000, N'tăng dịp lễ', CAST(N'2021-02-09T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6008, 7018, 1322000, N'giá gốc', CAST(N'2021-10-14T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6009, 7017, 322000, N'giá gốc', CAST(N'2021-09-21T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6010, 7016, 870000, N'giá gốc', CAST(N'2021-08-21T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6011, 7015, 1200000, N'giá gốc', CAST(N'2021-07-21T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6012, 7014, 578980, N'giá gốc', CAST(N'2021-06-20T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6013, 7013, 776300, N'giá gốc', CAST(N'2021-05-11T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6014, 7012, 789000, N'giá gốc', CAST(N'2021-04-12T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6015, 7011, 699000, N'giá gốc', CAST(N'2021-03-21T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6016, 7010, 699600, N'giá gốc', CAST(N'2021-01-17T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6017, 6010, 1320000, N'giá gốc', CAST(N'2021-11-21T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6018, 4015, 1500000, N'tăng dịp cuối năm noel', CAST(N'2021-11-17T00:00:00.000' AS DateTime))
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien], [ngayThem]) VALUES (6019, 7019, 500000, N'giá gốc', CAST(N'2021-12-24T12:00:00.000' AS DateTime))
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
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2004, N'Nguyễn Văn Minh', N'343242424', N'Aloha', N'Nữ', N'0855656556', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2005, N'Nguyễn Văn Linh', N'342346134', N'23 Hàm Nghi', N'Nữ', N'0623434343', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2006, N'Trần Văn N', N'342627726', N'89 Lê Duẫn', N'Nam', N'0623423432', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2007, N'Đoàn Hùng', N'3423436233', N'23 Nguyễn Trãi', N'Nam', N'0346234343', N'Việt Nam', 0)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (2008, N'Đoàn Hùng Hồ', N'3423436233', N'23 Nguyễn Trãi', N'Nữ', N'0346234343', N'Việt Nam', 1)
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich], [trangThai]) VALUES (3001, N'Trần Văn Tài', N'232343234', N'23 Cao Đạt', N'Nữ', N'0342343433', N'Việt Nam', 1)
SET IDENTITY_INSERT [dbo].[khachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[loaichiphi] ON 

INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (2001, N'Ăn uống', 1)
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (2002, N'Quà lưu niệm', 1)
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (2003, N'Đi lại', 1)
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (2004, N'Dọn dẹp', 1)
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (3001, N'tips tips tips', 1)
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi], [trangThai]) VALUES (4001, N'Phí thêm', 1)
SET IDENTITY_INSERT [dbo].[loaichiphi] OFF
GO
SET IDENTITY_INSERT [dbo].[loaihinhdulich] ON 

INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1001, N'Du lịch đi động', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1002, N'Du lịch kết hợp nghề nghiệp', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1003, N'Du lịch cá nhân', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1004, N'Du lịch bụi', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (1005, N'Du lịch mở', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (2001, N'Du lịch sinh thái', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (2002, N'Du lịch tự do', 1)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (2003, N'Du lịch 2222', 0)
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich], [trangThai]) VALUES (2004, N'Du lịch đi đây đó', 1)
SET IDENTITY_INSERT [dbo].[loaihinhdulich] OFF
GO
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2002, N'Trần Trọng Ninh', N'Lơ xe', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2003, N'Nguyễn Ngọc Quỳnh Như', N'Tiếp viên', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2004, N'Giang Thế Phong', N'Tài xế', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (2005, N'Nguyễn Thương Mến', N'Bán vé', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3001, N'Hồ Văn Tài', N'Bảo vệ', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3002, N'Nguyễn Văn Hùng', N'Tài xế', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3003, N'Trần Suy', N'Tiếp viên', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3004, N'Nguyễn Thị Hoa', N'tiếp viên', 0)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3005, N'Nguyễn Trần Nhật Hào', N'tài xế', 0)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3006, N'Đoàn Văn Hậu', N'tài xế', 0)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3007, N'Đoàn Văn Hậu', N'tài xế', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3008, N'Đoàn Văn Hậukvvvv', N'kkkkkkkk', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3009, N'gggg', N'gggggggggggg', 0)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3010, N'gggg', N'gggggggggggg', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3011, N'bvbvbvb', N'bvbvbvb', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3012, N'bnnnnnnnnnn', N'bnnnnnnnnnn', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3013, N'hfghfhfgh', N'naninaninani', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3014, N'cvcvcvccvv', N'best luôn', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3015, N'vbvbvb', N'bbvbbbbbb', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3016, N'trêt', N'sssd', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3017, N'yyyyyyyy', N'versace', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3018, N'pppppppp', N'pppppppp', 1)
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu], [trangThai]) VALUES (3019, N'aloaloalo', N'lơ xe', 1)
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
GO
SET IDENTITY_INSERT [dbo].[thamgiadoan] ON 

INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1021, 2002, 4007, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1022, 2004, 4007, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1023, 2003, 4007, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1024, 2005, 4008, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1025, 3002, 4008, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1026, 3001, 4012, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-03T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1027, 2005, 4008, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1028, 3003, 4009, CAST(N'2021-12-02T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1029, 3004, 4011, CAST(N'2021-12-03T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-03T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (1030, 3003, 4015, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-07T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (2001, 2005, 5005, CAST(N'2021-12-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-17T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (2002, 2002, 5005, CAST(N'2021-12-15T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-17T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (2003, 3018, 5005, CAST(N'2021-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-16T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (2004, 3001, 5005, CAST(N'2021-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-15T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (2005, 3010, 5005, CAST(N'2021-12-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-17T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (2006, 3008, 4015, CAST(N'2021-12-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-14T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (2007, 3003, 5005, CAST(N'2021-12-13T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-16T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3001, 2002, 6004, CAST(N'2021-11-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-14T00:00:00.0000000' AS DateTime2), 0)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3002, 2002, 6004, CAST(N'2021-11-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-14T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3003, 2005, 6004, CAST(N'2021-11-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3004, 2002, 7013, CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-18T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3005, 2003, 7006, CAST(N'2021-03-07T12:00:00.0000000' AS DateTime2), CAST(N'2021-03-10T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3009, 2002, 7019, CAST(N'2021-12-24T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-25T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3010, 2003, 7019, CAST(N'2021-12-24T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-27T12:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc], [trangThai]) VALUES (3011, 2004, 7019, CAST(N'2021-12-24T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-27T12:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[thamgiadoan] OFF
GO
SET IDENTITY_INSERT [dbo].[tour] ON 

INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3013, N'Nha Trang - Đà Nẵng', N'quá đẹp luôn', 1002, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-08T12:00:00.0000000' AS DateTime2), 2007, 3009, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3014, N'Sài Gòn - Củ Chi', N'huyền bí', 1001, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 2004, 3010, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3015, N'Sài Gòn - Đà Nẵng', N'rất vui', 1005, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-10T12:00:00.0000000' AS DateTime2), 2007, 3011, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3016, N'Tây Ninh - Đà Lạt', N'mát mẻ, trong lành', 1003, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-07T12:00:00.0000000' AS DateTime2), 2003, 3012, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (3017, N'Đà Lạt - Hà Nội', N'cổ kính', 1002, CAST(N'2021-12-01T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-05T12:00:00.0000000' AS DateTime2), 2006, 4001, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4009, N'abcccc', N'abcccc', 1001, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 2003, 4002, 0)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4010, N'kjjjj', N'kjjjj', 1001, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-15T12:00:00.0000000' AS DateTime2), 2003, 4003, 0)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4011, N'tour mowis', N'12323232', 1001, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), 2005, 4005, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4014, N'Tây Ninh - Quảng Bình', N'bụi lắm', 1004, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-22T12:00:00.0000000' AS DateTime2), 2005, NULL, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4015, N'Hà Nội - Đà Lạt', N'oke', 1001, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-22T12:00:00.0000000' AS DateTime2), 2003, 6018, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4016, N'Sài Gòn - Đà Lạt', N'yess', 1002, CAST(N'2021-12-04T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-15T12:00:00.0000000' AS DateTime2), 2003, 4013, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4017, N'Phim trường Du Long', N'đẹp luôn nhé', 2002, CAST(N'2021-12-10T00:43:00.0000000' AS DateTime2), CAST(N'2021-12-17T00:43:00.0000000' AS DateTime2), 2007, 4014, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4018, N'Đà lạt mơ mộng 2', N'đẹp luôn nhé ae', 1003, CAST(N'2021-12-11T00:53:00.0000000' AS DateTime2), CAST(N'2021-12-13T00:53:00.0000000' AS DateTime2), 2007, 4019, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4019, N'Đà lạt mơ mộng 26', N'đẹp lắm ae à', 1002, CAST(N'2021-12-11T01:07:00.0000000' AS DateTime2), CAST(N'2021-12-12T01:07:00.0000000' AS DateTime2), 2009, 5007, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4020, N'Du lịch Quảng Bình nè ae', N'xịn lắm ae', 2002, CAST(N'2021-12-10T01:26:00.0000000' AS DateTime2), CAST(N'2021-12-17T01:26:00.0000000' AS DateTime2), 2005, 4021, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4021, N'Tour Best guy 22', N'bestttttt', 1003, CAST(N'2021-12-10T01:35:00.0000000' AS DateTime2), CAST(N'2021-12-16T01:35:00.0000000' AS DateTime2), 2009, 4020, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (4022, N'Đà lạt mơ mộng 23434', N'dep lam nhe', 1002, CAST(N'2021-12-12T00:21:00.0000000' AS DateTime2), CAST(N'2021-12-14T00:21:00.0000000' AS DateTime2), 3002, NULL, 0)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (5009, N'Phim trường Du Long2222232323', N'saccxcxc', 1002, CAST(N'2021-12-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-16T00:00:00.0000000' AS DateTime2), 3002, NULL, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (5010, N'tour mới 15/12', N'ccccccrr', 2001, CAST(N'2021-12-15T00:00:00.0000000' AS DateTime2), CAST(N'2021-12-22T00:00:00.0000000' AS DateTime2), 2009, 5006, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (6009, N'tour 11', N'vvvasđsd', 1001, CAST(N'2021-11-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-22T00:00:00.0000000' AS DateTime2), 3002, 5008, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (6010, N'Hà Nội - Đà Nẵng', N'rất đẹp và nên thơ', 1003, CAST(N'2021-11-21T00:00:00.0000000' AS DateTime2), CAST(N'2021-11-23T00:00:00.0000000' AS DateTime2), 2007, 6017, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7009, N'tour tháng 2', N'alohe', 2001, CAST(N'2021-02-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-02-26T00:00:00.0000000' AS DateTime2), 2009, 6007, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7010, N'tour tháng 1', N'đặc điểm tour 1', 1004, CAST(N'2021-01-04T00:00:00.0000000' AS DateTime2), CAST(N'2021-01-14T00:00:00.0000000' AS DateTime2), 2009, 6016, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7011, N'Tour tháng 3', N'ccccc', 1003, CAST(N'2021-03-07T00:00:00.0000000' AS DateTime2), CAST(N'2021-03-14T00:00:00.0000000' AS DateTime2), 2005, 6015, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7012, N'Tour tháng 4', N'alohe', 2004, CAST(N'2021-04-06T00:00:00.0000000' AS DateTime2), CAST(N'2021-04-11T00:00:00.0000000' AS DateTime2), 3002, 6014, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7013, N'tour tháng 5', N'tour 5', 1005, CAST(N'2021-05-09T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-16T00:00:00.0000000' AS DateTime2), 2004, 6013, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7014, N'tour tháng 6', N't6 đặc điểm', 2004, CAST(N'2021-06-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-06-21T00:00:00.0000000' AS DateTime2), 2003, 6012, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7015, N'tour tháng 7', N't7', 2001, CAST(N'2021-07-21T00:00:00.0000000' AS DateTime2), CAST(N'2021-07-28T00:00:00.0000000' AS DateTime2), 3003, 6011, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7016, N'tour tháng 8', N't8', 1002, CAST(N'2021-08-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-08-21T00:00:00.0000000' AS DateTime2), 3001, 6010, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7017, N'tour tháng 9', N'tour9', 2001, CAST(N'2021-09-21T00:00:00.0000000' AS DateTime2), CAST(N'2021-09-24T00:00:00.0000000' AS DateTime2), 3005, 6009, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7018, N'tour tháng 10', N't10', 1003, CAST(N'2021-10-14T00:00:00.0000000' AS DateTime2), CAST(N'2021-10-21T00:00:00.0000000' AS DateTime2), 2007, 6008, 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maLoaiHinhDuLich], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen], [idGiaTour], [trangThai]) VALUES (7019, N'CLB du lịch 223', N'du lịch nhóm', 1004, CAST(N'2021-12-24T12:00:00.0000000' AS DateTime2), CAST(N'2021-12-30T12:00:00.0000000' AS DateTime2), 2003, 6019, 1)
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
ALTER TABLE [dbo].[loaichiphi] ADD  CONSTRAINT [DF_loaikhachhang_trangThai]  DEFAULT ((1)) FOR [trangThai]
GO
ALTER TABLE [dbo].[loaihinhdulich] ADD  CONSTRAINT [DF_loaihinhdulich_trangThai]  DEFAULT ((1)) FOR [trangThai]
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
