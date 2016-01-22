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
    public class PmiChaptersSteps
    {
        public PmiChaptersSteps(WebTestContext context)
        {
            _context = context;
            _chaptersPage = PageFactory.CreatePage(context, typeof(ChaptersPage).Name);
        }

        private WebTestContext _context;
        private ChaptersPage _chaptersPage;

        [When(@"I go to the chapters page")]
        public void WhenIGoToTheChaptersPage()
        {
            _chaptersPage.NavigateHere();
        }
        
        [Then(@"I should see a page with following (.*)")]
        public void ThenIShouldSeeAPageWithFollowing(string widgets)
        {
            Assert.IsTrue(_chaptersPage.CanSeeWidgets(widgets));
        }
    }
}
