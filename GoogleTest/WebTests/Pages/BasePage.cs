using GoogleTest.WebTests.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace GoogleTest.WebTests.Pages
{
    public class BasePage {
        private IWebDriver _driver = null;

        public IWebDriver Driver { get { return _driver; } }

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal void Hilight(IWebElement element)
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }
    }
}
