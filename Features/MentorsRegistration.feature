Feature: MentorsRegistration
	As a user of Mentorskid website
    I want to be able to register as a Mentor
	So that I can be availabe to mentees

@MEN-11
Scenario Outline:Valid Registration for Mentor
	Given that a user navigate on https://mentorskid.com/
	When user clicks on the Join as a Mentor's button on the homepage banner
	And user enters first name "<First Name>"
	And user enters last name "<Last Name>"
	And user enters email address in the given email field as "<EmailField>"
	And user enters password as "<Password>"
	And user clicks on instructor radio button
	And user clicks on the terms and conditions checkbox
	And user clicks on the "Join now" button
	Then the registered page is displayed	
Examples:
	| First Name  | Last Name | EmailField           | Password      |
	| Demo-Mentor | TesterD   | QATester@testing.com | password1234  |
	| Test-Mentor | TesterQA  | QATester@testing.com | #1234password |
 

Scenario Outline: Invalid Password Registration of Mentor
    Given that a user navigate on https://mentorskid.com/
	When user clicks on the Join as a Mentor's button one the homepage banner
	And user enters first name "<First Name>"
	And user enters last name "<Last Name>"
	And user enters email address in the given email field as "<EmailField>"
	And user enters password as "<Invalid Password>"
	And user clicks on instructor radio button
	And user clicks on the terms and conditions checkbox
	And user clicks on the "Join now" button
	Then the text "Password must be 8 characters" is displayed
Examples:
	| First Name  | Last Name   | EmailField           | Invalid Password |
	| Prof-Mentor | User-Tester | QATester@testing.com | pass             |
	| Doc-Testa   | TesterQA    | QATester@testing.com | #1234            |
