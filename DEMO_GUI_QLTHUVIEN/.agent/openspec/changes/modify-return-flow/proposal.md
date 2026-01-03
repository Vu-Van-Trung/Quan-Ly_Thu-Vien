# Modify Return Book Flow

## Goal
Simplify the Return Book process in `FormFine` by removing the manual "Calculate Fine" button and replacing the sequential MessageBox prompts for book condition with a single Checkbox Dialog.

## Changes
1.  **Remove Feature**: Remove `btnCalculateFine` ("Tính phạt") from the UI and its associated logic. The fine calculation for overdue items should happen automatically upon return or be implicit. (Note: functionality for overdue fine calculation is often embedded in `ReturnBook` logic in `FineService`, we just remove the standalone button if it effectively duplicates checking).
2.  **New UI Component**: Create `FormConditionCheck`, a small dialog form.
    *   Controls: CheckBox `chkDamaged` ("Sách hư hỏng"), CheckBox `chkLost` ("Sách mất"), Button `btnConfirm` ("Xác nhận").
    *   Logic: allow User to check one (or potentially both, but usually mutually exclusive for status) condition. Return the status.
3.  **Update Logic**:
    *   In `FormFine.ProcessReturnForRows`, replace the `MessageBox.Show` sequence with `FormConditionCheck.ShowDialog()`.
    *   Map the Result ("Hư hỏng", "Mất", or "Tốt") to the `ReturnBook` call.

## Scope
-   `FormFine.cs` (Modify)
-   `FormConditionCheck.cs` (Create)
