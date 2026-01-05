# Design

## Logic
In `FineService.GetLoanWithDetails(string loanId)`:
```csharp
// Clear cache to ensure fresh Include() results for Fines
_context.ChangeTracker.Clear();

return _context.Loans
    .Include(...)
    ...
```

## Risks
- `ChangeTracker.Clear()` discards any *unsaved* changes. 
- **Mitigation**: `ReturnBook` calls `SaveChanges()` immediately before the refresh is triggered. `PayFine` also calls `SaveChanges()`. So this should be safe in this workflow.
