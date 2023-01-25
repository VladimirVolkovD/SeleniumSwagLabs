using OpenQA.Selenium;

namespace Selenium.Pages
{
    public class LoginPage : BasePage
    {
        public static string STANDARD_USERNAME;
        public static string DEFAULT_PASSWORD;

        private By UserNameField;

        private By PasswordField;

        private By LoginButton;

        private By ErrorMessage;

        public LoginPage(WebDriver driver) : base(driver) { }

        public void OpenPage()
        {
           
        }

        public void SetUserName(string userName)
        {
            
        }

        public void SetPassword(string password)
        {
        }     

        internal void LoginWithStandardUser()
        {
          
        }

        public void ClickLogin()
        {
          
        }

        public void GetErrorMessage()
        {
            
        }
    }
}
