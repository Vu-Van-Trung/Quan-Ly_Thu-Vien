# Hệ Thống Quản Lý Thư Viện

> Ứng dụng quản lý thư viện toàn diện với C# Windows Forms và SQL Server

## 📚 Tổng Quan

Hệ thống quản lý thư viện là một ứng dụng desktop được phát triển bằng C# Windows Forms, sử dụng Entity Framework Core và SQL Server để quản lý các hoạt động của thư viện một cách hiệu quả.

### Tính Năng Chính

✅ **Quản lý Sách** - Thêm, sửa, xóa, tìm kiếm sách  
✅ **Quản lý Độc Giả** - Đăng ký, gia hạn thẻ, theo dõi độc giả  
✅ **Quản lý Mượn/Trả** - Tạo phiếu mượn, xử lý trả sách, gia hạn  
✅ **Quản lý Phạt** - Tự động tính phạt trễ hạn  
✅ **Báo Cáo & Thống Kê** - Thống kê sách mượn nhiều, độc giả tích cực, doanh thu  
✅ **Phân Quyền** - Admin, Thủ thư, Nhân viên  

## 🛠️ Công Nghệ Sử Dụng

- **Frontend**: C# Windows Forms (.NET Framework/Core)
- **Database**: SQL Server 2016+
- **ORM**: Entity Framework Core
- **Authentication**: Role-based Access Control

## 📋 Yêu Cầu Hệ Thống

- Windows 10/11
- .NET Framework 4.7.2+ hoặc .NET 6+
- SQL Server 2016 trở lên (Express, Standard hoặc Enterprise)
- Visual Studio 2022 (khuyến nghị)
- RAM tối thiểu: 4GB
- Dung lượng ổ cứng: 500MB

## 🚀 Cài Đặt

### 1. Clone Repository

```bash
git clone https://github.com/Vu-Van-Trung/Quan-Ly_Thu-Vien.git
cd Quan-Ly_Thu-Vien
```

### 2. Cài Đặt Database

#### Option A: Sử dụng SQL Server Management Studio (SSMS)

1. Mở SSMS và kết nối đến SQL Server
2. Mở file `database/schema.sql` và Execute (F5)
3. Mở file `database/seed-data.sql` và Execute để thêm dữ liệu mẫu
4. (Tùy chọn) Execute các stored procedures trong `database/stored-procedures/`

#### Option B: Sử dụng Command Line

```bash
# Tạo database schema
sqlcmd -S localhost -i database/schema.sql

# Import dữ liệu mẫu
sqlcmd -S localhost -i database/seed-data.sql

# Create stored procedures
sqlcmd -S localhost -i database/stored-procedures/sp_QuanLySach.sql
sqlcmd -S localhost -i database/stored-procedures/sp_MuonTraSach.sql
sqlcmd -S localhost -i database/stored-procedures/sp_BaoCao.sql
```

### 3. Cấu Hình Connection String

Mở file cấu hình (App.config hoặc appsettings.json) và cập nhật connection string:

```xml
<connectionStrings>
    <add name="QuanLyThuVien" 
         connectionString="Server=localhost;Database=QuanLyThuVien;Integrated Security=true;" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Hoặc với JSON:

```json
{
  "ConnectionStrings": {
    "QuanLyThuVien": "Server=localhost;Database=QuanLyThuVien;Integrated Security=true;"
  }
}
```

### 4. Build và Chạy Ứng Dụng

#### Sử dụng Visual Studio:
1. Mở solution file `DEMO_GUI_QLTHUVIEN.slnx`
2. Restore NuGet packages (Right-click solution → Restore NuGet Packages)
3. Build solution (Ctrl+Shift+B)
4. Run (F5)

#### Sử dụng Command Line:
```bash
cd DEMO_GUI_QLTHUVIEN
dotnet restore
dotnet build
dotnet run
```

## 🔐 Tài Khoản Mặc Định

Sau khi import dữ liệu mẫu, bạn có thể đăng nhập với các tài khoản sau:

| Tên đăng nhập | Mật khẩu | Quyền hạn |
|---------------|----------|-----------|
| admin | 123 | Quản trị viên |
| thuthu01 | 123 | Thủ thư |
| nhanvien01 | 123 | Nhân viên |

> ⚠️ **Lưu ý**: Đổi mật khẩu ngay sau lần đăng nhập đầu tiên!

## 📖 Hướng Dẫn Sử Dụng

### Quản Lý Sách
1. Vào menu **Quản lý → Sách**
2. **Thêm sách mới**: Click nút "Thêm mới", điền thông tin và Save
3. **Tìm kiếm**: Nhập từ khóa vào ô tìm kiếm (tên sách, tác giả, thể loại)
4. **Cập nhật**: Double-click vào sách cần sửa, chỉnh sửa và Save
5. **Xóa**: Chọn sách và click nút "Xóa"

### Mượn Sách
1. Vào menu **Giao dịch → Mượn sách**
2. Nhập mã độc giả hoặc tìm kiếm độc giả
3. Thêm các sách muốn mượn vào phiếu
4. Xác nhận và tạo phiếu mượn
5. In phiếu mượn (nếu cần)

### Trả Sách
1. Vào menu **Giao dịch → Trả sách**
2. Nhập mã phiếu mượn hoặc mã độc giả
3. Chọn sách cần trả
4. Kiểm tra tình trạng sách
5. Xác nhận trả → Hệ thống tự động tính phạt (nếu trễ hạn)

### Báo Cáo
1. Vào menu **Báo cáo**
2. Chọn loại báo cáo: Sách mượn nhiều, Độc giả tích cực, Doanh thu...
3. Chọn khoảng thời gian
4. Xem và Export báo cáo (PDF/Excel)

## 📁 Cấu Trúc Dự Án

```
Quan-Ly_Thu-Vien/
├── DEMO_GUI_QLTHUVIEN/          # Source code chính
│   ├── Data/                    # DbContext, Migrations
│   ├── Model/                   # Entity models
│   ├── Forms/                   # Windows Forms UI
│   ├── Login1.cs                # Form đăng nhập
│   ├── QuanLiSach.cs           # Form quản lý sách
│   ├── FormMember.cs           # Form quản lý độc giả
│   └── FormLoan.cs             # Form mượn/trả sách
├── database/                    # SQL scripts
│   ├── schema.sql              # Database schema
│   ├── seed-data.sql           # Dữ liệu mẫu
│   └── stored-procedures/      # Stored procedures
├── docs/                        # Tài liệu
├── openspec/                    # Project specifications
│   └── project.md              # OpenSpec document
└── README.md                    # File này
```

## 🔧 Cấu Hình Nâng Cao

### Thay Đổi Số Ngày Mượn Mặc Định
Trong code hoặc database, tìm constant `DEFAULT_BORROW_DAYS` và thay đổi giá trị (mặc định: 14 ngày)

### Thay Đổi Tiền Phạt Trễ Hạn
Tìm constant `FINE_PER_DAY` (mặc định: 5,000 VNĐ/ngày)

### Thay Đổi Số Sách Mượn Tối Đa
Tìm constant `MAX_BOOKS_PER_READER` (mặc định: 5 quyển)

## 🐛 Troubleshooting

### Lỗi kết nối Database
- Kiểm tra SQL Server đã chạy chưa
- Kiểm tra connection string có đúng không
- Kiểm tra firewall có block SQL Server không

### Lỗi login thất bại
- Kiểm tra đã import seed data chưa
- Reset mật khẩu trong database nếu cần

### Lỗi build project
- Restore NuGet packages
- Clean và Rebuild solution
- Kiểm tra .NET version có khớp không

## 📝 Business Rules

- Độc giả chỉ được mượn tối đa **5 quyển sách** cùng lúc
- Thời gian mượn mặc định: **14 ngày**
- Phạt trễ hạn: **5,000 VNĐ/ngày/sách**
- Thẻ độc giả có thời hạn **1 năm**
- Phạt hư hỏng sách: Theo giá trị sách

## 🤝 Đóng Góp
--**Vũ Văn Trung** - [GitHub](https://github.com/Vu-Van-Trung)

--**KoliangFish** - [GitHub] (https://github.com/KoliangFish).



## 📄 License

Dự án này được phát hành theo giấy phép MIT. Xem file `LICENSE` để biết thêm chi tiết.

## 👥 Tác Giả

- **LowKeyLifeeee** - [GitHub](https://github.com/LowKeyLifeeee)


## 📞 Liên Hệ

Nếu có câu hỏi hoặc góp ý, vui lòng liên hệ:
- Email: thangminhnt20@gmail.com (LowKeyLifeeee)
- Issues: [GitHub Issues](https://github.com/Vu-Van-Trung/Quan-Ly_Thu-Vien/issues)

## 🔄 Changelog

### Version 1.0 (19/12/2025)
- ✨ Initial release
- ✅ Quản lý sách, độc giả
- ✅ Mượn/trả sách
- ✅ Tính phạt tự động
- ✅ Báo cáo cơ bản

---

**Made with ❤️ using C# and SQL Server**

