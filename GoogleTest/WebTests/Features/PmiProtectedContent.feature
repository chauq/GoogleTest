Feature: Pmi protected content
	As a user, when you go to a protected page, then I should only see some text and not see the protected contact

Scenario: As a user, I should see a 403 message if I go to the protected item test
	Given I am on the Pmi home page
	When I go to the a protected item page
	Then I should see a page with the message that Access is Denied