## ADDED Requirements

### Requirement: Search and Check Borrow Slip
The system SHALL allow users to check a borrow slip by its ID (`MaPhieuMuon`) to retrieve book details and overdue status.

#### Scenario: Verify return eligibility
- **WHEN** a valid `MaPhieuMuon` is entered and "Check" is pressed
- **THEN** display list of books in that slip with their current status
- **AND** highlight any items that are overdue

### Requirement: Confirm Book Return
The system SHALL allow users to mark specific books as returned.

#### Scenario: Successful return
- **WHEN** user selects books and clicks "Confirm Return"
- **THEN** update `CHI_TIET_PHIEU_MUON` status to "Đã trả"
- **AND** update Book inventory/availability

#### Scenario: Return with Violation
- **WHEN** the return is overdue or marked as damaged
- **THEN** prompt to confirm fine details before saving

### Requirement: Fine Calculation and Recording
The system SHALL automatically calculate fines for overdue items and record them.

#### Scenario: Auto-calculation
- **WHEN** a book is overdue
- **THEN** calculate fine = (Return Date - Due Date) * 5,000 VND
- **AND** save record to `PHAT` table upon confirmation

### Requirement: Payment Processing
The system SHALL provide tools for handling fine payments.

#### Scenario: Quick Payment
- **WHEN** "Quick Payment" is clicked
- **THEN** update `PHAT.TrangThaiThanhToan` to "Đã thanh toán"
- **AND** set `NgayThanhToan` to current date

#### Scenario: Waiver
- **WHEN** "Waiver" is selected
- **THEN** set `SoTienPhat` to 0
- **AND** require entry of a reason in `LyDo`

### Requirement: Form Reset and Receipt
The system SHALL provide utility functions for workflow efficiency.

#### Scenario: Reset Form
- **WHEN** "Reset" is clicked
- **THEN** clear all input fields and search results

#### Scenario: Print Receipt
- **WHEN** "Print Receipt" is clicked
- **THEN** generate a printable confirmation/invoice for the transaction
