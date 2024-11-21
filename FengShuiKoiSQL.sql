USE master
GO

CREATE DATABASE FengShuiKoi
GO

USE FengShuiKoi
GO

CREATE TABLE Nhan_Vien
(
	ma_nhan_vien NVARCHAR(10) PRIMARY KEY,
	ho_ten NVARCHAR(255) NOT NULL,
	ngay_thang_nam_sinh DATE NOT NULL,
	tuoi int NOT NULL,
	gioi_tinh char(15) NOT NULL,
	so_dien_thoai VARCHAR(15) NOT NULL,
	email VARCHAR(100) UNIQUE ,
	mat_khau NVARCHAR(255) NOT NULL,
	ngay_them DATETIME DEFAULT CURRENT_TIMESTAMP,
	ngay_chinh_sua DATETIME DEFAULT CURRENT_TIMESTAMP,
)
GO
INSERT INTO Nhan_Vien (ma_nhan_vien, ho_ten, ngay_thang_nam_sinh, tuoi, gioi_tinh, so_dien_thoai, email, mat_khau)
VALUES 
('NV001', 'Nguyen Van A', '1990-01-01', 34, 1, '0123456789', 'nguyenvana@example.com', 'password1'),
('NV002', 'Tran Thi B', '1992-02-15', 32, 0, '0987654321', 'tranthib@example.com', 'password2'),
('NV003', 'Le Van C', '1985-05-23', 39, 1, '0912345678', 'levanc@example.com', 'password3'),
('NV004', 'Pham Thi D', '1995-09-30', 29, 0, '0934567890', 'phamthid@example.com', 'password4'),
('NV005', 'Hoang Van E', '1988-12-12', 36, 1, '0945678901', 'hoangvane@example.com', 'password5');
go 

CREATE TABLE Khach_Hang
(
	ma_khach_hang INT PRIMARY KEY IDENTITY(1,1),
	ten_khach_hang NVARCHAR(255) NOT NULL,
	ngay_thang_nam_sinh DATE NOT NULL,
	tuoi INT NOT NULL,
	email VARCHAR(100) UNIQUE NOT NULL,
	mat_khau varchar(100) unique NOT NULL,
	so_dien_thoai VARCHAR(15) NOT NULL,
	gioi_tinh bit NOT NULL,
	ngay_tao DATETIME DEFAULT CURRENT_TIMESTAMP,
	ngay_chinh_sua DATETIME DEFAULT CURRENT_TIMESTAMP,
)
GO

CREATE TABLE KoiFish 
(
	ma_ca_koi int primary key,
	so_luong int not null,
	giong_ca Varchar(255) UNIQUE not null,
	mo_ta Nvarchar(255) UNIQUE not null,
	thich_hop Nvarchar(255) UNIQUE not null,
)
go

INSERT INTO KoiFish (ma_ca_koi, so_luong, giong_ca, mo_ta, thich_hop)
VALUES
(1, 10, 'Kohaku', N'Màu trắng và đỏ', N'Thích hợp trong ao nhiệt độ ôn hòa'),
(2, 15, 'Taisho Sanke', N'Màu trắng, đỏ và đen', N'Thích hợp trong ao lớn với nước sạch'),
(3, 8, 'Showa Sanshoku', N'Màu đen, đỏ và trắng', N'Thích hợp trong môi trường nước lạnh'),
(4, 20, 'Asagi', N'Màu xanh dương và đỏ', N'Thích hợp trong ao đáy cát mịn'),
(5, 5, 'Shusui', N'Màu xanh dương sáng', N'Thích hợp trong nước tĩnh, ít dòng chảy');
go

create table Ho_ca
(
	ma_ho_ca  int primary key,
	hinh_dang nvarchar(100) UNIQUE not null,
	kich_thuoc nvarchar(100) UNIQUE not null,
	vi_tri nvarchar(100) UNIQUE not null,
	phuong_huong nvarchar(100) UNIQUE not null,
	thich_hop nvarchar(255) UNIQUE not null, 

)
go 

INSERT INTO Ho_ca (ma_ho_ca, hinh_dang, kich_thuoc, vi_tri, phuong_huong, thich_hop)
VALUES
(1, N'Vuông', N'3x3m', N'Sân sau', N'Hướng Nam', N'Thích hợp cho koi Kohaku'),
(2, N'Chữ nhật', N'4x2m', N'Trước nhà', N'Hướng Đông', N'Thích hợp cho koi Showa'),
(3, N'Tròn', N'Đường kính 3m', N'Góc vườn', N'Hướng Tây', N'Thích hợp cho koi Sanke'),
(4, N'Oval', N'4x3m', N'Bên hông nhà', N'Hướng Bắc', N'Thích hợp cho koi Asagi'),
(5, N'Lục giác', N'2x2m', N'Tầng thượng', N'Hướng Tây Nam', N'Thích hợp cho koi Shusui');
go

create table Goi_dang_tin
(
	ma_goi int primary key,
	ten_goi Nvarchar(255) unique not null,
	gia_tien Nvarchar(255) not null,
)
go

CREATE TABLE Avertise
(
	ma_quang_cao int primary key,
	ma_khach_hang INT FOREIGN KEY references Khach_hang(ma_khach_hang) on delete cascade on update cascade,
	ma_ca_koi INT FOREIGN KEY references Koifish(ma_ca_koi) on delete cascade on update cascade,
	ma_ho_ca INT FOREIGN KEY references Ho_ca(ma_ho_ca) on delete cascade on update cascade,
	san_pham_trang_tri NVARCHAR(255) unique not null,
	ban_menh NVARCHAR(255) unique not null,
	mo_ta Nvarchar(255) unique not null,
	gia_tien int not null,
	ngay_tao DATETIME DEFAULT CURRENT_TIMESTAMP,
	ngay_chinh_sua DATETIME DEFAULT CURRENT_TIMESTAMP,
	ma_goi INT FOREIGN KEY references Goi_dang_tin(ma_goi) on delete cascade on update cascade,
)
go

