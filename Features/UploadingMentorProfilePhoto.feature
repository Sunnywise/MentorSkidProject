#Feature: UploadingMentorProfilePhoto
#   As a registered mentor user of mentorskid webpage
#   I want to upload my picture
#   So that my picture can be displayed on my profile
#
#Background: 
#    Given that a user navigate on https://mentorskid.com/login/
#	When user enters username or email address "QATester1@testing.com"
#	And user enters login password "password1234"
#	And user clicks on submit button
#	Then the user registered page is displayed
#
#Scenario: Uploading of mentor's profile picture
#    When user clicks upload photo as a mentor
#	And user selects the desire photo to upload as a Mentor
#    And user clicks and drag the slider to crop mentor picture if necessary
#    And user clicks on save button to save the photo
#    Then mentor photo is successfully uploaded
