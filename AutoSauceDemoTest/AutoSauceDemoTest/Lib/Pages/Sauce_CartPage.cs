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
        private IWebElement _checkoutButton => _seleniumDriver.FindElement(By.ClassName("checkout"));
        #endregion

        public void ClickCheckout()
        {
            _checkoutButton.Click();
        }
    }
}
