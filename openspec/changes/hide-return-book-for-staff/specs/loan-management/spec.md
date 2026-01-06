# Loan Management Specs

## MODIFIED Requirements

### Staff Loan Permissions
Staff members are restricted from performing book return actions within the Loan Management form.

#### Scenario: Staff opening Loan Form
- Given I am logged in as a "Nhân viên"
- When I open the "Mượn sách" (Loan Management) form
- Then the "Trả Sách" button should NOT be visible
