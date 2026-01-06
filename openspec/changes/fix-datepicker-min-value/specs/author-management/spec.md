# DatePicker Config Specs

## MODIFIED Requirements

### Minimum Date
The Author Date of Birth picker must use a minimum date of Jan 1, 1753, to ensure compatibility with the underlying control.

#### Scenario: Form Initialization
- When the Author Management form is opened
- Then the application should not crash
- And the earliest selectable date for authors should be 01/01/1753
