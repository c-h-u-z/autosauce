using OpenQA.Selenium.Chrome;
using Sauce_TestAutomationFramework.Lib;
using System;
using TechTalk.SpecFlow;

namespace AutoSauceDemoTest.BDD.Steps;

[Binding]
public class Sauce_SortStepDefinitions
{
    private Sauce_Website<ChromeDriver> Sauce_Website { get; } = new Sauce_Website<ChromeDriver>();
    [Given(@"I am on the product page")]
    public void GivenIAmOnTheProductPage()
    {
        Sauce_Website.Sauce_HomePage.Login();
    }

    [When(@"I click the sort menu")]
    public void WhenIClickTheSortMenu()
    {
        throw new PendingStepException();
    }

    [Then(@"a menu displaying all sorting methods will appear")]
    public void ThenAMenuDisplayingAllSortingMethodsWillAppear()
    {
        throw new PendingStepException();
    }

    [Given(@"I have clicked the sort menu")]
    public void GivenIHaveClickedTheSortMenu()
    {
        //Sauce_Website.ProductPage
    }

    [When(@"I click sort by name \(A to Z\)")]
    public void WhenIClickSortByNameAToZ()
    {
        throw new PendingStepException();
    }

    [Then(@"the items will be sorted by name from A to Z")]
    public void ThenTheItemsWillBeSortedByNameFromAToZ()
    {
        throw new PendingStepException();
    }

    [When(@"I click sort by name \(Z to A\)")]
    public void WhenIClickSortByNameZToA()
    {
        throw new PendingStepException();
    }

    [Then(@"the items will be sorted by name from Z to A")]
    public void ThenTheItemsWillBeSortedByNameFromZToA()
    {
        throw new PendingStepException();
    }

    [When(@"I click sort by price \(low to high\)")]
    public void WhenIClickSortByPriceLowToHigh()
    {
        throw new PendingStepException();
    }

    [Then(@"the items will be sorted by price from low to high")]
    public void ThenTheItemsWillBeSortedByPriceFromLowToHigh()
    {
        throw new PendingStepException();
    }

    [When(@"I click sort by price \(high to low\)")]
    public void WhenIClickSortByPriceHighToLow()
    {
        throw new PendingStepException();
    }

    [Then(@"the items will be sorted by price from high to low")]
    public void ThenTheItemsWillBeSortedByPriceFromHighToLow()
    {
        throw new PendingStepException();
    }
}
