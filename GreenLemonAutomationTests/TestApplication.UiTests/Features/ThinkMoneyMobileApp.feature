Feature: ThinkMoney Mobile App

	In order to verify the new software changes
	As a test user 
	I want to ensure that the tests passes as expected

Background: 

	Given I navigate to the test site in my Mobile
	
			

@AppiumTests 
Scenario: Enter your Personal Details


When I enter Username, Password & Re-Type Password in App
And I click on Enter button
#When I press the Title 
When I enter the FirstName
And I enter the Sur Name 
And I enter the users Date of Birth 
And I enter my Telephone No
And I select Employment

Scenario: Check the Credit Score for the registered user

When I click on Login button
And I Login as the test user
Then I can see the user's credit score 

Scenario: Autochat test to Buy a House 

When I click on Login button
And I Login as the test user
And I click on Goals Icon
And I can autochat to Buy a House 
Then the autochat window opens 

#ChatFlow response
When I click on Not Yet for the question First, do you already own a property? 
Then I can see the Auto response as - Ok, and when you get your new property 

#Restart Plan button
When I click on Restart Plan 
Then the chat windows restarts 

#Scenario: Find offers 

#When I click on Login button
#And I Login as the test user
#And I click on Deals 
#Then I can see the Find offers for me Page
#When I click on Find offers for me 
#Then I can see my offers 


Scenario: Reports
#When I click on Login button
#And I Login as the test user
#And I click on Reports 
#Then I can see the Overview report 

#When I click on About You tab
#Then I can see my address and Current Address

#When I click on Accounts
#Then I can see my Credit cards, Current accounts and Loans 

#When I click on Corrections
#Then I can see the number of corrections

#When I click on Searches
#Then I can search for the Credit application searches



