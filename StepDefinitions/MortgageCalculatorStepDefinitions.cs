using OpenQA.Selenium;
using SpecFlow_MortgageCalculator.Drivers;

namespace SpecFlow_MortgageCalculator.StepDefinitions
{
    [Binding]
    public class MortgageCalculatorStepDefinitions
    {
        public Pages.MortgageCalculator calculatorPage = new Pages.MortgageCalculator();

        public MortgageCalculatorStepDefinitions(Pages.MortgageCalculator calculatorPage)
        {
            this.calculatorPage = calculatorPage;
        }

        [When(@"I navigate to the mortage calculator page")]
        public void WhenINavigateToTheMortageCalculatorPage()
        {
            Driver.GetDriver().Url = "https://www.foamortgage.com/calculators/mortgage-calculator/";
            Driver.GetDriver().Manage().Window.Maximize();
            Driver.GetDriver().Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            Driver.GetDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Then(@"I should confirm the page title is (.*)")]
        public void ThenIShouldConfirmThePageTitleIsMortgageCalculatorFinanceOfAmericaMortgage(string expectedTitle)
        {
            var actualPageTitle = Driver.GetDriver().Title;
            Assert.True(actualPageTitle != null, "we could not land on Mortgage Calculator page or no title on the page");
            Assert.True(actualPageTitle.Equals(expectedTitle), $"page title is {actualPageTitle} which was expected as {expectedTitle}");
        }

        [Then(@"Page header should be (.*)")]
        public void ThenPageHeaderShouldBeMortgageCalculator(string expectedHeader)
        {
            var actualPageHeader = Driver.GetDriver().FindElement(By.XPath(calculatorPage.pageHeaderXpath)).Text;
            Assert.True(actualPageHeader != null, "we could not land on Mortgage Calculator page or no header on the page");
            Assert.True(actualPageHeader.Equals(expectedHeader), $"page header is {actualPageHeader} which was expected as {expectedHeader}");
        }

        [Given(@"I am on the mortgage calculator page")]
        public void GivenIAmOnTheMortgageCalculatorPage()
        {
            //just to state we are on the page to start an action, we could do some of the assertions doen in background here as well
        }

        [When(@"I enter the home price as (.*)")]
        public void WhenIEnterTheHomePriceAs(string homePrice)
        {
            Driver.GetDriver().FindElement(By.XPath(calculatorPage.homePriceInputBoxXpath)).Clear();
            Driver.GetDriver().FindElement(By.XPath(calculatorPage.homePriceInputBoxXpath)).SendKeys(homePrice);
        }
        [When(@"I enter the down payment as (.*)")]
        public void WhenIEnterTheDownPaymentAs(string downPayment)
        {
            Driver.GetDriver().FindElement(By.XPath(calculatorPage.downPaymentInputBoxXpath)).Clear();
            Driver.GetDriver().FindElement(By.XPath(calculatorPage.downPaymentInputBoxXpath)).SendKeys(downPayment);
        }
        [When(@"I enter the interest rate as (.*)")]
        public void WhenIEnterTheInterestRateAsInterestRate(string interestRate)
        {
            Driver.GetDriver().FindElement(By.XPath(calculatorPage.interstRateInputBoxXpath)).Clear();
            Driver.GetDriver().FindElement(By.XPath(calculatorPage.interstRateInputBoxXpath)).SendKeys(interestRate);
        }

        [When(@"I choose the loan program as (.*)")]
        public void WhenIChooseTheLoanProgramAs_YearFixed(string program)
        {
            Driver.GetDriver().FindElement(By.XPath(calculatorPage.programSelectionDropdownXpath)).Click();
            try
            {
                Driver.GetDriver().FindElement(By.XPath(calculatorPage.selectedProgramXpath(program))).Click();
            }
            catch (Exception)
            {                
                throw new Exception($"{program} is not a defined program on the dropdown menu");
            }          

        }

        [Then(@"I should see the monthly payment as (.*)")]
        public void ThenIShouldSeeTheMonthlyPaymentAs(string expectedPaymentAmount)
        {
            var actualPaymentAmount = Driver.GetDriver().FindElement(By.XPath(calculatorPage.yourPaymentAmountXpath)).Text;
            Assert.True(actualPaymentAmount.Equals(expectedPaymentAmount), $"payment amount is {actualPaymentAmount} which was expected as {expectedPaymentAmount}");
        }

        [Then(@"I should see an error message of (.*)")]
        public void ThenIShouldSeeAnErrorMessageOfPleaseEnterAPositiveNumberForHomePrice(string errorText)
        {
            try
            {
                var isErrorTextDisplayed = Driver.GetDriver().FindElement(By.XPath(calculatorPage.errorTextXpath(errorText))).Displayed;
            }
            catch (Exception)
            {
                Assert.True(false, $"'{errorText}' error message should be displayed on the page but not");                
            }                      
        }
    }
}