# Price Increment Specification

## MODIFIED Requirements

### Requirement: Book Price Field Increment
The "Giá Tiền" (Price) input field in the Book Management form MUST increment or decrement by 500 units when interacting with the step buttons or arrow keys.

#### Scenario: User adjusts price
- **Given** the user is on the Book Management form
- **And** the "Giá Tiền" field has a value (e.g., 1000)
- **When** the user clicks the "Up" arrow or presses the Up key
- **Then** the value should increase by 500 (e.g., to 1500)
- **When** the user clicks the "Down" arrow or presses the Down key
- **Then** the value should decrease by 500 (e.g., to 500)
