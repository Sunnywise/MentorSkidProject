Feature: LandingPageBanner
	As a user of mentorskid website
    I want to see a banner on the landing page
    So that I can have a focal point for the first thing noticed on the website

@PBI11896
Scenario: To view the landing page
     
	Given that I am a user of "https://mentorskid.com/"
    When I click on the Start as a Mentee button
    Then I must be directed to the Registration Page
    When I click on the Join as a Mentor button
    Then I must be directed to the Registration Page again 
