using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.Resources.Helper
{
    public static class CustomResourceManager
    {
        private static Assembly resourceAssembly = Assembly.GetAssembly(typeof(Krokoz.CRM.Resources.Helper.CustomResourceManager));
        private const string resourceNamespace = "Krokoz.CRM.Resources.";

        public static string GetString(string resourceRelativePath, string key, CultureInfo culture = null)
        {
            return GetString(resourceRelativePath, key, false, culture);
        }
        public static Dictionary<string, string> GetDictionary(string resourceRelativePath, CultureInfo culture = null)
        {
            string resourcePath = resourceNamespace + resourceRelativePath;
            if (culture == null)
            { culture = CultureInfo.CurrentCulture; }

            if (resourceAssembly.GetManifestResourceNames().Contains(resourcePath + ".resources"))
            {
                var resourceManager = new System.Resources.ResourceManager(resourcePath, resourceAssembly);
                var ss = resourceManager.GetResourceSet(culture, true, true);
                return ss == null ? new Dictionary<string, string>() :
                       ss.Cast<DictionaryEntry>()
                       .ToDictionary(r => r.Key.ToString(), r => r.Value.ToString());
            }
            else
            {
                return new Dictionary<string, string>();
            }
        }
        public static string GetString(string resourceRelativePath, string key, bool emptyIfNotFound, CultureInfo culture = null)
        {
            string resourcePath = resourceNamespace + resourceRelativePath;
            string resourceString = "";
            if (culture == null)
            {
                culture = CultureInfo.CurrentCulture;
            }

            if (resourceAssembly.GetManifestResourceNames().Contains(resourcePath + ".resources"))
            {
                var resourceManager = new System.Resources.ResourceManager(resourcePath, resourceAssembly);
                resourceString = resourceManager.GetString(key, culture);
            }

            if (string.IsNullOrEmpty(resourceString))
            {
                if (!emptyIfNotFound)
                {
                    resourceString = $"[{key}]";
                }
            }
            return resourceString;
        }
    }
}
