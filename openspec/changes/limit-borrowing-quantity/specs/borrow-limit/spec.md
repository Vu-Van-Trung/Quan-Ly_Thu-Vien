# Borrow Limit Specification

## ADDED Requirements

### Requirement: The system MUST limit the number of books a reader can borrow to 5.
To ensure fair usage and resource availability, the system SHALL prevent a reader from borrowing additional books if they already have 5 or more active loans.

#### Scenario: Reader has reached the borrowing limit
- Given a reader "Nguyen Van A" has 5 books currently borrowed (active loans).
- When "Nguyen Van A" attempts to borrow another book.
- Then the system prevents the operation.
- And the system displays a warning message.

#### Scenario: Reader has not reached the limit
- Given a reader "Nguyen Van B" has 4 books currently borrowed.
- When "Nguyen Van B" attempts to borrow "The Pragmatic Programmer".
- Then the system allows the operation.

### Requirement: Unpaid fines MUST count towards the borrowing limit.
Returned books that resulted in unpaid fines MUST be treated as "active burdens" on the user's account for the purpose of the limit.
Formula: `Total = (Active Borrowed Books) + (Number of Unpaid Fines)`.

#### Scenario: Reader has mixed active books and unpaid fines reaching limit
- Given a reader has 4 active books.
- And the reader has 1 unpaid fine (from a previously returned book).
- When the reader attempts to borrow 1 more book.
- Then the system calculates Total = 4 + 1 = 5.
- And the system prevents the operation matching the limit (5).

#### Scenario: Reader has room to borrow despite fines
- Given a reader has 3 active books.
- And the reader has 1 unpaid fine.
- When the reader attempts to borrow 1 more book.
- Then the system calculates Total = 3 + 1 = 4.
- And the system allows the operation.
