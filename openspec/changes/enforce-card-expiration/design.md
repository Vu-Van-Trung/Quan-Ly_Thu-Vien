# Design

## Logic
Layer: Application Logic (UI/Form Code in `FormLoan`).
Trigger: `btnThem_Click`.

### Algorithm
1. Retrieve Member by ID.
2. Check `TrangThai` (Existing).
3. Check `NgayHetHan`:
   ```csharp
   if (member.NgayHetHan != null && member.NgayHetHan.Value.Date < DateTime.Now.Date)
   {
       // Block
   }
   ```
   *Note: Using `.Date` comparison to be precise, ensuring expiration happens at the end of the day or start of the next day as per business rule (usually strictly < Now means expired).*

## UI
Blocked MessageBox with Warning Icon.
