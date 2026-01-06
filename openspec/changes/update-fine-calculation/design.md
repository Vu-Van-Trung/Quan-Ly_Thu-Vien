# Design

## Logic Updates (`FineService.cs`)

### Late Fee
- **Current**: 5000 VND/day.
- **New**: 500 VND/day.
- **Implementation**: Change `FINE_PER_DAY` constant.

### Lost Book ("Mất")
- **Current**: 100% Price (x1).
- **New**: 300% Price (x3).
- **Implementation**: Return `price * 3`.

### Damaged Book ("Hư hỏng")
- **Current**: 50% Price.
- **New**: Flat fee of 10,000 VND.
- **Implementation**: Return `10000`.

## UI Updates (`FormFine.cs`)

### Formatting
- Use `amount.ToString("C0", new CultureInfo("vi-VN"))` for displaying the total fine amount.
