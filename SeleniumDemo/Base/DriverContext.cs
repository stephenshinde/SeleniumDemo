using System;
using OpenQA.Selenium;

namespace SeleniumDemo.Base
{
    public class DriverContext
    {
        public DriverContext()
        {
        }

        private static IWebDriver _driver;

        internal static IWebDriver Driver
        {
            get
            {
                return _driver;
            }

            set
            {
                _driver = value;
            }
        }



    }
}
