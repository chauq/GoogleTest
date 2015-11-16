using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace GoogleTest
{
    [Binding]
    public sealed class GoogleSearchFeatureSteps
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void InitScenario()
        {
            FirefoxOptions options = new FirefoxOptions();
            var profile = new FirefoxProfile();
            var binary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe");
            driver = new FirefoxDriver(binary, profile);
        }

        [AfterScenario]
        public void TearDownScenario()
        {
            driver.Dispose();
        }

        [Given(@"I navigate to the page ""(.*)""")]
        public void GivenINavigateToThePage(string p0)
        {
            driver.Navigate().GoToUrl("https://www.google.com.bd");
        }

        [Given(@"I see the page is loaded")]
        public void GivenISeeThePageIsLoaded()
        {
            Assert.AreEqual("Google", driver.Title);
        }

        [When(@"I enter Search Keyword in the Search Text box")]
        public void WhenIEnterSearchKeywordInTheSearchTextBox(Table table)
        {
            String searchText = table.Rows[0]["Keyword"].ToString();
            driver.FindElement(By.Name("q")).SendKeys(searchText);
        }

        [When(@"I click on Search Button")]
        public void WhenIClickOnSearchButton()
        {
            driver.FindElement(By.Name("btnG")).Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
        }

        [Then(@"Search items shows the items related to SpecFlow")]
        public void ThenSearchItemsShowsTheItemsRelatedToSpecFlow()
        {
            Assert.AreEqual("SpecFlow - Cucumber for .NET", driver.FindElement(By.XPath("//h3/a")).Text);
        }

    }
}
