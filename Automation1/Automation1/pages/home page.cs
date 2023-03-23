using Automation1.utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.pages
{
    public class home_page
    {
        public void GoToTMPage(IWebDriver Driver)
        {
           
            // Navigate to time and materials page
            IWebElement Administrationdropdown = Driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationdropdown.Click();
            Thread.Sleep(3000);

           // Wait.waittobeclickable(Driver,"XPath", "/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a", 5);
            IWebElement tmOption = Driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));  
            tmOption.Click();
            Thread.Sleep(3000);
        }
        public void GoToEmployeespage(IWebDriver Driver)
        {
            // Navigate to time and materials page
            IWebElement Administrationdropdown = Driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationdropdown.Click();
            Thread.Sleep(3000);

           // Wait.waittobeclickable(Driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a)", 5);
            IWebElement Employeesoption = Driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Employeesoption.Click();
            Thread.Sleep(3000);

        }
    }
}
