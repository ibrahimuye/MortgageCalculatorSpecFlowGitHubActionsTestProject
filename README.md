# MortgageCalculatorSpecFlowGitHubActionsTestProject
A demo with Seleneium, C#, Spec Flow on Mortgage Calculator

Here are test cases
Background: Navigate to the page
	When I navigate to the mortage calculator page
	Then I should confirm the page title is Mortgage Calculator | Finance of America Mortgage
	And Page header should be MORTGAGE CALCULATOR

@TestCaseNo:001
@smoke
Scenario: Fill the calculator fields with realistic data to reflect a real life scenario
	Given I am on the mortgage calculator page
	When I enter the home price as <Home Price>
	And I enter the down payment as <Down Payment>
	And I enter the interest rate as <Interest Rate>
	And I choose the loan program as <Loan Program>
	Then I should see the monthly payment as <Your Payment>
Examples: 
	| Home Price | Down Payment | Loan Program  | Interest Rate | Your Payment |
	| 385000     | 50000        | 30-year fixed | 2             | $1,813       |
	| 495000     | 100000       | 15-year fixed | 3             | $3,289       |
	| 255000     | 75000        | 5/1 ARM       | 2.5           | $1,522       |


@TestCaseNo:002
Scenario: Fill the calculator fields with unrealistic data - negative scenario
	Given I am on the mortgage calculator page
	When I enter the home price as <Home Price>
	And I enter the down payment as <Down Payment>
	And I enter the interest rate as <Interest Rate>
	And I choose the loan program as <Loan Program>
	Then I should see an error message of <Error>
Examples: 
	| Home Price | Down Payment | Loan Program  | Interest Rate | Error                                            |
	| 0          | 50000        | 30-year fixed | 2             | Please enter a positive number for Home Price    |
	| -250000    | 100000       | 15-year fixed | 3             | Please enter a positive number for Home Price    |
	| 255000     | -2000        | 5/1 ARM       | 2.5           | Please enter a positive number for Down Payment  |
	| 500000     | 50000        | 30-year fixed | -2            | Please enter a positive number for Interest Rate |


