# UI Consistency Specifications

## MODIFIED Requirements

### Requirement: Data Grid Styling
All DataGridViews in the Fine Management module MUST adhere to the application's standard styling.
#### Scenario: Grid Appearance
- **Given** I open the Fine Management screen
- **Then** the "Member Books" and "Fine List" grids MUST have:
  - Dark Blue Headers (`#141948`)
  - Alternating Row Colors
  - No vertical grid lines
  - Dark Turquoise selection highlight

### Requirement: Waiver Dialog Aesthetics
The Waiver Dialog MUST match the GunaUI design language.
#### Scenario: Dialog Visuals
- **Given** I open the Waiver Dialog
- **Then** it MUST have:
  - No OS-level window borders
  - Guna2 styled input fields (rounded)
  - Guna2 styled buttons (Gradient/Solid colors)
