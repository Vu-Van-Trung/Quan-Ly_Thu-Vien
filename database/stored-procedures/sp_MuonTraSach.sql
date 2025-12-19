-- =============================================
-- STORED PROCEDURES - QUẢN LÝ MƯỢN TRẢ SÁCH
-- =============================================

USE QuanLyThuVien;
GO

-- =============================================
-- SP: Tạo phiếu mượn mới
-- =============================================
IF OBJECT_ID('sp_TaoPhieuMuon', 'P') IS NOT NULL
    DROP PROCEDURE sp_TaoPhieuMuon;
GO

CREATE PROCEDURE sp_TaoPhieuMuon
    @MaPhieuMuon VARCHAR(20),
    @MaDocGia VARCHAR(20),
    @MaNhanVien INT,
    @SoNgayMuon INT = 14,
    @GhiChu NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Kiểm tra độc giả có đang hoạt động không
        IF NOT EXISTS (SELECT 1 FROM DOC_GIA WHERE MaDocGia = @MaDocGia AND TrangThai = N'Hoạt động')
        BEGIN
            ROLLBACK;
            RAISERROR (N'Độc giả không hợp lệ hoặc đã bị khóa!', 16, 1);
            RETURN;
        END
        
        -- Kiểm tra độc giả đã mượn quá 5 sách chưa
        DECLARE @SoSachDangMuon INT;
        SELECT @SoSachDangMuon = COUNT(*)
        FROM PHIEU_MUON pm
        INNER JOIN CHI_TIET_PHIEU_MUON ct ON pm.MaPhieuMuon = ct.MaPhieuMuon
        WHERE pm.MaDocGia = @MaDocGia AND pm.TrangThai = N'Đang mượn' AND ct.NgayTra IS NULL;
        
        IF @SoSachDangMuon >= 5
        BEGIN
            ROLLBACK;
            RAISERROR (N'Độc giả đã mượn tối đa 5 quyển sách!', 16, 1);
            RETURN;
        END
        
        -- Tạo phiếu mượn
        DECLARE @NgayMuon DATETIME = GETDATE();
        DECLARE @HanTra DATETIME = DATEADD(DAY, @SoNgayMuon, @NgayMuon);
        
        INSERT INTO PHIEU_MUON (MaPhieuMuon, MaDocGia, MaNhanVien, NgayMuon, HanTra, TrangThai, GhiChu)
        VALUES (@MaPhieuMuon, @MaDocGia, @MaNhanVien, @NgayMuon, @HanTra, N'Đang mượn', @GhiChu);
        
        COMMIT;
        PRINT N'Tạo phiếu mượn thành công!';
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
        PRINT ERROR_MESSAGE();
        THROW;
    END CATCH
END
GO

-- =============================================
-- SP: Thêm sách vào phiếu mượn
-- =============================================
IF OBJECT_ID('sp_ThemSachVaoPhieuMuon', 'P') IS NOT NULL
    DROP PROCEDURE sp_ThemSachVaoPhieuMuon;
GO

CREATE PROCEDURE sp_ThemSachVaoPhieuMuon
    @MaPhieuMuon VARCHAR(20),
    @MaSach VARCHAR(20),
    @SoLuong INT = 1,
    @TinhTrangMuon NVARCHAR(100) = N'Tốt'
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Kiểm tra phiếu mượn
        IF NOT EXISTS (SELECT 1 FROM PHIEU_MUON WHERE MaPhieuMuon = @MaPhieuMuon AND TrangThai = N'Đang mượn')
        BEGIN
            ROLLBACK;
            RAISERROR (N'Phiếu mượn không hợp lệ!', 16, 1);
            RETURN;
        END
        
        -- Kiểm tra sách có đủ số lượng không
        DECLARE @SoLuongTon INT;
        SELECT @SoLuongTon = SoLuongTon FROM SACH WHERE MaSach = @MaSach;
        
        IF @SoLuongTon IS NULL
        BEGIN
            ROLLBACK;
            RAISERROR (N'Không tìm thấy sách!', 16, 1);
            RETURN;
        END
        
        IF @SoLuongTon < @SoLuong
        BEGIN
            ROLLBACK;
            RAISERROR (N'Không đủ sách để mượn!', 16, 1);
            RETURN;
        END
        
        -- Thêm chi tiết phiếu mượn
        INSERT INTO CHI_TIET_PHIEU_MUON (MaPhieuMuon, MaSach, SoLuong, TinhTrangMuon)
        VALUES (@MaPhieuMuon, @MaSach, @SoLuong, @TinhTrangMuon);
        
        -- Giảm số lượng tồn
        UPDATE SACH
        SET SoLuongTon = SoLuongTon - @SoLuong
        WHERE MaSach = @MaSach;
        
        COMMIT;
        PRINT N'Thêm sách vào phiếu mượn thành công!';
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
        PRINT ERROR_MESSAGE();
        THROW;
    END CATCH
END
GO

-- =============================================
-- SP: Trả sách
-- =============================================
IF OBJECT_ID('sp_TraSach', 'P') IS NOT NULL
    DROP PROCEDURE sp_TraSach;
GO

CREATE PROCEDURE sp_TraSach
    @MaChiTiet INT,
    @TinhTrangTra NVARCHAR(100) = N'Tốt'
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @MaSach VARCHAR(20);
        DECLARE @SoLuong INT;
        DECLARE @MaPhieuMuon VARCHAR(20);
        DECLARE @HanTra DATETIME;
        DECLARE @NgayTra DATETIME = GETDATE();
        
        -- Lấy thông tin chi tiết phiếu mượn
        SELECT @MaSach = MaSach, @SoLuong = SoLuong, @MaPhieuMuon = MaPhieuMuon
        FROM CHI_TIET_PHIEU_MUON
        WHERE MaChiTiet = @MaChiTiet AND NgayTra IS NULL;
        
        IF @MaSach IS NULL
        BEGIN
            ROLLBACK;
            RAISERROR (N'Không tìm thấy chi tiết mượn hoặc đã trả!', 16, 1);
            RETURN;
        END
        
        -- Lấy hạn trả
        SELECT @HanTra = HanTra FROM PHIEU_MUON WHERE MaPhieuMuon = @MaPhieuMuon;
        
        -- Cập nhật chi tiết phiếu mượn
        UPDATE CHI_TIET_PHIEU_MUON
        SET NgayTra = @NgayTra,
            TinhTrangTra = @TinhTrangTra
        WHERE MaChiTiet = @MaChiTiet;
        
        -- Tăng số lượng tồn
        UPDATE SACH
        SET SoLuongTon = SoLuongTon + @SoLuong
        WHERE MaSach = @MaSach;
        
        -- Tính phạt nếu trễ hạn
        IF @NgayTra > @HanTra
        BEGIN
            DECLARE @SoNgayTre INT = DATEDIFF(DAY, @HanTra, @NgayTra);
            DECLARE @TienPhat DECIMAL(18,2) = @SoNgayTre * 5000 * @SoLuong;
            
            INSERT INTO PHAT (MaPhieuMuon, LyDo, SoTienPhat, NgayPhat)
            VALUES (@MaPhieuMuon, N'Trả sách trễ hạn ' + CAST(@SoNgayTre AS NVARCHAR) + N' ngày', 
                    @TienPhat, @NgayTra);
                    
            PRINT N'Trả sách thành công! Phạt trễ hạn: ' + CAST(@TienPhat AS NVARCHAR) + N' VNĐ';
        END
        ELSE
        BEGIN
            PRINT N'Trả sách thành công!';
        END
        
        -- Kiểm tra xem tất cả sách trong phiếu đã trả chưa
        IF NOT EXISTS (SELECT 1 FROM CHI_TIET_PHIEU_MUON WHERE MaPhieuMuon = @MaPhieuMuon AND NgayTra IS NULL)
        BEGIN
            UPDATE PHIEU_MUON
            SET TrangThai = N'Đã trả',
                NgayTraThucTe = @NgayTra
            WHERE MaPhieuMuon = @MaPhieuMuon;
        END
        
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
        PRINT ERROR_MESSAGE();
        THROW;
    END CATCH
END
GO

-- =============================================
-- SP: Xem sách quá hạn
-- =============================================
IF OBJECT_ID('sp_XemSachQuaHan', 'P') IS NOT NULL
    DROP PROCEDURE sp_XemSachQuaHan;
GO

CREATE PROCEDURE sp_XemSachQuaHan
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        pm.MaPhieuMuon,
        dg.MaDocGia,
        dg.HoTen AS TenDocGia,
        dg.SoDienThoai,
        s.MaSach,
        s.TenSach,
        pm.NgayMuon,
        pm.HanTra,
        DATEDIFF(DAY, pm.HanTra, GETDATE()) AS SoNgayTre,
        DATEDIFF(DAY, pm.HanTra, GETDATE()) * 5000 AS TienPhat
    FROM PHIEU_MUON pm
    INNER JOIN DOC_GIA dg ON pm.MaDocGia = dg.MaDocGia
    INNER JOIN CHI_TIET_PHIEU_MUON ct ON pm.MaPhieuMuon = ct.MaPhieuMuon
    INNER JOIN SACH s ON ct.MaSach = s.MaSach
    WHERE pm.TrangThai = N'Đang mượn'
      AND pm.HanTra < GETDATE()
      AND ct.NgayTra IS NULL
    ORDER BY pm.HanTra;
END
GO

PRINT 'Stored procedures for MUON_TRA created successfully!';
GO
