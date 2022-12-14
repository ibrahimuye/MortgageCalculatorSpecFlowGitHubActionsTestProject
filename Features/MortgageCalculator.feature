@calculator
@regression
Feature: Mortgage Calculator
As a user I should be able to land on the mortgage calculator page and calculate monthly payment amount


Background: Navigate to the page
	When I navigate to the mortage calculator page
	Then I should confirm the page title is Mortgage Calculator | Finance of America Mortgage
	And Page header should be MORTGAGE CALCULATOR

@TestCaseNo:001
@smoke
@US:15684
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
@US:15685
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



# Notes
# we use tags for grouping scenarios, we may assume each sceanrio as an independent test case
# feature is the folder containing similar scenarios
# if there is a tag on the feature header, this tag applies all scenarios in the feature
# using tags we can run some specific scenarios locally or on the pipeline e.g. regression, smoke
# Background steps run before each scenario
# the codes run in the following order - before feature - before scenario - background steps - scenario steps - after scenario - after feature 
# Scenario may have an Examples table, this scenario runs for each line of the table using provided data mentioned in the step "<tableHeader>"
# a step starting with Given means something is completed in the previous steps and we can assert this in the binded code
# a step starting with When requires and action in the binded code
# a step starting with Then is usually the last line of the scnenario for asserting the expected sitiaution, there might be many Then steps
# a step starting with And depends on the previos step, if previous step starts with "When",  "And" means "When", if previos step starts with "Then", "And" means "Then"
