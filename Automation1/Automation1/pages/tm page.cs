using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Automation1.pages
{
    public class tm_page
    {
        public void CreateTm(IWebDriver Driver)
        {
            IWebElement Createnewbutton = Driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            Createnewbutton.Click();
            Thread.Sleep(1000);

            // Select time option from type code dropdown list
            IWebElement typecodedropdown = Driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodedropdown.Click();
            Thread.Sleep(1000);

            IWebElement timeoption = Driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/ li[2]"));
            timeoption.Click();

            // Input code into the code textbox
            IWebElement Codetextbox = Driver.FindElement(By.Id("Code"));
            Codetextbox.SendKeys("Saritha2023Code");

            // Input Description into the description textbox
            IWebElement Descriptiontextbox = Driver.FindElement(By.Id("Description"));
            Descriptiontextbox.SendKeys("Saritha2023_Desc");

            // Input price per unit into the price per unit text box
            IWebElement Priceperunittextbox = Driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            Priceperunittextbox.Click();
            IWebElement Price = Driver.FindElement(By.Id("Price"));
            Price.SendKeys("12");

            // Click on save button
            IWebElement Savebutton = Driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();
            Thread.Sleep(2000);

            //Check if new time record has been created
            IWebElement gotolastpagebutton = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotolastpagebutton.Click();
            Thread.Sleep(2000);

            IWebElement Newcode = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            if (Newcode.Text == "Saritha2023Code")
            {
                Console.WriteLine("New time record created sucessfully");
            }
            else
            {
                Console.WriteLine("New record not created ");
            }

        }
        public void EditTM(IWebDriver Driver)

        {
            // Navigate to the last one record and click on edit
            IWebElement lasttimerecord = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            lasttimerecord.Click();

            IWebElement Editbutton = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Editbutton.Click();
            Thread.Sleep(2000);

            //Get Timestamp
            var Timestamp = Stopwatch.GetTimestamp();

            // Edit new code into the code textbox
            IWebElement Editnewcode = Driver.FindElement(By.Id("Code"));
            Editnewcode.Clear();
            Editnewcode.SendKeys("S" + Timestamp);

            // Edit new description into the description textbox
            IWebElement Editnewdescription = Driver.FindElement(By.Id("Description"));
            Editnewdescription.Clear();
            Editnewdescription.SendKeys("Saritha Description");

            // Edit new price per unit into the price per unit text box
            IWebElement EditPriceperunittextbox = Driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            EditPriceperunittextbox.Click();

            IWebElement newprice = Driver.FindElement(By.Id("Price"));
            newprice.Clear();
            EditPriceperunittextbox.Click();
            newprice.SendKeys("18");

            // Click on save button
            IWebElement savebutton = Driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(1000);

            //Check if new time record has created
            IWebElement gotothelastpagebutton = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[last()]/a[4]/span"));
            gotothelastpagebutton.Click();
            Thread.Sleep(3000);

            IWebElement newcode = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newcode.Text == ("S" + Timestamp))
            {
                Console.WriteLine("Edited time record created sucessfully");
            }
            else
            {
                Console.WriteLine("Time record not created sucessfully");
            }
        }
        public void DeleteTM(IWebDriver Driver)
        {
            // Navigate to last page and click on delete button
            IWebElement Lasttimerecord = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Lasttimerecord.Click();

            IWebElement deletebutton = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deletebutton.Click();
            Thread.Sleep(1000);

            // Navigate to alert option 
            Driver.SwitchTo().Alert().Accept();
            Thread.Sleep(5000);

            // check if the record is properly deleted
            IWebElement codedeleted = Driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            //Console.WriteLine(codedeleted.Text);

            if (codedeleted.Text == "\"S\"+Timestamp")
            {
                Console.WriteLine("Time record not deleted sucessfully");
            }
            else
            {
                Console.WriteLine("Time record deleted sucessfully");
            }

            Driver.Quit();
        }
    }
}


