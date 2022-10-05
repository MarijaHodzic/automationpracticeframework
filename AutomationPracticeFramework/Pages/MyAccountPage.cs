using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationPracticeFramework.Pages
{
    class MyAccountPage
    {
        readonly IWebDriver driver;

        public By MyAccount = By.Id("my-account");
        public By MyAccountHdg = By.ClassName("page-heading");


        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(MyAccount));
        }
    }
        
 }

