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
    private IWebElement _loginLink => _seleniumDriver.FindElement(By.Id("login-button"));

    #endregion
    public Sauce_HomePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

    #region Methods
    public void VisitHomePage() => _seleniumDriver.Navigate().GoToUrl(_homePageUrl);
    public void VisitLoginPage() => _LoginLink.Click();
    #endregion
}
