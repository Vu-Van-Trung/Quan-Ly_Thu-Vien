# Design

## Workflow Update

### Current Behavior
- "Trả sách" triggers `ReturnBook`.
- `ReturnBook` creates a fine for Damage/Lost.
- Then `FormFine` calculates Overdue Fee ("Tiền mượn") and creates a separate fine.
- Both appear in `dgvFines`.

### Desired Behavior
- "Tất cả tốt hư hỏng và mất sẽ đc đưa xuống danh sách phạt".
- This aligns with the current V2 implementation where Overdue Fee is treated as a Fine ("Tiền mượn").
- **Crucial Detail**: Ensure that the system interprets "Tiền mượn" (Overdue Fee) as a payable Item in the Fine list.
- **Waiver Application**: Since Waiver applies to selected rows in `dgvFines`, having all fees there satisfies the requirement.

## Implementation Details
- No major architectural change. The key is ensuring that the "Overdue Fee" creation logic in `FormFine.cs` is robust and always runs when `amount > 0`.
- If the user implies that *even 0 amount* returns should show up to be "waived" (which makes no sense), we assume they mean "any payable amount".
- We will assume standard "Tiền mượn" (Overdue) is the target for "Tốt".

## Edge Case
- If a book is returned "Tốt" and is NOT Overdue -> No fine -> Nothing to pay/waive. This is correct behavior.
- Use case is strictly for "calculating fees -> waiver -> payment".
