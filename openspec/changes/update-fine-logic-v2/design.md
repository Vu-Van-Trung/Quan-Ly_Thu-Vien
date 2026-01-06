# Design

## Logic Updates

### Overdue Fee
- **Rate**: 5,000 VND / day / book.
- **Affected File**: `FineService.cs` -> `FINE_PER_DAY`.

### Combined Fine for Damaged Books
- **Requirement**: "Hư hỏng" = "Tiền mượn" (Overdue Fee) + "Tiền phạt" (Damage Fee).
- **Implementation**:
    - Ensure that when a book is returned, the system calculates the overdue fee (if any).
    - AND calculates the damage fee (if any).
    - Both should be added to the Fines list (as separate entries or a combined one, separate is preferred for clarity).

## Current Implementation Review
- `FormFine.cs` currently handles the overdue calculation manually in `ProcessReturnForRows`.
- `FineService.ReturnBook` handles the condition fine.
- Both result in calls to `CreateOverdueFine`.
- This satisfies the "Sum" requirement (Total = A + B).

## Proposed Change
- Change `FINE_PER_DAY` in `FineService.cs` to 5000.
- No structural changes needed in `FormFine.cs` if the current sequential logic holds.
