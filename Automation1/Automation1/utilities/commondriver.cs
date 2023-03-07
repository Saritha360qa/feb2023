using Automation1.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.utilities
{
    public class commondriver
    {
        public IWebDriver driver;
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();

            //LoginPage object intialization and difinition
            login_page loginpageobj = new login_page();
            loginpageobj.LoginActions(driver);

        }
        [TearDown]
        public void Closetestrun()
        {
            driver.Quit();
        }
    }
}
