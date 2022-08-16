namespace AutoSauceDemoTest.Lib.Pages
{
    public class Sauce_ProductsPage
    {
        #region Properties and fields
        private IWebDriver _seleniumDriver;
        public Sauce_ProductsPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;
        private string _productsPageUrl = AppConfigReader.InventoryUrl;
        private List<IWebElement> _inventoryItems => _seleniumDriver.FindElements(By.ClassName("inventory_item")).ToList();

        private IWebElement _cartLink => _seleniumDriver.FindElement(By.ClassName("shopping_cart_link"));

        #endregion

        //private IWebElement _sortMenuActiveOption => _seleniumDriver.FindElement(By.ClassName("active_option"));
        //private IWebElement _sortMenuSelectContainer => _seleniumDriver.FindElement(By.ClassName("product_sort_container"));
        //private SelectElement _sortMenuSelectElement => new SelectElement(_sortMenuSelectContainer);

        #region Fields for adding and removing items
        private IWebElement _addBackpack => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        private IWebElement _addBikeLight => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        private IWebElement _addBoltT => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        private IWebElement _addJacket => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-fleece-jacket"));
        private IWebElement _addOnesie => _seleniumDriver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        private IWebElement _addRedT => _seleniumDriver.FindElement(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)"));
        private IWebElement _removeBackpack => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-backpack"));
        private IWebElement _removeBikeLight => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-bike-light"));
        private IWebElement _removeBoltT => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-bolt-t-shirt"));
        private IWebElement _removeJacket => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-fleece-jacket"));
        private IWebElement _removeOnesie => _seleniumDriver.FindElement(By.Id("remove-sauce-labs-onesie"));
        private IWebElement _removeRedT => _seleniumDriver.FindElement(By.Id("remove-test.allthethings()-t-shirt-(red)"));
        #endregion

        #region Methods
        //public string SortMenuActiveOption => _sortMenuActiveOption.Text;
        //public void ClickSortMenu() => _sortMenuSelectContainer.Click();
        //public void ChooseSortMethod(string sortMethod) => _sortMenuSelectElement.SelectByText(sortMethod);

        public List<string> InventoryItemNames =>
            _inventoryItems.Select(x => x.FindElement(By.ClassName("inventory_item_name")).Text).ToList();
        public List<float> InventoryItemPrices =>
            _inventoryItems.Select(x => (float)Math.Round(float.Parse(x.FindElement(By.ClassName("inventory_item_price")).Text.Remove(0,1)),2)).ToList();
        #endregion

        #region Adding items
        public void AddBackpack()
        {
            _addBackpack.Click();
        }
        public void AddBikeLight()
        {
            _addBikeLight.Click();
        }
        public void AddBoltT()
        {
            _addBoltT.Click();
        }
        public void AddJacket()
        {
            _addJacket.Click();
        }
        public void AddOnesie()
        {
            _addOnesie.Click();
        }
        public void AddRedT()
        {
            _addRedT.Click();
        }
        #endregion

        #region Removing items
        public void RemoveBackpack()
        {
            _removeBackpack.Click();
        }
        public void RemoveBikeLight()
        {
            _removeBikeLight.Click();
        }
        public void RemoveBoltT()
        {
            _removeBoltT.Click();
        }
        public void RemoveJacket()
        {
            _removeJacket.Click();
        }
        public void RemoveOnesie()
        {
            _removeOnesie.Click();
        }
        public void RemoveRedT()
        {
            _removeRedT.Click();
        }
        #endregion

        public void ClickCartLink()
        {
            _cartLink.Click();
        }
    }
}
