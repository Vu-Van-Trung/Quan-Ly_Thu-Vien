# Change: Restrict Activity Log for Librarians

## Why
The user wants to restrict the visibility of the "Activity Log" (Nhật ký hoạt động) for users with the "Thủ thư" (Librarian) role. They should only see logs related to their day-to-day operations (Borrow, Return, Extend, Fines). This prevents them from seeing sensitive or irrelevant system-wide logs (like Admin actions).

## What Changes
- **Logic**: In `QuanLiNhatKy.cs`, modify the `LoadData` method.
- **Filtering**:
    - Check if `Session.CurrentRole` is "Thủ thư" (or equivalent, distinct from "Admin").
    - If yes, append a `Where` clause to filter `ChucNang` (Function) to include only:
        - "Mượn sách"
        - "Trả sách"
        - "Gia hạn"
        - "Lập phiếu phạt"
        - "Thanh toán tiền phạt"
- **UI**: No direct UI changes, just data filtering.

## Impact
- **Filtered View**: Librarians will see a subset of logs.
- **Security**: Improves operational security by limiting log visibility.
