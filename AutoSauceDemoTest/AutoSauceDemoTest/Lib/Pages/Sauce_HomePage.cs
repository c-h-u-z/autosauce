using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sauce_TestAutomationFramework.Lib.Pages;

public class Sauce_HomePage
{
    #region Properties and fields
    private IWebDriver _seleniumDriver;
    private string _homePageUrl = AppConfigReader.BaseUrl;
    private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
    private IWebElement _emailField => _seleniumDriver.FindElement(By.Id("user-name"));
    private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
    private IWebElement _errorMessage => _seleniumDriver.FindElement(By.ClassName("error-message-container"));

    #endregion
    public Sauce_HomePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

    #region Methods
    public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);

    public void InputEmail(string email)
    {
        _emailField.SendKeys(email);
    }
    public void InputPassword(string password)
    {
        _passwordField.SendKeys(password);
    }
    public void ClickLogin()
    {
        _loginButton.Click();
    }
    public void Login() 
    {
        InputEmail("standard_user");
        InputPassword("secret_sauce");
        ClickLogin();
    }
    public string GetErrorMessageText()
    {
        return _errorMessage.FindElement(By.TagName("h3")).Text;
    }
    #endregion
}
