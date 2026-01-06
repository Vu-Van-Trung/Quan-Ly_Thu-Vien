# Print Receipt Improvements

## MODIFIED Requirements

#### Scenario: Print Button Click
Given the user is on `FormFine`
When they click "In biên lai"
Then the Print Preview Dialog should open exactly ONCE.

#### Scenario: Receipt Content - Fine Reason
Given a fine has a waiver applied with full audit trail in `LyDo`
"Phạt quá hạn (Miễn giảm: 50% - By: Admin - Reason: Good)"
When the receipt is printed
Then the fine line should display: "Phạt quá hạn (Miễn giảm: 50%)"
And exclude "By: Admin" and "Reason: Good".

#### Scenario: Receipt Content - Signature Layout
Given the footer of the receipt
When printed
Then the text "(Ký và ghi rõ họ tên)" should appear immediately below "Thủ thư" and "Người nộp" (approx 20-30px spacing)
Instead of a large gap.
