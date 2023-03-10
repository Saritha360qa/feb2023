using Automation1.pages;
using Automation1.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Automation1.StepDefinitions
{
    [Binding]
    public class TMfeatureStepDefinitions:commondriver

    {

        home_page homepageobj = new home_page();
        tm_page TMPageobj = new tm_page();

        public string? Newcode { get; private set; }

        [Given(@"I logged into turnup portal sucessfully")]
        public void GivenILoggedIntoTurnupPortalSucessfully()
        {
            driver = new ChromeDriver();

            //LoginPage object intialization and difinition
            login_page loginpageobj = new login_page();
            loginpageobj.LoginActions(driver);

        }

        [When(@"I navigate to time and materials page")]
        public void WhenINavigateToTimeAndMaterialsPage()
        {
            homepageobj.GoToTMPage(driver);
            
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            TMPageobj.CreateTm(driver);

        }

        [Then(@"The record should be created sucessfully")]
        public void ThenTheRecordShouldBeCreatedSucessfully()
        {
            string newcode = TMPageobj.Getcode(driver);
            string newDescription = TMPageobj.GetDescription(driver);
            string newprice = TMPageobj.Getprice(driver);

            Assert.That(newcode == "Saritha2023Code", "Actual code and expected code do Not match.");
            Assert.That(newDescription == "Saritha2023_Desc", "Actual description and expected description do Not match.");
            Assert.That(newprice == "$12.00", "Actual price and expected price do Not match.");
        }

       // [When(@"I Update '([^']*)' on an existing time and materials record")]
       // public void WhenIUpdateOnAnExistingTimeAndMaterialsRecord(string description)
       // {
           // TMPageobj . EditTM(driver, description);
       // }

       /// [Then(@"The record should have the updated '([^']*)'")]
        //public void ThenTheRecordShouldHaveTheUpdated(string description)
        //{
           // throw new PendingStepException();
       // }


        [When(@"I Update '([^']*)' '([^']*)','([^']*)'on an existing time and materials record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialsRecord(string description, string code, string price)
        {
            TMPageobj.EditTM(driver, description, code, price);
        }
        [Then(@"The record should have the updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string description, string code, string price)
        {
            String EditedDescription = TMPageobj .GeteditedDescription(driver);

            String EditedCode = TMPageobj.GeteditedCode(driver);

            String EditedPrice = TMPageobj.GeteditedPrice(driver);
            Console.WriteLine("This is Price stored int he Object"+ EditedPrice);

            Assert.That(EditedDescription == description, "Actual description and expected decsription do not match");
            Assert.That(EditedCode == code, "Actual code and expected code do not match");
            Assert.That(EditedPrice == price, "Actual price and expected price do not match");

        }




    }
}
