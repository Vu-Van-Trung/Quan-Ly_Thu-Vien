# Tasks

1. Modify `FormLoan.cs` in `btnThem_Click`: - [x]
   - **Task 1: Expiry Check**: Add check for `member.NgayHetHan` after the status check.
   - **Task 2: Unpaid Fine Check**: Query `db.Fines` where `Loan.MemberId == memberId` and `TrangThaiThanhToan == "Chưa thanh toán"`. Using `db.Fines.Any(f => f.Loan.MemberId == memberId && f.TrangThaiThanhToan == "Chưa thanh toán")`.
2. Verify: - [x]
   - Test with a member who has expired card.
   - Test with a member who has unpaid fines.
