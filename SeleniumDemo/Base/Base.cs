using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo.Base
{
    public class Base
    {
        public Base()
        {
        }

        [SetUp]
        public void initializeBrowser()
        {
            DriverContext.Driver = new ChromeDriver();
            DriverContext.Driver.Manage().Window.Maximize();
            DriverContext.Driver.Url = "http://automationpractice.com/index.php";
            DriverContext.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


        [TearDown]
        public void closeBrowser()
        {
            DriverContext.Driver.Close();
        }
    }
}
