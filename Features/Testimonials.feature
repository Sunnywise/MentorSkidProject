Feature: Testimonials
   As a user of www.mentorskid.com
   I want to see the fifth section on the landing page
   So that I can be able to read the testimonials

@PBI12361
Scenario: Verify user(s) can view and read other users' testimonials
	Given a user navigates to www.mentorskid.com
    When user scrolls to the fifth section on the landing page
    And user should read the text title header as "See how our members have made their success stories..." 
    Then user must be able to view and read the three testimonials in a container
    When user clicks the toggle button for the image carousel
    Then user must see the next testimonials.