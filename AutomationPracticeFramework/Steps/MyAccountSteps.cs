using System;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        Homepage hp = new Homepage(Driver);

        [Given(@"user clicks on '(.*)' button")]
        public void GivenUserClicksOnButton(string signInBtn)
        {
           ut.ClickOnElement(hp.SignInBtn);
        }
        
        [When(@"fills in '(.*)' and '(.*)' fields")]
        public void GivenFillsInAndFields(string email, string password)
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.EmailAddress, ut.GetMyAccountEmail());
            ut.EnterTextInElement(ap.Password, ut.GetMyAccountPssword());
        }

        [When(@"user cliks '(.*)' button")]
        public void WhenUserCliksButton(string signInBtn)
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.SignInBtn);
        }

        [Then(@"'(.*)' message is displayed")]
        public void ThenMessageIsDisplayed(string myAccount)
        {
            MyAccountPage map = new MyAccountPage(Driver);
            Assert.That(ut.ReturnTextFromElement(map.MyAccountHdg), Is.EqualTo(myAccount), "User is not signed in");
        }
    }
}
