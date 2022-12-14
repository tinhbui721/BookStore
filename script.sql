USE [master]
GO
/****** Object:  Database [BookStore]    Script Date: 19/11/2022 8:05:55 CH ******/
CREATE DATABASE [BookStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BookStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BookStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookStore] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BookStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookStore] SET  MULTI_USER 
GO
ALTER DATABASE [BookStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BookStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BookStore] SET QUERY_STORE = OFF
GO
USE [BookStore]
GO
/****** Object:  Table [dbo].[CT_GIOHANG]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_GIOHANG](
	[MaGioHang] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGioHang] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_HOADON]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_HOADON](
	[MaHoaDon] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
	[Gia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHGIASACH]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHGIASACH](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MaSach] [int] NOT NULL,
	[NoiDung] [nvarchar](500) NULL,
	[DanhGia] [int] NULL,
	[NgayDanhGia] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIACHI]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIACHI](
	[MaDiaChi] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiNhan] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MacDinh] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDiaChi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOHANG]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOHANG](
	[Gia] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Gia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIOHANG]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIOHANG](
	[MaGioHang] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
	[DaDungMaGiamGia] [bit] NULL,
	[TongTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [int] NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
	[NgayHoaDon] [datetime] NULL,
	[NgayGiaoHangMin] [datetime] NULL,
	[NgayGiaoHangMax] [datetime] NULL,
	[TongTien] [money] NULL,
	[HinhThucGiao] [nvarchar](50) NULL,
	[HinhThucThanhToan] [nvarchar](50) NULL,
	[MaDiaChi] [int] NULL,
	[TinhTrang] [bit] NULL,
	[PhiVanChuyen] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISACH]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISACH](
	[MaLoaiSach] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSach] [nvarchar](50) NULL,
	[Hinh] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAGIAMGIA]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAGIAMGIA](
	[MaGiamGia] [varchar](5) NOT NULL,
	[TiLeGiam] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiamGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiSach] [int] NULL,
	[TenSach] [nvarchar](100) NULL,
	[TacGia] [nvarchar](100) NULL,
	[NXB] [nvarchar](100) NULL,
	[Gia] [money] NULL,
	[MoTa] [nvarchar](max) NULL,
	[Hinh] [nvarchar](200) NULL,
	[GiamGia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SACHDAXEM]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACHDAXEM](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MaSach] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[IsAdmin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_GIOHANG] ADD  DEFAULT ((1)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[GIOHANG] ADD  DEFAULT ((0)) FOR [DaDungMaGiamGia]
GO
ALTER TABLE [dbo].[GIOHANG] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[TAIKHOAN] ADD  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[CT_GIOHANG]  WITH CHECK ADD  CONSTRAINT [fk_CTGIOHANG_GIOHANG] FOREIGN KEY([MaGioHang])
REFERENCES [dbo].[GIOHANG] ([MaGioHang])
GO
ALTER TABLE [dbo].[CT_GIOHANG] CHECK CONSTRAINT [fk_CTGIOHANG_GIOHANG]
GO
ALTER TABLE [dbo].[CT_GIOHANG]  WITH CHECK ADD  CONSTRAINT [fk_CTGIOHANG_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_GIOHANG] CHECK CONSTRAINT [fk_CTGIOHANG_SACH]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [fk_CTHOADON_HOADON] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [fk_CTHOADON_HOADON]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [fk_CTHOADON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [fk_CTHOADON_SACH]
GO
ALTER TABLE [dbo].[DANHGIASACH]  WITH CHECK ADD  CONSTRAINT [fk_DANHGIASACH_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[DANHGIASACH] CHECK CONSTRAINT [fk_DANHGIASACH_SACH]
GO
ALTER TABLE [dbo].[DANHGIASACH]  WITH CHECK ADD  CONSTRAINT [fk_DANHGIASACH_TAIKHOAN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TAIKHOAN] ([TenDangNhap])
GO
ALTER TABLE [dbo].[DANHGIASACH] CHECK CONSTRAINT [fk_DANHGIASACH_TAIKHOAN]
GO
ALTER TABLE [dbo].[DIACHI]  WITH CHECK ADD  CONSTRAINT [fk_DIACHI_TAIKHOAN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TAIKHOAN] ([TenDangNhap])
GO
ALTER TABLE [dbo].[DIACHI] CHECK CONSTRAINT [fk_DIACHI_TAIKHOAN]
GO
ALTER TABLE [dbo].[GIOHANG]  WITH CHECK ADD  CONSTRAINT [fk_GIOHANG_TAIKHOAN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TAIKHOAN] ([TenDangNhap])
GO
ALTER TABLE [dbo].[GIOHANG] CHECK CONSTRAINT [fk_GIOHANG_TAIKHOAN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk_HOADON_DIACHI] FOREIGN KEY([MaDiaChi])
REFERENCES [dbo].[DIACHI] ([MaDiaChi])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk_HOADON_DIACHI]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk_HOADON_TAIKHOAN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TAIKHOAN] ([TenDangNhap])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk_HOADON_TAIKHOAN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [fk_SACH_LOAISACH] FOREIGN KEY([MaLoaiSach])
REFERENCES [dbo].[LOAISACH] ([MaLoaiSach])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [fk_SACH_LOAISACH]
GO
ALTER TABLE [dbo].[SACHDAXEM]  WITH CHECK ADD  CONSTRAINT [fk_SACHDAXEM_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[SACHDAXEM] CHECK CONSTRAINT [fk_SACHDAXEM_SACH]
GO
ALTER TABLE [dbo].[SACHDAXEM]  WITH CHECK ADD  CONSTRAINT [fk_SACHDAXEM_TAIKHOAN] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TAIKHOAN] ([TenDangNhap])
GO
ALTER TABLE [dbo].[SACHDAXEM] CHECK CONSTRAINT [fk_SACHDAXEM_TAIKHOAN]
GO
/****** Object:  StoredProcedure [dbo].[sp_ApDungMa]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Áp dụng mã giảm giá 
create proc [dbo].[sp_ApDungMa] @MaGiamGia varchar(5), @MaGioHang int
as begin
	if exists (select * from MAGIAMGIA where MaGiamGia = @MaGiamGia)
	begin

		declare @TiLeGiam int, @DaDungMaGiamGia bit
		select @DaDungMaGiamGia = DaDungMaGiamGia from GIOHANG where MaGioHang = @MaGioHang
		if (@DaDungMaGiamGia = 0)
		begin 
			select @TiLeGiam = TiLeGiam from MAGIAMGIA where MaGiamGia = @MaGiamGia
			update GIOHANG set TongTien = TongTien - TongTien*@TiLeGiam/100, DaDungMaGiamGia = 1 where MaGioHang = @MaGioHang
		end
	end
end

GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhapTinhTrangHoaDon]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_CapNhapTinhTrangHoaDon] @MaHoaDon int
as begin
	update HOADON 
	set TinhTrang = 1
	where MaHoaDon = @MaHoaDon
end

GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatLoaiSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Sua loai sach
create PROC [dbo].[sp_CapNhatLoaiSach](@MaLoaiSach int, @TenLoaiSach nvarchar(50), @Hinh nvarchar(200), @CurrentID int output)
as
begin try
if(not exists(select * from LOAISACH where MaLoaiSach=@MaLoaiSach))
begin
set @CurrentID=0
return
end
Update LOAISACH Set  TenLoaiSach=@TenLoaiSach,Hinh= @Hinh where MaLoaiSach=@MaLoaiSach;
set @CurrentID=1
end try
begin catch
set @CurrentID=0
end catch

GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Cap nhat sach
create PROC [dbo].[sp_CapNhatSach] (@MaSach int ,@MaLoaiSach int,
	@TenSach nvarchar(100),
	@TacGia nvarchar(100),
	@NXB int,
	@Gia money,
	@MoTa nvarchar(max),
	@Hinh nvarchar(200), @GiamGia int, @CurrentID int output)
as
begin try
if(not exists(select * from SACH where MaSach=@MaSach and MaLoaiSach=@MaLoaiSach))
begin
set @CurrentID=0
return
end
Update  SACH  set MaLoaiSach=@MaLoaiSach,TenSach=@TenSach,NXB=@NXB,Gia=@Gia,MoTa=@MoTa,Hinh=@Hinh,GiamGia=@GiamGia where MaSach=@MaSach;
set @CurrentID=1
end try
begin catch
set @CurrentID=0
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatTaiKhoan]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Sửa tài khoản
create procedure [dbo].[sp_CapNhatTaiKhoan] @TenDangNhap varchar(50), @TenKhachHang nvarchar(50), @SoDienThoai varchar(10), @Email varchar(50), @NgaySinh datetime, @GioiTinh bit, @CurrentID int output
as
begin try
if(not exists(select * from TAIKHOAN where TenDangNhap=@TenDangNhap))
begin
set @CurrentID=0
return
end
Update TAIKHOAN
set TenKhachHang=@TenKhachHang, SoDienThoai=@SoDienThoai, Email=@Email, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh 
where TenDangNhap=@TenDangNhap;
set @CurrentID=1
end try
begin catch
set @CurrentID=0
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckDiaChi]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_CheckDiaChi] @MaDiaChi int
as begin
	select DIACHI.MaDiaChi from DIACHI, HOADON where DIACHI.MaDiaChi = HoaDon.MaDiaChi and DIACHI.MaDiaChi = @MaDiaChi
end

GO
/****** Object:  StoredProcedure [dbo].[sp_DoiMatKhau]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Đổi mật khẩu
create procedure [dbo].[sp_DoiMatKhau] @TenDangNhap varchar(50), @MatKhau varchar(50), @CurrentID int output
as
begin try
if(not exists(select * from TAIKHOAN where TenDangNhap=@TenDangNhap))
begin
set @CurrentID=0
return
end
Update TAIKHOAN
set MatKhau=@MatKhau
where TenDangNhap=@TenDangNhap
set @CurrentID=1
end try
begin catch
set @CurrentID=0
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_GiamSoLuong]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Giảm số lượng
create procedure [dbo].[sp_GiamSoLuong] @MaGioHang int, @MaSach int
as begin
	declare @SoLuongHienTai int
	select @SoLuongHienTai = SoLuong from CT_GIOHANG where MaGioHang = @MaGioHang and MaSach = @MaSach
	set @SoLuongHienTai = @SoLuongHienTai - 1

	if(@SoLuongHienTai = 0)
	begin 
		Delete from CT_GIOHANG where MaGioHang = @MaGioHang and MaSach = @MaSach
	end
	else begin
		declare @ThanhTien money, @Gia money, @GiamGiaSach int
		select @Gia = Gia from SACH where MaSach = @MaSach
		select @GiamGiaSach = GiamGia from SACH where MaSach = @MaSach
		set @ThanhTien = (@Gia - @Gia*@GiamGiaSach/100)*@SoLuongHienTai
		Update CT_GIOHANG set SoLuong = @SoLuongHienTai, ThanhTien = @ThanhTien where MaSach = @MaSach and MaGioHang = @MaGioHang
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraDonHang]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_KiemTraDonHang] @TenDangNhap varchar(50), @MaHoaDon int
as begin
	select MaHoaDon from HOADON where TenDangNhap = @TenDangNhap and MaHoaDon = @MaHoaDon
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayChiTietHoaDon]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Lấy CT_HOADON theo MaHoaDon
create proc [dbo].[sp_LayChiTietHoaDon]  @MaHoaDon int
as begin
	select HOADON.MaHoaDon, SACH.MaSach, TinhTrang, TenNguoiNhan, SDT, DiaChi, NgayHoaDon, HinhThucGiao, HinhThucThanhToan, Hinh, TenSach, CT_HOADON.Gia, SoLuong, ThanhTien, PhiVanChuyen, TongTien from CT_HOADON, HOADON, DIACHI, SACH where SACH.MaSach = CT_HOADON.MaSach and DIACHI.MaDiaChi = HOADON.MaDiaChi and HOADON.MaHoaDon = CT_HOADON.MaHoaDon and HOADON.MaHoaDon = @MaHoaDon
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachLoaiSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy danh sách loại sách
create procedure [dbo].[sp_LayDanhSachLoaiSach]
as begin
	select * from LOAISACH
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachMaGiamGia]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Lây danh sách mã giảm giá
create procedure [dbo].[sp_LayDanhSachMaGiamGia] 
as begin
	select * from MAGIAMGIA
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy danh sách sách
create procedure [dbo].[sp_LayDanhSachSach]
as begin
	select * from SACH
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachSachTheoKhuyenMai]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy danh sách sách theo mã khuyến mãi của sách
create procedure [dbo].[sp_LayDanhSachSachTheoKhuyenMai]
as begin
	select top 5 *
	from SACH
	order by GiamGia Desc
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachSachTheoLoaiSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Lấy danh sách sách theo mã loại 
create procedure [dbo].[sp_LayDanhSachSachTheoLoaiSach] @MaLoaiSach int
as begin
	if (@MaLoaiSach = 0)
	begin
		select MaSach,LOAISACH.MaLoaiSach, LOAISACH.TenLoaiSach, TenSach, TacGia, Gia, MoTa, SACH.Hinh, SACH.GiamGia
		from SACH join LOAISACH on SACH.MaLoaiSach = LOAISACH.MaLoaiSach
	end
	else begin
		select MaSach,LOAISACH.MaLoaiSach, LOAISACH.TenLoaiSach, TenSach, TacGia, Gia, MoTa, SACH.Hinh, SACH.GiamGia
		from SACH join LOAISACH on SACH.MaLoaiSach = LOAISACH.MaLoaiSach
		where LOAISACH.MaLoaiSach = @MaLoaiSach
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayDanhSachTaiKhoan]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy thông tin tài khoản theo tên đăng nhâp
create procedure [dbo].[sp_LayDanhSachTaiKhoan]
as begin
	select * from TAIKHOAN
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LayDiaChi]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Lấy địa chỉ theo tên đăng nhập
create proc [dbo].[sp_LayDiaChi] @TenDangNhap varchar(50)
as begin
	select * from DIACHI where TenDangNhap = @TenDangNhap
end

--exec sp_LayDiaChi tinh
GO
/****** Object:  StoredProcedure [dbo].[sp_LayGiaGiaoHang]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Lấy giá tiền giao hàng
create proc [dbo].[sp_LayGiaGiaoHang]
as begin
	select * from GIAOHANG
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LayHoaDonTheoTenDangNhap]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy hóa đơn theo tên đăng nhâp
create procedure [dbo].[sp_LayHoaDonTheoTenDangNhap] @TenDangNhap varchar(50)
as begin
	select *
	from HOADON 
	where TenDangNhap = @TenDangNhap
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaGiamGia]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Lấy mã giảm giá
create procedure [dbo].[sp_LayMaGiamGia] @MaGiamGia varchar(5)
as begin
	Select * from MAGIAMGIA where MaGiamGia = @MaGiamGia
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LaySachTheoMaSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LaySachTheoMaSach] @MaSach int
as begin
	select * from SACH where MaSach = @MaSach
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LayTatCaHoaDon]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Lấy thông tin tất cả hóa đơn
create proc [dbo].[sp_LayTatCaHoaDon]
as begin
	select COUNT(*) as SoCTHD, HOADON.MaHoaDon, TinhTrang into Temp
	from HOADON, CT_HOADON
	where HOADON.MaHoaDon = CT_HOADON.MaHoaDon
	group by HOADON.MaHoaDon, TinhTrang 

	select  SoCTHD,  Temp.MaHoaDon, TenSach, TinhTrang  from Temp, CT_HOADON, SACH where Temp.MaHoaDon = CT_HOADON.MaHoaDon and CT_HOADON.MaSach = SACH.MaSach

	drop table Temp
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinGioHang]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_LayThongTinGioHang] @TenDangNhap varchar(50)
as begin

	select TenSach, ThanhTien, SoLuong, Hinh, TongTien, GIOHANG.MaGioHang, CT_GIOHANG.MaSach, Gia, GiamGia
	from GIOHANG, SACH, CT_GIOHANG
	where CT_GIOHANG.MaSach = SACH.MaSach and CT_GIOHANG.MaGioHang = GIOHANG.MaGioHang and TenDangNhap = @TenDangNhap

end
GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinHoaDon]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Lấy thông tin hóa đơn theo TenDangNhap
create proc [dbo].[sp_LayThongTinHoaDon] @TenDangNhap varchar(50)
as begin
	select COUNT(*) as SoCTHD, HOADON.MaHoaDon, TinhTrang into Temp
	from HOADON, CT_HOADON
	where HOADON.MaHoaDon = CT_HOADON.MaHoaDon and TenDangNhap = @TenDangNhap
	group by HOADON.MaHoaDon, TinhTrang 

	select  SoCTHD,  Temp.MaHoaDon, TenSach, TinhTrang  from Temp, CT_HOADON, SACH where Temp.MaHoaDon = CT_HOADON.MaHoaDon and CT_HOADON.MaSach = SACH.MaSach

	drop table Temp
end

--Xóa chi tiết hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinHoaDonTheoMa]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Lấy thông tin hóa đơn theo MaHoaDon
create proc [dbo].[sp_LayThongTinHoaDonTheoMa] @MaHoaDon int
as begin
	select COUNT(*) as SoCTHD, HOADON.MaHoaDon, TinhTrang into Temp
	from HOADON, CT_HOADON
	where HOADON.MaHoaDon = CT_HOADON.MaHoaDon and HOADON.MaHoaDon = @MaHoaDon
	group by HOADON.MaHoaDon, TinhTrang 

	select  SoCTHD,  Temp.MaHoaDon, TenSach, TinhTrang  from Temp, CT_HOADON, SACH where Temp.MaHoaDon = CT_HOADON.MaHoaDon and CT_HOADON.MaSach = SACH.MaSach

	drop table Temp
end


GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinSPDaXem]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_LayThongTinSPDaXem] @TenDangNhap varchar(50)
as begin

	select SACH.MaSach, MaLoaiSach, TenSach, MoTa, Gia, GiamGia, Hinh
	from SACHDAXEM, SACH
	where SACHDAXEM.MaSach = SACH.MaSach and TenDangNhap = @TenDangNhap
end

GO
/****** Object:  StoredProcedure [dbo].[sp_LayThongTinTaiKhoan]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Lấy thông tin tài khoản theo tên đăng nhâp
create procedure [dbo].[sp_LayThongTinTaiKhoan] @TenDangNhap nvarchar(50)
as begin
	select * from TAIKHOAN where TenDangNhap = @TenDangNhap
end

GO
/****** Object:  StoredProcedure [dbo].[sp_SuaGiaGiaoHang]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Sửa giá tiền giao hàng
create proc [dbo].[sp_SuaGiaGiaoHang] @Gia money
as begin
	update GIAOHANG set Gia = @Gia;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaMaGiamGia]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Sửa mã giảm giá
create procedure [dbo].[sp_SuaMaGiamGia] @MaGiamGia varchar(5), @TiLeGiam int
as begin
	if @TiLeGiam > 0 and @TiLeGiam < 100
	begin 
		update MAGIAMGIA set TiLeGiam = @TiLeGiam where MaGiamGia = @MaGiamGia
	end
end

--exec sp_SuaMaGiamGia 12345, 50

GO
/****** Object:  StoredProcedure [dbo].[sp_TangSoLuong]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Tăng số lượng
create procedure [dbo].[sp_TangSoLuong] @MaGioHang nvarchar(50), @MaSach int
as begin
	declare @SoLuongHienTai int
	select @SoLuongHienTai = SoLuong from CT_GIOHANG where MaGioHang = @MaGioHang and MaSach = @MaSach
	
	set @SoLuongHienTai = @SoLuongHienTai + 1

		declare @ThanhTien money, @Gia money, @GiamGiaSach int
		select @Gia = Gia from SACH where MaSach = @MaSach
		select @GiamGiaSach = GiamGia from SACH where MaSach = @MaSach
		set @ThanhTien = (@Gia - @Gia*@GiamGiaSach/100)*@SoLuongHienTai
		Update CT_GIOHANG set SoLuong = @SoLuongHienTai, ThanhTien = @ThanhTien where MaSach = @MaSach and MaGioHang = @MaGioHang

end

GO
/****** Object:  StoredProcedure [dbo].[sp_ThayDoiDiaChiMacDinh]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thay đổi địa chỉ mặc định
create proc [dbo].[sp_ThayDoiDiaChiMacDinh] @MaDiaChi int, @TenDangNhap varchar(50)
as begin
	update DIACHI set MacDinh = 0 where TenDangNhap = @TenDangNhap
	update DIACHI set MacDinh = 1 where TenDangNhap = @TenDangNhap and MaDiaChi = @MaDiaChi
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemDiaChi]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thêm địa chỉ
create proc [dbo].[sp_ThemDiaChi] @TenNguoiNhan nvarchar(50), @SDT varchar(10), @DiaChi nvarchar(100), @TenDangNhap varchar(50)
as begin
	declare @MacDinh bit
	set @MacDinh = 0
	if not exists(select * from DIACHI where TenDangNhap = @TenDangNhap)
	begin
		set @MacDinh = 1;
	end
	insert into DIACHI (TenNguoiNhan, SDT, DiaChi, TenDangNhap, MacDinh) values (@TenNguoiNhan, @SDT, @DiaChi, @TenDangNhap, @MacDinh)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemHoaDon]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Khi đặt hàng sẽ gọi
create procedure [dbo].[sp_ThemHoaDon] @TenDangNhap varchar(50), @NgayHoaDon datetime, @NgayGiaoHangMin datetime, @NgayGiaoHangMax datetime, @MaDiaChi int
as begin
	-- Tạo hóa đơn
	declare @TongTien money, @MaHoaDon int, @Gia money, @PhiVanChuyen money
	select top 1 @Gia = Gia from GIAOHANG
	select @TongTien = TongTien + @Gia from GIOHANG where TenDangNhap = @TenDangNhap
	select @PhiVanChuyen = Gia from GIAOHANG
	set @MaHoaDon = 1
	while @MaHoaDon in (select MaHoaDon from HOADON)
		set @MaHoaDon = @MaHoaDon + 1
	insert into HOADON values (@MaHoaDon, @TenDangNhap, @NgayHoaDon, @NgayGiaoHangMin, @NgayGiaoHangMax, @TongTien, N'Giao hàng tiêu chuẩn', N'Thanh toán khi nhận hàng', @MaDiaChi, 0, @PhiVanChuyen)
	
	-- Tạo chi tiết hóa đơn
	declare @MaGioHang int , @MaSach int, @SoLuong int, @ThanhTien money, @GiaSP money
	select @MaGioHang = MaGioHang from GIOHANG where TenDangNhap = @TenDangNhap

	declare CUR_GIOHANG cursor for select MaSach, SoLuong, ThanhTien from CT_GIOHANG where MaGioHang = @MaGioHang
	open CUR_GIOHANG
	FETCH NEXT FROM CUR_GIOHANG INTO @MaSach, @SoLuong, @ThanhTien
	WHILE @@FETCH_STATUS = 0
	BEGIN
		select @GiaSP = Gia - Gia*GiamGia/100 from SACH where MaSach = @MaSach
		insert into CT_HOADON values (@MaHoaDon, @MaSach, @SoLuong, @ThanhTien, @GiaSP)
		FETCH NEXT FROM CUR_GIOHANG INTO @MaSach, @SoLuong, @ThanhTien
	END
	CLOSE CUR_GIOHANG
	DEALLOCATE CUR_GIOHANG

	-- Xóa CT_GioHang
	delete from CT_GIOHANG where MaGioHang = @MaGioHang
	update GIOHANG set DaDungMaGiamGia = 0 where MaGioHang = @MaGioHang
end

--Cập nhật tình trạng hóa đơn
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemLoaiSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Them loai sach
create PROC [dbo].[sp_ThemLoaiSach](@TenLoaiSach nvarchar(50), @Hinh nvarchar(200), @CurrentID int output)
as
begin try

if(exists(select * from LOAISACH where TenLoaiSach=@TenLoaiSach))
begin
set @CurrentID=0
return
end
insert into LOAISACH values (@TenLoaiSach, @Hinh);
set @CurrentID=@@IDENTITY
end try
begin catch
set @CurrentID=0
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMaGiamGia]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thêm mã giảm giá
create procedure [dbo].[sp_ThemMaGiamGia] @MaGiamGia varchar(5), @TiLeGiam int
as begin
	if not exists (select * from MAGIAMGIA where  MaGiamGia = @MaGiamGia)
	begin
		if @TiLeGiam > 0 and @TiLeGiam < 100
		begin 
			insert into MAGIAMGIA values (@MaGiamGia, @TiLeGiam)
		end
	end
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Thêm sách
create PROC [dbo].[sp_ThemSach] (@MaLoaiSach int,
	@TenSach nvarchar (100),
	@TacGia nvarchar (100),
	@NXB int,
	@Gia money,
	@MoTa nvarchar(max),
	@Hinh nvarchar(200), @GiamGia int, @CurrentID int output)
as
begin try

if(exists(select * from SACH where TenSach=@TenSach and MaLoaiSach=@MaLoaiSach))
begin
set @CurrentID=0
return
end
insert into SACH values(@MaLoaiSach,@TenSach,@TacGia,@NXB,@Gia,@MoTa,@Hinh,@GiamGia);
set @CurrentID=@@IDENTITY
end try
begin catch
set @CurrentID=0
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSachDaXem]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_ThemSachDaXem] @TenDangNhap varchar(50), @MaSach int
as begin
	if not exists (select * from SACHDAXEM where TenDangNhap = @TenDangNhap and MaSach =  @MaSach)
	begin
		insert into SACHDAXEM values(@TenDangNhap, @MaSach)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemSachVaoGioHang]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thêm sách vào giỏ hàng 
create procedure [dbo].[sp_ThemSachVaoGioHang] @TenDangNhap varchar(50), @MaSach int
as begin
	declare @MaGioHang int, @ThanhTien money, @Gia money, @GiamGiaSach int
	select @Gia = Gia - Gia*GiamGia/100 from SACH where MaSach = @MaSach
	set @ThanhTien = @Gia;
	select @MaGioHang = MaGioHang from GIOHANG where TenDangNhap = @TenDangNhap
	insert into CT_GIOHANG(MaGioHang, MaSach, ThanhTien) values (@MaGioHang, @MaSach, @ThanhTien);
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemTaiKhoan]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Thêm tài khoản
create procedure [dbo].[sp_ThemTaiKhoan] @TenDangNhap varchar(50), @MatKhau varchar(50), @TenKhachHang nvarchar(50), @SoDienThoai varchar(10), @Email varchar(50), @NgaySinh datetime, @GioiTinh bit, @IsAdmin bit, @CurrentID int output
as 
begin try
if(exists(select * from TAIKHOAN where TenDangNhap=@TenDangNhap))
begin
set @CurrentID=0
return
end
	insert into TAIKHOAN values(@TenDangNhap, @MatKhau, @TenKhachHang, @SoDienThoai, @Email, @NgaySinh, @GioiTinh, @IsAdmin)
	insert into GIOHANG(TenDangNhap) values(@TenDangNhap) -- Tạo giỏ hàng cho tài khoản
	set @CurrentID=1
end try
begin catch
set @CurrentID=0
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMatKhauQuaEmail]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[sp_UpdateMatKhauQuaEmail] @Email varchar(50), @MatKhau varchar(50)
as begin
	update TAIKHOAN set MatKhau = @MatKhau where Email = @Email
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaChiTietHoaDon]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_XoaChiTietHoaDon] @MaHoaDon int
as begin
	delete from CT_HOADON where MaHoaDon = @MaHoaDon
	delete from HOADON where MaHoaDon = @MaHoaDon
end

GO
/****** Object:  StoredProcedure [dbo].[sp_XoaDiaChi]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Xóa địa chỉ
create proc [dbo].[sp_XoaDiaChi] @MaDiaChi int
as begin
	delete from DIACHI where MaDiaChi = @MaDiaChi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaGioHang]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Xóa tất cả CT_GIOHANG khi đã đặt hàng
create proc [dbo].[sp_XoaGioHang] @MaGioHang int 
as begin
	delete from CT_GIOHANG where MaGioHang = @MaGioHang
end


GO
/****** Object:  StoredProcedure [dbo].[sp_XoaLoaiSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xoa loai sach
create PROC [dbo].[sp_XoaLoaiSach] @MaLoaiSach int, @CurrentID int output
as
begin try
if(not exists(select * from LOAISACH where MaLoaiSach=@MaLoaiSach) or (select COUNT(*) from SACH where MaLoaiSach=@MaLoaiSach)>0)
begin
set @CurrentID=0
return
end
Delete From LOAISACH where MaLoaiSach=@MaLoaiSach;
set @CurrentID=1
end try
begin catch
set @CurrentID=0
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaMaGiamGia]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Xóa mã giảm giá
create procedure [dbo].[sp_XoaMaGiamGia] @MaGiamGia varchar(5)
as begin
	Delete from MAGIAMGIA where MaGiamGia = @MaGiamGia
end

GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSach]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Xoa sach
create PROC [dbo].[sp_XoaSach] @MaSach int,@CurrentID int output
as
begin try
if(not exists(select * from SACH where MaSach=@MaSach))
begin
set @CurrentID=0
return
end
Delete From SACH where MaSach=@MaSach;
set @CurrentID=1
end try
begin catch
set @CurrentID=0
end catch
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaTaiKhoan]    Script Date: 19/11/2022 8:05:55 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--xóa tài khoản
create procedure [dbo].[sp_XoaTaiKhoan] @TenDangNhap varchar(50),@CurrentID int output
as
begin try
if(not exists(select * from TAIKHOAN where TenDangNhap=@TenDangNhap))
begin
set @CurrentID=0
return
end
delete from GIOHANG where TenDangNhap = @TenDangNhap;
Delete From TAIKHOAN where TenDangNhap=@TenDangNhap;
set @CurrentID=1
end try
begin catch
set @CurrentID=0
end catch
GO
USE [master]
GO
ALTER DATABASE [BookStore] SET  READ_WRITE 
GO
