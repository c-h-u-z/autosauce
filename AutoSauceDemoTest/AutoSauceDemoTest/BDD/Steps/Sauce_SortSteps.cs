namespace AutoSauceDemoTest.BDD.Steps;

[Binding]
public class Sauce_SortSteps
{
    Sauce_LoginSteps sauce_LoginSteps = new Sauce_LoginSteps();

    [Given(@"I am signed in with username ""([^""]*)"" and landed on product page")]
    public void GivenIAmSignedInWithUsernameAndLandedOnProductPage(string username)
    {
        sauce_LoginSteps.GivenIAmOnTheHomePage();
        sauce_LoginSteps.GivenIEnterACorrectUsername(username);
        sauce_LoginSteps.GivenIEnterACorrectPassword();
        sauce_LoginSteps.WhenIClickTheLoginButton();
    }

    //[When(@"I click the sort menu")]
    //public void WhenIClickTheSortMenu()
    //{
    //    Sauce_Website.Sauce_ProductsPage.ClickSortMenu();
    //}

    //[Then(@"a menu displaying all sorting methods will appear")]
    //public void ThenAMenuDisplayingAllSortingMethodsWillAppear()
    //{
    //    throw new PendingStepException();
    //}

    //[When(@"I click sort by ""([^""]*)""")]
    //public void WhenIClickSortBy(string sortMethod)
    //{
    //    Sauce_Website.Sauce_ProductsPage.ChooseSortMethod(sortMethod);
    //}

    //[Then(@"the items will be sorted by name from A to Z")]
    //public void ThenTheItemsWillBeSortedByNameFromAToZ()
    //{
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[0], Is.EqualTo("Sauce Labs Backpack"));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[1], Is.EqualTo("Sauce Labs Bike Light"));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[2], Is.EqualTo("Sauce Labs Bolt T-Shirt"));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[3], Is.EqualTo("Sauce Labs Onesie"));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[4], Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));

    //}

    //[Then(@"the items will be sorted by name from Z to A")]
    //public void ThenTheItemsWillBeSortedByNameFromZToA()
    //{
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[4], Is.EqualTo("Sauce Labs Backpack"));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[3], Is.EqualTo("Sauce Labs Bike Light"));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[2], Is.EqualTo("Sauce Labs Bolt T-Shirt"));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[1], Is.EqualTo("Sauce Labs Onesie"));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemNames[0], Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
    //}

    //[Then(@"the items will be sorted by price from low to high")]
    //public void ThenTheItemsWillBeSortedByPriceFromLowToHigh()
    //{
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[0], Is.EqualTo(7.99).Within(0.1));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[1], Is.EqualTo(9.99).Within(0.1));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[2], Is.EqualTo(15.99).Within(0.1));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[3], Is.EqualTo(15.99).Within(0.1));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[4], Is.EqualTo(29.99).Within(0.1));
    //}

    //[Then(@"the items will be sorted by price from high to low")]
    //public void ThenTheItemsWillBeSortedByPriceFromHighToLow()
    //{
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[4], Is.EqualTo(7.99).Within(0.1));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[3], Is.EqualTo(9.99).Within(0.1));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[2], Is.EqualTo(15.99).Within(0.1));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[1], Is.EqualTo(15.99).Within(0.1));
    //    Assert.That(Sauce_Website.Sauce_ProductsPage.InventoryItemPrices[0], Is.EqualTo(29.99).Within(0.1));
    //}
    //[AfterScenario]
    //public void DisposeWebDriver()
    //{
    //    Sauce_Website.SeleniumDriver.Dispose();
    //}
}
