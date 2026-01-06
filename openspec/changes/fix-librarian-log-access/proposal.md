# Fix Librarian Log Access

## Description
Expand the list of allowed function logs for the "Thủ thư" (Librarian) role in `QuanLiNhatKy` to ensure they can view activity logs for all features they have access to.

## Justification
Currently, Librarians are unable to view activity logs ("Nhật ký hoạt động") effectively because the filter logic in `QuanLiNhatKy.cs` uses an outdated or incomplete list of function names. This prevents them from auditing actions related to Books, Members, Loans, Fines, Authors, and Publishers, despite having permission to manage these entities.

## Impact
- **Modified**: `QuanLiNhatKy.cs` to update the `allowedFunctions` list.
- **Risk**: Low. Only affects the visibility of logs for one role.
