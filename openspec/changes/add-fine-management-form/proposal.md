# Change: Add Fine Management Form (Phiếu Phạt & Trả Sách)

## Why
Currently, the system needs a dedicated interface to handle book returns, especially when fines are involved (overdue or damaged). This form will streamline the process of checking borrow slips, calculating fines, and finalizing returns/payments.

## What Changes
- **New UI**: Create a "Fine Management" (Phiếu Phạt) form.
- **Features**:
    - Search/Check by `MaPhieuMuon`.
    - Auto-calculate fines (Overdue days * 5,000 VND).
    - Handle Book Return (Update status).
    - Quick Payment & Waiver options.
    - Print Receipt.
- **Database**:
    - Insert into `PHAT` table when applicable.
    - Update `PHIEU_MUON` lines/details.

## Impact
- **Affected Specs**: `fine-management`, `borrow-return-process`
- **Affected Code**: 
    - New Form: `FineMgtForm` (or similar).
    - New/Updated Service: `FineService`, `BorrowService`.
