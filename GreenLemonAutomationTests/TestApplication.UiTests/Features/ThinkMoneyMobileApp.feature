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
And I can see the test user's credit score 

