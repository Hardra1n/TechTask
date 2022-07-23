Feature: DropDownMenu

DDM for Drop Down Menu

@browser
Scenario: Number of countries should be correct
	Given Browser is on the DDM page
	When Number of options in DDM is calculated
	Then Result equals to '<number of countries>'

	Examples: 
	| number of countries |
	| 249                 |