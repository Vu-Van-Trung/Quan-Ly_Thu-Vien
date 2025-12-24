# Change: Update connection string to App.config

## Why
Hardcoding the connection string in `LibraryContext.cs` is not a best practice. It makes it difficult to change the database server or database name without recompiling the application. Moving it to `App.config` allows for easier configuration management.

## What Changes
- Create `App.config` file if it doesn't exist.
- Add `<connectionStrings>` section to `App.config`.
- Add `System.Configuration.ConfigurationManager` package to the project.
- Modify `LibraryContext.cs` to read the connection string from `App.config` using `ConfigurationManager`.

## Impact
- **Affected code**: 
    - `DEMO_GUI_QLTHUVIEN/Data/LibraryContext.cs`
    - `DEMO_GUI_QLTHUVIEN/App.config`
    - `DEMO_GUI_QLTHUVIEN/DEMO_GUI_QLTHUVIEN.csproj`
