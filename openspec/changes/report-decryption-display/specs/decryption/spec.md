# Requirement: Display Decrypted Information in Reports

## MODIFIED Requirements

### Requirement: Report View - Active Members
The "Active Members" ("Độc Giả Tích Cực") report MUST display readable text for Member information instead of encrypted strings.

#### Scenario: Viewing Active Members
- **Given** the database contains members with encrypted names (e.g., "U2FsdGVk...").
- **When** the user generates the "Active Members" report.
- **Then** the "Họ Tên", "Email", and "Số ĐT" columns show the decrypted, readable values (e.g., "Nguyen Van A").

### Requirement: Report View - Fine Revenue
The "Fine Revenue" ("Doanh Thu Phạt") report MUST display readable text for Member Names.

#### Scenario: Viewing Fine Revenue
- **Given** the database contains fines linked to members with encrypted names.
- **When** the user generates the "Fine Revenue" report.
- **Then** the "Độc Giả" column shows the decrypted Member Name.

### Requirement: Report View - Inventory
The "Inventory" ("Tồn Kho") report MUST display readable names for Publishers and Authors (if encrypted).

#### Scenario: Viewing Inventory
- **Given** the database contains books linked to Publishers with encrypted names.
- **When** the user generates the "Inventory" report.
- **Then** the "NXB" column shows the decrypted Publisher Name.
