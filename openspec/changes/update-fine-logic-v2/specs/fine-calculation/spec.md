# Fine Calculation V2 Specifications

## MODIFIED Requirements

### Requirement: Overdue Fine Rate
The overdue fine rate MUST be 5,000 VND per day per book.

#### Scenario: Late Return Normal
- **Given** a book is returned 2 days late
- **And** the condition is "Tốt" (Normal)
- **When** the fine is calculated
- **Then** the Overdue Fine should be 10,000 VND (2 * 5000)

### Requirement: Damaged Book Total Fine
When a book is returned as "Hư hỏng" (Damaged), the system MUST charge both the overdue fine (if applicable) and the damage penalty.

#### Scenario: Late Return Damaged
- **Given** a book is returned 2 days late (Overdue Fee = 10,000 VND)
- **And** the condition is "Hư hỏng" (Damage Fee = 10,000 VND fixed)
- **When** the return is processed
- **Then** the system should generate fines totaling 20,000 VND
- **And** these entries should appear in the payment list
