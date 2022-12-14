// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow_MortgageCalculator.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "calculator")]
    public partial class MortgageCalculatorFeature : object, Xunit.IClassFixture<MortgageCalculatorFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "calculator"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "MortgageCalculator.feature"
#line hidden
        
        public MortgageCalculatorFeature(MortgageCalculatorFeature.FixtureData fixtureData, SpecFlow_MortgageCalculator_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Mortgage Calculator", "As a user I should be able to land on the mortgage calculator page and calculate " +
                    "monthly payment amount", ProgrammingLanguage.CSharp, new string[] {
                        "calculator"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line hidden
#line 7
 testRunner.When("I navigate to the mortage calculator page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then("I should confirm the page title is Mortgage Calculator | Finance of America Mortg" +
                    "age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 9
 testRunner.And("Page header should be MORTGAGE CALCULATOR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Fill the calculator fields with realistic data to reflect a real life scenario")]
        [Xunit.TraitAttribute("FeatureTitle", "Mortgage Calculator")]
        [Xunit.TraitAttribute("Description", "Fill the calculator fields with realistic data to reflect a real life scenario")]
        [Xunit.TraitAttribute("Category", "TestCaseNo:001")]
        [Xunit.TraitAttribute("Category", "smoke")]
        [Xunit.InlineDataAttribute("385000", "50000", "30-year fixed", "2", "$1,813", new string[0])]
        [Xunit.InlineDataAttribute("495000", "100000", "15-year fixed", "3", "$3,289", new string[0])]
        [Xunit.InlineDataAttribute("255000", "75000", "5/1 ARM", "2.5", "$1,522", new string[0])]
        public virtual void FillTheCalculatorFieldsWithRealisticDataToReflectARealLifeScenario(string homePrice, string downPayment, string loanProgram, string interestRate, string yourPayment, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TestCaseNo:001",
                    "smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Home Price", homePrice);
            argumentsOfScenario.Add("Down Payment", downPayment);
            argumentsOfScenario.Add("Loan Program", loanProgram);
            argumentsOfScenario.Add("Interest Rate", interestRate);
            argumentsOfScenario.Add("Your Payment", yourPayment);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fill the calculator fields with realistic data to reflect a real life scenario", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 14
 testRunner.Given("I am on the mortgage calculator page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
 testRunner.When(string.Format("I enter the home price as {0}", homePrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.And(string.Format("I enter the down payment as {0}", downPayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And(string.Format("I enter the interest rate as {0}", interestRate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And(string.Format("I choose the loan program as {0}", loanProgram), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.Then(string.Format("I should see the monthly payment as {0}", yourPayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Fill the calculator fields with unrealistic data - negative scenario")]
        [Xunit.TraitAttribute("FeatureTitle", "Mortgage Calculator")]
        [Xunit.TraitAttribute("Description", "Fill the calculator fields with unrealistic data - negative scenario")]
        [Xunit.TraitAttribute("Category", "TestCaseNo:002")]
        [Xunit.InlineDataAttribute("0", "50000", "30-year fixed", "2", "Please enter a positive number for Home Price", new string[0])]
        [Xunit.InlineDataAttribute("-250000", "100000", "15-year fixed", "3", "Please enter a positive number for Home Price", new string[0])]
        [Xunit.InlineDataAttribute("255000", "-2000", "5/1 ARM", "2.5", "Please enter a positive number for Down Payment", new string[0])]
        [Xunit.InlineDataAttribute("500000", "50000", "30-year fixed", "-2", "Please enter a positive number for Interest Rate", new string[0])]
        public virtual void FillTheCalculatorFieldsWithUnrealisticData_NegativeScenario(string homePrice, string downPayment, string loanProgram, string interestRate, string error, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TestCaseNo:002"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Home Price", homePrice);
            argumentsOfScenario.Add("Down Payment", downPayment);
            argumentsOfScenario.Add("Loan Program", loanProgram);
            argumentsOfScenario.Add("Interest Rate", interestRate);
            argumentsOfScenario.Add("Error", error);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fill the calculator fields with unrealistic data - negative scenario", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
this.FeatureBackground();
#line hidden
#line 29
 testRunner.Given("I am on the mortgage calculator page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 30
 testRunner.When(string.Format("I enter the home price as {0}", homePrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.And(string.Format("I enter the down payment as {0}", downPayment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(string.Format("I enter the interest rate as {0}", interestRate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And(string.Format("I choose the loan program as {0}", loanProgram), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then(string.Format("I should see an error message of {0}", error), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                MortgageCalculatorFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                MortgageCalculatorFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
