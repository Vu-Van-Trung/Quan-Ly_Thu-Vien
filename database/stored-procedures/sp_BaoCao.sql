-- =============================================
-- STORED PROCEDURES - BÁO CÁO & THỐNG KÊ
-- =============================================

USE QuanLyThuVien;
GO

-- =============================================
-- SP: Thống kê sách được mượn nhiều nhất
-- =============================================
IF OBJECT_ID('sp_SachMuonNhieuNhat', 'P') IS NOT NULL
    DROP PROCEDURE sp_SachMuonNhieuNhat;
GO

CREATE PROCEDURE sp_SachMuonNhieuNhat
    @TopN INT = 10,
    @TuNgay DATETIME = NULL,
    @DenNgay DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SET @TuNgay = ISNULL(@TuNgay, DATEADD(MONTH, -3, GETDATE()));
    SET @DenNgay = ISNULL(@DenNgay, GETDATE());
    
    SELECT TOP (@TopN)
        s.MaSach,
        s.TenSach,
        tg.TenTacGia,
        tl.TenTheLoai,
        COUNT(*) AS SoLanMuon,
        SUM(ct.SoLuong) AS TongSoLuongMuon
    FROM SACH s
    INNER JOIN TAC_GIA tg ON s.MaTacGia = tg.MaTacGia
    INNER JOIN THE_LOAI tl ON s.MaTheLoai = tl.MaTheLoai
    INNER JOIN CHI_TIET_PHIEU_MUON ct ON s.MaSach = ct.MaSach
    INNER JOIN PHIEU_MUON pm ON ct.MaPhieuMuon = pm.MaPhieuMuon
    WHERE pm.NgayMuon BETWEEN @TuNgay AND @DenNgay
    GROUP BY s.MaSach, s.TenSach, tg.TenTacGia, tl.TenTheLoai
    ORDER BY SoLanMuon DESC, TongSoLuongMuon DESC;
END
GO

-- =============================================
-- SP: Thống kê theo thể loại
-- =============================================
IF OBJECT_ID('sp_ThongKeTheoTheLoai', 'P') IS NOT NULL
    DROP PROCEDURE sp_ThongKeTheoTheLoai;
GO

CREATE PROCEDURE sp_ThongKeTheoTheLoai
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        tl.TenTheLoai,
        COUNT(DISTINCT s.MaSach) AS SoLuongSach,
        SUM(s.SoLuongTon) AS TongTonKho,
        ISNULL(COUNT(DISTINCT ct.MaChiTiet), 0) AS SoLanMuon
    FROM THE_LOAI tl
    LEFT JOIN SACH s ON tl.MaTheLoai = s.MaTheLoai
    LEFT JOIN CHI_TIET_PHIEU_MUON ct ON s.MaSach = ct.MaSach
    GROUP BY tl.TenTheLoai
    ORDER BY SoLuongSach DESC;
END
GO

-- =============================================
-- SP: Độc giả tích cực nhất
-- =============================================
IF OBJECT_ID('sp_DocGiaTichCuc', 'P') IS NOT NULL
    DROP PROCEDURE sp_DocGiaTichCuc;
GO

CREATE PROCEDURE sp_DocGiaTichCuc
    @TopN INT = 10,
    @TuNgay DATETIME = NULL,
    @DenNgay DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SET @TuNgay = ISNULL(@TuNgay, DATEADD(MONTH, -3, GETDATE()));
    SET @DenNgay = ISNULL(@DenNgay, GETDATE());
    
    SELECT TOP (@TopN)
        dg.MaDocGia,
        dg.HoTen,
        dg.SoDienThoai,
        COUNT(DISTINCT pm.MaPhieuMuon) AS SoPhieuMuon,
        SUM(ct.SoLuong) AS TongSachMuon,
        ISNULL(SUM(p.SoTienPhat), 0) AS TongTienPhat
    FROM DOC_GIA dg
    INNER JOIN PHIEU_MUON pm ON dg.MaDocGia = pm.MaDocGia
    INNER JOIN CHI_TIET_PHIEU_MUON ct ON pm.MaPhieuMuon = ct.MaPhieuMuon
    LEFT JOIN PHAT p ON pm.MaPhieuMuon = p.MaPhieuMuon
    WHERE pm.NgayMuon BETWEEN @TuNgay AND @DenNgay
    GROUP BY dg.MaDocGia, dg.HoTen, dg.SoDienThoai
    ORDER BY TongSachMuon DESC;
END
GO

-- =============================================
-- SP: Báo cáo doanh thu phạt
-- =============================================
IF OBJECT_ID('sp_BaoCaoDoanhThu', 'P') IS NOT NULL
    DROP PROCEDURE sp_BaoCaoDoanhThu;
GO

CREATE PROCEDURE sp_BaoCaoDoanhThu
    @TuNgay DATETIME = NULL,
    @DenNgay DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SET @TuNgay = ISNULL(@TuNgay, DATEADD(MONTH, -1, GETDATE()));
    SET @DenNgay = ISNULL(@DenNgay, GETDATE());
    
    SELECT 
        COUNT(*) AS SoLuongPhat,
        SUM(SoTienPhat) AS TongTienPhat,
        SUM(CASE WHEN TrangThaiThanhToan = N'Đã thanh toán' THEN SoTienPhat ELSE 0 END) AS DaThanhToan,
        SUM(CASE WHEN TrangThaiThanhToan = N'Chưa thanh toán' THEN SoTienPhat ELSE 0 END) AS ChuaThanhToan
    FROM PHAT
    WHERE NgayPhat BETWEEN @TuNgay AND @DenNgay;
    
    -- Chi tiết theo loại phạt
    SELECT 
        LyDo,
        COUNT(*) AS SoLuong,
        SUM(SoTienPhat) AS TongTien
    FROM PHAT
    WHERE NgayPhat BETWEEN @TuNgay AND @DenNgay
    GROUP BY LyDo
    ORDER BY TongTien DESC;
END
GO

-- =============================================
-- SP: Báo cáo tồn kho
-- =============================================
IF OBJECT_ID('sp_BaoCaoTonKho', 'P') IS NOT NULL
    DROP PROCEDURE sp_BaoCaoTonKho;
GO

CREATE PROCEDURE sp_BaoCaoTonKho
    @MaTheLoai INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        s.MaSach,
        s.TenSach,
        tl.TenTheLoai,
        s.SoLuongTon,
        s.ViTri,
        s.TrangThai,
        CASE 
            WHEN s.SoLuongTon = 0 THEN N'Hết sách'
            WHEN s.SoLuongTon <= 5 THEN N'Sắp hết'
            ELSE N'Đủ'
        END AS CanhBao
    FROM SACH s
    INNER JOIN THE_LOAI tl ON s.MaTheLoai = tl.MaTheLoai
    WHERE (@MaTheLoai IS NULL OR s.MaTheLoai = @MaTheLoai)
    ORDER BY s.SoLuongTon ASC, s.TenSach;
END
GO

PRINT 'Stored procedures for REPORTS created successfully!';
GO
