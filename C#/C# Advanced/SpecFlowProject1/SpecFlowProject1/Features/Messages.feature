Feature: Messages
In order to contact the company
As a website visitor
I want to send a message

@mytag
Scenario: I sent a message successfully
	Given I have opened the website
	Given I have entered a name
	And I have entered a correct email
	And I have entered some message
	When I click The Create button
	Then the succes message should be displayed

Scenario: I forgot to enter the e-mail
Given I have opened the website
And I have entered a name
But I have forgotten to enter the e-mail
And I have entered some message
When I click The Create button
Then the error message should be displayed
	