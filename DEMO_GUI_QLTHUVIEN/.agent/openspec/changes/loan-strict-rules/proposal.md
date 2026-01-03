# Strict Loan Rules: Fines & Card Expiry

## Goal
Extend the loan validation logic to include checks for:
1.  **Unpaid Fines**: Block borrowing if there are any `Fine` records linked to the member's loans where `TrangThaiThanhToan == "Chưa thanh toán"`.
2.  **Card Expiry**: Block borrowing if `Member.NgayHetHan < DateTime.Now`.

## Existing Rules (Already Implemented)
- Member Status (Must be "Hoạt động")
- Overdue Books (Must not have overdue books)
- Quantity Limit (Max 5 unreturned books)

## Implementation Plan
- **Location**: `FormLoan.cs`, inside `btnThem_Click`.
- **Logic**: Append new checks to the existing validation block.
    - **Expiry Check**: `if (member.NgayHetHan != null && member.NgayHetHan < DateTime.Now)`
    - **Fine Check**: Join `Loans` -> `Fines` for the `MemberId`. check `f.TrangThaiThanhToan == "Chưa thanh toán"`.
