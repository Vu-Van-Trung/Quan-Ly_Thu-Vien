# Tasks

1. Modify `FormLoan.cs`: - [x]
   - In `btnThem_Click`, insert validation logic before creating `Loan` or `LoanDetail`.
   - **Step 1**: Query Member status. If not "Hoạt động", return error.
   - **Step 2**: Query for *Overdue* items: `db.Loans.Any(l => l.MemberId == id && l.DueDate < Now && l.LoanDetails.Any(d => d.NgayTra == null))`. If true, return error.
   - **Step 3**: Count currently borrowed books: `db.LoanDetails.Count(d => d.Loan.MemberId == id && d.NgayTra == null)`.
   - **Step 4**: Check if `CurrentCount + 1 > 5`. If true, return error.
2. Verify: - [x]
   - Test with a locked member.
   - Test with a member having overdue books.
   - Test with a member having 5 books.
