# Enable Comprehensive Return Fines Waiver

## Summary
Update the Return Book workflow (`FormFine`) to detecting and prompting for waiver/payment for **all** types of generated fines (Overdue AND Condition/Damage), not just Overdue fines.

## Background
Currently, the system only calculates and prompts for "Overdue" fines (`totalOverdueGenerated`) during the return process.
If a book is returned on time but is Damaged/Lost (generating a Condition Fine), the system does **not** prompt the user to handle this fine immediately. The user must manually find and select the fine to waive or pay it.
The user requested "waive for all cases", implying this gap needs to be closed.

## Goals
- Ensure `FineService.ReturnBook` returns information about generated Condition Fines.
- Update `FormFine.ProcessReturnForRows` to track both Overdue and Condition fines.
- Trigger the "Process Fines" (Waiver/Payment) prompt if *any* fine matches (Overdue > 0 OR Condition > 0).
- Update the prompt message to accurately reflect the total fine amount and types.

## Non-Goals
- Changing the fine calculation logic itself (pricing).
- Changing the Waiver Form UI (`FormWaiver`).
