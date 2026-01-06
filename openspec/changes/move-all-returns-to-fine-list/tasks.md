# Tasks

- [ ] Update `FormFine.cs` logic to ensure that even for "Normal" ("Tốt") books, if there is an overdue fee ("Tiền mượn"), it is created as a `Fine` entry. (Already implemented in V2, just verification needed or slight adjustment if "Normal" returns without overdue were also expected to show up - assuming standard overdue logic implies fee > 0). <!--id: ensure-overdue-is-fine-->
- [ ] Verify that "Damaged" ("Hư hỏng") and "Lost" ("Mất") returns generate their respective Fine entries. <!--id: verify-condition-fines-->
- [ ] Confirm that `dgvFines` refreshes and shows these entries immediately after return. <!--id: refresh-grid-->
