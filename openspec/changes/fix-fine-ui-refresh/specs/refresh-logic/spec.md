# UI Refresh Specification

## ADDED Requirements

### Requirement: The system MUST display newly created fines immediately after a book return.
When a book is returned and a fine is generated (e.g., for overdue), the list of fines and the total amount calculation MUST reflect this new fine immediately without requiring a form reopen.

#### Scenario: Returning an overdue book
- Given a Loan has an overdue book.
- When the user clicks "Return Book".
- Then the system calculates the fine.
- And the system saves the fine.
- And the system refreshes the "Fines" list to show the new entry.
- And the system updates the Total Fine Amount.
