# Tasks

1.  **Modify `FormLoan.cs`**: - [x]
    -   In `FormLoan_Load`, ensure `dtpNgayMuon.ValueChanged += dtpNgayMuon_ValueChanged;` is called.
    -   EXPLICITLY call `dtpNgayMuon_ValueChanged(null, null)` (or similar logic) inside `FormLoan_Load` to set the initial value.
    -   Verify `dtpNgayMuon_ValueChanged` implementation sets `dtpNgayTra.Value = dtpNgayMuon.Value.AddDays(14)`.
2.  **Verify**: - [x]
    -   Run app -> Open Form Loan -> Check defaults.
    -   Change Loan Date -> Check Due Date updates.
