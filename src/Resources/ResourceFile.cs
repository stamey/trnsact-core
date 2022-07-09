using System.Collections.Generic;
using System.Text.Json.Serialization;
using trnsACT.Core.Localization;

namespace trnsACT.Core.Resources
{
    public class ResourceFile
    {
        [JsonPropertyName(CultureNames.EnglishUS)]
        public List<Resource> english { get; set; }

        [JsonPropertyName(CultureNames.SpanishUS)]
        public List<Resource> spanish { get; set; }

        [JsonPropertyName(CultureNames.FrenchCA)]
        public List<Resource> french { get; set; }

        [JsonPropertyName(CultureNames.German)]
        public List<Resource> german { get; set; }

    }
}
