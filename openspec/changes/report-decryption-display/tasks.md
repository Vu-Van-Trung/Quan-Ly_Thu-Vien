# Tasks: Display Decrypted Data in Reports

- [x] Refactor `GenerateActiveMembersReport` in `FormReport.cs` <!-- id: 0 -->
    - Fetch raw data first.
    - Decrypt `FullName`, `PhoneNumber`, `Email`.
    - Bind decrypted list to Grid.
- [x] Refactor `GenerateFineRevenueReport` in `FormReport.cs` <!-- id: 1 -->
    - Decrypt `Member.FullName`.
- [x] Refactor `GenerateInventoryReport` in `FormReport.cs` <!-- id: 2 -->
    - Decrypt `Publisher.TenNhaXuatBan`.
    - Verify if `Author.Name` requires decryption (currently assumed plain, but verify).
- [x] Refactor `GenerateMostBorrowedBooksReport` in `FormReport.cs` <!-- id: 3 -->
    - Verify and decrypt `Author.Name` if necessary.
- [x] Verify Excel Export functionality <!-- id: 4 -->
    - Ensure `BtnExport_Click` uses the Grid's content (which is now decrypted) so the exported file is readable.
