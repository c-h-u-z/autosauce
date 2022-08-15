using OpenQA.Selenium;
using Sauce_TestAutomationFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSauceDemoTest.Lib.Pages
{
    public class Sauce_ProductsPage
    {
        #region Properties and fields
        private IWebDriver _seleniumDriver;
        private string _productsPageUrl = AppConfigReader.InventoryUrl;

        #endregion
        public Sauce_ProductsPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;

        #region Methods

        #endregion
    }
}
