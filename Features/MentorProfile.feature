Feature: MentorProfile
	As a Mentee user of mentorskid website
	I want the Side Navigation Panel to be displayed
    So that I can see the features and functions available to me as a Mentee

Background: 
     Given that a user navigate on https://mentorskid.com/login/
	When user enters username or email address "QATester@fake-box.com"
	And user enters login password "password1234"
	And user clicks on submit button
	Then the user registered page is displayed
@PBI12554
Scenario: To verify Mentor's profile page
    Given user is on "My Profile" page
    When user select gender from the dropdown menu
	And user enters hourly fee "£500"
	And user enters his tagline "Demo12345"
	And user selects his country from the dropdown
	And user enters his address "7 Tester Arena"
	And user enters his postcode "WC2N 5DU"
	And user select his preferred language or languages
	And user select the teaching location as online
	And user writes out a brief introduction about himself "I am an experienced instructor"
	Then user saves and update his profile