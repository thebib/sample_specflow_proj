using System.Configuration;
using BoDi;
using Gherkin.Events.Args.Ast;
using Microsoft.Extensions.Configuration;
using SpecFlowProjectTemplate.Helpers;
using SpecFlowProjectTemplate.Helpers.ReportHelpers;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration;

namespace SpecFlowProjectTemplate.Hooks
{
    [Binding]
    public class Setup
    {
        [BeforeFeature]
        public static void setupForFeature(FeatureContext context, IObjectContainer container)
        {
            loadConfiguration(container);
            loadReporter(context, container);
        }
        
        private static void loadConfiguration(IObjectContainer container)
        {
            var config =  new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            container.RegisterInstanceAs<IConfiguration>(config);
        }
        
        public static void loadReporter(FeatureContext context, IObjectContainer container)
        {
            var config = container.Resolve<IConfiguration>();
            if (config["appSettings:Reporter"] == "extent")
            {
                container.RegisterInstanceAs<IReportHelper>(new ExtentReportHelper());
                ExtentReportHelper.startReporter(context);
            }
            else
            {
                container.RegisterInstanceAs<IReportHelper>(new XmlReportHelper());
                XmlReportHelper.startReporter(context);
            }
        }
    }
}