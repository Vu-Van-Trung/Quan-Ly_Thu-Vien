# Move Author Error Label

## Description
Move the error label (`lblError`) in `QuanLiTacGia` to the right of the "Xóa trắng" button to avoid overlap, and ensure it is cleared when selecting a row from the grid.

## Justification
The user reported that `lblError` is overlapping/overwriting other UI elements (specifically checking "Xóa trắng") and should be positioned to the right. Additionally, the validation error message should not appear immediately when selecting a valid row from the grid; it should only appear when validation fails during input or saving.

## Impact
- **Modified**: `QuanLiTacGia.Designer.cs`
    - Update `lblError` location (increase X coordinate).
- **Modified**: `QuanLiTacGia.cs`
    - In `dgvAuthors_CellClick`, explicitly clear `lblError.Text` (or call a method that clears it) instead of triggering validation immediately, OR ensure validation passes quietly. The user mentioned "không hiện khi click vào dataview", implying we should likely suppress or clear the error on selection.
- **Risk**: Low. UI tweak.
