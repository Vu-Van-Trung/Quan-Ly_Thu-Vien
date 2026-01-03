# Tasks

1.  **Modify `FormFine.Designer.cs` (or implicit design)**: - [x]
    -   Remove `txtLoanId2` (TextBox) and `btnSearch` (Button).
    -   Add `cboLoanId` (System.Windows.Forms.ComboBox) to `grpDetails`.
2.  **Modify `FormFine.cs`**: - [x]
    -   In `FormFine_Load` (create if missing), populate `cboLoanId.DataSource` with a list of all Loan IDs from `FineService` (might need to expose a method `GetAllLoanIds`).
    -   Wire `cboLoanId.SelectedIndexChanged` to call `LoadLoanDetails(cboLoanId.SelectedValue.ToString())`.
    -   Adjust constructors to select the item in `cboLoanId` if passed a `loanId`.
3.  **Verify**: - [x]
    -   Run app, ensure Loan IDs populate.
    -   Select a specific ID -> Grid updates automatically.
