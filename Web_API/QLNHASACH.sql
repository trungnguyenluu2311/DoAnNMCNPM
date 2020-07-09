CREATE DATABASE QLNHASACH
go
USE QLNHASACH
go

CREATE TABLE Users
(
	Id varchar(6) PRIMARY KEY,
	Username varchar(20),
	Password varchar(8),
	QuyenHan int
)
go

CREATE TABLE Sach
(
	MaSach varchar(6) PRIMARY KEY,
	TenSach nvarchar(40),
	TheLoai nvarchar(20),
	TacGia nvarchar(40),
	DonGia money,
	SoLuong int
)
go

CREATE TABLE KhachHang
(
	MaKH varchar(6) PRIMARY KEY,
	TenKH nvarchar(40),
	DiaChi nvarchar(60),
	DienThoai varchar(10),
	Email varchar(20),
	TienNo money
)
go

CREATE TABLE PhieuNhapSach
(
	MaPN varchar(6) PRIMARY KEY,
	NgayNhap datetime
)
go

CREATE TABLE CTPNS
(
	MaPN varchar(6),
	MaSach varchar(6),
	SoLuongNhap int,
	DonGiaNhap money

	CONSTRAINT PK_CTPN PRIMARY KEY(MaPN, MaSach)
)
go

CREATE TABLE HoaDon
(
	MaHD varchar(6) PRIMARY KEY,
	NgayLap datetime,
	MaKH varchar(6),
	ThanhTien money
)
go

CREATE TABLE CTHD
(
	MaHD varchar(6),
	MaSach varchar(6),
	SoLuongBan int,
	DonGiaBan money,

	CONSTRAINT PK_CTHD PRIMARY KEY(MaHD, MaSach)
)
go

CREATE TABLE PhieuThuTien
(
	MaPT varchar(6) PRIMARY KEY,
	MaKH varchar(6),
	NgayThuTien datetime,
	TienThu money,
)
go

CREATE TABLE BaoCao
(
	MaBC varchar(6) PRIMARY KEY,
	Thang int,
)
go

CREATE TABLE CTBCNOCONG
(
	MaBC varchar(6),
	MaKH varchar(6),
	NoDau money,
	NoCuoi money,
	PhatSinh money

	CONSTRAINT PK_CTBCTON PRIMARY KEY(MaBC, MaKH)
)
go

CREATE TABLE CTBCTON
(
	MaBC varchar(6),
	MaSach varchar(6),
	TonDau int,
	TonCuoi int,
	PhatSinh int

	CONSTRAINT PK_CTBCNOCONG PRIMARY KEY(MaBC, MaSach)
)
go


--FK CTPNS_SACH, CTPNS_PNS
ALTER TABLE CTPNS
ADD FOREIGN KEY(MaPN) REFERENCES PhieuNhapSach(MaPN)
go

ALTER TABLE CTPNS
ADD FOREIGN KEY(MaSach) REFERENCES Sach(MaSach)
go

--FK CTHD_SAH, CTHD_HD
ALTER TABLE CTHD
ADD FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD)
go

ALTER TABLE CTHD
ADD FOREIGN KEY(MaSach) REFERENCES Sach(MaSach)
go

--FK THUTIEN_KH
ALTER TABLE PhieuThuTien
ADD FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
go

--FK HOADON_KH
ALTER TABLE HoaDon
ADD FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
go

--FK CTBCNOCONG_BC, CTBCNOCONG_KH
ALTER TABLE CTBCNOCONG
ADD FOREIGN KEY(MaBC) REFERENCES BaoCao(MaBC)
go

ALTER TABLE CTBCNOCONG
ADD FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH)
go

--FK CTBCTON_BC, CTBCTON_SACH
ALTER TABLE CTBCTON
ADD FOREIGN KEY(MaBC) REFERENCES BaoCao(MaBC)
go

ALTER TABLE CTBCTON
ADD FOREIGN KEY(MaSach) REFERENCES Sach(MaSach)
go

--
--DATA
--
insert into Users values('US0001','admin0','admin','0')
insert into Users values('US0002','ql_01','quanli','1')
insert into Users values('US0003','nv01','nhanvien','2')
select* from Users
go

insert into Sach values('SA0001','Sample data 1','sample1','dev','1500','1')
insert into Sach values('SA0002','Sample data 2','sample2','dev','1300','10')
insert into Sach values('SA0003','Sample data 3','sample1','dev','1100','69')
insert into Sach values('SA0004','Sample data 4','sample3','dev','1250','20')
select * from Sach
go

insert into KhachHang values('KH0001','Khach hang 1','Tp.HCM','012345678','mail_1@abc.cd','0')
insert into KhachHang values('KH0002','Khach hang 2','Ha Noi','0147852369','mail_2@abc.cd','0')
insert into KhachHang values('KH0003','Khach hang 3','Binh Duong','0369741258','mail_3@abc.cd','0')
insert into KhachHang values('KH0004','Khach hang 4','Da Nang','0149763258','mail_4@abc.cd','0')
select * from KhachHang
go

insert into PhieuNhapSach values('PN0001','1-7-2019')
insert into PhieuNhapSach values('PN0002','1-9-2019')
insert into PhieuNhapSach values('PN0003','1-11-2019')
insert into PhieuNhapSach values('PN0004','1-1-2020')
insert into PhieuNhapSach values('PN0005','1-3-2020')
insert into PhieuNhapSach values('PN0006','1-5-2020')
select * from PhieuNhapSach
go

insert into CTPNS  values('PN0001','SA0001','20','1000')
insert into CTPNS  values('PN0001','SA0003','30','1200')
insert into CTPNS  values('PN0001','SA0004','15','1050')
insert into CTPNS  values('PN0002','SA0002','20','1000')
insert into CTPNS  values('PN0002','SA0004','10','1200')
insert into CTPNS  values('PN0003','SA0001','20','1450')
insert into CTPNS  values('PN0003','SA0002','20','1350')
insert into CTPNS  values('PN0003','SA0003','40','1100')
insert into CTPNS  values('PN0004','SA0001','20','1500')
insert into CTPNS  values('PN0005','SA0002','15','1100')
insert into CTPNS  values('PN0005','SA0003','30','1000')
insert into CTPNS  values('PN0005','SA0004','15','1250')
insert into CTPNS  values('PN0006','SA0002','10','1300')
insert into CTPNS  values('PN0006','SA0003','10','1100')
select * from CTPNS
go

insert into HoaDon values('HD0001','9-2-2019','KH0002','10500')
insert into HoaDon values('HD0002','12-25-2019','KH0001','45000')
insert into HoaDon values('HD0003','2-14-2020','KH0003','6000')
insert into HoaDon values('HD0004','3-8-2020','KH0004','1400')
insert into HoaDon values('HD0005','4-30-2020','KH0001','3100')
select * from HoaDon
go

insert into CTHD values('HD0001','SA0001','5','1100')
insert into CTHD values('HD0001','SA0002','5','1000')
insert into CTHD values('HD0002','SA0001','10','1200')
insert into CTHD values('HD0002','SA0002','10','1000')
insert into CTHD values('HD0002','SA0003','10','1300')
insert into CTHD values('HD0002','SA0004','10','1000')
insert into CTHD values('HD0003','SA0004','4','1500')
insert into CTHD values('HD0004','SA0002','1','1400')
insert into CTHD values('HD0005','SA0002','1','1000')
insert into CTHD values('HD0005','SA0003','1','1100')
insert into CTHD values('HD0005','SA0004','1','1000')
select * from CTHD
go

insert into PhieuThuTien values('PT0001','KH0002','9-2-2019','10500')
insert into PhieuThuTien values('PT0002','KH0001','12-26-2019','45000')
insert into PhieuThuTien values('PT0003','KH0003','2-15-2020','6000')
insert into PhieuThuTien values('PT0004','KH0004','3-8-2020','1400')
insert into PhieuThuTien values('PT0005','KH0001','5-30-2020','3100')
select * from PhieuThuTien
go

-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------
-- Cap nhat lan 1
-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------


-- PROCEDURE

--GetAllUser
create procedure GetAllUser
as
begin
	select* 
	from Users
end
go


--GetAllSach
create procedure GetAllSach
as
begin
	select* from Sach
end
go

--Get sach
create procedure GetSach
@masach varchar(6)
as
begin
	select* from Sach
	where MaSach = @masach
end
go

--Get sach by
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


-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------
-- Cap nhat lan 2
-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------

-- Get all khach hang
create procedure GetAllKhachHang
as
begin
	select * from KhachHang
end
go

--get khach hang
create procedure GetKhachHang
@makh varchar(6)
as
begin
	select * from KhachHang
	where MaKH = @makh
end
go

--get khach hang by
create procedure GetKhachHangBy
@makh varchar(6), @tenkh varchar(40), @diachi varchar(60), @sdt varchar(10), @email varchar(20)
as
begin
	select * from KhachHang
	where MaKH like @makh+'%' and TenKH like @tenkh+'%' and DiaChi like @diachi+'%' and DienThoai like @sdt+'%' and Email like @email+'%'
end
go

--insert khach hang
create procedure InsertKhachHang
@makh varchar(6), @tenkh varchar(40), @diachi varchar(60), @sdt varchar(10), @email varchar(20)
as
begin
	insert into KhachHang(MaKH, TenKH, DiaChi, DienThoai, Email)
	values (@makh, @tenkh, @diachi, @sdt, @email)
end
go

--update khach hang
create procedure UpdateKhachHang
@makh varchar(6), @tenkh varchar(40), @diachi varchar(60), @sdt varchar(10), @email varchar(20)
as
begin
	update KhachHang 
	set TenKH = @tenkh, DiaChi = @diachi, DienThoai = @sdt, Email = @email
	where MaKH = @makh
end
go

--delete khach hang
create procedure DeleteKhachHang
@makh varchar(6)
as
begin
	delete from KhachHang 
	where MaKH = @makh
end
go


-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------
-- Cap nhat lan 3
-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------

--get all phieu thu tien
create procedure GetAllPhieuThuTien
as
begin
	select * from PhieuThuTien
end
go

--get phieu thu 
create procedure GetPhieuThuTien
@mapt varchar(6)
as
begin
	select * from PhieuThuTien
	where MaPT = @mapt
end
go

-- insert phieu thu tien
create procedure InsertPhieuThuTien
@mapt varchar(6), @makh varchar(6), @ngaythu datetime, @tienthu money
as
begin
	insert into PhieuThuTien(MaPT, MaKH, NgayThuTien, TienThu)
	values (@mapt, @makh, @ngaythu, @tienthu)
end
go

-- update pheiu thu tien
create procedure UpdatePhieuThuTien
@mapt varchar(6), @makh varchar(6), @ngaythu datetime, @tienthu money
as
begin
	update PhieuThuTien
	set MaKH = @makh, NgayThuTien = @ngaythu, TienThu = @tienthu
	where MaPT = @mapt
end
go

-- delete pheiu thu tien
create procedure DeletePhieuThuTien
@mapt varchar(6)
as
begin
	delete from PhieuThuTien
	where MaPT = @mapt
end
go


-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------
-- Cap nhat lan 4
-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------

-- get user by username and password
CREATE PROCEDURE GetUserBy
@username varchar(20), @password varchar(8)
AS
BEGIN
	SELECT * FROM Users
	WHERE Username = @username AND Password = @password
END
GO

-- get all user name
CREATE PROCEDURE GetAllUsername
AS
BEGIN
	SELECT Username FROM Users
END
GO

CREATE PROCEDURE GetAllUID
AS
BEGIN
	SELECT Id FROM Users
END
GO

-- insert user
CREATE PROCEDURE InsertUser
@id varchar(6), @username varchar(20), @password varchar(8), @quyenhan int
AS
BEGIN
	INSERT INTO Users(Id, Username, Password, QuyenHan)
	VALUES (@id, @username, @password, @quyenhan)
END
GO

-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------
-- Cap nhat lan 5
-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------

-- get all ma khach hang
CREATE PROCEDURE GetAllMaKhachHang
AS
BEGIN
	SELECT MaKH FROM KhachHang
END
GO

DROP TABLE PhieuThuTien
GO

CREATE TABLE PhieuThuTien
(
	MaPT varchar(6) PRIMARY KEY,
	MaKH varchar(6),
	TenKH nvarchar(40),
	DiaChi nvarchar(60),
	DienThoai varchar(10),
	Email varchar(20),
	NgayThuTien datetime,
	TienThu money,
)
GO

INSERT INTO PhieuThuTien VALUES('PT0001','KH0002','Khach hang 2','TP.HCM','0123456789','abc@zxy.cc','9-2-2019','10500')
INSERT INTO PhieuThuTien VALUES('PT0002','KH0001','Khach hang 1','Ha Noi','0125874963','qwe@uio.cc','12-26-2019','45000')
INSERT INTO PhieuThuTien VALUES('PT0003','Khong','Khach hang 69','Binh Duong','0123456789','zxy@asd.qwe','2-15-2020','6000')
SELECT * FROM PhieuThuTien
GO

-- insert phieu thu tien
alter procedure InsertPhieuThuTien
@mapt varchar(6), @makh varchar(6),@tenkh varchar(40), @diachi varchar(60), @sdt varchar(10), @email varchar(20), @ngaythu datetime, @tienthu money
as
begin
	insert into PhieuThuTien(MaPT, MaKH,TenKH, DiaChi, DienThoai, Email, NgayThuTien, TienThu)
	values (@mapt, @makh, @tenkh, @diachi, @sdt, @email, @ngaythu, @tienthu)
end
go

-- update pheiu thu tien
alter procedure UpdatePhieuThuTien
@mapt varchar(6), @makh varchar(6),@tenkh varchar(40), @diachi varchar(60), @sdt varchar(10), @email varchar(20), @ngaythu datetime, @tienthu money
as
begin
	update PhieuThuTien
	set MaKH = @makh, TenKH = @tenkh, DiaChi = @diachi, DienThoai = @sdt, Email = @email, NgayThuTien = @ngaythu, TienThu = @tienthu
	where MaPT = @mapt
end
go

CREATE PROCEDURE GetAllMaPhieuThu
AS
BEGIN
	SELECT MaPT FROM PhieuThuTien
END
GO

-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------
-- Cap nhat lan 6
-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------

-- get all ma hoa don
CREATE PROCEDURE GetAllMaHoaDon
AS
BEGIN
	SELECT MaHD FROM HoaDon
END
GO

-- insert hoa don
CREATE PROCEDURE InsertHoaDon
@mahd varchar(6), @makh varchar(6), @ngaylap datetime, @thanhtien money
AS
BEGIN
	INSERT INTO HoaDon(MaHD, MaKH, NgayLap, ThanhTien)
	VALUES (@mahd, @makh, @ngaylap, @thanhtien)
END
GO

-- insert cthd
CREATE PROCEDURE InsertCTHD
@mahd varchar(6), @masach varchar(6), @soluong int, @dongia money
AS
BEGIN
	INSERT INTO CTHD(MaHD, MaSach, SoLuongBan, DonGiaBan)
	VALUES (@mahd, @masach, @soluong, @dongia)
END
GO

CREATE PROCEDURE GetAllMaSach
AS
BEGIN
	SELECT MaSach FROM Sach
END
GO

-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------
-- Cap nhat lan 7
-------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------------------------

-- get all ma phieu nhap
CREATE PROCEDURE GetAllMaPhieuNhap
AS
BEGIN
	SELECT MaPN FROM PhieuNhapSach
END
GO

-- insert phieu nhap sach
CREATE PROCEDURE InsertPhieuNhap
@mapn varchar(6), @ngaynhap datetime
AS
BEGIN
	INSERT INTO PhieuNhapSach(MaPN, NgayNhap)
	VALUES (@mapn, @ngaynhap)
END
GO

-- insert CTPN
CREATE PROCEDURE InsertCTPNS
@mapn varchar(6), @masach varchar(6), @soluong int, @dongia money
AS
BEGIN
	INSERT INTO CTPNS(MaPN, MaSach, SoLuongNhap, DonGiaNhap)
	VALUES (@mapn, @masach, @soluong, @dongia)
END
GO

CREATE TABLE ThamSo
(
	MaThamSo varchar(6) PRIMARY KEY,
	TenThamSo varchar(50),
	GiaTri int
)
GO

INSERT INTO ThamSo VALUES('TS0001','So luong nhap toi thieu','150')
INSERT INTO ThamSo VALUES('TS0002','So luong ton toi da','300')
INSERT INTO ThamSo VALUES('TS0003','Tien no toi da','20000')
INSERT INTO ThamSo VALUES('TS0004','Luong ton toi thieu sau khi ban','20')
INSERT INTO ThamSo VALUES('TS0005','Ti le don gia ban','105')
SELECT * FROM ThamSo
GO

CREATE TRIGGER trigger_insert_cthd
ON CTHD
FOR INSERT
AS
BEGIN
	Declare @soluongban int, @masach varchar(6)

	SELECT @soluongban = SoLuongBan, @masach = MaSach FROM inserted

	UPDATE Sach 
	SET Sach.SoLuong = Sach.SoLuong - @soluongban
	WHERE Sach.MaSach = @masach
END
GO

CREATE TRIGGER trigger_insert_ctpns
ON CTPNS
FOR INSERT
AS
BEGIN
	Declare @soluongnhap int, @masach varchar(6)

	SELECT @soluongnhap = SoLuongNhap, @masach = MaSach FROM inserted

	UPDATE Sach 
	SET Sach.SoLuong = Sach.SoLuong + @soluongnhap
	WHERE Sach.MaSach = @masach
END
GO
