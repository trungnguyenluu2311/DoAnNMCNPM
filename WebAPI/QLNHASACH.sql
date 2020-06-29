CREATE DATABASE QLNHASACH
USE QLNHASACH

CREATE TABLE Users
(
	Id varchar(6) PRIMARY KEY,
	Username varchar(20),
	Password varchar(8),
	QuyenHan int
)

CREATE TABLE Sach
(
	MaSach varchar(6) PRIMARY KEY,
	TenSach nvarchar(40),
	TheLoai nvarchar(20),
	TacGia nvarchar(40),
	DonGia money,
	SoLuong int
)

CREATE TABLE KhachHang
(
	MaKH varchar(6) PRIMARY KEY,
	TenKH nvarchar(40),
	DiaChi nvarchar(60),
	DienThoai varchar(10),
	Email varchar(20),
	TienNo money
)

CREATE TABLE PhieuNhapSach
(
	MaPN varchar(6) PRIMARY KEY,
	NgayNhap datetime
)

CREATE TABLE CTPNS
(
	MaPN varchar(6),
	MaSach varchar(6),
	SoLuongNhap int,
	DonGiaNhap money

	CONSTRAINT PK_CTPN PRIMARY KEY(MaPN, MaSach)
)

CREATE TABLE HoaDon
(
	MaHD varchar(6) PRIMARY KEY,
	NgayLap datetime,
	MaKH varchar(6),
)

CREATE TABLE CTHD
(
	MaHD varchar(6),
	MaSach varchar(6),
	SoLuongBan int,
	DonGiaBan money,

	CONSTRAINT PK_CTHD PRIMARY KEY(MaHD, MaSach)
)

CREATE TABLE PhieuThuTien
(
	MaPT varchar(6) PRIMARY KEY,
	MaKH varchar(6),
	NgayThuTien datetime,
	TienThu money,
)

CREATE TABLE BaoCao
(
	MaBC varchar(6) PRIMARY KEY,
	Thang int,
)

CREATE TABLE CTBCNOCONG
(
	MaBC varchar(6),
	MaKH varchar(6),
	NoDau money,
	NoCuoi money,
	PhatSinh money

	CONSTRAINT PK_CTBCTON PRIMARY KEY(MaBC, MaKH)
)

CREATE TABLE CTBCTON
(
	MaBC varchar(6),
	MaSach varchar(6),
	TonDau int,
	TonCuoi int,
	PhatSinh int

	CONSTRAINT PK_CTBCNOCONG PRIMARY KEY(MaBC, MaSach)
)


--FK CTPNS_SACH, CTPNS_PNS
ALTER TABLE CTPNS
ADD FOREIGN KEY(MaPN) REFERENCES PhieuNhapSach(MaPN)
ALTER TABLE CTPNS
ADD FOREIGN KEY(MaSach) REFERENCES Sach(MaSach)

--FK CTHD_SAH, CTHD_HD
ALTER TABLE CTHD
ADD FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD)
ALTER TABLE CTHD
ADD FOREIGN KEY(MaSach) REFERENCES Sach(MaSach)

--FK THUTIEN_KH
ALTER TABLE PhieuThuTien
ADD FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)

--FK HOADON_KH
ALTER TABLE HoaDon
ADD FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)

--FK CTBCNOCONG_BC, CTBCNOCONG_KH
ALTER TABLE CTBCNOCONG
ADD FOREIGN KEY(MaBC) REFERENCES BaoCao(MaBC)
ALTER TABLE CTBCNOCONG
ADD FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)

--FK CTBCTON_BC, CTBCTON_SACH
ALTER TABLE CTBCTON
ADD FOREIGN KEY(MaBC) REFERENCES BaoCao(MaBC)
ALTER TABLE CTBCTON
ADD FOREIGN KEY(MaSach) REFERENCES Sach(MaSach)

--InsertData
insert into Users values('US0001','admin0','admin','0')
insert into Users values('US0002','ql_01','quanli','1')
insert into Users values('US0003','nv01','nhanvien','2')

insert into Sach values('SA0001','Sample data 1','sample1','dev','1000','1')
insert into Sach values('SA0002','Sample data 2','sample2','dev','1000','10')
insert into Sach values('SA0003','Sample data 3','sample1','dev','1000','69')
insert into Sach values('SA0004','Sample data 4','sample3','dev','1000','20')



-- PROCEDURE

--GetAllUser
create procedure GetAllUser
as
begin
	select* 
	from Users
end
go


-- InsertUser
create procedure InsertUser
@userid varchar(6), @username varchar(20), @password varchar(6), @quyenhan varchar(6)
as
begin
	insert into Users(Id,Username,Password,QuyennHan) 
	values (@userid, @username, @password, @quyenhan)
end
go

--DeleteUser
create procedure DeleteUser
@userid varchar(6)
as
begin
	delete from Users
	where Id = @userid
end
go


--UpdateUser
create procedure UpdateUser
@userid varchar(6), @password varchar(6), @quyenhan varchar(6)
as
begin
	update Users 
	set Password = @password, QuyenHan = @quyenhan
	where Id = @userid
end
go


--GetAllSach
create procedure GetAllSach
as
begin
	select* from Sach
end
go

create procedure GetSach
@masach varchar(6)
as
begin
	select* from Sach
	where MaSach = @masach
end
go

create procedure GetSachBy
@masach varchar(6)='', @tensach nvarchar(40)='', @theloai nvarchar(20)='', @tacgia nvarchar(40)=''
as
begin
	select * from Sach
	where MaSach like @masach+'%' and TenSach like @tensach+'%' and TheLoai like @theloai+'%' and TacGia like @tacgia+'%'
end
go

-- InsertSach
create procedure InsertSach
@masach varchar(6), @tensach nvarchar(40), @theloai nvarchar(20), @tacgia nvarchar(40), @dongia money, @soluong int
as
begin
	insert into Sach(MaSach,TenSach,TheLoai,TacGia,DonGia,SoLuong)
	values(@masach,@tensach,@theloai,@tacgia,@dongia,@soluong)
end
go


-- DeleteSach
create procedure DeleteSach
@masach varchar(6)
as
begin
	delete Sach
	where MaSach = @masach
end
go


-- UpdateSACH
create procedure UpdateSach
@masach varchar(6), @tensach nvarchar(40), @theloai nvarchar(20), @tacgia nvarchar(40), @dongia money
as
begin
	update Sach
	set TenSach = @tensach, TacGia = @tacgia, TheLoai = @theloai, DonGia = @dongia
	where MaSach = @masach
end
go