# Staff Name Decryption Specs

## MODIFIED Requirements

### Staff Name Display
The system must display staff names in a readable (decrypted) format in the Account Management interface.

#### Scenario: Viewing Staff List in ComboBox
- Given I am on the Account Management form
- When I view the "Nhân viên" dropdown
- Then I should see real names (e.g., "Nguyen Van A") instead of encrypted strings

#### Scenario: Viewing Account List
- Given I am on the Account Management form
- When I look at the "Nhân viên" column in the account table
- Then I should see real names corresponding to the account owners
