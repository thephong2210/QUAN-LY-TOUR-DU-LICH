USE [master]
GO
/****** Object:  Database [tourdulich]    Script Date: 20/10/2021 9:58:29 PM ******/
CREATE DATABASE [tourdulich]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'tourdulich', FILENAME = N'D:\Program Files (x86)\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\tourdulich.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'tourdulich_log', FILENAME = N'D:\Program Files (x86)\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\tourdulich_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
EXEC sys.sp_db_vardecimal_storage_format N'tourdulich', N'ON'
GO
USE [tourdulich]
GO
/****** Object:  Table [dbo].[chiphi]    Script Date: 20/10/2021 9:58:29 PM ******/
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
/****** Object:  Table [dbo].[dangky]    Script Date: 20/10/2021 9:58:29 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diadiemthamquan]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[diadiemthamquan](
	[maDiaDiem] [int] IDENTITY(1,1) NOT NULL,
	[tenDiaDiem] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maDiaDiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[doandulich]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[doandulich](
	[maSoDoan] [int] IDENTITY(1,1) NOT NULL,
	[tenGoiDoan] [varchar](100) NOT NULL,
	[soLuongKhachHang] [int] NOT NULL,
	[SoLuongNhanVien] [int] NOT NULL,
	[thoiGianKhoiHanh] [datetime2](6) NOT NULL,
	[thoiGianKetThuc] [datetime2](6) NOT NULL,
	[chiTiet] [varchar](max) NOT NULL,
	[maSoTour] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoDoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[giatour]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[giatour](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[maGiaTour] [int] NOT NULL,
	[gia] [float] NOT NULL,
	[dieuKien] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[maSoKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[hoTenKhachHang] [varchar](100) NOT NULL,
	[soCMND] [varchar](100) NOT NULL,
	[diaChi] [varchar](100) NOT NULL,
	[gioiTinh] [varchar](100) NOT NULL,
	[SDT] [varchar](100) NOT NULL,
	[quocTich] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[loaichiphi]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[loaichiphi](
	[maLoaiChiPhi] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiChiPhi] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiChiPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[loaihinhdulich]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[loaihinhdulich](
	[maLoaiHinhDuLich] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiHinhDuLich] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiHinhDuLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[loaikhachhang]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[loaikhachhang](
	[maLoaiKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiKhachHang] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[maNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[tenNhanVien] [varchar](100) NOT NULL,
	[nhiemVu] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[thamgiadoan]    Script Date: 20/10/2021 9:58:29 PM ******/
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
/****** Object:  Table [dbo].[tour]    Script Date: 20/10/2021 9:58:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tour](
	[maSoTour] [int] IDENTITY(1,1) NOT NULL,
	[tenGoiTour] [varchar](100) NOT NULL,
	[dacDiem] [varchar](100) NOT NULL,
	[maDiaDiem] [int] NOT NULL,
	[maGiaTour] [int] NOT NULL,
	[maLoaiHinhDuLich] [int] NOT NULL,
	[soLuongKhachHang] [int] NOT NULL,
	[tongTien] [float] NOT NULL,
	[thoiGianBatDau] [datetime2](6) NOT NULL,
	[thoiGianKetThuc] [datetime2](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[dangky] ON 

INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan]) VALUES (1, 1, 1, 1, CAST(N'2008-01-01' AS Date), 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan]) VALUES (2, 1, 1, 1, CAST(N'2008-01-01' AS Date), 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan]) VALUES (3, 1, 1, 1, CAST(N'2008-01-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[dangky] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemthamquan] ON 

INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (1, N'Thi?n Vi?n Trúc Lâm')
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (2, N'Chè C?u Ð?t')
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (3, N'Khu di tích d?a d?o C? Chi')
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (4, N'Chùa B?u Long')
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem]) VALUES (5, N'Núi hàm R?ng')
SET IDENTITY_INSERT [dbo].[diadiemthamquan] OFF
GO
SET IDENTITY_INSERT [dbo].[doandulich] ON 

INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour]) VALUES (1, N'Ðoàn Ð?i h?c Sài Gòn', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích di dâu thì di', 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour]) VALUES (2, N'Sài Gòn - Ðà L?t', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích di dâu thì di', 2)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour]) VALUES (3, N'Ðoàn anh em cây kh?', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích di dâu thì di', 3)
SET IDENTITY_INSERT [dbo].[doandulich] OFF
GO
SET IDENTITY_INSERT [dbo].[giatour] ON 

INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (1, 1, 5000000, N'Bình thu?ng')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (2, 2, 10000000, N'T?t nguyên dán')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3, 3, 2000000, N'Ð?ng giá 2tr')
SET IDENTITY_INSERT [dbo].[giatour] OFF
GO
SET IDENTITY_INSERT [dbo].[khachhang] ON 

INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (1, N'Nguy?n Th? Bé Ba', N'2453453454', N'41 Nguy?n Trãi, Phu?ng 1, Qu?n 5, TP HCM', N'N?', N'0961231232', N'Vi?t Nam')
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (2, N'Nguy?n Van Nam', N'3342454443', N'41/343 Nguy?n Bi?u, Phu?ng 1, Qu?n 5, TP HCM', N'Nam', N'0962342343', N'Vi?t Nam')
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (3, N'Tr?n Van', N'2939499392', N'273 An Duong Vuong, Phu?ng 3, Qu?n 5, TP HCM', N'Nam', N'0913332327', N'Vi?t Nam')
SET IDENTITY_INSERT [dbo].[khachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[loaichiphi] ON 

INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (1, N'Chi phí an u?ng')
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (2, N'Chi phí phuong ti?n')
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (3, N'Chi phí quà')
SET IDENTITY_INSERT [dbo].[loaichiphi] OFF
GO
SET IDENTITY_INSERT [dbo].[loaihinhdulich] ON 

INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (1, N'Du l?ch di d?ng')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (2, N'Du l?ch k?t h?p ngh? nghi?p')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (3, N'Du l?ch xã h?i và gia dình')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (4, N'Du l?ch khám phá')
SET IDENTITY_INSERT [dbo].[loaihinhdulich] OFF
GO
SET IDENTITY_INSERT [dbo].[loaikhachhang] ON 

INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang]) VALUES (1, N'Cá nhân')
INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang]) VALUES (2, N'Ðon v?')
SET IDENTITY_INSERT [dbo].[loaikhachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (1, N'Nguy?n Ng?c Qu?nh Nhu', N'Thu ti?n b?o kê')
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (2, N'Giang Th? Phong', N'Lo xe')
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (3, N'Tr?n Tr?ng Ninh', N'Tài x?')
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
GO
SET IDENTITY_INSERT [dbo].[thamgiadoan] ON 

INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (1, 1, 1, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (2, 1, 2, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (3, 1, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[thamgiadoan] OFF
GO
SET IDENTITY_INSERT [dbo].[tour] ON 

INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maDiaDiem], [maGiaTour], [maLoaiHinhDuLich], [soLuongKhachHang], [tongTien], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (2, N'Sài Gòn - Ðà L?t', N'R?t d? choi', 1, 1, 1, 2, 2000000, CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maDiaDiem], [maGiaTour], [maLoaiHinhDuLich], [soLuongKhachHang], [tongTien], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (3, N'Phan Rang - Bình Ð?nh', N'R?t d? choi', 1, 1, 1, 2, 2000000, CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maDiaDiem], [maGiaTour], [maLoaiHinhDuLich], [soLuongKhachHang], [tongTien], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (4, N'C? Chi - Sài Gòn', N'R?t d? choi', 1, 1, 1, 2, 2000000, CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[tour] OFF
GO
USE [master]
GO
ALTER DATABASE [tourdulich] SET  READ_WRITE 
GO
