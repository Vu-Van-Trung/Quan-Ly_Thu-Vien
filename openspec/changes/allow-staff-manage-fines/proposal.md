# Allow Staff Manage Fines

## Description
Update the Access Control policy to allow the "Nhân viên" (Staff) role to access the "ManageFines" (Phiếu Phạt & Trả Sách) functionality.

## Justification
The user explicitly requested that the "Nhân viên" role should have the capability to handle fines and book returns ("phạt và trả"), which is currently restricted to Librarians and Admins.

## Impact
- **Modified**: `AccessControl.cs`
    - Add `RoleStaff` to the allowed list for "ManageFines".
- **Risk**: Low. Grants existing functionality to an additional role.
