using GoogleTest.WebTests.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace GoogleTest.WebTests.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        internal bool IsTextPresent()
        {
            var text = Driver.FindElements(By.ClassName("rte"));
            return text.Count > 0;
        }
    }

}