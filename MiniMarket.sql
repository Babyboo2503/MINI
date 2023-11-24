CREATE MiniMarket
GO
USE [MiniMarket]
GO
/****** Object:  Table [dbo].[BaoCao]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoCao](
	[idBaoCao] [int] NULL,
	[idNhanVien] [int] NULL,
	[ngayLap] [datetime] NULL,
	[idSanPham] [int] NULL,
	[soLuong] [int] NULL,
	[lyDo] [nvarchar](1000) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[idHoaDon] [int] NULL,
	[idSanPham] [int] NULL,
	[soLuong] [int] NULL,
	[donGia] [decimal](10, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[idPhieuNhap] [int] NULL,
	[idSanPham] [int] NULL,
	[soLuong] [int] NULL,
	[donGia] [decimal](10, 2) NULL,
	[tongTien] [decimal](10, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/21/2023 4:17:34 PM ******/
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
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/21/2023 4:17:34 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[idKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[hoVaTen] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[soDienThoai] [varchar](10) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[email] [varchar](50) NULL,
	[deletedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[idKhuyenMai] [int] IDENTITY(1,1) NOT NULL,
	[ngayBatDau] [datetime] NULL,
	[ngayKetThuc] [datetime] NULL,
	[noiDung] [nvarchar](50) NULL,
	[tenKhuyenMai] [nvarchar](50) NULL,
	[phanTram] [float] NULL,
	[dieuKien] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[idKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 11/21/2023 4:17:34 PM ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[idNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[tenNhaCungCap] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[soDienThoai] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[idNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[hoVaTen] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[soDienThoai] [varchar](10) NULL,
	[gioiTinh] [nvarchar](10) NULL,
	[idChucVu] [varchar](10) NULL,
	[luong] [decimal](10, 2) NULL,
	[trangThai] [nvarchar](50) NULL,
	[ngayNghi] [datetime] NULL,
	[ngaySinh] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[idPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NULL,
	[idNhaCungCap] [int] NULL,
	[ngayNhap] [datetime] NULL,
	[tongTien] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/21/2023 4:17:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[idSanPham] [int] IDENTITY(1,1) NOT NULL,
	[idLoaiSanPham] [int] NULL,
	[tenSanPham] [nvarchar](50) NULL,
	[donGia] [decimal](10, 3) NULL,
	[soLuong] [int] NULL,
	[hinhAnh] [varchar](50) NULL,
	[trangThai] [varchar](20) NULL,
	[deletedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BaoCao]  WITH CHECK ADD FOREIGN KEY([idSanPham])
REFERENCES [dbo].[SanPham] ([idSanPham])
GO
ALTER TABLE [dbo].[BaoCao]  WITH CHECK ADD FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([idNhanVien])
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
ALTER TABLE [dbo].[HoaDon] WITH CHECK ADD FOREIGN KEY([idKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([idKhuyenMai])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idKhachHang])
REFERENCES [dbo].[KhachHang] ([idKhachHang])
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

--
-- insert bảng NhaCungCap
-- 

INSERT INTO NhaCungCap (idNhaCungCap, tenNhaCungCap, diaChi, soDienThoai)
VALUES
	(1, 'Công ty TNHH Thương mại và Sản xuất Thực phẩm Cầu Tre', 'Số 123, đường Nguyễn Văn Cừ, quận 1, TP. Hồ Chí Minh', '02838271111'),
	(2, 'Công ty Cổ phần Thực phẩm Á Châu', 'Số 456, đường Cách Mạng Tháng Tám, quận 3, TP. Hồ Chí Minh', '02839112222'),
	(3, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Vinafood', 'Số 789, đường Điện Biên Phủ, quận Bình Thạnh, TP. Hồ Chí Minh', '02836223333'),
	(4, 'Công ty Cổ phần Thực phẩm Ba Huân', 'Số 101, đường Lê Văn Sỹ, quận Tân Bình, TP. Hồ Chí Minh', '02838124444'),
	(5, 'Công ty TNHH Thực phẩm Cỏ May', 'Số 111, đường Hoàng Văn Thụ, quận Phú Nhuận, TP. Hồ Chí Minh', '02839995555'),
	(6, 'Công ty TNHH Thực phẩm An Phú', 'Số 123, đường Nguyễn Văn Bứa, quận Bình Chánh, TP. Hồ Chí Minh', '02838761111'),
	(7, 'Công ty Cổ phần Thực phẩm Nam Long', 'Số 456, đường Nguyễn Thị Định, quận 2, TP. Hồ Chí Minh', '02839222222'),
	(8, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Việt Hân', 'Số 789, đường Xa Lộ Hà Nội, quận 9, TP. Hồ Chí Minh', '02836333333'),
	(9, 'Công ty Cổ phần Thực phẩm Đồng Tiến', 'Số 101, đường Quốc Lộ 1A, quận Thủ Đức, TP. Hồ Chí Minh', '02838134444'),
	(10, 'Công ty TNHH Thực phẩm Ngọc Châu', 'Số 111, đường Phạm Văn Đồng, quận Gò Vấp, TP. Hồ Chí Minh', '02839995556'),
	(11, 'Công ty TNHH Thực phẩm Mộc Châu', 'Số 123, đường Trần Hưng Đạo, tỉnh Sơn La', '021238271111'),
	(12, 'Công ty Cổ phần Thực phẩm Điện Biên', 'Số 456, đường Lê Duẩn, tỉnh Điện Biên', '021239112222'),
	(13, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Lào Cai', 'Số 789, đường Nguyễn Huệ, tỉnh Lào Cai', '021236223333'),
	(14, 'Công ty Cổ phần Thực phẩm Yên Bái', 'Số 101, đường Thái Nguyên, tỉnh Yên Bái', '021238124444'),
	(15, 'Công ty TNHH Thực phẩm Phú Thọ', 'Số 111, đường Hùng Vương, tỉnh Phú Thọ', '021239995555'),
	(16, 'Công ty TNHH Thực phẩm Vĩnh Phúc', 'Số 123, đường Nguyễn Tất Thành, tỉnh Vĩnh Phúc', '021238271112'),
	(17, 'Công ty Cổ phần Thực phẩm Hà Nội', 'Số 456, đường Giải Phóng, thành phố Hà Nội', '021239112223'),
	(18, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Hải Dương', 'Số 789, đường Trần Phú, tỉnh Hải Dương', '021236223334'),
	(19, 'Công ty Cổ phần Thực phẩm Hải Phòng', 'Số 101, đường Lê Hồng Phong, thành phố Hải Phòng', '021238124445')
	(20, 'Công ty TNHH Thực phẩm Bình Dương', 'Số 123, đường Cách Mạng Tháng Tám, tỉnh Bình Dương', '027438271111'),
	(21, 'Công ty Cổ phần Thực phẩm Đồng Nai', 'Số 456, đường Nguyễn Văn Trỗi, tỉnh Đồng Nai', '025139112222'),
	(22, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Tây Ninh', 'Số 789, đường 30/4, tỉnh Tây Ninh', '027636223333'),
	(23, 'Công ty Cổ phần Thực phẩm Long An', 'Số 101, đường Hùng Vương, tỉnh Long An', '027238124444'),
	(24, 'Công ty TNHH Thực phẩm Tiền Giang', 'Số 111, đường Nguyễn Thị Minh Khai, tỉnh Tiền Giang', '027339995555'),
	(25, 'Công ty TNHH Thực phẩm Trà Vinh', 'Số 123, đường Nguyễn Huệ, tỉnh Trà Vinh', '029438271111'),
	(26, 'Công ty Cổ phần Thực phẩm Sóc Trăng', 'Số 456, đường Võ Văn Kiệt, tỉnh Sóc Trăng', '029939112222'),
	(27,'Công ty TNHH Sản xuất và Thương mại Thực phẩm Bạc Liêu', 'Số 789, đường Trần Phú, tỉnh Bạc Liêu', '029136223333'),
	(28, 'Công ty Cổ phần Thực phẩm Cà Mau', 'Số 101, đường Lê Lợi, tỉnh Cà Mau', '029038124444'),
	(29, 'Công ty TNHH Thực phẩm Kiên Giang', 'Số 111, đường Nguyễn Trung Trực, tỉnh Kiên Giang', '029739995555'),
	(30, 'Công ty TNHH Thực phẩm An Giang', 'Số 123, đường Trần Hưng Đạo, tỉnh An Giang', '029638271112'),
	(31, 'Công ty Cổ phần Thực phẩm Đồng Tháp', 'Số 456, đường Nguyễn Chí Thanh, tỉnh Đồng Tháp', '027739112223'),
	(32, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Vĩnh Long', 'Số 789, đường Hùng Vương, tỉnh Vĩnh Long', '027036223334'),
	(33, 'Công ty Cổ phần Thực phẩm Bến Tre', 'Số 101, đường Nguyễn Thị Minh Khai, tỉnh Bến Tre', '027538124445'),
	(34, 'Công ty TNHH Thực phẩm Đà Nẵng', 'Số 123, đường Nguyễn Văn Linh, thành phố Đà Nẵng', '023638271111'),
	(35, 'Công ty Cổ phần Thực phẩm Quảng Nam', 'Số 456, đường Hùng Vương, thành phố Tam Kỳ, tỉnh Quảng Nam', '023539112222'),
	(36, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Quảng Ngãi', 'Số 789, đường Lê Lợi, thành phố Quảng Ngãi, tỉnh Quảng Ngãi', '025536223333'),
	(37, 'Công ty Cổ phần Thực phẩm Bình Định', 'Số 101, đường Nguyễn Tất Thành, thành phố Quy Nhơn, tỉnh Bình Định', '025638124444'),
	(38, 'Công ty TNHH Thực phẩm Phú Yên', 'Số 111, đường Trần Phú, thành phố Tuy Hòa, tỉnh Phú Yên', '025739995555'),
	(39, 'Công ty TNHH Thực phẩm Khánh Hòa', 'Số 123, đường Trần Hưng Đạo, thành phố Nha Trang, tỉnh Khánh Hòa', '025838271111'),
	(40, 'Công ty Cổ phần Thực phẩm Ninh Thuận', 'Số 456, đường Nguyễn Văn Trỗi, thành phố Phan Rang-Tháp Chàm, tỉnh Ninh Thuận', '025939112222'),
	(41, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Bình Thuận', 'Số 789, đường 30/4, thành phố Phan Thiết, tỉnh Bình Thuận', '025236223333'),
	(42, 'Công ty Cổ phần Thực phẩm Kon Tum', 'Số 101, đường Hùng Vương, thành phố Kon Tum, tỉnh Kon Tum', '026038124444'),
	(43, 'Công ty TNHH Thực phẩm Gia Lai', 'Số 111, đường Nguyễn Thị Minh Khai, thành phố Pleiku, tỉnh Gia Lai', '026139995555'),
	(44, 'Công ty TNHH Thực phẩm Đắk Lắk', 'Số 123, đường Nguyễn Huệ, thành phố Buôn Ma Thuột, tỉnh Đắk Lắk', '026238271111'),
	(45, 'Công ty Cổ phần Thực phẩm Đắk Nông', 'Số 456, đường Võ Văn Kiệt, thành phố Gia Nghĩa, tỉnh Đắk Nông', '026839112222'),
	(46, 'Công ty TNHH Sản xuất và Thương mại Thực phẩm Lâm Đồng', 'Số 789, đường Trần Phú, thành phố Đà Lạt, tỉnh Lâm Đồng', '026336223333'),
	(47, 'Công ty Cổ phần Thực phẩm Bình Phước', 'Số 101, đường Lê Lợi, thành phố Đồng Xoài, tỉnh Bình Phước', '027138124444');

--
-- insert bảng ChucVu
--

INSERT INTO ChucVu(idChucVu, tenChucVu, moTaChucVu)
VALUES
	(1, N'Admin', N'Nhân viên admin có khả năng quản lý tài khoản và quản lý chức vụ cho các tài khoản khác.'),
	(2, N'Quản Lý', N'Nhân viên quản lý có khả năng quản lý nhân viên, quản lý sản phẩm, quản lý khuyến mãi, quản lý nhà cung cấp, quản lý loại sản phẩm, quản lý phiếu nhập và quản lý hóa đơn.'),
	(3, N'Bán Hàng', N'Nhân viên bán hàng có khả năng quản lý bán hàng, quản lý hóa đơn, quản lý khách hàng và quản lý báo cáo.'),
	(4, N'Thủ Kho', N'Nhân viên thủ kho có khả năng xem.');

--
-- insert bảng NhanVien
--

INSERT INTO NhanVien (idNhanVien, hotTenNhanVien, diaChi, soDienThoai, ngaySinh, gioiTinh, luong, trangThai, idChucVu)
VALUES
	(1, N'Lương Minh Thế Vinh', N'320/30 Trần Bình Trọng, P4, Q5, TP.HCM', '0346575111', '2003-06-16', 'Nam', 50000000, N'Đang Làm', 1),
	(2, N'Nguyễn Thị Ân', N'Số 123, đường Lý Thường Kiệt, quận 1, TP. Hồ Chí Minh', '02838272222', '1991-02-02', N'Nữ', 20000000,  N'Đang Làm', 2),
	(3, N'Nguyễn Văn Bình', N'Số 456, đường Đồng Khởi, quận 3, TP. Hồ Chí Minh', '02839113333', '1993-03-03', 'Nam',  20000000,  N'Đang Làm', 2),
	(4, N'Trương Văn Chương', N'Số 789, đường Nguyễn Huệ, quận Bình Thạnh, TP. Hồ Chí Minh', '02836224444', '1995-04-04', 'Nam',  20000000,  N'Đang Làm', 2),
	(5, N'Hồ Thị Duyên', N'Số 101, đường Bà Huyện Thanh Quan, quận Tân Bình, TP. Hồ Chí Minh', '02838125555', '1997-05-05', 'Nữ', 20000000,  N'Đang Làm', 2),
	(6, N'Đỗ Văn Mạnh', N'Số 111, đường Nguyễn Du, quận Phú Nhuận, TP. Hồ Chí Minh', '02839996666', '1999-06-06', 'Nam', 20000000,  N'Đang Làm', 2),
	(7, N'Huỳnh Thị Giang', N'Số 123, đường Phạm Ngọc Thạch, quận 1, TP. Hồ Chí Minh', '02838277777', '2000-07-07', N'Nữ', 10000000,  N'Đang Làm', 3),
	(8, N'Vũ Văn Ninh', N'Số 456, đường Lê Lợi, quận 3, TP. Hồ Chí Minh', '028-3911-8888', '20010808', 'Nam', 10000000,  N'Đang Làm', 3),
	(9, N'Phan Thị Hương', N'Số 789, đường Nguyễn Đình Chiểu, quận Bình Thạnh, TP. Hồ Chí Minh', '02836229999', '2002-09-09', N'Nữ', 10000000,  N'Đang Làm', 3),
	(10, N'Lê Thị Liên', N'Số 101, đường Nguyễn Thị Minh Khai, quận Tân Bình, TP. Hồ Chí Minh', '02838120000', '2003-10-10', N'Nữ', 10000000,  N'Đang Làm', 3),
	(11, N'Nguyễn Văn Sơn', N'Số 111, đường Võ Văn Kiệt, quận Phú Nhuận, TP. Hồ Chí Minh', '02839991111', '2004-11-11', 'Nam', '3', 10000000,  N'Đang Làm', 3);

--
-- insert bảng KhachHang
--

INSERT INTO KhachHang (idKhachHang, hoVaTen, diaChi, soDienThoai, gioiTinh, email, ngaySinh, diem)
VALUES
	(1, 'Nguyễn Văn An', 'Số 123, đường Nguyễn Văn Cừ, quận 1, TP. Hồ Chí Minh', '02838271111', 'Nam', 'nguyenvana@gmail.com', '1990-01-01', 200),
	(2, 'Nguyễn Thị Bình', 'Số 456, đường Cách Mạng Tháng Tám, quận 3, TP. Hồ Chí Minh', '02839112222', 'Nữ', 'nguyenthib@gmail.com', '1992-02-02', 300),
	(3, 'Trần Văn Cầu', 'Số 789, đường Điện Biên Phủ, quận Bình Thạnh, TP. Hồ Chí Minh', '02836223333', 'Nam', 'tranvanc@gmail.com', '1994-03-03', 100),
	(4, 'Đặng Thị Dương', 'Số 101, đường Lê Văn Sỹ, quận Tân Bình, TP. Hồ Chí Minh', '02838124444', 'Nữ', 'dangthid@gmail.com', '1996-04-04', 500),
	(5, 'Lê Thị Ân', 'Số 123, đường Lý Thường Kiệt, quận 1, TP. Hồ Chí Minh', '02838272222', 'Nữ', 'letha@gmail.com', '1991-02-02', 600),
	(6, 'Nguyễn Văn Bình', 'Số 456, đường Đồng Khởi, quận 3, TP. Hồ Chí Minh', '02839113333', 'Nam', 'nguyenvanb@gmail.com', '1993-03-03', 200),
	(7, 'Trương Văn Duy', 'Số 789, đường Nguyễn Huệ, quận Bình Thạnh, TP. Hồ Chí Minh', '02836224444', 'Nam', 'truongvanc@gmail.com', '1995-04-04', 100),
	(8, 'Hồ Thị Duyên', 'Số 101, đường Bà Huyện Thanh Quan, quận Tân Bình, TP. Hồ Chí Minh', '02838125555', 'Nữ', 'hothid@gmail.com', '1997-05-05', 500),
	(9, 'Đỗ Văn Hưng', 'Số 111, đường Nguyễn Du, quận Phú Nhuận, TP. Hồ Chí Minh', '02839996666', 'Nam', 'dovane@gmail.com', '1999-06-06', 400),
	(10, 'Huỳnh Thị Hà', 'Số 123, đường Phạm Ngọc Thạch, quận 1, TP. Hồ Chí Minh', '02838277777', 'Nữ', 'huynhthif@gmail.com', '2000-07-07', 600),
	(11, 'Vũ Văn Giang', 'Số 456, đường Lê Lợi, quận 3, TP. Hồ Chí Minh', '02839118888', 'Nam', 'vuvang@gmail.com', '2001-08-08', 800),
	(12, 'Phan Thị Hương Giang', 'Số 789, đường Nguyễn Đình Chiểu, quận Bình Thạnh, TP. Hồ Chí Minh', '02836229999', 'Nữ', 'phanthih@gmail.com', '2002-09-09', 0),
	(13, 'Lê Thị Anh', 'Số 101, đường Nguyễn Thị Minh Khai, quận Tân Bình, TP. Hồ Chí Minh', '02838120000', 'Nữ', 'lethii@gmail.com', '2003-10-10', 100),
	(14, 'Nguyễn Văn Bình', 'Số 111, đường Võ Văn Kiệt, quận Phú Nhuận, TP. Hồ Chí Minh', '02839991111', 'Nam', 'nguyenvanj@gmail.com', '2004-11-11', 0),
	(15, 'Trần Thị Liên', 'Số 123, đường Trần Phú, quận 1, TP. Hồ Chí Minh', '02838272222', 'Nữ', 'tranthik@gmail.com', '2005-12-12', 100),
	(16, 'Đỗ Văn Mạnh', 'Số 456, đường Nguyễn Văn Cừ, quận 3, TP. Hồ Chí Minh', '02839113333', 'Nam', 'dovanl@gmail.com', '2006-01-01', 200);

--
-- insert bảng LoaiSanPham
--

INSERT INTO LoaiSanPham(idLoaiSanPham, tenLoaiSanPham) 
VALUES
	(1, N'Thịt, Cá, Trứng, Hải Sản'),
	(2, N'Rau, Củ, Nấm, Trái Cây'),
	(3, N'Dầu Ăn, Nước Chấm, Gia Vị'),
	(4, N'Kem, Thực Phẩm Đông Mát'),
	(5, N'Mì, Miến, Cháo, Phở'),
	(6, N'Gạo, Bột, Đồ Khô'),
	(7, N'Bia, Nước Giải Khát'),
	(8, N'Sữa Các Loại'),
	(9, N'Bánh Kẹo Các Loại'),
	(10, N'Chăm Sóc Cá Nhân'),
	(11, N'Sản Phẩm Cho Mẹ Và Bé'),
	(12, N'Vệ Sinh Nhà Cửa'),
	(13, N'Đồ Dùng Gia Đình'),
	(14, N'Chăm Sóc Thú Cưng');

--
-- insert bảng SanPham
--

INSERT INTO SanPham(idSanPham, idLoaiSanPham, tenSanPham, donGia, soLuong, hinhAnh, trangThai, chietKhau)
VALUES
	(1, 1, N'Ba rọi heo rút sườn G 300g', 85500, 100, 'ba_roi_heo_300g.webp', 'Còn bán', 0),
	(2, 1, N'Cốt lết heo 300g', 36500, 100, 'cot_let_heo_300g.webp', 'Còn bán', 0),
	(3, 1, N'Thịt bắp giò C.P 300g', 45500, 100, 'thit_bap_gio_300g.webp', 'Còn bán', 0),
	(4, 1, N'Thịt heo xay C.P 500g', 70000, 100, 'thit_heo_xay_500g.webp', 'Còn bán', 0),
	(5, 1, N'Thịt đùi heo C.P 500g', 69000, 100, 'thit_dui_heo_500g.webp', 'Còn bán', 0),
	(6, 1, N'Ba chỉ bò Mỹ Fohla đông lạnh 250g', 64000, 100, 'ba_chi_bo_my_fohla_250g.webp', 'Còn bán', 0),
	(7, 1, N'Bò xay Fohla 250g', 58500, 100, 'bo-xay-fohla-250g.webp', 'Còn bán', 0),
	(8, 1, N'Bắp bò Úc Fohla đông lạnh 250g', 67000, 100, 'bap_bo_uc_fohla_250g.webp', 'Còn bán', 0),
	(9, 1, N'Nạm bò Fohla 250g', 80000, 100, 'nam-bo-fohla-250g.webp', 'Còn bán', 0),
	(10, 1, N'Tôm thẻ nõn tự nhiên HDC 200g', 74000, 100, 'tom-the-non-tu-nhien-hdc-200g.webp', 'Còn bán', 0),
	(11, 1, N'Tôm sú nõn tự nhiên HDC 200g', 97000, 100, 'tom-su-non-tu-nhien-hdc-200g.webp', 'Còn bán', 0),
	(12, 1, N'Cá basa cắt khúc đông lạnh 450-550g', 30000, 100, 'ca-basa-cat-khuc-dong-lanh-500g.webp', 'Còn bán', 0),
	(13, 1, N'Cá nục đông lạnh 450-550g (4-7 con)', 35000, 100, 'ca-nuc-dong-lanh-500g.webp', 'Còn bán', 0),
	(14, 1, N'Cá basa phi lê 250g', 27000, 100, 'ca-basa-phi-le-250g.webp', 'Còn bán', 0),
	(15, 1, N'Cá hồi phi lê SG Food khay 200g', 110000, 100, 'ca-hoi-phi-le-sg-food-khay-200g.webp', 'Còn bán', 0),
	(16, 1, N'Mực một nắng 500g', 318000, 100, 'muc-mot-nang-200g.webp', 'Còn bán', 0),
	(17, 1, N'Khô mực 200g', 239000, 100, 'kho-muc-200g.webp', 'Còn bán', 0),
	(18, 1, N'Trứng gà Happy Egg hộp 10 quả', 26500, 100, 'trung-ga-happy-egg-hop-10-qua.webp', 'Còn bán', 0),
	(19, 1, N'Trứng gà so Happy Egg hộp 10 tặng 2', 26500, 100, 'trung-ga-so-happy-egg-hop-10-tang-2.webp', 'Còn bán', 0),
	(20, 1, N'Trứng cút Phương Nam hộp 30 quả', 26000, 100, 'trung-cut-nguyen-ho-hop-30-qua.webp', 'Còn bán', 0),
	(21, 1, N'Trứng vịt muối Phương Nam hộp 4 quả', 23000, 100, 'trung-vit-muoi-nguyen-ho-hop-4-qua.webp', 'Còn bán', 0),
	(22, 1, N'Trứng vịt bắc thảo Phương Nam hộp 4 quả', 26000, 100, 'trung-vit-bac-thao-nguyen-ho-hop-4-qua.webp', 'Còn bán', 0),
	(23, 2, N'Xà lách thủy tinh thủy canh từ 200g', 7000, 100, 'xa-lach-thuy-tinh-thuy-canh-cay-tu-230g.webp', 'Còn bán', 0),
	(24, 2, N'Rau dền baby 300g', 7000, 100, 'rau-den-baby-goi-300g.webp', 'Còn bán', 0),
	(25, 2, N'Rau húng cây 100g', 4000, 100, 'rau-hung-cay-goi-100g.webp', 'Còn bán', 0),
	(26, 2, N'Bí đỏ hồ lô 850g', 16000, 100, 'bi-do-ho-lo-1-trai-700g-900g.webp', 'Còn bán', 0),
	(27, 2, N'Khoai lang tím 1kg', 29000, 100, 'khoai-lang-tim-1kg.webp', 'Còn bán', 0),
	(28, 2, N'Nấm kim châm Thái Lan 150g', 11000, 100, 'nam-kim-cham-thai-lan-150g.webp', 'Còn bán', 0),
	(29, 2, N'Nấm đùi gà baby 200g', 29000, 100, 'nam-dui-ga-baby-200g.webp', 'Còn bán', 0),
	(30, 2, N'Bưởi da xanh trái 1.5 kg', 69000, 100, 'buoi-da-xanh-trai-tu-17kg-tro-len.webp', 'Còn bán', 0),
	(31, 2, N'Kiwi xanh Zespri New Zealand hộp 2 trái', 59000, 100, 'kiwi-xanh-zespri-new-zealand-hop-2-trai.webp', 'Còn bán', 0),
	(32, 2, N'Táo Gala New Zealand 1kg', 69000, 100, 'tao-gala-nhap-khau-new-zealand-hop-1kg.webp', 'Còn bán', 0),
	(33, 2, N'Đu đủ ruột đỏ trái 900g', 11000, 100, 'du_du.webp', 'Còn bán', 0),
	(34, 3, N'Dầu hạt cải nguyên chất Simply chai 1 lít', 80000, 100, 'dau-hat-cai-nguyen-chat-simply-chai-1-lit.webp', 'Còn bán', 0),
	(35, 3, N'Dầu đậu nành nguyên chất Simply chai 1 lít', 68000, 100, 'dau-dau-nanh-nguyen-chat-simply-chai-1-lit.webp', 'Còn bán', 0),
	(36, 3, N'Dầu gạo lứt nguyên chất Simply chai 1 lít', 74000, 100, 'dau-gao-nguyen-chat-simply-chai-1-lit.webp', 'Còn bán', 0),
	(37, 3, N'Dầu hướng dương nguyên chất Simply chai 1 lít', 82500, 100, 'dau-huong-duong-nguyen-chat-simply-chai-1-lit.webp', 'Còn bán', 0),
	(38, 3, N'2 chai nước chấm Nam Ngư Đệ Nhị 900ml', 50000, 100, 'nuoc-cham-nam-ngu-de-nhi-2-chai-900ml.webp', 'Còn bán', 0),
	(39, 3, N'Nước mắm cá cơm Nam Ngư 12 độ đạm chai 750ml', 49500, 100, 'nuoc-mam-nam-ngu-ca-com-tuoi-10-do-dam-chai-750ml.webp', 'Còn bán', 0),
	(40, 3, N'Nước mắm cao cấp cốt nhĩ tôm Đầu Bếp Tôm 18 độ đạm chai 500ml', 59000, 100, 'nuoc-mam-cao-cap-cot-nhi-tom-dau-bep-tom-18-do-dam-chai-500ml.webp', 'Còn bán', 0),
	(41, 3, N'Nước mắm nhỉ cá cơm 584 Nha Trang 25 độ đạm chai 1 lít', 55000, 100, 'nuoc-mam-nhi-ca-com-584-nha-trang-25-do-dam-chai-1-lit.webp', 'Còn bán', 0),
	(42, 3, N'Nước tương đậu nành Maggi thanh dịu chai 700ml', 18000, 100, 'nuoc-tuong-dau-nanh-thanh-diu-maggi-chai-700ml.webp', 'Còn bán', 0),
	(43, 3, N'Nước tương đậu nành Maggi giảm muối chai 300ml', 22000, 100, 'nuoc-tuong-dau-nanh-maggi-giam-muoi-chai-300ml.webp', 'Còn bán', 0),
	(44, 3, N'Nước tương đậu nành Maggi đậm đặc chai 300ml', 18500, 100, 'nuoc-tuong-dau-nanh-dam-dac-maggi-chai-300ml.webp', 'Còn bán', 0),
	(45, 3, N'Nước tương Chinsu tỏi ớt chai 330ml', 19000, 100, 'nuoc-tuong-chinsu-toi-ot-chai-330ml.webp', 'Còn bán', 0),
	(46, 3, N'Nước tương Chinsu nấm Shiitake chai 330ml', 16500, 100, 'nuoc-tuong-chinsu-nam-shiitake-chai-330ml.webp', 'Còn bán', 0),
	(47, 3, N'Đường làm bánh Biên Hòa Pro gói 1kg', 43800, 100, 'duong-lam-banh-bien-hoa-pro-goi-1kg.webp', 'Còn bán', 0),
	(48, 3, N'Đường mía thiên nhiên Biên Hòa gói 1kg', 33000, 100, 'duong-vang-thien-nhien-bien-hoa-gold-goi-1kg.webp', 'Còn bán', 0),
	(49, 3, N'2 gói bột ngọt hạt lớn Ajinomoto 400g', 68000, 100, '2-goi-bot-ngot-hat-lon-ajinomoto-400g.webp', 'Còn bán', 0),
	(50, 3, N'Bột ngọt hạt nhỏ Vedan gói 1kg', 65000, 100, 'bot-ngot-vedan-goi-1kg.webp', 'Còn bán', 0),
	(51, 3, N'Hạt nêm Ajinomoto tôm thịt gói 900g', 64000, 100, 'hat-nem-ajinomoto-tom-thit-goi-900g.webp', 'Còn bán', 0),
	(52, 3, N'Hạt nêm Vedan thịt heo gói 1kg', 66500, 100, 'hat-nem-thit-heo-vedan-goi-1kg.webp', 'Còn bán', 0),
	(53, 3, N'Hạt nêm Knorr thịt thăn, xương ống, tủy gói 900g', 86000, 100, 'hat-nem-thit-than-xuong-ong-tuy-knorr-goi-900g.webp', 'Còn bán', 0),
	(54, 3, N'Bột canh Vifon gói 200g', 6000, 100, 'bot-canh-vifont-230gam-2-org.webp', 'Còn bán', 0),
	(55, 3, N'Muối sấy I-ốt Sosal Group gói 1kg', 6900, 100, 'muoi-tinh-say-bo-sung-i-ot-sosal-group-goi-1kg.webp', 'Còn bán', 0),
	(56, 3, N'Muối hạt thiên nhiên Vĩnh Hảo Sosal Group gói 1kg', 7900, 100, 'muoi-hat-thien-nhien-vinh-hao-sosal-group-goi-1kg.webp', 'Còn bán', 0),
	(57, 4, N'Kem Topten Socola Wall cây 60g', 12000, 100, 'kem-topten-socola-walls-cay-60g.webp', 'Còn bán', 0),
	(58, 4, N'Kem Chocolate Wall ly 90ml 46g', 11000, 100, 'kem-chocolate-walls-ly-90ml-46g.webp', 'Còn bán', 0),
	(59, 4, N'Kem que Topten Vanila Wall cây 60g', 12000, 100, 'kem-que-topten-vanila-walls-cay-55g.webp', 'Còn bán', 0),
	(60, 4, N'2 lốc sữa chua ít đường Vinamilk Love Yogurt Green Farm hộp 100g', 54000, 100, '2-loc-sua-chua-it-duong-vinamilk-love-yogurt-green-farm-hop-100g.webp', 'Còn bán', 0),
	(61, 4, N'2 lốc sữa chua Vinamilk nha đam hộp 100g', 57000, 100, '2-loc-sua-chua-vinamilk-nha-dam-hop-100g.webp', 'Còn bán', 0),
	(62, 5, N'Mì Hảo Hảo vị tôm chua cay gói 75g', 4000, 100, 'mi-hao-hao-vi-tom-chua-cay-goi-75g.webp', 'Còn bán', 0),
	(63, 5, N'Mì Hảo Hảo hương vị lẩu kim chi Hàn Quốc gói 75g', 4400, 100, 'mi-hao-hao-huong-vi-lau-kim-chi-han-quoc-goi-75g.webp', 'Còn bán', 0),
	(64, 5, N'Mì khô gà cay Samyang gói 140g', 20000, 100, 'mi-kho-samyang-ga-cay-140gr-2-org.webp', 'Còn bán', 0),
	(65, 5, N'Miến Phú Hương sườn heo gói 55g', 11500, 100, 'mien-phu-huong-suon-heo-goi-58g.webp', 'Còn bán', 0),
	(66, 5, N'Miến Phú Hương lẩu Thái tôm gói 60g', 11500, 100, 'mien-phu-huong-lau-thai-tom-goi-60g.webp', 'Còn bán', 0),
	(67, 5, N'Cháo thịt bằm Gấu Đỏ gói 50g', 4000, 100, 'chao-thit-bam-gau-do-goi-50g-202307121014338847.webp', 'Còn bán', 0),
	(68, 5, N'Cháo Vifon vị thịt bằm gói 50g', 3600, 100, 'chao-vifon-vi-thit-bam-goi-50g.webp', 'Còn bán', 0),
	(69, 5, N'Cháo gà Gấu Đỏ gói 50g', 4000, 100, 'chao-ga-gau-do-goi-50g-202209282327437027.webp', 'Còn bán', 0),
	(70, 5, N'Phở bò Vifon gói 65g', 8400, 100, 'pho-vi-bo-vifon-goi-65g-201911270930039500.webp', 'Còn bán', 0),
	(71, 5, N'Phở gà Vifon gói 65g', 8400, 100, 'pho-ga-vifon-goi-65g-201911051624561949.webp', 'Còn bán', 0),
	(72, 6, N'Gạo đặc sản Trạng Nguyên Vinh Hiển ST25 túi 5kg', 179000, 100, 'gao-dac-san-trang-nguyen-vinh-hien-st25-tui-5kg.webp', 'Còn bán', 0),
	(73, 6, N'Gạo giống Nhật Bản Vinh Hiển Taiyo túi 5kg', 149000, 100, 'gao-giong-nhat-ban-vinh-hien-taiyo-tui-5kg-202007211001455095.webp', 'Còn bán', 0),
	(74, 6, N'Bột chiên giòn Meizan gói 150g', 10000, 100, 'bot-chien-gion-meizan-goi-150g-202006201551249041.webp', 'Còn bán', 0),
	(75, 6, N'Bột rau câu giòn Bà Bảy gói 10g', 10000, 100, 'bot-rau-cau-gion-ba-bay-goi-10g-202105140829175776.webp', 'Còn bán', 0),
	(76, 7, N'Thùng 20 lon bia Budweiser 330ml', 290000, 100, 'thung-20-lon-bia-budweiser-330ml-202212271500437513.webp', 'Còn bán', 0),
	(77, 7, N'Thùng 24 lon bia Tiger lon cao 330ml', 350000, 100, 'thung-24-lon-bia-tiger-lon-cao-330ml-202311041013335193.webp', 'Còn bán', 0),
	(78, 7, N'6 lon bia Budweiser 330ml', 105000, 100, '6-lon-bia-budweiser-330ml-202110111020026125.webp', 'Còn bán', 0),
	(79, 7, N'6 lon nước ngọt Coca Cola Zero 320ml', 42000, 100, '6-lon-nuoc-ngot-coca-cola-zero-320ml-202201271536306113.webp', 'Còn bán', 0),
	(80, 7, N'6 lon nước ngọt Coca Cola Light 320ml', 42000, 100, '6-lon-nuoc-ngot-coca-cola-light-330ml-202209111902227891.webp', 'Còn bán', 0),
	(81, 7, N'6 lon nước ngọt Coca Cola 320ml', 47000, 100, '6-lon-nuoc-ngot-coca-cola-320ml-202304131108497884.webp', 'Còn bán', 0),
	(82, 7, N'6 lon nước ngọt Pepsi không calo 320ml', 45000, 100, 'loc-6-lon-nuoc-ngot-pepsi-khong-calo-330ml-202103162336336531.webp', 'Còn bán', 0),
	(83, 7, N'6 lon nước ngọt Pepsi Cola 320ml', 44000, 100, '6-lon-nuoc-ngot-pepsi-cola-320ml-202303151109096736.webp', 'Còn bán', 0),
	(84, 8, N'2 hộp sữa tươi tiệt trùng có đường Vinamilk 100% Sữa tươi 1 lít', 65000, 100, '2-hop-sua-tuoi-tiet-trung-co-duong-vinamilk-100-sua-tuoi-1-lit-202310240931215665.webp', 'Còn bán', 0),
	(85, 8, N'2 hộp sữa tươi tiệt trùng Dutch Lady không đường 965ml', 62000, 100, 'sua-tuoi-tiet-trung-khong-duong-dutch-lady-hop-965ml-202307271504090009.webp', 'Còn bán', 0),
	(86, 8, N'2 hộp sữa tươi tiệt trùng không đường Vinamilk 100% Sữa tươi 1 lít', 65000, 100, '2-hop-sua-tuoi-tiet-trung-khong-duong-vinamilk-100-sua-tuoi-1-lit-202310301028485472.webp', 'Còn bán', 0),
	(87, 8, N'2 lốc sữa đậu nành hạt óc chó Vinamilk Super Nut 180ml', 54000, 100, 'loc-4-hop-sua-dau-nanh-hat-oc-cho-vinamilk-super-nut-180ml-202308011522015728.webp', 'Còn bán', 0),
	(88, 8, N'Lốc 6 hộp sữa đậu nành ít đường Fami Canxi 200ml', 30500, 100, 'loc-6-hop-sua-dau-nanh-it-duong-fami-canxi-200ml-202308181455366933.webp', 'Còn bán', 0),
	(89, 8, N'5 hộp sữa đậu đen óc chó hạnh nhân Sahmyook 190ml', 30500, 100, 'sua-dau-den-oc-cho-hanh-nhan-sahmyook-190ml-202308231102264831.webp', 'Còn bán', 0),
	(90, 8, N'Lốc 6 hộp sữa đậu nành vị cà phê Fami Canxi 200ml', 31000, 100, 'loc-6-hop-sua-dau-nanh-vi-ca-phe-fami-canxi-200ml-202110071444531639.webp', 'Còn bán', 0),
	(91, 9, N'Bánh cracker 2 lớp kem bơ Magic Twin hộp 300g', 32500, 100, 'banh-cracker-hai-lop-kem-bo-magic-twin-hop-300g-201912151715090527.webp', 'Còn bán', 0),
	(92, 9, N'Bánh cracker vị rau AFC Dinh Dưỡng hộp 86g', 14300, 100, 'banh-cracker-vi-rau-afc-dinh-duong-hop-100g-202309261434004885.webp', 'Còn bán', 0),
	(93, 9, N'Bánh cracker vị cốm non AFC Dinh Dưỡng hộp 109g', 18500, 100, 'banh-cracker-vi-com-non-afc-dinh-duong-hop-109g-202302170839310749.webp', 'Còn bán', 0),
	(94, 9, N'Bánh quy caramel flan AFC hộp 125g', 18500, 100, 'banh-quy-caramel-flan-afc-hop-125g-202203290805310008.webp', 'Còn bán', 0),
	(95, 9, N'Bánh quy vị cà phê Coffee Joy hộp 156g', 21500, 100, 'banh-quy-vi-ca-phe-coffee-joy-hop-156g-202303130955311274.webp', 'Còn bán', 0),
	(96, 9, N'Bánh trứng Tipo gói 220g', 41800, 100, 'banh-trung-tipo-goi-220g-202212021644387800.webp', 'Còn bán', 0),
	(97, 9, N'Socola sữa Hershey thanh 15g', 9000, 100, 'socola-sua-hersheys-thanh-15g-201909271604299845.webp', 'Còn bán', 0),
	(98, 9, N'Socola trắng nhân bánh quy Hershey thanh 15g', 9000, 100, 'socola-trang-nhan-banh-quy-hersheys-goi-15g-201908161329561479.webp', 'Còn bán', 0),
	(99, 9, N'Socola kem sữa nhân hạnh nhân Hershey Nuggets gói 28g', 9000, 100, 'socola-kem-sua-nhan-hanh-nhan-hersheys-nuggets-goi-28g-201908211311473092.webp', 'Còn bán', 0),
	(100, 9, N'Bánh xốp phủ socola KitKat Chunky Cookies & Cream gói 38g', 18000, 100, 'banh-xop-phu-socola-kitkat-chunky-cookies-cream-thanh-38g-201907291251442370.webp', 'Còn bán', 0),
	(101, 9, N'Bánh xốp phủ socola KitKat Chunky gói 38g', 18000, 100, 'socola-kit-kat-thanh-chunky-cocoa-38g-2-org.webp', 'Còn bán', 0),
	(102, 10, N'Dầu gội X-Men Water thơm lâu sạch sâu 750g', 180000, 100, 'dau-goi-x-men-water-thom-lau-sach-sau-750g-202110301527563873.webp', 'Còn bán', 0),
	(103, 10, N'Dầu gội sạch gàu Clear mát lạnh bạc hà 680ml', 159000, 100, 'dau_goi_clear.webp', 'Còn bán', 0),
	(104, 10, N'Dầu gội sạch gàu Clear hương hoa anh đào 618ml', 148000, 100, 'dau-goi-sach-gau-clear-huong-hoa-anh-dao-618ml-202308120938162654.webp', 'Còn bán', 0),
	(105, 10, N'Dầu gội Head & Shoulders làm sạch gàu bạc hà mát rượi 625ml', 150000, 100, 'dau-goi-sach-gau-head-shoulders-bac-ha-mat-ruoi-625ml-202003201039420386.webp', 'Còn bán', 0),
	(106, 10, N'Dầu gội hương nước hoa Romano Classic tóc chắc khoẻ 650g', 155000, 100, 'romano-classic-650g-2-org.webp', 'Còn bán', 0),
	(107, 10, N'Chai sữa tắm bảo vệ khỏi vi khuẩn Lifebuoy bảo vệ vượt trội 980ml', 168000, 100, 'sua-tam-bao-ve-khoi-vi-khuan-lifebuoy-bao-ve-vuot-troi-980ml-202304110938232209.webp', 'Còn bán', 0),
	(108, 10, N'Chai sữa tắm bảo vệ khỏi vi khuẩn Lifebuoy chăm sóc da 980ml', 168000, 100, 'sua-tam-bao-ve-khoi-vi-khuan-lifebuoy-sua-duong-am-980ml-202303130934283530.webp', 'Còn bán', 0),
	(109, 10, N'Sữa tắm nước hoa Enchanteur Deluxe Charming 900g', 240000, 100, 'sua-tam-enchanteur-huong-nuoc-hoa-charming-900g-2-orgsua-tam-enchanteur-huong-nuoc-hoa-charming-900g-2-org.webp', 'Còn bán', 0),
	(110, 10, N'Sữa tắm nước hoa Enchanteur Deluxe Magic 650g', 196000, 100, 'st-enchantuer-magic-650g-2-org.webp', 'Còn bán', 0),
	(111, 10, N'Sữa tắm nước hoa dưỡng da Enchanteur Deluxe Sensation 650g', 196000, 100, 'st-enchantuer-sentation-650g-2-org.webp', 'Còn bán', 0),
	(112, 11, N'Dầu massage cho bé Johnson 200ml', 106000, 100, 'dau-massage-cho-be-johnsons-200ml-201910011409015090.webp', 'Còn bán', 0),
	(113, 11, N'Nước hoa Johnson hương nắng mai 125ml', 81000, 100, 'nuoc-hoa-johnsons-huong-nang-mai-125ml-202105310948548997.webp', 'Còn bán', 0),
	(114, 11, N'Phấn thơm Pigeon Baby Powder 100g', 38000, 100, 'phan-pigeon-chong-ham-diu-nhe-100g-201812051000292878.webp', 'Còn bán', 0),
	(115, 11, N'Phấn thơm trẻ em Babi Mild White Sakura 180g', 32500, 100, 'phan-thom-babi-mild-white-sakura-180g-201905270819366454.webp', 'Còn bán', 0),
	(116, 11, N'Kem đánh răng cho bé trên 2 tuổi Colgate Minions hương dâu 80g', 33000, 100, 'kem-danh-rang-cho-be-tren-2-tuoi-colgate-minions-huong-dau-80g-202211300949412089.webp', 'Còn bán', 0),
	(117, 11, N'Kem đánh răng cho bé từ 2 - 6 tuổi P/S hương dâu ngừa sâu răng cho men răng chắc khỏe 45g', 24000, 100, 'kem-danh-rang-cho-be-tu-2-6-tuoi-p-s-huong-dau-ngua-sau-rang-cho-men-rang-chac-khoe-45g-202205121009089157.webp', 'Còn bán', 0),
	(118, 12, N'Nước lau sàn Sunlight tinh dầu thảo mộc hương hoa hạ và bạc hà túi 3.58 lít', 60000, 100, 'nuoc-lau-nha-sunlight-huong-hoa-dien-vy-tui-36kg-202203282017088496.webp', 'Còn bán', 0),
	(119, 12, N'Nước lau sàn Sunlight tinh dầu thảo mộc hương hoa lily và hương thảo túi 3.58 lít', 60000, 100, 'nuoc-lau-nha-sunlight-tinh-dau-thao-moc-huong-hoa-lily-va-huong-thao-tui-358-lit-202208151037274779.webp', 'Còn bán', 0),
	(120, 12, N'Nước rửa chén Sunlight Chanh 100 đánh bay dầu mỡ cứng đầu chai 725ml', 28000, 100, 'nuoc-rua-chen-sunlight-chiet-xuat-chanh-danh-bay-dau-mo-voi-suc-manh-nhu-100-trai-chanh-chai-725ml-202308231430517568.webp', 'Còn bán', 0),
	(121, 12, N'Nước rửa chén Sunlight thiên nhiên muối khoáng và lô hội chai 725ml', 35000, 100, 'nuoc-rua-chen-sunlight-thien-nhien-muoi-khoang-va-lo-hoi-an-toan-cho-chen-dia-tre-em-chai-725ml-202308121528493643.webp', 'Còn bán', 0),
	(122, 12, N'Nước lau kính Gift sắc biển tươi mát chai 540ml', 15000, 100, 'nuoc-lau-kinh-gift-sac-bien-tuoi-mat-chai-580ml-202212280818260328.webp', 'Còn bán', 0),
	(123, 12, N'Nước lau kính hương bạc hà IZI HOME chai 650ml', 29000, 100, 'nuoc-lau-kinh-izi-home-huong-bac-ha-chai-650ml-202101161756059600.webp', 'Còn bán', 0),
	(124, 12, N'Chảo nhôm chống dính Rainy DIAMOND RNDT24TT 24cm', 390000, 100, 'chao-nhom-chong-dinh-rainy-diamond-rndt24tt-24cm-202308210834426142.webp', 'Còn bán', 0),
	(125, 12, N'Chảo nhôm chống dính Rainy VEINSTONE RNT2025TT 20cm', 260000, 100, 'chao-nhom-chong-dinh-rainy-veinstone-rnt2025tt-20cm-202308210918374552.webp', 'Còn bán', 0),
	(126, 12, N'Chảo nhôm chống dính đáy từ sâu Rainy RNTS2825TT 28cm', 288000, 100, 'chao-nhom-chong-dinh-day-tu-sau-rainy-rnts2825tt-28cm-202308210909284954.webp', 'Còn bán', 0),
	(127, 12, N'Lốc 3 cuộn túi rác đen tự huỷ sinh học Bách Hóa XANH 55x65cm (1kg)', 56000, 100, 'loc-3-cuon-tui-rac-den-tu-huy-sinh-hoc-bach-hoa-xanh-55x65cm-1kg-202007291030342603.webp', 'Còn bán', 0),
	(128, 12, N'Lốc 3 cuộn túi rác đen tự huỷ sinh học Bách Hóa XANH 64x78cm (1kg)', 56000, 100, 'loc-3-cuon-tui-rac-den-tu-huy-sinh-hoc-bach-hoa-xanh-64x78cm-1kg-202007291029365115.webp', 'Còn bán', 0),
	(129, 13, N'Thức ăn cho mèo trưởng thành Me-O vị hải sản túi 3kg', 296000, 100, 'thuc-an-cho-meo-truong-thanh-me-o-vi-hai-san-tui-3kg-202203200118480042.webp', 'Còn bán', 0),
	(130, 13, N'Thức ăn cho mèo Whiskas hương cá biển túi 3kg', 275000, 100, 'thuc-an-cho-meo-lon-whiskas-vi-ca-bien-tui-3kg-202105121515410083.webp', 'Còn bán', 0),
	(131, 13, N'Thức ăn khô cho chó con SmartHeart vị thịt bò và sữa túi 3kg', 210000, 100, 'thuc-an-kho-cho-cho-con-smartheart-vi-thit-bo-va-sua-tui-3kg-202203261555037628.webp', 'Còn bán', 0),
	(132, 13, N'Thức ăn chó trưởng thành Ganador vị cá hồi và gạo gói 3kg', 215000, 100, 'thuc-an-cho-truong-thanh-ganador-vi-ca-hoi-va-gao-goi-3kg-202210141130005784.webp', 'Còn bán', 0),
	(133, 13, N'Thức ăn giống chó nhỏ trưởng thành SmartHeart vị thịt bò nướng túi 3kg', 200000, 100, 'thuc-an-giong-cho-nho-truong-thanh-smartheart-vi-thit-bo-nuong-tui-3kg-202203200125489102.webp', 'Còn bán', 0),
	(134, 13, N'Thức ăn cho chó lớn Pedigree hương bò và rau củ túi 3kg', 200000, 100, 'thuc-an-cho-cho-lon-pedigree-vi-bo-va-rau-cu-tui-3kg-202105111903437646.webp', 'Còn bán', 0),
	(134, 13, N'Thức ăn chó trưởng thành Ganador vị gà nướng gói 3kg', 193000, 100, 'thuc-an-cho-truong-thanh-ganador-vi-ga-nuong-goi-3kg-202210141141515385.webp', 'Còn bán', 0),
	(134, 13, N'Cát vệ sinh cho mèo Me-O hương chanh bao 4.4kg', 105000, 100, 'cat-ve-sinh-cho-meo-me-o-huong-chanh-bao-5-lit-202205310911523965.webp', 'Còn bán', 0),
	(134, 13, N'Cát vệ sinh cho mèo Catsan bao 4kg', 115000, 100, 'cat-ve-sinh-cho-meo-catsan-bao-5-lit-202105111913384718.webp', 'Còn bán', 0);

--
-- insert bảng PhieuNhap
--

INSERT INTO PhieuNhap (idPhieuNhap, idNhanVien, idNhaCungCap, ngayNhap, tongTien)
VALUES
	(1, 2, 1, '2023-11-21', 2510000),
	(2, 2, 3, '2023-11-21', 2944000),
	(3, 2, 5, '2023-11-21', 5580000),
	(4, 3, 2, '2023-11-22', 1410000),
	(5, 3, 3, '2023-11-22', 350000),
	(6, 4, 1, '2023-11-23', 495000),
	(7, 4, 5, '2023-11-23', 9290000),
	(8, 4, 6, '2023-11-23', 2390000);

--
-- insert bảng ChiTietPhieuNhap
--

INSERT INTO ChiTietPhieuNhap (idPhieuNhap, idSanPham, soLuong, donGia, tongTien)
VALUES	
	(1, 1, 10, 80000, 800000),
	(1, 2, 10, 32000, 320000),
	(1, 3, 10, 42000, 420000),
	(1, 4, 10, 32000, 320000),
	(1, 5, 10, 65000, 650000),
	(2, 23, 10, 6500, 65000),
	(2, 24, 10, 6700, 67000),
	(2, 25, 10, 3200, 32000),
	(2, 26, 10, 13000, 130000),
	(2, 27, 10, 27000, 270000),
	(2, 28, 10, 10000, 100000),
	(2, 29, 10, 27000, 270000),
	(2, 30, 10, 65000, 650000),
	(2, 31, 10, 58000, 580000),
	(2, 32, 10, 68000, 680000),
	(2, 33, 10, 10000, 100000),
	(3, 34, 10, 78000, 780000),
	(3, 35, 10, 65000, 650000),
	(3, 36, 10, 73000, 730000),
	(3, 37, 10, 81500, 815000),
	(3, 38, 10, 45000, 450000),
	(3, 39, 10, 47000, 470000),
	(3, 40, 10, 58000, 580000),
	(3, 41, 10, 54000, 540000),
	(3, 42, 10, 17500, 175000),
	(3, 43, 10, 21500, 215000),
	(3, 44, 10, 17500, 175000),
	(4, 57, 10, 11500, 115000),
	(4, 58, 10, 10000, 100000),
	(4, 59, 10, 11500, 115000),
	(4, 60, 10, 53000, 530000),
	(4, 61, 10, 55000, 550000),
	(5, 62, 10, 3400, 34000),
	(5, 63, 10, 3600, 36000),
	(5, 64, 10, 18000, 180000),
	(5, 65, 10, 10000, 100000),
	(6, 72, 10, 17500, 175000),
	(6, 73, 10, 13500, 135000),
	(6, 74, 10, 9500, 95000),
	(6, 75, 10, 9000, 90000),
	(7, 76, 10, 280000, 2800000),
	(7, 77, 10, 340000, 3400000),
	(7, 78, 10, 100000, 1000000),
	(7, 79, 10, 40000, 400000),
	(7, 80, 10, 40000, 400000),
	(7, 81, 10, 45000, 450000),
	(7, 82, 10, 42000, 420000),
	(7, 83, 10, 42000, 420000),
	(8, 84, 10, 63000, 630000),
	(8, 85, 10, 60000, 600000),
	(8, 86, 10, 63000, 630000),
	(8, 86, 10, 53000, 530000);

--
-- insert bảng KhuyenMai
--

INSERT INTO KhuyenMai (idKhuyenMai, tenKhuyenMai, ngayBatDau, ngayKetThuc, noiDung, phanTram, dieuKien)
VALUES
	(1, N'Giảm giá 5% cho tổng giá trị của đơn hàng.', '2023-11-15', '2023-11-20', N'Giảm giá 5% cho tổng giá trị của đơn hàng với những đơn hàng có giá trị >= 1000000đ .', 0.05, '>= 1000000đ'),
	(2, N'Giảm giá 3% cho sản phẩm', '2023-11-22', '2023-11-25', N'Giảm giá 5% cho các giá trị sản phẩm của mẹ và bé.', 0.05, 'điểm của khách hàng >= 1000'),
	(3, N'Giảm giá 20% cho tổng giá trị của đơn hàng', '2023-11-30', '2023-12-2', N'Giảm giá 20% cho tổng giá trị của đơn hàng đối với khách hàng có điểm >= 2000.', 0.05, 'điểm của khách hàng >= 2000'),
	(4, N'Giảm giá 5% cho sản phẩm', '2023-12-15', '2024-1-5', N'Giảm giá 5% cho các sản phẩm thuộc loại sản phẩm bánh kẹo.', 0.05, 'điểm của khách hàng >= 1000'),
	(5, N'Giảm giá 10% cho sản phẩm', '2023-12-15', '2024-1-15', N'Giảm giá 10% cho các sản phẩm thuộc loại sản phẩm bia và nước giải khát.', 0.05, 'điểm của khách hàng >= 1000');

--
-- insert bảng HoaDon
--

INSERT INTO HoaDon (idHoaDon, idNhanVien, idKhachHang, ngayLap, idKhuyenMai, tongHoaDon)
VALUES
	(1, 7, 1, '2023-11-22', null, 2111000),
	(2, 7, 2, '2023-11-22', null, 119800),
	(3, 7, 3, '2023-11-22', null, 1051500),
	(4, 7, 6, '2023-11-22', null, 1260000),
	(5, 7, 5, '2023-11-22', null, 1085000);

--
-- insert bảng ChiTietHoaDon
-- 

INSERT INTO ChiTietHoaDon (idHoaDon, idSanPham, soLuong, donGia, tongTien)
VALUES
	(1, 40, 2, 59000, 118000),
	(1, 42, 3, 18000, 36000),
	(1, 48, 1, 33000, 66000),
	(1, 49, 1, 68000, 68000),
	(1, 6, 2, 64000, 128000),
	(1, 16, 5, 318000, 1590000),
	(1, 78, 1, 105000, 105000),
	(2, 62, 2, 4000, 8000),
	(2, 63, 2, 4400, 8800),
	(2, 64, 2, 20000, 40000),
	(2, 65, 2, 11500, 23000),
	(2, 66, 2, 11500, 23000),
	(2, 67, 2, 4000, 8000),
	(2, 68, 2, 3600, 7200),
	(2, 69, 2, 4000, 8000),
	(2, 70, 2, 8400, 16800),
	(3, 84, 5, 65000, 325000),
	(3, 85, 5, 62000, 310000),
	(3, 91, 5, 32500, 162500),
	(3, 92, 5, 14300, 71500),
	(3, 93, 5, 18500, 92500),
	(3, 100, 5, 18000, 90000),
	(4, 41, 2, 55000, 110000),
	(4, 46, 2, 16500, 33000),
	(4, 14, 5, 27000, 135000),
	(4, 15, 5, 110000, 550000),
	(4, 20, 2, 26000, 52000),
	(4, 76, 1, 290000, 290000),
	(4, 82, 2, 45000, 90000),
	(5, 116, 2, 33000, 66000),
	(5, 115, 2, 32500, 65000),
	(5, 113, 2, 81000, 162000),
	(5, 112, 2, 106000, 212000),
	(5, 118, 2, 60000, 120000),
	(5, 122, 2, 15000, 30000),
	(5, 132, 2, 215000, 430000);

-- 
-- insert bảng TaiKhoan
--

INSERT INTO TaiKhoan (idTaiKhoan, username, password, idNhanVien)
VALUES
	(1, 'admin', 'admin', 1),
	(2, 'manager', 'manager', 2),
	(3, 'nguyenvanbinh', '0000', 3),
	(4, 'truongvanchuong', '0001', 4),
	(5, 'sale', 'sale', 7),
	(6, 'vuvanninh', '0123', 8),
	(7, 'phanthihuong', '0123', 9);

--
-- insert bảng BaoCao
--

INSERT INTO BaoCao (idBaoCao, idNhanVien, idSanPham, ngayLap, soLuong, lyDo)
VALUES
    (1, 7, 65, '2023-11-23', 3, N'Sản phẩm không đạt yêu cầu.'),
    (2, 7, 70, '2023-11-23', 3, N'Sản phẩm đã hết hạn sử dụng.'),
    (3, 7, 90, '2023-11-23', 3, N'Sản phẩm không đạt yêu cầu.'),
    (4, 7, 100, '2023-11-23', 3, N'Sản phẩm không đạt yêu cầu.'),
    (5, 7, 120, '2023-11-23', 3, N'Sản phẩm đã hết hạn sử dụng.');