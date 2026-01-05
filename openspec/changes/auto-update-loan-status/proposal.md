# Auto-Update Loan Status and Interface

## Summary
Automatically update the `Loan` status to "Finished" when all books are returned, and ensure the UI (specifically borrowing limits) reflects changes immediately after fines are paid or books are returned.

## Motivation
Currently, when a user returns all books, the Loan might still appear as "In Progress" or "Active" if the status isn't explicitly updated. Furthermore, paying a fine in the `FormFine` dialog doesn't automatically unlock the borrowing capability in the parent `FormLoan` until a manual refresh occurs, causing user friction.

## Proposed Solution
1.  **Update `FineService.ReturnBook`**:
    -   Check if *all* books in the Loan are returned (active count == 0).
    -   If yes, set `Loan.TrangThai = "Đã trả"` (or generic "Completed" status) and `Loan.NgayTraThucTe = DateTime.Now`.
2.  **Update `FormFine`**:
    -   Ensure `CheckRefreshParent()` is called after **paying fines** (currently only called after returning books).
