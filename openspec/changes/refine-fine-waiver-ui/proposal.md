# Refine Fine & Waiver UI

## Summary
Overhaul the User Interface of `FormFine` and `FormWaiver` to match the application's premium design aesthetic (GunaUI, specific color palettes, styled grids).

## Motivation
The current `FormFine` has inconsistent generic buttons and unstyled grids. The newly created `FormWaiver` is a raw WinForms dialog that looks out of place. Both need to standardized to ensure a seamless ("đồng đều") user experience.

## Scope
- `FormFine.cs`:
  - Convert standard Buttons to `Guna2Button`.
  - Apply `ConfigureBeautifulGrid` style to `dgvBooks` and `dgvFines`.
  - Improve resizing/layout logic.
- `FormWaiver.cs`:
  - comprehensive UI redesign using Guna2 controls.
  - Remove window borders (Borderless form) and add shadow/drag control.
