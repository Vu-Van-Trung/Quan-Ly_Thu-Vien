# Enforce Single Active Form & Verify Receipt

## Summary
1. Update navigation logic to ensure that when transitioning between forms (specifically Loan -> Fine), the current form is closed to prevent multiple active forms.
2. Verify and refine receipt logic to ensuring "Tổng thanh toán" accurately reflects the sum of Overdue and Damage fines with correct VND formatting.

## Motivation
The user requested that the system prevents multiple forms from being open simultaneously ("khi mở 1 form tất cả các form khác sẽ phải tắt") and re-emphasized the receipt calculation/formatting logic.

## Scope
- `FormLoan.cs`: Update `btnTraSach_Click` to close `FormLoan` after opening `FormFine`.
- `FormFine.cs`: No changes needed if verification passes (Receipt update in previous step matches request).
