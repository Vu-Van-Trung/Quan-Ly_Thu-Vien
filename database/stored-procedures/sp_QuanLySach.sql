-- =============================================
-- STORED PROCEDURES - QUẢN LÝ SÁCH
-- =============================================

USE QuanLyThuVien;
GO

-- =============================================
-- SP: Tìm kiếm sách nâng cao
-- =============================================
IF OBJECT_ID('sp_TimKiemSach', 'P') IS NOT NULL
    DROP PROCEDURE sp_TimKiemSach;
GO

CREATE PROCEDURE sp_TimKiemSach
    @TuKhoa NVARCHAR(200) = NULL,
    @MaTheLoai INT = NULL,
    @MaTacGia INT = NULL,
    @NamXuatBan INT = NULL,
    @TrangThai NVARCHAR(50) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        s.MaSach,
        s.TenSach,
        tg.TenTacGia,
        tl.TenTheLoai,
        nxb.TenNhaXuatBan,
        s.NamXuatBan,
        s.SoLuongTon,
        s.ViTri,
        s.TrangThai,
        s.GiaTien
    FROM SACH s
    INNER JOIN TAC_GIA tg ON s.MaTacGia = tg.MaTacGia
    INNER JOIN THE_LOAI tl ON s.MaTheLoai = tl.MaTheLoai
    INNER JOIN NHA_XUAT_BAN nxb ON s.MaNhaXuatBan = nxb.MaNhaXuatBan
    WHERE 
        (@TuKhoa IS NULL OR s.TenSach LIKE N'%' + @TuKhoa + '%')
        AND (@MaTheLoai IS NULL OR s.MaTheLoai = @MaTheLoai)
        AND (@MaTacGia IS NULL OR s.MaTacGia = @MaTacGia)
        AND (@NamXuatBan IS NULL OR s.NamXuatBan = @NamXuatBan)
        AND (@TrangThai IS NULL OR s.TrangThai = @TrangThai)
    ORDER BY s.TenSach;
END
GO

-- =============================================
-- SP: Thêm sách mới
-- =============================================
IF OBJECT_ID('sp_ThemSach', 'P') IS NOT NULL
    DROP PROCEDURE sp_ThemSach;
GO

CREATE PROCEDURE sp_ThemSach
    @MaSach VARCHAR(20),
    @TenSach NVARCHAR(200),
    @MaTacGia INT,
    @MaTheLoai INT,
    @MaNhaXuatBan INT,
    @NamXuatBan INT = NULL,
    @SoLuongTon INT = 0,
    @ViTri NVARCHAR(50) = NULL,
    @MoTa NVARCHAR(MAX) = NULL,
    @GiaTien DECIMAL(18,2) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        -- Kiểm tra mã sách đã tồn tại
        IF EXISTS (SELECT 1 FROM SACH WHERE MaSach = @MaSach)
        BEGIN
            RAISERROR (N'Mã sách đã tồn tại!', 16, 1);
            RETURN;
        END
        
        INSERT INTO SACH (MaSach, TenSach, MaTacGia, MaTheLoai, MaNhaXuatBan, 
                         NamXuatBan, SoLuongTon, ViTri, MoTa, GiaTien)
        VALUES (@MaSach, @TenSach, @MaTacGia, @MaTheLoai, @MaNhaXuatBan, 
                @NamXuatBan, @SoLuongTon, @ViTri, @MoTa, @GiaTien);
        
        PRINT N'Thêm sách thành công!';
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE();
        THROW;
    END CATCH
END
GO

-- =============================================
-- SP: Cập nhật tồn kho sách
-- =============================================
IF OBJECT_ID('sp_CapNhatTonKho', 'P') IS NOT NULL
    DROP PROCEDURE sp_CapNhatTonKho;
GO

CREATE PROCEDURE sp_CapNhatTonKho
    @MaSach VARCHAR(20),
    @SoLuongThayDoi INT  -- Dương: nhập thêm, Âm: xuất
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @SoLuongHienTai INT;
        
        SELECT @SoLuongHienTai = SoLuongTon 
        FROM SACH WITH (UPDLOCK)
        WHERE MaSach = @MaSach;
        
        IF @SoLuongHienTai IS NULL
        BEGIN
            ROLLBACK;
            RAISERROR (N'Không tìm thấy sách!', 16, 1);
            RETURN;
        END
        
        IF (@SoLuongHienTai + @SoLuongThayDoi) < 0
        BEGIN
            ROLLBACK;
            RAISERROR (N'Số lượng tồn kho không đủ!', 16, 1);
            RETURN;
        END
        
        UPDATE SACH
        SET SoLuongTon = SoLuongTon + @SoLuongThayDoi
        WHERE MaSach = @MaSach;
        
        COMMIT;
        PRINT N'Cập nhật tồn kho thành công!';
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK;
        PRINT ERROR_MESSAGE();
        THROW;
    END CATCH
END
GO

PRINT 'Stored procedures for SACH created successfully!';
GO
