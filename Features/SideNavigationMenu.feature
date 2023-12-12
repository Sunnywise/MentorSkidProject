Feature: SideNavigationMenu
	As a Registered Mentee user of mentorskid website
	I want the Side Navigation Panel to be displayed
    So that I can see the features and functions available to me as a Mentee

Background: 
    Given that a user navigate on https://mentorskid.com/login/
	When user enters username or email address "menteeTester@opentrash.com"
	And user enters login password "password1234"
	And user clicks on submit button
	Then the user registered page is displayed
@PBI12370
Scenario: To verify side navigation menu by mentee
    Given I view the Side Navigation Panel with upload text messages "You can upload"
    And I click on the downward arrow icon for the submenu to collape
	Then I click on the forward arrow icon for the sub-menu to expand
