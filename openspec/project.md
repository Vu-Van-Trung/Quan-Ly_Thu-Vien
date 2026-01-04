# OpenSpec - Hệ Thống Quản Lý Thư Viện

## 1. Mục Đích Dự Án

### Tổng Quan
Hệ thống quản lý thư viện là một ứng dụng toàn diện giúp quản lý, theo dõi và vận hành các hoạt động của thư viện một cách hiệu quả. Hệ thống cung cấp các chức năng quản lý sách, độc giả, mượn/trả sách, và báo cáo thống kê.

### Mục Tiêu Chính
- **Số hóa quy trình**: Chuyển đổi quy trình quản lý thủ công sang hệ thống điện tử
- **Tối ưu hóa**: Giảm thiểu thời gian xử lý các giao dịch mượn/trả sách
- **Theo dõi chính xác**: Quản lý chặt chẽ tình trạng sách và thông tin độc giả
- **Báo cáo thống kê**: Cung cấp các báo cáo chi tiết về hoạt động thư viện
- **Dễ sử dụng**: Giao diện thân thiện, dễ sử dụng cho cả thủ thư và độc giả

### Đối Tượng Sử Dụng
- **Thủ thư/Quản trị viên**: Quản lý toàn bộ hệ thống
- **Nhân viên thư viện**: Xử lý mượn/trả sách, đăng ký độc giả
- **Độc giả**: Tra cứu sách, xem lịch sử mượn sách

## 2. Công Nghệ Sử Dụng

### Frontend
- **Ngôn ngữ**: HTML5, CSS3, JavaScript (hoặc TypeScript)
- **Framework**: 
  - React.js hoặc Vue.js (cho ứng dụng web hiện đại)
  - Windows Forms / WPF (cho ứng dụng desktop .NET)
- **UI Framework**: Bootstrap 5 hoặc Material-UI
- **Biểu đồ**: Chart.js hoặc Recharts

### Backend
- **Ngôn ngữ**: 
  - C# (.NET Framework/Core) - Khuyến nghị
  - hoặc Node.js với Express
  - hoặc Python với Flask/Django
- **ORM**: Entity Framework (C#), Sequelize (Node.js), hoặc SQLAlchemy (Python)
- **API**: RESTful API hoặc GraphQL

### Cơ Sở Dữ Liệu
- **SQL Server** (Primary - Khuyến nghị)
- Hoặc **MySQL/PostgreSQL** (Alternatives)
- **Công cụ quản lý**: SQL Server Management Studio (SSMS), Azure Data Studio

### Công Cụ Phát Triển
- **IDE**: Visual Studio 2022, Visual Studio Code
- **Version Control**: Git + GitHub/GitLab
- **Database Migration**: Entity Framework Migrations hoặc FlywayDB
- **Testing**: xUnit/NUnit (C#), Jest (JavaScript)

## 3. Kiến Trúc Hệ Thống

### Mô Hình Kiến Trúc
```
┌─────────────────────────────────────────┐
│         PRESENTATION LAYER              │
│  (Desktop App / Web Interface)          │
└──────────────┬──────────────────────────┘
               │
┌──────────────▼──────────────────────────┐
│         BUSINESS LOGIC LAYER            │
│  (Controllers, Services, Validators)    │
└──────────────┬──────────────────────────┘
               │
┌──────────────▼──────────────────────────┐
│         DATA ACCESS LAYER               │
│  (Repositories, ORM, Database Context)  │
└──────────────┬──────────────────────────┘
               │
┌──────────────▼──────────────────────────┐
│         DATABASE LAYER                  │
│         (SQL Server)                    │
└─────────────────────────────────────────┘
```

### Design Patterns
- **Repository Pattern**: Trừu tượng hóa data access
- **Unit of Work**: Quản lý transactions
- **Dependency Injection**: Loose coupling giữa các components
- **MVC/MVVM**: Tách biệt UI và business logic
- **Singleton**: Cho database connection management

## 4. Cơ Sở Dữ Liệu SQL

### Schema Chính

#### 4.1. Bảng SACH (Books)
```sql
- MaSach (PK) - VARCHAR(20)
- TenSach - NVARCHAR(200)
- MaTacGia (FK) - INT
- MaTheLoai (FK) - INT
- MaNhaXuatBan (FK) - INT
- NamXuatBan - INT
- SoLuongTon - INT
- ViTri - NVARCHAR(50)
- TrangThai - NVARCHAR(50)
- MoTa - NVARCHAR(MAX)
- GiaTien - DECIMAL(18,2)
- NgayNhap - DATETIME
```

#### 4.2. Bảng TAC_GIA (Authors)
```sql
- MaTacGia (PK) - INT IDENTITY
- TenTacGia - NVARCHAR(100)
- NgaySinh - DATE
- QuocTich - NVARCHAR(50)
- TieuSu - NVARCHAR(MAX)
```

#### 4.3. Bảng THE_LOAI (Categories)
```sql
- MaTheLoai (PK) - INT IDENTITY
- TenTheLoai - NVARCHAR(100)
- MoTa - NVARCHAR(500)
```

#### 4.4. Bảng NHA_XUAT_BAN (Publishers)
```sql
- MaNhaXuatBan (PK) - INT IDENTITY
- TenNhaXuatBan - NVARCHAR(200)
- DiaChi - NVARCHAR(300)
- SoDienThoai - VARCHAR(15)
- Email - VARCHAR(100)
```

#### 4.5. Bảng DOC_GIA (Readers)
```sql
- MaDocGia (PK) - VARCHAR(20)
- HoTen - NVARCHAR(100)
- NgaySinh - DATE
- GioiTinh - NVARCHAR(10)
- DiaChi - NVARCHAR(300)
- SoDienThoai - VARCHAR(15)
- Email - VARCHAR(100)
- NgayDangKy - DATETIME
- NgayHetHan - DATETIME
- TrangThai - NVARCHAR(50)
- CMND - VARCHAR(20)
```

#### 4.6. Bảng PHIEU_MUON (Borrow Receipts)
```sql
- MaPhieuMuon (PK) - VARCHAR(20)
- MaDocGia (FK) - VARCHAR(20)
- MaNhanVien (FK) - INT
- NgayMuon - DATETIME
- HanTra - DATETIME
- TrangThai - NVARCHAR(50)
- GhiChu - NVARCHAR(500)
```

#### 4.7. Bảng CHI_TIET_PHIEU_MUON (Borrow Details)
```sql
- MaChiTiet (PK) - INT IDENTITY
- MaPhieuMuon (FK) - VARCHAR(20)
- MaSach (FK) - VARCHAR(20)
- SoLuong - INT
- TinhTrangMuon - NVARCHAR(100)
- TinhTrangTra - NVARCHAR(100)
- NgayTra - DATETIME
```

#### 4.8. Bảng NHAN_VIEN (Staff)
```sql
- MaNhanVien (PK) - INT IDENTITY
- HoTen - NVARCHAR(100)
- ChucVu - NVARCHAR(50)
- NgaySinh - DATE
- GioiTinh - NVARCHAR(10)
- DiaChi - NVARCHAR(300)
- SoDienThoai - VARCHAR(15)
- Email - VARCHAR(100)
- NgayVaoLam - DATETIME
```

#### 4.9. Bảng TAI_KHOAN (User Accounts)
```sql
- MaTaiKhoan (PK) - INT IDENTITY
- TenDangNhap - VARCHAR(50) UNIQUE
- MatKhau - VARCHAR(255)
- MaNhanVien (FK) - INT
- QuyenHan - NVARCHAR(50)
- TrangThai - NVARCHAR(20)
- NgayTao - DATETIME
```

#### 4.10. Bảng PHAT (Fines)
```sql
- MaPhat (PK) - INT IDENTITY
- MaPhieuMuon (FK) - VARCHAR(20)
- LyDo - NVARCHAR(500)
- SoTienPhat - DECIMAL(18,2)
- NgayPhat - DATETIME
- TrangThaiThanhToan - NVARCHAR(50)
```

### Relationships
- TAC_GIA 1-N SACH
- THE_LOAI 1-N SACH
- NHA_XUAT_BAN 1-N SACH
- DOC_GIA 1-N PHIEU_MUON
- NHAN_VIEN 1-N PHIEU_MUON
- PHIEU_MUON 1-N CHI_TIET_PHIEU_MUON
- SACH 1-N CHI_TIET_PHIEU_MUON
- NHAN_VIEN 1-1 TAI_KHOAN
- PHIEU_MUON 1-N PHAT

## 5. Chức Năng Chính

### 5.1. Quản Lý Sách
- ✅ Thêm sách mới (nhập thông tin đầy đủ)
- ✅ Cập nhật thông tin sách
- ✅ Xóa sách (soft delete hoặc hard delete)
- ✅ Tìm kiếm sách (theo tên, tác giả, thể loại, mã sách)
- ✅ Phân loại sách theo thể loại
- ✅ Quản lý số lượng tồn kho
- ✅ Import/Export danh sách sách (Excel, CSV)

### 5.2. Quản Lý Độc Giả
- ✅ Đăng ký độc giả mới
- ✅ Cập nhật thông tin độc giả
- ✅ Xóa/Khóa tài khoản độc giả
- ✅ Tìm kiếm độc giả
- ✅ Gia hạn thẻ độc giả
- ✅ Xem lịch sử mượn sách của độc giả

### 5.3. Quản Lý Mượn/Trả Sách
- ✅ Tạo phiếu mượn sách
- ✅ Xử lý trả sách
- ✅ Gia hạn phiếu mượn
- ✅ Kiểm tra tình trạng sách khi trả
- ✅ Tính toán phạt tự động (trễ hạn, hư hỏng)
- ✅ Xem danh sách sách đang mượn
- ✅ Cảnh báo sách quá hạn

### 5.4. Quản Lý Phạt
- ✅ Tự động tính phạt trễ hạn
- ✅ Phạt hư hỏng/mất sách
- ✅ Thu tiền phạt
- ✅ Xem lịch sử phạt
- ✅ Báo cáo công nợ

### 5.5. Báo Cáo & Thống Kê
- ✅ Báo cáo sách được mượn nhiều nhất
- ✅ Thống kê theo thể loại
- ✅ Báo cáo độc giả tích cực
- ✅ Thống kê doanh thu (phạt, thẻ độc giả)
- ✅ Báo cáo tồn kho
- ✅ Biểu đồ thống kê theo thời gian
- ✅ Export báo cáo (PDF, Excel)

### 5.6. Quản Lý Hệ Thống
- ✅ Đăng nhập/Đăng xuất
- ✅ Phân quyền người dùng (Admin, Staff, Reader)
- ✅ Quản lý nhân viên
- ✅ Sao lưu/Phục hồi dữ liệu
- ✅ Cấu hình hệ thống
- ✅ Nhật ký hoạt động (Audit Log)

## 6. Quy Ước Code

### Naming Conventions
- **Class**: PascalCase (VD: `BookManager`, `ReaderService`)
- **Method**: PascalCase (VD: `GetBookById`, `AddNewReader`)
- **Variable/Parameter**: camelCase (VD: `bookId`, `readerName`)
- **Constant**: UPPER_SNAKE_CASE (VD: `MAX_BORROW_DAYS`, `DEFAULT_FINE`)
- **Database**: UPPER_SNAKE_CASE cho bảng, PascalCase cho stored procedures

### Code Style
- **Indentation**: 4 spaces (C#), 2 spaces (JavaScript)
- **Encoding**: UTF-8 with BOM
- **Line Length**: Tối đa 120 characters
- **Comments**: Tiếng Việt có dấu cho business logic, English cho technical comments
- **XML Documentation**: Bắt buộc cho public methods và classes

### Project Structure
```
Quan-Ly_Thu-Vien/
├── src/
│   ├── Core/                    # Business logic
│   │   ├── Entities/           # Domain models
│   │   ├── Interfaces/         # Contracts
│   │   └── Services/           # Business services
│   ├── Infrastructure/          # Data access
│   │   ├── Data/               # DbContext, Migrations
│   │   └── Repositories/       # Data repositories
│   ├── Application/            # Use cases
│   │   ├── DTOs/               # Data transfer objects
│   │   └── Validators/         # Input validation
│   └── Presentation/           # UI layer
│       ├── Forms/              # Windows Forms
│       ├── Controllers/        # API controllers
│       └── Views/              # Web views
├── tests/                      # Unit & Integration tests
├── database/                   # SQL scripts
│   ├── schema.sql
│   ├── seed-data.sql
│   └── stored-procedures/
├── docs/                       # Documentation
└── openspec/                   # Project specs
```

## 7. Chiến Lược Testing

### Unit Tests
- Test các service methods
- Test validation logic
- Test business rules
- Coverage tối thiểu: 70%

### Integration Tests
- Test database operations
- Test API endpoints
- Test workflows end-to-end

### Manual Testing
- Test UI/UX
- Test performance với dữ liệu lớn
- Test security và authorization

## 8. Git Workflow

### Branching Strategy
- `main`: Production-ready code
- `develop`: Development branch
- `feature/*`: Feature branches
- `bugfix/*`: Bug fix branches
- `hotfix/*`: Emergency fixes

### Commit Conventions
```
<type>(<scope>): <subject>

[optional body]

VD:
feat(books): thêm chức năng tìm kiếm nâng cao
fix(borrow): sửa lỗi tính toán ngày trả
docs(readme): cập nhật hướng dẫn cài đặt
```

Types: `feat`, `fix`, `docs`, `style`, `refactor`, `test`, `chore`

## 9. Ràng Buộc & Yêu Cầu

### Yêu Cầu Kỹ Thuật
- Hỗ trợ SQL Server 2016 trở lên
- Tương thích Windows 10/11
- .NET Framework 4.7.2+ hoặc .NET 6+
- SQL Connection pooling để tối ưu performance

### Business Rules
- Độc giả chỉ được mượn tối đa 5 quyển sách cùng lúc
- Thời gian mượn mặc định: 14 ngày
- Phạt trễ hạn: 5,000 VNĐ/ngày/sách
- Thẻ độc giả có thời hạn 1 năm

### Security Requirements
- Mã hóa mật khẩu (BCrypt hoặc SHA-256)
- SQL Injection prevention (Parameterized queries)
- Role-based access control (RBAC)
- Audit logging cho các thao tác quan trọng
- Session timeout: 30 phút

### Performance Requirements
- Thời gian tải trang: < 2 giây
- Hỗ trợ tối thiểu 100 concurrent users
- Database backup hàng ngày
- Response time API: < 500ms

## 10. Dependencies & Integrations

### External Libraries
- **Dapper** hoặc **Entity Framework Core**: ORM
- **AutoMapper**: Object mapping
- **FluentValidation**: Input validation
- **Serilog**: Logging framework
- **EPPlus** hoặc **ClosedXML**: Excel export/import
- **iTextSharp** hoặc **QuestPDF**: PDF generation
- **BCrypt.Net**: Password hashing

### Optional Integrations
- Email service (MailKit) - Gửi thông báo quá hạn
- SMS gateway - Nhắc nhở trả sách
- Barcode scanner - Quét mã sách
- Report viewer (Crystal Reports, RDLC)

## 11. Deployment & Maintenance

### Deployment
- **Local**: Standalone application với SQL Server Express
- **Network**: Client-Server model với SQL Server Standard
- **Cloud**: Azure SQL Database (optional)

### Backup Strategy
- Full backup: Hàng tuần
- Differential backup: Hàng ngày
- Transaction log backup: Mỗi 4 giờ

### Monitoring
- Database performance monitoring
- Application error logging
- User activity tracking

---

**Phiên bản**: 1.0  
**Ngày tạo**: 19/12/2025  
**Tác giả**: LowKeyLifeeeee  
**Trạng thái**: Draft - Chờ phê duyệt