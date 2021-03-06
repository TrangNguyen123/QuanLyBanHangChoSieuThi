USE [QuanLyBHST]
GO
/****** Object:  StoredProcedure [dbo].[Loatcthoadonban]    Script Date: 5/9/2017 1:33:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Loatcthoadonban]
as
begin
select CHITIETHOADONBAN.mahoadon, HANGHOA.tenhanghoa, CHITIETHOADONBAN.soluong,HANGHOA.dongiaban
,CHITIETHOADONBAN.giamgia, CHITIETHOADONBAN.thanhtien 
from CHITIETHOADONBAN  inner join HANGHOA
on CHITIETHOADONBAN.mavach=HANGHOA.mavach
end
  
GO
/****** Object:  StoredProcedure [dbo].[loatcthoadonnhap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loatcthoadonnhap]
as
begin
select CHITIETHOADONNHAP.mahoadon, HANGHOA.tenhanghoa, CHITIETHOADONNHAP.soluong,HANGHOA.dongianhap
,CHITIETHOADONNHAP.giamgia, CHITIETHOADONNHAP.thanhtien 
from CHITIETHOADONNHAP  left join HANGHOA
on CHITIETHOADONNHAP.mavach=HANGHOA.mavach
end
GO
/****** Object:  StoredProcedure [dbo].[Loathanghoa]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Loathanghoa]
as
begin
SELECT HANGHOA.mavach, HANGHOA.tenhanghoa,HANGHOA.soluong, HANGHOA.dongiaban, HANGHOA.dongianhap
      ,[NHACUNGCAP].[tennhacungcap]
  FROM [dbo].[HANGHOA] inner join NHACUNGCAP on NHACUNGCAP.manhacungcap=HANGHOA.manhacungcap
  end
  
GO
/****** Object:  StoredProcedure [dbo].[loathoadonban]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loathoadonban]
as
begin
select
HOADONBAN.sohoadonban, HOADONBAN.mahoadon, HANGHOA.tenhanghoa, CHITIETHOADONBAN.soluong, CHITIETHOADONBAN.dongiaban, CHITIETHOADONBAN.giamgia,
CHITIETHOADONBAN.thanhtien, HOADONBAN.tongtien,HOADONBAN.ngayban, KHACHHANG.tenkhachhang, NHANVIEN.tennhanvien
from (((HOADONBAN inner join CHITIETHOADONBAN on HOADONBAN.mahoadon=CHITIETHOADONBAN.mahoadon) 
left join HANGHOA on HANGHOA.mavach=CHITIETHOADONBAN.mavach) 
left join KHACHHANG on KHACHHANG.makhachhang=HOADONBAN.makhachhang) 
left join NHANVIEN on NHANVIEN.manhanvien=HOADONBAN.manhanvien
end
  
GO
/****** Object:  StoredProcedure [dbo].[loathoadonnhap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loathoadonnhap]
as
begin
select
HOADONNHAP.sohoadonnhap, HOADONNHAP.mahoadon, HANGHOA.tenhanghoa, CHITIETHOADONNHAP.soluong, 
CHITIETHOADONNHAP.dongianhap, CHITIETHOADONNHAP.giamgia,
CHITIETHOADONNHAP.thanhtien, HOADONNHAP.tongtienhoadonnhap,HOADONNHAP.ngaynhap, 
NHACUNGCAP.tennhacungcap, NHANVIEN.tennhanvien
from (((HOADONNHAP inner join CHITIETHOADONNHAP on HOADONNHAP.mahoadon=CHITIETHOADONNHAP.mahoadon) 
inner join HANGHOA on HANGHOA.mavach=CHITIETHOADONNHAP.mavach) 
inner join NHACUNGCAP on NHACUNGCAP.manhacungcap=HOADONNHAP.manhacungcap) 
inner join NHANVIEN on NHANVIEN.manhanvien=HOADONNHAP.manhanvien
end
  
GO
/****** Object:  StoredProcedure [dbo].[Loatkhachhang]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Loatkhachhang]
as
begin
select * from KHACHHANG 
end
GO
/****** Object:  StoredProcedure [dbo].[Loatnhacungcap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Loatnhacungcap]
as
begin
select * from NHACUNGCAP
end
GO
/****** Object:  StoredProcedure [dbo].[Loatnhanvien]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Loatnhanvien]
as
begin
select *from NHANVIEN
end
GO
/****** Object:  StoredProcedure [dbo].[suacthoadonban]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suacthoadonban]
(@mahoadon nchar(10),
@mavach nchar(10),
@soluong int,
@dongiaban float,
@giamgia float,
@thanhtien float
)
as
begin
update CHITIETHOADONBAN
set
mahoadon=@mahoadon,
mavach=@mavach,
soluong=@soluong,
dongiaban=@dongiaban,
giamgia=@giamgia,
thanhtien=@thanhtien
where mahoadon=@mahoadon 
end
GO
/****** Object:  StoredProcedure [dbo].[suacthoadonnhap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suacthoadonnhap]
(@mahoadon nchar(10),
@mavach nchar(10),
@soluong int,
@dongianhap float,
@giamgia float,
@thanhtien float
)
as
begin
update CHITIETHOADONNHAP
set
mahoadon=@mahoadon,
mavach=@mavach,
soluong=@soluong,
dongianhap=@dongianhap,
giamgia=@giamgia,
thanhtien=@thanhtien
where mahoadon=@mahoadon 
end
GO
/****** Object:  StoredProcedure [dbo].[suahanghoa]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suahanghoa](
@mavach nchar(10),
@tenhanghoa nvarchar(30),
@soluong int,
@dongiaban float,
@dongianhap float,
@manhacungcap nchar(10))
as
begin 
update HANGHOA
set 
tenhanghoa=@tenhanghoa,
soluong=@soluong,
dongiaban=@dongiaban,
dongianhap=@dongianhap,
manhacungcap=@manhacungcap

where mavach=@mavach
end
GO
/****** Object:  StoredProcedure [dbo].[suahoadonban]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suahoadonban]
(@mahoadon nchar(10),
@manhanvien nchar(10),
@makhachhang nchar(10),
@tongtien float,
@ngayban date,
@sohoadonban int)
as
begin
update HOADONBAN
set
manhanvien=@manhanvien,
makhachhang=@makhachhang,
tongtien=@tongtien,
ngayban=@ngayban,
sohoadonban=@sohoadonban
where mahoadon=@mahoadon 
end

GO
/****** Object:  StoredProcedure [dbo].[suahoadonnhap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suahoadonnhap]
(@mahoadon nchar(10),
@manhanvien nchar(10),
@manhacungcap nchar(10),
@tongtien float,
@ngaynhap date,
@sohoadonnhap int)
as
begin
update HOADONNHAP
set
manhanvien=@manhanvien,
manhacungcap=@manhacungcap,
tongtienhoadonnhap=@tongtien,
ngaynhap=@ngaynhap,
sohoadonnhap=@sohoadonnhap
where mahoadon=@mahoadon 
end
GO
/****** Object:  StoredProcedure [dbo].[suakhachhang]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suakhachhang](
@makhachhang nchar(10),
@tenkhachhang nvarchar(20),
@diachi nvarchar(30),
@sodienthoai nchar(12))
as
begin
update KHACHHANG
set
tenkhachhang=@tenkhachhang,
diachi=@diachi,
sodienthoai=@sodienthoai
where @makhachhang=makhachhang
end
GO
/****** Object:  StoredProcedure [dbo].[suanhacungcap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suanhacungcap](
@manhacungcap nchar(10),
@tennhacungcap nvarchar(20),
@diachi nvarchar(30),
@sodienthoai nchar(12))
as
begin
update NHACUNGCAP
set
tennhacungcap=@tennhacungcap,
diachi=@diachi,
sodienthoai=@sodienthoai
 where manhacungcap=@manhacungcap
end
GO
/****** Object:  StoredProcedure [dbo].[suanhanvien]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suanhanvien](
@manhanvien nchar(10),
@tennhanvien nvarchar(30),
@gioitinh nchar(10),
@ngaysinh date,
@chucvu nvarchar(20),
@diachi nvarchar(20),
@sodienthoai nchar(12))
as
begin
update NHANVIEN
set
tennhanvien=@tennhanvien,
gioitinh=@gioitinh,
ngaysinh=@ngaysinh,
chucvu=@chucvu,
diachi=@diachi,
sodienthoai=@sodienthoai
 where manhanvien=@manhanvien 
end
GO
/****** Object:  StoredProcedure [dbo].[themcthoadonban]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[themcthoadonban]
(@mahoadon nchar(10),
@mavach nchar(10),
@soluong int,
@dongiaban float,
@giamgia float,
@thanhtien float
)
as
begin 
insert into CHITIETHOADONBAN(mahoadon,mavach,soluong,dongiaban,giamgia,thanhtien)
values (@mahoadon,@mavach,@soluong,@dongiaban,@giamgia,@thanhtien)
end
GO
/****** Object:  StoredProcedure [dbo].[themcthoadonnhap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themcthoadonnhap]
(@mahoadon nchar(10),
@mavach nchar(10),
@soluong int,
@dongianhap float,
@giamgia float,
@thanhtien float
)
as
begin 
insert into CHITIETHOADONNHAP(mahoadon,mavach,soluong,dongianhap,giamgia,thanhtien)
values (@mahoadon,@mavach,@soluong,@dongianhap,@giamgia,@thanhtien)
end
GO
/****** Object:  StoredProcedure [dbo].[themhanghoa]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themhanghoa](
@mavach nchar(10),
@tenhanghoa nvarchar(30),
@soluong int,
@dongiaban float,
@dongianhap float,
@manhacungcap nchar(10))
as
begin 
insert into HANGHOA(mavach,tenhanghoa, soluong, dongiaban, dongianhap, manhacungcap)
values (@mavach, @tenhanghoa,@soluong,@dongiaban,@dongianhap,@manhacungcap)
end

GO
/****** Object:  StoredProcedure [dbo].[themhoadonban]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themhoadonban]
(@mahoadon nchar(10),
@manhanvien nchar(10),
@makhachhang nchar(10),
@tongtien float,
@ngayban date,
@sohoadonban int)
as
begin 
insert into HOADONBAN(mahoadon,manhanvien,makhachhang,tongtien,ngayban,sohoadonban)
values (@mahoadon,@manhanvien,@makhachhang,@tongtien, @ngayban, @sohoadonban)
end

GO
/****** Object:  StoredProcedure [dbo].[themhoadonnhap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themhoadonnhap]
(@mahoadon nchar(10),
@manhanvien nchar(10),
@manhacungcap nchar(10),
@tongtien float,
@ngaynhap date,
@sohoadonnhap int)
as
begin 
insert into HOADONNHAP(mahoadon,manhanvien,manhacungcap,tongtienhoadonnhap,ngaynhap,sohoadonnhap)
values (@mahoadon,@manhanvien,@manhacungcap,@tongtien, @ngaynhap, @sohoadonnhap)
end

GO
/****** Object:  StoredProcedure [dbo].[themkhachhang]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themkhachhang](
@makhachhang nchar(10),
@tenkhachhang nvarchar(20),
@diachi nvarchar(30),
@sodienthoai nchar(12))
as
begin
insert into KHACHHANG(makhachhang, tenkhachhang, diachi, sodienthoai)
values (@makhachhang, @tenkhachhang, @diachi, @sodienthoai)
end
GO
/****** Object:  StoredProcedure [dbo].[themnhacungcap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themnhacungcap](
@manhacungcap nchar(10),
@tennhacungcap nvarchar(20),
@diachi nvarchar(30),
@sodienthoai nchar(12))
as
begin
insert into NHACUNGCAP(manhacungcap, tennhacungcap, diachi, sodienthoai)
values (@manhacungcap, @tennhacungcap, @diachi, @sodienthoai)
end
GO
/****** Object:  StoredProcedure [dbo].[themnhanvien]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themnhanvien](
@manhanvien nchar(10),
@tennhanvien nvarchar(30),
@gioitinh nchar(10),
@ngaysinh date,
@chucvu nvarchar(20),
@diachi nvarchar(20),
@sodienthoai nchar(12))
as
begin 
insert into NHANVIEN(manhanvien,tennhanvien,gioitinh,ngaysinh,chucvu,diachi,sodienthoai)
values (@manhanvien, @tennhanvien,@gioitinh,@ngaysinh,@chucvu,@diachi,@sodienthoai)
end

GO
/****** Object:  StoredProcedure [dbo].[timhanghoa]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[timhanghoa](
@tenhanghoa nvarchar(20)
)
as
begin 
select *from HANGHOA where tenhanghoa= @tenhanghoa -- @mavach
end

GO
/****** Object:  StoredProcedure [dbo].[xoacthoadonban]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[xoacthoadonban]
(@mahoadon nchar(10))
as
begin
delete cthdb 
from CHITIETHOADONBAN  cthdb 
where cthdb.mahoadon=@mahoadon 
end
GO
/****** Object:  StoredProcedure [dbo].[xoacthoadonnhap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xoacthoadonnhap]
(@mahoadon nchar(10))
as
begin
delete cthdn 
from CHITIETHOADONNHAP  cthdn 
where cthdn.mahoadon=@mahoadon 
end
GO
/****** Object:  StoredProcedure [dbo].[xoahanghoa]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xoahanghoa](
@mavach nchar(10)
)
as
begin 
delete h
 from HANGHOA h 
 where @mavach=h.mavach
end

GO
/****** Object:  StoredProcedure [dbo].[xoahoadonban]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xoahoadonban]
(@mahoadon nchar(10))
as
begin
delete hdb 
from HOADONBAN  hdb
where hdb.mahoadon=@mahoadon
end

GO
/****** Object:  StoredProcedure [dbo].[xoahoadonnhap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xoahoadonnhap]
(@mahoadon nchar(10))
as
begin
delete hdb 
from HOADONNHAP  hdb
where hdb.mahoadon=@mahoadon
end
GO
/****** Object:  StoredProcedure [dbo].[xoakhachhang]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoakhachhang](
@makhachhang nchar(10))
as
begin
delete from KHACHHANG where @makhachhang=makhachhang
end
GO
/****** Object:  StoredProcedure [dbo].[xoanhacungcap]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoanhacungcap](
@manhacungcap nchar(10))
as
begin
delete from NHACUNGCAP where @manhacungcap=manhacungcap
end
GO
/****** Object:  StoredProcedure [dbo].[xoanhanvien]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoanhanvien](
@manhanvien nchar(10))
as
begin
delete from NHANVIEN where manhanvien=@manhanvien
end
GO
/****** Object:  Table [dbo].[chitietdonhang]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chitietdonhang](
	[machitietdonhang] [varchar](10) NOT NULL,
	[masach] [varchar](10) NULL,
	[madonhang] [varchar](10) NULL,
	[soluong] [int] NULL,
	[dongia] [int] NULL,
 CONSTRAINT [PK_chitietdonhang] PRIMARY KEY CLUSTERED 
(
	[machitietdonhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETHOADONBAN]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADONBAN](
	[mahoadon] [nchar](10) NOT NULL,
	[mavach] [nchar](10) NOT NULL,
	[soluong] [int] NULL,
	[giamgia] [float] NULL,
	[thanhtien] [float] NULL,
	[dongiaban] [float] NULL,
 CONSTRAINT [PK_CHITIETHOADONBAN] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[mavach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHOADONNHAP]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADONNHAP](
	[mahoadon] [nchar](10) NOT NULL,
	[mavach] [nchar](10) NOT NULL,
	[soluong] [int] NULL,
	[dongianhap] [float] NULL,
	[giamgia] [float] NULL,
	[thanhtien] [float] NULL,
 CONSTRAINT [PK_CHITIETHOADONNHAP] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC,
	[mavach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chudesach]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chudesach](
	[machudesach] [varchar](10) NOT NULL,
	[tenchudesach] [nvarchar](50) NULL,
 CONSTRAINT [PK_chudesach] PRIMARY KEY CLUSTERED 
(
	[machudesach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[donhang]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[donhang](
	[madonhang] [varchar](10) NOT NULL,
	[ngaygiaohang] [datetime] NULL,
	[ngaydathang] [datetime] NULL,
	[tennguoinhan] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[makhachhang] [varchar](10) NULL,
 CONSTRAINT [PK_donhang] PRIMARY KEY CLUSTERED 
(
	[madonhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[mavach] [nchar](10) NOT NULL,
	[tenhanghoa] [nvarchar](20) NULL,
	[soluong] [int] NULL,
	[dongianhap] [float] NULL,
	[dongiaban] [float] NULL,
	[manhacungcap] [nchar](10) NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[mavach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONBAN]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONBAN](
	[mahoadon] [nchar](10) NOT NULL,
	[manhanvien] [nchar](10) NULL,
	[makhachhang] [nchar](10) NULL,
	[tongtien] [float] NULL,
	[ngayban] [date] NULL,
	[sohoadonban] [int] NULL,
 CONSTRAINT [PK_HOADONBAN] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADONNHAP]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONNHAP](
	[mahoadon] [nchar](10) NOT NULL,
	[manhanvien] [nchar](10) NULL,
	[ngaynhap] [date] NULL,
	[manhacungcap] [nchar](10) NULL,
	[tongtienhoadonnhap] [float] NULL,
	[sohoadonnhap] [int] NULL,
 CONSTRAINT [PK_HOADONNHAP] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[makhachhang] [nchar](10) NOT NULL,
	[tenkhachhang] [nvarchar](30) NULL,
	[diachi] [nvarchar](20) NULL,
	[sodienthoai] [nchar](12) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nguoidung]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nguoidung](
	[username] [nvarchar](50) NULL,
	[password] [varchar](50) NULL,
	[hoten] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[manhacungcap] [nchar](10) NOT NULL,
	[tennhacungcap] [nvarchar](20) NULL,
	[diachi] [nvarchar](30) NULL,
	[sodienthoai] [nchar](12) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[manhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[manhanvien] [nchar](10) NOT NULL,
	[tennhanvien] [nvarchar](30) NULL,
	[gioitinh] [nchar](10) NULL,
	[ngaysinh] [date] NULL,
	[chucvu] [nchar](10) NULL,
	[sodienthoai] [nchar](12) NULL,
	[diachi] [nvarchar](20) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhaxuatban]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhaxuatban](
	[manhaxuatban] [varchar](10) NOT NULL,
	[tennhaxuatban] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[tieusu] [nvarchar](200) NULL,
 CONSTRAINT [PK_nhaxuatban] PRIMARY KEY CLUSTERED 
(
	[manhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[role]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[role](
	[idrole] [varchar](10) NOT NULL,
	[rolename] [nvarchar](100) NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[idrole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sach]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sach](
	[masach] [varchar](10) NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[giaban] [money] NULL,
	[mota] [nvarchar](100) NULL,
	[anhbia] [nvarchar](100) NULL,
	[namxuatban] [datetime] NULL,
	[tinhtrang] [bit] NULL,
	[kichco] [varchar](50) NULL,
	[sotrang] [int] NULL,
	[soluong] [int] NULL,
	[manhaxuatban] [varchar](10) NULL,
	[machudesach] [varchar](10) NULL,
	[matacgia] [varchar](10) NULL,
 CONSTRAINT [PK_sach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tacgia]    Script Date: 5/9/2017 1:33:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tacgia](
	[matacgia] [varchar](10) NOT NULL,
	[tentacgia] [nvarchar](50) NULL,
	[diachi] [nvarchar](100) NULL,
	[tieusu] [nvarchar](200) NULL,
	[sodienthoai] [varchar](50) NULL,
 CONSTRAINT [PK_tacgia] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHITIETHOADONBAN] ([mahoadon], [mavach], [soluong], [giamgia], [thanhtien], [dongiaban]) VALUES (N'HDB001    ', N'MV001     ', 10, 0.9, 270000, 30000)
INSERT [dbo].[CHITIETHOADONBAN] ([mahoadon], [mavach], [soluong], [giamgia], [thanhtien], [dongiaban]) VALUES (N'HDB002    ', N'MV002     ', 10, 0.800000011920929, 1200000, 150000)
INSERT [dbo].[CHITIETHOADONBAN] ([mahoadon], [mavach], [soluong], [giamgia], [thanhtien], [dongiaban]) VALUES (N'HDB003    ', N'MV003     ', 1, 0.8, 40000, 50000)
INSERT [dbo].[CHITIETHOADONNHAP] ([mahoadon], [mavach], [soluong], [dongianhap], [giamgia], [thanhtien]) VALUES (N'HDN001    ', N'MV001     ', 100, 3000, 0.1, 270000)
INSERT [dbo].[CHITIETHOADONNHAP] ([mahoadon], [mavach], [soluong], [dongianhap], [giamgia], [thanhtien]) VALUES (N'HDN002    ', N'MV002     ', 100, 15000, 0.1, 1350000)
INSERT [dbo].[HANGHOA] ([mavach], [tenhanghoa], [soluong], [dongianhap], [dongiaban], [manhacungcap]) VALUES (N'MV001     ', N'HH001', 1000, 3000, 30000, N'NCC001    ')
INSERT [dbo].[HANGHOA] ([mavach], [tenhanghoa], [soluong], [dongianhap], [dongiaban], [manhacungcap]) VALUES (N'MV002     ', N'HH002', 200, 15000, 150000, N'NCC002    ')
INSERT [dbo].[HANGHOA] ([mavach], [tenhanghoa], [soluong], [dongianhap], [dongiaban], [manhacungcap]) VALUES (N'MV003     ', N'HH003', 14, 5000, 50000, N'NCC001    ')
INSERT [dbo].[HOADONBAN] ([mahoadon], [manhanvien], [makhachhang], [tongtien], [ngayban], [sohoadonban]) VALUES (N'HDB001    ', N'NV001     ', N'KH001     ', 20000, CAST(0x6A3C0B00 AS Date), 1)
INSERT [dbo].[HOADONBAN] ([mahoadon], [manhanvien], [makhachhang], [tongtien], [ngayban], [sohoadonban]) VALUES (N'HDB002    ', N'NV001     ', N'KH002     ', 100000, CAST(0x693C0B00 AS Date), 2)
INSERT [dbo].[HOADONBAN] ([mahoadon], [manhanvien], [makhachhang], [tongtien], [ngayban], [sohoadonban]) VALUES (N'HDB003    ', N'NV002     ', N'KH001     ', 100000, CAST(0x493C0B00 AS Date), 3)
INSERT [dbo].[HOADONNHAP] ([mahoadon], [manhanvien], [ngaynhap], [manhacungcap], [tongtienhoadonnhap], [sohoadonnhap]) VALUES (N'HDN001    ', N'NV001     ', CAST(0x5F3B0B00 AS Date), N'NCC001    ', 1000000, 1)
INSERT [dbo].[HOADONNHAP] ([mahoadon], [manhanvien], [ngaynhap], [manhacungcap], [tongtienhoadonnhap], [sohoadonnhap]) VALUES (N'HDN002    ', N'NV002     ', CAST(0x733B0B00 AS Date), N'NCC002    ', 2000000, 2)
INSERT [dbo].[KHACHHANG] ([makhachhang], [tenkhachhang], [diachi], [sodienthoai]) VALUES (N'KH001     ', N'Nguyễn Hoàng Lan', N'Hà Nội', N'(016) 845-72')
INSERT [dbo].[KHACHHANG] ([makhachhang], [tenkhachhang], [diachi], [sodienthoai]) VALUES (N'KH002     ', N'Lê Nhật Minh', N'Hà Nội', N'01689544256 ')
INSERT [dbo].[KHACHHANG] ([makhachhang], [tenkhachhang], [diachi], [sodienthoai]) VALUES (N'KH003     ', N'Mai Hồng loan', N'Hà tây hà nội', N'(012) 666-56')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sodienthoai]) VALUES (N'NCC001    ', N'CTTNHH Hoàng Long', N'Long Biên-Hà Nôi', N'(044) 422-51')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sodienthoai]) VALUES (N'NCC002    ', N'CTTNHH Hồng Hà', N'Gia Lâm-Hà Nội', N'03334444333 ')
INSERT [dbo].[NHACUNGCAP] ([manhacungcap], [tennhacungcap], [diachi], [sodienthoai]) VALUES (N'NCC003    ', N'CT LAN HƯƠNG', N'Sơn Tây - Hà Nội', N'(012) 423-66')
INSERT [dbo].[NHANVIEN] ([manhanvien], [tennhanvien], [gioitinh], [ngaysinh], [chucvu], [sodienthoai], [diachi]) VALUES (N'NV001     ', N'Nguyễn Hồng', N'Nữ        ', CAST(0x0A1F0B00 AS Date), N'Nhân Viên ', N'(098) 457-63', N'Hà Nội')
INSERT [dbo].[NHANVIEN] ([manhanvien], [tennhanvien], [gioitinh], [ngaysinh], [chucvu], [sodienthoai], [diachi]) VALUES (N'NV002     ', N'Trần Minh Hoàng', N'nam       ', CAST(0x9D180B00 AS Date), N'Nhân Viên ', N'0964582565  ', N'Hà Nội')
ALTER TABLE [dbo].[chitietdonhang]  WITH CHECK ADD  CONSTRAINT [FK_chitietdonhang_sach] FOREIGN KEY([masach])
REFERENCES [dbo].[sach] ([masach])
GO
ALTER TABLE [dbo].[chitietdonhang] CHECK CONSTRAINT [FK_chitietdonhang_sach]
GO
ALTER TABLE [dbo].[CHITIETHOADONBAN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADONBAN_HANGHOA] FOREIGN KEY([mavach])
REFERENCES [dbo].[HANGHOA] ([mavach])
GO
ALTER TABLE [dbo].[CHITIETHOADONBAN] CHECK CONSTRAINT [FK_CHITIETHOADONBAN_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETHOADONBAN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADONBAN_HOADONBAN] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[HOADONBAN] ([mahoadon])
GO
ALTER TABLE [dbo].[CHITIETHOADONBAN] CHECK CONSTRAINT [FK_CHITIETHOADONBAN_HOADONBAN]
GO
ALTER TABLE [dbo].[CHITIETHOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADONNHAP_HANGHOA] FOREIGN KEY([mavach])
REFERENCES [dbo].[HANGHOA] ([mavach])
GO
ALTER TABLE [dbo].[CHITIETHOADONNHAP] CHECK CONSTRAINT [FK_CHITIETHOADONNHAP_HANGHOA]
GO
ALTER TABLE [dbo].[CHITIETHOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADONNHAP_HOADONNHAP] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[HOADONNHAP] ([mahoadon])
GO
ALTER TABLE [dbo].[CHITIETHOADONNHAP] CHECK CONSTRAINT [FK_CHITIETHOADONNHAP_HOADONNHAP]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_NHACUNGCAP] FOREIGN KEY([manhacungcap])
REFERENCES [dbo].[NHACUNGCAP] ([manhacungcap])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_NHACUNGCAP]
GO
ALTER TABLE [dbo].[HOADONBAN]  WITH CHECK ADD  CONSTRAINT [FK_HOADONBAN_KHACHHANG] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[KHACHHANG] ([makhachhang])
GO
ALTER TABLE [dbo].[HOADONBAN] CHECK CONSTRAINT [FK_HOADONBAN_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADONBAN]  WITH CHECK ADD  CONSTRAINT [FK_HOADONBAN_NHANVIEN] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[NHANVIEN] ([manhanvien])
GO
ALTER TABLE [dbo].[HOADONBAN] CHECK CONSTRAINT [FK_HOADONBAN_NHANVIEN]
GO
ALTER TABLE [dbo].[HOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNHAP_NHACUNGCAP] FOREIGN KEY([manhacungcap])
REFERENCES [dbo].[NHACUNGCAP] ([manhacungcap])
GO
ALTER TABLE [dbo].[HOADONNHAP] CHECK CONSTRAINT [FK_HOADONNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[HOADONNHAP]  WITH CHECK ADD  CONSTRAINT [FK_HOADONNHAP_NHANVIEN] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[NHANVIEN] ([manhanvien])
GO
ALTER TABLE [dbo].[HOADONNHAP] CHECK CONSTRAINT [FK_HOADONNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_chudesach] FOREIGN KEY([machudesach])
REFERENCES [dbo].[chudesach] ([machudesach])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_chudesach]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_nhaxuatban] FOREIGN KEY([manhaxuatban])
REFERENCES [dbo].[nhaxuatban] ([manhaxuatban])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_nhaxuatban]
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD  CONSTRAINT [FK_sach_tacgia] FOREIGN KEY([matacgia])
REFERENCES [dbo].[tacgia] ([matacgia])
GO
ALTER TABLE [dbo].[sach] CHECK CONSTRAINT [FK_sach_tacgia]
GO
