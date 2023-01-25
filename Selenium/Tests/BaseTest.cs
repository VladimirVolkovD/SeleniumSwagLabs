using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Selenium.Pages;
using NUnit.Framework;

namespace Selenium.Tests
{
    public class BaseTest
    {
        private WebDriver driver;
        protected LoginPage LoginPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();

            LoginPage = new LoginPage(driver);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
