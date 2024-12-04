USE [master]
GO
/****** Object:  Database [QL_DOAN_TEST_2]    Script Date: 04/12/2024 5:53:11 CH ******/
CREATE DATABASE [QL_DOAN_TEST_2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_DOAN_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QL_DOAN_TEST_2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB ), 
 FILEGROUP [QL_DOAN_FS] CONTAINS FILESTREAM  DEFAULT
( NAME = N'QL_DOAN_STREAM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QL_DOAN_STREAM_TEST_2' , MAXSIZE = UNLIMITED)
 LOG ON 
( NAME = N'QL_DOAN_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QL_DOAN_log_TEST_2.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_DOAN_TEST_2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET  MULTI_USER 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET QUERY_STORE = ON
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QL_DOAN_TEST_2]
GO
/****** Object:  Table [dbo].[BaoCaoTienDo]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCaoTienDo](
	[MaBaoCao] [varchar](10) NOT NULL,
	[TuanThu] [int] NOT NULL,
	[NgayBaoCao] [datetime] NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[CoMat] [bit] NOT NULL,
	[MaNhom] [varchar](10) NOT NULL,
	[MaGiangVien] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoMon]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoMon](
	[MaBoMon] [varchar](10) NOT NULL,
	[TenBoMon] [nvarchar](100) NOT NULL,
	[MaKhoa] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBoMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangKyDeTai]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangKyDeTai](
	[MaDangKyDeTai] [varchar](10) NOT NULL,
	[NgayDangKy] [datetime] NOT NULL,
	[MaNhom] [varchar](10) NOT NULL,
	[MaDeTai] [varchar](10) NOT NULL,
	[MaThoiGianDangKy] [varchar](10) NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDangKyDeTai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGiaBaoCaoTienDo]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGiaBaoCaoTienDo](
	[MaDanhGia] [varchar](10) NOT NULL,
	[MaBaoCao] [varchar](10) NOT NULL,
	[NgayDanhGia] [datetime] NOT NULL,
	[NoiDung] [nvarchar](max) NULL,
	[MaNhom] [varchar](10) NOT NULL,
	[MaGiangVien] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeTai]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeTai](
	[MaDeTai] [varchar](10) NOT NULL,
	[TenDeTai] [nvarchar](max) NOT NULL,
	[MoTa] [nvarchar](max) NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[NgayDeXuat] [datetime] NOT NULL,
	[NgayDuyet] [datetime] NULL,
	[DaChinhSua] [bit] NULL,
	[CapNhatLanCuoi] [datetime] NULL,
	[MaGVHuongDan] [varchar](10) NOT NULL,
	[MaGVPhanBien] [varchar](10) NULL,
	[MaBoMon] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDeTai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoAnVaDiem]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoAnVaDiem](
	[MaDeTai] [varchar](10) NOT NULL,
	[Id] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[NgayNopDoAn] [date] NULL,
	[NoiDungDoAn] [varbinary](max) FILESTREAM  NULL,
	[DiemGVHuongDan] [float] NULL,
	[DiemGVPhanBien] [float] NULL,
	[DiemCuoiCung] [float] NULL,
	[NhanXet] [nvarchar](max) NULL,
	[NgayCham] [datetime] NULL,
	[MaNhom] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDeTai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY] FILESTREAM_ON [QL_DOAN_FS],
UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY] FILESTREAM_ON [QL_DOAN_FS]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGiangVien] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[Email] [varchar](100) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[MaBoMon] [varchar](10) NOT NULL,
	[TenDangNhap] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVuKhoa]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVuKhoa](
	[MaGiaoVu] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[Email] [varchar](100) NULL,
	[MaKhoa] [varchar](10) NOT NULL,
	[TenDangNhap] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaoVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[MaHocKy] [varchar](10) NOT NULL,
	[TenHocKy] [nvarchar](10) NULL,
	[MaNamHoc] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](10) NOT NULL,
	[TenKhoa] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuChinhSuaDeTai]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuChinhSuaDeTai](
	[MaLichSu] [int] IDENTITY(1,1) NOT NULL,
	[MaDeTai] [varchar](10) NOT NULL,
	[TruongChinhSua] [nvarchar](255) NOT NULL,
	[GiaTriCu] [nvarchar](max) NOT NULL,
	[GiaTriMoi] [nvarchar](max) NOT NULL,
	[ThoiGianChinhSua] [datetime] NULL,
	[NguoiChinhSua] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLichSu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuTrangThaiDeTai]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuTrangThaiDeTai](
	[MaTrangThai] [int] IDENTITY(1,1) NOT NULL,
	[MaDeTai] [varchar](10) NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
	[ThoiGianThayDoi] [datetime] NOT NULL,
	[NguoiThayDoi] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](10) NOT NULL,
	[TenLop] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ManHinh]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ManHinh](
	[MaManHinh] [varchar](10) NOT NULL,
	[TenManHinh] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NamHoc]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NamHoc](
	[MaNamHoc] [varchar](10) NOT NULL,
	[TenNamHoc] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNamHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[TenDangNhap] [varchar](100) NOT NULL,
	[MatKhau] [varchar](100) NOT NULL,
	[HoatDong] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung_NhomNguoiDung]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung_NhomNguoiDung](
	[TenDangNhap] [varchar](100) NOT NULL,
	[MaNhomNguoiDung] [varchar](100) NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomNguoiDung]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNguoiDung](
	[MaNhomNguoiDung] [varchar](100) NOT NULL,
	[TenNhomNguoiDung] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomSinhVien]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSinhVien](
	[MaNhom] [varchar](10) NOT NULL,
	[NgayDangKy] [datetime] NOT NULL,
	[DaDuyet] [bit] NULL,
	[MaNhomTruong] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaNhomNguoiDung] [varchar](100) NOT NULL,
	[MaManHinh] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[NamSinh] [date] NULL,
	[Email] [varchar](100) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[MaLop] [varchar](10) NOT NULL,
	[MaKhoa] [varchar](10) NOT NULL,
	[TenDangNhap] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhVienNhom]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVienNhom](
	[MaNhom] [varchar](10) NOT NULL,
	[MaSinhVien] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiGianDangKy]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiGianDangKy](
	[MaThoiGianDangKy] [varchar](10) NOT NULL,
	[MaHocKy] [varchar](10) NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NOT NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThoiGianDangKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[YeuCauChinhSua]    Script Date: 04/12/2024 5:53:11 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YeuCauChinhSua](
	[MaYeuCau] [int] IDENTITY(1,1) NOT NULL,
	[MaDeTai] [varchar](10) NOT NULL,
	[TruongCanChinhSua] [nvarchar](255) NOT NULL,
	[YeuCau] [nvarchar](max) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NguoiYeuCau] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaYeuCau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[BoMon] ([MaBoMon], [TenBoMon], [MaKhoa]) VALUES (N'CNPM', N'Công nghệ phần mềm', N'CNTT')
INSERT [dbo].[BoMon] ([MaBoMon], [TenBoMon], [MaKhoa]) VALUES (N'HTTT', N'Hệ thống thông tin', N'CNTT')
INSERT [dbo].[BoMon] ([MaBoMon], [TenBoMon], [MaKhoa]) VALUES (N'TT', N'Trí tuệ nhân tạo', N'CNTT')
GO
INSERT [dbo].[DeTai] ([MaDeTai], [TenDeTai], [MoTa], [TrangThai], [NgayDeXuat], [NgayDuyet], [DaChinhSua], [CapNhatLanCuoi], [MaGVHuongDan], [MaGVPhanBien], [MaBoMon]) VALUES (N'DT001', N'Nghiên cứu AI trong giáo dục', N'Ứng dụng trí tuệ nhân tạo để cải thiện trải nghiệm học tập.', N'Từ chối', CAST(N'2024-12-03T12:07:35.663' AS DateTime), NULL, 0, CAST(N'2024-12-03T12:07:35.737' AS DateTime), N'GV101', NULL, N'CNPM')
INSERT [dbo].[DeTai] ([MaDeTai], [TenDeTai], [MoTa], [TrangThai], [NgayDeXuat], [NgayDuyet], [DaChinhSua], [CapNhatLanCuoi], [MaGVHuongDan], [MaGVPhanBien], [MaBoMon]) VALUES (N'DT002', N'Thiết kế hệ thống IoT cho công nghiệp', N'Tích hợp cảm biến và mạng lưới để giám sát môi trường trồng trọt.', N'Cần chỉnh sửa', CAST(N'2024-12-03T23:11:44.393' AS DateTime), NULL, 0, CAST(N'2024-12-03T23:11:44.450' AS DateTime), N'GV101', NULL, N'CNPM')
INSERT [dbo].[DeTai] ([MaDeTai], [TenDeTai], [MoTa], [TrangThai], [NgayDeXuat], [NgayDuyet], [DaChinhSua], [CapNhatLanCuoi], [MaGVHuongDan], [MaGVPhanBien], [MaBoMon]) VALUES (N'DT003', N'Nghiên cứu tác động của biến đổi khí hậu', N'Đánh giá tác động của biến đổi khí hậu lên môi trường.', N'Đề xuất', CAST(N'2024-12-04T00:07:20.530' AS DateTime), NULL, 0, CAST(N'2024-12-04T00:07:20.593' AS DateTime), N'GV101', NULL, N'CNPM')
INSERT [dbo].[DeTai] ([MaDeTai], [TenDeTai], [MoTa], [TrangThai], [NgayDeXuat], [NgayDuyet], [DaChinhSua], [CapNhatLanCuoi], [MaGVHuongDan], [MaGVPhanBien], [MaBoMon]) VALUES (N'DT004', N'Phát triển ứng dụng quản lý sinh viên', N'Xây dựng ứng dụng di động hỗ trợ quản lý thông tin sinh viên.', N'Đề xuất', CAST(N'2024-12-04T00:10:29.713' AS DateTime), NULL, 0, CAST(N'2024-12-04T00:10:29.760' AS DateTime), N'GV101', NULL, N'CNPM')
INSERT [dbo].[DeTai] ([MaDeTai], [TenDeTai], [MoTa], [TrangThai], [NgayDeXuat], [NgayDuyet], [DaChinhSua], [CapNhatLanCuoi], [MaGVHuongDan], [MaGVPhanBien], [MaBoMon]) VALUES (N'DT005', N'dd', N'dddd', N'Đề xuất', CAST(N'2024-12-04T00:13:13.047' AS DateTime), NULL, 0, CAST(N'2024-12-04T00:13:13.087' AS DateTime), N'GV101', NULL, N'CNPM')
INSERT [dbo].[DeTai] ([MaDeTai], [TenDeTai], [MoTa], [TrangThai], [NgayDeXuat], [NgayDuyet], [DaChinhSua], [CapNhatLanCuoi], [MaGVHuongDan], [MaGVPhanBien], [MaBoMon]) VALUES (N'DT006', N'dd', N'dddd', N'Đề xuất', CAST(N'2024-12-04T00:13:30.353' AS DateTime), NULL, 0, CAST(N'2024-12-04T00:13:30.370' AS DateTime), N'GV101', NULL, N'CNPM')
GO
INSERT [dbo].[GiangVien] ([MaGiangVien], [HoTen], [Email], [SoDienThoai], [MaBoMon], [TenDangNhap]) VALUES (N'GV101', N'Phạm Văn An', N'anpv@example.com', N'0901234567', N'CNPM', N'gv001')
INSERT [dbo].[GiangVien] ([MaGiangVien], [HoTen], [Email], [SoDienThoai], [MaBoMon], [TenDangNhap]) VALUES (N'GV102', N'Lê Thị Bình', N'binhlt@example.com', N'0912345678', N'TT', N'gv002')
INSERT [dbo].[GiangVien] ([MaGiangVien], [HoTen], [Email], [SoDienThoai], [MaBoMon], [TenDangNhap]) VALUES (N'GV103', N'Trần Đức Cường', N'cuongtd@example.com', N'0923456789', N'HTTT', N'gv003')
INSERT [dbo].[GiangVien] ([MaGiangVien], [HoTen], [Email], [SoDienThoai], [MaBoMon], [TenDangNhap]) VALUES (N'GV104', N'Nguyễn Thị Dung', N'dungnt@example.com', N'0934567890', N'HTTT', N'gv004')
GO
INSERT [dbo].[GiaoVuKhoa] ([MaGiaoVu], [HoTen], [Email], [MaKhoa], [TenDangNhap]) VALUES (N'GV001', N'Nguyễn Thị Minh', N'minhnt@example.com', N'CNTT', N'giaovu1')
INSERT [dbo].[GiaoVuKhoa] ([MaGiaoVu], [HoTen], [Email], [MaKhoa], [TenDangNhap]) VALUES (N'GV002', N'Trần Văn Hoàng', N'hoangtv@example.com', N'CNTT', N'giaovu2')
GO
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy], [MaNamHoc]) VALUES (N'HK1_2223', N'Học kỳ 1', N'NH2223')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy], [MaNamHoc]) VALUES (N'HK1_2324', N'Học kỳ 1', N'NH2324')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy], [MaNamHoc]) VALUES (N'HK2_2223', N'Học kỳ 2', N'NH2223')
INSERT [dbo].[HocKy] ([MaHocKy], [TenHocKy], [MaNamHoc]) VALUES (N'HK2_2324', N'Học kỳ 2', N'NH2324')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Công nghệ thông tin')
GO
SET IDENTITY_INSERT [dbo].[LichSuChinhSuaDeTai] ON 

INSERT [dbo].[LichSuChinhSuaDeTai] ([MaLichSu], [MaDeTai], [TruongChinhSua], [GiaTriCu], [GiaTriMoi], [ThoiGianChinhSua], [NguoiChinhSua]) VALUES (2, N'DT002', N'Tên đề tài', N'Thiết kế hệ thống IoT cho nông nghiệp', N'Thiết kế hệ thống IoT cho công nghiệp', CAST(N'2024-12-04T12:22:10.247' AS DateTime), N'GV101')
SET IDENTITY_INSERT [dbo].[LichSuChinhSuaDeTai] OFF
GO
SET IDENTITY_INSERT [dbo].[LichSuTrangThaiDeTai] ON 

INSERT [dbo].[LichSuTrangThaiDeTai] ([MaTrangThai], [MaDeTai], [TrangThai], [ThoiGianThayDoi], [NguoiThayDoi]) VALUES (5, N'DT005', N'Đề xuất', CAST(N'2024-12-04T00:13:13.100' AS DateTime), N'GV101')
INSERT [dbo].[LichSuTrangThaiDeTai] ([MaTrangThai], [MaDeTai], [TrangThai], [ThoiGianThayDoi], [NguoiThayDoi]) VALUES (6, N'DT006', N'Đề xuất', CAST(N'2024-12-04T00:13:30.383' AS DateTime), N'GV101')
SET IDENTITY_INSERT [dbo].[LichSuTrangThaiDeTai] OFF
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (N'12DHTH01', N'12DHTH01')
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (N'12DHTH02', N'12DHTH02')
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (N'13DHTH01', N'13DHTH01')
INSERT [dbo].[Lop] ([MaLop], [TenLop]) VALUES (N'13DHTH02', N'13DHTH02')
GO
INSERT [dbo].[NamHoc] ([MaNamHoc], [TenNamHoc]) VALUES (N'NH2223', N'2022-2023')
INSERT [dbo].[NamHoc] ([MaNamHoc], [TenNamHoc]) VALUES (N'NH2324', N'2023-2024')
INSERT [dbo].[NamHoc] ([MaNamHoc], [TenNamHoc]) VALUES (N'NH2425', N'2024-2025')
GO
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'giaovu1', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'giaovu2', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'gv001', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'gv002', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'gv003', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'gv004', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'sv001', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'sv002', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'sv003', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'sv004', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'sv005', N'123456', 1)
INSERT [dbo].[NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'sv006', N'123456', 1)
GO
INSERT [dbo].[NhomSinhVien] ([MaNhom], [NgayDangKy], [DaDuyet], [MaNhomTruong]) VALUES (N'N001', CAST(N'2023-09-02T00:00:00.000' AS DateTime), 1, N'SV001')
INSERT [dbo].[NhomSinhVien] ([MaNhom], [NgayDangKy], [DaDuyet], [MaNhomTruong]) VALUES (N'N002', CAST(N'2023-09-03T00:00:00.000' AS DateTime), 1, N'SV003')
INSERT [dbo].[NhomSinhVien] ([MaNhom], [NgayDangKy], [DaDuyet], [MaNhomTruong]) VALUES (N'N003', CAST(N'2023-09-04T00:00:00.000' AS DateTime), 0, N'SV005')
GO
INSERT [dbo].[SinhVien] ([MaSinhVien], [HoTen], [GioiTinh], [NamSinh], [Email], [SoDienThoai], [MaLop], [MaKhoa], [TenDangNhap]) VALUES (N'SV001', N'Nguyễn Văn Nam', N'Nam', CAST(N'2002-01-15' AS Date), N'namnv@example.com', N'0945678901', N'12DHTH01', N'CNTT', N'sv001')
INSERT [dbo].[SinhVien] ([MaSinhVien], [HoTen], [GioiTinh], [NamSinh], [Email], [SoDienThoai], [MaLop], [MaKhoa], [TenDangNhap]) VALUES (N'SV002', N'Trần Thị Hoa', N'Nữ', CAST(N'2002-03-20' AS Date), N'hoatt@example.com', N'0956789012', N'12DHTH01', N'CNTT', N'sv002')
INSERT [dbo].[SinhVien] ([MaSinhVien], [HoTen], [GioiTinh], [NamSinh], [Email], [SoDienThoai], [MaLop], [MaKhoa], [TenDangNhap]) VALUES (N'SV003', N'Lê Văn Đức', N'Nam', CAST(N'2002-05-10' AS Date), N'duclv@example.com', N'0967890123', N'12DHTH02', N'CNTT', N'sv003')
INSERT [dbo].[SinhVien] ([MaSinhVien], [HoTen], [GioiTinh], [NamSinh], [Email], [SoDienThoai], [MaLop], [MaKhoa], [TenDangNhap]) VALUES (N'SV004', N'Phạm Thị Mai', N'Nữ', CAST(N'2002-07-25' AS Date), N'maipt@example.com', N'0978901234', N'12DHTH02', N'CNTT', N'sv004')
INSERT [dbo].[SinhVien] ([MaSinhVien], [HoTen], [GioiTinh], [NamSinh], [Email], [SoDienThoai], [MaLop], [MaKhoa], [TenDangNhap]) VALUES (N'SV005', N'Hoàng Văn Long', N'Nam', CAST(N'2002-09-30' AS Date), N'longhv@example.com', N'0989012345', N'13DHTH01', N'CNTT', N'sv005')
INSERT [dbo].[SinhVien] ([MaSinhVien], [HoTen], [GioiTinh], [NamSinh], [Email], [SoDienThoai], [MaLop], [MaKhoa], [TenDangNhap]) VALUES (N'SV006', N'Vũ Thị Lan', N'Nữ', CAST(N'2002-11-05' AS Date), N'lanvt@example.com', N'0990123456', N'13DHTH02', N'CNTT', N'sv006')
GO
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSinhVien]) VALUES (N'N001', N'SV001')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSinhVien]) VALUES (N'N001', N'SV002')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSinhVien]) VALUES (N'N002', N'SV003')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSinhVien]) VALUES (N'N002', N'SV004')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSinhVien]) VALUES (N'N003', N'SV005')
INSERT [dbo].[ThanhVienNhom] ([MaNhom], [MaSinhVien]) VALUES (N'N003', N'SV006')
GO
INSERT [dbo].[ThoiGianDangKy] ([MaThoiGianDangKy], [MaHocKy], [NgayBatDau], [NgayKetThuc], [TrangThai]) VALUES (N'TGDK1', N'HK1_2324', CAST(N'2023-09-01T00:00:00.000' AS DateTime), CAST(N'2023-09-15T00:00:00.000' AS DateTime), N'Đã đóng')
INSERT [dbo].[ThoiGianDangKy] ([MaThoiGianDangKy], [MaHocKy], [NgayBatDau], [NgayKetThuc], [TrangThai]) VALUES (N'TGDK2', N'HK2_2324', CAST(N'2024-01-15T00:00:00.000' AS DateTime), CAST(N'2024-01-30T00:00:00.000' AS DateTime), N'Đang mở')
GO
SET IDENTITY_INSERT [dbo].[YeuCauChinhSua] ON 

INSERT [dbo].[YeuCauChinhSua] ([MaYeuCau], [MaDeTai], [TruongCanChinhSua], [YeuCau], [NgayTao], [NguoiYeuCau]) VALUES (8, N'DT002', N'Tên đề tài', N'Tên đề tài không rõ ràng', CAST(N'2024-12-03T23:36:40.220' AS DateTime), N'GV101')
SET IDENTITY_INSERT [dbo].[YeuCauChinhSua] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_NhomDeTai]    Script Date: 04/12/2024 5:53:12 CH ******/
ALTER TABLE [dbo].[DangKyDeTai] ADD  CONSTRAINT [UQ_NhomDeTai] UNIQUE NONCLUSTERED 
(
	[MaNhom] ASC,
	[MaDeTai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DeTai] ADD  DEFAULT ((0)) FOR [DaChinhSua]
GO
ALTER TABLE [dbo].[DeTai] ADD  DEFAULT (getdate()) FOR [CapNhatLanCuoi]
GO
ALTER TABLE [dbo].[DoAnVaDiem] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[LichSuChinhSuaDeTai] ADD  DEFAULT (getdate()) FOR [ThoiGianChinhSua]
GO
ALTER TABLE [dbo].[LichSuTrangThaiDeTai] ADD  DEFAULT (getdate()) FOR [ThoiGianThayDoi]
GO
ALTER TABLE [dbo].[NguoiDung] ADD  DEFAULT ((1)) FOR [HoatDong]
GO
ALTER TABLE [dbo].[NhomSinhVien] ADD  DEFAULT ((0)) FOR [DaDuyet]
GO
ALTER TABLE [dbo].[YeuCauChinhSua] ADD  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[BaoCaoTienDo]  WITH CHECK ADD FOREIGN KEY([MaGiangVien])
REFERENCES [dbo].[GiangVien] ([MaGiangVien])
GO
ALTER TABLE [dbo].[BaoCaoTienDo]  WITH CHECK ADD FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomSinhVien] ([MaNhom])
GO
ALTER TABLE [dbo].[BoMon]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[DangKyDeTai]  WITH CHECK ADD FOREIGN KEY([MaDeTai])
REFERENCES [dbo].[DeTai] ([MaDeTai])
GO
ALTER TABLE [dbo].[DangKyDeTai]  WITH CHECK ADD FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomSinhVien] ([MaNhom])
GO
ALTER TABLE [dbo].[DangKyDeTai]  WITH CHECK ADD FOREIGN KEY([MaThoiGianDangKy])
REFERENCES [dbo].[ThoiGianDangKy] ([MaThoiGianDangKy])
GO
ALTER TABLE [dbo].[DanhGiaBaoCaoTienDo]  WITH CHECK ADD FOREIGN KEY([MaBaoCao])
REFERENCES [dbo].[BaoCaoTienDo] ([MaBaoCao])
GO
ALTER TABLE [dbo].[DanhGiaBaoCaoTienDo]  WITH CHECK ADD FOREIGN KEY([MaGiangVien])
REFERENCES [dbo].[GiangVien] ([MaGiangVien])
GO
ALTER TABLE [dbo].[DanhGiaBaoCaoTienDo]  WITH CHECK ADD FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomSinhVien] ([MaNhom])
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD FOREIGN KEY([MaBoMon])
REFERENCES [dbo].[BoMon] ([MaBoMon])
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD FOREIGN KEY([MaGVHuongDan])
REFERENCES [dbo].[GiangVien] ([MaGiangVien])
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD FOREIGN KEY([MaGVPhanBien])
REFERENCES [dbo].[GiangVien] ([MaGiangVien])
GO
ALTER TABLE [dbo].[DoAnVaDiem]  WITH CHECK ADD FOREIGN KEY([MaDeTai])
REFERENCES [dbo].[DeTai] ([MaDeTai])
GO
ALTER TABLE [dbo].[DoAnVaDiem]  WITH CHECK ADD FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomSinhVien] ([MaNhom])
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD FOREIGN KEY([MaBoMon])
REFERENCES [dbo].[BoMon] ([MaBoMon])
GO
ALTER TABLE [dbo].[GiangVien]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NguoiDung] ([TenDangNhap])
GO
ALTER TABLE [dbo].[GiaoVuKhoa]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[GiaoVuKhoa]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NguoiDung] ([TenDangNhap])
GO
ALTER TABLE [dbo].[HocKy]  WITH CHECK ADD FOREIGN KEY([MaNamHoc])
REFERENCES [dbo].[NamHoc] ([MaNamHoc])
GO
ALTER TABLE [dbo].[LichSuChinhSuaDeTai]  WITH CHECK ADD FOREIGN KEY([MaDeTai])
REFERENCES [dbo].[DeTai] ([MaDeTai])
GO
ALTER TABLE [dbo].[LichSuChinhSuaDeTai]  WITH CHECK ADD FOREIGN KEY([NguoiChinhSua])
REFERENCES [dbo].[GiangVien] ([MaGiangVien])
GO
ALTER TABLE [dbo].[LichSuTrangThaiDeTai]  WITH CHECK ADD FOREIGN KEY([MaDeTai])
REFERENCES [dbo].[DeTai] ([MaDeTai])
GO
ALTER TABLE [dbo].[LichSuTrangThaiDeTai]  WITH CHECK ADD FOREIGN KEY([NguoiThayDoi])
REFERENCES [dbo].[GiangVien] ([MaGiangVien])
GO
ALTER TABLE [dbo].[NguoiDung_NhomNguoiDung]  WITH CHECK ADD FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[NhomNguoiDung] ([MaNhomNguoiDung])
GO
ALTER TABLE [dbo].[NguoiDung_NhomNguoiDung]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NguoiDung] ([TenDangNhap])
GO
ALTER TABLE [dbo].[NhomSinhVien]  WITH CHECK ADD FOREIGN KEY([MaNhomTruong])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[ManHinh] ([MaManHinh])
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[NhomNguoiDung] ([MaNhomNguoiDung])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NguoiDung] ([TenDangNhap])
GO
ALTER TABLE [dbo].[ThanhVienNhom]  WITH CHECK ADD FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomSinhVien] ([MaNhom])
GO
ALTER TABLE [dbo].[ThanhVienNhom]  WITH CHECK ADD FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[ThoiGianDangKy]  WITH CHECK ADD FOREIGN KEY([MaHocKy])
REFERENCES [dbo].[HocKy] ([MaHocKy])
GO
ALTER TABLE [dbo].[YeuCauChinhSua]  WITH CHECK ADD FOREIGN KEY([MaDeTai])
REFERENCES [dbo].[DeTai] ([MaDeTai])
GO
ALTER TABLE [dbo].[YeuCauChinhSua]  WITH CHECK ADD FOREIGN KEY([NguoiYeuCau])
REFERENCES [dbo].[GiangVien] ([MaGiangVien])
GO
ALTER TABLE [dbo].[BaoCaoTienDo]  WITH CHECK ADD  CONSTRAINT [CHK_TuanBaoCao] CHECK  (([TuanThu]>=(1) AND [TuanThu]<=(10)))
GO
ALTER TABLE [dbo].[BaoCaoTienDo] CHECK CONSTRAINT [CHK_TuanBaoCao]
GO
ALTER TABLE [dbo].[DangKyDeTai]  WITH CHECK ADD  CONSTRAINT [CHK_TrangThaiDangKyDeTai] CHECK  (([TrangThai]=N'Đã hủy' OR [TrangThai]=N'Đã đăng ký'))
GO
ALTER TABLE [dbo].[DangKyDeTai] CHECK CONSTRAINT [CHK_TrangThaiDangKyDeTai]
GO
ALTER TABLE [dbo].[DeTai]  WITH CHECK ADD  CONSTRAINT [CHK_TrangThaiDeTai] CHECK  (([TrangThai]=N'Hoàn thành' OR [TrangThai]=N'Đã đăng ký' OR [TrangThai]=N'Chấp nhận' OR [TrangThai]=N'Từ chối' OR [TrangThai]=N'Cần chỉnh sửa' OR [TrangThai]=N'Đề xuất'))
GO
ALTER TABLE [dbo].[DeTai] CHECK CONSTRAINT [CHK_TrangThaiDeTai]
GO
ALTER TABLE [dbo].[DoAnVaDiem]  WITH CHECK ADD  CONSTRAINT [CHK_DiemHopLe] CHECK  (([DiemGVHuongDan]>=(0) AND [DiemGVHuongDan]<=(10) AND ([DiemGVPhanBien]>=(0) AND [DiemGVPhanBien]<=(10)) AND ([DiemCuoiCung]>=(0) AND [DiemCuoiCung]<=(10))))
GO
ALTER TABLE [dbo].[DoAnVaDiem] CHECK CONSTRAINT [CHK_DiemHopLe]
GO
ALTER TABLE [dbo].[LichSuTrangThaiDeTai]  WITH CHECK ADD  CONSTRAINT [CHK_LichSuTrangThaiDeTai] CHECK  (([TrangThai]=N'Hoàn thành' OR [TrangThai]=N'Đã đăng ký' OR [TrangThai]=N'Chấp nhận' OR [TrangThai]=N'Từ chối' OR [TrangThai]=N'Cần chỉnh sửa' OR [TrangThai]=N'Đề xuất'))
GO
ALTER TABLE [dbo].[LichSuTrangThaiDeTai] CHECK CONSTRAINT [CHK_LichSuTrangThaiDeTai]
GO
ALTER TABLE [dbo].[ThoiGianDangKy]  WITH CHECK ADD  CONSTRAINT [CHK_TrangThaiDangKy] CHECK  (([TrangThai]=N'Đã đóng' OR [TrangThai]=N'Đang mở' OR [TrangThai]=N'Chưa mở'))
GO
ALTER TABLE [dbo].[ThoiGianDangKy] CHECK CONSTRAINT [CHK_TrangThaiDangKy]
GO
USE [master]
GO
ALTER DATABASE [QL_DOAN_TEST_2] SET  READ_WRITE 
GO
