Feature: TMfeature

As a TurnUp portal admin
I would like to create, edit time and material records
So that I can manage employees' time and materials sucessfully

@tag1
Scenario: Create time and material record with valid details
	Given I logged into turnup portal sucessfully
	When I navigate to time and materials page
	And I create a new time and material record
	Then The record should be created sucessfully

Scenario Outline: Edit Existing time and material record with valid details
	Given I logged into turnup portal sucessfully
	When I navigate to time and materials page
	And I Update '<Description>' on an existing time and materials record
	Then The record should have the updated '<description>'

Examples: 
| Description |
| Time        |
| Material    |
| Editedrecord            |
 
	
 

