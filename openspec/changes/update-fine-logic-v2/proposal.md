# Update Fine Logic V2

## Summary
Update the fine calculation logic to set the overdue fee to 5,000 VND/day and ensure that for damaged books, the total amount to pay includes both the overdue fee ("tiền mượn") and the damage penalty ("tiền phạt").

## Motivation
The user requested a specific change to the fine structure: 5,000 VND/day for normal returns (overdue), and for damaged books, it must be the sum of the overdue fee and the damage penalty.

## Scope
- `FineService.cs`: Update `FINE_PER_DAY` constant.
- `FormFine.cs`: Ensure logic correctly captures both overdue and damage fines for a single return action.
