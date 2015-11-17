using GoogleTest.WebTests.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace GoogleTest.WebTests.Pages
{
    public class FindFlightsPage : BasePage
    {
        public FindFlightsPage(IWebDriver driver)
            : base(driver){
        }

        internal bool HasBodyText
        {
            get { return Driver.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[3]/td/font")).Text.Length > 3; }
        }
    }
}
