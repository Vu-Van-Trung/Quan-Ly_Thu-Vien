# Tasks

1.  **Create `FormConditionCheck.cs`**: - [x]
    -   Create a new WinForms form `FormConditionCheck`.
    -   Add `CheckBox` `chkHuHong` text "Sách hư hỏng".
    -   Add `CheckBox` `chkMat` text "Sách mất".
    -   Add `Button` `btnConfirm` text "Xác nhận".
    -   Expose a public property `SelectedCondition` (string) that returns "Hư hỏng", "Mất", or "Tốt" based on checks (Mất takes precedence or enforce single selection).
2.  **Modify `FormFine.cs` (UI)**: - [x]
    -   Hide or Remove `btnCalculateFine`.
    -   Remove `btnCalculateFine.Click` event wiring.
3.  **Modify `FormFine.cs` (Logic)**: - [x]
    -   Update `ProcessReturnForRows`:
        -   Instantiate `FormConditionCheck`.
        -   Show `ShowDialog()`.
        -   Use `form.SelectedCondition` as the condition for `_fineService.ReturnBook`.
4.  **Verify**: - [x]
    -   Run app, click "Trả Sách".
    -   Verify dialog appears.
    -   Test "Hư hỏng" -> ensures fine generated/status updated.
    -   Test "Mất" -> ensures fine/status.
    -   Test "Tốt" (no check) -> standard return.
