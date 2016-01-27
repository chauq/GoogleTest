using GoogleTest.WebTests.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoogleTest.WebTests.Pages
{
    public class ChaptersPage : BasePage
    {
        public ChaptersPage(IWebDriver driver)
            : base(driver, typeof(ChaptersPage).Name){
                _link = new Uri(SystemUnderTest.SiteUri + "/" + SystemUnderTest.ChaptersLink);
        }

        private Uri _link;

        internal void NavigateHere()
        {
            Driver.Navigate().GoToUrl(_link);
        }


        //looks for widgets on the page by looking for the class name of the widget
        /* This method is in the Basepage now
        internal bool CanSeeWidgets(string widget)
        {
            var w = Driver.FindElements(By.ClassName(widget));
            return w.Count > 0;
        }
        */

        public ChaptersSearchPage SearchFor(string searchTerm) {
            var query = Driver.FindElement(By.Id("search-input"));
            var searchButtonBy = Driver.FindElement(By.ClassName("input-group-btn"));
            var searchButton = searchButtonBy.FindElement(By.CssSelector(".fa"));
            var test = Driver.FindElement(By.CssSelector("[value]"));

            Hilight(query);
            query.Clear();
            query.SendKeys(searchTerm);
            Hilight(searchButtonBy);
            Hilight(searchButton);
            searchButton.Click();
            return new ChaptersSearchPage(Driver);
         }
      }
}
