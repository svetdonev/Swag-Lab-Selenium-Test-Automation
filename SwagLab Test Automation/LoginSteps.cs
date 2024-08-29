using OpenQA.Selenium;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace SwagLab_Test_Automation
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            driver = (IWebDriver)scenarioContext("WebDriver");
            loginPage = (LoginPage)scenarioContext("LoginPage");
        }
    }
}
