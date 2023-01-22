Feature: Login
	Check if login functionality works

	#@smoke @regressions @CCP-203
@mytag  
Scenario: Login user as User
	Given I navigate to application
	And I click the Login link
	And I enter username and password
		| UserName               | Password |
		| natlisjo@gmail.com     | Tindra52# |
	And I click login
	Then I should see user logged in to the application
	 
 