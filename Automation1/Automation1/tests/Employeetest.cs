using Automation1.pages;
using Automation1.utilities;
using NUnit.Framework;
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
    
    public class Employeetest : commondriver
    {
        //page object intialization
        home_page homepageobj = new home_page();
        Employeespage EmployeePageobj = new Employeespage();

        [Test, Order(1), Description("check if user is able to create time record with valid data")]
        public void CreateEmployeepageTest()
        {
            
            homepageobj.GoToEmployeespage(driver);
            EmployeePageobj.createEmployeespage(driver);
        }

        [Test, Order(2), Description("check if user is able to edit an existing data with valid data")]
        public void editEmployeepagetest()
        {

            homepageobj.GoToEmployeespage(driver);
            EmployeePageobj.editEmployeepage(driver);

        }

        [Test, Order(3), Description("check if user is able to delete an existing data")]
        public void deleteEmployeepagetest()
        {
           
            homepageobj.GoToEmployeespage(driver);
            EmployeePageobj.deleteEmployeepage(driver);

        }
       
    }
}


        