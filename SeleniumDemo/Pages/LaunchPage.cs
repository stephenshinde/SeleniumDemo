using System;
using OpenQA.Selenium;
using SeleniumDemo.Base;

namespace SeleniumDemo.Pages
{
    public class LaunchPage
    {
        public LaunchPage()
        {
        }

        IWebElement txtsSearchProduct => DriverContext.Driver.FindElement(By.Id("search_query_top"));

        IWebElement btnSearch => DriverContext.Driver.FindElement(By.Name("submit_search"));

        //IWebElement btnLogin => _parallelConfig.Driver.FindByCss("input.btn");

        //IWebElement btnLoginss => _parallelConfig.Driver.FindByCss("input.btnssss");



        public string getPageTitle()
        {
           return DriverContext.Driver.Title;

        }

        public void entersearchText(string productName)
        {
            btnSearch.SendKeys(productName);
        }

        public void clickonSearchbutton()
        {
            btnSearch.Click();
        }
    }

    

}


