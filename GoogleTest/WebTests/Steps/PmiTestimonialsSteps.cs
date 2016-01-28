using GoogleTest.WebTests.Code;
using GoogleTest.WebTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace GoogleTestGoogleTest.WebTests.Steps
{
    [Binding]
    public class PmiTestimonialsSteps{
        
        public PmiTestimonialsSteps(WebTestContext context) {
            _context = context;
            _testimonialsPage = PageFactory.CreatePage(context, typeof(TestimonialsPage).Name);
        }

         private WebTestContext _context;
         private TestimonialsPage _testimonialsPage;
 
        [When(@"I go to the testimonials page")]
        public void WhenIGoToTheTestimonialsPage()
        {
            _testimonialsPage.NavigateHere();
        }
    }
}
