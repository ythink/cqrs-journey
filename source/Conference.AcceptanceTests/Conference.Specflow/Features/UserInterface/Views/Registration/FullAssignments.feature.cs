﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.UserInterface.Views.Registration
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegistrantWorkflowForAssigningAllThePurchasedOrderItems_Feature : Xunit.IUseFixture<RegistrantWorkflowForAssigningAllThePurchasedOrderItems_Feature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FullAssignments.feature"
#line hidden
        
        public RegistrantWorkflowForAssigningAllThePurchasedOrderItems_Feature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registrant workflow for assigning all the purchased Order Items.", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 16
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "100"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "100"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "100"});
#line 17
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
        }
        
        public virtual void SetFixture(RegistrantWorkflowForAssigningAllThePurchasedOrderItems_Feature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for assigning all the purchased Order Items.")]
        [Xunit.TraitAttribute("Description", "Allocate all purchased Seats for an individual")]
        public virtual void AllocateAllPurchasedSeatsForAnIndividual()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allocate all purchased Seats for an individual", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 16
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 25
 testRunner.Given("the selected Order Items", ((string)(null)), table2);
#line 29
 testRunner.And("the Registrant proceeds to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table3.AddRow(new string[] {
                        "William",
                        "Flash",
                        "william@fabrikam.com"});
#line 30
 testRunner.And("the Registrant enters these details", ((string)(null)), table3);
#line 33
 testRunner.And("the Registrant proceeds to Checkout:Payment");
#line 34
 testRunner.And("the Registrant proceeds to confirm the payment");
#line 35
    testRunner.And("the Registration process was successful");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table4.AddRow(new string[] {
                        "General admission",
                        "1"});
            table4.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 36
 testRunner.And("the Order should be created with the following Order Items", ((string)(null)), table4);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "first name",
                        "last name",
                        "email address"});
            table5.AddRow(new string[] {
                        "General admission",
                        "William",
                        "Flash",
                        "william@fabrikam.com"});
            table5.AddRow(new string[] {
                        "Additional cocktail party",
                        "Jim",
                        "Corbin",
                        "jim@litwareinc.com"});
#line 40
 testRunner.When("the Registrant assigns these seats", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table6.AddRow(new string[] {
                        "General admission",
                        "1"});
            table6.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 44
 testRunner.Then("these seats are assigned", ((string)(null)), table6);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for assigning all the purchased Order Items.")]
        [Xunit.TraitAttribute("Description", "Allocate all purchased Seats for a group")]
        public virtual void AllocateAllPurchasedSeatsForAGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allocate all purchased Seats for a group", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line 16
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table7.AddRow(new string[] {
                        "General admission",
                        "4"});
            table7.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 51
 testRunner.Given("the selected Order Items", ((string)(null)), table7);
#line 55
 testRunner.And("the Registrant proceeds to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "first name",
                        "last name",
                        "email address"});
            table8.AddRow(new string[] {
                        "William",
                        "Flash",
                        "william@fabrikam.com"});
#line 56
 testRunner.And("the Registrant enters these details", ((string)(null)), table8);
#line 59
 testRunner.And("the Registrant proceeds to Checkout:Payment");
#line 60
 testRunner.And("the Registrant proceeds to confirm the payment");
#line 61
    testRunner.And("the Registration process was successful");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table9.AddRow(new string[] {
                        "General admission",
                        "4"});
            table9.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 62
 testRunner.And("the Order should be created with the following Order Items", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "first name",
                        "last name",
                        "email address"});
            table10.AddRow(new string[] {
                        "General admission",
                        "William",
                        "Flash",
                        "william@fabrikam.com"});
            table10.AddRow(new string[] {
                        "General admission",
                        "Jim",
                        "Corbin",
                        "jim@litwareinc.com"});
            table10.AddRow(new string[] {
                        "General admission",
                        "Karen",
                        "Berg",
                        "karen@alpineskihouse.com"});
            table10.AddRow(new string[] {
                        "General admission",
                        "Ryan",
                        "Ihrig",
                        "ryan@cohowinery.com"});
            table10.AddRow(new string[] {
                        "Additional cocktail party",
                        "Antonio",
                        "Alwan",
                        "antonio@adatim.com"});
            table10.AddRow(new string[] {
                        "Additional cocktail party",
                        "Jon",
                        "Jaffe",
                        "jon@fabrika.com"});
#line 66
 testRunner.When("the Registrant assigns these seats", ((string)(null)), table10);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table11.AddRow(new string[] {
                        "General admission",
                        "4"});
            table11.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 74
 testRunner.Then("these seats are assigned", ((string)(null)), table11);
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegistrantWorkflowForAssigningAllThePurchasedOrderItems_Feature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegistrantWorkflowForAssigningAllThePurchasedOrderItems_Feature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
