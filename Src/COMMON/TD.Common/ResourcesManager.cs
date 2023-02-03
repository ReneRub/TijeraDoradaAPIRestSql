using System.Globalization;
using System.Reflection;
using System.Resources;

namespace TD.Common
{
    /// <summary>
    /// Contains all in reference to Resources files
    /// </summary>
    public class ResourcesManager
    {
        /// <summary>
        /// Gets the resource value.
        /// </summary>
        /// <param name="keyName">Name of the key.</param>
        /// <returns>string</returns>
        public static string GetResourceValue(string keyName)
        {
            if (string.IsNullOrEmpty(keyName))
            {
                return string.Empty;
            }

            ResourceManager stringManager =
               new ResourceManager("TD.Common.AppResources", Assembly.GetExecutingAssembly());

            try
            {
                return stringManager.GetString(keyName, CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return stringManager.GetString(keyName, new CultureInfo("en-US"));
            }
        }
    }
}
