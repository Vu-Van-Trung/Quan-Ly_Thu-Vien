# Comprehensive Waiver Prompt

## ADDED Requirements

#### Scenario: Prompt for Condition Fine
Given a user is returning a book
And the book is returned "On Time"
But the book condition is "Hư hỏng" (Damaged)
When the return process completes
Then the system should generate a Condition Fine
And the system should immediately prompt the user to "Waive / Pay" the fine
And the prompt should show the Condition Fine amount.

#### Scenario: Prompt for Combined Fines
Given a user is returning a book
And the book is "Late" (Overdue Fine)
And the book condition is "Mất" (Lost - Condition Fine)
When the return process completes
Then the system should generate both fines
And the system should prompt the user to "Waive / Pay" the TOTAL amount (Overdue + Condition)
And clicking "Yes" should open the Waiver/Payment flow for BOTH fines.

#### Scenario: No Prompt for Good Returns
Given a user is returning a book
And the book is "On Time"
And the book condition is "Tốt"
When the return process completes
Then the system should NOT prompt for waiver/payment (unless other books in the batch generated fines).
