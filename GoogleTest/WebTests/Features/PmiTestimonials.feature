Feature: Pmi Testimonials

Scenario Outline: As a user, If I go to the Testimonials page, I should see some widgets
	Given I am on the Pmi home page
	When I go to the testimonials page
	Then I should see a page with following <widgets>
	Examples: 
	| widgets						|
	| quotation-central				|
	| quotation-central				|
	| quotation						|