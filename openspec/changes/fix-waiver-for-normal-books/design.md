# Prompt for Any Unpaid Fines

## Problem
The current "Waiver/Payment" prompt only triggers if *new* fines were generated during the specific `ReturnBook` call (`totalGenerated > 0`).
If fines were generated previously (e.g., via "Calculate Fine" button, or a previous partial return) or if the creation was skipped due to duplication checks (`IsFineExists`), the user is **not prompted** to pay/waive, even though unpaid fines exist for the books just returned.
This confuses users returning "Normal" (Good Condition) books that are Late, as the fine might have been pre-calculated or simply doesn't trigger the "New Fine" threshold if logic overlaps.

## Solution
Instead of tracking `totalGenerated`, explicitly check the **Total Unpaid Balance** of the Loan after the return transaction completes.
If `Total Unpaid > 0`, prompt the user to handle it.
This ensures that *any* debt associated with the loan—whether Condition-based, Overdue, new, or old—is brought to the user's attention immediately upon returning books.

## Logic Change
In `FormFine.ProcessReturnForRows`:
1. Perform Returns.
2. Reload Loan Details (Fines).
3. Calculate `totalUnpaid = Fines.Where(Unpaid).Sum()`.
4. If `totalUnpaid > 0`: Show Prompt.

## Refinement
The prompt message should focus on "Current Balance" rather than "Just Generated".
"Trả sách thành công. Hiện tại phiếu mượn có khoản phạt chưa thanh toán: {totalUnpaid}. Bạn có muốn xử lý ngay không?"
