using System;
using BoDi;
using SpecFlowProjectTemplate.Helpers;
using SpecFlowProjectTemplate.Helpers.ReportHelpers;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTemplate.Hooks
{
    [Binding]
    public class Hooks
    {
        private IReportHelper helper;
        private Hooks(IObjectContainer container)
        {
            this.helper = container.Resolve<IReportHelper>();
        }

        [AfterScenario]
        public void ReportScenario(ScenarioContext context)
        {
            helper.reportScenario(context);
        }

        [AfterStep]
        public void ReportStep(ScenarioContext context)
        {
            helper.reportStep(context);
        }
    }
}