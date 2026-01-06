# Design: Decrypt Staff Names

## Implementation Details
We will use `LibraryManagement.Security.CryptoHelper.Decrypt` to process the staff names fetched from the database.

### `LoadComboBoxes`
Fetch the list of staff, then use LINQ to project a new anonymous type or class where `HoTen` is decrypted.

```csharp
var staffList = db.Staff.ToList() // Force client-side evaluation for decryption
    .Select(s => new { 
        s.StaffId, 
        HoTen = LibraryManagement.Security.CryptoHelper.Decrypt(s.HoTen) 
    })
    .ToList();
```

### `LoadData`
Similarly for `LoadData`, fetch the user list with staff included, then process in memory.

```csharp
var users = db.Users
    .Include(u => u.Staff)
    .ToList() // Bring to memory
    .Select(u => new
    {
        u.Id,
        u.Username,
        StaffName = u.Staff != null ? LibraryManagement.Security.CryptoHelper.Decrypt(u.Staff.HoTen) : "N/A",
        u.Role,
        u.TrangThai,
        u.StaffId,
        u.LanDangNhapCuoi
    })
    .ToList();
```

## Considerations
- **Performance**: Fetching all staff and users into memory is acceptable for the expected scale (hundreds/thousands of records).
- **Null Safety**: Check for null `Staff` when projecting `StaffName`.
