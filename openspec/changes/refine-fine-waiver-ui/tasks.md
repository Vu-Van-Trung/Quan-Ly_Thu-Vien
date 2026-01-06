# Tasks

- [x] Update `FormFine.cs`: Add `ConfigureBeautifulGrid` helper and apply to `dgvBooks`/`dgvFines` in `Load`. <!--id: fine-grid-->
- [x] Update `FormFine.cs`: Replace standard `Button` controls (Pay, Return, Waiver) with styled `Guna2Button`s (Green for Pay/Return, Orange/Blue for others). <!--id: fine-buttons-->
- [x] Refactor `FormWaiver.cs`: Update inheritance to standard Form but remove border; Add `Guna2BorderlessForm`. <!--id: waiver-form-->
- [x] Update `FormWaiver.Designer.cs`: Replace all controls with Guna2 equivalents (`Guna2RadioButton`, `Guna2NumericUpDown`, `Guna2TextBox`, `Guna2Button`, `Guna2GradientButton` for OK). <!--id: waiver-controls-->
