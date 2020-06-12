Feature: g2oSite1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Browser_Chrome
Scenario Outline: Visit g2o
	Given The user has avigated to g2o's website
	#When the user has clicked <navigation>
	Then the new URL should contain '/ourwork'
	Examples: 
	| navigation |
	|    Our Work    |
