using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Infobase.Common
{
    public static class RouteLocalizer
    {
        private static Dictionary<(string, string), string> dict = new Dictionary<(string, string), string>();
        static RouteLocalizer() {
            
            // Add Index
            dict.Add(("FR", "index"), "Index");

            // Add measure details
            dict.Add(("FR", "détails"), "Details");

            // Add measure details
            dict.Add(("FR", "outil"), "Datatool");

            // Add strata controller
            dict.Add(("FR", "stratafr"), "strata");
        }
        public static string LocalizeRouteElement(string culture, string part) {
        try
            {
                return dict[(culture.ToUpper(), part.ToLower())];
            }
            catch (System.Exception)
            {
              return part;
            }
        }

        public static string ReverseLookup(string culture, string part) {
            return  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(dict.Where(kvp => kvp.Key.Item1 == culture && kvp.Value == part).Select(kvp => kvp.Key.Item2).FirstOrDefault() ?? part);
            
        }
    }
    
}