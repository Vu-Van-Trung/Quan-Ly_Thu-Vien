# Update Author DOB Range

## Description
Update the allowed Date of Birth range for Authors in `QuanLiTacGia`:
- Minimum Date: Year 1700.
- Maximum Date: Current Date minus 15 years.
- Valid Age: 15 years old (updated from 18).

## Justification
The user explicitly requested to adjust the date limits (`min 1700` and `max = now - 15`). This implies a business rule change regarding the minimum age of an author (lowering it to 15) and expanding the historical range to 1700.

## Impact
- **Modified**: `QuanLiTacGia.Designer.cs`
    - Update `dtpNgaySinh.MinDate` to `01/01/1700`.
- **Modified**: `QuanLiTacGia.cs`
    - In `QuanLiTacGia_Load`, set `dtpNgaySinh.MaxDate` to `DateTime.Now.AddYears(-15)`.
    - Update `ValidateForm` to check for age >= 15 instead of 18.
- **Risk**: Low. Business rule adjustment.
