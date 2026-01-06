# Return Flow Specifications

## MODIFIED Requirements

### Requirement: Centralized Payment List
All financial obligations arising from a book return MUST be generated as records in the Fine/Payment list (`dgvFines`) to facilitate unified payment processing and waiver application.

#### Scenario: Normal Return with Overdue
- **Given** a book is returned "Tốt" (Normal) but is Late
- **When** the return is processed
- **Then** a Fine entry for "Quá hạn sách..." (Tiền mượn) MUST be created
- **And** it MUST appear in the "Danh sách phạt" grid automatically

#### Scenario: Damaged Return with Overdue
- **Given** a book is returned "Hư hỏng" (Damaged) and is Late
- **When** the return is processed
- **Then** TWO Fine entries (or one combined) MUST be created:
  1. Overdue Fee ("Tiền mượn")
  2. Damage Penalty ("Tiền phạt")
- **And** both MUST appear in the "Danh sách phạt" grid

#### Scenario: Lost Return
- **Given** a book is returned "Mất" (Lost)
- **When** the return is processed
- **Then** a Fine entry for the Lost penalty MUST be created
- **And** it MUST appear in the "Danh sách phạt" grid
