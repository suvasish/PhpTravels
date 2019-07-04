using System.Configuration;

namespace PhpTravels
{
    public static class Config
    {
        public static string URL { get { return ConfigurationManager.AppSettings["URL"]; } }

        public static string Browser { get { return ConfigurationManager.AppSettings["BROWSER"]; } }

        public static string LoginEmail { get { return ConfigurationManager.AppSettings["LoginEmail"]; } }

        public static string Password { get { return ConfigurationManager.AppSettings["Password"]; } }

    }
}
