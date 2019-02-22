Feature: ThinkMoney

	In order to verify the new software changes
	As a test user 
	I want to ensure that the tests passes as expected

Background: 

	Given I navigate to the test site
	

@Tests @PersonalDetails @Register
Scenario Outline: Account Registration and Verify the Credit Score

    Then I am on Create Account page
	When I enter Username, Password & Re-Type Password
	And I click on Enter
	Then I can enter my personal details
    When I select the Title 
    When I enter the following values into the Personal Details page "<FirstName>", "<SurName>", "<DateofBirth>", "<TelephoneNumber>" and "<GrossAnnualIncome>"
    And I select Employment and Residential Status
	#testcommit
    And I enter my address
	And the month and year I moved in
	And I click on Address Search
	And I add my address 
    And I have agreed with the Terms and Conditions
    And I Click on Enter on Personal Details Page
 #   Then I can successfully enter my personal details
 #   #Credit Report Authentication
 #   When I click on YES to set up the credit report
	#And I select the correct answers for the authentication questions 
    And I submit the answers by pressing the Enter button
    Then I can verify the Credit Report authentication
    

  Examples:

| FirstName  | SurName    | DateofBirth | TelephoneNumber | GrossAnnualIncome |
| CHELSEA | STEPHENS | 19/02/1960  | 01273006033     | 35000            |


Scenario: Reports
    When I login as the test user on Web App
    And I click on Reports on Web App 
    Then I can see the Overview report on Web App
#About Tab
    When I click on About You tab on Web App
    Then I can see my address and Current Address on Web App
#Accounts Tab
    When I click on Accounts on Web App
    Then I can see my Credit cards, Current accounts and Loans on Web App
#Corrections Tab
    When I click on Corrections on Web App
    Then I can see the number of corrections on Web App
#Searches Tab
    When I click on Searches on Web App
    Then I can search for the Credit application searches on Web App


Scenario: Decision tree to Buy a car

    When I login as the test user on Web App 
    And I click on ChatFlows 
    Then I can see the Actions and Goals button
    When I click on Actions button 
    Then I am on Actions Page and I can see how to improve my credit score
    When I click on Goals Button
    Then I can see the chat flows like Buy a car, Get credit etc., 
	When I click on Buy a car Chat Flow
	And I click on Reset Plan
	Then I the decision tree chatflows has been restarted 
    When I click on Buy a car Chat Flow
    Then I can see the chat window for Buy a car 
    When I click on Let's do it
    Then I receive an automation responce as Let's put a key in the ignition and get started
    When I click on the key symbol
    Then I can see my average running cost of a car
	


Scenario: Find Deals to the test users

    When I login as the test user on Web App
    And I click on Deals on Web App
	And I select the Purpose of the loan
    And I click on Find offers for me 
    Then I can see offers for the test user
	When I click on Go to borrow the money 
	Then the page navigates to the loans website



