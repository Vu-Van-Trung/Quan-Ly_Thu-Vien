# Tasks

- [x] Modify `FineService.GetLoanWithDetails` to include `_context.ChangeTracker.Clear()` before querying. <!-- id: impl-refresh -->
- [x] Verify `FormFine` calls `LoadLoanDetails` after return (already verified, just need to ensure it works). <!-- id: verify-call -->
