# Fix Print Receipt Layout and Event

## Summary
The user identified three issues with the Fine Receipt printing:
1.  **Double Print Dialog:** The print dialog opens twice because the event handler is subscribed twice (once in Designer, once in `SetupEvents`).
2.  **Cluttered Content:** The "Reason" field on the receipt includes internal audit trail info (By: Admin, Reason: ...). The user wants only the main fine reason and the waiver amount.
3.  **Signature Layout:** The "Sign and write name" text is too far from the "Librarian/Payer" headers.

## Changes

### 1. Fix Double Event Subscription
Remove `btnPrint.Click += BtnPrint_Click;` from `SetupEvents` in `FormFine.cs`, as it is already defined in `InitializeComponent` (Designer).

### 2. Clean Up Fine Details
In `PrintDocument1_PrintPage`:
- Parse the `f.LyDo` string.
- If it contains the waiver suffix `(Miễn giảm: ... - By: ... - Reason: ...)`.
- Extract only the "Miễn giảm: [Amount]" part.
- Display format: `[Original Reason] [Miễn giảm info if exists]`.
- Remove " - By: ..." and " - Reason: ..." parts from the display string.

### 3. Adjust Signature Spacing
- Reduce the `y` increment between "Thủ thư/Người nộp" and "(Ký và ghi rõ họ tên)" from 80 to 25-30 to place them close together.
- Ensure the space *below* "(Ký...)" is sufficient for the actual signature (add gap *after* the text if needed, or just leave it at the bottom). Usually, "(Ký ...)" goes *under* the signature space?
- **Correction:** The user said "ký và ghi rõ họ tên phải được đặt ngay dưới Thủ thư và người nộp".
- Standard VP form:
  **Thủ thư**
  *(Ký và ghi rõ họ tên)*
  
  [Space for Signature]
  
- Current code:
  Draw "Thủ thư"
  y += 80 (Gap)
  Draw "(Ký ...)"
- New code:
  Draw "Thủ thư"
  y += 25 (Line Height)
  Draw "(Ký ...)"
  y += 80 (Gap for signature effectively, though usually this text is the instruction).

## Analysis
- **Double Call:** Confirmed in code `SetupEvents` line 343 vs Designer line 285.
- **String Parsing:** The format created in `FineService` is `... (Miễn giảm: X - By: Y - Reason: Z)`.
  Regex: `\(Miễn giảm: (.*?) - By:` -> Capture the amount part.
  Or simpler: Split by ` - By:`. Take the first part?
  But we need the closing parenthesis `)`.
  String: `Main Reason (Miễn giảm: 50% - By: admin - Reason: xyz)`
  Desired: `Main Reason (Miễn giảm: 50%)`
  Logic: Find index of ` - By:`. If found, substring up to that index, then append `)`.
