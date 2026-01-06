# Fix Account Loading Error (Relationship Severed)

## Description
Modify how the `User` entity is loaded and displayed in `QuanLyTaiKhoan.cs` to avoid Entity Framework Core tracking issues that lead to the "The association between entity types 'Staff' and 'User' has been severed" error.

## Justification
The error message indicates that EF Core's change tracker detects a broken relationship between a `User` and its required `Staff` entity. This often happens when entities are loaded, then modified or projected, and then re-accessed or saved while still attached to the context in a conflicting state. By using `.AsNoTracking()` for read-only display operations, we can decouple the retrieved data from the context's state manager, preventing this validation error during data loading.

## Impact
- **Modified**: `QuanLyTaiKhoan.cs`
    - Update `LoadComboBoxes`: Use `.AsNoTracking()` when fetching staff.
    - Update `LoadData`: Use `.AsNoTracking()` when fetching users.
- **Risk**: Low. This is a standard practice for read-only data grids in EF Core.
