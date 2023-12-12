Feature: MentorAvailability
    As a mentor on Mentorskid
    I want to be able to select the my booking feature on my profile
    So that I can select my availability
	
Background: 
    Given that a user navigate on https://mentorskid.com/login/
    When user enters username or email address "alpha.beta@testing.com"
	And user enters login password "password1234"
	And user clicks on submit button
	And a user clicks on the My Calendar button at the side navigation panel
    Then user clicks on Add/Edit bookings.

Scenario: Adding MentorTime slots
   Given user clicks on Add time slots.
   And user clicks on new add time slots
   And user selects available service days from the drop-down
   And user enters the Slot/Appointment Title in the text field as "Learn to automate web application using Selenium "
   And user selects the start and end times from the drop list
   And user selects Break time from the drop-down list
   And user selects Session duration from the drop-down list
   And user selects the number of appointment spaces from the checkbox 
   When user clicks on the Generate appointment slots button
   Then my appointment slots must be generated
Scenario: Mentor unavailability days
  Given user clicks on the Add unavailable days.
  When user selects start and end dates.
  And user clicks on the Mark these days unavailable. 
  And user clicks on save and update changes.
  Then success update message pops up