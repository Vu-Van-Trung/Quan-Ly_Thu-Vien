# Update Receipt Total Label

## Summary
Update the label "Tổng tiền phạt" to "Tổng thanh toán" in the printed receipt and ensure the amount is clearly formatted in VND.

## Motivation
Use a more neutral and accurate term ("Payment Total" instead of "Fine Total") for the receipt, as it may include overdue fees which are not strictly "fines" in some contexts, and ensure currency clarity.

## Scope
- `FormFine.cs`: Update `PrintDocument1_PrintPage` logic.
