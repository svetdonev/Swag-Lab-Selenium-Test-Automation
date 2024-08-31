using OpenQA.Selenium;
using SwagLab_Test_Automation.Drivers;
using SwagLab_Test_Automation.Pages;
using TechTalk.SpecFlow;

namespace SwagLab_Test_Automation.Hooks
{
    [Binding]
    public class Hook
    {
        private readonly ScenarioContext scenarioContext;

        public Hook(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = WebDriverFactory.CreateDriver("firefox");
            scenarioContext["WebDriver"] = driver;
            scenarioContext["LoginPage"] = new LoginPage(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (scenarioContext.ContainsKey("WebDriver"))
            {
                var driver = scenarioContext["WebDriver"] as IWebDriver;
                driver?.Quit();
            }
        }
    }
}
