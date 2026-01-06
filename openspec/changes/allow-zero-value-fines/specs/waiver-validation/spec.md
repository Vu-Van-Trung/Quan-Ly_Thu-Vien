# Zero Value Processing

## ADDED Requirements

#### Scenario: Return Normal Book
Given a user returns a book with condition "Tốt" (Normal)
When the return is processed
Then the system should generate a Fine record with Amount 0 VNĐ
And the reason should be "Trả sách: [BookName] (Tốt)"
And the status should be "Chưa thanh toán" (Pending).

#### Scenario: Process Normal Return
Given a "Normal" return record exists (Amount 0, Status Unpaid)
When the user selects it and clicks "Thanh toán" (Pay)
Then the system should Update status to "Đã thanh toán" (Paid)
And show success message.

#### Scenario: Waive Normal Return
Given a "Normal" return record exists (Amount 0, Status Unpaid)
When the user selects it and clicks "Miễn trừ" (Waiver)
Then the system should Update status to "Đã thanh toán" (Paid)
And show success message.
