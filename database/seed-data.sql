-- =============================================
-- DỮ LIỆU MẪU CHO HỆ THỐNG QUẢN LÝ THƯ VIỆN
-- Seed Data Script
-- Version: 1.5
-- Date: 03/01/2026
-- Author: Vũ Văn Trung
-- =============================================

USE QuanLyThuVien;
GO

PRINT '============================================='
PRINT 'Starting seed data insertion...'
PRINT '============================================='

-- =============================================
-- 1. TÁC GIẢ (Authors)
-- =============================================
PRINT 'Inserting Authors...';
SET IDENTITY_INSERT TAC_GIA ON;

INSERT INTO TAC_GIA (MaTacGia, TenTacGia, NgaySinh, QuocTich, TieuSu, NgayTao, NgayCapNhat) VALUES
(1, N'Nguyễn Nhật Ánh', '1955-05-07', N'Việt Nam', N'Nhà văn nổi tiếng với các tác phẩm văn học thiếu nhi và tuổi trẻ', GETDATE(), GETDATE()),
(2, N'Nam Cao', '1915-10-29', N'Việt Nam', N'Nhà văn hiện thực xuất sắc của văn học Việt Nam hiện đại', GETDATE(), GETDATE()),
(3, N'Tô Hoài', '1920-09-27', N'Việt Nam', N'Nhà văn với nhiều tác phẩm về thiên nhiên và con người', GETDATE(), GETDATE()),
(4, N'J.K. Rowling', '1965-07-31', N'Anh', N'Tác giả của series Harry Potter nổi tiếng thế giới', GETDATE(), GETDATE()),
(5, N'Haruki Murakami', '1949-01-12', N'Nhật Bản', N'Nhà văn hiện đại với phong cách độc đáo, huyền ảo', GETDATE(), GETDATE()),
(6, N'Ngô Tất Tố', '1894-11-11', N'Việt Nam', N'Tác giả của Tắt đèn - kiệt tác văn học Việt Nam', GETDATE(), GETDATE()),
(7, N'Paulo Coelho', '1947-08-24', N'Brazil', N'Tác giả của Nhà giả kim và nhiều tác phẩm triết lý nổi tiếng', GETDATE(), GETDATE()),
(8, N'Gabriel García Márquez', '1927-03-06', N'Colombia', N'Nhà văn đoạt giải Nobel văn học 1982', GETDATE(), GETDATE()),
(9, N'Nguyễn Du', '1766-01-03', N'Việt Nam', N'Đại thi hào - Tác giả của Truyện Kiều', GETDATE(), GETDATE()),
(10, N'Antoine de Saint-Exupéry', '1900-06-29', N'Pháp', N'Phi công và nhà văn - Tác giả của Hoàng tử bé', GETDATE(), GETDATE()),
(11, N'Nguyễn Ngọc Tư', '1976-08-01', N'Việt Nam', N'Nhà văn nữ đương đại nổi tiếng', GETDATE(), GETDATE()),
(12, N'Vũ Trọng Phụng', '1912-10-20', N'Việt Nam', N'Nhà văn hiện thực phê phán', GETDATE(), GETDATE()),
(13, N'Dan Brown', '1964-06-22', N'Mỹ', N'Tác giả của The Da Vinci Code', GETDATE(), GETDATE()),
(14, N'Yuval Noah Harari', '1976-02-24', N'Israel', N'Sử học và triết học', GETDATE(), GETDATE()),
(15, N'Dale Carnegie', '1888-11-24', N'Mỹ', N'Chuyên gia về kỹ năng giao tiếp và phát triển bản thân', GETDATE(), GETDATE());

SET IDENTITY_INSERT TAC_GIA OFF;
PRINT '  ✓ Inserted 15 authors';
GO

-- =============================================
-- 2. THỂ LOẠI (Categories)
-- =============================================
PRINT 'Inserting Categories...';
SET IDENTITY_INSERT THE_LOAI ON;

INSERT INTO THE_LOAI (MaTheLoai, TenTheLoai, MoTa, NgayTao) VALUES
(1, N'Văn học Việt Nam', N'Các tác phẩm văn học của tác giả Việt Nam', GETDATE()),
(2, N'Văn học nước ngoài', N'Các tác phẩm văn học dịch từ nước ngoài', GETDATE()),
(3, N'Tiểu thuyết', N'Sách tiểu thuyết các thể loại', GETDATE()),
(4, N'Thiếu nhi', N'Sách dành cho trẻ em và thiếu niên', GETDATE()),
(5, N'Khoa học công nghệ', N'Sách về khoa học, công nghệ, lập trình, AI', GETDATE()),
(6, N'Kinh tế - Kinh doanh', N'Sách về kinh tế, quản trị, khởi nghiệp', GETDATE()),
(7, N'Lịch sử', N'Sách về lịch sử Việt Nam và thế giới', GETDATE()),
(8, N'Tâm lý - Kỹ năng sống', N'Sách phát triển bản thân và kỹ năng mềm', GETDATE()),
(9, N'Triết học - Tôn giáo', N'Sách về triết học, tôn giáo, tâm linh', GETDATE()),
(10, N'Giáo trình', N'Sách giáo khoa, tài liệu học tập', GETDATE()),
(11, N'Fantasy - Phiêu lưu', N'Sách viễn tưởng, phép thuật, phiêu lưu', GETDATE()),
(12, N'Trinh thám - Bí ẩn', N'Truyện trinh thám, giải mã', GETDATE());

SET IDENTITY_INSERT THE_LOAI OFF;
PRINT '  ✓ Inserted 12 categories';
GO

-- =============================================
-- 3. NHÀ XUẤT BẢN (Publishers)
-- =============================================
PRINT 'Inserting Publishers...';
SET IDENTITY_INSERT NHA_XUAT_BAN ON;

INSERT INTO NHA_XUAT_BAN (MaNhaXuatBan, TenNhaXuatBan, DiaChi, SoDienThoai, Email, NgayTao, NgayCapNhat) VALUES
(1, N'NXB Trẻ', N'161B Lý Chính Thắng, Quận 3, TP.HCM', '028-39316211', 'info@nxbtre.com.vn', GETDATE(), GETDATE()),
(2, N'NXB Kim Đồng', N'55 Quang Trung, Hai Bà Trưng, Hà Nội', '024-39434730', 'info@nxbkimdong.com.vn', GETDATE(), GETDATE()),
(3, N'NXB Văn học', N'18 Nguyễn Trường Tộ, Ba Đình, Hà Nội', '024-38222913', 'info@nxbvanhoc.com.vn', GETDATE(), GETDATE()),
(4, N'NXB Thế giới', N'7 Nguyễn Thị Minh Khai, Hai Bà Trưng, Hà Nội', '024-39717979', 'info@thegioipublishers.vn', GETDATE(), GETDATE()),
(5, N'NXB Lao động', N'175 Giảng Võ, Đống Đa, Hà Nội', '024-38514791', 'nxblaodong@hn.vnn.vn', GETDATE(), GETDATE()),
(6, N'NXB Đại học Quốc Gia', N'16 Hàng Chuối, Hai Bà Trưng, Hà Nội', '024-38695938', 'info@nxbdhqg.edu.vn', GETDATE(), GETDATE()),
(7, N'NXB Tổng hợp TP.HCM', N'62 Nguyễn Thị Minh Khai, Quận 1, TP.HCM', '028-38225340', 'nstonghop@hcm.vnn.vn', GETDATE(), GETDATE()),
(8, N'NXB Hội Nhà văn', N'65 Nguyễn Du, Hai Bà Trưng, Hà Nội', '024-39432668', 'nxbhnv@hn.vnn.vn', GETDATE(), GETDATE()),
(9, N'NXB First News', N'Toà nhà A&B Tower, 76A Lê Lai, Quận 1, TP.HCM', '028-62731616', 'info@firstnews.com.vn', GETDATE(), GETDATE()),
(10, N'NXB Dân trí', N'365 Lê Hồng Phong, Quận 10, TP.HCM', '028-38358585', 'info@nxbdantri.com.vn', GETDATE(), GETDATE());

SET IDENTITY_INSERT NHA_XUAT_BAN OFF;
PRINT '  ✓ Inserted 10 publishers';
GO

-- =============================================
-- 4. NHÂN VIÊN (Staff)
-- =============================================
PRINT 'Inserting Staff...';
SET IDENTITY_INSERT NHAN_VIEN ON;

INSERT INTO NHAN_VIEN (MaNhanVien, HoTen, ChucVu, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, NgayVaoLam, TrangThai, NgayTao) VALUES
(1, N'Vũ Văn Trung', N'Quản trị viên', '1990-05-15', N'Nam', N'Số 123, Đường Giải Phóng, Hai Bà Trưng, Hà Nội', '0912345678', 'trung.vu@thuvien.vn', '2020-01-01', N'Đang làm việc', GETDATE()),
(2, N'Nguyễn Thị Mai', N'Thủ thư trưởng', '1988-08-20', N'Nữ', N'Số 45, Phố Huế, Hai Bà Trưng, Hà Nội', '0912345679', 'mai.nguyen@thuvien.vn', '2020-02-01', N'Đang làm việc', GETDATE()),
(3, N'Trần Văn Hùng', N'Thủ thư', '1995-03-10', N'Nam', N'Số 67, Nguyễn Lương Bằng, Đống Đa, Hà Nội', '0912345680', 'hung.tran@thuvien.vn', '2021-06-15', N'Đang làm việc', GETDATE()),
(4, N'Lê Thị Hoa', N'Nhân viên', '1992-11-25', N'Nữ', N'Số 89, Láng Hạ, Ba Đình, Hà Nội', '0912345681', 'hoa.le@thuvien.vn', '2021-09-01', N'Đang làm việc', GETDATE()),
(5, N'Phạm Minh Tuấn', N'Nhân viên', '1993-07-08', N'Nam', N'Số 12, Tôn Đức Thắng, Đống Đa, Hà Nội', '0912345682', 'tuan.pham@thuvien.vn', '2022-01-10', N'Đang làm việc', GETDATE()),
(6, N'Hoàng Thị Lan', N'Thực tập sinh', '2001-12-15', N'Nữ', N'Số 34, Kim Liên, Đống Đa, Hà Nội', '0912345683', 'lan.hoang@thuvien.vn', '2025-09-01', N'Đang làm việc', GETDATE()),
(7, N'Đỗ Văn Nam', N'Nhân viên', '1994-04-22', N'Nam', N'Số 56, Xã Đàn, Đống Đa, Hà Nội', '0912345684', 'nam.do@thuvien.vn', '2022-06-15', N'Đang làm việc', GETDATE());

SET IDENTITY_INSERT NHAN_VIEN OFF;
PRINT '  ✓ Inserted 7 staff members';
GO

-- =============================================
-- 5. TÀI KHOẢN (User Accounts)
-- Password: "123456" hashed với SHA-256
-- =============================================
PRINT 'Inserting User Accounts...';
SET IDENTITY_INSERT TAI_KHOAN ON;

INSERT INTO TAI_KHOAN (MaTaiKhoan, TenDangNhap, MatKhau, MaNhanVien, QuyenHan, TrangThai, NgayTao) VALUES
(1, 'admin', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 1, N'Quản trị viên', N'Hoạt động', GETDATE()),
(2, 'thuthutruong', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 2, N'Thủ thư trưởng', N'Hoạt động', GETDATE()),
(3, 'thuthu01', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 3, N'Thủ thư', N'Hoạt động', GETDATE()),
(4, 'nhanvien01', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 4, N'Nhân viên', N'Hoạt động', GETDATE()),
(5, 'nhanvien02', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 5, N'Nhân viên', N'Hoạt động', GETDATE()),
(6, 'thuctap01', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 6, N'Thực tập sinh', N'Hoạt động', GETDATE()),
(7, 'nhanvien03', '8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92', 7, N'Nhân viên', N'Hoạt động', GETDATE());

SET IDENTITY_INSERT TAI_KHOAN OFF;
PRINT '  ✓ Inserted 7 user accounts (Password: 123456 for all)';
GO

-- =============================================
-- 6. ĐỘC GIẢ (Members/Readers)
-- =============================================
PRINT 'Inserting Members...';

INSERT INTO DOC_GIA (MaDocGia, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, CMND, NgayDangKy, NgayHetHan, TrangThai, GhiChu) VALUES
('DG001', N'Nguyễn Văn An', '2000-01-15', N'Nam', N'Số 10, Bạch Mai, Hai Bà Trưng, Hà Nội', '0901234567', 'an.nguyen@email.com', '001234567890', '2024-01-01', '2026-01-01', N'Hoạt động', N'Độc giả thân thiết'),
('DG002', N'Trần Thị Bình', '1998-05-20', N'Nữ', N'Số 22, Trần Đại Nghĩa, Hai Bà Trưng, Hà Nội', '0901234568', 'binh.tran@email.com', '001234567891', '2024-01-05', '2026-01-05', N'Hoạt động', NULL),
('DG003', N'Lê Minh Cường', '2002-08-10', N'Nam', N'Số 33, Lê Duẩn, Đống Đa, Hà Nội', '0901234569', 'cuong.le@email.com', '001234567892', '2024-02-01', '2026-02-01', N'Hoạt động', NULL),
('DG004', N'Phạm Thị Dung', '1999-12-25', N'Nữ', N'Số 44, Nguyễn Chí Thanh, Đống Đa, Hà Nội', '0901234570', 'dung.pham@email.com', '001234567893', '2024-02-15', '2026-02-15', N'Hoạt động', NULL),
('DG005', N'Hoàng Văn Em', '2001-03-30', N'Nam', N'Số 55, Khâm Thiên, Đống Đa, Hà Nội', '0901234571', 'em.hoang@email.com', '001234567894', '2024-03-01', '2026-03-01', N'Hoạt động', NULL),
('DG006', N'Đỗ Thị Phượng', '2003-06-15', N'Nữ', N'Số 66, Thái Hà, Đống Đa, Hà Nội', '0901234572', 'phuong.do@email.com', '001234567895', '2024-03-10', '2026-03-10', N'Hoạt động', NULL),
('DG007', N'Vũ Văn Giang', '2000-09-05', N'Nam', N'Số 77, Chùa Bộc, Đống Đa, Hà Nội', '0901234573', 'giang.vu@email.com', '001234567896', '2024-04-01', '2026-04-01', N'Hoạt động', NULL),
('DG008', N'Bùi Thị Hương', '1997-11-20', N'Nữ', N'Số 88, Nguyễn Lương Bằng, Đống Đa, Hà Nội', '0901234574', 'huong.bui@email.com', '001234567897', '2024-04-15', '2026-04-15', N'Hoạt động', NULL),
('DG009', N'Đinh Văn Inh', '2002-02-28', N'Nam', N'Số 99, Tôn Thất Tùng, Đống Đa, Hà Nội', '0901234575', 'inh.dinh@email.com', '001234567898', '2024-05-01', '2026-05-01', N'Hoạt động', NULL),
('DG010', N'Ngô Thị Khánh', '2001-07-12', N'Nữ', N'Số 111, Láng, Đống Đa, Hà Nội', '0901234576', 'khanh.ngo@email.com', '001234567899', '2024-05-10', '2026-05-10', N'Hoạt động', NULL),
('DG011', N'Trương Văn Long', '1995-03-18', N'Nam', N'Số 123, Kim Mã, Ba Đình, Hà Nội', '0901234577', 'long.truong@email.com', '001234567900', '2024-06-01', '2026-06-01', N'Hoạt động', NULL),
('DG012', N'Phan Thị Mai', '2000-10-05', N'Nữ', N'Số 135, Núi Trúc, Ba Đình, Hà Nội', '0901234578', 'mai.phan@email.com', '001234567901', '2024-06-15', '2026-06-15', N'Hoạt động', NULL),
('DG013', N'Lý Văn Nam', '1998-05-22', N'Nam', N'Số 147, Liễu Giai, Ba Đình, Hà Nội', '0901234579', 'nam.ly@email.com', '001234567902', '2024-07-01', '2026-07-01', N'Hoạt động', NULL),
('DG014', N'Đặng Thị Oanh', '2001-08-14', N'Nữ', N'Số 159, Cát Linh, Đống Đa, Hà Nội', '0901234580', 'oanh.dang@email.com', '001234567903', '2024-07-15', '2026-07-15', N'Hoạt động', NULL),
('DG015', N'Cao Văn Phong', '1999-11-30', N'Nam', N'Số 171, Nguyễn Thái Học, Ba Đình, Hà Nội', '0901234581', 'phong.cao@email.com', '001234567904', '2024-08-01', '2026-08-01', N'Hoạt động', NULL);

PRINT '  ✓ Inserted 15 members';
GO

-- =============================================
-- 7. SÁCH (Books) - Đa dạng thể loại
-- =============================================
PRINT 'Inserting Books...';

INSERT INTO SACH (MaSach, TenSach, MaTacGia, MaTheLoai, MaNhaXuatBan, NamXuatBan, SoLuongTon, ViTri, TrangThai, MoTa, GiaTien, NgayNhap) VALUES
-- Thiếu nhi & Tuổi trẻ (Nguyễn Nhật Ánh)
('S001', N'Cho tôi xin một vé đi tuổi thơ', 1, 4, 1, 2014, 10, 'A1-01', N'Có sẵn', N'Truyện về tuổi thơ đẹp đẽ của Nguyễn Nhật Ánh', 80000, GETDATE()),
('S002', N'Mắt biếc', 1, 3, 1, 2010, 8, 'A1-02', N'Có sẵn', N'Câu chuyện tình yêu đầu đẹp và buồn', 95000, GETDATE()),
('S003', N'Tôi thấy hoa vàng trên cỏ xanh', 1, 3, 1, 2013, 12, 'A1-03', N'Có sẵn', N'Truyện về tình anh em và tuổi thơ nghèo khó', 100000, GETDATE()),
('S004', N'Cô gái đến từ hôm qua', 1, 3, 1, 2018, 7, 'A1-04', N'Có sẵn', N'Câu chuyện tình yêu kỳ lạ và lãng mạn', 110000, GETDATE()),

-- Văn học Việt Nam cổ điển
('S005', N'Chí Phèo', 2, 1, 3, 2015, 15, 'A2-01', N'Có sẵn', N'Tác phẩm kinh điển phê phán xã hội cũ', 50000, GETDATE()),
('S006', N'Lão Hạc', 2, 1, 3, 2015, 18, 'A2-02', N'Có sẵn', N'Truyện ngắn cảm động về tình người', 40000, GETDATE()),
('S007', N'Tắt đèn', 6, 1, 3, 2015, 20, 'A2-03', N'Có sẵn', N'Kiệt tác về cuộc sống nông thôn đầu thế kỷ 20', 60000, GETDATE()),
('S008', N'Truyện Kiều', 9, 1, 3, 2016, 30, 'A3-01', N'Có sẵn', N'Tác phẩm bất hủ của đại thi hào Nguyễn Du', 45000, GETDATE()),

-- Thiếu nhi kinh điển
('S009', N'Dế Mèn phiêu lưu ký', 3, 4, 2, 2016, 12, 'B1-01', N'Có sẵn', N'Truyện thiếu nhi kinh điển của Việt Nam', 65000, GETDATE()),
('S010', N'Hoàng tử bé', 10, 4, 1, 2018, 15, 'B1-02', N'Có sẵn', N'Câu chuyện triết lý đẹp cho mọi lứa tuổi', 75000, GETDATE()),

-- Fantasy - Harry Potter Series
('S011', N'Harry Potter và Hòn đá Phù thủy', 4, 11, 1, 2017, 20, 'C1-01', N'Có sẵn', N'Phần 1 - Khởi đầu hành trình phép thuật', 150000, GETDATE()),
('S012', N'Harry Potter và Phòng chứa Bí mật', 4, 11, 1, 2017, 18, 'C1-02', N'Có sẵn', N'Phần 2 - Bí mật của Hogwarts', 170000, GETDATE()),
('S013', N'Harry Potter và Tên tù nhân ngục Azkaban', 4, 11, 1, 2018, 16, 'C1-03', N'Có sẵn', N'Phần 3 - Sự trở lại của kẻ phản bội', 180000, GETDATE()),
('S014', N'Harry Potter và Chiếc cốc lửa', 4, 11, 1, 2018, 14, 'C1-04', N'Có sẵn', N'Phần 4 - Giải đấu Tam Pháp Thuật', 200000, GETDATE()),

-- Văn học Nhật Bản - Murakami
('S015', N'Rừng Na Uy', 5, 2, 4, 2018, 10, 'C2-01', N'Có sẵn', N'Tiểu thuyết nổi tiếng nhất của Murakami', 120000, GETDATE()),
('S016', N'Kafka bên bờ biển', 5, 2, 4, 2019, 8, 'C2-02', N'Có sẵn', N'Hành trình tìm kiếm bản thân đầy huyền ảo', 140000, GETDATE()),
('S017', N'1Q84 - Tập 1', 5, 2, 4, 2020, 6, 'C2-03', N'Có sẵn', N'Thế giới song song kỳ ảo', 160000, GETDATE()),

-- Triết học & Tâm lý
('S018', N'Nhà giả kim', 7, 9, 4, 2020, 25, 'D1-01', N'Có sẵn', N'Hành trình tìm kho báu và bài học cuộc đời', 90000, GETDATE()),
('S019', N'Sapiens: Lược sử loài người', 14, 7, 4, 2018, 15, 'D1-02', N'Có sẵn', N'Lịch sử tiến hóa của loài người', 250000, GETDATE()),
('S020', N'Đắc nhân tâm', 15, 8, 5, 2016, 30, 'D2-01', N'Có sẵn', N'Nghệ thuật giao tiếp và ứng xử', 85000, GETDATE()),

-- Trinh thám
('S021', N'Mật mã Da Vinci', 13, 12, 4, 2019, 12, 'E1-01', N'Có sẵn', N'Cuộc săn tìm bí mật lịch sử', 180000, GETDATE()),
('S022', N'Thiên thần và Ác quỷ', 13, 12, 4, 2019, 10, 'E1-02', N'Có sẵn', N'Giải mã bí ẩn Illuminati', 190000, GETDATE()),

-- Văn học Việt Nam đương đại
('S023', N'Sông', 11, 1, 3, 2019, 8, 'A4-01', N'Có sẵn', N'Cuộc sống vùng đồng bằng sông Cửu Long', 95000, GETDATE()),
('S024', N'Số đỏ', 12, 1, 3, 2017, 12, 'A4-02', N'Có sẵn', N'Phê phán xã hội đô thị thời thuộc địa', 65000, GETDATE()),

-- Văn học thế giới
('S025', N'Trăm năm cô đơn', 8, 2, 4, 2018, 10, 'C3-01', N'Có sẵn', N'Kiệt tác của chủ nghĩa hiện thực huyễn ảo', 150000, GETDATE());

PRINT '  ✓ Inserted 25 books';
GO

-- =============================================
-- 8. PHIẾU MƯỢN (Loan Receipts) - Nhiều trường hợp
-- =============================================
PRINT 'Inserting Loan Receipts...';

INSERT INTO PHIEU_MUON (MaPhieuMuon, MaDocGia, MaNhanVien, NgayMuon, HanTra, NgayTraThucTe, TrangThai, GhiChu) VALUES
-- Phiếu đã trả đúng hạn
('PM001', 'DG001', 2, '2025-11-15', '2025-11-29', '2025-11-28', N'Đã trả', N'Trả đúng hạn - Sách tốt'),
('PM002', 'DG003', 3, '2025-11-20', '2025-12-04', '2025-12-03', N'Đã trả', N'Trả đúng hạn'),

-- Phiếu đã trả nhưng trễ hạn (có phạt)
('PM003', 'DG002', 2, '2025-11-10', '2025-11-24', '2025-12-01', N'Đã trả', N'Trả trễ 7 ngày - Đã phạt'),
('PM004', 'DG005', 4, '2025-11-18', '2025-12-02', '2025-12-08', N'Đã trả', N'Trả trễ 6 ngày - Đã phạt'),

-- Phiếu đang mượn (chưa quá hạn)
('PM005', 'DG007', 3, '2025-12-20', '2026-01-03', NULL, N'Đang mượn', N'Đang trong hạn'),
('PM006', 'DG008', 5, '2025-12-25', '2026-01-08', NULL, N'Đang mượn', N''),
('PM007', 'DG010', 2, '2025-12-28', '2026-01-11', NULL, N'Đang mượn', N''),

-- Phiếu đang mượn (ĐÃ QUÁ HẠN - cần xử lý phạt)
('PM008', 'DG004', 4, '2025-11-25', '2025-12-09', NULL, N'Đang mượn', N'QUÁ HẠN - Cần liên hệ độc giả'),
('PM009', 'DG006', 3, '2025-12-01', '2025-12-15', NULL, N'Đang mượn', N'QUÁ HẠN - Đã nhắc nhở'),

-- Phiếu mới (vừa mượn hôm nay)
('PM010', 'DG012', 7, '2026-01-03', '2026-01-17', NULL, N'Đang mượn', N'Mới mượn hôm nay'),
('PM011', 'DG015', 7, '2026-01-03', '2026-01-17', NULL, N'Đang mượn', N'Độc giả mới');

PRINT '  ✓ Inserted 11 loan receipts';
GO

-- =============================================
-- 9. CHI TIẾT PHIẾU MƯỢN (Loan Details)
-- =============================================
PRINT 'Inserting Loan Details...';
SET IDENTITY_INSERT CHI_TIET_PHIEU_MUON ON;

INSERT INTO CHI_TIET_PHIEU_MUON (MaChiTiet, MaPhieuMuon, MaSach, SoLuong, TinhTrangMuon, TinhTrangTra, NgayTra) VALUES
-- PM001: Đã trả (2 sách)
(1, 'PM001', 'S001', 1, N'Tốt', N'Tốt', '2025-11-28'),
(2, 'PM001', 'S002', 1, N'Tốt', N'Tốt', '2025-11-28'),

-- PM002: Đã trả (3 sách)
(3, 'PM002', 'S018', 1, N'Tốt', N'Tốt', '2025-12-03'),
(4, 'PM002', 'S020', 1, N'Tốt', N'Tốt', '2025-12-03'),
(5, 'PM002', 'S010', 1, N'Tốt', N'Tốt', '2025-12-03'),

-- PM003: Đã trả trễ (2 sách)
(6, 'PM003', 'S011', 1, N'Tốt', N'Hơi cũ', '2025-12-01'),
(7, 'PM003', 'S012', 1, N'Tốt', N'Tốt', '2025-12-01'),

-- PM004: Đã trả trễ (4 sách)
(8, 'PM004', 'S015', 1, N'Tốt', N'Tốt', '2025-12-08'),
(9, 'PM004', 'S016', 1, N'Tốt', N'Bị dơ chút', '2025-12-08'),
(10, 'PM004', 'S005', 1, N'Tốt', N'Tốt', '2025-12-08'),
(11, 'PM004', 'S008', 1, N'Tốt', N'Tốt', '2025-12-08'),

-- PM005: Đang mượn (3 sách)
(12, 'PM005', 'S019', 1, N'Tốt', NULL, NULL),
(13, 'PM005', 'S021', 1, N'Tốt', NULL, NULL),
(14, 'PM005', 'S022', 1, N'Tốt', NULL, NULL),

-- PM006: Đang mượn (2 sách)
(15, 'PM006', 'S013', 1, N'Tốt', NULL, NULL),
(16, 'PM006', 'S014', 1, N'Tốt', NULL, NULL),

-- PM007: Đang mượn (5 sách - Max)
(17, 'PM007', 'S003', 1, N'Tốt', NULL, NULL),
(18, 'PM007', 'S004', 1, N'Tốt', NULL, NULL),
(19, 'PM007', 'S009', 1, N'Tốt', NULL, NULL),
(20, 'PM007', 'S023', 1, N'Tốt', NULL, NULL),
(21, 'PM007', 'S024', 1, N'Tốt', NULL, NULL),

-- PM008: Đang mượn QUÁ HẠN (2 sách)
(22, 'PM008', 'S006', 1, N'Tốt', NULL, NULL),
(23, 'PM008', 'S007', 1, N'Tốt', NULL, NULL),

-- PM009: Đang mượn QUÁ HẠN (3 sách)
(24, 'PM009', 'S017', 1, N'Tốt', NULL, NULL),
(25, 'PM009', 'S025', 1, N'Tốt', NULL, NULL),
(26, 'PM009', 'S020', 1, N'Tốt', NULL, NULL),

-- PM010: Mới mượn hôm nay (3 sách)
(27, 'PM010', 'S011', 1, N'Tốt', NULL, NULL),
(28, 'PM010', 'S015', 1, N'Tốt', NULL, NULL),
(29, 'PM010', 'S018', 1, N'Tốt', NULL, NULL),

-- PM011: Mới mượn hôm nay (2 sách)
(30, 'PM011', 'S001', 1, N'Tốt', NULL, NULL),
(31, 'PM011', 'S002', 1, N'Tốt', NULL, NULL);

SET IDENTITY_INSERT CHI_TIET_PHIEU_MUON OFF;
PRINT '  ✓ Inserted 31 loan details';
GO

-- =============================================
-- 10. PHẠT (Fines) - Nhiều trường hợp
-- =============================================
PRINT 'Inserting Fines...';
SET IDENTITY_INSERT PHAT ON;

INSERT INTO PHAT (MaPhat, MaPhieuMuon, LyDo, SoTienPhat, NgayPhat, TrangThaiThanhToan, NgayThanhToan) VALUES
-- Đã thanh toán
(1, 'PM001', N'Không có phạt - Trả đúng hạn', 0, '2025-11-28', N'Đã thanh toán', '2025-11-28'),
(2, 'PM002', N'Không có phạt - Trả đúng hạn', 0, '2025-12-03', N'Đã thanh toán', '2025-12-03'),
(3, 'PM003', N'Trả trễ 7 ngày (2 sách x 7 ngày x 5,000đ)', 70000, '2025-12-01', N'Đã thanh toán', '2025-12-01'),
(4, 'PM004', N'Trả trễ 6 ngày (4 sách x 6 ngày x 5,000đ)', 120000, '2025-12-08', N'Đã thanh toán', '2025-12-08'),

-- Chưa thanh toán (Phiếu quá hạn - cần xử lý)
(5, 'PM008', N'Quá hạn 25 ngày (2 sách x 25 ngày x 5,000đ)', 250000, '2026-01-03', N'Chưa thanh toán', NULL),
(6, 'PM009', N'Quá hạn 19 ngày (3 sách x 19 ngày x 5,000đ)', 285000, '2026-01-03', N'Chưa thanh toán', NULL);

SET IDENTITY_INSERT PHAT OFF;
PRINT '  ✓ Inserted 6 fines';
GO

-- =============================================
-- 11. NHẬT KÝ HỆ THỐNG (System Logs)
-- =============================================
PRINT 'Inserting System Logs...';
SET IDENTITY_INSERT NHAT_KY_HE_THONG ON;

INSERT INTO NHAT_KY_HE_THONG (MaLog, TenDangNhap, ChucNang, HanhDong, NoiDung, ThoiGian) VALUES
(1, 'admin', N'Đăng nhập', N'Đăng nhập hệ thống', N'Đăng nhập thành công từ IP: 192.168.1.100', '2026-01-03 08:00:00'),
(2, 'admin', N'Quản lý tài khoản', N'Tạo tài khoản', N'Tạo tài khoản mới: thuctap01', '2026-01-03 08:15:00'),
(3, 'thuthu01', N'Đăng nhập', N'Đăng nhập hệ thống', N'Đăng nhập thành công', '2026-01-03 08:30:00'),
(4, 'thuthu01', N'Quản lý sách', N'Thêm sách mới', N'Thêm sách: S025 - Trăm năm cô đơn', '2026-01-03 08:45:00'),
(5, 'nhanvien01', N'Đăng nhập', N'Đăng nhập hệ thống', N'Đăng nhập thành công', '2026-01-03 09:00:00'),
(6, 'nhanvien01', N'Quản lý độc giả', N'Gia hạn thẻ', N'Gia hạn thẻ độc giả DG001 đến 2026-01-01', '2026-01-03 09:15:00'),
(7, 'nhanvien03', N'Mượn sách', N'Tạo phiếu mượn', N'Tạo phiếu mượn PM010 cho độc giả DG012', '2026-01-03 09:30:00'),
(8, 'nhanvien03', N'Mượn sách', N'Tạo phiếu mượn', N'Tạo phiếu mượn PM011 cho độc giả DG015', '2026-01-03 09:45:00'),
(9, 'thuthu01', N'Quản lý phạt', N'Tạo phiếu phạt', N'Tạo phiếu phạt PM008 - Quá hạn 25 ngày - 250,000đ', '2026-01-03 10:00:00'),
(10, 'thuthu01', N'Quản lý phạt', N'Tạo phiếu phạt', N'Tạo phiếu phạt PM009 - Quá hạn 19 ngày - 285,000đ', '2026-01-03 10:15:00'),
(11, 'thuthutruong', N'Đăng nhập', N'Đăng nhập hệ thống', N'Đăng nhập thành công', '2026-01-03 10:30:00'),
(12, 'thuthutruong', N'Báo cáo', N'Xem báo cáo', N'Xem báo cáo sách được mượn nhiều nhất tháng 12/2025', '2026-01-03 10:45:00'),
(13, 'admin', N'Quản lý nhân viên', N'Thêm nhân viên', N'Thêm nhân viên mới: Đỗ Văn Nam (MaNV: 7)', '2026-01-03 11:00:00'),
(14, 'nhanvien01', N'Trả sách', N'Xử lý trả sách', N'Xử lý trả sách PM004 - Trễ 6 ngày', '2025-12-08 14:30:00'),
(15, 'nhanvien01', N'Quản lý phạt', N'Thu tiền phạt', N'Thu tiền phạt PM004 - 120,000đ - Đã thanh toán', '2025-12-08 14:35:00'),
(16, 'thuthu01', N'Quản lý sách', N'Cập nhật sách', N'Cập nhật số lượng tồn S011 từ 15 thành 20', '2026-01-02 16:00:00'),
(17, 'admin', N'Nhật ký hệ thống', N'Xem nhật ký', N'Xem nhật ký hệ thống từ 01/12/2025 đến 03/01/2026', '2026-01-03 11:30:00'),
(18, 'thuthutruong', N'Quản lý tác giả', N'Thêm tác giả', N'Thêm tác giả mới: Dale Carnegie', '2025-12-28 10:00:00'),
(19, 'thuthutruong', N'Quản lý NXB', N'Cập nhật NXB', N'Cập nhật thông tin NXB Trẻ - Số điện thoại mới', '2025-12-29 11:00:00'),
(20, 'admin', N'Đăng xuất', N'Đăng xuất hệ thống', N'Đăng xuất an toàn', '2026-01-03 12:00:00');

SET IDENTITY_INSERT NHAT_KY_HE_THONG OFF;
PRINT '  ✓ Inserted 20 system logs';
GO

-- =============================================
-- SUMMARY
-- =============================================
PRINT ''
PRINT '============================================='
PRINT 'Seed data inserted successfully!'
PRINT '============================================='
PRINT 'Summary:'
PRINT '  • Authors (Tác giả): 15'
PRINT '  • Categories (Thể loại): 12'
PRINT '  • Publishers (Nhà xuất bản): 10'
PRINT '  • Staff (Nhân viên): 7'
PRINT '  • User Accounts (Tài khoản): 7'
PRINT '  • Members (Độc giả): 15'
PRINT '  • Books (Sách): 25'
PRINT '  • Loan Receipts (Phiếu mượn): 11'
PRINT '  • Loan Details (Chi tiết mượn): 31'
PRINT '  • Fines (Phạt): 6'
PRINT '  • System Logs (Nhật ký): 20'
PRINT '============================================='
PRINT ''
PRINT 'Login Credentials (All passwords: 123456):'
PRINT '  → admin / 123456 (Quản trị viên)'
PRINT '  → thuthutruong / 123456 (Thủ thư trưởng)'
PRINT '  → thuthu01 / 123456 (Thủ thư)'
PRINT '  → nhanvien01 / 123456 (Nhân viên)'
PRINT '  → nhanvien02 / 123456 (Nhân viên)'
PRINT '  → thuctap01 / 123456 (Thực tập sinh)'
PRINT '  → nhanvien03 / 123456 (Nhân viên)'
PRINT '============================================='
PRINT ''
PRINT 'Note: Có 2 phiếu mượn QUÁ HẠN cần xử lý:'
PRINT '  • PM008 - Độc giả DG004 - Quá hạn 25 ngày'
PRINT '  • PM009 - Độc giả DG006 - Quá hạn 19 ngày'
PRINT '============================================='
GO
