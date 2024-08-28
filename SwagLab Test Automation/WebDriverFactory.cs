using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SwagLab_Test_Automation
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateDriver(string browser)
        {
            switch (browser.ToLower())
            {
                case "firefox":
                    return new FirefoxDriver();
                case "chrome":
                    return new ChromeDriver();
                case "edge":
                    return new EdgeDriver();
                default:
                    throw new ArgumentException($"The browser is not supported: {browser}");
            }
        }
    }
}
