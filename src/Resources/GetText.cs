using System.Collections.Generic;

namespace trnsACT.Core.Resources
{
    public static partial class ResourcesExtensions
    {
        public static string GetText(this string reference,
                                          string locale,
                                          IList<Resource> resources,
                                          string defaultLocale = "en-US")
        {
            string resourceText = GetResource(reference, locale, resources, defaultLocale)?.text;
            if (string.IsNullOrEmpty(resourceText))
            {
                return reference;
            }
            return ReplaceEmbeddedResource(resourceText, locale, resources);
        }

    }
}