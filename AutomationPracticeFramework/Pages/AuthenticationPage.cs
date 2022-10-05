using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class AuthenticationPage
    {
        readonly IWebDriver driver;

        public By Authentication = By.Id("authentication");
        public By EmailAddress = By.Id("email");
        public By Password = By.Id("passwd");
        public By SignInBtn = By.Id("SubmitLogin");


        public AuthenticationPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(Authentication));
        }

    }
}
