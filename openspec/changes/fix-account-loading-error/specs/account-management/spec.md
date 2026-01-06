# Account Loading Error Fix Specs

## MODIFIED Requirements

### Error-Free Data Loading
The Account Management form must load data without throwing EF Core relationship errors.

#### Scenario: Opening Account Management
- Given I open "Quản lý Tài khoản"
- When the data loads
- Then I should NOT see an error message starting with "The association between entity types 'Staff' and 'User' has been severed"
- And the grid and staff dropdown should populate correctly
