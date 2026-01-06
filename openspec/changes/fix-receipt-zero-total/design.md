# Design

## Logic Update

### Current Logic
```csharp
decimal total = _currentLoan.Fines.Where(f => f.TrangThaiThanhToan != "Đã thanh toán").Sum(f => f.SoTienPhat);
```

### New Logic
```csharp
decimal total = _currentLoan.Fines.Sum(f => f.SoTienPhat);
```
*Rationale*: The receipt details section lists *all* fines on the loan. The total must equal the sum of the lines printed above it. Whether paid or not, the "Total Payment" (or "Total Amount" in this context) represents the total value processed.
