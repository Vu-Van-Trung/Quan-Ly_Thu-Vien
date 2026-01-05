# Loan Status Auto-Update Specification

## ADDED Requirements

### Requirement: The system MUST automatically mark a Loan as "Returned" when all items are returned.
When the last book in a Loan is returned, the system SHALL update the Loan's status to indicate completion and record the actual return date.

#### Scenario: Returning the last book
- Given a Loan has 3 books.
- And 2 books are already returned.
- When the user returns the 3rd book.
- Then the system marks the 3rd book as returned.
- And the system updates the Loan status to "Đã trả".
- And the system records the current date as the Actual Return Date for the Loan.

### Requirement: The system MUST automatically refresh borrowing eligibility views after payments.
When a fine is paid or waived, any parent interface displaying borrowing limits or eligibility (e.g., `FormLoan`) MUST be refreshed immediately to reflect the unblocked status.

#### Scenario: User pays fine to unlock borrowing
- Given a user is blocked from borrowing due to an unpaid fine.
- When the user pays the fine in the Fine Management screen.
- Then the Fine Management screen closes or updates.
- And the Borrowing screen immediately reflects the payment (user is no longer blocked).
