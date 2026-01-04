# Change: Update Condition Check Form

## Why
The user requested to add an explicit option for "Normal Book" (Sách bình thường) in the condition check form and to improve the selection algorithm (mutual exclusion). Currently, "Normal" is implied when other options are unchecked, which can be ambiguous.

## What Changes
- **UI**: Add a new checkbox `chkNormal` (Sách bình thường).
- **Logic**: 
    - Ensure `chkNormal`, `chkHuHong`, and `chkMat` are mutually exclusive.
    - Default to `chkNormal` being checked if no other issues are present.
    - Update `SelectedCondition` based on the active checkbox.
