Feature: Pmi Chapters
	
	As a User I should be able to see and use the Chapter Search widget on the chapter page

Scenario Outline: As a user, I should see a number of widgets if I go to the chapter page
	Given I am on the Pmi home page
	When I go to the chapters page
	Then I should see a page with following <widgets>
	Examples: 
	| widgets			|
	| rte				|
	| chapters-near     |
	| chapters-search   |