# autosauce
Mini Automated Web Testing Project - Engineering 120

## Project goal
To test the website www.saucedemo.com using automated tests with Selenium and Specflow and to report any defects found

## Features tested

### 1. Logging in

Happy path
- Correct usernames, correct password

Sad paths
- Correct usernames, incorrect password
- Correct usernames, empty password
- Incorrect username, correct password
- Incorrect username, incorrect password
- Incorrect usernames, empty password
- Empty username, correct password
- Empty username, incorrect password


### 2. Products

Happy paths
- Adding items
- Removing items


### 3. Checking out
#### Checking Out Step One

Happy path
- Having entered first name, last name, postal code

Sad path
- Empty first name, last name, and postal code
- Empty first name
- Empty last name
- Empty postal code

#### Checking Out Step Two

Happy paths
- finishing the transaction
- canceling the transaction

## Defects found

### 1. Logging in
locked_out_user cannot log in
![pic1](pic1.png)

### 2. Products
problem_user cannot remove item
![pic2](pic2.png)


## Project progress

### Original plan
![pic3](pic3.png)

### After review
Focusing on the core features that bring the most value to the business
![pic4](pic4.png)


