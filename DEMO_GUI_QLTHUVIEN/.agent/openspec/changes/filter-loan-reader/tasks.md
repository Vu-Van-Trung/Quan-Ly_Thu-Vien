# Tasks

1. Modify `FormLoan.Designer.cs` to add `txtTenDocGia` (TextBox) and configure `cbMaDocGia`. - [x]
2. Update `FormLoan.cs` `LoadComboBoxes` to bind `DisplayMember` of `cbMaDocGia` to `MemberId` (or format selection). - [x]
3. Implement `cbMaDocGia_SelectedIndexChanged` in `FormLoan.cs` to: - [x]
   - Update `txtTenDocGia.Text`.
   - Filter `bindingSource` of `dgvSachMuon` by `MemberId`.
4. Add logic to handle "Show All" or clearing the filter (optional but good for UX, maybe a 'Clear' button or logic). - [x] (Implemented via clear if no selection)
