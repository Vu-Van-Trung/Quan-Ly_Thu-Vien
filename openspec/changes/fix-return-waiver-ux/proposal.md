# Fix Return & Waiver UX

## Summary
Improve the User Experience for Book Returns and Fine Waivers to ensure transparency and ease of use.

## Motivation
Users report confusion when returning normal books that have overdue fines ("Status only shows Returned, not Payment Confirmed"). Additionally, accessing the Waiver form is difficult ("haven't seen calling form waiver"). This change addresses these by adding explicit execution feedback and auto-selection of fines.

## Scope
- `FormFine.cs`:
  - Update `ProcessReturnForRows` to explicitly notify if fines were generated (Overdue).
  - Update `BtnWaiver_Click` to auto-select fines if none are selected but available.
  - Provide clear feedback on "Payment Pending" status after return.
