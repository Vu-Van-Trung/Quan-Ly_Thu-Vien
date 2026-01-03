# Design

## 1. Access Control Logic
We will introduce a `Security/AccessControl.cs` static class.
It will contain:
- Constants for Roles: `RoleAdmin`, `RoleLibrarian`, `RoleStaff`.
- A method `bool CanAccess(string formKey)` or `bool CanAccess(Type formType)`.

However, since `QuanLiThuVien` uses string keys for menu actions, we can map permissions to these keys.

### Menu Keys & Permissions
- `ManageAccounts`: Admin
- `Settings`: Admin
- `ManageStaff`: Admin
- `ManageBooks`: Admin, Librarian, Staff (View)
- `ManageLoans`: Admin, Librarian, Staff
- `ManageFines`: Admin, Librarian
- `ManageMembers`: Admin, Librarian, Staff
- `Reports`: Admin, Librarian
- `ViewLogs`: Admin, Librarian

## 2. Form Specific Logic

### QuanLiSach (Books)
- **Role**: Staff
- **Behavior**: 
    - Hide/Disable: `btnAdd`, `btnEdit`, `btnDelete`.
    - Functionality: Grid View only, Search allowed. `DoubleClick` (Edit) should be disabled or open in View-Only mode.

### QuanLiNhatKy (System Logs)
- **Role**: Librarian.
- **Behavior**: The form is already read-only (View Logs). Access is controlled via Menu visibility. If a Librarian manages to open it, they can only view, which is the default.

## 3. Implementation Details
In `QuanLiThuVien.SetupDefaultMenuActions`:
```csharp
if (AccessControl.CanAccess("ManageBooks")) AddMenuAction(...)
```
Or simply put the logic inline if it's simple enough, but a separate class is cleaner.
