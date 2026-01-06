# Design

## Logic Updates

### Receipt Printing (`FormFine.cs`)
- **Locate**: `PrintDocument1_PrintPage` method.
- **Current**: Draws `lblTotalFine.Text` (which might still say "Tổng tiền phạt: ...").
- **New**: Explicitly draw string "Tổng thanh toán: " + formatted amount.

### Formatting
- Continue utilizing `ToString("C0", new CultureInfo("vi-VN"))` for consistency.
