﻿Feature: Pmi Homepage
	As a User 
	when you go to the homepage, then I should see some text

Scenario Outline: As a user, I should see some body text
	Given I am on the Pmi home page
	Then I should see a page with following <widgets>
	Examples: 
	| widgets			|
	| rte				|