using SpecFlowProject.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Hooks
{
    [Binding]
    public sealed class WebDriverHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private ScenarioContext scenarioContext;

        public WebDriverHooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext; 
            scenarioContext["Username"] = "Test" + DateTime.Now.ToString("yyyyMMdd'T'HHmmss");
            scenarioContext["Password"] = "Test2021!@#$";
             
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario
            Loggers.Log(scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void QuitWebdriver()
        {
            //TODO: implement logic that has to run after executing each scenario
            Singlton.Close();
        }
    }
}
