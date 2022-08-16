Feature: Sauce_Products

As a user
I want to be able to add and remove items
So that I can select the items that I want to buy

@HappyPath
Scenario: Adding items
Given I have signed in with username "<username>" and landed on the product page
And I have added a backpack
When I click the cart
Then the item will be added as shown in the cart page
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |

@HappyPath
Scenario: Removing items
Given I have signed in with username "<username>" and landed on the product page
And I have added a backpack
And I have removed backpack
When I click the cart
Then the item will be removed as shown in the cart page
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |