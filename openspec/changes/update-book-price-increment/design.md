# Design

## Overview
The `NumericUpDown` control `numPrice` in `QuanLiSach` currently uses the default increment of 1. We will explicitly set the `Increment` property to 500.

## Implementation Details
- Locate `numPrice` initialization in `QuanLiSach.Designer.cs` or in the `QuanLiSach` constructor/Load event.
- Set `numPrice.Increment = 500;`.
