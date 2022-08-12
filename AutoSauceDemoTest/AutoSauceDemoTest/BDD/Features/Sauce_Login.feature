Feature: Sauce_Login

As a user with an account, 
I want to be able to log in 
So that I can use the site

@HappyPath
Scenario: Correct username and password
Given I am on the home page 
And I enter a correct username 
And I enter a correct password
When I click the login button
Then I should be taken to the products page

@SadPath
Scenario: Correct username incorrect password
Given I am on the home page  
And I enter a correct username
And I enter an incorrect password
When I click the login button
Then I should get an exception thrown

@SadPath
Scenario: Incorrect username correct password
Given I am on the home page 
And I enter an incorrect username 
And I enter a correct password
When I click the login button
Then I should get an exception thrown

@SadPath
Scenario: Correct username, without password
Given I am on the home page 
And I enter a correct username 
And I do not enter a password
When I click the login button
Then I should get an exception thrown

@SadPath
Scenario: Incorrect username, without password
Given I am on the home page 
And I enter an incorrect username
And I do not enter a password
When I click the login button
Then I should get an exception thrown

@SadPath
Scenario: Correct password, without username
Given I am on the home page 
And I enter a correct password
And I do not enter a username
When I click the login button
Then I should get an exception thrown

@SadPath
Scenario: Incorrect password, without username
Given I am on the home page 
And I enter an incorrect password
And I do not enter a username
When I click the login button
Then I should get an exception thrown