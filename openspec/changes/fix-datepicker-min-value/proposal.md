# Fix DateTimePicker MinValue

## Description
Change `dtpNgaySinh.MinDate` from `1700` to `1753` in `QuanLiTacGia.Designer.cs`.

## Justification
The user reported an error when setting `MinDate` to `01/01/1700`. This is a known limitation of the standard Windows `DateTimePicker` control (and likely the Guna UI wrapper), which relies on the underlying Win32 control. The minimum supported date for the standard DateTimePicker is **January 1, 1753** (related to SQL Server `DATETIME` compatibility and the switch from Julian to Gregorian calendars in Britain). Setting it lower causes a runtime crash.

## Impact
- **Modified**: `QuanLiTacGia.Designer.cs`
    - Update `dtpNgaySinh.MinDate` to `new DateTime(1753, 1, 1, 0, 0, 0, 0)`.
- **Risk**: Low. Fixes a crash.
