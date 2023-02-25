using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.Animation;
using System.Diagnostics;



// open chrome browser 
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// Lunch turnup portal
driver .Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread. Sleep(1000);

// Identify the username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys ("hari");

// Identify the password textbox and enter valid password
IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
PasswordTextbox.SendKeys("123123");

// Identify the login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
Thread.Sleep(1000);

// Check if login was sucessfull
IWebElement Username = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (Username.Text == "helloHari!")
{
    Console.WriteLine("login is sucessfull");
}
else
{
    Console.WriteLine("login failed");
}


// create a new material record

// Navigate to time and materials page
IWebElement Administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
Administrationdropdown.Click();

IWebElement Timeandmaterialoption = driver.FindElement(By.XPath("/ html / body / div[3] / div / div / ul / li[5] / ul / li[3] / a"));
Timeandmaterialoption.Click();
Thread.Sleep(1000);

// Click on createnew button
IWebElement Createnewbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
Createnewbutton.Click();
Thread.Sleep(1000);

// Select time option from type code dropdown list
IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typecodedropdown.Click();
Thread.Sleep(1000);

IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/ li[2]"));
timeoption.Click();

// Input code into the code textbox
IWebElement Codetextbox = driver.FindElement(By.Id ("Code"));
Codetextbox.SendKeys("Saritha2023Code");

// Input Description into the description textbox
IWebElement Descriptiontextbox = driver.FindElement(By.Id("Description"));
Descriptiontextbox.SendKeys("Saritha2023_Desc");

// Input price per unit into the price per unit text box
IWebElement Priceperunittextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
Priceperunittextbox.Click();
IWebElement Price = driver.FindElement(By.Id("Price"));
Price.SendKeys("12");

// Click on save button
IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
Savebutton.Click();
Thread.Sleep(2000);

//Check if new time record has been created
IWebElement gotolastpagebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotolastpagebutton.Click();
Thread.Sleep(2000);

IWebElement Newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (Newcode.Text == "Saritha2023Code")
{
    Console.WriteLine("New time record created sucessfully");
}
else
{
    Console.WriteLine("New record not created ");
}



// Navigate to the last one record and click on edit
IWebElement lasttimerecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
lasttimerecord.Click();

IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
Editbutton.Click();
Thread.Sleep(2000);

//Get Timestamp
var Timestamp = Stopwatch.GetTimestamp();

Console.WriteLine(Timestamp);

// Edit new code into the code textbox

IWebElement Editnewcode = driver.FindElement(By.Id("Code"));
Editnewcode.Clear();
Editnewcode.SendKeys("Saritha"+Timestamp);

// Edit new description into the description textbox
IWebElement Editnewdescription = driver.FindElement(By.Id("Description"));
Editnewdescription.Clear();
Editnewdescription.SendKeys("Saritha Description");

// Edit new price per unit into the price per unit text box
IWebElement EditPriceperunittextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
EditPriceperunittextbox.Click();

IWebElement newprice = driver.FindElement(By.Id("Price"));
newprice.Clear();
EditPriceperunittextbox.Click();
newprice.SendKeys("18");

// Click on save button
IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
savebutton.Click();
Thread.Sleep(1000);

//Check if new time record has created
IWebElement gotothelastpagebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[last()]/a[4]/span"));
gotothelastpagebutton.Click();
Thread.Sleep(3000);

IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (newcode.Text == ("Saritha"+Timestamp))
{
    Console.WriteLine("Edited time record created sucessfully");
}
else
{
    Console.WriteLine("Time record not created sucessfully");
}

// Navigate to last page and click on delete button
IWebElement Lasttimerecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
Lasttimerecord.Click();

IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deletebutton.Click();
Thread.Sleep(1000);

// Navigate to alert option 
driver.SwitchTo().Alert().Accept();
Thread.Sleep(5000);


// check if the record is properly deleted
IWebElement codedeleted = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
Console.WriteLine(codedeleted.Text);

if (codedeleted.Text == "\"Saritha\"+Timestamp")
{
    Console.WriteLine("time record not deleted sucessfully");
}
else
{
    Console.WriteLine("Time record deleted sucessfully");
}

driver.Quit();

