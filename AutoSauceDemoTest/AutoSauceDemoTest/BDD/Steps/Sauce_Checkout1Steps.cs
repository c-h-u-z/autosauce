using System;
using TechTalk.SpecFlow;

namespace AutoSauceDemoTest.BDD.Steps
{
    [Binding]
    public class Sauce_Checkout1Steps
    {
        public Sauce_ProductsSteps sauce_productsSteps { get; } = new Sauce_ProductsSteps();

        [Given(@"I have clicked the cart and clicked checkout")]
        public void GivenIHaveClickedTheCartAndClickedCheckout()
        {
            sauce_productsSteps.WhenIClickTheCart();
            sauce_productsSteps.sauce_LoginSteps.Sauce_Website.Sauce_CartPage.ClickCheckout();
        }

        [Given(@"I have entered a first name")]
        public void GivenIHaveEnteredAFirstName()
        {
            sauce_productsSteps.sauce_LoginSteps.Sauce_Website.Sauce_CheckoutPage1.InputFirstName();
        }

        [Given(@"I have entered a last name")]
        public void GivenIHaveEnteredALastName()
        {
            sauce_productsSteps.sauce_LoginSteps.Sauce_Website.Sauce_CheckoutPage1.InputLastName();
        }

        [Given(@"I have entered a postal code")]
        public void GivenIHaveEnteredAPostalCode()
        {
            sauce_productsSteps.sauce_LoginSteps.Sauce_Website.Sauce_CheckoutPage1.InputPostalCode();
        }

        [When(@"I click the continue button")]
        public void WhenIClickTheContinueButton()
        {
            sauce_productsSteps.sauce_LoginSteps.Sauce_Website.Sauce_CheckoutPage1.ClickContinue();
        }

        [Then(@"I should be taken to the check out step two page")]
        public void ThenIShouldBeTakenToTheCheckOutStepTwoPage()
        {
            var url = sauce_productsSteps.sauce_LoginSteps.Sauce_Website.SeleniumDriver.Url;
            Assert.That(url, Is.EqualTo(AppConfigReader.CheckoutStepTwoUrl));
        }

        [Then(@"I should be thrown an exception ""([^""]*)""")]
        public void ThenIShouldBeThrownAnException(string expectedErrorMessage)
        {
            var errorMessage = sauce_productsSteps.sauce_LoginSteps.Sauce_Website.Sauce_CheckoutPage1.GetErrorMessageText;
            Assert.That(errorMessage, Is.EqualTo(expectedErrorMessage));
        }

        [Given(@"I have signed in with username ""([^""]*)""")]
        public void GivenIHaveSignedInWithUsername(string p0)
        {
            throw new PendingStepException();
        }
    }
}
