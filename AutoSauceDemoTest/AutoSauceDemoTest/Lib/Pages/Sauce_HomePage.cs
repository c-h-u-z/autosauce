namespace AutoSauceDemoTest.Lib.Pages;

public class Sauce_HomePage
{
    #region Properties and fields
    private IWebDriver _seleniumDriver;
    private string _homePageUrl = AppConfigReader.BaseUrl;
    private IWebElement _loginButton => _seleniumDriver.FindElement(By.Id("login-button"));
    private IWebElement _emailField => _seleniumDriver.FindElement(By.Id("user-name"));
    private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("password"));
    private IWebElement _errorMessage => _seleniumDriver.FindElement(By.ClassName("error-message-container"));
    public Sauce_HomePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
    #endregion


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
