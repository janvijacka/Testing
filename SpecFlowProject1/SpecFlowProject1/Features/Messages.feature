Feature: Messages

Feature used to send a message to the company.

@tag1
Scenario: Everything is entered correctly
	Given I open the website
	And I click the Messages link
	When I enter the name "Johnny"
	And I enter the email "johnny@deep.com"
	And I enter the message "Joha joha joha"
	And I click the Create button
	Then my message should be displayed
	And I can close the browser window

Scenario: Forget to enter email
	Given I open the website
	And I click the Messages link
	When I enter the name "Johnny"
	And I enter the message "Joha joha joha"
	But I forgot to enter the email
	And I click the Create button
	Then the error messages shows
	And I can close the browser window
