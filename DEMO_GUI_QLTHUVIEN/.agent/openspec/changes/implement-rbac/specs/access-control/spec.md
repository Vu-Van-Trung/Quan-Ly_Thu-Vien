# Access Control Specs

## ADDED Requirements

### Access Control Logic
The system must restrict access to application features based on the logged-in user's role.

#### Scenario: Admin Access
- Given I am logged in as "Quản trị viên"
- When I view the main menu
- Then I see all menu items including "Quản lý Tài Khoản", "Cài đặt & Dữ liệu", "Quản lý Nhân viên".

#### Scenario: Librarian Access
- Given I am logged in as "Thủ thư" (or "Thủ thư trưởng")
- When I view the main menu
- Then I do NOT see "Quản lý Tài Khoản", "Cài đặt & Dữ liệu", "Quản lý Nhân viên".
- And I see "Quản lý Sách", "Quản lý Mượn/Trả", "Quản lý Độc giả", "Báo cáo & Thống kê", "Nhật Ký Hệ Thống", "Phiếu Phạt".

#### Scenario: Staff Access
- Given I am logged in as "Nhân viên"
- When I view the main menu
- Then I do NOT see "Quản lý Tài Khoản", "Cài đặt & Dữ liệu", "Quản lý Nhân viên", "Phiếu Phạt", "Báo cáo & Thống kê", "Nhật Ký Hệ Thống".
- And I see "Quản lý Sách" but in Read-Only mode.
- And I see "Quản lý Mượn/Trả", "Quản lý Độc giả".

### Read-Only Forms
Specific forms must adapt their UI to disable modification features for restricted roles.

#### Scenario: Staff Viewing Books
- Given I am logged in as "Nhân viên"
- When I open "Quản lý Sách"
- Then the "Thêm", "Sửa", "Xóa" buttons are hidden or disabled.
- And I cannot modify book details.
