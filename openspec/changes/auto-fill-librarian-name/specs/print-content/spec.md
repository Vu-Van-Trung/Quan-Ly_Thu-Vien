# Receipt Librarian Name

## ADDED Requirements

#### Scenario: Print Receipt Librarian Name
Given a logged-in user "staff01"
When the receipt is printed
Then the text "staff01" should appear approximately 80-100px below the "Thủ thư" header section
Aligning with the signature block to indicate the identity of the issuer.
