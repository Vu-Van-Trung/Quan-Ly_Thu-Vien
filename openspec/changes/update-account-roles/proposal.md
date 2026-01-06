# Update Account Roles

## Description
Modify the available roles in the Account Management form (`QuanLyTaiKhoan`) to be "Thủ thư" (Librarian) and "Nhân viên" (Staff), replacing the previous selection (e.g. "Quản trị viên").

## Justification
The user has requested that account creation/management should be restricted to "Thủ thư" and "Nhân viên" roles. This prevents the creation of arbitrary "Quản trị viên" accounts via this form and aligns with the desired role structure.

## Impact
- **Modified**: `QuanLyTaiKhoan.cs`
- **Risk**: Low. Existing "Quản trị viên" accounts will persist in DB, but new ones cannot be created via UI, and existing ones cannot be set to Admin via UI (unless they already are, but the UI might not show it correctly if not in list).
- **Note**: This change acts on the UI dropdown population.
