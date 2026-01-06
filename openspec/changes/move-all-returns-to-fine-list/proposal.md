# Move All Returns to Fine List

## Summary
Update the book return workflow so that **every** book return (Normal, Damaged, or Lost) generates an entry in the "Fine List" (Danh sách phạt/thanh toán), even if the amount is just the overdue fee (or potentially 0 if not overdue/normal, though usually overdue fees apply). This allows the "Waiver" (Miễn trừ) logic to be applied uniformly during the payment process.

## Motivation
Currently, only explicit fines (damaged/lost) or overdue fees might be clearly visible for payment/waiver. The user wants *all* return outcomes to flow into the payment list to easily apply discounts or waivers before final payment.

## Scope
- `FormFine.cs`: Ensure that upon clicking "Trả sách", all calculated amounts (including Overdue "Tiền mượn") are explicitly created as `Fine` records that appear in the `dgvFines` grid.
- `FineService.cs`: Verify `CreateOverdueFine` usage ensures visibility.
