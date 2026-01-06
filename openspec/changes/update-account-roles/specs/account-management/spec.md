# Account Management Role Specs

## MODIFIED Requirements

### Role Selection
The system must restrict the available role options in the Account Management form.

#### Scenario: Admin creates a new account
- Given I am on the Account Management form
- When I open the "Quyền hạn" (Role) dropdown
- Then I should see "Thủ thư" and "Nhân viên" as the only options
- And I should NOT see "Quản trị viên"
