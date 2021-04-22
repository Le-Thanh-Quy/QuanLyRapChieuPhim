
create database QuanLyRapChieuPhim

USE QuanLyRapChieuPhim
GO







CREATE TABLE TaiKhoan
(
	UserName NVARCHAR(100) NOT NULL,
	Pass VARCHAR(1000) NOT NULL,
	LoaiTK INT NOT NULL DEFAULT 2, 
)
GO



CREATE TABLE PhongChieu
(
	id VARCHAR(50) PRIMARY KEY,
	TenPhong NVARCHAR(100) NOT NULL,
	SoChoNgoi INT NOT NULL,
	TinhTrang INT NOT NULL DEFAULT 1, -- 0:không hoạt động || 1:đang hoạt động
)
GO

CREATE TABLE Phim
(
	id varchar(50) PRIMARY KEY,
	TenPhim nvarchar(100) NOT NULL,
	MoTa nvarchar(1000) NULL,
	ThoiLuong float NOT NULL,
	SanXuat nvarchar(50) NOT NULL,
	DaoDien nvarchar(100) NULL,
	NamSX int NOT NULL,
	ApPhich image
)
GO




CREATE TABLE TheLoai
(
	id VARCHAR(50) PRIMARY KEY,
	TenTheLoai NVARCHAR(100) NOT NULL,
	MoTa NVARCHAR(100)
)
GO

CREATE TABLE PhanLoaiPhim 
(
	idPhim VARCHAR(50) NOT NULL,
	idTheLoai VARCHAR(50) NOT NULL,

	FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id),
	FOREIGN KEY (idTheLoai) REFERENCES dbo.TheLoai(id),

	CONSTRAINT PK_PhanLoaiPhim PRIMARY KEY(idPhim,idTheLoai)
)
GO
CREATE TABLE CaChieu 
(
	id VARCHAR(50) PRIMARY KEY,
	Tenca varchar(50),
	ThoigianBatDau time,
	ThoiGianKetThuc time
)
CREATE TABLE LichChieu
(
	id VARCHAR(50) PRIMARY KEY,
	idPhim varchar(50),
	idCaChieu VARCHAR(50),
	NgayChieu DATE NOT NULL,
	idPhong VARCHAR(50) NOT NULL,
	TrangThai INT NOT NULL DEFAULT '0', --0: Chưa tạo vé cho lịch chiếu || 1: Đã tạo vé
	FOREIGN KEY (idPhong) REFERENCES dbo.PhongChieu(id),
	FOREIGN KEY (idCaChieu) REFERENCES dbo.CaChieu(id),
	FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id)
)
GO

CREATE TABLE KhachHang
(
	id VARCHAR(50) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	SDT VARCHAR(100),
	DiemTichLuy int
)
GO

create table GheNgoi 
(
	idGheNgoi VARCHAR(50) primary key,
	p1 bit,
	p2 bit,
	p3 bit,
	p4 bit,
	p5 bit,
	p6 bit
)
CREATE TABLE Ve
(
	id int identity(1,1) PRIMARY KEY,
	LoaiVe INT , --0: Vé người lớn || 1: Vé học sinh - sinh viên || 2: vé trẻ em
	idLichChieu VARCHAR(50),
	idGheNgoi VARCHAR(50),
	idKhachHang VARCHAR(50),
	TienBanVe MONEY DEFAULT '0',
	FOREIGN KEY (idLichChieu) REFERENCES dbo.LichChieu(id),
	FOREIGN KEY (idKhachHang) REFERENCES dbo.KhachHang(id),
	FOREIGN KEY (idGheNgoi) REFERENCES dbo.GheNgoi(idGheNgoi)
)

