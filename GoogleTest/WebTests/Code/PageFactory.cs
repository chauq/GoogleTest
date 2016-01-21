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

        public static dynamic CreatePage(WebTestContext context, string pageType)
        {

            string pageFileEnding = "Page";

            // Make this easy on the user - find classes regardless of 'page' on the end
            if (!pageType.EndsWith(pageFileEnding, StringComparison.OrdinalIgnoreCase))
            {
                pageType += pageFileEnding;
            }

            // We can even account for gaps in page names
            // Remove spaces and make camel-case
            var pageWords = pageType.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (pageWords.Any())
            {

                var builder = new StringBuilder();

                foreach (string item in pageWords)
                {
                    string capitalised = item[0].ToString().ToUpperInvariant() + item.Substring(1);
                    builder.Append(capitalised);
                }

                pageType = builder.ToString();

            }

            Type type = Type.GetType("GoogleTest.WebTests.Pages." + pageType);
            Assert.IsNotNull(type, "No type was found for the page type called: " + pageType);
            return CreatePage(context, type);
        }

        public static dynamic CreatePage(WebTestContext context, Type pageType)
        {
            var args = new object[1] { context.Driver };
            return Activator.CreateInstance(pageType, args);
        }

        /// <summary>
        /// Create a new test page using the current driver context
        /// and the page type.
        /// </summary>
        /// <param name="context">Current test driver context.</param>
        /// <typeparam name="T">The page type to use</typeparam>
        /// <returns>A new instance of the page class.</returns>
        public static T CreatePage<T>(WebTestContext context) where T : BasePage
        {
            var pageType = typeof(T);
            var args = new[] { context.Driver };
            object page = Activator.CreateInstance(pageType, args);
            T typedPage = page as T;
            if (null == typedPage) throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Unable to create a {0} page", pageType.Name));
            return typedPage;
        }

        public static T CreatePage<T>(IWebDriver driver) where T : BasePage
        {
            var pageType = typeof(T);
            var args = new[] { driver };
            object page = Activator.CreateInstance(pageType, args);
            T typedPage = page as T;
            if (null == typedPage) throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Unable to create a {0} page", pageType.Name));
            return typedPage;
        }
    }
}