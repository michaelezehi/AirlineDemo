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
namespace Airline.Specs.FareCalculation
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FlightBookingService")]
    public partial class FlightBookingServiceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FlightBookingService.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FlightBookingService", @"In order to book a flight
I have to be a specific type of passenger the airline caters for
1. General – normal fare paying passengers 
2. Loyalty Members – repeat customers who get benefits for choosing to fly with the airline
3. Airline Employee – employees of the airline who fly with the airline on a free basis as a perk", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("The Airline charges a base price for a specific route for a standard passenger")]
        [NUnit.Framework.CategoryAttribute("test")]
        public virtual void TheAirlineChargesABasePriceForASpecificRouteForAStandardPassenger()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Airline charges a base price for a specific route for a standard passenger", new string[] {
                        "test"});
#line 9
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost",
                        "PlaneCapacity"});
            table1.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100",
                        "100"});
#line 10
testRunner.Given("flight details", ((string)(null)), table1, "Given ");
#line 13
testRunner.And("a passenger \'Tom\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.When("Tom books a flight with 1 baggage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
testRunner.Then("he does not get any discount on his fares", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A loyalty passenger gets a discount on their flights when they use their loyalty " +
            "points")]
        public virtual void ALoyaltyPassengerGetsADiscountOnTheirFlightsWhenTheyUseTheirLoyaltyPoints()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A loyalty passenger gets a discount on their flights when they use their loyalty " +
                    "points", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost",
                        "PlaneCapacity"});
            table2.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100",
                        "100"});
#line 19
testRunner.Given("flight details", ((string)(null)), table2, "Given ");
#line 22
testRunner.And("a passenger \'Suzy\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
testRunner.When("Suzy books a flight with 1 baggage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
testRunner.Then("he gets a discount on his flight fare (total cost is TicketBasePrice minus Loyalt" +
                    "yPoints)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A Loyalty member with two bagages and using their extra backage benefits")]
        public virtual void ALoyaltyMemberWithTwoBagagesAndUsingTheirExtraBackageBenefits()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A Loyalty member with two bagages and using their extra backage benefits", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost",
                        "PlaneCapacity"});
            table3.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100",
                        "100"});
#line 28
testRunner.Given("flight details", ((string)(null)), table3, "Given ");
#line 31
testRunner.And("a passenger \'Jone\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
testRunner.When("Jone books a flight with 2 baggage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
testRunner.Then("he does not gets charged extra baggage fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A General member with two baggage")]
        public virtual void AGeneralMemberWithTwoBaggage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A General member with two baggage", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost",
                        "PlaneCapacity"});
            table4.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100",
                        "100"});
#line 37
testRunner.Given("flight details", ((string)(null)), table4, "Given ");
#line 40
testRunner.And("a passenger \'Jack\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
testRunner.When("Jack books a flight with 2 baggage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
testRunner.Then("he  gets charged extra baggage fees", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An Airline employee with one baggage")]
        public virtual void AnAirlineEmployeeWithOneBaggage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An Airline employee with one baggage", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost",
                        "PlaneCapacity"});
            table5.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100",
                        "100"});
#line 45
testRunner.Given("flight details", ((string)(null)), table5, "Given ");
#line 48
testRunner.And("a passenger \'Trevor\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
testRunner.When("Trevor books a flight with 1 baggage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.Then("he  does not pay any fare", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A Loyalty member with more than 2 baggage")]
        public virtual void ALoyaltyMemberWithMoreThan2Baggage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A Loyalty member with more than 2 baggage", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost",
                        "PlaneCapacity"});
            table6.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100",
                        "100"});
#line 53
testRunner.Given("flight details", ((string)(null)), table6, "Given ");
#line 56
testRunner.And("a passenger \'Jone\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
testRunner.When("Jone books a flight with 3 baggage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
testRunner.Then("she  gets charged extra baggage fees excluding entitled allowance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("An Employee member with more than 3 baggage")]
        public virtual void AnEmployeeMemberWithMoreThan3Baggage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An Employee member with more than 3 baggage", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Origin",
                        "Destination",
                        "TicketBasePrice",
                        "PassengerCost",
                        "PlaneCapacity"});
            table7.AddRow(new string[] {
                        "London",
                        "Dublin",
                        "150",
                        "100",
                        "100"});
#line 61
testRunner.Given("flight details", ((string)(null)), table7, "Given ");
#line 64
testRunner.And("a passenger \'Trevor\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
testRunner.When("Trevor books a flight with 3 baggage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
testRunner.Then("he  does not get additional charges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion