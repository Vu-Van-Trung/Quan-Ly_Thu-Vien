# Design: Fix Account Data Loading

## Local DTO Classes
We will define simple classes within the `QuanLyTaiKhoan` namespace (or nested in the form) to hold the view data.

```csharp
public class StaffDisplayItem
{
    public int StaffId { get; set; }
    public string HoTen { get; set; }
}

public class UserDisplayItem
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string StaffName { get; set; }
    public string Role { get; set; }
    public string TrangThai { get; set; }
    public int StaffId { get; set; }
    public DateTime? LanDangNhapCuoi { get; set; }
}
```

## Logic Update
### LoadComboBoxes
```csharp
var staffList = db.Staff.ToList()
    .Select(s => new StaffDisplayItem {
        StaffId = s.StaffId,
        HoTen = LibraryManagement.Security.CryptoHelper.Decrypt(s.HoTen)
    }).ToList();
cbNhanVien.DataSource = staffList;
```

### LoadData
```csharp
var users = db.Users.Include(u => u.Staff).ToList()
    .Select(u => new UserDisplayItem {
        Id = u.Id,
        Username = u.Username,
        StaffName = u.Staff != null ? LibraryManagement.Security.CryptoHelper.Decrypt(u.Staff.HoTen) : "N/A",
        Role = u.Role,
        TrangThai = u.TrangThai,
        StaffId = u.StaffId,
        LanDangNhapCuoi = u.LanDangNhapCuoi
    }).ToList();
dgvTaiKhoan.DataSource = users;
```
