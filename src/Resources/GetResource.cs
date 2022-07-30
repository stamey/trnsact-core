using System.Collections.Generic;
using System.Linq;

namespace trnsACT.Core.Resources
{
    public static partial class ResourcesExtensions
    {
        public static Resource GetResource(string reference,
                                           string locale,
                                           IList<Resource> resources,
                                           string defaultLocale = "en-US",
                                           string defaultText = "")
        {
            if (resources != null)
            {
                IEnumerable<Resource> selected = from resource in resources
                                                 where (resource.locale?.ToLower() == locale?.ToLower() || resource.locale?.Substring(0, 2)?.ToLower() == locale.Substring(0, 2)?.ToLower() || resource.locale?.ToLower() == defaultLocale)
                                                 &&
                                                 resource.reference.ToLower() == reference?.ToLower()
                                                 orderby ((resource.locale?.ToLower() == locale?.ToLower() ? 3000 : resource.locale?.Substring(0, 2)?.ToLower() == locale.Substring(0, 2)?.ToLower() ? 2000 : 1000)) descending
                                                 select resource;
                var result = selected?.FirstOrDefault();
                if (result != null) return result;
            }
            return new Resource { 
                                    text = (defaultText == "") ? reference : defaultText, 
                                    locale = (string.IsNullOrEmpty(locale)) ? defaultLocale : locale 
                                };
        }
    }
}