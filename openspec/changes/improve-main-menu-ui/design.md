## Decisions
- **Control Selection**: Use `Guna2Button` for menu items. These controls support `Image`, `HoverState`, `CheckedState`, and `CustomizableEdges`, making them ideal for modern UI.
- **Layout**: Use a `Panel` or `FlowLayoutPanel` docked to the left. If the menu items are static, individual buttons can be placed manually for better design-time control.
- **State Management**: Use `CheckedState` and `RadioButton` mode of Guna buttons to automatically handle "active" item highlighting.
- **Icons**: Since we are in a text-based environment, I will attempt to use existing resources if possible, or generate new ones and save them to the `Resources` folder. I will use high-quality PNGs with transparency.

## Proposed Layout
- `pnlLeft`: `Dock = Left`, `Width = 260`
- `lblMenuHeader`: `Dock = Top`, `Height = 100`, styled with a logo.
- `menuContainer` (FlowLayoutPanel): `Dock = Fill`.
- `btnLogout`: `Dock = Bottom`, `Height = 60`.
