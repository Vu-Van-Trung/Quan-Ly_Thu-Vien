# Access Control Specs

## MODIFIED Requirements

### Fines Management Access
The system must allow users with the "Nhân viên" role to access the Fines and Returns management interface.

#### Scenario: Staff accessing Fines menu
- Given I am logged in as a "Nhân viên"
- When I look at the main menu
- Then I should see the "Phiếu Phạt & Trả Sách" option
- And clicking it should open the `FormFine` screen
