# Hệ Thống Quản Lý Thư Viện

> Ứng dụng quản lý thư viện toàn diện với C# Windows Forms, Entity Framework Core và SQL Server

[![.NET](https://img.shields.io/badge/.NET-6.0+-512BD4?style=flat&logo=.net)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2016+-CC2927?style=flat&logo=microsoft-sql-server)](https://www.microsoft.com/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## 📚 Tổng Quan

Hệ thống quản lý thư viện là một ứng dụng desktop được phát triển bằng C# Windows Forms, sử dụng **Entity Framework Core** và **SQL Server** để quản lý các hoạt động của thư viện một cách hiệu quả, an toàn và chuyên nghiệp.

### ✨ Điểm Nổi Bật

🔐 **Bảo Mật Cao Cấp** - Mã hóa AES-256 + RSA cho dữ liệu nhạy cảm  
📊 **Báo Cáo Chuyên Sâu** - 5 loại báo cáo thống kê chi tiết  
🎯 **Phân Quyền Linh Hoạt** - Role-based Access Control (RBAC)  
📝 **Audit Logging** - Ghi nhật ký đầy đủ mọi thao tác  
💰 **Quản Lý Phạt Thông Minh** - Tự động tính phạt, miễn giảm linh hoạt  
🖨️ **In Ấn Chuyên Nghiệp** - Tích hợp in phiếu mượn, phiếu phạt  

## 🎯 Tính Năng Chi Tiết

### 1. Quản Lý Sách (`QuanLiSach.cs`)
- ✅ **CRUD đầy đủ**: Thêm, sửa, xóa, tìm kiếm sách
- ✅ **Tìm kiếm nâng cao**: Theo tên, tác giả, thể loại, nhà xuất bản
- ✅ **Quản lý tồn kho**: Theo dõi số lượng sách có sẵn
- ✅ **Phân loại**: Quản lý theo thể loại, tác giả, nhà xuất bản
- ✅ **Thông tin chi tiết**: Năm xuất bản, giá tiền, vị trí, mô tả, trạng thái

### 2. Quản Lý Độc Giả (`FormMember.cs`)
- ✅ **Đăng ký thành viên**: Form đăng ký với đầy đủ thông tin
- ✅ **Quản lý thông tin**: Họ tên, ngày sinh, giới tính, địa chỉ, CMND
- ✅ **Gia hạn thẻ**: Theo dõi ngày đăng ký, ngày hết hạn
- ✅ **Trạng thái**: Đang hoạt động, tạm khóa, hết hạn
- ✅ **Lịch sử mượn**: Xem toàn bộ lịch sử mượn sách của độc giả

### 3. Quản Lý Mượn/Trả Sách (`FormLoan.cs`)
- ✅ **Tạo phiếu mượn**: Chọn độc giả, thêm nhiều sách vào 1 phiếu
- ✅ **Xử lý trả sách**: Kiểm tra tình trạng sách khi trả
- ✅ **Gia hạn**: Gia hạn thời gian mượn
- ✅ **Kiểm tra điều kiện**: Tự động kiểm tra số sách được phép mượn
- ✅ **Tính toán ngày**: Tự động tính ngày trả dự kiến
- ✅ **Cảnh báo**: Cảnh báo sách quá hạn, sắp quá hạn

### 4. Quản Lý Phạt (`FormFine.cs`)
- ✅ **Tự động tính phạt trễ hạn**: 5,000 VNĐ/ngày/sách
- ✅ **Phạt hư hỏng/mất sách**: Theo giá trị sách
- ✅ **Thu tiền phạt**: Cập nhật trạng thái thanh toán
- ✅ **Miễn giảm phạt**: Chức năng miễn giảm có quyền hạn
- ✅ **In phiếu phạt**: In chi tiết phạt cho độc giả
- ✅ **Lịch sử phạt**: Xem đầy đủ lịch sử phạt

### 5. Báo Cáo & Thống Kê (`FormReport.cs`)
Hệ thống cung cấp **5 loại báo cáo** chuyên sâu:

#### 📈 Sách Được Mượn Nhiều Nhất
- Top sách được mượn theo khoảng thời gian
- Hiển thị số lần mượn, tác giả, thể loại
- Hỗ trợ xuất Excel

#### 👥 Độc Giả Tích Cực
- Xếp hạng độc giả theo số lần mượn
- Thông tin liên hệ, trạng thái thành viên

#### 📚 Thống Kê Theo Thể Loại
- Số lượng sách theo từng thể loại
- Số lượng sách đang mượn/có sẵn
- Tỷ lệ phần trăm

#### 💰 Doanh Thu Tiền Phạt
- Tổng tiền phạt theo khoảng thời gian
- Phân loại: Đã thanh toán / Chưa thanh toán
- Lý do phạt chi tiết

#### 📦 Báo Cáo Tồn Kho
- Danh sách sách trong kho
- Số lượng tồn, số lượng đang mượn
- Cảnh báo sách sắp hết

### 6. Quản Lý Tác Giả (`QuanLiTacGia.cs`)
- ✅ Thêm/sửa/xóa tác giả
- ✅ Thông tin: Tên, ngày sinh, quốc tịch, tiểu sử
- ✅ Xem danh sách sách của tác giả

### 7. Quản Lý Nhà Xuất Bản (`FormPublisher.cs`)
- ✅ CRUD nhà xuất bản
- ✅ Thông tin: Tên, địa chỉ, số điện thoại, email
- ✅ Quản lý danh sách sách xuất bản

### 8. Quản Lý Nhân Viên (`FormStaff.cs`)
- ✅ Quản lý thông tin nhân viên
- ✅ Chức vụ: Quản trị viên, Thủ thư, Nhân viên, Thực tập sinh
- ✅ Thông tin: Họ tên, ngày sinh, giới tính, địa chỉ, SĐT, email
- ✅ Theo dõi ngày vào làm

### 9. Quản Lý Tài Khoản (`QuanLyTaiKhoan.cs`)
- ✅ **Tạo tài khoản**: Liên kết với nhân viên
- ✅ **Phân quyền**: 3 cấp độ quyền hạn
- ✅ **Mã hóa mật khẩu**: Hash password an toàn
- ✅ **Đổi mật khẩu**: Cho phép người dùng đổi mật khẩu
- ✅ **Khóa/Mở khóa**: Quản lý trạng thái tài khoản
- ✅ **Trạng thái**: Đang hoạt động / Bị khóa

### 10. Nhật Ký Hệ Thống (`QuanLiNhatKy.cs`)
- ✅ **Ghi log đầy đủ**: Mọi thao tác trong hệ thống
- ✅ **Thông tin log**: Người dùng, chức năng, hành động, nội dung, thời gian
- ✅ **Tìm kiếm**: Theo người dùng, chức năng, khoảng thời gian
- ✅ **Xem chi tiết**: Hiển thị nội dung đầy đủ của từng log

### 11. Hệ Thống Bảo Mật (`Security/`)

#### 🔐 Mã Hóa Dữ Liệu (`CryptoHelper.cs`)
- **AES-256 Encryption**: Mã hóa dữ liệu nhạy cảm
- **RSA Key Protection**: Bảo vệ khóa AES bằng RSA
- **Toggle Encryption**: Bật/tắt mã hóa cho demo
- **Backward Compatibility**: Tương thích với dữ liệu cũ

#### 🛡️ Phân Quyền (`AccessControl.cs`)
Hệ thống 5 cấp độ quyền hạn:

| Quyền Hạn | Mô Tả | Chức Năng |
|-----------|-------|-----------|
| **Quản trị viên** | Toàn quyền | Tất cả chức năng |
| **Thủ thư** | Nghiệp vụ chính | Quản lý sách, mượn/trả, phạt, báo cáo |
| **Nhân viên** | Nghiệp vụ cơ bản | Mượn/trả sách, quản lý độc giả |

**Quyền hạn chi tiết**:
- `ManageAccounts`: Chỉ Admin
- `Settings`: Chỉ Admin
- `ManageStaff`: Chỉ Admin
- `ManageFines`: Admin, Thủ thư
- `Reports`: Admin, Thủ thư
- `ViewLogs`: Admin, Thủ thư
- `ManageBooks`: Tất cả
- `ManageLoans`: Tất cả
- `ManageMembers`: Tất cả

### 12. Đăng Nhập & Bảo Mật (`Login1.cs`)
- ✅ Xác thực tài khoản
- ✅ Kiểm tra trạng thái tài khoản
- ✅ Session management
- ✅ Ghi log đăng nhập/đăng xuất

### 13. Form Đăng Ký (`FormRegister.cs`)
- ✅ Đăng ký tài khoản người dùng mới
- ✅ Xác thực dữ liệu đầu vào
- ✅ Mã hóa mật khẩu tự động

### 14. Cài Đặt Hệ Thống (`FormSettings.cs`)
- ✅ Cấu hình tham số hệ thống
- ✅ Thiết lập quy tắc nghiệp vụ
- ✅ Quản lý backup/restore

### 15. Kiểm Tra Điều Kiện (`FormConditionCheck.cs`)
- ✅ Kiểm tra điều kiện mượn sách
- ✅ Xác minh độc giả hợp lệ
- ✅ Kiểm tra số lượng sách được phép mượn

## 🛠️ Công Nghệ Sử Dụng

### Frontend
- **Framework**: Windows Forms (.NET 6.0+)
- **UI Components**: Guna UI 2 - Modern, đẹp mắt, responsive
- **Icons & Graphics**: System.Drawing

### Backend
- **Language**: C# 10.0+
- **ORM**: Entity Framework Core 6.0+
- **Database**: SQL Server 2016+
- **Security**: AES-256, RSA, BCrypt/SHA-256

### Architecture
- **Pattern**: Layered Architecture (Presentation → Business → Data)
- **Data Access**: Repository Pattern với Entity Framework
- **Security**: Encryption Layer + Access Control
- **Logging**: Centralized System Logging

### External Libraries
- `Microsoft.EntityFrameworkCore.SqlServer` - ORM
- `Guna.UI2.WinForms` - Modern UI Components
- `System.Configuration.ConfigurationManager` - Configuration
- `TheArtOfDevHtmlRenderer` - HTML Rendering & Printing

## 📋 Yêu Cầu Hệ Thống

### Phần Cứng
- **CPU**: Intel Core i3 hoặc tương đương (khuyến nghị i5+)
- **RAM**: Tối thiểu 4GB (khuyến nghị 8GB+)
- **Ổ cứng**: 500MB trống (chưa bao gồm database)

### Phần Mềm
- **OS**: Windows 10/11 (64-bit)
- **.NET**: .NET 6.0 Runtime hoặc cao hơn
- **Database**: SQL Server 2016+ (Express, Standard, hoặc Enterprise)
- **IDE** (Development): Visual Studio 2022 hoặc VS Code với C# Extension

## 🚀 Hướng Dẫn Cài Đặt

### Bước 1: Clone Repository

```bash
git clone https://github.com/Vu-Van-Trung/Quan-Ly_Thu-Vien.git
cd Quan-Ly_Thu-Vien
```

### Bước 2: Cài Đặt SQL Server

1. Download và cài đặt [SQL Server 2019 Express](https://www.microsoft.com/sql-server/sql-server-downloads)
2. Download và cài đặt [SQL Server Management Studio (SSMS)](https://aka.ms/ssmsfullsetup)

### Bước 3: Tạo Database

#### Option A: Sử dụng SSMS (Khuyến nghị)

1. Mở SSMS và kết nối đến SQL Server
2. Mở file `database/schema.sql`
3. Thực thi (F5) để tạo database và tables
4. Mở file `database/seed-data.sql`
5. Thực thi (F5) để thêm dữ liệu mẫu
6. (Tùy chọn) Thực thi các stored procedures trong `database/stored-procedures/`

#### Option B: Sử dụng Command Line

```bash
# Tạo database schema
sqlcmd -S localhost -i database/schema.sql

# Import dữ liệu mẫu
sqlcmd -S localhost -i database/seed-data.sql

# Tạo stored procedures
sqlcmd -S localhost -i database/stored-procedures/sp_QuanLySach.sql
sqlcmd -S localhost -i database/stored-procedures/sp_MuonTraSach.sql
sqlcmd -S localhost -i database/stored-procedures/sp_BaoCao.sql
```

### Bước 4: Cấu Hình Connection String

Mở file `DEMO_GUI_QLTHUVIEN/App.config` và cập nhật connection string:

```xml
<connectionStrings>
    <add name="LibraryDb"
         connectionString="Server=localhost;Database=QuanLyThuVien;Integrated Security=true;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

**Lưu ý**: Thay đổi `Server=localhost` thành tên SQL Server instance của bạn nếu khác.

### Bước 5: Build và Chạy Ứng Dụng

#### Sử dụng Visual Studio 2022:

1. Mở solution file `DEMO_GUI_QLTHUVIEN.slnx`
2. Restore NuGet packages: `Right-click solution` → `Restore NuGet Packages`
3. Build solution: `Ctrl+Shift+B`
4. Run: `F5` (Debug) hoặc `Ctrl+F5` (Release)

#### Sử dụng Command Line:

```bash
cd DEMO_GUI_QLTHUVIEN
dotnet restore
dotnet build
dotnet run
```

## 🔐 Tài Khoản Mặc Định

Sau khi import dữ liệu mẫu, bạn có thể đăng nhập với các tài khoản sau:

| Tên đăng nhập | Mật khẩu | Quyền hạn | Mô tả |
|---------------|----------|-----------|-------|
| `admin` | `123456` | Quản trị viên | Toàn quyền |
| `thuthu01` | `123456` | Thủ thư | Nghiệp vụ chính |
| `nhanvien01` | `123456` | Nhân viên | Nghiệp vụ cơ bản |

> ⚠️ **BẮT BUỘC**: Đổi mật khẩu ngay sau lần đăng nhập đầu tiên để đảm bảo bảo mật!

## 📖 Hướng Dẫn Sử Dụng

### 🔑 Đăng Nhập

1. Khởi động ứng dụng
2. Nhập **tên đăng nhập** và **mật khẩu**
3. Click "Đăng nhập"
4. Hệ thống sẽ hiển thị giao diện chính với menu tương ứng quyền hạn

### 📚 Quản Lý Sách

1. Vào menu **Quản lý** → **Sách**
2. **Thêm sách**: Click "Thêm mới", điền đầy đủ thông tin, click "Lưu"
3. **Tìm kiếm**: Nhập từ khóa vào ô tìm kiếm (tên, tác giả, thể loại)
4. **Sửa**: Double-click vào dòng cần sửa, chỉnh sửa, click "Cập nhật"
5. **Xóa**: Chọn dòng, click "Xóa", xác nhận

### 👥 Đăng Ký Độc Giả

1. Vào menu **Quản lý** → **Độc giả**
2. Click "Thêm mới"
3. Điền đầy đủ: Họ tên, CMND, ngày sinh, giới tính, địa chỉ, số điện thoại, email
4. Hệ thống tự động set ngày đăng ký = hôm nay, ngày hết hạn = +1 năm
5. Click "Lưu"

### 📖 Mượn Sách

1. Vào **Giao dịch** → **Mượn sách**
2. Nhập mã độc giả hoặc tìm kiếm độc giả
3. Hệ thống kiểm tra:
   - Thẻ còn hạn không?
   - Có sách quá hạn không?
   - Đã mượn đủ 5 quyển chưa?
4. Thêm sách vào phiếu (tối đa 5 quyển/phiếu)
5. Xác nhận ngày mượn và hạn trả (mặc định +14 ngày)
6. Click "Tạo phiếu mượn"
7. In phiếu mượn (tùy chọn)

### 📥 Trả Sách

1. Vào **Giao dịch** → **Trả sách** (hoặc mở từ **Quản lý phạt**)
2. Nhập mã phiếu mượn hoặc mã độc giả
3. Hệ thống hiển thị danh sách sách đang mượn
4. Chọn sách cần trả, kiểm tra tình trạng
5. Hệ thống tự động:
   - Tính số ngày trễ hạn (nếu có)
   - Tạo phiếu phạt (5,000 VNĐ/ngày/sách)
6. Click "Xác nhận trả"
7. Nếu có phạt → chuyển sang Form Phạt để thanh toán

### 💰 Quản Lý Phạt

1. Vào **Quản lý** → **Phạt**
2. Chọn mã phiếu mượn từ dropdown
3. Hệ thống hiển thị:
   - Danh sách sách đang mượn
   - Danh sách phạt (nếu có)
4. **Thu tiền**: Chọn dòng phạt, click "Thanh toán"
5. **Miễn giảm**: Click "Miễn giảm" (chỉ Admin/Thủ thư)
6. **In phiếu**: Click "In phiếu phạt"

### 📊 Báo Cáo

1. Vào **Báo cáo** → Chọn loại báo cáo từ Tab
2. Chọn **khoảng thời gian** (Từ ngày - Đến ngày)
3. Click "Tạo báo cáo"
4. Xem kết quả trong DataGridView
5. Export: Click "Export Excel" (tùy chọn)

### 🔍 Xem Nhật Ký

1. Vào **Hệ thống** → **Nhật ký hoạt động**
2. Lọc theo:
   - Người dùng
   - Chức năng
   - Khoảng thời gian
3. Click "Tìm kiếm"
4. Xem chi tiết log ở panel bên phải

## 📁 Cấu Trúc Dự Án

```
Quan-Ly_Thu-Vien/
├── DEMO_GUI_QLTHUVIEN/              # Source code chính
│   ├── Data/                        # Database Context
│   │   └── LibraryContext.cs        # EF Core DbContext
│   ├── Model/                       # Entity Models
│   │   ├── Author.cs                # Tác giả
│   │   ├── Book.cs                  # Sách
│   │   ├── Category.cs              # Thể loại
│   │   ├── Publisher.cs             # Nhà xuất bản
│   │   ├── Member.cs                # Độc giả
│   │   ├── Staff.cs                 # Nhân viên
│   │   ├── User.cs                  # Tài khoản
│   │   ├── Loan.cs                  # Phiếu mượn
│   │   ├── LoanDetail.cs            # Chi tiết phiếu mượn
│   │   ├── Fine.cs                  # Phạt
│   │   └── SystemLog.cs             # Nhật ký hệ thống
│   ├── Security/                    # Bảo mật
│   │   ├── CryptoHelper.cs          # Mã hóa AES + RSA
│   │   ├── RsaHelper.cs             # RSA Key Management
│   │   └── AccessControl.cs         # Phân quyền RBAC
│   ├── Services/                    # Business Logic
│   │   ├── AuthorService.cs         # Service tác giả
│   │   ├── FineService.cs           # Service phạt
│   │   ├── Logger.cs                # Logging service
│   │   └── Session.cs               # Session management
│   ├── Migrations/                  # EF Core Migrations
│   ├── Forms/                       # Windows Forms UI
│   │   ├── Login1.cs                # Đăng nhập
│   │   ├── QuanLiThuVien.cs         # Form chính (MDI Container)
│   │   ├── QuanLiSach.cs            # Quản lý sách
│   │   ├── QuanLiTacGia.cs          # Quản lý tác giả
│   │   ├── FormPublisher.cs         # Quản lý NXB
│   │   ├── FormMember.cs            # Quản lý độc giả
│   │   ├── FormStaff.cs             # Quản lý nhân viên
│   │   ├── FormLoan.cs              # Mượn/Trả sách
│   │   ├── FormFine.cs              # Quản lý phạt
│   │   ├── FormReport.cs            # Báo cáo thống kê
│   │   ├── QuanLyTaiKhoan.cs        # Quản lý tài khoản
│   │   ├── QuanLiNhatKy.cs          # Nhật ký hệ thống
│   │   ├── FormRegister.cs          # Đăng ký
│   │   ├── FormSettings.cs          # Cài đặt
│   │   └── FormConditionCheck.cs    # Kiểm tra điều kiện
│   ├── App.config                   # Configuration file
│   └── Program.cs                   # Entry point
├── database/                        # SQL Scripts
│   ├── schema.sql                   # Database schema
│   ├── seed-data.sql                # Dữ liệu mẫu
│   └── stored-procedures/           # Stored procedures
│       ├── sp_QuanLySach.sql
│       ├── sp_MuonTraSach.sql
│       └── sp_BaoCao.sql
├── docs/                            # Tài liệu
├── openspec/                        # OpenSpec Documents
│   └── project.md                   # Đặc tả dự án
├── .gitignore
├── AGENTS.md                        # AI Agents configuration
├── DEMO_GUI_QLTHUVIEN.slnx          # Solution file
└── README.md                        # File này
```

## 🗄️ Cấu Trúc Database

### Bảng Chính

| Bảng | Mô Tả | Khóa Chính |
|------|-------|------------|
| `Authors` | Tác giả | `AuthorId` (INT) |
| `Categories` | Thể loại | `CategoryId` (INT) |
| `Publishers` | Nhà xuất bản | `PublisherId` (INT) |
| `Books` | Sách | `BookId` (VARCHAR) |
| `Members` | Độc giả | `MemberId` (VARCHAR) |
| `Staff` | Nhân viên | `StaffId` (INT) |
| `Users` | Tài khoản | `Id` (INT) |
| `Loans` | Phiếu mượn | `LoanId` (VARCHAR) |
| `LoanDetails` | Chi tiết phiếu mượn | `LoanDetailId` (INT) |
| `Fines` | Phạt | `FineId` (INT) |
| `SystemLogs` | Nhật ký hệ thống | `LogId` (INT) |

### Mối Quan Hệ

```
Authors (1) ──────< (N) Books
Categories (1) ────< (N) Books
Publishers (1) ────< (N) Books
Members (1) ───────< (N) Loans
Staff (1) ─────────< (N) Loans
Staff (1) ─────────< (1) Users
Loans (1) ─────────< (N) LoanDetails
Books (1) ─────────< (N) LoanDetails
Loans (1) ─────────< (N) Fines
```

## 🔧 Cấu Hình Nâng Cao

### Thay Đổi Quy Tắc Nghiệp Vụ

Các constant có thể điều chỉnh trong code:

```csharp
// Số ngày mượn mặc định
public const int DEFAULT_BORROW_DAYS = 14;

// Tiền phạt trễ hạn (VNĐ/ngày/sách)
public const decimal FINE_PER_DAY = 5000;

// Số sách mượn tối đa
public const int MAX_BOOKS_PER_MEMBER = 5;

// Thời hạn thẻ độc giả (năm)
public const int MEMBERSHIP_DURATION_YEARS = 1;
```

### Bật/Tắt Mã Hóa

Trong `Security/CryptoHelper.cs`:

```csharp
// true: Mã hóa dữ liệu nhạy cảm
// false: Lưu dạng plain text (chỉ dùng demo)
public static bool IsEncryptionEnabled = true;
```

### Cấu Hình Connection String

Trong `App.config`:

```xml
<!-- Integrated Security (Windows Authentication) -->
<add name="LibraryDb"
     connectionString="Server=localhost;Database=QuanLyThuVien;Integrated Security=true;TrustServerCertificate=True" />

<!-- SQL Server Authentication -->
<add name="LibraryDb"
     connectionString="Server=localhost;Database=QuanLyThuVien;User Id=sa;Password=YourPassword;TrustServerCertificate=True" />
```

## 🐛 Troubleshooting

### Lỗi: "Cannot open database"

**Nguyên nhân**: SQL Server chưa chạy hoặc database chưa được tạo

**Giải pháp**:
1. Kiểm tra SQL Server đã chạy: `services.msc` → tìm "SQL Server"
2. Kiểm tra database đã tồn tại: SSMS → Object Explorer
3. Nếu chưa có, chạy lại `database/schema.sql`

### Lỗi: "Login failed for user"

**Nguyên nhân**: Connection string sai hoặc quyền truy cập thiếu

**Giải pháp**:
1. Kiểm tra `Server` name trong connection string
2. Nếu dùng SQL Auth: kiểm tra username/password
3. Nếu dùng Windows Auth: đảm bảo user Windows có quyền truy cập SQL

### Lỗi: "Could not load file or assembly"

**Nguyên nhân**: Thiếu NuGet packages

**Giải pháp**:
```bash
dotnet restore
# hoặc trong VS: Right-click solution → Restore NuGet Packages
```

### Lỗi mã hóa: "Lỗi nghiêm trọng khi khởi tạo hệ thống bảo mật"

**Nguyên nhân**: RSA keys không thể tạo hoặc đọc

**Giải pháp**:
1. Xóa file `aes.key.enc`, `aes.iv`, `rsa_public.xml`, `rsa_private.xml`
2. Chạy lại ứng dụng để tạo keys mới
3. Hoặc tạm thời tắt mã hóa: `IsEncryptionEnabled = false`

### Lỗi: "Timeout expired"

**Nguyên nhân**: Query chạy quá lâu (database lớn)

**Giải pháp**: Thêm timeout vào connection string:
```xml
connectionString="...;Connection Timeout=60;"
```

## 📝 Quy Tắc Nghiệp Vụ

### Mượn Sách
- ✅ Độc giả phải có thẻ còn hạn
- ✅ Không được có sách quá hạn
- ✅ Tối đa **5 quyển** cùng lúc
- ✅ Thời gian mượn mặc định: **14 ngày**
- ✅ Có thể gia hạn nếu chưa quá hạn

### Trả Sách
- ✅ Phạt trễ hạn: **5,000 VNĐ/ngày/sách**
- ✅ Phạt hư hỏng: Theo giá sách
- ✅ Phạt mất sách: 100% giá sách
- ✅ Kiểm tra tình trạng sách khi trả

### Thẻ Độc Giả
- ✅ Thời hạn: **1 năm** kể từ ngày đăng ký
- ✅ Gia hạn: Trước khi hết hạn
- ✅ Yêu cầu: Không có nợ phạt

### Quyền Hạn
- ✅ **Admin**: Toàn quyền hệ thống
- ✅ **Thủ thư**: Quản lý sách, mượn/trả, phạt, báo cáo
- ✅ **Nhân viên**: Mượn/trả, quản lý độc giả

## 🤝 Đóng Góp

Contributions, issues và feature requests đều được chào đón!

### Quy Trình Đóng Góp

1. Fork repository này
2. Tạo branch mới cho feature: `git checkout -b feature/AmazingFeature`
3. Commit changes: `git commit -m 'feat: Add some AmazingFeature'`
4. Push to branch: `git push origin feature/AmazingFeature`
5. Tạo Pull Request

### Commit Convention

```
<type>(<scope>): <subject>

Types: feat, fix, docs, style, refactor, test, chore

Ví dụ:
feat(books): thêm tìm kiếm nâng cao theo nhiều tiêu chí
fix(loan): sửa lỗi tính toán ngày trả
docs(readme): cập nhật hướng dẫn cài đặt
```

## 📄 License

Dự án này được phát hành theo giấy phép **MIT License**. Xem file [LICENSE](LICENSE) để biết thêm chi tiết.

## 👥 Tác Giả

- **Vũ Văn Trung** - [GitHub](https://github.com/Vu-Van-Trung)
- **LowKeyLifeeee** - [GitHub](https://github.com/LowKeyLifeeee)
- KoliangFish - [GitHub](https://github.com/KoliangFish)

## 🙏 Lời Cảm Ơn

- **Guna Framework** - UI Components đẹp, hiện đại
- **Entity Framework Core Team** - ORM mạnh mẽ
- **Microsoft** - .NET Platform và SQL Server
- **Cộng đồng C#** - Hỗ trợ và chia sẻ kiến thức

## 📞 Liên Hệ

Nếu có câu hỏi, góp ý hoặc cần hỗ trợ:

- 📧 Email: thangminhnt20@gmail.com
- 🐛 Issues: [GitHub Issues](https://github.com/Vu-Van-Trung/Quan-Ly_Thu-Vien/issues)
- 💬 Discussions: [GitHub Discussions](https://github.com/Vu-Van-Trung/Quan-Ly_Thu-Vien/discussions)

## 🔄 Changelog

### Version 1.5 (03/01/2026) - Current
- ✨ **Bảo mật nâng cao**: Mã hóa AES-256 + RSA cho dữ liệu nhạy cảm
- ✨ **Phân quyền chi tiết**: 5 cấp độ với AccessControl
- ✨ **Audit Logging**: Ghi nhật ký đầy đủ mọi thao tác
- ✨ **Form Phạt hoàn chỉnh**: Thu phạt, miễn giảm, in phiếu
- ✨ **5 loại báo cáo**: Sách mượn nhiều, độc giả tích cực, thể loại, doanh thu, tồn kho
- ✨ **Quản lý nhà xuất bản**: Form riêng cho NXB
- 🐛 **Bug fixes**: Sửa lỗi tính toán ngày, hiển thị dữ liệu

### Version 1.0 (19/12/2025)
- ✅ Initial release
- ✅ Quản lý sách, độc giả, tác giả
- ✅ Mượn/trả sách cơ bản
- ✅ Tính phạt tự động
- ✅ Báo cáo cơ bản
- ✅ Đăng nhập và phân quyền

## 🎯 Roadmap

### Version 2.0 (Planned)
- [ ] **Web API**: RESTful API cho mobile/web client
- [ ] **Barcode Scanner**: Tích hợp quét mã vạch
- [ ] **Email/SMS**: Thông báo tự động quá hạn
- [ ] **Dashboard**: Biểu đồ thống kê real-time
- [ ] **Export PDF**: Xuất báo cáo PDF
- [ ] **Multi-language**: Hỗ trợ tiếng Anh

### Version 2.5 (Future)
- [ ] **Mobile App**: Ứng dụng di động cho độc giả
- [ ] **Cloud Sync**: Đồng bộ với cloud storage
- [ ] **AI Recommendations**: Gợi ý sách theo sở thích
- [ ] **E-Books**: Quản lý sách điện tử

---

<p align="center">
  <strong>Made with ❤️ using C#, Entity Framework Core, and SQL Server</strong>
</p>

<p align="center">
  <sub>✨ Hệ thống quản lý thư viện chuyên nghiệp cho thư viện Việt Nam ✨</sub>
</p>
