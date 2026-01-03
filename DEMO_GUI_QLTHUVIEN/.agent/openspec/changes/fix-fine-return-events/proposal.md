# Fix Fine & Return Button Events

## Problem
The `FormFine` interface has mismatched button logic and duplicate event subscriptions:
1.  **Mismatched Context**:
    -   The button in `grpSearch` (Books section) is named `btnPay` ("Trả Tiền") but triggers `BtnPay_Click` which acts on Fines (`dgvFines`).
    -   The button in `grpFines` (Fines section) is named `btnReturn` ("Thanh toán") but triggers `BtnReturn_Click` which acts on Books (`dgvBooks`).
2.  **Duplicate Events**: `SetupEvents` subscribes to events (e.g., `btnReset.Click`, `btnPrint.Click`) multiple times, causing double execution.
3.  **Ambiguous Naming**: `btnReturn` is labelled "Thanh toán" (Payment) while `btnPay` is labelled "Trả Tiền" (Pay Money), but physically they are in opposing groups.

## Solution
1.  **Swap & Rename**:
    -   `btnPay` (in Books group): Rename text to "Trả Sách" and wire to `BtnReturn_Click` (Return Book logic).
    -   `btnReturn` (in Fines group): Rename text to "Thanh Toán" and wire to `BtnPay_Click` (Pay Logic).
2.  **Cleanup**:
    -   Remove duplicate event subscriptions in `SetupEvents`.
    -   Ensure `InitializeComponent` doesn't conflict with manual wiring.

## Scope
-   **File**: `FormFine.cs`
-   **Method**: `InitializeComponent`, `SetupEvents`.
