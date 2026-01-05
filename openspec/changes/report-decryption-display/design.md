# Design: Report Data Decryption

## Strategy
The application uses `CryptoHelper` with a static IV, ensuring deterministic encryption. This allows the database to correctly `GroupBy` encrypted fields (like Name or Email) because identical plaintext results in identical ciphertext.

However, the raw data returned by EF Core queries remains encrypted. We cannot decrypt inside the LINQ-to-SQL `Select` projection because `CryptoHelper.Decrypt` cannot be translated to SQL.

## Implementation Pattern
The data loading process for reports will be refactored to a 2-step process:
1.  **Fetch Data**: Execute the query (including aggregations like `Sum`, `Count`) against the database and retrieve the results into memory (using `ToList()`). The sensitive fields in this result set will still be encrypted.
2.  **Decrypt Data**: Use LINQ-to-Objects (in-memory) to project the result set into a new list, applying `CryptoHelper.Decrypt()` to all sensitive fields.

```csharp
// Step 1: Query DB
var rawData = db.Loans
    .GroupBy(...)
    .Select(g => new { EncryptedName = g.Key.FullName, ... })
    .ToList();

// Step 2: Decrypt
var finalData = rawData.Select(r => new {
    DisplayValidName = CryptoHelper.Decrypt(r.EncryptedName),
    ...
}).ToList();

// Step 3: Bind
dgvReport.DataSource = finalData;
```

## Affected Reports
1.  **Active Members (`GenerateActiveMembersReport`)**: Member Name, Phone, Email.
2.  **Fine Revenue (`GenerateFineRevenueReport`)**: Member Name.
3.  **Inventory (`GenerateInventoryReport`)**: Publisher Name, Address (if displayed/used), Author Name (if encrypted).
    *   *Note*: `Author` entity review required. If `Author.Name` is not encrypted, no change needed there. `Publisher.TenNhaXuatBan` is known to be encrypted.
4.  **Most Borrowed Books (`GenerateMostBorrowedBooksReport`)**: Author Name (check status), Publisher (not displayed currently but if added later).

## Performance
Since report queries are already limited (`Take(20)`) or aggregated, the overhead of decrypting a small set of result rows in memory is negligible.
