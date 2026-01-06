# Design

## Design System (Existing)
- **Header Color**: `Color.FromArgb(20, 25, 72)`
- **Selection Color**: `Color.DarkTurquoise`
- **Alternating Row**: `Color.FromArgb(238, 239, 249)`
- **Button Radius**: `18` (approx) or Rounded.

## FormFine Layout
- **Grids**: Use `ConfigureBeautifulGrid` method (copied/shared from `FormLoan`).
- **Buttons**:
  - `btnPay`/`btnReturn`: `FillColor = Color.FromArgb(46, 204, 113)` (Green) or similar.
  - `btnWaiver`: `FillColor = Color.FromArgb(255, 192, 128)` (Orange) to match "Warning/Action".

## FormWaiver Layout
- **Style**: Modern Modal Dialog.
- **Background**: White.
- **Buttons**: Gradient Blue (`Guna2GradientButton`) for confirmation.
- **Inputs**: Rounded `Guna2TextBox` and `Guna2NumericUpDown`.
