# Account Data Loading Specs

## MODIFIED Requirements

### Robust Data Binding
The Account Management form must successfully load and display staff and user data without errors.

#### Scenario: Opening the Form
- Given I open the "Quản lý Tài khoản" form
- Then the staff dropdown should be populated with decrypted names
- And the account list should be populated with user details including decrypted staff names
- And no error message ("Lỗi tải dữ liệu...") should appear
