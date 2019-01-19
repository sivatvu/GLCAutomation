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
    #When I select the Title 
    When I enter the following values into the Personal Details page "<FirstName>", "<SurName>", "<DateofBirth>", "<TelephoneNumber>" and "<GrossAnnualIncome>"
    #And I select Employment and Residential Status
    And I enter my address
	And the month and year I moved in
	And I click on Address Search
	And I add my address 
    And I have agreed with the Terms and Conditions
    And I Click on Enter on Personal Details Page
    #Then I can successfully enter my personal details
    #Credit Report Authentication
    When I click on YES to set up the credit report
	When I select the correct answers for the authentication questions 
    And I submit the answers by pressing the Enter button
#	And I login as the test admin
#   Then I am on Credit report homepage 
#   And I can see my Credit Score 
    Then I can verify the Credit Report authentication
    

Examples:

| FirstName  | SurName    | DateofBirth | TelephoneNumber | GrossAnnualIncome |
| CHELSEA | STEPHENS | 1960-02-19  | 01273006033     | 35000            |

Scenario: Login as  the test user

    When I login as the test user
    Then I can see the test user's credit score
    And I can see the offers 
    And I can see the ChatFlows 
#
Scenario: Find offers to the test users

    When I login as the test user
    And I click on Offers
    And I click on Find offers for me 
    Then I can see offers for the test user


Scenario: Automatic Chat Flows and chat workflow to Buy a car

    When I login as the test user 
    And I click on ChatFlows 
    Then I can see the Actions and Goals button
    When I click on Actions button 
    Then I am on Actions Page and I can see how to improve my credit score
    When I click on Goals Button
    Then I can see the chat flows like Buy a car, Get credit etc., 
    When I click on Buy a car Chat Flow
    Then I can see the chat window for Buy a car 
    When I click on Let's do it
    Then I receive an automation responce as Let's put a key in the ignition and get started
    When I click on the key symbol
    Then I can see my average running cost of a car





