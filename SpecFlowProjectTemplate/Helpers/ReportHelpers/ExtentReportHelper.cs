using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTemplate.Helpers.ReportHelpers
{
    public class ExtentReportHelper : IReportHelper
    {
        public void reportStep(ScenarioContext context)
        {
            // Report an extent Step Here
        }

        public void reportScenario(ScenarioContext context)
        {
            // Report an extent Scenario here
        }

        public static void startReporter(FeatureContext context)
        {
            //Start the feature
        }
    }
}