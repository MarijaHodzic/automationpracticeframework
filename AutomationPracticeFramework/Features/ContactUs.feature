Feature: ContactUsFeature
	As  a user
	I want to be able to se contact us form
	So I can contact customer service

@mytag
Scenario: User can contact customer service
	Given user opens contact us page
	When user fill in all required fields with 'Webmaster' heading and 'QA kurs' message
	And user submits the form
	Then message 'Your message has been successfully sent to our team.' is presented to the user
	         