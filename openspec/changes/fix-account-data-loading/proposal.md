# Fix Account Data Loading

## Description
Refactor the data loading logic in `QuanLyTaiKhoan.cs` to use concrete Data Transfer Objects (DTOs) instead of anonymous types for databinding.

## Justification
The user reported a data loading error after the recent switch to client-side decryption. This is likely due to WinForms databinding having trouble reflecting on the properties of the anonymous types generated in the LINQ query, or potentially an unhandled null referencing issue with the `Staff` navigation property during the object construction. Using concrete classes ensures public properties are correctly exposed for binding and allows for more robust error handling during the mapping process.

## Impact
- **Modified**: `QuanLyTaiKhoan.cs`
    - Add internal classes `StaffDisplayItem` and `UserDisplayItem`.
    - Update `LoadComboBoxes` to use `StaffDisplayItem`.
    - Update `LoadData` to use `UserDisplayItem`.
- **Risk**: Low. Improves stability of data binding.
