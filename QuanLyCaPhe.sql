CREATE DATABASE QuanLyCaPhe;
GO

USE QuanLyCaPhe;
GO

CREATE TABLE LoaiMon (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE MonAn (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    Gia FLOAT NOT NULL,
    HinhAnh NVARCHAR(500),
    MaLoai INT FOREIGN KEY REFERENCES LoaiMon(ID)
);
GO

INSERT INTO LoaiMon (TenLoai) VALUES (N'Cà phê');
INSERT INTO LoaiMon (TenLoai) VALUES (N'Trà');
INSERT INTO LoaiMon (TenLoai) VALUES (N'Matcha');
INSERT INTO LoaiMon (TenLoai) VALUES (N'Nước ép');
INSERT INTO LoaiMon (TenLoai) VALUES (N'Bánh');
GO

INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Cà phê đen', 35000, 'capheden.jpg', 1);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Cà phê sữa', 40000, 'caphesua.jpg', 1);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Bạc xỉu', 45000, 'bacxiu.jpg', 1);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Cà phê muối', 45000, 'caphemuoi.jpg', 1);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Cà phê hạnh nhân', 55000, 'hanhnhan.jpg', 1);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Americano', 40000, 'americano.jpg', 1);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Trà đào', 45000, 'tradao.jpg', 2);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Cam mật ong', 45000, 'cammatong.jpg', 2);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Matcha latte', 60000, 'matcha.jpg', 3);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Matcha dâu', 65000, 'matchadau.jpg', 3);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Matcha xoài', 65000, 'matchaxoai.jpg', 3);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Coldwhisk', 70000, 'coldwhisk.jpg', 3);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Croissant', 32000, 'croissant.jpg', 5);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Croissant hạnh nhân', 39000, 'croissant_hanhnhan.jpg', 5);
INSERT INTO MonAn (TenMon, Gia, HinhAnh, MaLoai) VALUES (N'Tiramisu', 49000, 'tiramisu.jpg', 5);
GO

UPDATE MonAn SET HinhAnh = 'cfden.jpg' WHERE TenMon = N'Cà phê đen';
UPDATE MonAn SET HinhAnh = 'cfsua.jpg' WHERE TenMon = N'Cà phê sữa';
GO

UPDATE MonAn
SET TenMon = N'Croissant Lava',
    HinhAnh = 'croissant_lava.jpg'
WHERE TenMon = N'Croissant Hạnh Nhân';