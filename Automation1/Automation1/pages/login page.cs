using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Automation1.pages
{
    public class login_page
    {
        public void LoginActions(IWebDriver Driver)
        {

       
            Driver.Manage().Window.Maximize();

            // Launch turnup portal
            Driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(3000);

            // Identify the username textbox and enter valid username
            IWebElement usernameTextbox = Driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // Identify the password textbox and enter valid password
            IWebElement PasswordTextbox = Driver.FindElement(By.Id("Password"));
            PasswordTextbox.SendKeys("123123");

            // Identify the login button and click on it
            IWebElement loginButton = Driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(3000);
        }
    }
}



