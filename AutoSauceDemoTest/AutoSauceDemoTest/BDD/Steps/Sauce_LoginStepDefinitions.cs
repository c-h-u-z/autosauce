using System;
using TechTalk.SpecFlow;
using Sauce_TestAutomationFramework;
using Sauce_TestAutomationFramework.Lib;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutoSauceDemoTest.BDD.Steps;

[Binding]
public class Sauce_LoginStepDefinitions
{
    private Sauce_Website<ChromeDriver> Sauce_Website = new Sauce_Website<ChromeDriver>();

    [Given(@"I am on the home page")]
    public void GivenIAmOnTheHomePage()
    {
        Sauce_Website.SeleniumDriver.Navigate().GoToUrl(AppConfigReader.BaseUrl);
    }

    [Given(@"I enter a correct username")]
    public void GivenIEnterACorrectUsername()
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
        //Assert.That
    }

    [Given(@"I enter an incorrect username")]
    public void GivenIEnterAnIncorrectUsername()
    {
        throw new PendingStepException();
    }

    [Given(@"I do not enter a password")]
    public void GivenIDoNotEnterAPassword()
    {
        throw new PendingStepException();
    }

    [Given(@"I do not enter a username")]
    public void GivenIDoNotEnterAUsername()
    {
        throw new PendingStepException();
    }

}
