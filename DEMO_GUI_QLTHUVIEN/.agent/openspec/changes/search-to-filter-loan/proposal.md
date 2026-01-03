# Search to Filter Loan (FormFine)

## Goal
Replace the manual "Search" button functionality in `FormFine` with an automatic filter that triggers as the user types/selects a Loan ID from a ComboBox.

## Changes
1.  **UI Updates**: 
    -   Replace the `txtLoanId2` (TextBox) with a `ComboBox` named `cboLoanId`.
    -   Hide or Remove the `btnSearch` button as the action will be automatic.
2.  **Logic Updates**:
    -   Populate `cboLoanId` with all available `LoanId`s on Load.
    -   Bind the `SelectedIndexChanged` (or `TextChanged` for autocomplete) event of `cboLoanId` to `LoadLoanDetails`.

## Scope
-   `FormFine.cs`: Update `InitializeComponent` (replace control) and logic.
