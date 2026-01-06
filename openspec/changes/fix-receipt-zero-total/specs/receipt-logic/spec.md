# Receipt Logic Specifications

## MODIFIED Requirements

### Requirement: Receipt Total Calculation
The "Tổng thanh toán" on the receipt MUST be the sum of **all** fines listed in the receipt details, regardless of their payment status.

#### Scenario: Print Receipt After Payment
- **Given** I have a fine of 50,000 VND
- **And** I have just paid it (Status = "Đã thanh toán")
- **When** I print the receipt
- **Then** the "Tổng thanh toán" MUST be "50.000 ₫" (Previously 0)
