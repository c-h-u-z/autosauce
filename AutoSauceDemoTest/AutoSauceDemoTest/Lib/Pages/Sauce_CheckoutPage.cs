using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSauceDemoTest.Lib.Pages
{
    public class Sauce_CheckoutPage
    {
        #region Properties and fields
        private IWebDriver _seleniumDriver;
        private string _checkoutStepOnePageUrl = AppConfigReader.CheckoutStepOneUrl;
        private string _checkoutStepTwoPageUrl = AppConfigReader.CheckoutStepTwoUrl;
        private IWebElement _firstName => _seleniumDriver.FindElement(By.Id("first-name"));
        private IWebElement _lastName => _seleniumDriver.FindElement(By.Id("last-name"));
        private IWebElement _postalCode => _seleniumDriver.FindElement(By.Id("postal-code"));
        private IWebElement _continueButton => _seleniumDriver.FindElement(By.Id("submit-button btn btn_primary cart_button btn_action"));
        private IWebElement _errorMessage => _seleniumDriver.FindElement(By.ClassName("error-button"));

        #endregion
        public Sauce_CheckoutPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region Methods
        public void VisitCheckoutPage() => _seleniumDriver.Navigate().GoToUrl(_checkoutStepOnePageUrl);

        public void InputFirstName(string firstName)
        {
            _firstName.SendKeys(firstName);
        }
        public void InputLastName(string lastName)
        {
            _lastName.SendKeys(lastName);
        }
        public void InputPostalCode(string postalCode)
        {
            _postalCode.SendKeys(postalCode);
        }
        public void ClickContinue()
        {
            _continueButton.Click();
        }
        public string GetErrorMessageText()
        {
            return _errorMessage.FindElement(By.TagName("h3")).Text;
        }
        #endregion
    }
}
