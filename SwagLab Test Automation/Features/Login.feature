Feature: User Login

	Scenario: Login with empty credentials
		Given I am on the login page
		When I attempt to login with empty credentials
		Then I should see an error message "Epic sadface: Username is required"

	Scenario: Login with missing password
		Given I am on the login page
		When I attempt to login with username and missing password
		Then I should see an error message "Epic sadface: Password is required"
		
	Scenario: Login with locked out user
		Given I am on the login page
		When I attempt to login with locked out user
		Then I should see an error message "Epic sadface: Sorry, this user has been locked out."

	Scenario Outline: Successful login with valid credentials
		Given I am on the login page
		When I enter username "<username>" and password "<password>"
		And I click the login button
		Then I should be redirected to the Swag Labs title page

		Examples:
			| username               | password		  |
			| standard_user          | secret_sauce   |
			| problem_user           | secret_sauce   |
			| performance_glitch_user| secret_sauce   |
			| error_user             | secret_sauce   |
			| visual_user            | secret_sauce   |