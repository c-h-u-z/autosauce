Feature: Sauce_Checkout1

As a user,
I want to be able to fill out my name and postal code
So that I can continue to checkout

@HappyPath
Scenario: Have entered a first name, a last name, and a postal code
Given I have signed in with username "<username>"
And I have added an item
And I have clicked the cart and clicked checkout
And I have entered a first name
And I have entered a last name
And I have entered a postal code
When I click the continue button
Then I should be taken to the check out step two page
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@SadPath
Scenario: Have not entered any first name, last name, or postal code
Given I have signed in with username "<username>"
And I have added an item
And I have clicked the cart and clicked checkout
When I click the continue button
Then I should be thrown an exception "Error: First Name is required"
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@SadPath
Scenario: Have entered a first name, a last name, but not a postal code
Given I have signed in with username "<username>"
And I have added an item
And I have clicked the cart and clicked checkout
And I have entered a first name
And I have entered a last name
When I click the continue button
Then I should be thrown an exception "Error: Postal Code is required"
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@SadPath
Scenario: Have entered a first name, a postal code, but not a last name
Given I have signed in with username "<username>"
And I have added an item
And I have clicked the cart and clicked checkout
And I have entered a first name
And I have entered a postal code
When I click the continue button
Then I should be thrown an exception "Error: Last Name is required"
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@SadPath
Scenario: Have entered a last name, a postal code, but not a first name
Given I have signed in with username "<username>"
And I have added an item
And I have clicked the cart and clicked checkout
And I have entered a last name
And I have entered a postal code
When I click the continue button
Then I should be thrown an exception "Error: First Name is required"
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |