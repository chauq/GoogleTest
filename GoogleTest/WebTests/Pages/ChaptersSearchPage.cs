using GoogleTest.WebTests.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoogleTest.WebTests.Pages
{
    public class ChaptersSearchPage : BasePage
    {
        public ChaptersSearchPage(IWebDriver driver)
            : base(driver, typeof(ChaptersSearchPage).Name)
        {
        }
    }

}
