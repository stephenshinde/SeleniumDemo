using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumDemo.Base;

namespace SeleniumDemo.Pages
{
    public class SearchResultPage
    {
        public SearchResultPage()
        {
        }

        IWebElement txtSearchProductName => DriverContext.Driver.FindElement(By.XPath("//div[@class='right-block']//a[@class='product-name']"));

        IWebElement btnSearch => DriverContext.Driver.FindElement(By.Name("submit_search"));


        public string getProductName()
        {
           return txtSearchProductName.Text;
        }

        
    }
}
