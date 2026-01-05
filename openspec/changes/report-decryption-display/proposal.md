# Display Decrypted Data in Statistical Reports

## Problem
The `FormReport` form displays raw encrypted strings (Base64 format) for sensitive fields such as "Họ Tên" (Member Name), "Email", and "Số Điện Thoại" in various report tabs (Active Members, Fine Revenue). This makes the reports difficult to read and verify.

## Solution
Update the report generation logic to decrypt these sensitive fields using `CryptoHelper.Decrypt` before binding the data to the UI. This aligns the report behavior with other management forms like `FormPublisher` and `FormMember`.
