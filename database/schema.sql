-- =============================================
-- HỆ THỐNG QUẢN LÝ THƯ VIỆN
-- Database Schema Creation Script
-- Version: 1.5
-- Date: 03/01/2026
-- Author: Vũ Văn Trung
-- =============================================

USE master;
GO

-- Tạo database nếu chưa tồn tại
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'QuanLyThuVien')
BEGIN
    CREATE DATABASE QuanLyThuVien;
    PRINT 'Database QuanLyThuVien created successfully.';
END
GO

USE QuanLyThuVien;
GO

-- =============================================
-- DROP TABLES (Theo thứ tự dependencies)
-- =============================================
IF OBJECT_ID('dbo.NHAT_KY_HE_THONG', 'U') IS NOT NULL DROP TABLE dbo.NHAT_KY_HE_THONG;
IF OBJECT_ID('dbo.PHAT', 'U') IS NOT NULL DROP TABLE dbo.PHAT;
IF OBJECT_ID('dbo.CHI_TIET_PHIEU_MUON', 'U') IS NOT NULL DROP TABLE dbo.CHI_TIET_PHIEU_MUON;
IF OBJECT_ID('dbo.PHIEU_MUON', 'U') IS NOT NULL DROP TABLE dbo.PHIEU_MUON;
IF OBJECT_ID('dbo.TAI_KHOAN', 'U') IS NOT NULL DROP TABLE dbo.TAI_KHOAN;
IF OBJECT_ID('dbo.SACH', 'U') IS NOT NULL DROP TABLE dbo.SACH;
IF OBJECT_ID('dbo.DOC_GIA', 'U') IS NOT NULL DROP TABLE dbo.DOC_GIA;
IF OBJECT_ID('dbo.NHAN_VIEN', 'U') IS NOT NULL DROP TABLE dbo.NHAN_VIEN;
IF OBJECT_ID('dbo.NHA_XUAT_BAN', 'U') IS NOT NULL DROP TABLE dbo.NHA_XUAT_BAN;
IF OBJECT_ID('dbo.THE_LOAI', 'U') IS NOT NULL DROP TABLE dbo.THE_LOAI;
IF OBJECT_ID('dbo.TAC_GIA', 'U') IS NOT NULL DROP TABLE dbo.TAC_GIA;
GO

-- =============================================
-- 1. BẢNG TAC_GIA (Authors)
-- =============================================
CREATE TABLE TAC_GIA (
    MaTacGia INT IDENTITY(1,1) PRIMARY KEY,
    TenTacGia NVARCHAR(100) NOT NULL,
    NgaySinh DATE NULL,
    QuocTich NVARCHAR(50) NULL,
    TieuSu NVARCHAR(MAX) NULL,
    NgayTao DATETIME DEFAULT GETDATE() NOT NULL,
    NgayCapNhat DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- =============================================
-- 2. BẢNG THE_LOAI (Categories)
-- =============================================
CREATE TABLE THE_LOAI (
    MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
    TenTheLoai NVARCHAR(100) NOT NULL UNIQUE,
    MoTa NVARCHAR(500) NULL,
    NgayTao DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- =============================================
-- 3. BẢNG NHA_XUAT_BAN (Publishers)
-- =============================================
CREATE TABLE NHA_XUAT_BAN (
    MaNhaXuatBan INT IDENTITY(1,1) PRIMARY KEY,
    TenNhaXuatBan NVARCHAR(MAX) NOT NULL,
    DiaChi NVARCHAR(MAX) NULL,
    SoDienThoai VARCHAR(MAX) NULL,
    Email VARCHAR(MAX) NULL,
    NgayTao DATETIME DEFAULT GETDATE() NOT NULL,
    NgayCapNhat DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- =============================================
-- 4. BẢNG NHAN_VIEN (Staff)
-- =============================================
CREATE TABLE NHAN_VIEN (
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(MAX) NOT NULL,
    ChucVu NVARCHAR(MAX) NOT NULL,
    NgaySinh DATE NULL,
    GioiTinh NVARCHAR(MAX) NULL,
    DiaChi NVARCHAR(MAX) NULL,
    SoDienThoai VARCHAR(MAX) NULL,
    Email VARCHAR(MAX) NULL,
    NgayVaoLam DATETIME DEFAULT GETDATE() NOT NULL,
    TrangThai NVARCHAR(MAX) DEFAULT N'Đang làm việc' NOT NULL,
    NgayTao DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- =============================================
-- 5. BẢNG DOC_GIA (Members/Readers)
-- =============================================
CREATE TABLE DOC_GIA (
    MaDocGia VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(MAX) NOT NULL,
    NgaySinh DATE NULL,
    GioiTinh NVARCHAR(MAX) NULL,
    DiaChi NVARCHAR(MAX) NULL,
    SoDienThoai VARCHAR(MAX) NULL,
    Email VARCHAR(MAX) NULL,
    CMND VARCHAR(MAX) NULL UNIQUE,
    NgayDangKy DATETIME DEFAULT GETDATE() NOT NULL,
    NgayHetHan DATETIME NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Hoạt động' NOT NULL,
    GhiChu NVARCHAR(500) NULL
);
GO

-- =============================================
-- 6. BẢNG SACH (Books)
-- =============================================
CREATE TABLE SACH (
    MaSach VARCHAR(20) PRIMARY KEY,
    TenSach NVARCHAR(200) NOT NULL,
    MaTacGia INT NOT NULL,
    MaTheLoai INT NOT NULL,
    MaNhaXuatBan INT NOT NULL,
    NamXuatBan INT NULL,
    SoLuongTon INT DEFAULT 0 NOT NULL,
    ViTri NVARCHAR(50) NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Có sẵn' NOT NULL,
    MoTa NVARCHAR(MAX) NULL,
    GiaTien DECIMAL(18,2) NULL,
    NgayNhap DATETIME DEFAULT GETDATE() NOT NULL,
    
    CONSTRAINT FK_SACH_TAC_GIA FOREIGN KEY (MaTacGia) REFERENCES TAC_GIA(MaTacGia),
    CONSTRAINT FK_SACH_THE_LOAI FOREIGN KEY (MaTheLoai) REFERENCES THE_LOAI(MaTheLoai),
    CONSTRAINT FK_SACH_NHA_XUAT_BAN FOREIGN KEY (MaNhaXuatBan) REFERENCES NHA_XUAT_BAN(MaNhaXuatBan),
    CONSTRAINT CHK_SACH_NAM CHECK (NamXuatBan IS NULL OR NamXuatBan BETWEEN 1000 AND YEAR(GETDATE()) + 1),
    CONSTRAINT CHK_SACH_SOLUONG CHECK (SoLuongTon >= 0)
);
GO

-- =============================================
-- 7. BẢNG TAI_KHOAN (User Accounts)
-- =============================================
CREATE TABLE TAI_KHOAN (
    MaTaiKhoan INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
    MatKhau VARCHAR(255) NOT NULL,
    MaNhanVien INT NOT NULL,
    QuyenHan NVARCHAR(50) DEFAULT N'Nhân viên' NOT NULL,
    TrangThai NVARCHAR(20) DEFAULT N'Hoạt động' NOT NULL,
    NgayTao DATETIME DEFAULT GETDATE() NOT NULL,
    LanDangNhapCuoi DATETIME NULL,
    
    CONSTRAINT FK_TAI_KHOAN_NHAN_VIEN FOREIGN KEY (MaNhanVien) REFERENCES NHAN_VIEN(MaNhanVien)
);
GO

-- =============================================
-- 8. BẢNG PHIEU_MUON (Loan Receipts)
-- =============================================
CREATE TABLE PHIEU_MUON (
    MaPhieuMuon VARCHAR(20) PRIMARY KEY,
    MaDocGia VARCHAR(20) NOT NULL,
    MaNhanVien INT NOT NULL,
    NgayMuon DATETIME DEFAULT GETDATE() NOT NULL,
    HanTra DATETIME NOT NULL,
    NgayTraThucTe DATETIME NULL,
    TrangThai NVARCHAR(50) DEFAULT N'Đang mượn' NOT NULL,
    GhiChu NVARCHAR(500) NULL,
    
    CONSTRAINT FK_PHIEU_MUON_DOC_GIA FOREIGN KEY (MaDocGia) REFERENCES DOC_GIA(MaDocGia),
    CONSTRAINT FK_PHIEU_MUON_NHAN_VIEN FOREIGN KEY (MaNhanVien) REFERENCES NHAN_VIEN(MaNhanVien),
    CONSTRAINT CHK_PHIEU_MUON_NGAY CHECK (HanTra > NgayMuon)
);
GO

-- =============================================
-- 9. BẢNG CHI_TIET_PHIEU_MUON (Loan Details)
-- =============================================
CREATE TABLE CHI_TIET_PHIEU_MUON (
    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuMuon VARCHAR(20) NOT NULL,
    MaSach VARCHAR(20) NOT NULL,
    SoLuong INT DEFAULT 1 NOT NULL,
    TinhTrangMuon NVARCHAR(100) DEFAULT N'Tốt' NOT NULL,
    TinhTrangTra NVARCHAR(100) NULL,
    NgayTra DATETIME NULL,
    
    CONSTRAINT FK_CHI_TIET_PHIEU_MUON FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEU_MUON(MaPhieuMuon) ON DELETE CASCADE,
    CONSTRAINT FK_CHI_TIET_SACH FOREIGN KEY (MaSach) REFERENCES SACH(MaSach),
    CONSTRAINT CHK_CHI_TIET_SOLUONG CHECK (SoLuong > 0)
);
GO

-- =============================================
-- 10. BẢNG PHAT (Fines)
-- =============================================
CREATE TABLE PHAT (
    MaPhat INT IDENTITY(1,1) PRIMARY KEY,
    MaPhieuMuon VARCHAR(20) NOT NULL,
    LyDo NVARCHAR(500) NOT NULL,
    SoTienPhat DECIMAL(18,2) NOT NULL,
    NgayPhat DATETIME DEFAULT GETDATE() NOT NULL,
    TrangThaiThanhToan NVARCHAR(50) DEFAULT N'Chưa thanh toán' NOT NULL,
    NgayThanhToan DATETIME NULL,
    
    CONSTRAINT FK_PHAT_PHIEU_MUON FOREIGN KEY (MaPhieuMuon) REFERENCES PHIEU_MUON(MaPhieuMuon) ON DELETE CASCADE,
    CONSTRAINT CHK_PHAT_SOTIEN CHECK (SoTienPhat >= 0)
);
GO

-- =============================================
-- 11. BẢNG NHAT_KY_HE_THONG (System Logs)
-- =============================================
CREATE TABLE NHAT_KY_HE_THONG (
    MaLog INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL,
    ChucNang NVARCHAR(100) NOT NULL,
    HanhDong NVARCHAR(100) NOT NULL,
    NoiDung NVARCHAR(500) NULL,
    ThoiGian DATETIME DEFAULT GETDATE() NOT NULL
);
GO

-- =============================================
-- CREATE INDEXES FOR PERFORMANCE
-- =============================================

-- Indexes for TAC_GIA
CREATE INDEX IX_TAC_GIA_TEN ON TAC_GIA(TenTacGia);

-- Indexes for SACH
CREATE INDEX IX_SACH_TEN ON SACH(TenSach);
CREATE INDEX IX_SACH_TAC_GIA ON SACH(MaTacGia);
CREATE INDEX IX_SACH_THE_LOAI ON SACH(MaTheLoai);
CREATE INDEX IX_SACH_NXB ON SACH(MaNhaXuatBan);
CREATE INDEX IX_SACH_TRANG_THAI ON SACH(TrangThai);

-- Indexes for DOC_GIA
CREATE INDEX IX_DOC_GIA_TEN ON DOC_GIA(HoTen);
CREATE INDEX IX_DOC_GIA_SDT ON DOC_GIA(SoDienThoai);
CREATE INDEX IX_DOC_GIA_TRANG_THAI ON DOC_GIA(TrangThai);

-- Indexes for NHAN_VIEN
CREATE INDEX IX_NHAN_VIEN_TEN ON NHAN_VIEN(HoTen);
CREATE INDEX IX_NHAN_VIEN_CHUC_VU ON NHAN_VIEN(ChucVu);

-- Indexes for TAI_KHOAN
CREATE INDEX IX_TAI_KHOAN_TEN_DANG_NHAP ON TAI_KHOAN(TenDangNhap);

-- Indexes for PHIEU_MUON
CREATE INDEX IX_PHIEU_MUON_DOC_GIA ON PHIEU_MUON(MaDocGia);
CREATE INDEX IX_PHIEU_MUON_NHAN_VIEN ON PHIEU_MUON(MaNhanVien);
CREATE INDEX IX_PHIEU_MUON_NGAY ON PHIEU_MUON(NgayMuon);
CREATE INDEX IX_PHIEU_MUON_HAN_TRA ON PHIEU_MUON(HanTra);
CREATE INDEX IX_PHIEU_MUON_TRANG_THAI ON PHIEU_MUON(TrangThai);

-- Indexes for CHI_TIET_PHIEU_MUON
CREATE INDEX IX_CHI_TIET_PHIEU ON CHI_TIET_PHIEU_MUON(MaPhieuMuon);
CREATE INDEX IX_CHI_TIET_SACH ON CHI_TIET_PHIEU_MUON(MaSach);

-- Indexes for PHAT
CREATE INDEX IX_PHAT_PHIEU_MUON ON PHAT(MaPhieuMuon);
CREATE INDEX IX_PHAT_TRANG_THAI ON PHAT(TrangThaiThanhToan);
CREATE INDEX IX_PHAT_NGAY ON PHAT(NgayPhat);

-- Indexes for NHAT_KY_HE_THONG
CREATE INDEX IX_NHAT_KY_TEN_DANG_NHAP ON NHAT_KY_HE_THONG(TenDangNhap);
CREATE INDEX IX_NHAT_KY_CHUC_NANG ON NHAT_KY_HE_THONG(ChucNang);
CREATE INDEX IX_NHAT_KY_THOI_GIAN ON NHAT_KY_HE_THONG(ThoiGian);

GO

PRINT '============================================='
PRINT 'Database schema created successfully!'
PRINT '============================================='
PRINT 'Total tables created: 11'
PRINT '  1. TAC_GIA (Authors)'
PRINT '  2. THE_LOAI (Categories)'
PRINT '  3. NHA_XUAT_BAN (Publishers)'
PRINT '  4. NHAN_VIEN (Staff)'
PRINT '  5. DOC_GIA (Members)'
PRINT '  6. SACH (Books)'
PRINT '  7. TAI_KHOAN (User Accounts)'
PRINT '  8. PHIEU_MUON (Loans)'
PRINT '  9. CHI_TIET_PHIEU_MUON (Loan Details)'
PRINT ' 10. PHAT (Fines)'
PRINT ' 11. NHAT_KY_HE_THONG (System Logs)'
PRINT '============================================='
PRINT 'Total indexes created: 25'
PRINT '============================================='
GO
