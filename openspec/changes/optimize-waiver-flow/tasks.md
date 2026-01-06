# Tasks

- [x] Create `FormWaiver.cs` (and Designer) with radio buttons for "%" / "VND", a numeric input, and a text box for "Reason". <!--id: create-form-->
- [x] Update `FineService.cs` to add `ApplyWaiver(int fineId, decimal amount, bool isPercentage, string reason, string performer)`. <!--id: update-service-->
- [x] Update `FormFine.cs` to use `FormWaiver` and call the new service method. <!--id: integrate-ui-->
