# Design: Fix Librarian Log Access

## Current Behavior
The `QuanLiNhatKy` form filters logs for the "Thủ thư" role using a hardcoded list:
- "Mượn sách", "Trả sách", "Gia hạn", "Lập phiếu phạt", "Thanh toán tiền phạt", "Quản lý Sách"

However, the application logs actions using different or additional names:
- "Quản lý Mượn Trả" (covers Borrow/Return)
- "Quản lý Độc giả"
- "Quản lý Tác Giả"
- "Quản lý Nhà Xuất Bản"
- "Quản lý Phạt"
- "Quản lý Sách"

## Proposed Change
Update the `allowedFunctions` list in `QuanLiNhatKy.cs` to include all relevant function names that a Librarian can access.

### Allowed Functions List
The new list for "Thủ thư" will be:
- "Quản lý Sách"
- "Quản lý Độc giả"
- "Quản lý Mượn Trả"
- "Quản lý Phạt"
- "Quản lý Tác Giả"
- "Quản lý Nhà Xuất Bản"
- "Mượn sách", "Trả sách", "Gia hạn", "Lập phiếu phạt", "Thanh toán tiền phạt" (legacy compatibility)

## Alternatives Considered
- **Dynamic Permission Check**: Instead of a hardcoded list, we could map Log Functions to `AccessControl` keys. However, the Log Function strings ("Quản lý Sách") do not 1:1 match the AccessControl keys ("ManageBooks") without a mapping table. Given the simplicity, updating the list is sufficient.
