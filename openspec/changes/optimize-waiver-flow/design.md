# Design

## UI Design: `FormWaiver`
- **Type**: Form (Dialog).
- **Controls**:
  - `radPercent` (Radio): "Theo phần trăm (%)".
  - `radAmount` (Radio): "Theo số tiền (VND)".
  - `numValue` (NumericUpDown): For input value.
  - `txtReason` (TextBox): "Lý do miễn giảm" (Required).
  - `btnOk`: "Xác nhận".
  - `btnCancel`: "Hủy".

## Logic Design: `FineService.ApplyWaiver`
- **Signature**: `void ApplyWaiver(int fineId, decimal value, bool isPercentage, string reason, string performer)`
- **Logic**:
  - Retrieve fine.
  - Calculate `discountAmount`:
    - If `isPercentage`: `fine.SoTienPhat * value / 100`.
    - If `!isPercentage`: `value`.
  - Validate `discountAmount <= fine.SoTienPhat`.
  - Update `fine.SoTienPhat -= discountAmount`.
  - Append to `fine.LyDo`: `$" {OldReason} (Miễn giảm: {value}{(isPercentage ? "%" : " ₫")} - By: {performer} - Reason: {reason})"`.

## Interaction
- User selects fines in `FormFine`.
- Clicks "Miễn trừ".
- `FormWaiver` opens.
- User enters details and clicks OK.
- `FormFine` iterates selected rows and calls `ApplyWaiver`.
