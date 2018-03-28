using System.Configuration;

namespace PhpTravelsFramework.Helpers
{
    public static class Config
    {

        public static string GetUrl()
        {
            var appSettings = ConfigurationManager.AppSettings;
            return appSettings["Url"];
        }

        public static string GetBrowser()
        {
            var appSettings = ConfigurationManager.AppSettings;
            return appSettings["Browser"];
        }
    }
}
