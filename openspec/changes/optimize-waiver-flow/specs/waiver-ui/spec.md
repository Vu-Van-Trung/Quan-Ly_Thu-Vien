# Waiver UI Specifications

## ADDED Requirements

### Requirement: Waiver Dialog
The system MUST provide a dedicated dialog for processing fine waivers, replacing the simple text input.
#### Scenario: Open Waiver Dialog
- **Given** I adhere to the Fine Management screen
- **When** I click "Miễn trừ"
- **Then** the `FormWaiver` dialog should appear
- **And** it should allow me to choose between Percentage or Fixed Amount

### Requirement: Flexible Waiver Calculation
The system MUST support waiver calculation by both percentage and fixed amount.
#### Scenario: Waive by Amount
- **Given** a fine of 50,000 VND
- **When** I apply a waiver of 20,000 VND
- **Then** the remaining fine should be 30,000 VND
- **And** the reason should update to reflect the waiver

#### Scenario: Waive by Percentage
- **Given** a fine of 50,000 VND
- **When** I apply a waiver of 10%
- **Then** the remaining fine should be 45,000 VND

### Requirement: Waiver Audit Trail
The system MUST record the reason for the waiver and the person who performed it to ensure transparency.
#### Scenario: Audit Logging
- **Given** the current user is "Admin"
- **When** a waiver is applied with reason "Damage forgiveness"
- **Then** the fine record MUST include "By: Admin" and "Reason: Damage forgiveness" in its history/notes
