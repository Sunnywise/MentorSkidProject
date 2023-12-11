Feature: UploadingMenteeProfilePhoto
   As a registered mentee' user of mentorskid webpage
   I want to upload my picture
   So that my picture can be displayed on my profile

Background: 
 Given that a user navigate on https://mentorskid.com/login/
	When user enters username or email address "menteeTester@opentrash.com"
	And user enters login password "password1234"
	And user clicks on submit button
	Then the user registered page is displayed
@PBI12374
Scenario: Uploading of mentee profile picture
    When I click upload photo as a mentee
	And I select the desire photo to upload "MenteeImage.jpeg"
    And I click and drag the slider to crop my image if necessary
    And I click on save button to save the photo
    Then the photo is successfully uploaded
