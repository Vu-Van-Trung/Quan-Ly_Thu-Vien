# Audit Logging Specs

## MODIFIED Requirements

### Librarian Log Visibility
The system must allow users with the "Thủ thư" role to view activity logs for all functions they are authorized to manage.

#### Scenario: Librarian views Borrow/Return logs
- Given I am logged in as a "Thủ thư"
- When I open the "Nhật ký hoạt động" (System Log)
- Then I should see entries where "Chức năng" is "Quản lý Mượn Trả"

#### Scenario: Librarian views Member logs
- Given I am logged in as a "Thủ thư"
- When I open the "Nhật ký hoạt động"
- Then I should see entries where "Chức năng" is "Quản lý Độc giả"

#### Scenario: Librarian views Author/Publisher logs
- Given I am logged in as a "Thủ thư"
- When I open the "Nhật ký hoạt động"
- Then I should see entries where "Chức năng" is "Quản lý Tác Giả" or "Quản lý Nhà Xuất Bản"
