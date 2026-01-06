# Design

## Cross-Highlighting
- **Event**: `dgvBooks.SelectionChanged`.
- **Logic**: Get selected Book Title, find rows in `dgvFines` with matching `LyDo`, select them.

## Auto-Prompt Return
- **Logic**: In `ProcessReturnForRows`, if `totalFine > 0`, prompt Yes/No. If Yes, open Waiver.

## Sync
- `FormLoan`: Needs to reload context or clear tracker to get fresh status.
