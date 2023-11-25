Feature: AboutUs
	As a user of www.mentorskid.com
    I want to navigate on the About Us page
    So that I can view and respond to all the sections or containers

@mytag
Scenario: Scrolling on each section of the About Us page
	Given that I am a user of mentorskid website
    When I click on the About us tab from the Menu
    Then I am directed to the About us page
    And I scroll to the second section: How it works
    And I scroll to the third section: Call to action