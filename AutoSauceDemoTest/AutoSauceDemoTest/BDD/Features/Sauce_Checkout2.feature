Feature: Sauce_Checkout2

As a user,
I want to be able to finish checking out
So that I can complete my transaction

@HappyPath
Scenario: Finish the transaction
Given I have signed in with username "<username>" and landed on the product page
And I have added a backpack
And I have clicked the cart and clicked checkout
And I have entered a first name
And I have entered a last name
And I have entered a postal code
And I have clicked the continue button
When I click the finish button
Then I should be able to complete the transaction
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@HappyPath
Scenario: Cancel the transaction
Given I have signed in with username "<username>" and landed on the product page
And I have added a backpack
And I have clicked the cart and clicked checkout
And I have entered a first name
And I have entered a last name
And I have entered a postal code
And I have clicked the continue button
When I click the cancel button
Then I should be able to cancel the transaction
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |