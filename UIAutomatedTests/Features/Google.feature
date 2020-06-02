Feature: Google
	In order to browse the internet
	As a user
	I want to be able to use the lucky button


#@Browser_IE
@Browser_Chrome
Scenario Outline: I'm feeling lucky
	Given the user has navigated to google
	When the user clicks on the '<button title>'
	Then the url will not contain '<domain name>'
	Examples: 
	| button title | domain name |
	| I'm Feeling Lucky    |  google      |



@ignore
@Browser_Chrome
Scenario Outline: Searching for term
	Given the user has navigated to google
	When the user enters '<search term>'
	And clicks search
	Then the url will change and contain '<search term>'
	Examples: 
	| search term|
	| I'm Feeling Lucky    | 