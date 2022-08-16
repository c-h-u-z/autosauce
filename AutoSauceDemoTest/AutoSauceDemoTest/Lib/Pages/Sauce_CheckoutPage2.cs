using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSauceDemoTest.Lib.Pages
{
    public class Sauce_CheckoutPage2
    {
        #region Properties and fields
        private IWebDriver _seleniumDriver;
        private string _checkoutStepTwoPageUrl = AppConfigReader.CheckoutStepTwoUrl;
        //private IWebElement _inventory => _seleniumDriver.FindElement(By.Id("item_0_title_link"));
        private IWebElement _item0Name => _seleniumDriver.FindElement(By.Id("item_0_title_link")).FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _item1Name => _seleniumDriver.FindElement(By.Id("item_1_title_link")).FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _item2Name => _seleniumDriver.FindElement(By.Id("item_2_title_link")).FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _item3Name => _seleniumDriver.FindElement(By.Id("item_3_title_link")).FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _item4Name => _seleniumDriver.FindElement(By.Id("item_4_title_link")).FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _item5Name => _seleniumDriver.FindElement(By.Id("item_5_title_link")).FindElement(By.ClassName("inventory_item_name"));
        private IWebElement _item0Price => _seleniumDriver.FindElement(By.Id("item_0_title_link")).FindElement(By.ClassName("item_pricebar"));
        private IWebElement _item1Price => _seleniumDriver.FindElement(By.Id("item_1_title_link")).FindElement(By.ClassName("item_pricebar"));
        private IWebElement _item2Price => _seleniumDriver.FindElement(By.Id("item_2_title_link")).FindElement(By.ClassName("item_pricebar"));
        private IWebElement _item3Price => _seleniumDriver.FindElement(By.Id("item_3_title_link")).FindElement(By.ClassName("item_pricebar"));
        private IWebElement _item4Price => _seleniumDriver.FindElement(By.Id("item_4_title_link")).FindElement(By.ClassName("item_pricebar"));
        private IWebElement _item5Price => _seleniumDriver.FindElement(By.Id("item_5_title_link")).FindElement(By.ClassName("item_pricebar"));
        private IWebElement _finishButton => _seleniumDriver.FindElement(By.Id("finish"));
        private IWebElement _cancelButton => _seleniumDriver.FindElement(By.Id("cancel"));
        #endregion

        public Sauce_CheckoutPage2(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        #region Methods
        public void ClickFinish()
        {
            _finishButton.Click();
        }

        public void ClickCancel()
        {
            _cancelButton.Click();
        }
        #endregion
    }
}
