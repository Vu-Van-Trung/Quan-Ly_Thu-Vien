# Role-Based Access Control (RBAC) Implementation

## Goal
Implement a permission system based on the user's role (Admin, Librarian, Staff) to control access to various forms and functionalities within the application.

## Roles
- **Quản trị viên (Admin)**: Full access.
- **Thủ thư (Librarian)**: Manage books, loans, members, reports. View logs. No access to accounts, settings, staff.
- **Nhân viên (Staff)**: Manage loans, members. View books. No access to other management forms.

## Scope
1. **Menu Visibility (`QuanLiThuVien.cs`)**:
   - Dynamically build the menu based on the current user's role.
   - Hide menu items for unauthorized forms.

2. **Form Level Access (`QuanLiSach.cs`)**:
   - Implement read-only mode for "Nhân viên" to allow viewing books without editing capability.

## Matrix Implementation
| Function | Form | Admin | Librarian | Staff |
| :--- | :--- | :--- | :--- | :--- |
| Accounts | `QuanLyTaiKhoan` | Full | - | - |
| Settings | `FormSettings` | Full | - | - |
| Staff | `FormStaff` | Full | - | - |
| Dashboard | `QuanLiThuVien` | Full | Full | View |
| Books | `QuanLiSach` | Full | Full | View (Read-only) |
| Loans | `FormLoan` | Full | Full | Full |
| Fines | `FormFine` | Full | Full | - |
| Members | `FormMember` | Full | Full | Full |
| Reports | `FormReport` | Full | Full | - |
| Logs | `QuanLiNhatKy` | Full | View | - |
