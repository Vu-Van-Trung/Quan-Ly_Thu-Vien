# Refine Librarian Name

## MODIFIED Requirements

#### Scenario: Print Librarian Full Name
Given a logged-in user
When printing the receipt
Then the system should display the Staff's **Full Name** (not Username) under the "Thủ thư" section.

#### Scenario: Remove Payer Name
When printing the receipt
The system should NOT display any auto-filled name under the "Người nộp" section (leave blank for signature/manual entry).
