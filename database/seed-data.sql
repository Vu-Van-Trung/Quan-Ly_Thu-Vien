-- =============================================
-- DỮ LIỆU MẪU CHO HỆ THỐNG QUẢN LÝ THƯ VIỆN
-- Seed Data Script
-- Version: 1.0
-- Date: 19/12/2025
-- =============================================

USE QuanLyThuVien;
GO

-- =============================================
-- 1. TÁC GIẢ (Authors)
-- =============================================
SET IDENTITY_INSERT TAC_GIA ON;

INSERT INTO TAC_GIA (MaTacGia, TenTacGia, NgaySinh, QuocTich, TieuSu) VALUES
(1, N'Nguyễn Nhật Ánh', '1955-05-07', N'Việt Nam', N'Nhà văn nổi tiếng với các tác phẩm văn học thiếu nhi'),
(2, N'Nam Cao', '1915-10-29', N'Việt Nam', N'Nhà văn hiện thực xuất sắc của văn học Việt Nam'),
(3, N'Tô Hoài', '1920-09-27', N'Việt Nam', N'Nhà văn với nhiều tác phẩm về thiên nhiên và con người'),
(4, N'J.K. Rowling', '1965-07-31', N'Anh', N'Tác giả của series Harry Potter nổi tiếng thế giới'),
(5, N'Haruki Murakami', '1949-01-12', N'Nhật Bản', N'Nhà văn hiện đại với phong cách độc đáo'),
(6, N'Ngô Tất Tố', '1894-11-11', N'Việt Nam', N'Tác giả của Tắt đèn - kiệt tác văn học Việt Nam'),
(7, N'Paulo Coelho', '1947-08-24', N'Brazil', N'Tác giả của Nhà giả kim và nhiều tác phẩm triết lý'),
(8, N'Gabriel García Márquez', '1927-03-06', N'Colombia', N'Nhà văn đoạt giải Nobel văn học'),
(9, N'Nguyễn Du', '1766-01-03', N'Việt Nam', N'Tác giả của Truyện Kiều - tác phẩm bất hủ'),
(10, N'Antoine de Saint-Exupéry', '1900-06-29', N'Pháp', N'Tác giả của Hoàng tử bé');

SET IDENTITY_INSERT TAC_GIA OFF;
GO

-- =============================================
-- 2. THỂ LOẠI (Categories)
-- =============================================
SET IDENTITY_INSERT THE_LOAI ON;

INSERT INTO THE_LOAI (MaTheLoai, TenTheLoai, MoTa) VALUES
(1, N'Văn học Việt Nam', N'Các tác phẩm văn học của tác giả Việt Nam'),
(2, N'Văn học nước ngoài', N'Các tác phẩm văn học dịch từ nước ngoài'),
(3, N'Tiểu thuyết', N'Sách tiểu thuyết các thể loại'),
(4, N'Thiếu nhi', N'Sách dành cho trẻ em và thiếu niên'),
(5, N'Khoa học công nghệ', N'Sách về khoa học, công nghệ, lập trình'),
(6, N'Kinh tế - Kinh doanh', N'Sách về kinh tế, quản trị, kinh doanh'),
(7, N'Lịch sử', N'Sách về lịch sử Việt Nam và thế giới'),
(8, N'Tâm lý - Kỹ năng sống', N'Sách phát triển bản thân'),
(9, N'Truyện tranh - Manga', N'Truyện tranh Nhật Bản, Hàn Quốc...'),
(10, N'Giáo trình', N'Sách giáo khoa, tài liệu học tập');

SET IDENTITY_INSERT THE_LOAI OFF;
GO

-- =============================================
-- 3. NHÀ XUẤT BẢN (Publishers)
-- =============================================
SET IDENTITY_INSERT NHA_XUAT_BAN ON;

INSERT INTO NHA_XUAT_BAN (MaNhaXuatBan, TenNhaXuatBan, DiaChi, SoDienThoai, Email) VALUES
(1, N'NXB Trẻ', N'161B Lý Chính Thắng, Q.3, TP.HCM', '028-39316211', 'info@nxbtre.com.vn'),
(2, N'NXB Kim Đồng', N'55 Quang Trung, Hà Nội', '024-39434730', 'info@nxbkimdong.com.vn'),
(3, N'NXB Văn học', N'18 Nguyễn Trường Tộ, Hà Nội', '024-38222913', 'info@nxbvanhoc.com.vn'),
(4, N'NXB Thế giới', N'7 Nguyễn Thị Minh Khai, Hà Nội', '024-39717979', 'info@thegioipublishers.vn'),
(5, N'NXB Lao động', N'175 Giảng Võ, Hà Nội', '024-38514791', 'nxblaodong@hn.vnn.vn'),
(6, N'NXB Đại học Quốc Gia', N'16 Hàng Chuối, Hà Nội', '024-38695938', 'info@nxb.hust.edu.vn'),
(7, N'NXB Tổng hợp TP.HCM', N'62 Nguyễn Thị Minh Khai, Q.1, TP.HCM', '028-38225340', 'nstonghop@hcm.vnn.vn'),
(8, N'NXB Hội Nhà văn', N'65 Nguyễn Du, Hà Nội', '024-39432668', 'nxbhnv@hn.vnn.vn'),
(9, N'NXB Phụ nữ', N'39 Hàng Chuối, Hà Nội', '024-39710717', 'info@nxbphunu.com.vn'),
(10, N'NXB Hà Nội', N'3 Hồ Gươm, Hà Nội', '024-38253841', 'info@nxbhanoi.com.vn');

SET IDENTITY_INSERT NHA_XUAT_BAN OFF;
GO

-- =============================================
-- 4. NHÂN VIÊN (Staff)
-- =============================================
SET IDENTITY_INSERT NHAN_VIEN ON;

INSERT INTO NHAN_VIEN (MaNhanVien, HoTen, ChucVu, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, NgayVaoLam) VALUES
(1, N'Vũ Văn Trung', N'Quản trị viên', '1990-05-15', N'Nam', N'Hà Nội', '0912345678', 'admin@thuvien.vn', '2020-01-01'),
(2, N'Nguyễn Thị Mai', N'Thủ thư trưởng', '1988-08-20', N'Nữ', N'Hà Nội', '0912345679', 'mai.nguyen@thuvien.vn', '2020-02-01'),
(3, N'Trần Văn Hùng', N'Nhân viên', '1995-03-10', N'Nam', N'Hà Nội', '0912345680', 'hung.tran@thuvien.vn', '2021-06-15'),
(4, N'Lê Thị Hoa', N'Nhân viên', '1992-11-25', N'Nữ', N'Hà Nội', '0912345681', 'hoa.le@thuvien.vn', '2021-09-01'),
(5, N'Phạm Minh Tuấn', N'Nhân viên', '1993-07-08', N'Nam', N'Hà Nội', '0912345682', 'tuan.pham@thuvien.vn', '2022-01-10');

SET IDENTITY_INSERT NHAN_VIEN OFF;
GO

-- =============================================
-- 5. TÀI KHOẢN (User Accounts)
-- Note: Password là "123456" đã được hash (trong thực tế nên dùng BCrypt)
-- =============================================
SET IDENTITY_INSERT TAI_KHOAN ON;

INSERT INTO TAI_KHOAN (MaTaiKhoan, TenDangNhap, MatKhau, MaNhanVien, QuyenHan, TrangThai) VALUES
(1, 'admin', 'pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=', 1, N'Quản trị viên', N'Hoạt động'),
(2, 'thuthu01', 'pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=', 2, N'Thủ thư', N'Hoạt động'),
(3, 'nhanvien01', 'pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=', 3, N'Nhân viên', N'Hoạt động'),
(4, 'nhanvien02', 'pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=', 4, N'Nhân viên', N'Hoạt động'),
(5, 'nhanvien03', 'pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=', 5, N'Nhân viên', N'Hoạt động');

SET IDENTITY_INSERT TAI_KHOAN OFF;
GO

-- =============================================
-- 6. ĐỘC GIẢ (Readers)
-- =============================================
INSERT INTO DOC_GIA (MaDocGia, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, CMND, NgayDangKy, NgayHetHan, TrangThai) VALUES
('DG001', N'Nguyễn Văn An', '2000-01-15', N'Nam', N'Hà Nội', '0901234567', 'an.nguyen@email.com', '001234567890', '2024-01-01', '2025-01-01', N'Hoạt động'),
('DG002', N'Trần Thị Bình', '1998-05-20', N'Nữ', N'Hà Nội', '0901234568', 'binh.tran@email.com', '001234567891', '2024-01-05', '2025-01-05', N'Hoạt động'),
('DG003', N'Lê Minh Cường', '2002-08-10', N'Nam', N'Hà Nội', '0901234569', 'cuong.le@email.com', '001234567892', '2024-02-01', '2025-02-01', N'Hoạt động'),
('DG004', N'Phạm Thị Dung', '1999-12-25', N'Nữ', N'Hà Nội', '0901234570', 'dung.pham@email.com', '001234567893', '2024-02-15', '2025-02-15', N'Hoạt động'),
('DG005', N'Hoàng Văn Em', '2001-03-30', N'Nam', N'Hà Nội', '0901234571', 'em.hoang@email.com', '001234567894', '2024-03-01', '2025-03-01', N'Hoạt động'),
('DG006', N'Đỗ Thị Phượng', '2003-06-15', N'Nữ', N'Hà Nội', '0901234572', 'phuong.do@email.com', '001234567895', '2024-03-10', '2025-03-10', N'Hoạt động'),
('DG007', N'Vũ Văn Giang', '2000-09-05', N'Nam', N'Hà Nội', '0901234573', 'giang.vu@email.com', '001234567896', '2024-04-01', '2025-04-01', N'Hoạt động'),
('DG008', N'Bùi Thị Hương', '1997-11-20', N'Nữ', N'Hà Nội', '0901234574', 'huong.bui@email.com', '001234567897', '2024-04-15', '2025-04-15', N'Hoạt động'),
('DG009', N'Đinh Văn Inh', '2002-02-28', N'Nam', N'Hà Nội', '0901234575', 'inh.dinh@email.com', '001234567898', '2024-05-01', '2025-05-01', N'Hoạt động'),
('DG010', N'Ngô Thị Khánh', '2001-07-12', N'Nữ', N'Hà Nội', '0901234576', 'khanh.ngo@email.com', '001234567899', '2024-05-10', '2025-05-10', N'Hoạt động');
GO

-- =============================================
-- 7. SÁCH (Books)
-- =============================================
INSERT INTO SACH (MaSach, TenSach, MaTacGia, MaTheLoai, MaNhaXuatBan, NamXuatBan, SoLuongTon, ViTri, TrangThai, MoTa, GiaTien) VALUES
('S001', N'Cho tôi xin một vé đi tuổi thơ', 1, 4, 1, 2014, 10, 'A1-01', N'Có sẵn', N'Truyện về tuổi thơ của Nguyễn Nhật Ánh', 80000),
('S002', N'Mắt biếc', 1, 3, 1, 2010, 8, 'A1-02', N'Có sẵn', N'Câu chuyện tình yêu đẹp và buồn', 95000),
('S003', N'Chí Phèo', 2, 1, 3, 2015, 15, 'A2-01', N'Có sẵn', N'Tác phẩm kinh điển của Nam Cao', 50000),
('S004', N'Dế Mèn phiêu lưu ký', 3, 4, 2, 2016, 12, 'B1-01', N'Có sẵn', N'Truyện thiếu nhi kinh điển', 65000),
('S005', N'Harry Potter và Hòn đá Phù thủy', 4, 2, 1, 2017, 20, 'C1-01', N'Có sẵn', N'Phần 1 của series Harry Potter', 150000),
('S006', N'Harry Potter và Phòng chứa Bí mật', 4, 2, 1, 2017, 18, 'C1-02', N'Có sẵn', N'Phần 2 của series Harry Potter', 170000),
('S007', N'Rừng Na Uy', 5, 2, 4, 2018, 10, 'C2-01', N'Có sẵn', N'Tiểu thuyết nổi tiếng của Murakami', 120000),
('S008', N'Kafka bên bờ biển', 5, 2, 4, 2019, 8, 'C2-02', N'Có sẵn', N'Một trong những tác phẩm hay nhất của Murakami', 140000),
('S009', N'Tắt đèn', 6, 1, 3, 2015, 20, 'A2-02', N'Có sẵn', N'Kiệt tác văn học Việt Nam', 60000),
('S010', N'Nhà giả kim', 7, 2, 4, 2020, 25, 'D1-01', N'Có sẵn', N'Cuốn sách triết lý nổi tiếng thế giới', 90000),
('S011', N'Truyện Kiều', 9, 1, 3, 2016, 30, 'A3-01', N'Có sẵn', N'Tác phẩm bất hủ của Nguyễn Du', 45000),
('S012', N'Hoàng tử bé', 10, 4, 1, 2018, 15, 'B1-02', N'Có sẵn', N'Câu chuyện đẹp về tình yêu và trách nhiệm', 75000),
('S013', N'Tôi thấy hoa vàng trên cỏ xanh', 1, 3, 1, 2013, 12, 'A1-03', N'Có sẵn', N'Truyện về tình anh em và tuổi thơ', 100000),
('S014', N'Lão Hạc', 2, 1, 3, 2015, 18, 'A2-03', N'Có sẵn', N'Truyện ngắn cảm động của Nam Cao', 40000),
('S015', N'Đồi gió hú', 8, 2, 4, 2019, 6, 'C3-01', N'Có sẵn', N'Tiểu thuyết nổi tiếng thế giới', 110000);
GO

-- =============================================
-- 8. PHIẾU MƯỢN MẪU (Sample Borrow Receipts)
-- =============================================
INSERT INTO PHIEU_MUON (MaPhieuMuon, MaDocGia, MaNhanVien, NgayMuon, HanTra, TrangThai, GhiChu) VALUES
('PM001', 'DG001', 2, '2024-12-01', '2024-12-15', N'Đã trả', N'Trả đúng hạn'),
('PM002', 'DG002', 3, '2024-12-05', '2024-12-19', N'Đang mượn', N''),
('PM003', 'DG003', 2, '2024-12-10', '2024-12-24', N'Đang mượn', N''),
('PM004', 'DG001', 4, '2024-12-15', '2024-12-29', N'Đang mượn', N'Gia hạn 1 lần');
GO

-- =============================================
-- 9. CHI TIẾT PHIẾU MƯỢN (Borrow Details)
-- =============================================
SET IDENTITY_INSERT CHI_TIET_PHIEU_MUON ON;

INSERT INTO CHI_TIET_PHIEU_MUON (MaChiTiet, MaPhieuMuon, MaSach, SoLuong, TinhTrangMuon, TinhTrangTra, NgayTra) VALUES
(1, 'PM001', 'S001', 1, N'Tốt', N'Tốt', '2024-12-14'),
(2, 'PM001', 'S002', 1, N'Tốt', N'Tốt', '2024-12-14'),
(3, 'PM002', 'S005', 1, N'Tốt', NULL, NULL),
(4, 'PM002', 'S006', 1, N'Tốt', NULL, NULL),
(5, 'PM003', 'S010', 1, N'Tốt', NULL, NULL),
(6, 'PM003', 'S012', 1, N'Tốt', NULL, NULL),
(7, 'PM003', 'S013', 1, N'Tốt', NULL, NULL),
(8, 'PM004', 'S007', 1, N'Tốt', NULL, NULL);

SET IDENTITY_INSERT CHI_TIET_PHIEU_MUON OFF;
GO

-- =============================================
-- 10. PHẠT MẪU (Sample Fines)
-- =============================================
SET IDENTITY_INSERT PHAT ON;

INSERT INTO PHAT (MaPhat, MaPhieuMuon, LyDo, SoTienPhat, NgayPhat, TrangThaiThanhToan, NgayThanhToan) VALUES
(1, 'PM001', N'Không có phạt', 0, '2024-12-14', N'Đã thanh toán', '2024-12-14');

SET IDENTITY_INSERT PHAT OFF;
GO

PRINT 'Seed data inserted successfully!';
PRINT 'Tác giả: 10 | Thể loại: 10 | Nhà xuất bản: 10';
PRINT 'Nhân viên: 5 | Tài khoản: 5 | Độc giả: 10';
PRINT 'Sách: 15 | Phiếu mượn: 4 | Chi tiết: 8';
GO
