using System.Collections.Generic;
using System.Linq;

namespace Core.Resources
{
    public static class ResourcesExtensions
    {
        public static string GetResourceText(this string reference,
                                             string locale,
                                             string role,
                                             List<Resource> resources)
        {
            const string DEFAULT_LOCALE = "en-us";
            const string DEFAULT_ROLE = "all";
            string resourceText = reference ?? string.Empty;
            if (resources != null)
            {
                IEnumerable<Resource> selected = from resource in resources
                                                 where (resource.locale?.ToLower() == locale?.ToLower() || resource.locale?.Substring(0, 2)?.ToLower() == locale.Substring(0, 2)?.ToLower() || resource.locale?.ToLower() == DEFAULT_LOCALE)
                                                 &&
                                                 (resource.role?.ToLower() == role?.ToLower() || resource.role?.ToLower() == DEFAULT_ROLE)
                                                 &&
                                                 resource.reference.ToLower() == reference?.ToLower()
                                                 orderby ((resource.locale?.ToLower() == locale?.ToLower() ? 3000 : resource.locale?.Substring(0, 2)?.ToLower() == locale.Substring(0, 2)?.ToLower() ? 2000 : 1000) + (resource.role == DEFAULT_ROLE ? 100 : 200)) descending
                                                 select resource;
                resourceText = selected.FirstOrDefault()?.text;
            }
            if (!string.IsNullOrEmpty(resourceText))
            {
                resourceText = ReplaceEmbeddedResource(resourceText, locale, role, resources);
            }
            return resourceText;
        }

        private static string ReplaceEmbeddedResource(string textToEvaluate,
                                                     string locale,
                                                     string role,
                                                     List<Resource> resources)
        {
            string result = textToEvaluate;
            if (textToEvaluate != string.Empty)
            {
                const string RESOURCE_PATTERN = "{{RESOURCE:";
                const string RESOURCE_PATTERN_UPPERCASE = "{{URESOURCE:";
                const string RESOURCE_PATTERN_LOWERCASE = "{{LRESOURCE:";
                if (textToEvaluate.IndexOf(RESOURCE_PATTERN) > -1 || textToEvaluate.IndexOf(RESOURCE_PATTERN_UPPERCASE) > -1 || textToEvaluate.IndexOf(RESOURCE_PATTERN_LOWERCASE) > -1)
                {
                    string pattern = string.Empty;
                    if (textToEvaluate.IndexOf(RESOURCE_PATTERN) > -1)
                    {
                        pattern = RESOURCE_PATTERN;
                    }
                    else if (textToEvaluate.IndexOf(RESOURCE_PATTERN_UPPERCASE) > -1)
                    {
                        pattern = RESOURCE_PATTERN_UPPERCASE;
                    }
                    else if (textToEvaluate.IndexOf(RESOURCE_PATTERN_LOWERCASE) > -1)
                    {
                        pattern = RESOURCE_PATTERN_LOWERCASE;
                    }

                    if (pattern != string.Empty)
                    {
                        string resourceReference = textToEvaluate.Substring(textToEvaluate.IndexOf(pattern) + pattern.Length);
                        resourceReference = resourceReference.Substring(0, resourceReference.IndexOf("}}")).Trim();
                        string embeddedResourceReference = resourceReference.GetResourceText(locale, role, resources);
                        if (embeddedResourceReference != resourceReference && pattern.Equals(RESOURCE_PATTERN_UPPERCASE))
                        {
                            embeddedResourceReference = embeddedResourceReference.ToUpper();
                        }
                        else if (embeddedResourceReference != resourceReference && pattern.Equals(RESOURCE_PATTERN_LOWERCASE))
                        {
                            embeddedResourceReference = embeddedResourceReference.ToLower();
                        }
                        result = textToEvaluate.Replace(pattern + resourceReference + "}}", embeddedResourceReference);
                        if (result.IndexOf(RESOURCE_PATTERN) > -1 || result.IndexOf(RESOURCE_PATTERN_UPPERCASE) > -1 || result.IndexOf(RESOURCE_PATTERN_LOWERCASE) > -1)
                        {
                            result = ReplaceEmbeddedResource(result, locale, role, resources);
                        }
                    }
                }
            }
            return result;
        }
    }
}