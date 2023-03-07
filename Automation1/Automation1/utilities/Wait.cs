using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.utilities
{
    public class Wait
    {
        public static void waittobeclickable(IWebDriver Driver,string locatortype,string locatorvalue,int seconds)
        {
            var Wait = new WebDriverWait(Driver,new TimeSpan(0,0,seconds));

            if(locatortype == "XPath")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorvalue)));
            }
            if(locatortype == "Id")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorvalue)));
            }
            if(locatortype == "Cssselector")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorvalue)));
            }
        }

    }
}
