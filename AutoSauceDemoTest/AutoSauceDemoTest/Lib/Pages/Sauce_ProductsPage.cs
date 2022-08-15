namespace AutoSauceDemoTest.Lib.Pages
{
    public class Sauce_ProductsPage
    {
        #region Properties and fields
        private IWebDriver _seleniumDriver;
        private string _productsPageUrl = AppConfigReader.InventoryUrl;
        private IWebElement _sortMenuActiveOption => _seleniumDriver.FindElement(By.ClassName("active_option"));
        private IWebElement _sortMenuSelectContainer => _seleniumDriver.FindElement(By.ClassName("product_sort_container"));
        private SelectElement _sortMenuSelectElement => new SelectElement(_sortMenuSelectContainer);
        private List<IWebElement> _inventoryItems => _seleniumDriver.FindElements(By.ClassName("inventory_item")).ToList();
        #endregion
        public Sauce_ProductsPage(IWebDriver seleniumDriver) => _seleniumDriver = seleniumDriver;


        #region Methods
        public string SortMenuActiveOption => _sortMenuActiveOption.Text;
        public void ClickSortMenu() => _sortMenuSelectContainer.Click();
        public void ChooseSortMethod(string sortMethod) => _sortMenuSelectElement.SelectByText(sortMethod);

        public List<string> InventoryItemNames =>
            _inventoryItems.Select(x => x.FindElement(By.ClassName("inventory_item_name")).Text).ToList();
        public List<float> InventoryItemPrices =>
            _inventoryItems.Select(x => (float)Math.Round(float.Parse(x.FindElement(By.ClassName("inventory_item_price")).Text.Remove(0,1)),2)).ToList();
        
        
        #endregion
    }
}
