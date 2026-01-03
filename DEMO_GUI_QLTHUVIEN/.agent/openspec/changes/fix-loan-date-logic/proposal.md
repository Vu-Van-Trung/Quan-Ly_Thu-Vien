# Fix Loan Date Auto-Calculation Logic

## Goal
Ensure `dtpNgayTra` (Due Date) is strictly bound to `dtpNgayMuon` (Loan Date) + 14 days in `FormLoan`. This must happen on initialization AND whenever the Loan Date changes.

## Changes
1.  **Event Wiring**: Ensure `dtpNgayMuon.ValueChanged` is wired correctly.
2.  **Initial State**: Call the update logic immediately on `Form_Load` so the initial state is correct.
3.  **Validation**: Verify that `dtpNgayTra` is disabled (ReadOnly) or resets if user tries to pick something else? The user didn't ask to disable it, just that it should be "Loan Date + 14". I will implement the auto-update.

## Scope
-   `FormLoan.cs`: Update `FormLoan_Load` and ensure the event is fired or method called.
