# Refine Librarian Name on Receipt

## Summary
The user requested corrections to the previous "Auto-Fill Librarian Name" feature:
1.  **Do NOT use Username:** "Không lấy tên đăng nhập". This implies we need the *Full Name* of the staff member.
    Currently `Session.cs` only has `CurrentUserId` and `CurrentUsername`.
    We need to fetch the `Staff` (NhanVien) full name from the database using `CurrentUserId` or `CurrentUsername`.
2.  **Remove Payer Name:** "Bên người nộp không cần thiết". I previously added it proactively; I will remove it.

## Changes
1.  **Modify `Session.cs`?** Or just fetch inside `FormFine`?
    Fetching inside `FormFine` is safer as `Session` is static and might need DB context to populate "FullName" which we don't want to couple tightly if not needed elsewhere yet.
    However, `FineService` has access to DB.
    Or we can use `_fineService` to get the Librarian Name by `Session.CurrentUsername`?
    No, `_fineService` is for Fines.
    We can add a helper in `FineService` or use `LibraryContext` directly? `FormFine` doesn't hold `LibraryContext` directly, it uses `FineService`.
    
    Better approach: Add `public string GetStaffFullName(string username)` to `FineService`.
    In `FormFine`, call `_fineService.GetStaffFullName(Session.CurrentUsername)`.

2.  **Update `FormFine.PrintDocument1_PrintPage`**:
    - Call the new service method to get the full name.
    - Remove the Payer Name drawing code.

## Design
`FineService.GetStaffFullName`:
- Look up `Staff` table (or whatever the User table is called, likely `NhanVien` or `User`?).
- Wait, I haven't seen the `Staff` model.
- Let's check `LibraryContext` or `Models` to find the User table.
- Earlier contexts mentioned `FormStaff`, `QuanLyTaiKhoan`.
- Likely `Account` or `NhanVien` table.
- `Session.CurrentUsername` is likely from `Account`.
- We need to find the link.

Let's assume there is a `Staff` or `User` table. I'll search for it.
