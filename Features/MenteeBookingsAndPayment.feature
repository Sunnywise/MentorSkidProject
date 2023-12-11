Feature: MenteeBookingsAndPayment
	As a user of mentorskid.com
    I want to be able to make payments
    So that I can pay for mentoring sessions with my mentor
Background: 
    Given that a user navigate on https://mentorskid.com/login/
	When user enters username or email address "menteeTester@opentrash.com"
	And user enters login password "password1234"
	And user clicks on submit button
    Then user clicks on Find a Mentor from the Menu Bar
@PBI15804
Scenario: Valid Bookings and Payment
    Given user clicks the View Profile button for the Mentor of my choice
    When user clicks on the Book a session button
    And user completes the booking details fields to indicate my availability 
    And user clicks on the Show availability button
    And user clicks on an available slot of my choice 
    And user clicks on the Save & continue button
    And user clicks on the Save & continue button again
    And user clicks on the proceed to checkout button
    And user completes the billing details fields
    And user enters my test card details 
    And user clicks on the place order button
    Then user is directed to the "order received" confirmation page
Scenario: Invalid bookings
    Given user clicks on the View profile button of mentor without bookings
    When user clicks on the Book a session button
    And user completes the booking details fields to indicate my availability 
    And user clicks on the Show availability button
    Then an error message pops up as "Failed! no slot available"
    