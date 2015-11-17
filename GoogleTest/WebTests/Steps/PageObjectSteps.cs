using GoogleTest.WebTests.Code;
using GoogleTest.WebTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace GoogleTest.WebTests.Steps
{
    [Binding]
    public sealed class PageObjectSteps {

        public PageObjectSteps(WebTestContext context)
        {
            _context = context;
            _loginPage = PageFactory.CreateHomepage(context);
            _findFlightsPage = PageFactory.CreateFlightsPage(context);
        }

        private WebTestContext _context;
        private LoginPage _loginPage;
        private FindFlightsPage _findFlightsPage;

        [Given(@"I go to the Test page")]
        public void GivenIGoToTheTestPage()
        {
            _loginPage = PageFactory.CreateHomepage(_context);
            _loginPage.Driver.Navigate().GoToUrl("http://newtours.demoaut.com");
        }

        [When(@"I login into the Flights application")]
        public void WhenILoginIntoTheFlightsApplication()
        {
            _loginPage.LogIntoPage();
        }

        [Then(@"I should get the Find Flights page")]
        public void ThenIShouldGetTheFindFlightsPage()
        {
            _findFlightsPage = PageFactory.CreateFlightsPage(_context);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (_context.Driver != null) _context.Driver.Quit();
        }
    }
}
