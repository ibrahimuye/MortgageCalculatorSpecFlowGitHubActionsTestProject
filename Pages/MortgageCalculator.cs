using SpecFlow_MortgageCalculator.Drivers;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace SpecFlow_MortgageCalculator.Pages
{
    public class MortgageCalculator
    {
        public string pageHeaderXpath = "//h1[@class='subpage-banner__title']";
        public string homePriceInputBoxXpath = "//input[@id='homePrice']";
        public string downPaymentInputBoxXpath = "//input[@id='downPayment']";
        public string programSelectionDropdownXpath = "//div[@class='jq-selectbox__select']";
        public string interstRateInputBoxXpath = "//input[@id='interestRate']";
        public string yourPaymentAmountXpath = "//span[@class='payment ng-binding']";
        public string selectedProgramXpath (string programOption) 
        {
            var xpath = $"//li[.='{programOption}']";
            return xpath;
        }

        public string errorTextXpath(string errorText)
        {
            var xpath = $"//*[.='{errorText}']";
            return xpath;
        }
    }
}
