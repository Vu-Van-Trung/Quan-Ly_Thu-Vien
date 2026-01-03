-- =============================================
-- MIGRATION: Add NHAT_KY_HE_THONG Table
-- Version: 1.5
-- Date: 03/01/2026
-- Description: Thêm bảng Nhật ký hệ thống vào database hiện có
-- =============================================

USE QuanLyThuVien;
GO

PRINT '============================================='
PRINT 'Migration: Adding NHAT_KY_HE_THONG Table'
PRINT '============================================='

-- Kiểm tra xem bảng đã tồn tại chưa
IF OBJECT_ID('dbo.NHAT_KY_HE_THONG', 'U') IS NOT NULL
BEGIN
    PRINT 'Table NHAT_KY_HE_THONG already exists. Skipping creation.'
END
ELSE
BEGIN
    PRINT 'Creating table NHAT_KY_HE_THONG...'
    
    -- Tạo bảng
    CREATE TABLE NHAT_KY_HE_THONG (
        MaLog INT IDENTITY(1,1) PRIMARY KEY,
        TenDangNhap NVARCHAR(50) NOT NULL,
        ChucNang NVARCHAR(100) NOT NULL,
        HanhDong NVARCHAR(100) NOT NULL,
        NoiDung NVARCHAR(500) NULL,
        ThoiGian DATETIME DEFAULT GETDATE() NOT NULL
    );
    
    PRINT '  ✓ Table NHAT_KY_HE_THONG created successfully'
    
    -- Tạo indexes
    PRINT 'Creating indexes...'
    CREATE INDEX IX_NHAT_KY_TEN_DANG_NHAP ON NHAT_KY_HE_THONG(TenDangNhap);
    CREATE INDEX IX_NHAT_KY_CHUC_NANG ON NHAT_KY_HE_THONG(ChucNang);
    CREATE INDEX IX_NHAT_KY_THOI_GIAN ON NHAT_KY_HE_THONG(ThoiGian);
    
    PRINT '  ✓ Indexes created successfully'
    
    -- Thêm một vài log mẫu để test
    PRINT 'Inserting sample logs...'
    
    SET IDENTITY_INSERT NHAT_KY_HE_THONG ON;
    
    INSERT INTO NHAT_KY_HE_THONG (MaLog, TenDangNhap, ChucNang, HanhDong, NoiDung, ThoiGian) VALUES
    (1, 'admin', N'Hệ thống', N'Migration', N'Tạo bảng NHAT_KY_HE_THONG thành công', GETDATE());
    
    SET IDENTITY_INSERT NHAT_KY_HE_THONG OFF;
    
    PRINT '  ✓ Sample log inserted'
    PRINT ''
    PRINT '============================================='
    PRINT 'Migration completed successfully!'
    PRINT '============================================='
END
GO
