# Tasks for Author Management

## 1. UI Implementation
- [ ] 1.1 Add menu button "Quản Lý Tác Giả" to `QuanLiThuVien.Designer.cs` inside `pnlMenuContainer`.
- [ ] 1.2 Create new form `QuanLiTacGia` with Designer file.
  - DataGridView to list authors (columns: AuthorId, Name, QuocTich, NgaySinh, Bio).
  - TextBoxes for Name, QuocTich, NgaySinh (DateTimePicker), Bio.
  - Buttons: Thêm, Cập nhật, Xóa, Clear.
- [ ] 1.3 Wire button click to open `QuanLiTacGia` form in `QuanLiThuVien.cs`.

## 2. Backend Service
- [ ] 2.1 Create `AuthorService.cs` with CRUD methods using `LibraryContext`.
- [ ] 2.2 Inject `AuthorService` where needed (e.g., in `QuanLiTacGia` form).

## 3. Integration
- [ ] 3.1 Ensure `QuanLiTacGia` loads authors via `AuthorService` and binds to DataGridView.
- [ ] 3.2 Implement Add/Update/Delete operations calling service and refreshing grid.

## 4. Verification
- [ ] 4.1 Run application, open Author Management, verify UI works and data persists.
- [ ] 4.2 Ensure designer files are correctly generated for future edits.

## 5. Documentation
- [ ] 5.1 Update `openspec/changes/add-author-management/proposal.md` if needed.
- [ ] 5.2 Mark all tasks as completed.
