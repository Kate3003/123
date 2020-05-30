Feature: Login
As a user of the website 
I want to log into the website

Scenario: Check for login

Given I open "http://localhost:5000" url
When I type in the fields Name "user", Password "user"
And I click the login button
Then The phrase should be  "Home page" 