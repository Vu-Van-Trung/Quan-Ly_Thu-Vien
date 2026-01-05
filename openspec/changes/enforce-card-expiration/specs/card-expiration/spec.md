# Card Expiration Specification

## ADDED Requirements

### Requirement: The system MUST prevent borrowing if the reader card is expired.
The system uses the expiration date (`NgayHetHan`) to determine validity. If the current date is after the expiration date, the card SHALL be considered invalid for borrowing purposes.

#### Scenario: Reader card is expired
- Given the current date is "2025-01-01".
- And the reader "Nguyen Van A" has `NgayHetHan` = "2024-12-31".
- When "Nguyen Van A" attempts to borrow a book.
- Then the system prevents the operation.
- And the system displays a message indicating the card is expired.

#### Scenario: Reader card is valid
- Given the current date is "2025-01-01".
- And the reader "Nguyen Van B" has `NgayHetHan` = "2025-06-30".
- When "Nguyen Van B" attempts to borrow a book.
- Then the system proceeds to other checks (allows borrowing if other conditions met).

#### Scenario: Reader card has no expiration date
- Given a reader "vip-member" has `NgayHetHan` is null (lifetime member).
- When "vip-member" attempts to borrow.
- Then the system allows the operation (valid).
