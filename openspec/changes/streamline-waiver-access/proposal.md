# Streamline Waiver Access

## Summary
Simplify the access to the Waiver functionality directly from the Return flow and ensure Overdue fines for "Good" books are handled transparently.

## Motivation
Users report difficulty invoking the Waiver form and confusion regarding overdue fines for "Good" books. This change links the two actions and ensures real-time status updates.

## Scope
- `FormFine.cs`:
  - Update `ProcessReturnForRows` to prompt the user to **Waive/Pay immediately**.
  - Implement `CrossHighlightFines`.
- `FormLoan.cs`:
  - Ensure parent form synchronization.
