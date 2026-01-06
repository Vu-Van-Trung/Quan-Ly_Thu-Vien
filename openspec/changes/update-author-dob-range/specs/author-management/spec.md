# Author DOB Constraint Specs

## MODIFIED Requirements

### Date of Birth Range
The system must enforce a Date of Birth range for authors.
- The earliest allowed date is Jan 1st, 1700.
- The latest allowed date is 15 years prior to the current date.

### Age Validation
The system must validate that an author is at least 15 years old.

#### Scenario: Entering an invalid date of birth (Too Young)
- Given I am adding a new author
- When I try to select a birth date less than 15 years ago
- Then the date picker should verify the max date limit
- Or the validation message should state "Tác giả phải từ 15 tuổi trở lên" if manually entered
