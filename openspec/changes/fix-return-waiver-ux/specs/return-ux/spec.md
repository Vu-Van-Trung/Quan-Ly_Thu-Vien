# Return & Waiver UX Specifications

## MODIFIED Requirements

### Requirement: Explicit Return Feedback
The system MUST inform the user of financial implications immediately upon book return.
#### Scenario: Return with Overdue Fine
- **Given** I return a "Normal" book that is Overdue
- **When** the return is processed
- **Then** the system MUST display a message: "Trả sách thành công. Phạt quá hạn: [Amount] VNĐ."
- **And** the corresponding fine MUST be highlighted in the Fine List.

### Requirement: Smart Waiver Access
The system MUST facilitate access to the Waiver function.
#### Scenario: Click Waiver without Selection
- **Given** there are unpaid fines in the list
- **And** no rows are selected
- **When** I click "Miễn trừ"
- **Then** the system MUST automatically select the fines (or prompt to confirm auto-selection)
- **And** open the Waiver Dialog.
