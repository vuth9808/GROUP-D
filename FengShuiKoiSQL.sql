USE master
GO

CREATE DATABASE FengShuiKoi
GO

USE FengShuiKoi
GO

CREATE TABLE Nhan_Vien
(
	ma_nhan_vien NVARCHAR(10) PRIMARY KEY,
	ho_ten NVARCHAR(255),
	tuoi INT,
	ngay_thang_nam_sinh DATE,
	gioi_tinh BIT,
	dia_chia NVARCHAR(MAX),
	que_quan NVARCHAR(255),
	so_dien_thoai VARCHAR(15),
	mo_ta NVARCHAR(MAX),
	trang_thai BIT,
	email VARCHAR(100) UNIQUE,
	mat_khau NVARCHAR(255),
	lan_dang_nhap_cuoi DATETIME,
	them_vao_ngay DATETIME DEFAULT CURRENT_TIMESTAMP,
	cap_nhat_vao_ngay DATETIME DEFAULT CURRENT_TIMESTAMP,
	them_boi NVARCHAR(255),
	cap_nhat_boi NVARCHAR(255),
)
GO

CREATE TABLE Khach_Hang
(
	ma_khach_hang INT PRIMARY KEY IDENTITY(1,1),
	ten_khach_hang NVARCHAR(255),
	ngay_thang_nam_sinh DATE,
	tuoi INT,
	email VARCHAR(100) UNIQUE,
	so_dien_thoai VARCHAR(15),
	dia_chi NVARCHAR(255),
	ngay_tao DATETIME DEFAULT CURRENT_TIMESTAMP,
	ngay_chinh_sua DATETIME DEFAULT CURRENT_TIMESTAMP,
)
GO

CREATE TABLE Avertise
(
	ma_khach_hang INT FOREIGN KEY references Khach_hang(ma_khach_hang) on delete cascade on update cascade,
	loai_ca NVARCHAR(255),
	san_pham_trang_tri NVARCHAR(255),
	ban_menh NVARCHAR(255),
	gia_tien int ,
	ngay_tao DATETIME DEFAULT CURRENT_TIMESTAMP,
	ngay_chinh_sua DATETIME DEFAULT CURRENT_TIMESTAMP,

)