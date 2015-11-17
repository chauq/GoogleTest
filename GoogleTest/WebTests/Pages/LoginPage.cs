using GoogleTest.WebTests.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GoogleTest.WebTests.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public void LogIntoPage()
        {
            Driver.FindElement(By.Name("userName")).SendKeys("test");
            Driver.FindElement(By.Name("password")).SendKeys("test");
            Driver.FindElement(By.Name("login")).Click();
        }
    }

}
