CREATE DATABASE QL_DOAN
ON PRIMARY 
    (
        NAME = QL_DOAN_Data,
        FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QL_DOAN.mdf'
    ),
FILEGROUP QL_DOAN_FS CONTAINS FILESTREAM
    (
        NAME = QL_DOAN_STREAM,
        FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QL_DOAN_STREAM'
    )
LOG ON
    (
        NAME = QL_DOAN_Log,
        FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QL_DOAN_log.ldf'
    );
GO

USE QL_DOAN
GO

EXEC sp_configure filestream_access_level, 2
GO
RECONFIGURE
GO

EXEC sp_configure 'show advanced options', 1;
GO
RECONFIGURE;
GO

EXEC sp_configure 'filestream_access_level', 2;
GO
RECONFIGURE;
GO

-- Tạo bảng Khoa
CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);
GO

-- Tạo bảng BoMon
CREATE TABLE BoMon (
    MaBoMon VARCHAR(10) PRIMARY KEY,
    TenBoMon NVARCHAR(100) NOT NULL,
	MaKhoa VARCHAR(10) NOT NULL,
	FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);
GO

-- Tạo bảng NguoiDung
CREATE TABLE NguoiDung (
    TenDangNhap VARCHAR(100) PRIMARY KEY,
    MatKhau VARCHAR(100) NOT NULL,
	HoatDong bit NOT NULL DEFAULT 1
);
GO

-- Tạo bảng NhomNguoiDung
CREATE TABLE NhomNguoiDung  
(  
    MaNhomNguoiDung VARCHAR(100) PRIMARY KEY,  
    TenNhomNguoiDung NVARCHAR(100) NOT NULL,  
    GhiChu NVARCHAR(100)
);  
GO

-- Tạo bảng NguoiDung_NhomNguoiDung
CREATE TABLE NguoiDung_NhomNguoiDung 
(  
    TenDangNhap VARCHAR(100) NOT NULL,  
    MaNhomNguoiDung VARCHAR(100) NOT NULL,  
    GhiChu NVARCHAR(100),
    PRIMARY KEY(TenDangNhap, MaNhomNguoiDung),
	FOREIGN KEY (TenDangNhap) REFERENCES NguoiDung(TenDangNhap),
	FOREIGN KEY (MaNhomNguoiDung) REFERENCES NhomNguoiDung(MaNhomNguoiDung)
);
GO  

-- Tạo bảng ManHinh
CREATE TABLE ManHinh  
(  
    MaManHinh VARCHAR(10) PRIMARY KEY,  
    TenManHinh NVARCHAR(100) NOT NULL
);  
GO

-- Tạo bảng PhanQUyen
CREATE TABLE PhanQuyen  
(  
    MaNhomNguoiDung VARCHAR(100) NOT NULL,  
    MaManHinh VARCHAR(10) NOT NULL,
    PRIMARY KEY(MaNhomNguoiDung, MaManHinh),
	FOREIGN KEY (MaManHinh) REFERENCES ManHinh(MaManHinh),
	FOREIGN KEY (MaNhomNguoiDung) REFERENCES NhomNguoiDung(MaNhomNguoiDung)
);  
GO  

-- Tạo bảng GiaoVuKhoa
CREATE TABLE GiaoVuKhoa (
    MaGiaoVu VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    Email VARCHAR(100),
	MaKhoa VARCHAR(10) NOT NULL,
	TenDangNhap VARCHAR(100) NOT NULL,
	FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
	FOREIGN KEY (TenDangNhap) REFERENCES NguoiDung(TenDangNhap)
);
GO

-- Tạo bảng GiangVien
CREATE TABLE GiangVien (
    MaGiangVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    Email VARCHAR(100),
    SoDienThoai VARCHAR(10),
    MaBoMon VARCHAR(10) NOT NULL,
	TenDangNhap VARCHAR(100) NOT NULL,
    FOREIGN KEY (MaBoMon) REFERENCES BoMon(MaBoMon),
	FOREIGN KEY (TenDangNhap) REFERENCES NguoiDung(TenDangNhap)
);
GO

-- Tạo bảng DeTai
CREATE TABLE DeTai (
    MaDeTai VARCHAR(10) PRIMARY KEY,
    TenDeTai NVARCHAR(200) NOT NULL,
    MoTa NVARCHAR(MAX),
    TrangThai NVARCHAR(50) NOT NULL,
    NgayDeXuat DATETIME NOT NULL,
    NgayDuyet DATETIME,
    MaGVHuongDan VARCHAR(10) NOT NULL,
    MaGVPhanBien VARCHAR(10),
    MaBoMon VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaGVHuongDan) REFERENCES GiangVien(MaGiangVien),
    FOREIGN KEY (MaGVPhanBien) REFERENCES GiangVien(MaGiangVien),
    FOREIGN KEY (MaBoMon) REFERENCES BoMon(MaBoMon),
    CONSTRAINT CHK_TrangThaiDeTai CHECK (TrangThai IN (N'Đề xuất', N'Đã duyệt', N'Chờ chỉnh sửa', N'Đã đăng ký', N'Hoàn thành'))
);
GO

-- Tạo bảng Lop
CREATE TABLE Lop  
(  
    MaLop VARCHAR(10) PRIMARY KEY,  
    TenLop NVARCHAR(100) NOT NULL
);  
GO  

-- Tạo bảng SinhVien
CREATE TABLE SinhVien (
    MaSinhVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
	GioiTinh NVARCHAR(10),
	NamSinh DATE,
    Email VARCHAR(100),
    SoDienThoai VARCHAR(10),
	MaLop VARCHAR(10) NOT NULL,
	MaKhoa VARCHAR(10) NOT NULL,
    TenDangNhap VARCHAR(100) NOT NULL,
	FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
	FOREIGN KEY (TenDangNhap) REFERENCES NguoiDung(TenDangNhap),
	FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
);
GO

-- Tạo bảng NhomSinhVien
CREATE TABLE NhomSinhVien (
    MaNhom VARCHAR(10) PRIMARY KEY,
    NgayDangKy DATETIME NOT NULL,
    DaDuyet BIT DEFAULT 0,
    MaNhomTruong VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaNhomTruong) REFERENCES SinhVien(MaSinhVien)
);
GO

-- Tạo bảng ThanhVienNhom (bảng trung gian cho quan hệ nhiều-nhiều giữa SinhVien và NhomSinhVien)
CREATE TABLE ThanhVienNhom (
    MaNhom VARCHAR(10),
    MaSinhVien VARCHAR(10),
    PRIMARY KEY (MaNhom, MaSinhVien),
    FOREIGN KEY (MaNhom) REFERENCES NhomSinhVien(MaNhom),
    FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien)
);
GO

-- Tạo bảng NamHoc
CREATE TABLE NamHoc (
    MaNamHoc VARCHAR(10) PRIMARY KEY,
    TenNamHoc NVARCHAR(10)
);
GO

-- Tạo bảng HocKy
CREATE TABLE HocKy (
    MaHocKy VARCHAR(10) PRIMARY KEY,
    TenHocKy NVARCHAR(10),
	MaNamHoc VARCHAR(10) NOT NULL,
	FOREIGN KEY (MaNamHoc) REFERENCES NamHoc(MaNamHoc)
);
GO

-- Tạo bảng ThoiGianDangKy
CREATE TABLE ThoiGianDangKy (
    MaThoiGianDangKy VARCHAR(10) PRIMARY KEY,
    MaHocKy VARCHAR(10) NOT NULL,
    NgayBatDau DATETIME NOT NULL,
    NgayKetThuc DATETIME NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
	FOREIGN KEY (MaHocKy) REFERENCES HocKy(MaHocKy),
    CONSTRAINT CHK_TrangThaiDangKy CHECK (TrangThai IN (N'Chưa mở', N'Đang mở', N'Đã đóng'))
);
GO

-- Tạo bảng DangKyDeTai
CREATE TABLE DangKyDeTai (
    MaDangKyDeTai VARCHAR(10) PRIMARY KEY,
    NgayDangKy DATETIME NOT NULL,
    MaNhom VARCHAR(10) NOT NULL,
    MaDeTai VARCHAR(10) NOT NULL,
    MaThoiGianDangKy VARCHAR(10) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL,
    FOREIGN KEY (MaNhom) REFERENCES NhomSinhVien(MaNhom),
    FOREIGN KEY (MaDeTai) REFERENCES DeTai(MaDeTai),
    FOREIGN KEY (MaThoiGianDangKy) REFERENCES ThoiGianDangKy(MaThoiGianDangKy),
    CONSTRAINT UQ_NhomDeTai UNIQUE (MaNhom, MaDeTai),
    CONSTRAINT CHK_TrangThaiDangKyDeTai CHECK (TrangThai IN (N'Đã đăng ký', N'Đã hủy'))
);
GO

-- Tạo bảng BaoCaoTienDo
CREATE TABLE BaoCaoTienDo (
    MaBaoCao VARCHAR(10) PRIMARY KEY,
    TuanThu INT NOT NULL,
    NgayBaoCao DATETIME NOT NULL,
    NoiDung NVARCHAR(MAX),
    CoMat BIT NOT NULL,
    MaNhom VARCHAR(10) NOT NULL,
    MaGiangVien VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaNhom) REFERENCES NhomSinhVien(MaNhom),
    FOREIGN KEY (MaGiangVien) REFERENCES GiangVien(MaGiangVien),
    CONSTRAINT CHK_TuanBaoCao CHECK (TuanThu BETWEEN 1 AND 10)
);
GO

-- Tạo bảng DoAnVaDiem
CREATE TABLE DoAnVaDiem (
    MaDeTai VARCHAR(10) PRIMARY KEY,
	Id uniqueidentifier ROWGUIDCOL NOT NULL UNIQUE DEFAULT NEWID(),
	NgayNopDoAn DATE,
	NoiDungDoAn VARBINARY(MAX) FILESTREAM NULL,
    DiemGVHuongDan FLOAT,
    DiemGVPhanBien FLOAT,
    DiemCuoiCung FLOAT,
    NhanXet NVARCHAR(MAX),
    NgayCham DATETIME,
    MaNhom VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaNhom) REFERENCES NhomSinhVien(MaNhom),
    FOREIGN KEY (MaDeTai) REFERENCES DeTai(MaDeTai),
    CONSTRAINT CHK_DiemHopLe CHECK (
        DiemGVHuongDan BETWEEN 0 AND 10 AND
        DiemGVPhanBien BETWEEN 0 AND 10 AND
        DiemCuoiCung BETWEEN 0 AND 10
    )
);
GO

-- Tạo các Index để tối ưu hiệu suất truy vấn
/*CREATE INDEX IX_GiangVien_BoMon ON GiangVien(MaBoMon);
CREATE INDEX IX_DeTai_BoMon ON DeTai(MaBoMon);
CREATE INDEX IX_DeTai_GiangVien ON DeTai(MaGVHuongDan, MaGVPhanBien);
CREATE INDEX IX_BaoCaoTienDo_Nhom ON BaoCaoTienDo(MaNhom);
CREATE INDEX IX_DangKyDeTai_KyDangKy ON DangKyDeTai(MaKyDangKy);
CREATE INDEX IX_ThanhVienNhom_SinhVien ON ThanhVienNhom(MaSinhVien);
GO*/

USE QL_DOAN
GO

-- Thêm dữ liệu cho bảng Khoa
DELETE FROM Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES
('CNTT', N'Công nghệ thông tin')
GO

-- Thêm dữ liệu cho bảng BoMon
DELETE FROM BoMon
INSERT INTO BoMon (MaBoMon, TenBoMon, MaKhoa) VALUES
('CNPM', N'Công nghệ phần mềm', 'CNTT'),
('TT', N'Trí tuệ nhân tạo', 'CNTT'),
('HTTT', N'Hệ thống thông tin', 'CNTT')
GO

-- Thêm dữ liệu cho bảng NguoiDung
DELETE FROM NguoiDung
INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoatDong) VALUES
('giaovu1', '123456', 1),
('giaovu2', '123456', 1),
('gv001', '123456', 1),
('gv002', '123456', 1),
('gv003', '123456', 1),
('gv004', '123456', 1),
('sv001', '123456', 1),
('sv002', '123456', 1),
('sv003', '123456', 1),
('sv004', '123456', 1),
('sv005', '123456', 1),
('sv006', '123456', 1)
GO

-- Thêm dữ liệu cho bảng GiaoVuKhoa
DELETE FROM GiaoVuKhoa
INSERT INTO GiaoVuKhoa (MaGiaoVu, HoTen, Email, MaKhoa, TenDangNhap) VALUES
('GV001', N'Nguyễn Thị Minh', 'minhnt@example.com', 'CNTT', 'giaovu1'),
('GV002', N'Trần Văn Hoàng', 'hoangtv@example.com', 'CNTT', 'giaovu2')
GO

-- Thêm dữ liệu cho bảng GiangVien
DELETE FROM GiangVien
INSERT INTO GiangVien (MaGiangVien, HoTen, Email, SoDienThoai, MaBoMon, TenDangNhap) VALUES
('GV101', N'Phạm Văn An', 'anpv@example.com', '0901234567', 'CNPM', 'gv001'),
('GV102', N'Lê Thị Bình', 'binhlt@example.com', '0912345678', 'TT', 'gv002'),
('GV103', N'Trần Đức Cường', 'cuongtd@example.com', '0923456789', 'HTTT', 'gv003'),
('GV104', N'Nguyễn Thị Dung', 'dungnt@example.com', '0934567890', 'HTTT', 'gv004')
GO

-- Thêm dữ liệu cho bảng Lop
DELETE FROM Lop
INSERT INTO Lop (MaLop, TenLop) VALUES
('12DHTH01', N'12DHTH01'),
('12DHTH02', N'12DHTH02'),
('13DHTH01', N'13DHTH01'),
('13DHTH02', N'13DHTH02')
GO

-- Thêm dữ liệu cho bảng SinhVien
DELETE FROM SinhVien
INSERT INTO SinhVien (MaSinhVien, HoTen, GioiTinh, NamSinh, Email, SoDienThoai, MaLop, TenDangNhap, MaKhoa) VALUES
('SV001', N'Nguyễn Văn Nam', N'Nam', '2002-01-15', 'namnv@example.com', '0945678901', '12DHTH01', 'sv001', 'CNTT'),
('SV002', N'Trần Thị Hoa', N'Nữ', '2002-03-20', 'hoatt@example.com', '0956789012', '12DHTH01', 'sv002', 'CNTT'),
('SV003', N'Lê Văn Đức', N'Nam', '2002-05-10', 'duclv@example.com', '0967890123', '12DHTH02', 'sv003', 'CNTT'),
('SV004', N'Phạm Thị Mai', N'Nữ', '2002-07-25', 'maipt@example.com', '0978901234', '12DHTH02', 'sv004', 'CNTT'),
('SV005', N'Hoàng Văn Long', N'Nam', '2002-09-30', 'longhv@example.com', '0989012345', '13DHTH01', 'sv005', 'CNTT'),
('SV006', N'Vũ Thị Lan', N'Nữ', '2002-11-05', 'lanvt@example.com', '0990123456', '13DHTH02', 'sv006', 'CNTT')
GO

-- Thêm dữ liệu cho bảng NamHoc
DELETE FROM NamHoc
INSERT INTO NamHoc (MaNamHoc, TenNamHoc) VALUES
('NH2223', '2022-2023'),
('NH2324', '2023-2024'),
('NH2425', '2024-2025')
GO

-- Thêm dữ liệu cho bảng HocKy
DELETE FROM HocKy
INSERT INTO HocKy (MaHocKy, TenHocKy, MaNamHoc) VALUES
('HK1_2223', N'Học kỳ 1', 'NH2223'),
('HK2_2223', N'Học kỳ 2', 'NH2223'),
('HK1_2324', N'Học kỳ 1', 'NH2324'),
('HK2_2324', N'Học kỳ 2', 'NH2324')
GO

-- Thêm dữ liệu cho bảng ThoiGianDangKy
DELETE FROM ThoiGianDangKy
INSERT INTO ThoiGianDangKy (MaThoiGianDangKy, MaHocKy, NgayBatDau, NgayKetThuc, TrangThai) VALUES
('TGDK1', 'HK1_2324', '2023-09-01', '2023-09-15', N'Đã đóng'),
('TGDK2', 'HK2_2324', '2024-01-15', '2024-01-30', N'Đang mở')
GO

-- Thêm dữ liệu cho bảng DeTai
DELETE FROM DeTai
INSERT INTO DeTai (MaDeTai, TenDeTai, MoTa, TrangThai, NgayDeXuat, NgayDuyet, MaGVHuongDan, MaGVPhanBien, MaBoMon) VALUES
('DT001', N'Xây dựng ứng dụng quản lý đồ án', N'Xây dựng hệ thống quản lý đồ án với các chức năng cơ bản', N'Đã duyệt', '2023-08-15', '2023-08-20', 'GV101', 'GV102', 'CNPM'),
('DT002', N'Phát triển hệ thống IoT cho nhà thông minh', N'Nghiên cứu và phát triển hệ thống IoT điều khiển thiết bị trong nhà', N'Đã duyệt', '2023-08-16', '2023-08-21', 'GV103', 'GV104', 'HTTT'),
('DT003', N'Ứng dụng AI trong nhận diện khuôn mặt', N'Phát triển hệ thống nhận diện khuôn mặt sử dụng deep learning', N'Đề xuất', '2023-08-17', NULL, 'GV101', NULL, 'CNPM'),
('DT004', N'Xây dựng website thương mại điện tử', N'Phát triển website thương mại điện tử với đầy đủ chức năng', N'Chờ chỉnh sửa', '2023-08-18', NULL, 'GV102', NULL, 'TT')
GO

-- Thêm dữ liệu cho bảng NhomSinhVien
DELETE FROM NhomSinhVien
INSERT INTO NhomSinhVien (MaNhom, NgayDangKy, DaDuyet, MaNhomTruong) VALUES
('N001', '2023-09-02', 1, 'SV001'),
('N002', '2023-09-03', 1, 'SV003'),
('N003', '2023-09-04', 0, 'SV005')
GO

-- Thêm dữ liệu cho bảng ThanhVienNhom
DELETE FROM ThanhVienNhom
INSERT INTO ThanhVienNhom (MaNhom, MaSinhVien) VALUES
('N001', 'SV001'),
('N001', 'SV002'),
('N002', 'SV003'), 
('N002', 'SV004'),
('N003', 'SV005'),
('N003', 'SV006')
GO

-- Thêm dữ liệu cho bảng DangKyDeTai
DELETE FROM DangKyDeTai
INSERT INTO DangKyDeTai (MaDangKyDeTai, NgayDangKy, MaNhom, MaDeTai, MaThoiGianDangKy, TrangThai) VALUES
('DK001', '2023-09-05', 'N001', 'DT001', 'TGDK1', N'Đã đăng ký'),
('DK002', '2023-09-06', 'N002', 'DT002', 'TGDK1', N'Đã đăng ký')
GO

-- Thêm dữ liệu cho bảng BaoCaoTienDo
DELETE FROM BaoCaoTienDo
INSERT INTO BaoCaoTienDo (MaBaoCao, TuanThu, NgayBaoCao, NoiDung, CoMat, MaNhom, MaGiangVien) VALUES
('BC001', 1, '2023-09-12', N'Đã hoàn thành phân tích yêu cầu và thiết kế database', 1, 'N001', 'GV101'),
('BC002', 1, '2023-09-12', N'Đã hoàn thành khảo sát hiện trạng và lập kế hoạch', 1, 'N002', 'GV103'),
('BC003', 2, '2023-09-19', N'Đã hoàn thành thiết kế giao diện người dùng', 1, 'N001', 'GV101'),
('BC004', 2, '2023-09-19', N'Đã hoàn thành thiết kế mô hình hệ thống', 0, 'N002', 'GV103')
GO