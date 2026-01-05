# Design

## Logic
The check resides in the `FormLoan.cs` `btnThem_Click` (and potentially `btnSua_Click` if modifying quantities).

### Formula
```csharp
// 1. Calculate Active Borrowed Books
int dangMuon = db.LoanDetails
    .Where(ld => ld.Loan.MemberId == memberId && ld.NgayTra == null)
    .Sum(ld => (int?)ld.SoLuong) ?? 0;

// 2. Calculate Unpaid Fines (assuming 1 Fine = 1 unit of penalty/risk blocking a book slot)
int noPhat = db.Fines
    .Count(f => f.Loan.MemberId == memberId && f.TrangThaiThanhToan == "Chưa thanh toán");

// 3. Condition
if (dangMuon + noPhat + soLuongMuonMoi > 5)
{
    MessageBox.Show(
        "Độc giả đã đạt giới hạn mượn tối đa 5 cuốn sách (bao gồm sách đang mượn và phạt chưa đóng).",
        "Cảnh báo",
        MessageBoxButtons.OK,
        MessageBoxIcon.Warning
    );
    return;
}
```

## UI
Use standard `MessageBox` with `MessageBoxIcon.Warning`.
Message: "Độc giả đã đạt giới hạn mượn tối đa 5 cuốn sách."
