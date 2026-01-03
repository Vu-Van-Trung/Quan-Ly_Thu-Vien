# Tasks

1. Create `Security/AccessControl.cs` to manage role definitions and permission logic.
2. Modify `QuanLiThuVien.cs` to filter menu items based on `AccessControl.IsAuthorized`.
3. Modify `QuanLiSach.cs` to accept a role or check `Session.CurrentRole` and disable modification buttons (`btnAdd`, `btnEdit`, `btnDelete`) and enable `ReadOnly` modes for inputs if the user is "Nhân viên".
4. Verify `QuanLiNhatKy` access (ensure only Admin/Librarian can open it via menu).
5. Verify `FormFine` and `FormReport` access (ensure Staff cannot open them).
