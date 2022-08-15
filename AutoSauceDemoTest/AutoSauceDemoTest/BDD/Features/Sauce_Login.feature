﻿Feature: Sauce_Login

As a user with an account, 
I want to be able to log in 
So that I can use the site

@HappyPath
Scenario: Correct username and password
Given I am on the home page 
And I enter the username standard_user
And I enter a correct password
When I click the login button
Then I should be taken to the products page

@SadPath
Scenario: Correct username incorrect password
Given I am on the home page  
And I enter the username standard_user
And I enter an incorrect password
When I click the login button
Then I should get an exception thrown "Epic sadface: Username and password do not match any user in this service"

@SadPath
Scenario: Incorrect username correct password
Given I am on the home page 
And I enter an incorrect username 
And I enter a correct password
When I click the login button
Then I should get an exception thrown "Epic sadface: Username and password do not match any user in this service"

@SadPath
Scenario: Correct username, without password
Given I am on the home page 
And I enter the username standard_user
And I do not enter a password
When I click the login button
Then I should get an exception thrown "Epic sadface: Password is required"

@SadPath
Scenario: Incorrect username, without password
Given I am on the home page 
And I enter an incorrect username
And I do not enter a password
When I click the login button
Then I should get an exception thrown "Epic sadface: Password is required"

@SadPath
Scenario: Correct password, without username
Given I am on the home page 
And I enter a correct password
And I do not enter a username
When I click the login button
Then I should get an exception thrown "Epic sadface: Username is required"

@SadPath
Scenario: Incorrect password, without username
Given I am on the home page 
And I enter an incorrect password
And I do not enter a username
When I click the login button
Then I should get an exception thrown "Epic sadface: Username is required"

@SadPath
Scenario: Access products without login
Given I am on a search engine 
When i enter the web address for the products page 
Then I should get an error "Epic sadface: You can only access '/inventory.html' when you are logged in."