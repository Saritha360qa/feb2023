using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



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
IWebElement Typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
Typecodedropdown.Click();
Thread.Sleep(1000);

IWebElement Timeoption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
Timeoption.Click();

// Input code into the code textbox
IWebElement Codetextbox = driver.FindElement(By.Id ("Code"));
Codetextbox.SendKeys("February2023");

// Input Description into the description textbox
IWebElement Descriptiontextbox = driver.FindElement(By.Id("Description"));
Descriptiontextbox.SendKeys("February2023");

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
if (Newcode.Text == "February2023")
{
    Console.WriteLine("New time record created sucessfully");
}
else
{
    Console.WriteLine("New record not created ");
}
     


