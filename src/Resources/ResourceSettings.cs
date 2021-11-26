using System.Collections.Generic;

namespace Core.Resources
{
    public class ResourceSettings : IResources
    {
        public ResourceSettings()
        {
            Resources = new HashSet<Resource>();
        }
        public ICollection<Resource> Resources { get; set; }
    }
}
