# Limit Borrowing Quantity to 5 Books

## Summary
Restrict the number of books a reader can borrow at any given time to a maximum of 5. This ensures fair distribution of resources and minimizes risk.

## Motivation
Currently, readers might be able to borrow an unlimited number of books (or the limit needs to be strictly enforced and validated). The library policy states a limit of 5 books per reader.

## Proposed Solution
- Implement a check in the borrowing workflow (`FormLoan`).
- Calculate the `Active Books` using `Sum(SoLuong)` of active loans.
- Calculate the `Unpaid Fines` count for the member.
- **Rule**: `TotalUsage = ActiveBooks + UnpaidFines`.
- If `TotalUsage + NewRequest > 5`, prevent the loan.
- This ensures that users who have returned books but not paid fines are still restricted.
- Display a clear warning message.
