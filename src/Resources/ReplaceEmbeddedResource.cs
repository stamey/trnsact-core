using System.Collections.Generic;

namespace trnsACT.Core.Resources
{
    public static partial class ResourcesExtensions
    {
        public static string ReplaceEmbeddedResource(string textToEvaluate,
                                                     string locale,
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
                        //Allow for embedded resources to be nested -- Call to GetText() instead of GetResouce().Text
                        string embeddedResourceReference = resourceReference.GetText(locale,resources);
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
                            result = ReplaceEmbeddedResource(result, locale, resources);
                        }
                    }
                }
            }
            return result;
        }
    }
}