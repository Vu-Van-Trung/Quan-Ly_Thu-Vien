# Navigation Specifications

## MODIFIED Requirements

### Requirement: Single Active Form
The system MUST ensure that only one functional form is active at a time to prevent window stacking.

#### Scenario: Navigate from Loan to Fine
- **Given** the user is on `FormLoan`
- **When** they click "Trả Sách" to open `FormFine`
- **Then** `FormLoan` MUST close automatically
- **And** `FormFine` MUST open as the active form

### Requirement: Receipt Total Definition
The "Tổng thanh toán" on the receipt MUST be the sum of all applicable fees (Overdue + Condition Fines) and formatted in VND.
(This is a verification of existing behavior).

#### Scenario: Verify Total Calculation
- **Given** a user has an overdue fee of 10,000 VND
- **And** a damage fine of 20,000 VND
- **When** the receipt is generated
- **Then** the "Tổng thanh toán" should be "30.000 ₫"
