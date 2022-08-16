using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSauceDemoTest.Lib.Pages
{
    public class Sauce_CartPage
    {
        #region Properties and fields
        private IWebDriver _seleniumDriver;
        public Sauce_CartPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        private string _cartPageUrl = AppConfigReader.CartUrl;
        private IWebElement _checkoutButton => _seleniumDriver.FindElement(By.ClassName("checkout"));
        #endregion

        public void ClickCheckout()
        {
            _checkoutButton.Click();
        }
    }
}
