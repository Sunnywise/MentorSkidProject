Feature: CategoryFilter
	As a user of www.mentorskid.com
    I want to be able to filter the different Categories and Subcategories when searching for Mentors
    So that I can see the relevant Mentors based on my search

@PBI12360
Scenario: Mentors' search categories
	Given that I am a user of www.mentorskid.com
    When I click on Find a Mentor from the Main Menu
    And I click on the angle down icon or select category button
    And i click on the search now button
    And i randomly select any course of interest.
    Then I must see all the Subcategories listed on the Side Navigation Panel