# Waiver for Any Unpaid Balance

## MODIFIED Requirements

#### Scenario: Prompt for Pre-existing Fines
Given a Loan has an existing unpaid fine (e.g. 50,000 overdue)
And the user returns a book (Normal condition, On Time or Late)
When the return completes
Then the system should recalculate the total unpaid balance
And if the balance > 0, the system should prompt "Do you want to Waive/Pay {Balance}?"
And clicking "Yes" should select all unpaid fines and open the Waiver/Payment form.

#### Scenario: Normal Book Late Return
Given a user returns a book "Normal" (Good) but "Late"
And the system generates an Overdue fine (or finds an existing one)
When the return completes
Then the system should prompt for the Total Unpaid amount
So the user can Waive/Pay the overdue fee immediately.
