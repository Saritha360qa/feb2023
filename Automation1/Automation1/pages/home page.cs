using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.pages
{
    public class home_page
    {
        public void GoToTmpage(IWebDriver Driver)
        {

            // Navigate to time and materials page
            IWebElement Administrationdropdown = Driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationdropdown.Click();

            IWebElement Timeandmaterialoption = Driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
            Timeandmaterialoption.Click();
            Thread.Sleep(1000);
        }
    }
}
