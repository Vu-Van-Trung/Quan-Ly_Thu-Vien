# Loan Constraints: Max 5 Books & Overdue Block

## Goal
Enforce borrowing policies to prevent hoarding and ensure timely returns.
1. **Quantity Limit**: A member can have at most **5 unreturned books** at any time.
2. **Good Standing**: A member **cannot borrow new books** if they currently have any **Overdue** (Quá hạn) books.
3. **Active Status**: Only members with `TrangThai == "Hoạt động"` can borrow.

## Rules
1. **Active Member Check**:
   - Before allowing a loan, check `Member.TrangThai`.
   - If != "Hoạt động", reject with message "Thẻ độc giả đang bị khóa hoặc không hoạt động."

2. **Overdue Check**:
   - Check all Loans for this member.
   - If any Loan has `DueDate < DateTime.Now` AND contains `LoanDetails` with `NgayTra == null`, the member is blocked.
   - Message: "Độc giả đang có sách quá hạn chưa trả. Vui lòng trả sách quá hạn trước khi mượn thêm."

3. **Quantity Warning**:
   - Count total `LoanDetails` where `NgayTra == null` across ALL of the member's loans.
   - If `Count + NewBooksRequest > 5`, reject.
   - Message: "Độc giả đã đạt giới hạn mượn 5 cuốn sách (Đang mượn: {Current})."

## Implementation
- **Location**: `FormLoan.cs`, inside `btnThem_Click`.
- **Logic**: Use EF Core to query the member's current standing before proceeding with `Add` logic.
