Feature: Pmi Certifications

Scenario Outline: As a user, I should go to the Certifications page and see some widgets
	Given I am on the Pmi home page
	When I click on the main navbar link "Certifications"
	Then I should see a page with following <widgets>
	Examples: 
	| widgets       |
	| rte           |
	| notification  |
	| image-caption |
	| no-margin     |
	| faq           |
