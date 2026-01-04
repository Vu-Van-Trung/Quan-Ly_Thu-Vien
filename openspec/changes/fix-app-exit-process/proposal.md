# Change: Ensure Full Application Exit on Main Form Close

## Why
Currently, when the main library management form (`QuanLiThuVien`) is closed, the application process remains running in the background because the initial login form (`Login1`) is merely hidden, not closed. The user wants the application to completely terminate when the main form is closed.

## What Changes
- **Logic**: update `QuanLiThuVien.cs`.
    - Add a private flag `_isLoggingOut` to track if the user is logging out or exiting.
    - Wire up the `FormClosed` event.
    - In `FormClosed`, call `Application.Exit()` *unless* `_isLoggingOut` is true.
    - Update Logout handlers to set `_isLoggingOut = true` before closing the form.

## Impact
- **Consistency**: Closing the main window now properly kills the application process.
- **Workflow**: Logging out still works as expected (returns to Login screen) without killing the app.
