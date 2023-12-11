Feature: AvailabilityDaysFilter
   As a registered mentee on www.mentorskid.com
   I want to be able to search for mentors' availability based on the days of the week
   So that I can see the relevant mentors based on the day(s) I selected

@PBI12406
Scenario: Filtering'mentor availabiliy days
	Given that I am a registered mentee on mentorskid's webpage
    When I click on find a mentor from the main menu
    And I scroll down to mentor availability on the Side Navigation Panel to view all the days of the week
    And I click the checkbox for my desired day(s) of the week
    And I click on the Apply filters button
    Then I must see all the mentors that are available, based on the days I selected
