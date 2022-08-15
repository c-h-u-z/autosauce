using System;
using TechTalk.SpecFlow;

namespace AutoSauceDemoTest.BDD.Steps
{
    [Binding]
    public class Sauce_ProductsSteps
    {
        Sauce_LoginSteps sauce_LoginSteps = new Sauce_LoginSteps();

        [Given(@"I have signed in with username ""([^""]*)"" and landed on the product page")]
        public void GivenIHaveSignedInWithUsernameAndLandedOnTheProductPage(string username)
        {
            sauce_LoginSteps.GivenIAmOnTheHomePage();
            sauce_LoginSteps.GivenIEnterACorrectUsername(username);
            sauce_LoginSteps.GivenIEnterACorrectPassword();
            sauce_LoginSteps.WhenIClickTheLoginButton();
        }

        [Given(@"I have added a backpack")]
        public void GivenIHaveAddedABackpack()
        {
            sauce_LoginSteps.Sauce_Website.Sauce_ProductsPage.AddBackpack();
        }

        [When(@"I click the cart")]
        public void WhenIClickTheCart()
        {
            sauce_LoginSteps.Sauce_Website.Sauce_ProductsPage.ClickCartLink();
        }

        [Then(@"the item will be added as shown in the cart page")]
        public void ThenTheItemWillBeAddedAsShownInTheCartPage()
        {
            var inventory = sauce_LoginSteps.Sauce_Website.SeleniumDriver.FindElement(By.Id("item_4_title_link")).FindElement(By.ClassName("inventory_item_name")).Text;
            Assert.That(inventory, Is.EqualTo("Sauce Labs Backpack"));
        }

        [Given(@"I click remove backpack")]
        public void GivenIClickRemoveBackpack()
        {
            sauce_LoginSteps.Sauce_Website.Sauce_ProductsPage.RemoveBackpack();
        }

        [Then(@"the item will be removed as shown in the cart page")]
        public void ThenTheItemWillBeRemovedAsShownInTheCartPage()
        {
            throw new PendingStepException();
        }
    }
}
