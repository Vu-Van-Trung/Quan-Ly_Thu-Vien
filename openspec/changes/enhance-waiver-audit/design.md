# Design

## Logging Logic
In `FineService.ApplyWaiver`:
- After successfully updating the fine, call `Logger.Log`.
- **Category**: "Quản lý Phạt".
- **Action**: "Miễn giảm".
- **Detail**: "Miễn giảm {Amount} cho khoản phạt {FineId} (Phiếu {LoanId}). Lý do: {Reason}. Người thực hiện: {Performer}".

## Validation Logic (Confirmed Existing)
- **Reason**: Enforced in UI (`FormWaiver`).
- **Non-negative**: Enforced in Logic (Cap discount at total fine amount).
