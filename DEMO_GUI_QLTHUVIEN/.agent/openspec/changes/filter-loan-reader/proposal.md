# Filter Loan by Reader ID & Locked Reader Name

## Goal
Enhance `FormLoan` to allow filtering loan records by Reader ID and improve the UI by explicitly separating Reader ID selection and Reader Name display.

## Requirements
1.  **Filter by Reader ID**:
    - The main list of loans (`dgvSachMuon`) should be filterable by Reader ID.
    - Selecting a Reader ID in the input area should trigger this filter.
2.  **Locked Reader Name**:
    - Add a specialized `txtTenDocGia` (Reader Name) text box.
    - This box must be **Read-Only** (Locked).
    - It should only display data when a valid Reader ID is selected in `cbMaDocGia`.
    - `cbMaDocGia` should now primarily serve to select/display the **Member ID**, while `txtTenDocGia` shows the name.

## Design
- **Form**: `FormLoan`
- **Controls**:
    - Modify `cbMaDocGia`: Set `DisplayMember` to `MemberId`.
    - Add `txtTenDocGia`: Placed near `cbMaDocGia`. Status: `ReadOnly`.
- **Events**:
    - `cbMaDocGia_SelectedIndexChanged`:
        - Update `txtTenDocGia.Text` with the selected member's name.
        - Filter `dgvSachMuon` to match `MemberId`.
