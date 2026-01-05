# Tasks

- [x] Update `FineService.ReturnBook` to check for full completion of the Loan. <!-- id: update-service-return -->
- [x] Logic: `if (!AllLoanDetails.Any(ld => ld.NgayTra == null)) { Loan.TrangThai = "Đã trả"; Loan.NgayTraThucTe = DateTime.Now; }` <!-- id: logic-update-status -->
- [x] Update `FormFine.ProcessPayForRows` to call `CheckRefreshParent()`. <!-- id: update-ui-refresh -->
