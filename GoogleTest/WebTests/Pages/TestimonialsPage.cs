using GoogleTest.WebTests.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoogleTest.WebTests.Pages
{
    public class TestimonialsPage : BasePage
    {
        public TestimonialsPage(IWebDriver driver)
            : base(driver, typeof(TestimonialsPage).Name)
        {
            _link = new Uri(SystemUnderTest.SiteUri + "/" + SystemUnderTest.TestimonialsLink);
        }

        private Uri _link;

        internal void NavigateHere()
        {
            Driver.Navigate().GoToUrl(_link);
        }

      }
}
