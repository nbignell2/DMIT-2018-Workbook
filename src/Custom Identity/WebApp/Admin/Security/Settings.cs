using System;
using System.Collections.Generic;
// Using a class with static members makes the code cleaner
using static System.Configuration.ConfigurationManager;
using System.Linq;
using System.Web;

namespace WebApp.Admin.Security
{
    /// <summary>
    /// A collection of application-wide settings that provide values
    /// for security roles which have been set in the web.config's
    /// appsettings section.
    /// </summary>
    internal static class Settings //There is no need to instantiate static class
    {
        public static string AdminRole => AppSettings //moved configurationmanager to using statement
            ["adminRole"];
        /*
         * The above is the same as typing:
         * public static string AdminRole
         * {
                get { return ConfigurationManager.AppSettings["adminRole"];
            }
         * 
         */
        public static string UserRole => AppSettings
           ["userRole"];

        public static IEnumerable<string> DefaultSecurityRoles =>
            new List<string>{ AdminRole, UserRole };

    }
}