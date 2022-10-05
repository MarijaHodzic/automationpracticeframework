using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class Homepage
    {
        readonly IWebDriver driver;

        public By homepage = By.Id("index");
        public By ContactUs = By.Id("contact-link");
        public By SearchField = By.Id("search_query_top");
        public By SearchBtn = By.Name("submit_search");
        public By SignInBtn = By.ClassName("login");
        
                        
        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(homepage));
        }
    }
}
