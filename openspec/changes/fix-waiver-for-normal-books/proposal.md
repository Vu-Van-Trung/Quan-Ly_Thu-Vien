# Fix Waiver for Normal Books

## Summary
Update the Waiver/Payment logic to allow closing (marking as paid) fines even if they have an amount of 0 VNĐ, and ensure the UI allows selecting and processing these "Normal" (but potentially 0-value or manually added) fines.

## Background
The user reported: "hệ thống không thể thanh toán và miễn trừ đối với sách bình thường". 
This likely refers to a scenario where a book is returned "Normal" (Tốt) but might still have some associated cost or simply needs the "transaction" to be cleared/closed formally, OR they are trying to apply a waiver on a 0-value fine (which might fail validation) or a fine that is already "Normal" but the system blocks it.
Wait, "sách bình thường" usually implies NO fine. If they want to "waive" a normal book, they might be confused. 
However, if they mean "Books that are returned normally but *LATE*", they should be waivable (which we fixed). 
If they mean "Books returned normally and ON TIME", there is no fine.
BUT, if they mean "I want to apply a waiver/payment action even if the fine is 0 or non-existent to 'close' the transaction record", that's different.

Actually, looking at `FineService.CalculateConditionFine`, "Normal" (Tốt) returns 0.
If they want to "waive/pay" for a "Normal" book, maybe they mean they want to *explicitly* mark it as "Paid" even if it's 0?
Or maybe they are talking about the **Waiver Form** validation.

Let's look at `ProcessReturnForRows` again.
If `condition == "Tốt"` and `OnTime`, `fineAmount` is 0. No fine is created.
PROMPTS only appear if `totalGenerated > 0`.
So for a purely "Normal" return, no prompt appears.
Maybe the user wants to be able to "Confirm" the return is "Paid/Clear" even if 0?
BUT, the user said "không thể thanh toán và miễn trừ". This implies they *want* to do it.

Ah, if the user manually *selects* the row and clicks "Miễn trừ" (Waiver), but the row has 0 fine, does it work?
In `BtnWaiver_Click`:
`if (dgvFines.SelectedRows.Count == 0 && dgvFines.Rows.Count > 0)` -> Auto selects unpaid.
If a fine is 0, is it "Chưa thanh toán"?
`CreateOverdueFine` sets "Chưa thanh toán".
But if Amount is 0, we usually don't create the fine at all!
`CalculateConditionFine` returns 0 for "Tốt".
`CalculateFineAmount` returns 0 for OnTime.

If NO fine is created, `dgvFines` is empty. You can't waive what doesn't exist.
Perhaps the user implies that for "Normal" books, they expected a record in `dgvFines` (maybe with 0 value) so they can "Review" it?
OR, they mean that when they return a book, they want the system to acknowledge it as "Cleared".

Let's assume the most critical interpretation: **The user might be facing a bug where they CANNOT select/waive a fine that DOES exist but is perhaps small or treated as "invalid" by the logic.**

Re-reading: "vẫn chưa thể miễn trừ cho sách tốt".
"Sách tốt" -> Condition = "Tốt".
If "Sách tốt" but **LATE**, it generates Overdue Fine.
Our previous fix `enable-comprehensive-return-fines` SHOULD have fixed the PROMPT for this.
But maybe the **Waiver Form** itself blocks it?
Let's look at `FormWaiver.cs` (from previous turn memories). it validates `txtReason`. It doesn't seem to block 0 values?

Wait, `FineService.ApplyWaiver`:
`if (fine.SoTienPhat <= 0) ... fine.TrangThaiThanhToan = "Đã thanh toán";`
If fine is already 0, it auto-pays.

**Hypothesis:** The user effectively wants to Apply Waiver/Payment to "Clear" the debt.
If the book is "Normal", maybe they are confused why it's not showing up to be "Waived"?
No, "Normal" implies NO FINE. Why would you waive no fine?

**Alternative Interpretation:** "Sách bình thường" might mean "Standard Book" (not reference, etc), or simply "Good Condition".
If "Good Condition" + "Late" -> Overdue Fine only.
User says "Still cannot waive".
Maybe the `BtnWaiver_Click` logic `if (!found) dgvFines.Rows[0].Selected = true;` is failing if the list is updated?

**Let's look at `FormFine.cs` line 655:**
`if (r.Cells["TrangThaiThanhToan"].Value?.ToString() == "Chưa thanh toán")`
If the fine is Overdue (for Good book), it IS "Chưa thanh toán".
So it should work.

**Let's look at the User's exact words logically:**
"trong form trả sách tôi vẫn chưa thể miễn trừ cho sách tốt."
(In return form, I still cannot waive for good books).
"Tôi muốn hệ thông phải miễn trừ cho tất cả các trường hợp"
(I want system to waive for ALL cases).

If I returned a "Good" book LATE, I have an Overdue Fine.
If I click "Return", the prompt appears (after my last fix).
If I say "Yes", it opens Waiver Form.
Is it possible the **Waiver Form** isn't receiving the right data or `ApplyWaiver` isn't working for "Overdue" specifically?
No, `ApplyWaiver` works by ID.

**Wait, what if they mean "Normal" books don't get a FINE RECORD at all, so they can't "Waive" (i.e. reduce to 0) the "Event"?**
Unlikely.

**What if they mean: I want to button 'Miễn trừ' to work even if I assign '0' value?**
If `FormWaiver` returns `WaiverValue = 0`?
`discountAmount = fine.SoTienPhat * 0 / 100` -> 0.
`fine.SoTienPhat -= 0`.
It remains original amount. Status "Chưa thanh toán".
So you can't "Waive" with 0 value. You must waive *something*.
But if the user wants to "Waive" the *entire* amount? They enter 100% or the full amount.

**Is it possible the user means "Thanh toán cho sách bình thường"?**
If a book is "Normal" and "On Time", there is NO fine. The transaction is done (`LoanDetail.NgayTra` set). Status is "Đã trả".
There is nothing to pay.

**Let's assume the User encountered a scenario where they returned a book (Good condition), generated an Overdue fine, tried to Waive/Pay, and it FAILED.**
Why?
Maybe `FormWaiver` has a constraint?
`numValue.Maximum = 100` (Percent).
`numValue.Maximum = 1000000000` (Amount).

**Let's look at `FormFine.ProcessReturnForRows` in the previous step.**
I added: `decimal totalGenerated = totalOverdueGenerated + totalConditionGenerated;`.
If `totalGenerated > 0` -> Prompt.
If "Good" + "Late": `totalOverdue > 0`, `totalCondition = 0`. `totalGenerated > 0`. Prompt shows.
Prompt calls `BtnWaiver_Click`.
`BtnWaiver_Click` selects Unpaid rows.
Passes to `FormWaiver`.
Calls `_fineService.ApplyWaiver`.

**Could it be that "Sách tốt" (Good Book) Logic in `FineService` is preventing fine creation?**
No, `CalculateConditionFine` returns 0. Overdue is separate.

**CRITICAL FINDING POTENTIAL:**
In `FineService.ReturnBook`:
```csharp
            // Calculate Condition Fine
            decimal fineAmount = CalculateConditionFine(detail.Book, condition);
            if (fineAmount > 0)
            {
                CreateOverdueFine(detail.LoanId, fineAmount, $"Phạt sách {condition}: {detail.Book.Title}");
            }
```
If Condition is "Tốt", `fineAmount` is 0. No "Condition Fine" created.
Overdue fine IS created later in `ProcessReturnForRows`.

**What if the user implies "Sách bình thường" = "Sách không bị phạt" but they WANT to record a "Waiver" (0 fee)?**
No, "miễn trừ" means "Exempt".
"Exempt for all cases".
Maybe they mean "Auto-Exempt"? i.e. "Check a box to auto-waive everything"?
No, "trong form trả sách tôi vẫn chưa thể miễn trừ".
This signifies a CAPABILITY block.

**Let's check `FineService.cs` line 140 `ApplyWaiver` again.**
It reduces amount.
If `SoTienPhat <= 0` -> Sets "Đã thanh toán".

**Maybe the user means: When I calculate fine, it shows "Sách tốt" (Good), but I can't click "Waive" because the row isn't selected or the button is disabled?**
Button `btnWaiver` is always enabled.

**Let's look at the `BtnWaiver_Click` logic in `FormFine` again.**
```csharp
            if (dgvFines.SelectedRows.Count == 0 && dgvFines.Rows.Count > 0)
            {
                // ... finds unpaid ...
                if (!found) dgvFines.Rows[0].Selected = true;
            }
```
If I have an Overdue fine (Unpaid), `found` is true. Row selected.
It enters `if (dgvFines.SelectedRows.Count == 0)`.
It enters `using (var frm = new FormWaiver())`.

**Wait! The Prompt in `ProcessReturnForRows`:**
```csharp
                    if (MessageBox.Show(msg, "Thông báo & Xử lý phạt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Auto-select unpaid fines
                        HighlightUnpaidFines();
                        
                        // Open Waiver Form directly
                        BtnWaiver_Click(null, null); 
                    }
```
This looks correct.

**Is it possible the user is referring to the "Condition Check" form?**
In `FormConditionCheck`, defaults to "Normal".
If they select "Normal", `fineAmount` is 0.
If they are also "On Time", `overdueAmount` is 0.
Total 0.
NO PROMPT.

If the user wants to "Waive" (Skip) the Return process? No.

**Let's reconsider "Sách bình thường" in the context of user testing.**
Maybe they tested "Late Return + Good Condition".
Fine Type: "Quá hạn sách ...".
They tried to waive it.
DID IT WORK?
If my previous code works, it shoud work.

**Maybe the issue is in `HighlightUnpaidFines`?**
```csharp
        private void HighlightUnpaidFines()
        {
            // Helper to select unpaid fines
            dgvFines.ClearSelection();
            foreach(DataGridViewRow r in dgvFines.Rows)
            {
                if (r.Cells["TrangThaiThanhToan"].Value?.ToString() == "Chưa thanh toán")
                {
                    r.Selected = true;
                }
            }
        }
```
`dgvFines` data source is a list of anonymous objects.
BUT, `dgvFines` rows are generating...
When `ProcessReturnForRows` runs:
1. It calls `ReturnBook`.
2. It (maybe) creates Overdue Fine.
3. It calls `LoadLoanDetails` (Reloads Fines).
4. `CheckRefreshParent`.
5. SHOWS MSG.
6. Calls `HighlightUnpaidFines`.

**TIMING ISSUE?**
`LoadLoanDetails` sets `DataSource`.
Does `DataGridView` create rows synchronously immediately? Yes, usually.
So `dgvFines.Rows` should be populated.

**Is it possible the user wants to Waive the fine BEFORE returning?**
"Trong form trả sách".
If they Calculate Fine first?
They click "Tính phạt" (Calculate Fine - `btnCalculateFine` is existing but I commented out its event in `SetupEvents`? No, I see `btnCalculateFine` in Designer but `SetupEvents` had it commented out: `// btnCalculateFine.Click += BtnCalculateFine_Click; // REMOVED`).

**Maybe the user wants to "Waive" the condition check itself?**
No.

**Let's assume the user is talking about validation.**
If I have a fine of 5000 VND.
I choose Waiver 100%.
Result: 0 Remaining. Paid.
This works.

**What if "Sách tốt" (Good Book) is somehow NOT generating the "Overdue" fine correctly in their test?**
Code:
```csharp
                if (DateTime.Now > _currentLoan.DueDate)
                {
                     decimal overdueAmount = _fineService.CalculateFineAmount(_currentLoan.DueDate, DateTime.Now);
                     if (overdueAmount > 0)
                     {
                         // ... Create Fine ...
                     }
                }
```
This looks standard.

**Let's look at `CreateOverdueFine` in `FineService`:**
```csharp
        public Fine CreateOverdueFine(string loanId, decimal amount, string reason)
        {
            // ...
            if (IsFineExists(loanId, reason)) return null;
            // ...
        }
```
**BLOCKER FOUND?** `IsFineExists`.
If I return a book, it creates a fine "Quá hạn sách ABC".
If I realize I made a mistake, cancel, and try again?
Or if I return *partially*?
If `IsFineExists` returns true, `CreateOverdueFine` returns `null`.
`totalOverdueGenerated` remains 0 (or lower).
Prompt might NOT show if it thinks fine already exists (so technically "0 generated" this time).
BUT, if the fine exists and is UNPAID, the user still owes it!
The logic `if (totalGenerated > 0)` only checks *newly generated* fines.
If the fine was generated *previously* (e.g. they clicked "Tính phạt" before, or returned then cancelled), `totalGenerated` is 0.
So the prompt doesn't appear.
AND `HighlightUnpaidFines` is never called.
So the user sits there handling a specific return, and the system stays silent, expecting them to notice the `dgvFines` grid has an item.

**This matches "vẫn chưa thể miễn trừ" (still cannot waive).** 
Because the UI flow didn't PROMPT them or select it for them.

**Solution:**
We should check for **Existing Unpaid Fines** for the returned books as well, not just "Newly Generated" ones.
Or, simply, after return, if there are ANY unpaid fines for this loan, we should prompt/notify?
Maybe that's too aggressive (what if they want to pay later?).
But specifically for the returned books:
If `IsFineExists` prevents creation, it implies the fine is there.
We should populate `totalOverdueGenerated` with the *existing* fine amount if we found it was relevant?
Or easier:
In `ProcessReturnForRows`, we are iterating rows.
If `IsFineExists` is true, we should probably fetch that fine and count it as "Pending for this session".

**Wait, `IsFineExists` checks logic:**
`_context.Fines.Any(f => f.LoanId == loanId && f.LyDo == reason);`
If I have "Quá hạn sách A". I pay it.
Next time I borrow A and return late? "Quá hạn sách A". `IsFineExists` might be true if it doesn't check date/status!
But `Fine` table likely accumulates.
If I paid it, it's "Đã thanh toán".
If `IsFineExists` returns true even for PAID fines, then we are blocking new fines for the same book name?!?
**BUG Check:**
Line 94: `return _context.Fines.Any(f => f.LoanId == loanId && f.LyDo == reason);`
This checks if *any* fine with this reason exists for this *LOAN ID*.
A Loan ID is unique to a session? Use usually `LoanId` is unique per borrowing session.
So yes, within one session, normally you only fine once for "Quá hạn sách A".
BUT, if I generated it, didn't pay. It exists.
If I return it now. `CreateOverdueFine` returns null. `totalGenerated` = 0.
Prompt doesn't show.
User sees nothing.

**The Fix:**
1. Update `IsFineExists` or `CreateOverdueFine` to return the *existing* fine if found (so we can track it), or handle "Pending" fines in the Prompt logic.
2. OR, simply modify the Prompt logic: `decimal totalUnpaid = _currentLoan.Fines.Where(f => ...).Sum(...)`.
If `totalUnpaid > 0` AND we just returned books, ASK?
"Bạn vừa trả sách. Hiện có {totalUnpaid} tiền phạt chưa thanh toán. Muốn xử lý ngay không?"

**Let's Refine the Prompt Logic:**
Instead of relying solely on `totalGenerated`, we should look at `totalUnpaid` associated with the *Current Loan* immediately after the return.
If `successCount > 0` (We successfully returned something).
Check `_currentLoan.Fines.Where(Unpaid).Sum()`.
If > 0:
Prompt: "Trả sách thành công. Hiện phiếu mượn này đang có tổng nợ: {X}. Bạn có muốn thanh toán/miễn trừ ngay không?"

This covers:
- Newly generated fines (Condition, Overdue).
- Previously generated fines (if they clicked "Calc" before, or system auto-generated).
- "Sách bình thường" (Normal condition) that happened to be Overdue (Fine generated but blocked by exists check, or generated previously).

**Let's verify "Sách bình thường" again.**
User might mean: "I returned a Normal Book. It was Overdue. I want to Waive the Overdue fine."
My proposed fix covers this perfectly.

**Plan:**
1. Modify `ProcessReturnForRows` in `FormFine`.
2. Instead of `if (totalGenerated > 0)`, use:
   `LoadLoanDetails(...)` (Already there).
   `decimal totalUnpaid = _currentLoan.Fines.Where(f => f.TrangThaiThanhToan == "Chưa thanh toán").Sum(f => f.SoTienPhat);`
   `if (totalUnpaid > 0)`...
   
   Adjust the message accordingly.
   "Trả sách thành công. Tổng tiền phạt cần thanh toán: {totalUnpaid}..."

This is robust and "Comprehensive".

**Proposal:** `fix-waiver-for-normal-books`
