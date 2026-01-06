# Design

## Navigation Updates
### FormLoan -> FormFine
- **Current**: `frmFine.Show()` keeps `FormLoan` open.
- **New**: Call `this.Close()` immediately after showing `frmFine`.
- **Constraint**: Ensure `frm.MdiParent` is set correctly so `FormFine` doesn't disappear if it was somehow dependent (it isn't, they are MDI siblings).

## Receipt Logic
- The user definition: `Total Payment = Fine (Damage/Lost) + Overdue (Loan Fee)`.
- Current Code: `_currentLoan.Fines.Sum(f => f.SoTienPhat)`.
- **Validation**: Since `ReturnBook` creates "Damage" fines and `ProcessReturn` creates "Overdue" fines, and both are added to `Fines` collection, the `Sum` operation correctly aggregates them.
- **Format**: `ToString("C0", vi-VN)` produces "50.000 ₫" or similar. This matches "format giống vậy".

No logical changes to receipt needed, just validation.
