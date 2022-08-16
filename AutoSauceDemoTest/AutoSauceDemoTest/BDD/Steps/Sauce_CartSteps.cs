using Sauce_TestAutomationFramework.Lib;
using System;
using TechTalk.SpecFlow;

namespace AutoSauceDemoTest.BDD.Steps
{
    [Binding]
    public class Sauce_CartSteps
    {
        //
        public Sauce_ProductsSteps sauce_ProductsSteps { get; } = new Sauce_ProductsSteps();

        [Given(@"I have signed in with username ""([^""]*)"", added a backpack, and clicked the cart")]
        public void GivenIHaveSignedInWithUsernameAddedABackpackAndClickedTheCart(string username)
        {
            sauce_ProductsSteps.GivenIHaveSignedInWithUsernameAndLandedOnTheProductPage(username);
            sauce_ProductsSteps.GivenIHaveAddedABackpack();
            sauce_ProductsSteps.WhenIClickTheCart();
        }

        [When(@"I click checkout")]
        public void WhenIClickCheckout()
        {
            sauce_ProductsSteps.sauce_LoginSteps.Sauce_Website.Sauce_CartPage.ClickCheckout();
        }

        [Then(@"I should be taken to the checkout page")]
        public void ThenIShouldBeTakenToTheCheckoutPage()
        {
            sauce_ProductsSteps.sauce_LoginSteps.Sauce_Website.SeleniumDriver.Navigate().GoToUrl(AppConfigReader.CartUrl);
        }
        [AfterScenario]
        public void DisposeWebDriver()
        {
            sauce_ProductsSteps.sauce_LoginSteps.Sauce_Website.SeleniumDriver.Dispose();
        }
    }
}
