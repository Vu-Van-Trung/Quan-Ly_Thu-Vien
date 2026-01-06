# Waiver Audit Specifications

## ADDED Requirements

### Requirement: Mandatory Reason
The system MUST require a reason for every waiver action.
#### Scenario: Missing Reason
- **Given** I am on the Waiver Dialog
- **When** I attempt to confirm without entering a reason
- **Then** the system MUST block the action and display a warning

### Requirement: Non-Negative Balance
The system MUST prevent waiver actions from resulting in a negative fine balance.
#### Scenario: Excessive Waiver
- **Given** a fine of 50,000 VND
- **When** I attempt to waive 60,000 VND
- **Then** the system MUST cap the waiver at 50,000 VND (Result = 0) OR block the action (Current implementation caps it)

### Requirement: System Audit Log
The system MUST record a persistent log entry for every waiver applied.
#### Scenario: Log Entry
- **Given** a waiver is successfully applied
- **Then** a new entry MUST appear in the System Log
- **And** it must contain: Fine ID, Waived Amount, Reason, and User Name
