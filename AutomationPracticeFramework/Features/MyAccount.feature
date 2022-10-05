Feature: MyAccount
	User fills fields to log in

@mytag
Scenario: User can log in to his account
	Given user clicks on 'SIGN IN' button
	When fills in 'Email address' and 'Password' fields
	And user cliks 'Sign in' button
	Then 'MY ACCOUNT' message is displayed