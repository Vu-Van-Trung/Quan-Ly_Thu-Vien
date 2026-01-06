# Access Control Specs

## MODIFIED Requirements

### Fines Management Access
The system must restrict the Fines and Returns management interface to Librarian and Admin roles only.

#### Scenario: Staff accessing Fines menu
- Given I am logged in as a "Nhân viên"
- When I look at the main menu
- Then I should NOT see the "Phiếu Phạt & Trả Sách" option
