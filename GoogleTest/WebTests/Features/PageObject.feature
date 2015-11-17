Feature: PageObject Design Pattern

Scenario: Log into the Flights application
	Given I go to the Test page
	When I login into the Flights application
	Then I should get the Find Flights page
