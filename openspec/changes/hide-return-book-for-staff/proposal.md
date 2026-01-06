# Hide Return Book Button for Staff

## Description
Hide the "Trả Sách" (Return Book) button in the Loan Management form (`FormLoan`) when the logged-in user has the "Nhân viên" (Staff) role.

## Justification
The user explicitly requested that the "Trả Sách" button should be hidden for staff members in the `FormLoan` interface. This aligns with the previous decision to restrict fine and return management to Librarians and Admins.

## Impact
- **Modified**: `FormLoan.cs`
    - Update `FormLoan_Load` to check `Session.CurrentRole` and set `btnTraSach.Visible = false` if the role is `RoleStaff`.
- **Risk**: Low. UI-only change specifically targeting one role.
