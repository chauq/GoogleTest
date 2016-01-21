using GoogleTest.WebTests.Code;
using GoogleTest.WebTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace GoogleTest
{
    [Binding]
    public class PmiProtectedContentSteps
    {

        public PmiProtectedContentSteps(WebTestContext context)
        {
            _context = context;
            _protectedContentPage = PageFactory.CreatePage(context, typeof(ProtectedContentPage).Name);
        }

        private WebTestContext _context;
        private ProtectedContentPage _protectedContentPage;

        [When(@"I go to the a protected item page")]
        public void WhenIGoToTheAProtectedItemPage()
        {
            _protectedContentPage.NavigateHere();
        }

        [Then(@"I should see a page with the message that Access is Denied")]
        public void ThenIShouldSeeAPageWithTheMessageThatAccessIsDenied()
        {
            Assert.IsTrue(_protectedContentPage.IsAccessDenied());
        }

    }
}
