# Author Date Binding Specs

## MODIFIED Requirements

### Robust Date Handling
The Author Management form must handle date selection from the grid without crashing, even if the date is out of range for the picker.

#### Scenario: Selecting an author
- Given I am on the Author Management form
- When I click on a row in the "Danh Sách Tác Giả" grid
- Then the "Ngày Sinh" date picker should fail gracefully or default to `DateTime.Now` if the date is invalid
- And the application should NOT crash
