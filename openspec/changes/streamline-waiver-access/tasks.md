# Tasks

- [x] Update `FormFine.cs`: Implement `CrossHighlightFines` in `dgvBooks_CellClick`/`SelectionChanged` to select fines containing the book's title in `dgvFines`. <!--id: cross-highlight-->
- [x] Update `FormFine.cs`: Modify `ProcessReturnForRows` to change the final MessageBox to a `YesNo` dialog: "Phạt quá hạn: X VNĐ. Bạn có muốn xử lý (miễn giảm/thanh toán) ngay không?". If Yes -> Select fines -> Open `FormWaiver`. <!--id: auto-prompt-->
- [x] Verify/Update `FormLoan.cs`: Ensure `LoadData` fetches fresh data from DB (refresh `LibraryContext` if needed) and `FormFine` calls `CheckRefreshParent` effectively. <!--id: sync-check-->
