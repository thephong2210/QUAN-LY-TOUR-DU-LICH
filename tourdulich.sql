USE [master]
GO
/****** Object:  Database [tourdulich]    Script Date: 30/10/2021 7:31:40 PM ******/
alter DATABASE [tourdulich]
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
/****** Object:  Table [dbo].[chiphi]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[dangky]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[diadiemden]    Script Date: 30/10/2021 7:31:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diadiemden](
	[maDiaDiemDen] [int] IDENTITY(1,1) NOT NULL,
	[tenDiaDiemDen] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK__diadiemd__9959D07E25BD4227] PRIMARY KEY CLUSTERED 
(
	[maDiaDiemDen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diadiemthamquan]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[diadiemtour]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[doandulich]    Script Date: 30/10/2021 7:31:40 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[maSoDoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[giatour]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[khachhang]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[loaichiphi]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[loaihinhdulich]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[loaikhachhang]    Script Date: 30/10/2021 7:31:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaikhachhang](
	[maLoaiKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiKhachHang] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[maLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[thamgiadoan]    Script Date: 30/10/2021 7:31:40 PM ******/
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
/****** Object:  Table [dbo].[tour]    Script Date: 30/10/2021 7:31:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tour](
	[maSoTour] [int] IDENTITY(1,1) NOT NULL,
	[tenGoiTour] [nvarchar](100) NOT NULL,
	[dacDiem] [nvarchar](100) NOT NULL,
	[maGiaTour] [int] NOT NULL,
	[maLoaiHinhDuLich] [int] NOT NULL,
	[soLuongKhachHang] [int] NOT NULL,
	[tongTien] [float] NOT NULL,
	[thoiGianBatDau] [datetime2](6) NOT NULL,
	[thoiGianKetThuc] [datetime2](6) NOT NULL,
	[maDiaDiemDen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maSoTour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[dangky] ON 

INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan]) VALUES (1, 1, 1, 1, CAST(N'2008-01-01' AS Date), 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan]) VALUES (2, 1, 1, 1, CAST(N'2008-01-01' AS Date), 1)
INSERT [dbo].[dangky] ([id], [maSoKhachHang], [maTour], [maLoaiKhachHang], [ngayDangKy], [maSoDoan]) VALUES (3, 1, 1, 1, CAST(N'2008-01-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[dangky] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemden] ON 

INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen]) VALUES (1, N'Đà Lạt')
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen]) VALUES (2, N'Củ Chi')
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen]) VALUES (3, N'TP Hồ Chí Minh')
INSERT [dbo].[diadiemden] ([maDiaDiemDen], [tenDiaDiemDen]) VALUES (4, N'Sa Pa')
SET IDENTITY_INSERT [dbo].[diadiemden] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemthamquan] ON 

INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (1, N'Thiền Viện Trúc Lâm', 1)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (2, N'Chè Cầu Ðất', 1)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (3, N'Khu di tích địa đạo Củ Chi', 2)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (4, N'Chùa Bửu Long', 3)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (5, N'Núi hàm Rồng', 4)
INSERT [dbo].[diadiemthamquan] ([maDiaDiem], [tenDiaDiem], [maDiaDiemDen]) VALUES (6, N'Hồ Xuân Hương', 1)
SET IDENTITY_INSERT [dbo].[diadiemthamquan] OFF
GO
SET IDENTITY_INSERT [dbo].[diadiemtour] ON 

INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (1, 2, N'Thiền Viện Trúc Lâm')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (2, 2, N'Chè Cầu Đất')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (3, 3, N'Khu di tích địa đạo Củ Chi')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (4, 4, N'Thiền Viện Trúc Lâm')
INSERT [dbo].[diadiemtour] ([id], [maTour], [tenDiaDiemThamQuan]) VALUES (5, 4, N'Hồ Xuân Hương')
SET IDENTITY_INSERT [dbo].[diadiemtour] OFF
GO
SET IDENTITY_INSERT [dbo].[doandulich] ON 

INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour]) VALUES (1, N'Ðoàn Ðại học Sài Gòn', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', 1)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour]) VALUES (2, N'Sài Gòn - Ðà Lạt', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', 2)
INSERT [dbo].[doandulich] ([maSoDoan], [tenGoiDoan], [soLuongKhachHang], [SoLuongNhanVien], [thoiGianKhoiHanh], [thoiGianKetThuc], [chiTiet], [maSoTour]) VALUES (3, N'Ðoàn anh em cây khế', 20, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), N'Thích đi đâu thì đi', 3)
SET IDENTITY_INSERT [dbo].[doandulich] OFF
GO
SET IDENTITY_INSERT [dbo].[giatour] ON 

INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (1, 1, 5000000, N'Bình thường')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (2, 2, 10000000, N'Tết nguyên đán')
INSERT [dbo].[giatour] ([id], [maGiaTour], [gia], [dieuKien]) VALUES (3, 3, 2000000, N'Ðồng giá 2 triệu')
SET IDENTITY_INSERT [dbo].[giatour] OFF
GO
SET IDENTITY_INSERT [dbo].[khachhang] ON 

INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (1, N'Nguyễn Thị Bé Ba', N'2453453454', N'41 Nguyễn Trãi, Phường 1, Quận 5, TP HCM', N'Nữ', N'0961231232', N'Việt Nam')
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (2, N'Nguyễn Văn Nam', N'3342454443', N'41/343 Nguyễn Biểu, Phường 1, Quận 5, TP HCM', N'Nam', N'0962342343', N'Việt Nam')
INSERT [dbo].[khachhang] ([maSoKhachHang], [hoTenKhachHang], [soCMND], [diaChi], [gioiTinh], [SDT], [quocTich]) VALUES (3, N'Trần Văn', N'2939499392', N'273 An Dương Vương, Phường 3, Quận 5, TP HCM', N'Nam', N'0913332327', N'Việt Nam')
SET IDENTITY_INSERT [dbo].[khachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[loaichiphi] ON 

INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (1, N'Chi phí ăn uống')
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (2, N'Chi phí phương tiện')
INSERT [dbo].[loaichiphi] ([maLoaiChiPhi], [tenLoaiChiPhi]) VALUES (3, N'Chi phí quà')
SET IDENTITY_INSERT [dbo].[loaichiphi] OFF
GO
SET IDENTITY_INSERT [dbo].[loaihinhdulich] ON 

INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (1, N'Du lịch di động')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (2, N'Du lịch kết hợp nghề nghiệp')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (3, N'Du lịch xã hội và gia đình')
INSERT [dbo].[loaihinhdulich] ([maLoaiHinhDuLich], [tenLoaiHinhDuLich]) VALUES (4, N'Du lịch khám phá')
SET IDENTITY_INSERT [dbo].[loaihinhdulich] OFF
GO
SET IDENTITY_INSERT [dbo].[loaikhachhang] ON 

INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang]) VALUES (1, N'Cá nhân')
INSERT [dbo].[loaikhachhang] ([maLoaiKhachHang], [tenLoaiKhachHang]) VALUES (2, N'Ðơn vị')
SET IDENTITY_INSERT [dbo].[loaikhachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[nhanvien] ON 

INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (1, N'Nguyễn Ngọc Quỳnh Như', N'Thu tiền bảo kê')
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (2, N'Giang Thế Phong', N'Lơ xe')
INSERT [dbo].[nhanvien] ([maNhanVien], [tenNhanVien], [nhiemVu]) VALUES (3, N'Trần Trọng Ninh', N'Tài xế')
SET IDENTITY_INSERT [dbo].[nhanvien] OFF
GO
SET IDENTITY_INSERT [dbo].[thamgiadoan] ON 

INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (1, 1, 1, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (2, 1, 2, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[thamgiadoan] ([maThamGia], [maNhanVien], [maSoDoan], [thoiGianBatDau], [thoiGianKetThuc]) VALUES (3, 1, 3, CAST(N'2008-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2008-01-02T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[thamgiadoan] OFF
GO
SET IDENTITY_INSERT [dbo].[tour] ON 

INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maGiaTour], [maLoaiHinhDuLich], [soLuongKhachHang], [tongTien], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen]) VALUES (2, N'TP Hồ Chí Minh - Ðà Lạt', N'Rất dễ chơi', 1, 1, 2, 2000000, CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maGiaTour], [maLoaiHinhDuLich], [soLuongKhachHang], [tongTien], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen]) VALUES (3, N'Phan Rang - Củ Chi', N'Rất dễ choi', 1, 1, 2, 2000000, CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), 2)
INSERT [dbo].[tour] ([maSoTour], [tenGoiTour], [dacDiem], [maGiaTour], [maLoaiHinhDuLich], [soLuongKhachHang], [tongTien], [thoiGianBatDau], [thoiGianKetThuc], [maDiaDiemDen]) VALUES (4, N'Củ Chi - Đà Lạt', N'Rất dễ choi', 1, 1, 2, 2000000, CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), CAST(N'2008-11-11T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[tour] OFF
GO
USE [master]
GO
ALTER DATABASE [tourdulich] SET  READ_WRITE 
GO
