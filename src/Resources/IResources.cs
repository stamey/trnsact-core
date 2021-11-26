using System.Collections.Generic;

namespace trnsACT.Core.Resources
{
    interface IResources
    {
        ICollection<Resource> Resources { get; set; }
    }
}
