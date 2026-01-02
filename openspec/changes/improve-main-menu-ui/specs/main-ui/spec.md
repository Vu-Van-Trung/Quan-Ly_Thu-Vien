## ADDED Requirements

### Requirement: Modern Sidebar Menu
The system SHALL provide a modern navigation sidebar in the main form using `Guna2Button` controls instead of a standard `ListBox`.

#### Scenario: Visual Appearance
- **WHEN** the main form is loaded
- **THEN** the sidebar SHALL have a dark premium background (`#2c3e50` or similar)
- **AND** each menu item SHALL be represented by a button with an icon and text
- **AND** buttons SHALL have smooth hover transitions

#### Scenario: Functional Navigation
- **WHEN** a menu button is clicked
- **THEN** the corresponding child form SHALL be opened or brought to front if already open
- **AND** the clicked button SHALL be visually emphasized as "active"
