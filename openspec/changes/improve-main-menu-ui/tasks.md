## 1. Design & Resources
- [x] 1.1 Generate or select icons for each menu item (Books, Members, Loans, Staff, Publishers, Reports, Fines, Settings).
- [x] 1.2 Design the new sidebar layout structure.

## 2. UI Implementation
- [x] 2.1 Modify `QuanLiThuVien.Designer.cs` to remove `lstMenu` and add a container (e.g., `FlowLayoutPanel` or `Panel`) for menu buttons.
- [x] 2.2 Add `Guna2Button` instances for each menu action.
- [x] 2.3 Style the buttons with hover effects, icons, and consistent padding/alignment.

## 3. Logic Integration
- [x] 3.1 Update `QuanLiThuVien.cs` to map button clicks to the existing `OpenOrActivateChild` logic.
- [x] 3.2 Refactor `AddMenuAction` and `SetupDefaultMenuActions` if necessary to support dynamic button generation or static button wiring.
- [x] 3.3 Ensure the active menu item is visually highlighted.

## 4. UI Refinement (Latest)
- [x] 4.1 Increase padding between menu items (Margin 15, 10).
- [x] 4.2 Add left indicator line for hover and checked states.
- [x] 4.3 Set consistent border radius (12px) for buttons and main header.

## 5. Verification
- [x] 5.1 Verify that all menu items open the correct forms.
- [x] 5.2 Verify that the UI fits the Salmon background and looks premium.
