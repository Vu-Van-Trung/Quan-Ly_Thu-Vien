# Update Book Price Increment

## Summary
Update the Price increment step in the Book Management form (`QuanLiSach`) to 500. This ensures that when users use the up/down arrows or buttons on the price field, the value changes by 500 units instead of the default 1.

## Motivation
Standard book prices often move in larger increments (e.g. 500, 1000). A step of 1 is too granular and inconvenient for users.

## Scope
- `QuanLiSach.cs` / `QuanLiSach.Designer.cs`: Update `numPrice` control configuration.
