# Change: Improve Main Menu UI

## Why
The current sidebar menu in `QuanLiThuVien` uses a standard `ListBox` with a Salmon background, which looks outdated and does not match the modern `Guna.UI2` components used elsewhere in the application. Users want a more professional, visually appealing menu with icons and better interaction feedback.

## What Changes
- Replace `lstMenu` (ListBox) with a structured layout of `Guna2Button` controls.
- Add icons to each menu item for better visual recognition.
- Improve the overall aesthetic of the sidebar (sidebar color, header, and button styles).
- Ensure the menu functionality remains the same (MDI child management).

## Impact
- Affected specs: `main-ui`
- Affected code: `QuanLiThuVien.cs`, `QuanLiThuVien.Designer.cs`
