Feature: Login
	Check if login functionality works


@mytag
Scenario: Login user as User
	Given I navigate to application
	And I click the Login link
	And I enter username and password
		| UserName | Password |
		| UserPassword    | password |
	And I click login
	Then I should see user logged in to the application