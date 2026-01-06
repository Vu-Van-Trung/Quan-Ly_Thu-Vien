# Tracking Condition Fines

## Problem
`FineService.ReturnBook` currently returns `void`. It calculates and saves Condition Fines internally, but the calling UI (`FormFine`) has no visibility into the amount generated.
This prevents the UI from summing up the total fines for the current return action.

## Solution

### 1. Update `FineService.ReturnBook`
Refactor `ReturnBook` to return `decimal` (the amount of condition fine generated) or a `Fine` result object.
Given we might need more details later, returning the created `Fine` object (or null) is flexible, but returning `decimal` is sufficient for the immediate total calculation.
Let's return `decimal fineAmount`.

Signature change:
`public void ReturnBook(...)` -> `public decimal ReturnBook(...)`

### 2. Update `FormFine.ProcessReturnForRows`
Logic update:
```csharp
decimal conditionFine = _fineService.ReturnBook(detailId, condition);
totalConditionGenerated += conditionFine;

// ... calculate overdue ...
if (overdue > 0) totalOverdueGenerated += overdue;
```

Total Prompt Trigger:
`if (totalOverdueGenerated + totalConditionGenerated > 0)` ...

### 3. Prompt Message
Update message to:
`"Hệ thống đã ghi nhận tổng tiền phạt: {total} VNĐ (Quá hạn: {overdue}, Tình trạng: {condition})..."`

### 4. Selection Logic
`HighlightUnpaidFines` already selects all "Chưa thanh toán" rows. This fits the requirement as both new fines will be unpaid.
However, we must ensure `LoadLoanDetails` -> `LoadFines` is called *before* `HighlightUnpaidFines` (it currently is).
