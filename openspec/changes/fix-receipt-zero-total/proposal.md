# Fix Receipt Zero Total

## Summary
Update the receipt total calculation logic to include **all** fines (both paid and unpaid) associated with the loan, ensuring the "Tổng thanh toán" matches the list of items detailed in the receipt.

## Motivation
Currently, the receipt calculates the total by summing only *unpaid* fines (`!= "Đã thanh toán"`). If a user pays the fine and then prints the receipt (the standard workflow), the total shows 0 VND because the fines are now marked as "Paid". The receipt should reflect the total value of the transaction history for this loan.

## Scope
- `FormFine.cs`: Update the `Sum` logic in `PrintDocument1_PrintPage`.
