# Revert Staff Fines Access

## Description
Remove `RoleStaff` ("Nhân viên") from the allowed roles for "ManageFines" in `AccessControl.cs`.

## Justification
The user requested to "return to the old state" ("trả lại trạng thái cũ"), effectively reversing the previous decision to grant Staff access to the Fines and Returns management form.

## Impact
- **Modified**: `AccessControl.cs`
    - Remove `RoleStaff` from `ManageFines`.
- **Risk**: Low. Reverts to previous behavior.
