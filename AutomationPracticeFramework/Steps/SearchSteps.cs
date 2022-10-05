using System;
using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class SearchSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        Homepage hp = new Homepage(Driver);

        [Given(@"user enters '(.*)' search term")]
        public void GivenUserEntersSearchTerm(string term)
        {
            ut.EnterTextInElement(hp.SearchField, term);
        }

        [When(@"user submits the search")]
        public void WhenUserSubmitsTheSearch()
        {
            ut.ClickOnElement(hp.SearchBtn);
        }

        [Then(@"results for '(.*)' search term are displayed")]
        public void ThenResultsForSearchTermAreDisplayed(string term)
        {
            SearchResultsPage srp = new SearchResultsPage(Driver);
            Assert.That(ut.ReturnTextFromElement(srp.searchResult), Does.Contain(term), "Wrong search results");
        }
    }
}



   