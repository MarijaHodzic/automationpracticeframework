using System;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        Homepage hp = new Homepage(Driver);

        [Given(@"user opens contact us page")]
        public void GivenUserOpensContactUsPage()
        {
            ut.ClickOnElement(hp.ContactUs);
        }
        
        [When(@"user fill in all required fields with '(.*)' heading and '(.*)' message")]
        public void WhenUserFillInAllRequiredFieldsWithHeadingAndMessage(string heading, string message)
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.DropdownSelect(cup.subjectHeading, heading);
            ut.EnterTextInElement(cup.contactEmail, ut.GenerateRandomEmail());
            ut.EnterTextInElement(cup.message, message);
        }
        
        [When(@"user submits the form")]
        public void WhenUserSubmitsTheForm()
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.ClickOnElement(cup.sendBtn);
        }
        
        [Then(@"message '(.*)' is presented to the user")]
        public void ThenMessageIsPresentedToTheUser(string successMessage)
        {
            ContactUsPage cup = new ContactUsPage(Driver);
            Assert.That(ut.ReturnTextFromElement(cup.successMessage), Is.EqualTo(successMessage), "Message was not sent to customer service");               
        }
    }
}
