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
            _protectedItemPage = PageFactory.CreatePage(context, typeof(ProtectedItemPage).Name);
            _protectedContentPage = PageFactory.CreatePage(context, typeof(ProtectedContentPage).Name);
        }

        private WebTestContext _context;
        private ProtectedItemPage _protectedItemPage;
        private ProtectedContentPage _protectedContentPage;

        [When(@"I go to the a protected item page")]
        public void WhenIGoToTheAProtectedItemPage()
        {
            _protectedItemPage.NavigateHere();
        }

        [Then(@"I should see a page with the message that Access is Denied")]
        public void ThenIShouldSeeAPageWithTheMessageThatAccessIsDenied()
        {
            Assert.IsTrue(_protectedItemPage.IsAccessDenied());
        }

        [When(@"I go to the a protected content page")]
        public void WhenIGoToTheAProtectedContentPage()
        {
            _protectedContentPage.NavigateHere();
        }

        [Then(@"I should see a page with a Abstract Content text")]
        public void ThenIShouldSeeAPageWithAAbstractContentText()
        {
            Assert.IsTrue(_protectedContentPage.CanSeeAbstract());
        }
    }
}
