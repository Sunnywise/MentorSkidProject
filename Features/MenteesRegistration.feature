Feature: MenteesRegistration
	As a user of mentoskid website
    I want to be able to register as a Mentee
	So that I can create my account and book a session with a mentor

@MENTEES
Scenario Outline:Valid Registration of Mentee
	Given that I am a user of https://mentorskid.com/
	When I click on the start as a Mentee's button on the homepage banner
	And I enter first name "<First Name>"
	And I enter last name "<Last Name>"
	And I enter my email address in the email field as "<EmailField>"
	And I enter password of my choice as "<Password>"
    And I click on Mentee radio button
	And I click on the terms and conditions checkbox
	And I click on the "Join now" button
	Then the registered page for Mentee is displayed	
Examples:
	| First Name  | Last Name      | EmailField           | Password      |
	| Testi-money | Testing-Mentee | QATester@testing.com | password1234  |
	| Mentee      | Demo-Student   | QATester@testing.com | #1234password |

Scenario Outline: Invalid Password Registration of Mentee
    Given that I am a user of https://mentorskid.com/
	When I click on the start as a Mentee's button on the homepage banner
	And I enter first name "<First Name>"
	And I enter last name "<Last Name>"
	And I enter my email address in the email field as "<EmailField>"
	And I enter password of my choice as "<Invalid Password>"
    And I click on Mentee radio button
	And I click on the terms and conditions checkbox
	And I click on the "Join now" button
	Then the text "Password must be 8 characters" is displayed
Examples:
	| First Name | Last Name   | EmailField           | Invalid Password |
	| Tester     | User-Tester | QATester@testing.com | pass             |
	| TestA      | TesterQA    | QATester@testing.com | #1234            |
