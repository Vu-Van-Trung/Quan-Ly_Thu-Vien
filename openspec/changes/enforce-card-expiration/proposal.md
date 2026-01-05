# Enforce Borrowing Restrictions Based on Card Expiration

## Summary
The system must use the Reader's expiration date (`NgayHetHan`) to determine the validity of the card during borrowing operations. If the current date exceeds the expiration date, borrowing must be blocked.

## Motivation
Although `TrangThai` (Status) exists, the definitive logic for "Expired" relies on `NgayHetHan`. Ensuring this check is performed specifically against the date guarantees that even if the manual status wasn't updated, the system enforces the expiration policy.

## Proposed Solution
- In `FormLoan.cs` (Borrowing function), before allowing a loan:
    - Check if `Member.NgayHetHan` is present.
    - Check if `DateTime.Now > Member.NgayHetHan`.
    - If expired, block the transaction and alert the user.
- This logic reinforces the existing `TrangThai` check.
