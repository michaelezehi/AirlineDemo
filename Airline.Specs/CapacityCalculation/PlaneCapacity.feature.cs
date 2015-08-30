﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Airline.Specs.CapacityCalculation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PlaneCapacity")]
    public partial class PlaneCapacityFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PlaneCapacity.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PlaneCapacity", "In order to avoid silly mistakes\r\nAs a math idiot\r\nI want to be told the sum of t" +
                    "wo numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An airplane with less than expected capacity (Min capacity 75%)")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void AnAirplaneWithLessThanExpectedCapacityMinCapacity75()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An airplane with less than expected capacity (Min capacity 75%)", new string[] {
                        "test"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost"});
            table1.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100"});
#line 8
testRunner.Given("flight with details", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Age",
                        "PassengerType",
                        "LoyaltyPoints",
                        "Baggage",
                        "IsUsingLoyaltyPoint",
                        "IsUsingExtraBaggageAllowance"});
            table2.AddRow(new string[] {
                        "James",
                        "44",
                        "Employee",
                        "0",
                        "1",
                        "false",
                        "false"});
            table2.AddRow(new string[] {
                        "Amori",
                        "51",
                        "Loyalty",
                        "0",
                        "1",
                        "false",
                        "false"});
            table2.AddRow(new string[] {
                        "Cindy",
                        "12",
                        "Loyalty",
                        "0",
                        "1",
                        "false",
                        "false"});
            table2.AddRow(new string[] {
                        "Amina",
                        "8",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table2.AddRow(new string[] {
                        "Lemar",
                        "39",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
#line 11
testRunner.And("passengers  with details", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "NumberOfSeats"});
            table3.AddRow(new string[] {
                        "Gulfstream-G550",
                        "8"});
#line 19
testRunner.And("airplane details", ((string)(null)), table3, "And ");
#line 23
testRunner.When("all booking is complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.Then("the airline cannot depart because of insufficient capacity", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An airplane with expected capacity (Min capacity 75%)")]
        public virtual void AnAirplaneWithExpectedCapacityMinCapacity75()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An airplane with expected capacity (Min capacity 75%)", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost"});
            table4.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100"});
#line 29
testRunner.Given("flight with details", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Age",
                        "PassengerType",
                        "LoyaltyPoints",
                        "Baggage",
                        "IsUsingLoyaltyPoint",
                        "IsUsingExtraBaggageAllowance"});
            table5.AddRow(new string[] {
                        "James",
                        "44",
                        "Employee",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Amori",
                        "51",
                        "Loyalty",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Cindy",
                        "12",
                        "Loyalty",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Amina",
                        "8",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Lemar",
                        "39",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "George",
                        "18",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Jude",
                        "78",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
#line 32
testRunner.And("passengers  with details", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "NumberOfSeats"});
            table6.AddRow(new string[] {
                        "Gulfstream-G550",
                        "8"});
#line 41
testRunner.And("airplane details", ((string)(null)), table6, "And ");
#line 45
testRunner.When("all booking is complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
testRunner.Then("the airline can depart to it\'s destination", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
