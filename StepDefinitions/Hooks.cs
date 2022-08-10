﻿using SpecFlow_MortgageCalculator.Drivers;
using TechTalk.SpecFlow;

namespace SpecFlow_MortgageCalculator.StepDefinitions
{
    [Binding]
    public sealed class Hooks
    {
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.CloseDriver();
        }
    }
}