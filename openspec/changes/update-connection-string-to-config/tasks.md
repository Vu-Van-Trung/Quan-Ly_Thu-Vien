## 1. Setup
- [x] 1.1 Create `App.config` in `DEMO_GUI_QLTHUVIEN` root directory
- [x] 1.2 Add the connection string to `App.config`
- [x] 1.3 Add `System.Configuration.ConfigurationManager` NuGet package to `DEMO_GUI_QLTHUVIEN.csproj`

## 2. Implementation
- [x] 2.1 Update `LibraryContext.cs` to import `System.Configuration`
- [x] 2.2 Modify `OnConfiguring` method in `LibraryContext.cs` to read from `ConfigurationManager`

## 3. Verification
- [x] 3.1 Build the project to ensure no errors
