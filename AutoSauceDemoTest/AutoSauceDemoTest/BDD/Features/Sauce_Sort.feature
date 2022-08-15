Feature: Sauce_Sort

A short summary of the feature

@HappyPath
Scenario: Sort Menu
Given I am signed in with username "<username>" and landed on product page
When I click the sort menu
Then a menu displaying all sorting methods will appear
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@HappyPath
Scenario: Sort Name (A to Z)
Given I am signed in with username "<username>" and landed on product page
When I click sort by "Name (A to Z)"
Then the items will be sorted by name from A to Z
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@HappyPath
Scenario: Sort Name (Z to A)
Given I am signed in with username "<username>" and landed on product page
When I click sort by "Name (Z to A)"
Then the items will be sorted by name from Z to A
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@HappyPath
Scenario: Sort Price (low to high)
Given I am signed in with username "<username>" and landed on product page
When I click sort by "Price (low to high)"
Then the items will be sorted by price from low to high
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@HappyPath
Scenario: Sort Price (high to low)
Given I am signed in with username "<username>" and landed on product page
When I click sort by "Price (high to low)"
Then the items will be sorted by price from high to low
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |