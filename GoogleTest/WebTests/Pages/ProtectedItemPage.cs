using GoogleTest.WebTests.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoogleTest.WebTests.Pages
{
    public class ProtectedItemPage : BasePage
    {
        public ProtectedItemPage(IWebDriver driver)
            : base(driver, typeof(ProtectedItemPage).Name){
                _link = new Uri(SystemUnderTest.SiteUri + "/" + SystemUnderTest.ProtectedItemLink);
        }

        private Uri _link;

        internal void NavigateHere()
        {
            Driver.Navigate().GoToUrl(_link);
        }

        internal bool IsAccessDenied()
        {
            return Driver.PageSource.Contains("Access Denied");
        }
    }

}
