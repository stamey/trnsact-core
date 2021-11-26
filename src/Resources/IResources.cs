using System.Collections.Generic;

namespace Core.Resources
{
    interface IResources
    {
        ICollection<Resource> Resources { get; set; }
    }
}
