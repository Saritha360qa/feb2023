


using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Automation1.pages;
using System.ComponentModel.DataAnnotations;

// open chrome browser 
IWebDriver Driver = new ChromeDriver();

//LoginPage object intialization and difinition
login_page loginpageobj = new login_page();
loginpageobj.LoginActions(Driver);

//Homepage object intialization and difinition
home_page homepageobj= new home_page();
homepageobj.GoToTmpage(Driver);

//TMpage object intialization and difinition
tm_page TMPageobj= new tm_page();
TMPageobj.CreateTm(Driver);

//Edit TM
TMPageobj.EditTM(Driver);

//Delete TM
TMPageobj.DeleteTM(Driver);





