USE [master]
GO
/****** Object:  Database [Quan_Ly_Kho]    Script Date: 6/29/2021 12:25:02 PM ******/
CREATE DATABASE [Quan_Ly_Kho]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quan_Ly_Kho', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Quan_Ly_Kho.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quan_Ly_Kho_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Quan_Ly_Kho_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Quan_Ly_Kho] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quan_Ly_Kho].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quan_Ly_Kho] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Quan_Ly_Kho] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quan_Ly_Kho] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quan_Ly_Kho] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Quan_Ly_Kho] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quan_Ly_Kho] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quan_Ly_Kho] SET  MULTI_USER 
GO
ALTER DATABASE [Quan_Ly_Kho] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quan_Ly_Kho] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quan_Ly_Kho] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quan_Ly_Kho] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quan_Ly_Kho] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quan_Ly_Kho] SET QUERY_STORE = OFF
GO
USE [Quan_Ly_Kho]
GO
/****** Object:  Table [dbo].[Chitietnhap]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietnhap](
	[maCTN] [char](10) NOT NULL,
	[maPN] [char](10) NULL,
	[maHH] [char](10) NULL,
	[soLuong] [int] NULL,
	[donGia] [money] NULL,
 CONSTRAINT [PK_Chitietnhap] PRIMARY KEY CLUSTERED 
(
	[maCTN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chitietxuat]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitietxuat](
	[maCTX] [char](10) NOT NULL,
	[maPX] [char](10) NULL,
	[maHH] [char](10) NULL,
	[soLuong] [int] NULL,
	[donGia] [money] NULL,
 CONSTRAINT [PK_Chitietxuat] PRIMARY KEY CLUSTERED 
(
	[maCTX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[maHH] [char](10) NOT NULL,
	[tenHH] [nvarchar](50) NOT NULL,
	[maNCC] [char](10) NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[maHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NCC]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NCC](
	[MaNCC] [char](10) NOT NULL,
	[TenNCC] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[maPN] [char](10) NOT NULL,
	[ngayNhap] [date] NULL,
	[tongTien] [money] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuat]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuat](
	[maPX] [char](10) NOT NULL,
	[ngayXuat] [date] NULL,
	[tongTien] [money] NULL,
 CONSTRAINT [PK_PhieuXuat] PRIMARY KEY CLUSTERED 
(
	[maPX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[acc] [char](15) NOT NULL,
	[pass] [char](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[acc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Chitietnhap]  WITH CHECK ADD FOREIGN KEY([maHH])
REFERENCES [dbo].[HangHoa] ([maHH])
GO
ALTER TABLE [dbo].[Chitietnhap]  WITH CHECK ADD FOREIGN KEY([maPN])
REFERENCES [dbo].[PhieuNhap] ([maPN])
GO
ALTER TABLE [dbo].[Chitietxuat]  WITH CHECK ADD FOREIGN KEY([maHH])
REFERENCES [dbo].[HangHoa] ([maHH])
GO
ALTER TABLE [dbo].[Chitietxuat]  WITH CHECK ADD FOREIGN KEY([maPX])
REFERENCES [dbo].[PhieuXuat] ([maPX])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([maNCC])
REFERENCES [dbo].[NCC] ([MaNCC])
GO
/****** Object:  StoredProcedure [dbo].[sua_CTN]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_CTN](@maCTN char(10),@maPN char(10),@maHH char(10),@soLuong int,@donGia money)
as
begin
update Chitietnhap
set maPN = @maPN,
	maHH = @maHH,
	soLuong = @soLuong,
	donGia = @donGia
where maCTN = @maCTN
end

GO
/****** Object:  StoredProcedure [dbo].[sua_CTX]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_CTX](@maCTX char(10),@maPX char(10),@maHH char(10),@soLuong int,@donGia money)
as
begin
update Chitietxuat
set maPX = @maPX,
	maHH = @maHH,
	soLuong = @soLuong,
	donGia = @donGia
where maCTX = @maCTX
end

GO
/****** Object:  StoredProcedure [dbo].[sua_HH]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sua_HH](@maHH char(10),@tenHH nvarchar(50),@maNCC char(10))
as
begin
update HangHoa
set tenHH = @tenHH,
	maNCC = @maNCC
where maHH = @maHH
end

GO
/****** Object:  StoredProcedure [dbo].[sua_NCC]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sua_NCC](@maNCC char(10),@tenNCC nvarchar(30),@diaChi nvarchar(50))
as
begin
update NCC
set tenNCC = @tenNCC,
	diaChi = @diaChi
where maNCC = @maNCC
end
GO
/****** Object:  StoredProcedure [dbo].[sua_PN]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sua_PN](@maPN char(10),@ngayNhap date,@tongTien money)
as
begin
update PhieuNhap
set ngayNhap = @ngayNhap,
	tongTien = @tongTien
where maPN = @maPN
end
GO
/****** Object:  StoredProcedure [dbo].[sua_PX]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sua_PX](@maPX char(10),@ngayXuat date,@tongTien money)
as
begin
update PhieuXuat
set ngayXuat = @ngayXuat,
	tongTien = @tongTien
where maPX = @maPX
end

GO
/****** Object:  StoredProcedure [dbo].[them_CTN]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--chi tiết nhập
create proc [dbo].[them_CTN](@maCTN char(10),@maPN char(10),@maHH char(10),@soLuong int,@donGia money)
as
begin
if exists (select maCTN from Chitietnhap where maCTN = @maCTN) print('Ko thêm được')
else
insert into Chitietnhap values (@maCTN,@maPN,@maHH,@soLuong,@donGia)
end

GO
/****** Object:  StoredProcedure [dbo].[them_CTX]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Chi tiết xuất
create proc [dbo].[them_CTX](@maCTX char(10),@maPX char(10),@maHH char(10),@soLuong int,@donGia money)
as
begin
if exists (select maCTX from Chitietxuat where maCTX = @maCTX) print('Ko thêm được')
else
insert into Chitietxuat values (@maCTX,@maPX,@maHH,@soLuong,@donGia)
end

GO
/****** Object:  StoredProcedure [dbo].[them_HH]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_HH](@maHH char(10),@tenHH nvarchar(50),@maNCC char(10),@soluong int)
as
begin
if exists (select maHH from HangHoa where maHH = @maHH) print ('Ko thêm được')
else
insert into HangHoa values (@maHH,@tenHH,@maNCC,@soluong)
end
GO
/****** Object:  StoredProcedure [dbo].[them_NCC]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_NCC](@maNCC char(10),@tenNCC nvarchar(30),@diaChi nvarchar(50))
as
begin
if exists (select maNCC from NCC where maNCC=@maNCC) print('Ko tồn tại')
else
insert into NCC values(@maNCC,@tenNCC,@diaChi)
end
GO
/****** Object:  StoredProcedure [dbo].[them_PN]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Phiếu nhập
CREATE proc [dbo].[them_PN](@maPN char(10),@ngayNhap date,@tongTien money)
as
begin
if exists(select maPN from PhieuNhap where maPN = @maPN) print('Ko thêm được')
else
insert into PhieuNhap values(@maPN,@ngayNhap,@tongTien)
end

GO
/****** Object:  StoredProcedure [dbo].[them_PX]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--pHIẾU XUẤT
CREATE proc [dbo].[them_PX](@maPX char(10),@ngayXuat date,@tongTien money)
as
begin
if exists (select maPX from PhieuXuat where maPX = @maPX) print('Ko thêm được')
else
insert into PhieuXuat values (@maPX,@ngayXuat,@tongTien)
end

GO
/****** Object:  StoredProcedure [dbo].[them_TK]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[them_TK](@acc char(15),@pass char(15))
as
begin
if exists(select acc from TaiKhoan where acc=@acc) print('khong them duoc')
else
insert into TaiKhoan values(@acc,@pass)
end

GO
/****** Object:  StoredProcedure [dbo].[thongke_HH]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--thống kê hàng hóa
create proc [dbo].[thongke_HH]
as
begin
	select maHH as [Mã Hàng Hóa],tenHH as [Tên Hàng Hóa],maNCC as [Mã NCC]
	from HangHoa
end

GO
/****** Object:  StoredProcedure [dbo].[thongke_Nhap]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thống kê phiếu nhập
CREATE proc [dbo].[thongke_Nhap]
as
begin
	select maPN as [Mã Phiếu Nhập],ngayNhap as [Ngày Nhập],tongTien as [Tổng Tiền]
	from PhieuNhap
end

GO
/****** Object:  StoredProcedure [dbo].[thongke_Xuat]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thống kê phiếu xuất
CREATE proc [dbo].[thongke_Xuat]
as
begin
	select maPX as [Mã Phiếu Xuất],ngayXuat as [Ngày Nhập],tongTien as [Tổng Tiền]
	from PhieuXuat
end

GO
/****** Object:  StoredProcedure [dbo].[timkiem_HH1]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- tìm theo mã hh
create proc [dbo].[timkiem_HH1](@maHH char(10))
as
begin
	select maHH,tenHH,maNCC from HangHoa where maHH=@maHH
end

GO
/****** Object:  StoredProcedure [dbo].[timkiem_HH2]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- tìm theo tên HH
create proc [dbo].[timkiem_HH2](@tenHH nvarchar(50))
as
begin
	select maHH,tenHH,maNCC from HangHoa Where tenHH=@tenHH
end

GO
/****** Object:  StoredProcedure [dbo].[tk_hh]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tk_hh]
 as
 begin
 select  maHH as N'Mã Hàng hóa', tenHH as N'Tên Hàng hóa', tenNCC as N'Nhà cung cấp' , soluong as 'Số lượng'
 from HangHoa HH, NCC
 where HH.maNCC=NCC.maNCC
 end
GO
/****** Object:  StoredProcedure [dbo].[tk_nhap]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[tk_nhap]
 as
 begin
 select HH.maHH as N'Mã HH', tenHH as N'Tên HH', tenNCC as N'Tên NCC',sum(CTN.soluong) as 'SL Nhập', donGia as N'Đơn giá', sum(CTN.donGia*CTN.soLuong) as N'Tiền Nhập'
 from HangHoa HH, NCC,  Chitietnhap  CTN
 where HH.maNCC=NCC.maNCC and HH.maHH=CTN.maHH
 group by HH.maHH, tenHH, tenNCC, donGia 
 end



GO
/****** Object:  StoredProcedure [dbo].[tk_xuat]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[tk_xuat]
as
 begin
 select HH.maHH as N'Mã HH', tenHH as N'Tên HH', tenNCC as N'Tên NCC',sum(CTX.soluong) as 'SL Xuất', donGia as N'Đơn giá', sum(CTX.donGia*CTX.soLuong) as N'Tiền Xuất'
 from HangHoa HH, NCC,  Chitietxuat  CTX
 where HH.maNCC=NCC.maNCC and HH.maHH=CTX.maHH
 group by HH.maHH, tenHH, tenNCC, donGia
 end



GO
/****** Object:  StoredProcedure [dbo].[xoa_CTN]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_CTN](@maCTN char(10))
as
begin
delete Chitietnhap
where maCTN = @maCTN
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_CTX]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_CTX](@maCTX char(10))
as
begin
delete Chitietxuat
where maCTX = @maCTX
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_HH]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xoa_HH](@maHH char(10))
as
begin
delete HangHoa
where maHH = @maHH
end

GO
/****** Object:  StoredProcedure [dbo].[xoa_NCC]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xoa_NCC] (@maNCC char(10))
as
begin
delete NCC
where maNCC = @maNCC
end
GO
/****** Object:  StoredProcedure [dbo].[xoa_PN]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



 CREATE proc [dbo].[xoa_PN](@maPN char(10))
as
begin
delete Chitietnhap
where maPN=@maPN
delete PhieuNhap
where maPN = @maPN
end
GO
/****** Object:  StoredProcedure [dbo].[xoa_PX]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[xoa_PX](@maPX char(10))
as
begin
delete Chitietxuat
where maPX=@maPX
delete PhieuXuat
where maPX = @maPX
end
GO
/****** Object:  StoredProcedure [dbo].[xuat_CTN]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xuat_CTN]
as
begin
select maCTN as [Mã CTN],maPN as [Mã PN],maHH as [Mã Hàng Hóa],soLuong as [Số Lượng],donGia as [Đơn giá] from Chitietnhap
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_CTN2]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_CTN2](@maPN char(10))
as
begin

select maCTN as [Mã CTN],maHH as [Mã Hàng Hóa],soLuong as [Số Lượng],donGia as [Đơn giá] from Chitietnhap
where maPN=@maPN
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_CTX]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[xuat_CTX]
as
begin
select maCTX as [Mã CTX],maPX as [Mã PX],maHH as [Mã Hàng Hóa],soLuong as [Số Lượng],donGia as [Đơn giá] from Chitietxuat
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_CTX2]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_CTX2](@maPX char(10))
as
begin

select maCTX as [Mã CTX],maHH as [Mã Hàng Hóa],soLuong as [Số Lượng],donGia as [Đơn giá] from Chitietxuat
where maPX=@maPX
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_HH]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_HH]
as
begin
select maHH as [Mã Hàng Hóa],tenHH as [Tên Hàng Hóa],maNCC as [Mã NCC] from HangHoa
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_hh_tk]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_hh_tk]
as begin
select maHH as[Mã Hàng Hóa],tenHH as [Tên Hàng Hóa],tenNCC as[Tên NCC],soluong as[ Số Lượng] from HangHoa,NCC
where HangHoa.maNCC=NCC.maNCC
end
GO
/****** Object:  StoredProcedure [dbo].[xuat_NCC]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xuat_NCC]
as
begin
select maNCC as[Mã NCC],tenNCC as [Tên NCC],diaChi as [Địa chỉ] from NCC
end
GO
/****** Object:  StoredProcedure [dbo].[xuat_PN]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[xuat_PN]
as
begin
select maPN as [Mã Phiếu Nhập],ngayNhap as [Ngày Nhập],tongTien as [Tổng Tiền]
from PhieuNhap
end

GO
/****** Object:  StoredProcedure [dbo].[xuat_PX]    Script Date: 6/29/2021 12:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[xuat_PX]
as
begin
select maPX as [Mã Phiếu Xuất],ngayXuat as [Ngày Xuất],tongTien as [Tổng Tiền] from PhieuXuat
end

GO
USE [master]
GO
ALTER DATABASE [Quan_Ly_Kho] SET  READ_WRITE 
GO
