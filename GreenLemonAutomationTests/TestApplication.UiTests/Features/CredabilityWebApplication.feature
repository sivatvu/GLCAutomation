Feature: Credability Feature file - Web Application 

	In order to verify the new software changes
	As a test user 
	I want to ensure that the tests passes as expected

Background: 

	Given I navigate to the test site

Scenario Outline: Sign-in and verify the credit score

	When I click on Login button on the Web app
	Then I am on Login page
	When I enter the "<email>" and "<password>"
	Then I click on Login button
	Then I can verify the Credit score

Examples:

	| email					 | password   | 
	| Ignacio32@email.com    | Pa55w0rd!  | 

@Tests @PersonalDetails @Register
Scenario Outline: Account Registration and Postcode only Address Search

	When I click on Sign up button
	Then I am on Create Account page
	When I enter Username, Password & Re-Type Password
	And I click on Enter
	Then I can enter my personal details
	When I select the Title
	When I enter the following values into the Personal Details page "<FirstName>", "<SurName>", "<DateofBirth>", "<TelephoneNumber>" and "<GrossAnnualIncome>"
	And I select Employment and Residential Status
	And I enter my address (only postcode)
	And I click on Address Search
	Then I can verify the list of addresses in the specified postcode.
	And I can select the specific address

Examples:

	| FirstName  | SurName    | DateofBirth | TelephoneNumber | GrossAnnualIncome |
	| MARIE		 | RICHARDSON | 17/02/1960  | 07411577889     | 19000             |

Scenario Outline: Account Registration and edit the address

	When I click on Sign up button
	Then I am on Create Account page
	When I enter Username, Password & Re-Type Password
	And I click on Enter
	Then I can enter my personal details
	When I select the Title
	When I enter the following values into the Personal Details page "<FirstName>", "<SurName>", "<DateofBirth>", "<TelephoneNumber>" and "<GrossAnnualIncome>"
	And I select Employment and Residential Status
	And I enter my address
	And I click on Address Search
	Then I can verify the list of addresses in the specified postcode.
	And I can select the specific address
	And I click on "edit link" to edit the address
	And I enter the postcode and house number 
	And I can select the specific address

Examples:

	| FirstName  | SurName    | DateofBirth | TelephoneNumber | GrossAnnualIncome |
	| MARIE		 | RICHARDSON | 17/02/1960  | 07411577889     | 19000             |

Scenario: Account Registration with multiple address selection (by specifying the postcode and house number) to display credit score in dashboard

	When I Enter Title , First Name , Surname , Date of birth , Mobile number.
	And I Enter Employment Status , Gross annual income 
	And Enter "House/Flat number" and "postcode" . click on Find My address button.
	Then the address should be picked up when it is a single one and filled in.
	When i enter the date when moved-in with year = "2019" and "month" = january
	Then I will be prompted with message to enter more address.
	And I enter the House/Flat number and postcode , click "Find My Address" to see the address automatically being selected.
	And I enter the date when moved in to 2001 january.
	And I select the preferences Email , SMS and Call
	And I select "terms and conditions" check-box
	And Click the Next button.
	Then I will be shown the KBA Page

Scenario Outline: Account Registration and display the KBA 2nd Stage Questions Page
 
	When I click on Sign up button
	Then I am on Create Account page
	When I enter Username, Password & Re-Type Password
	And I click on Enter
	Then I can enter my personal details
	When I select the Title
	When I enter the following values into the Personal Details page "<FirstName>", "<SurName>", "<DateofBirth>", "<TelephoneNumber>" and "<GrossAnnualIncome>"
	And I select Employment and Residential Status
	And I enter my address
	And I click on Address Search
	And the month and year I moved in
	And I select the specific address
	And I add my address
	And I have agreed with the Terms and Conditions
	And I Click on Enter on Personal Details Page
	And I submit only 2 correct answers (less than 65%) by pressing the Enter button
	Then I will be shown the 2nd stage of KBA questions.

Examples:

	| FirstName  | SurName    | DateofBirth | TelephoneNumber | GrossAnnualIncome |
	| MARIE		 | RICHARDSON | 17/02/1960  | 07411577889     | 19000             |

Scenario Outline: Account Registration and display Activate your report in 3 days in Dashboard
 
	When I click on Sign up button
	Then I am on Create Account page
	When I enter Username, Password & Re-Type Password
	And I click on Enter
	Then I can enter my personal details
	When I select the Title
	When I enter the following values into the Personal Details page "<FirstName>", "<SurName>", "<DateofBirth>", "<TelephoneNumber>" and "<GrossAnnualIncome>"
	And I select Employment and Residential Status
	And I enter my address
	And I click on Address Search
	And the month and year I moved in
	And I select the specific address
	And I add my address
	And I have agreed with the Terms and Conditions
	And I Click on Enter on Personal Details Page
	And I submit wrong answers in KBA page
	Then I will be shown the screen with the message "oops - too many details didn't match".
	And when i click the "continue" button
	Then I can verify the message in Dashboard stating "Activate your report in 3 days"

Examples:

	| FirstName  | SurName    | DateofBirth | TelephoneNumber | GrossAnnualIncome |
	| MARIE		 | RICHARDSON | 17/02/1960  | 07411577889     | 19000             |

Scenario Outline: Account Login for Failed KBA (once) and Trigger KBA again after 3 days.
 
	When I click on Login button
	Then I am on Login page
	When I enter <Email> and <pwd>
	And I click on Login
	Then I can verify the message in Dashboard stating "Activate report"
	When I click on the "activate report" in dashboard
	Then I can verify the screen with KBA questions.

Examples:

	| email					 | password   | 
	| Ignacio32@email.com    | Pa55w0rd!  | 

Scenario Outline: Account Login for Failed KBA and display hard stop message after 3 attempts

	When I click on Login button
	Then I am on Login page
	When I enter <Email> and <pwd>
	And I click on Login
	Then I can verify the message in Dashboard stating "Activate report" 
	When I click on the "activate report" in dashboard
	Then I can verify the screen with KBA questions
	And I answer the KBA questions with wrong answers
	Then I can verify the message

Examples:

	| email					 | password   | 
	| Ignacio32@email.com    | Pa55w0rd!  | 
Scenario: Loan Offers - Happy Path with <=1000

   When User clicks "Get Loans" button under Deals.
   When Enters the Loan amount "less than 1000" and duration and clicks Next button.
   And  Enters reason for loan, monthly rent/mortgage payment and click "Get my loans" buttons.
   Then Displays the Loan offers.

Scenario: Loan Offers - Happy Path with greater amount (15000)

	When I  Enter amount > 1000
	And  Enter reason for loan, marital status, and dependents and click "Next button".
	And Enter the salary details etc and click next.
	And Enter the expenditure details.
	And Click "Get my loans" buttons.