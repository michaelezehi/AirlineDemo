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
                        "Mark",
                        "35",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table2.AddRow(new string[] {
                        "Tom",
                        "15",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table2.AddRow(new string[] {
                        "James",
                        "72",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table2.AddRow(new string[] {
                        "Trevor",
                        "54",
                        "Employee",
                        "0",
                        "1",
                        "false",
                        "false"});
            table2.AddRow(new string[] {
                        "Alan",
                        "65",
                        "Loyalty",
                        "50",
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
#line 28
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
                        "Mark",
                        "35",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Tom",
                        "15",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "James",
                        "72",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Trevor",
                        "54",
                        "Employee",
                        "0",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Alan",
                        "65",
                        "Loyalty",
                        "50",
                        "1",
                        "false",
                        "false"});
            table5.AddRow(new string[] {
                        "Suzy",
                        "21",
                        "Loyalty",
                        "40",
                        "2",
                        "false",
                        "true"});
            table5.AddRow(new string[] {
                        "Jone",
                        "56",
                        "Loyalty",
                        "100",
                        "1",
                        "true",
                        "false"});
#line 31
testRunner.And("passengers  with details", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "NumberOfSeats"});
            table6.AddRow(new string[] {
                        "Gulfstream-G550",
                        "8"});
#line 40
testRunner.And("airplane details", ((string)(null)), table6, "And ");
#line 44
testRunner.When("all booking is complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
testRunner.Then("the airline can depart to it\'s destination", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An airplane with expected capacity and total adjusted revenue")]
        public virtual void AnAirplaneWithExpectedCapacityAndTotalAdjustedRevenue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An airplane with expected capacity and total adjusted revenue", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost"});
            table7.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100"});
#line 49
testRunner.Given("flight with details", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Age",
                        "PassengerType",
                        "LoyaltyPoints",
                        "Baggage",
                        "IsUsingLoyaltyPoint",
                        "IsUsingExtraBaggageAllowance"});
            table8.AddRow(new string[] {
                        "Mark",
                        "35",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table8.AddRow(new string[] {
                        "Tom",
                        "15",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table8.AddRow(new string[] {
                        "James",
                        "72",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table8.AddRow(new string[] {
                        "Trevor",
                        "54",
                        "Employee",
                        "0",
                        "1",
                        "false",
                        "false"});
            table8.AddRow(new string[] {
                        "Alan",
                        "65",
                        "Loyalty",
                        "50",
                        "1",
                        "false",
                        "false"});
            table8.AddRow(new string[] {
                        "Suzy",
                        "21",
                        "Loyalty",
                        "40",
                        "2",
                        "false",
                        "true"});
            table8.AddRow(new string[] {
                        "Jone",
                        "56",
                        "Loyalty",
                        "100",
                        "1",
                        "true",
                        "false"});
            table8.AddRow(new string[] {
                        "Jack",
                        "50",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
#line 52
testRunner.And("passengers  with details", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "NumberOfSeats"});
            table9.AddRow(new string[] {
                        "Gulfstream-G550",
                        "8"});
#line 62
testRunner.And("airplane details", ((string)(null)), table9, "And ");
#line 66
testRunner.When("all booking is complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
testRunner.Then("the airline expected revenue should be 950", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An airplane with expected capacity (8) adjusted revenue should exceed the total c" +
            "ost of the flight")]
        public virtual void AnAirplaneWithExpectedCapacity8AdjustedRevenueShouldExceedTheTotalCostOfTheFlight()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An airplane with expected capacity (8) adjusted revenue should exceed the total c" +
                    "ost of the flight", ((string[])(null)));
#line 71
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost"});
            table10.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100"});
#line 72
testRunner.Given("flight with details", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Age",
                        "PassengerType",
                        "LoyaltyPoints",
                        "Baggage",
                        "IsUsingLoyaltyPoint",
                        "IsUsingExtraBaggageAllowance"});
            table11.AddRow(new string[] {
                        "Mark",
                        "35",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table11.AddRow(new string[] {
                        "Tom",
                        "15",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table11.AddRow(new string[] {
                        "James",
                        "72",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table11.AddRow(new string[] {
                        "Trevor",
                        "54",
                        "Employee",
                        "0",
                        "1",
                        "false",
                        "false"});
            table11.AddRow(new string[] {
                        "Alan",
                        "65",
                        "Loyalty",
                        "50",
                        "1",
                        "false",
                        "false"});
            table11.AddRow(new string[] {
                        "Suzy",
                        "21",
                        "Loyalty",
                        "40",
                        "2",
                        "false",
                        "true"});
            table11.AddRow(new string[] {
                        "Jone",
                        "56",
                        "Loyalty",
                        "100",
                        "1",
                        "true",
                        "false"});
            table11.AddRow(new string[] {
                        "Jack",
                        "50",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
#line 75
testRunner.And("passengers  with details", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "NumberOfSeats"});
            table12.AddRow(new string[] {
                        "Gulfstream-G550",
                        "8"});
#line 85
testRunner.And("airplane details", ((string)(null)), table12, "And ");
#line 89
testRunner.When("all booking is complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
testRunner.Then("the adjusted revenue should exceed airline total cost of 800", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An additional passenger Joe tries to book after the plane capacity is reached")]
        public virtual void AnAdditionalPassengerJoeTriesToBookAfterThePlaneCapacityIsReached()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An additional passenger Joe tries to book after the plane capacity is reached", ((string[])(null)));
#line 93
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost"});
            table13.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100"});
#line 94
testRunner.Given("flight with details", ((string)(null)), table13, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "Age",
                        "PassengerType",
                        "LoyaltyPoints",
                        "Baggage",
                        "IsUsingLoyaltyPoint",
                        "IsUsingExtraBaggageAllowance"});
            table14.AddRow(new string[] {
                        "Mark",
                        "35",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table14.AddRow(new string[] {
                        "Tom",
                        "15",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table14.AddRow(new string[] {
                        "James",
                        "72",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table14.AddRow(new string[] {
                        "Trevor",
                        "54",
                        "Employee",
                        "0",
                        "1",
                        "false",
                        "false"});
            table14.AddRow(new string[] {
                        "Alan",
                        "65",
                        "Loyalty",
                        "50",
                        "1",
                        "false",
                        "false"});
            table14.AddRow(new string[] {
                        "Suzy",
                        "21",
                        "Loyalty",
                        "40",
                        "2",
                        "false",
                        "true"});
            table14.AddRow(new string[] {
                        "Jone",
                        "56",
                        "Loyalty",
                        "100",
                        "1",
                        "true",
                        "false"});
            table14.AddRow(new string[] {
                        "Jack",
                        "50",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
            table14.AddRow(new string[] {
                        "Joe",
                        "18",
                        "General",
                        "0",
                        "1",
                        "false",
                        "false"});
#line 97
testRunner.And("passengers  with details", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "NumberOfSeats"});
            table15.AddRow(new string[] {
                        "Gulfstream-G550",
                        "8"});
#line 108
testRunner.And("airplane details", ((string)(null)), table15, "And ");
#line 112
testRunner.When("all booking is complete", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
testRunner.Then("\'Joe\' is denied access to the flight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
testRunner.And("8 passengers should have access to the flight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
