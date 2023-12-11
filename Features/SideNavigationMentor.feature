Feature: SideNavigationMentor
	As a Registered Mentor user of mentorskid website
	I want the Side Navigation Panel to be displayed
    So that I can see the features and functions available to me as a Mentor

Background: 
    Given that a user navigate on https://mentorskid.com/login/
	When user enters username or email address "QATester@fake-box.com"
	And user enters login password "password1234"
	And user clicks on submit button
	Then the user registered page is displayed

@PBI12361
Scenario: To verify Mentor's profile page
    Given user sees the side navigation panel with "You can upload" message.
    When user clicks on the dropdown icon for the submenu to collape.
	Then user clicks on the forward arrow icon for the submenu to expand to view the sub-menu.