namespace AutoSauceDemoTest.BDD.Steps;

[Binding]
public class Sauce_LoginSteps
{
    private Sauce_Website<ChromeDriver> Sauce_Website { get; } = new Sauce_Website<ChromeDriver>();

    [Given(@"I am on the home page")]
    public void GivenIAmOnTheHomePage()
    {
        Sauce_Website.SeleniumDriver.Navigate().GoToUrl(AppConfigReader.BaseUrl);
    }

    [Given(@"I enter the username standard_user")]
    public void GivenIEnterTheUsernameStandard_User()
    {
        Sauce_Website.Sauce_HomePage.InputEmail("standard_user");
    }

    [Given(@"I enter a correct password")]
    public void GivenIEnterACorrectPassword()
    {
        Sauce_Website.Sauce_HomePage.InputPassword("secret_sauce");
    }

    [When(@"I click the login button")]
    public void WhenIClickTheLoginButton()
    {
        Sauce_Website.Sauce_HomePage.ClickLogin();
    }

    [Then(@"I should be taken to the products page")]
    public void ThenIShouldBeTakenToTheProductsPage()
    {
        Assert.That(Sauce_Website.SeleniumDriver.Url, Is.EqualTo(AppConfigReader.InventoryUrl));
    }

    [Given(@"I enter an incorrect password")]
    public void GivenIEnterAnIncorrectPassword()
    {
        Sauce_Website.Sauce_HomePage.InputPassword("123456");
    }

    [Then(@"I should get an exception thrown")]
    public void ThenIShouldGetAnExceptionThrown()
    {
        var errorText = Sauce_Website.Sauce_HomePage.GetErrorMessageText();
        Assert.That(errorText, Does.Exist);
    }

    [Then(@"I should get an exception thrown ""([^""]*)""")]
    public void ThenIShouldGetAnExceptionThrown(string error)
    {
        var errorText = Sauce_Website.Sauce_HomePage.GetErrorMessageText();
        Assert.That(errorText, Is.EqualTo(error));
    }

    [Given(@"I enter an incorrect username")]
    public void GivenIEnterAnIncorrectUsername()
    {
        Sauce_Website.Sauce_HomePage.InputEmail("incorrect");
    }

    [Given(@"I do not enter a password")]
    public void GivenIDoNotEnterAPassword()
    {
        
    }

    [Given(@"I do not enter a username")]
    public void GivenIDoNotEnterAUsername()
    {
        
    }
    [Given(@"I am on a search engine")]
    public void GivenIAmOnASearchEngine()
    {
        
    }

    [When(@"i enter the web address for the products page")]
    public void WhenIEnterTheWebAddressForTheProductsPage()
    {
        Sauce_Website.SeleniumDriver.Navigate().GoToUrl(AppConfigReader.InventoryUrl);
    }

    [Then(@"I should get an error ""([^""]*)""")]
    public void ThenIShouldGetAnError(string error)
    {
        var errorText = Sauce_Website.Sauce_HomePage.GetErrorMessageText();
        Assert.That(errorText, Is.EqualTo(error));
    }

    [AfterScenario]
    public void DisposeWebDriver()
    {
        Sauce_Website.SeleniumDriver.Dispose();
    }

}
