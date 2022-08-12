using System.Configuration;

namespace Sauce_TestAutomationFramework;

public static class AppConfigReader
{
    public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
}
