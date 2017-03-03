Feature: Login
	In order to login to Admin Site
	As admin user
	I have to enter valid email and password

@mytag
Scenario: Logging in with valid credentials
	Given I am at the Admin Login Page
	And I have entered valid credentials
	When I press log in button
	Then I am directed to Manage Page


