# Fine Calculation Specifications

## MODIFIED Requirements

### Requirement: Late Fee Calculation
The system MUST automatically calculate the late fee for overdue books.
- The fee is **500 VND per day** for each overdue book.

#### Scenario: Book returned late
- **Given** a book is returned 10 days after the due date
- **When** the fine is calculated
- **Then** the amount should be 5,000 VND (10 * 500)

### Requirement: Book Condition Penalties
The system MUST calculate penalties based on the returned book's condition.

#### Scenario: Lost Book
- **Given** a book is marked as "Mất" (Lost)
- **And** the book price is 100,000 VND
- **When** the fine is calculated
- **Then** the amount should be 300,000 VND (3 * Price)

#### Scenario: Damaged Book
- **Given** a book is marked as "Hư hỏng" (Damaged)
- **When** the fine is calculated
- **Then** the amount should be 10,000 VND

### Requirement: Currency Formatting
The system MUST display monetary amounts in Vietnamese currency format.

#### Scenario: Display Total Fine
- **Given** the total fine is 500,000 VND
- **When** the amount is displayed on the UI
- **Then** it should follow the Vietnamese format (e.g., "500.000 ₫" or "500.000 đ" depending on system culture, strictly using `vi-VN`)
