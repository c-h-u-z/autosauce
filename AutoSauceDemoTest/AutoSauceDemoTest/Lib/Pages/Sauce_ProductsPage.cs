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
        public Sauce_HomePage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
    }
}
