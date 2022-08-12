Feature: Sauce_Login

As a user with an account, 
I want to be able to log in 
So that I can use the site

@HappyPath
Scenario: Correct username and password
Given I enter a correct username and a correct password
When I click the login button
Then I should be taken to the products page

@SadPath
Scenario: Correct username incorrect password
Given I enter a correct username and an incorrect password
When I click the login button
Then I should get an exception thrown

@SadPath
Scenario: Incorrect username correct password
Given I enter an incorrect username and a correct password
When I click the login button
Then I should get an exception thrown