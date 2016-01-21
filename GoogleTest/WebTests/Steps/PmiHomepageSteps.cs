using GoogleTest.WebTests.Code;
using GoogleTest.WebTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace GoogleTest.WebTests.Steps {
    [Binding]
    public sealed class PmiHomepageSteps {


    public PmiHomepageSteps(WebTestContext context) {
            _context = context;
            _homePage = PageFactory.CreateHomePage(context);
        }

        private WebTestContext _context = null;
        private HomePage _homePage = null;
        
        [Then(@"I should get some body text")]
        public void ThenIShouldGetSomeBodyText()
        {
            Assert.IsTrue(_homePage.IsTextPresent());
        }
    }
}
