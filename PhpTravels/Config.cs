using System.Configuration;


namespace PhpTravels
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
