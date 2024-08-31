using OpenQA.Selenium;

namespace SwagLab_Test_Automation.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly string url = "https://www.saucedemo.com/";
        private IWebElement UsernameField => driver.FindElement(By.CssSelector("#user-name"));
        private IWebElement PasswordField => driver.FindElement(By.CssSelector("#password"));
        private IWebElement LoginButton => driver.FindElement(By.CssSelector("#login-button"));
        private IWebElement ErrorMessage => driver.FindElement(By.CssSelector("[data-test='error']"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenWebsite() => driver.Navigate().GoToUrl(url);
        public void EnterUsername(string username) => UsernameField.SendKeys(username);
        public void EnterPassword(string password) => PasswordField.SendKeys(password);
        public void ClearUsername() => UsernameField.Clear();
        public void ClearPassword() => PasswordField.Clear();
        public void ClickLoginButton() => LoginButton.Click();
        public string GetErrorMessage() => ErrorMessage.Text;
        public string GetPageTitle() => driver.Title;
    }
}
