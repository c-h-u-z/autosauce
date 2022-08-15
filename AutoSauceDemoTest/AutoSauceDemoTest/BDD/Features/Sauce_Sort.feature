Feature: Sauce_Sort

A short summary of the feature

@HappyPath
Scenario: Sort Menu
Given I am on the product page
When I click the sort menu
Then a menu displaying all sorting methods will appear

@HappyPath
Scenario: Sort Name (A to Z)
Given I am on the product page
And I have clicked the sort menu
When I click sort by name (A to Z)
Then the items will be sorted by name from A to Z

@HappyPath
Scenario: Sort Name (Z to A)
Given I am on the product page
And I have clicked the sort menu
When I click sort by name (Z to A)
Then the items will be sorted by name from Z to A

@HappyPath
Scenario: Sort Price (low to high)
Given I am on the product page
And I have clicked the sort menu
When I click sort by price (low to high)
Then the items will be sorted by price from low to high

@HappyPath
Scenario: Sort Price (high to low)
Given I am on the product page
And I have clicked the sort menu
When I click sort by price (high to low)
Then the items will be sorted by price from high to low