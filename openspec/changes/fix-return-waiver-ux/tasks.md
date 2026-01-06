# Tasks

- [x] Update `FormFine.cs`: In `ProcessReturnForRows`, calculate total generated fine amount and display specific MessageBox ("Return Success. Overdue Fine: X. Please Pay/Waive"). <!--id: return-feedback-->
- [x] Update `FormFine.cs`: In `BtnWaiver_Click`, if no rows selected -> check `dgvFines`. If rows exist, select all/first and proceed to open Form. <!--id: auto-waiver-->
- [x] Update `FormFine.cs`: Ensure `LoadFines` re-selects relevant rows after reload if possible. <!--id: grid-selection-->
