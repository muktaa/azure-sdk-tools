﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18051
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Microsoft.WindowsAzure.Management.HDInsight.Cmdlet.Tests.GherkinTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Remove-AzureHDInsightCluster Cmdlet")]
    [NUnit.Framework.CategoryAttribute("CheckIn")]
    public partial class Remove_AzureHDInsightClusterCmdletFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Remove-AzureHDInsightClusterCmdlet.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Remove-AzureHDInsightCluster Cmdlet", " In order to manage my HDInsight clusters on my Azure subscription\n As an IT prof" +
                    "essional\n  I want to be able to execute a PowerShell command that removes an HDI" +
                    "nsight clusters", ProgrammingLanguage.CSharp, new string[] {
                        "CheckIn"});
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
     testRunner.Given("I have installed the AzureHDInsight Cmdlets", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
       testRunner.When("I am using the \"Remove-AzureHDInsightCluster\" PowerShell Cmdlet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("There Exists a Remove-AzureHDInsightCluster PowerShell Cmdlet")]
        public virtual void ThereExistsARemove_AzureHDInsightClusterPowerShellCmdlet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("There Exists a Remove-AzureHDInsightCluster PowerShell Cmdlet", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 12
  testRunner.Then("There exists a \"Remove-AzureHDInsightCluster\" PowerShell Cmdlet", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("There is only 1 ParameterSet specified for the Get-AzureHDInsightCluster PowerShe" +
            "ll Cmdlet")]
        public virtual void ThereIsOnly1ParameterSetSpecifiedForTheGet_AzureHDInsightClusterPowerShellCmdlet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("There is only 1 ParameterSet specified for the Get-AzureHDInsightCluster PowerShe" +
                    "ll Cmdlet", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 15
  testRunner.Then("there exists a \"Cluster By Name (with Specific Subscription Credential)\" paramete" +
                    "r set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
   testRunner.And("there exists no further parameter sets", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No parameter set has two parameters in the same location")]
        [NUnit.Framework.TestCaseAttribute("Cluster By Name (with Specific Subscription Credential)", null)]
        public virtual void NoParameterSetHasTwoParametersInTheSameLocation(string parameterSetName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No parameter set has two parameters in the same location", exampleTags);
#line 18
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 19
   testRunner.And(string.Format("I am using the \"{0}\" parameter set", parameterSetName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
  testRunner.Then("no parameter in the set shares the same position with another parameter from the " +
                    "set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No parameter set has two parameters that accept their value from the pipeline")]
        [NUnit.Framework.TestCaseAttribute("Cluster By Name (with Specific Subscription Credential)", null)]
        public virtual void NoParameterSetHasTwoParametersThatAcceptTheirValueFromThePipeline(string parameterSetName, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No parameter set has two parameters that accept their value from the pipeline", exampleTags);
#line 25
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 26
   testRunner.And(string.Format("I am using the \"{0}\" parameter set", parameterSetName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
  testRunner.Then("only one parameter in the set is set to take its value from the pipeline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No parameter in any set shares a name or alias with another")]
        public virtual void NoParameterInAnySetSharesANameOrAliasWithAnother()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No parameter in any set shares a name or alias with another", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 33
  testRunner.Then("no parameter in any parameter set shares a name or alias with another parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No parameter lacks either a Getter or a Setter")]
        public virtual void NoParameterLacksEitherAGetterOrASetter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No parameter lacks either a Getter or a Setter", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 36
  testRunner.Then("no parameter lacks either a Getter or a Setter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I can use the \"Cluster By Name (with Specific Subscription Credential)\" parameter" +
            " set")]
        public virtual void ICanUseTheClusterByNameWithSpecificSubscriptionCredentialParameterSet()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can use the \"Cluster By Name (with Specific Subscription Credential)\" parameter" +
                    " set", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 39
  testRunner.When("I am using the \"Cluster By Name (with Specific Subscription Credential)\" paramete" +
                    "r set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
  testRunner.Then("there exists a \"Name\" Cmdlet parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
   testRunner.And("it is of type \"String\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
   testRunner.And("it is a required parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
   testRunner.And("it is specified as parameter 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
   testRunner.And("it can take its value from the pipeline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
   testRunner.And("there exists a \"Subscription\" Cmdlet parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
   testRunner.And("it is of type \"String\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
   testRunner.And("it is a required parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
   testRunner.And("it is specified as parameter 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
   testRunner.And("it can not take its value from the pipeline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
      testRunner.And("there exists a \"Certificate\" Cmdlet parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
   testRunner.And("it is of type \"X509Certificate2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
   testRunner.And("it is an optional parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
   testRunner.And("it is specified as parameter 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
   testRunner.And("it can not take its value from the pipeline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
   testRunner.And("there exists a \"Location\" Cmdlet parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
   testRunner.And("it is of type \"String\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
   testRunner.And("it is an optional parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
   testRunner.And("it is specified as parameter 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
   testRunner.And("it can not take its value from the pipeline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
      testRunner.And("there exists a \"EndPoint\" Cmdlet parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
   testRunner.And("it is of type \"Uri\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
   testRunner.And("it is an optional parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
   testRunner.And("it is specified as parameter 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
   testRunner.And("it can not take its value from the pipeline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
      testRunner.And("there exists a \"CloudServiceName\" Cmdlet parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
   testRunner.And("it is of type \"String\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
   testRunner.And("it is an optional parameter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
   testRunner.And("it is specified as parameter 5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
   testRunner.And("it can not take its value from the pipeline", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
      testRunner.And("there are no additional parameters in the parameter set", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
