# Update Fine Calculation and Formatting

## Summary
Update the system's fine calculation logic for late returns, lost books, and damaged books, and apply Vietnamese currency formatting to the displayed amounts.

## Motivation
To align with the library's new penalty policies and ensure clear, localized currency display.

## Scope
- `FineService.cs`: Update fine calculation constants and logic.
- `FormFine.cs`: Update currency formatting in `lblTotalFine`.
