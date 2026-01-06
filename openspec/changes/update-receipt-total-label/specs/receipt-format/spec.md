# Receipt Format Specifications

## MODIFIED Requirements

### Requirement: Receipt Total Label
The printed receipt MUST label the final amount as "Tổng thanh toán" instead of "Tổng tiền phạt".

#### Scenario: Printing Receipt
- **Given** I am printing a receipt for a transaction
- **When** the receipt is generated
- **Then** the total line should read "Tổng thanh toán: [Amount]"

### Requirement: Receipt Currency Format
The printed receipt MUST display the total amount in clear Vietnamese currency format.

#### Scenario: Currency Display
- **Given** the total amount is 50,000
- **When** the receipt is printed
- **Then** the amount should define the currency symbol (₫/đ) clearly (e.g., "50.000 ₫")
