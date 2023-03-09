using Automation1.pages;
using Automation1.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.tests
{
    [TestFixture]
    [Parallelizable]
    
    public class Tmtests : commondriver
    {
        //page object intialization
        home_page homepageobj = new home_page();
        tm_page TMPageobj = new tm_page();

        [Test, Order(1), Description("check if user is able to create time record with valid data")]
        public void CreateTmTest()
        {
          

            homepageobj.GoToTMPage(driver);
            TMPageobj.CreateTm(driver);
           
        }
        [Test,Order(2), Description("check if user is able to edit an existing data with valid data")]
        public void edittmtest()
        {
         
            homepageobj.GoToTMPage(driver);
           // TMPageobj.EditTM(driver);
        }
        [Test,Order(3),Description("check if user is able to delete an existing data")]
        public void deletetmtest()
        {
           
            homepageobj.GoToTMPage(driver);
            TMPageobj.DeleteTM(driver);

        }
        
    }
}
