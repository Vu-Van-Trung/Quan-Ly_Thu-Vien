# Tasks

- [x] Verify existing borrowing logic in `FormLoan.cs`. <!-- id: verify-logic -->
- [x] Implement query: `int dangMuon = db.LoanDetails.Where(ld => ld.Loan.MemberId == memberId && ld.NgayTra == null).Sum(ld => (int?)ld.SoLuong) ?? 0;` <!-- id: impl-borrow-count -->
- [x] Implement query: `int noPhat = db.Fines.Count(f => f.Loan.MemberId == memberId && f.TrangThaiThanhToan == "Chưa thanh toán");` <!-- id: impl-fine-count -->
- [x] Logic: If `dangMuon + noPhat + soLuongMuonMoi > 5` then Block. <!-- id: impl-check -->
- [x] Display a warning message if the limit (5) is reached. <!-- id: display-warning -->
- [x] Verify that the check works for both creating a new Loan and adding to an existing Loan. <!-- id: verify-scenarios -->
