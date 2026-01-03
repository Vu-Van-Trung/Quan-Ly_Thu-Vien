# Tasks

1.  **Modify `FormFine.cs` (InitializeComponent)**: - [x]
    -   Locate `btnPay`: Change `Text` to "Trả Sách".
    -   Locate `btnReturn`: Change `Text` to "Thanh toán".
    -   Remove inline event subscriptions in `InitializeComponent` (e.g., `btnReturn.Click += ...`) to rely on `SetupEvents` centrally, OR standardize on one place.
2.  **Modify `FormFine.cs` (SetupEvents)**: - [x]
    -   Remove duplicate lines (e.g., `btnReset.Click += ...` appearing twice).
    -   Fix wiring:
        -   `btnPay.Click` -> `BtnReturn_Click` (Book Return Logic).
        -   `btnReturn.Click` -> `BtnPay_Click` (Fine Pay Logic).
3.  **Verification**: - [x]
    -   Verify "Trả Sách" button checks `dgvBooks` and returns books.
    -   Verify "Thanh toán" button checks `dgvFines` and pays fines.
