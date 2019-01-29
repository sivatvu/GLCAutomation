Feature: ThinkMoney iOS Mobile Testing

	In order to verify the new software changes
	As a test user 
	I want to ensure that the tests passes as expected

Background: 

	Given I navigate to the test site on my iOS Mobile

	@iOSTest
Scenario: Enter your Personal Details to Sign up
      
	  When I Click on Sign up button on iOS

Scenario: Check the Credit Score for the registered user in iOS 

When I click on Login button on iOS
And I Login as the iOS test user
Then I can see the iOS user's credit score 

Scenario: Autochat test to Buy a House on iOS Device

When I click on Login button on iOS
And I Login as the iOS test user
And I click on Goals Icon on iOS
And I can autochat to Buy a House on iOS
Then the autochat window opens on iOS
##ChatFlow response
#When I click on Not Yet for the question First, do you already own a property? 
#Then I can see the Auto response as - Ok, and when you get your new property 
##Restart Plan button
#When I click on Restart Plan 
#Then the chat windows restarts 

Scenario: Find offers 

When I click on Login button
And I Login as the test user
And I click on Deals 
Then I can see the Find offers for me Page
When I click on Find offers for me Button
Then I can see my offers 


Scenario: Reports
When I click on Login button
And I Login as the test user
And I click on Reports 
Then I can see the Overview report 
#About Tab
When I click on About You tab
Then I can see my address and Current Address
#Accounts Tab
When I click on Accounts
Then I can see my Credit cards, Current accounts and Loans 
#Corrections Tab
When I click on Corrections
Then I can see the number of corrections
#Searches Tab
When I click on Searches
Then I can search for the Credit application searches
	





