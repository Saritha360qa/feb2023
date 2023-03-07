using Automation1.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.pages
{
    public class Employeespage : commondriver
    {
        public void createEmployeespage(IWebDriver driver) 
        {
            //click on create button in employeespage
            IWebElement Createbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            Createbutton.Click();
            Thread.Sleep(2000);

            //Input code into the name textbox
            IWebElement Nametextbox = driver.FindElement(By.Id("Name"));
            Nametextbox.SendKeys("Saritha");

            //Input code into user name textbox
            IWebElement Usernametextbox = driver.FindElement(By.Id("Username"));
            Usernametextbox.SendKeys("Siri");

            //Input code into contact textbox
            IWebElement Contacttextbox = driver.FindElement(By.Id("ContactDisplay"));
            Contacttextbox.SendKeys("12345678");

            //Input code into passwordtextbox
            IWebElement Passwordtextbox = driver.FindElement(By.Id("Password"));
            Passwordtextbox.SendKeys("5678");

            //Input code into Retypepasswordtextbox
            IWebElement Retypepasswordtextbox = driver.FindElement(By.Id("RetypePassword"));
            Retypepasswordtextbox.SendKeys("5678");

            //Click on admin button
            IWebElement Adminbutton = driver.FindElement(By.Id("IsAdmin"));
            Adminbutton.Click();

            //Input code into vehicle textbox
            IWebElement Vehicletextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            Vehicletextbox.SendKeys("321");

            //Click on groupsdropdown and select NZtest option
            IWebElement Groupsdropdown = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            Groupsdropdown.Click();
            Thread.Sleep(2000);

            IWebElement NZtestoption = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[13]"));
            NZtestoption.Click();

            //Click on save button
            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();
            Thread.Sleep(6000);


            IWebElement Administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationdropdown.Click();
            Thread.Sleep(3000);

            IWebElement Employeesoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Employeesoption.Click();
            Thread.Sleep(1000);



            //Check if new record created or not
            IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotolastpagebutton.Click();
            Thread.Sleep(3000); 

            IWebElement Newcode = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(Newcode.Text == "Saritha","Actual code and expected code do Not match");
         
        }

        public void editEmployeepage(IWebDriver driver) 
        {
            IWebElement GoToLastpagebutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            GoToLastpagebutton.Click();
            Thread.Sleep(2000);

           // IWebElement recordtobeedited = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
           // if (recordtobeedited.Text == "Saritha")
          //  {
                IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                Editbutton.Click();
                Thread.Sleep(2000);
           // }
            //else
                 //Assert.Fail("record to be edited not found");

            

            //edit newcode into the name textbox
            IWebElement Editnametextbox = driver.FindElement(By.Id("Name"));
            Editnametextbox.Clear();
            Editnametextbox.SendKeys("Ram");

            //edit newcode into the username textbox
            IWebElement Editusernametextbox = driver.FindElement(By.Id("Username"));
            Editusernametextbox.Clear();
            Editusernametextbox.SendKeys("Siri1");

            //edit newcode into contacttextbox
            IWebElement Editcontacttextbox = driver.FindElement(By.Id("ContactDisplay"));
            Editcontacttextbox.Clear();
            Editcontacttextbox.SendKeys("23456789");

            //edit newcode into passwordtextbox
            IWebElement Editpasswordtextbox = driver.FindElement(By.Id("Password"));
            Editpasswordtextbox.Clear();
            Editpasswordtextbox.SendKeys("1234");

            //edit newcode into retypepasswordtextbox
            IWebElement Editretypepasswordtextbox = driver.FindElement(By.Id("RetypePassword"));
            Editretypepasswordtextbox.Clear();
            Editretypepasswordtextbox.SendKeys("1234");


            //Click on save button
            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();
            Thread.Sleep(1000);

            IWebElement Administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Administrationdropdown.Click();
            Thread.Sleep(3000);

            IWebElement Employeesoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            Employeesoption.Click();
            Thread.Sleep(1000);

            //Check if record edited or not
            IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotolastpagebutton.Click();
            Thread.Sleep(3000); 
          

            IWebElement Newcode = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(Newcode.Text == "Ram", "actual code and edited code do not match");



        }
        public void deleteEmployeepage(IWebDriver driver) 
        {
            IWebElement GoToLastpagebutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            GoToLastpagebutton.Click();
            Thread.Sleep(2000);

            IWebElement recordtobedeleted = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (recordtobedeleted.Text == "Ram") 

            {
                IWebElement Deletebutton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
                Deletebutton.Click();
                Thread.Sleep(2000);
            }

            else
            
                Assert.Fail("record to be deleted not found");
            


            // Navigate to alert option 
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(5000);

            IWebElement codedeleted = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(codedeleted.Text != "Ram", "record deleted sucessfully");

        }
    }


    
}
