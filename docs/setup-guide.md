# Hướng Dẫn Cài Đặt Hệ Thống Quản Lý Thư Viện

> Hướng dẫn chi tiết từng bước để cài đặt và triển khai hệ thống

## 📋 Mục Lục
- [Yêu Cầu Hệ Thống](#yêu-cầu-hệ-thống)
- [Cài Đặt SQL Server](#cài-đặt-sql-server)
- [Cài Đặt Database](#cài-đặt-database)
- [Cài Đặt Ứng Dụng](#cài-đặt-ứng-dụng)
- [Cấu Hình](#cấu-hình)
- [Kiểm Tra](#kiểm-tra)

## ✅ Yêu Cầu Hệ Thống

### Phần Cứng
- **CPU**: Intel Core i3 hoặc tương đương (khuyến nghị i5+)
- **RAM**: Tối thiểu 4GB (khuyến nghị 8GB+)
- **Ổ cứng**: 500MB dung lượng trống (cho ứng dụng)
- **Ổ cứng (Database)**: 2GB+ cho SQL Server

### Phần Mềm
- **OS**: Windows 10/11 (64-bit)
- **.NET Framework**: 4.7.2 hoặc .NET 6+
- **SQL Server**: 2016, 2017, 2019, hoặc 2022
  - SQL Server Express (miễn phí) - Đủ cho hầu hết trường hợp
  - SQL Server Standard/Enterprise - Cho môi trường production
- **Visual Studio**: 2022 Community (miễn phí) hoặc Professional/Enterprise
- **SSMS**: SQL Server Management Studio 18+ (khuyến nghị)

## 🔧 Cài Đặt SQL Server

### Option 1: SQL Server Express (Miễn Phí - Khuyến Nghị)

#### Bước 1: Download
1. Truy cập: https://www.microsoft.com/en-us/sql-server/sql-server-downloads
2. Scroll xuống phần **Express**
3. Click **Download now** để tải SQL Server 2022 Express

#### Bước 2: Cài Đặt
1. Chạy file installer đã tải về
2. Chọn **Basic** installation
3. Chọn ngôn ngữ: **English** hoặc **Vietnamese**
4. Đọc và chấp nhận License Terms
5. Chọn thư mục cài đặt (hoặc dùng mặc định)
6. Click **Install**
7. Đợi quá trình cài đặt hoàn tất (5-10 phút)

#### Bước 3: Cài SQL Server Management Studio (SSMS)
1. Sau khi cài SQL Server xong, click **Install SSMS**
2. Hoặc download từ: https://aka.ms/ssmsfullsetup
3. Chạy installer SSMS
4. Follow hướng dẫn cài đặt
5. Khởi động lại máy nếu được yêu cầu

#### Bước 4: Kiểm Tra Kết Nối
1. Mở **SQL Server Management Studio (SSMS)**
2. Trong cửa sổ **Connect to Server**:
   - Server type: `Database Engine`
   - Server name: `localhost\SQLEXPRESS` hoặc `.\SQLEXPRESS`
   - Authentication: `Windows Authentication`
3. Click **Connect**
4. Nếu kết nối thành công → SQL Server đã sẵn sàng! ✅

### Option 2: SQL Server Developer (Full Features - Miễn Phí)

Similar to Express nhưng chọn **Developer** edition thay vì Express. Developer edition có đầy đủ tính năng nhưng chỉ dùng cho development/testing.

## 💾 Cài Đặt Database

### Phương Án 1: Sử dụng SSMS (Đơn Giản - Khuyến Nghị)

#### Bước 1: Tạo Database Schema
1. Mở **SQL Server Management Studio**
2. Kết nối đến server (như hướng dẫn ở trên)
3. Click **File → Open → File**
4. Duyệt đến thư mục dự án và chọn `database/schema.sql`
5. Click **Execute** (hoặc nhấn F5)
6. Kiểm tra Messages:
   ```
   Database QuanLyThuVien created successfully.
   Database schema created successfully!
   Total tables created: 10
   Total indexes created: 13
   ```

#### Bước 2: Import Dữ Liệu Mẫu
1. Trong SSMS, click **File → Open → File**
2. Chọn file `database/seed-data.sql`
3. Click **Execute** (F5)
4. Kiểm tra thông báo thành công:
   ```
   Seed data inserted successfully!
   Tác giả: 10 | Thể loại: 10 | Nhà xuất bản: 10
   Nhân viên: 5 | Tài khoản: 5 | Độc giả: 10
   Sách: 15 | Phiếu mượn: 4 | Chi tiết: 8
   ```

#### Bước 3: Tạo Stored Procedures
Execute lần lượt các file stored procedures:

1. **sp_QuanLySach.sql**:
   ```
   File → Open → database/stored-procedures/sp_QuanLySach.sql
   Execute (F5)
   ```

2. **sp_MuonTraSach.sql**:
   ```
   File → Open → database/stored-procedures/sp_MuonTraSach.sql
   Execute (F5)
   ```

3. **sp_BaoCao.sql**:
   ```
   File → Open → database/stored-procedures/sp_BaoCao.sql
   Execute (F5)
   ```

#### Bước 4: Verify Database
```sql
-- Kiểm tra các bảng đã tạo
USE QuanLyThuVien;
GO

SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME;

-- Kiểm tra dữ liệu
SELECT COUNT(*) AS SoLuongSach FROM SACH;
SELECT COUNT(*) AS SoDocGia FROM DOC_GIA;
SELECT COUNT(*) AS SoNhanVien FROM NHAN_VIEN;
```

### Phương Án 2: Sử dụng Command Line (Advanced)

```powershell
# Chuyển đến thư mục database
cd "C:\Users\HI\source\repos\Quan-Ly_Thu-Vien\database"

# Execute schema
sqlcmd -S localhost\SQLEXPRESS -E -i schema.sql

# Execute seed data
sqlcmd -S localhost\SQLEXPRESS -E -i seed-data.sql

# Execute stored procedures
cd stored-procedures
sqlcmd -S localhost\SQLEXPRESS -E -i sp_QuanLySach.sql
sqlcmd -S localhost\SQLEXPRESS -E -i sp_MuonTraSach.sql
sqlcmd -S localhost\SQLEXPRESS -E -i sp_BaoCao.sql
```

## 🖥️ Cài Đặt Ứng Dụng

### Bước 1: Clone hoặc Download Source Code

**Option A: Sử dụng Git**
```bash
git clone https://github.com/Vu-Van-Trung/Quan-Ly_Thu-Vien.git
cd Quan-Ly_Thu-Vien
```

**Option B: Download ZIP**
1. Truy cập GitHub repository
2. Click **Code → Download ZIP**
3. Giải nén vào thư mục mong muốn

### Bước 2: Mở Project trong Visual Studio

1. Khởi động **Visual Studio 2022**
2. Click **Open a project or solution**
3. Duyệt đến thư mục dự án
4. Chọn file `DEMO_GUI_QLTHUVIEN.slnx` hoặc `.sln`
5. Click **Open**

### Bước 3: Restore NuGet Packages

Visual Studio sẽ tự động restore packages. Nếu không:

1. Right-click vào Solution trong Solution Explorer
2. Chọn **Restore NuGet Packages**
3. Đợi quá trình hoàn tất

### Bước 4: Cấu Hình Connection String

#### Tìm file cấu hình:
- **App.config** (Windows Forms - .NET Framework)
- **appsettings.json** (nếu dùng .NET Core/6+)

#### Cập nhật Connection String:

**Cho App.config:**
```xml
<configuration>
  <connectionStrings>
    <add name="QuanLyThuVien" 
         connectionString="Server=localhost\SQLEXPRESS;Database=QuanLyThuVien;Integrated Security=true;TrustServerCertificate=true;" 
         providerName="System.Data.SqlClient" />
  </connectionStrings>
</configuration>
```

**Cho appsettings.json:**
```json
{
  "ConnectionStrings": {
    "QuanLyThuVien": "Server=localhost\\SQLEXPRESS;Database=QuanLyThuVien;Integrated Security=true;TrustServerCertificate=true;"
  }
}
```

> 💡 **Lưu ý**: 
> - Thay `localhost\SQLEXPRESS` bằng tên server của bạn nếu khác
> - Nếu dùng SQL Authentication, connection string sẽ là:
>   ```
>   Server=localhost\SQLEXPRESS;Database=QuanLyThuVien;User Id=sa;Password=YourPassword;TrustServerCertificate=true;
>   ```

### Bước 5: Build Project

1. Trong Visual Studio, chọn **Build → Rebuild Solution** (hoặc Ctrl+Shift+B)
2. Kiểm tra **Output** window cho kết quả
3. Đảm bảo không có lỗi (có thể có warnings)

### Bước 6: Run Ứng Dụng

1. Đảm bảo startup project là `DEMO_GUI_QLTHUVIEN`
2. Nhấn **F5** hoặc click **Start** button
3. Ứng dụng sẽ khởi động và hiển thị màn hình đăng nhập

## 🔐 Đăng Nhập Lần Đầu

Sử dụng tài khoản mặc định:

| Tên đăng nhập | Mật khẩu | Quyền |
|---------------|----------|-------|
| admin | 123456 | Quản trị viên |
| thuthu01 | 123456 | Thủ thư |
| nhanvien01 | 123456 | Nhân viên |

> ⚠️ **Bảo mật**: Đổi mật khẩu ngay sau lần đăng nhập đầu tiên!

## ✔️ Kiểm Tra & Xác Nhận

### Checklist Hoàn Thành

- [ ] SQL Server đã được cài đặt và chạy
- [ ] SSMS kết nối thành công đến SQL Server
- [ ] Database `QuanLyThuVien` đã được tạo
- [ ] 10 bảng chính đã tồn tại
- [ ] Dữ liệu mẫu đã được import
- [ ] Stored procedures đã được tạo
- [ ] Visual Studio mở project thành công
- [ ] NuGet packages đã được restore
- [ ] Connection string đã được cấu hình đúng
- [ ] Build project thành công (0 errors)
- [ ] Ứng dụng khởi động thành công
- [ ] Đăng nhập thành công với tài khoản mặc định

### Test Chức Năng Cơ Bản

1. **Đăng nhập**: Thử với tài khoản `admin/123456`
2. **Xem danh sách sách**: Kiểm tra có 15 sách mẫu
3. **Xem danh sách độc giả**: Kiểm tra có 10 độc giả
4. **Tạo phiếu mượn mới**: Thử tạo 1 phiếu mượn test
5. **Xem báo cáo**: Kiểm tra báo cáo hiển thị đúng

Nếu tất cả chức năng trên hoạt động → Cài đặt thành công! 🎉

## 🆘 Xử Lý Sự Cố

### Lỗi: "Cannot connect to database"
**Nguyên nhân**: Connection string sai hoặc SQL Server không chạy

**Giải pháp**:
1. Kiểm tra SQL Server đang chạy:
   ```
   Services → Tìm "SQL Server (SQLEXPRESS)" → Phải là "Running"
   ```
2. Verify connection string trong App.config
3. Test connection trong SSMS trước

### Lỗi: "Login failed for user"
**Nguyên nhân**: Quyền truy cập database

**Giải pháp**:
1. Dùng Windows Authentication thay vì SQL Authentication
2. Hoặc tạo SQL login và grant quyền:
   ```sql
   CREATE LOGIN appuser WITH PASSWORD = 'StrongPass123!';
   USE QuanLyThuVien;
   CREATE USER appuser FOR LOGIN appuser;
   ALTER ROLE db_owner ADD MEMBER appuser;
   ```

### Lỗi: "Database does not exist"
**Giải pháp**: Chạy lại `schema.sql` trong SSMS

### Lỗi build: "NuGet packages missing"
**Giải pháp**:
```
Tools → NuGet Package Manager → Package Manager Console
Run: Update-Package -reinstall
```

### Ứng dụng crash khi khởi động
**Giải pháp**:
1. Check connection string
2. Check database có tồn tại không
3. Xem error details trong Output window
4. Enable exceptions: Debug → Windows → Exception Settings

## 📞 Hỗ Trợ

Nếu gặp vấn đề không giải quyết được:

1. Check [GitHub Issues](https://github.com/Vu-Van-Trung/Quan-Ly_Thu-Vien/issues)
2. Tạo issue mới với:
   - Mô tả chi tiết lỗi
   - Screenshots
   - Error messages
   - Môi trường (Windows version, SQL Server version, .NET version)

---

**Chúc bạn cài đặt thành công! 🚀**
