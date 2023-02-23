using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



// open chrome browser 

IWebDriver Driver = new ChromeDriver();

// lunch turnup portal
Driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

// Identify the username textbox and enter valid username
IWebElement UsernameTextbox = Driver. FindElement(By.Id("UserName"));
UsernameTextbox.SendKeys ("Hari");

// Identify the password textbox and enter valid password
IWebElement PasswordTextbox = Driver. FindElement(By.Id("Password"));
PasswordTextbox.SendKeys ("123123");

// Identify the login button and click on it
IWebElement LoginButton = Driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
LoginButton.Click();