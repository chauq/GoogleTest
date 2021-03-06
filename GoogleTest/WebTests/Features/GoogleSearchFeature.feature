﻿Feature: GoogleSearch

@google
Scenario: Verify the search Functionality of Google Search page
Given I navigate to the page "www.google.com"
And I see the page is loaded
When I enter Search Keyword in the Search Text box
| Keyword  |
| SpecFlow |
And I click on Search Button
Then Search items shows the items related to SpecFlow

@ignore @google
Scenario: Verify the SpecFlow can fail
Given I navigate to the page "www.google.com"
And I see the page is loaded
When I enter Search Keyword in the Search Text box
| Keyword  |
| fail	   |
And I click on Search Button
Then Search items shows the items related to SpecFlow