# Optimize Waiver Flow

## Summary
Replace the simple InputBox for fine waivers with a dedicated "Miễn giảm" dialog that allows users to specify a discount by either **Percentage (%)** or **Fixed Amount (VND)**, and requires a reason for the waiver.

## Motivation
The current waiver implementation only supports percentage-based discounts via a basic InputBox. Users need more flexibility (e.g., waiving a specific amount) and better audit trails (recording the reason for the waiver).

## Scope
- `FormFine.cs`: Update `BtnWaiver_Click` to open the new `FormWaiver`.
- `FormWaiver.cs` (New): Create a dialog form for waiver input.
- `FineService.cs`: Update/Add logic to handle fixed amount discounts and reason appending.
