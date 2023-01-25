using NUnit.Framework;
using Selenium.Pages;

namespace Selenium.Tests
{
    [TestFixture]
    internal class LoginTest : BaseTest
    {
        [Test]
        public void TestEmptyPassword()
        {
            LoginPage.OpenPage();
            LoginPage.SetUserName(LoginPage.STANDARD_USERNAME);
            LoginPage.SetPassword("");
            LoginPage.ClickLogin();

            Assert.AreEqual(LoginPage.GetErrorMessage(), "Epic sadface: Password is required");
        }             
    }
}
