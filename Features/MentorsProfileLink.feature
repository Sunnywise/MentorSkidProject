Feature: MentorsProfileLink
	As a user of www.mentorskid.com
    I want to be able to copy the Mentor's profile link
    So that I can share the profile of the Mentor to others

@PBI16711
Scenario: Viewing mentor's profile by clicking or sharing its link
    Given that I am a user of mentor skid webpage
    When I click on Find a mentor button
    And I click on View profile button of any of the mentors
    And I click on the mentor's profile link
    Then I must be directed to the Mentor's profile page on another tab successfully