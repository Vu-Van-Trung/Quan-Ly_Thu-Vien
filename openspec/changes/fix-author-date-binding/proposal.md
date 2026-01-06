# Fix Author Date Binding

## Description
Update `QuanLiTacGia.cs` to correctly verify bounds before assigning `dtpNgaySinh.Value`.

## Justification
The user reported a crash/error specifically at `dtpNgaySinh.Value = dt;`. The `DateTimePicker` control in WinForms throws an exception if the assigned value is less than `MinDate` (usually 1/1/1753) or greater than `MaxDate`. If the grid cell contains an invalid or very old date (or if parsing fails in a weird way), this assignment causes the crash. We need to clamp or validate the `dt` value before assignment.

## Impact
- **Modified**: `QuanLiTacGia.cs`
    - Update `dgvAuthors_CellClick` to clamp `dt` between `DateTimePicker.MinDate` and `DateTimePicker.MaxDate` before assignment.
- **Risk**: Low. Increases stability of the form.
