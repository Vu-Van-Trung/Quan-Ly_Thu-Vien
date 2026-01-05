# Design

## Logic (FineService)
In `ReturnBook(int loanDetailId, ...)`:
1. Update `LoanDetail`.
2. Fetch `Loan` with *all* details.
   - *Note: `_context` is shared, so `detail.Loan` might be accessible via navigation if loaded, or query it.*
3. Check: `bool isFullyReturned = !context.LoanDetails.Any(ld => ld.LoanId == loanId && ld.NgayTra == null);`
4. If true:
   ```csharp
   var loan = _context.Loans.Find(loanId);
   loan.TrangThai = "Đã trả";
   loan.NgayTraThucTe = DateTime.Now;
   ```

## UI (FormFine)
- Method: `ProcessPayForRows`
- Action: Add `CheckRefreshParent();` at the end of the success block.
