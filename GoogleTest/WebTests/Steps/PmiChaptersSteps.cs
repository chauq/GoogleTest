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
            _chaptersSearchPage = PageFactory.CreatePage(context, typeof(ChaptersSearchPage).Name);
        }

        private WebTestContext _context;
        private ChaptersPage _chaptersPage;
        private ChaptersSearchPage _chaptersSearchPage;

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

        [Given(@"I am on the Chapter page")]
        public void GivenIAmOnTheChapterPage()
        {
            _chaptersPage.NavigateHere();
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string searchTerm)
        {
            _chaptersSearchPage = _chaptersPage.SearchFor(searchTerm);
        }

        [Then(@"I should see results for ""(.*)""")]
        public void ThenIShouldSeeResultsFor(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
