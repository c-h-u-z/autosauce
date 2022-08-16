Feature: Sauce_Cart

As a user
I want to be able to checkout
So that I can buy the things I want to buy

@HappyPath
Scenario: Checkout Page
Given I have signed in with username "<username>", added a backpack, and clicked the cart
When I click checkout
Then I should be taken to the checkout page
Examples:
| username                |
| standard_user           |
| problem_user            |
| performance_glitch_user |
