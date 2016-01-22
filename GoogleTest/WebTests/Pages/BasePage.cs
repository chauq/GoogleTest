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
        private string _configTemplateName;

        public IWebDriver Driver { get { return _driver; } }

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public BasePage(IWebDriver driver, Type pageType)
        {
            _configTemplateName = pageType.Name;
            _driver = driver;
        }

        public BasePage(IWebDriver driver, string configTemplateName)
        {
            _configTemplateName = configTemplateName;
            _driver = driver;
        }

        internal void Hilight(IWebElement element)
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("arguments[0].style.border='3px solid red'", element);
        }

        internal bool IsPageNotFound()
        {
            return Driver.PageSource.Contains("Page not found");
        }

        //looks for widgets on the page by looking for the class name of the widget
        internal bool CanSeeWidgets(string widget)
        {
            var w = Driver.FindElements(By.ClassName(widget));
            return w.Count > 0;
        }
    }
}
