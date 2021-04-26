using System;
using Gherkin.Ast;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTemplate.Helpers
{
    public interface IReportHelper
    {
        public void reportStep(ScenarioContext context);
        public void reportScenario(ScenarioContext context);
    }
}