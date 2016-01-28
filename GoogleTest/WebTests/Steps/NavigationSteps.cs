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
    public class NavigationSteps
    {

        public NavigationSteps(WebTestContext context)
        {
            _homePage = PageFactory.CreateHomePage(context);
            _context = context;
        }

        private WebTestContext _context = null;
        private HomePage _homePage = null;
        private String uri;

        [Given(@"I am on the Pmi home page")]
        public void GivenIAmOnThePmiHomePage()
        {
            _homePage = PageFactory.CreateHomePage(_context);
            _homePage.Driver.Navigate().GoToUrl("http://pmi-refresh.durabledigital.com/");
        }

        [When(@"I go to the ""(.*)"" url")]
        public void WhenIGoToTheUrl(string url)
        {
            _homePage.Driver.Navigate().GoToUrl("http://pmi-refresh.durabledigital.com/" + uri);
        }

        [When(@"I click on the main navbar link ""(.*)""")]
        public void WhenIClickOnTheMainNavigationBarLink(NavigationBarLink mainLink)
        {
            _homePage.ClickLinkInHeader(mainLink.ToString());
        }
    }
}
