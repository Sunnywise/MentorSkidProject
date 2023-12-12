Feature: PasswordReset
	As a registered user of www.mentorskid.com
   I want to be able to reset my password
   So that I can regain access to my account, if I forget my password

@mytag
Scenario: Resetting of password
 Given that I am on the password reset page
 When I enter my email address
 And click the Reset password Button
 And I click on the password reset link in my email
 #And I am directed to a page where I can enter a new password
 #And I enter my new password
 #And I re-enter my new password
 #And I click on the submit button
 #Then my password must be successfully reset 

