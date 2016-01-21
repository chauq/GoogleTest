Feature: Pmi protected content
	As a Content Editor
	I want to be able to restrict access to content, excluding reference articles
	So that I can control the benefits of becoming a Registered User or a Member, 
	constructing rules such as “Member only if within 90 days of Publication Date, else Registered User only".

	As a User 
	When I go to a protected item page, then I should only see a page with a 403 : Access is Denied message
	When I go to a protected content page, then I should only see some Abstract text from the content 
	and not see the main protected content itself.

Scenario: As a user, I should see a 403 message if I go to the protected item test page
	Given I am on the Pmi home page
	When I go to the a protected item page
	Then I should see a page with the message that Access is Denied