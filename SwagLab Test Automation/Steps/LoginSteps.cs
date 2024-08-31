using OpenQA.Selenium;
using TechTalk.SpecFlow;
using FluentAssertions;
using SwagLab_Test_Automation.Pages;

namespace SwagLab_Test_Automation.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver driver;
        private readonly LoginPage loginPage;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            driver = (IWebDriver)scenarioContext["WebDriver"];
            loginPage = (LoginPage)scenarioContext["LoginPage"];
        }

        [Given(@"I am on the login page")]
        public void GivenIamOnTheLoginPage()
        {
            loginPage.OpenWebsite();
        }

        [When(@"I attempt to login with empty credentials")]
        public void WhenIAttemptToLoginWithEmptyCredentials()
        {
            loginPage.ClearUsername();
            loginPage.ClearPassword();
            loginPage.ClickLoginButton();
        }

        [When(@"I attempt to login with username and missing password")]
        public void WhenIAttemptToLoginWithUsernameAndMissingPassword()
        {
            loginPage.EnterUsername("test-user");
            loginPage.ClearPassword();
            loginPage.ClickLoginButton();
        }

        [When(@"I attempt to login with locked out user")]
        public void WhenIAttemptToLoginWithLockedOutUser()
        {
            loginPage.EnterUsername("locked_out_user");
            loginPage.EnterPassword("secret_sauce");
            loginPage.ClickLoginButton();
        }

        [When(@"I enter username ""(.*)"" and password ""(.*)""")]
        public void WhenIEnterUsernameAndPassword(string username, string password)
        {
            loginPage.EnterUsername(username);
            loginPage.EnterPassword(password);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see an error message ""(.*)""")]
        public void ThenIShouldSeeAnErrorMessage(string expectedMessage)
        {
            loginPage.GetErrorMessage().Should().Be(expectedMessage);
        }

        [Then(@"I should be redirected to the Swag Labs title page")]
        public void ThenIShouldBeRedirectedToTheSwagLabsTitlePage()
        {
            loginPage.GetPageTitle().Should().Be("Swag Labs");
        }
    }
}
