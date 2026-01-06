# Design

## Return Flow UX
Current: Returns book -> Updates Grid "Status: Returned" -> User manually checks Fines.
New: Returns book -> Updates Grid -> **Popup**: "Returned X books. Generated Overdue Fine: Y VND." -> Auto-selects fine in `dgvFines`.

## Waiver Flow UX
Current: Click Waiver -> Checks Selection -> Errors if empty.
New: Click Waiver -> Checks Selection -> If empty but fines exist -> Auto-selects first/all unpaid fines -> Opens Waiver Form.

## Logic
- **Overdue Check**: Calculate `overdueAmount` in the loop and sum it up for the message.
- **Auto-Selection**: Use `dgvFines.Rows[i].Selected = true`.
