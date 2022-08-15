using System.Configuration;

namespace Sauce_TestAutomationFramework;

public static class AppConfigReader
{
    public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
    public static readonly string CartUrl = ConfigurationManager.AppSettings["cart_url"];
    public static readonly string InventoryUrl = ConfigurationManager.AppSettings["inventory_url"];
    public static readonly string CheckoutStepOneUrl = ConfigurationManager.AppSettings["checkoutstepone_url"];
    public static readonly string CheckoutStepTwoUrl = ConfigurationManager.AppSettings["checkoutsteptwo_url"];
}
