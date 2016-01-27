using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace GoogleTest.WebTests.Code{
    public static class SystemUnderTest {

        public static TimeSpan ShortWaitTime
        {
            get { return TimeSpan.FromMilliseconds(250); }
        }

        public static string SiteUri { get { return "http://pmi-refresh.durabledigital.com"; } }
        public static string ProtectedItemLink { get { return "protected-item-test"; } }
        public static string ProtectedContentLink { get { return "protected-Content-test"; } }
        public static string ChaptersLink { get { return "membership/chapters"; } }
    }
}


