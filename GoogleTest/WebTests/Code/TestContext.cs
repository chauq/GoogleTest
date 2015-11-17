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
    public class WebTestContext {

        public IWebDriver Driver { get; set; }

        public WebTestContext() {

        FirefoxOptions options = new FirefoxOptions();
        var profile = new FirefoxProfile();
        var binary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe");

            if (Driver == null)
                Driver = new FirefoxDriver(binary, profile);
        }
    }
}


