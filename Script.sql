
/****** Object:  Database [MiniMarket]    Script Date: 11/27/2023 10:47:01 AM ******/
CREATE DATABASE [MiniMarket]
GO
ALTER DATABASE [MiniMarket] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MiniMarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MiniMarket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MiniMarket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MiniMarket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MiniMarket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MiniMarket] SET ARITHABORT OFF 
GO
ALTER DATABASE [MiniMarket] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MiniMarket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MiniMarket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MiniMarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MiniMarket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MiniMarket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MiniMarket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MiniMarket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MiniMarket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MiniMarket] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MiniMarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MiniMarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MiniMarket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MiniMarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MiniMarket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MiniMarket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MiniMarket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MiniMarket] SET RECOVERY FULL 
GO
ALTER DATABASE [MiniMarket] SET  MULTI_USER 
GO
ALTER DATABASE [MiniMarket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MiniMarket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MiniMarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MiniMarket] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MiniMarket] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MiniMarket] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MiniMarket', N'ON'
GO
ALTER DATABASE [MiniMarket] SET QUERY_STORE = OFF
GO
USE [MiniMarket]
GO
/****** Object:  Table [dbo].[BaoCao]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao](
	[idBaoCao] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NULL,
	[ngayLap] [datetime] NULL,
	[idSanPham] [int] NULL,
	[soLuong] [int] NULL,
	[lyDo] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[idBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[idHoaDon] [int] NULL,
	[idSanPham] [int] NULL,
	[soLuong] [int] NULL,
	[donGia] [decimal](10, 2) NULL,
	[tongTien] [decimal](10, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[idPhieuNhap] [int] NULL,
	[idSanPham] [int] NULL,
	[soLuong] [int] NULL,
	[donGia] [decimal](10, 2) NULL,
	[thanhTien] [decimal](10, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[idChucVu] [varchar](10) NOT NULL,
	[tenChucVu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[idHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NULL,
	[idKhachHang] [int] NULL,
	[ngayLap] [datetime] NULL,
	[idKhuyenMai] [int] NULL,
	[tongHoaDon] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[idKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[hoVaTen] [nvarchar](50) NULL,
	[soDienThoai] [varchar](10) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[email] [varchar](50) NULL,
	[ngaySinh] [datetime] NULL,
	[diem] [int] NULL,
	[diaChi] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[idKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[idKhuyenMai] [int] IDENTITY(1,1) NOT NULL,
	[ngayBatDau] [datetime] NULL,
	[ngayKetThuc] [datetime] NULL,
	[tenKhuyenMai] [nvarchar](50) NULL,
	[phanTram] [float] NULL,
	[noiDung] [nvarchar](100) NULL,
	[dieuKien] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[idLoaiSanPham] [int] IDENTITY(1,1) NOT NULL,
	[tenLoaiSanPham] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[idNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[soDienThoai] [varchar](12) NULL,
	[tenNhaCungCap] [nvarchar](200) NULL,
	[diaChi] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[hoVaTen] [nvarchar](50) NULL,
	[soDienThoai] [varchar](10) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[idChucVu] [varchar](10) NULL,
	[luong] [decimal](10, 2) NULL,
	[trangThai] [nvarchar](50) NULL,
	[ngayNghi] [datetime] NULL,
	[ngaySinh] [datetime] NULL,
	[diaChi] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[idNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[idPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NULL,
	[idNhaCungCap] [int] NULL,
	[ngayNhap] [datetime] NULL,
	[tongTien] [decimal](10, 2) NULL
PRIMARY KEY CLUSTERED 
(
	[idPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[idSanPham] [int] IDENTITY(1,1) NOT NULL,
	[idLoaiSanPham] [int] NULL,
	[donGia] [decimal](10, 3) NULL,
	[soLuong] [int] NULL,
	[trangThai] [nvarchar](20) NULL,
	[chietKhau] [int] NULL,
	[tenSanPham] [nvarchar](150) NULL,
	[hinhAnh] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[idSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/27/2023 10:47:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[idTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[username] [char](500) NULL,
	[password] [char](10) NULL,
	[idNhanVien] [int] NULL,
	[quyen] [varchar](MAX) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BaoCao]  WITH CHECK ADD FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([idNhanVien])
GO
ALTER TABLE [dbo].[BaoCao]  WITH CHECK ADD FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SanPham] ([idSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([idHoaDon])
REFERENCES [dbo].[HoaDon] ([idHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SanPham] ([idSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([idPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([idPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SanPham] ([idSanPham])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idKhachHang])
REFERENCES [dbo].[KhachHang] ([idKhachHang])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([idKhuyenMai])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([idNhanVien])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([idChucVu])
REFERENCES [dbo].[ChucVu] ([idChucVu])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([idNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD FOREIGN KEY([idNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([idNhaCungCap])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([idLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([idLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([idLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([idLoaiSanPham])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([idNhanVien])
GO
ALTER DATABASE [MiniMarket] SET  READ_WRITE 
GO
