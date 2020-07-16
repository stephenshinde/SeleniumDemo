using System;
using NUnit.Framework;
using SeleniumDemo.Pages;

namespace SeleniumDemo.TestCases
{
    public class LaunchTest
    {
        public LaunchTest()
        {
        }

        [Test]
        public void verifyPageTitle()
        {
            LaunchPage launchpage = new LaunchPage();
            Assert.AreEqual("My Store", launchpage.getPageTitle());
        }

        [Test]
        public void searchProduct()
        {
            LaunchPage launchpage = new LaunchPage();
            launchpage.entersearchText("Faded Short Sleeve T-shirts");
            launchpage.clickonSearchbutton();
        }
    }
}
