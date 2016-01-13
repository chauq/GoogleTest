using GoogleTest.WebTests.Pages;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace GoogleTest.WebTests.Code
{
    public static class PageFactory {

        public static LoginPage CreateLoginPage(WebTestContext context)
        {
            return new LoginPage(context.Driver);
        }

        public static FindFlightsPage CreateFlightsPage(WebTestContext context)
        {
            return new FindFlightsPage(context.Driver);
        }

        public static HomePage CreateHomePage(WebTestContext context)
        {
            return new HomePage(context.Driver);
        }
    }
}