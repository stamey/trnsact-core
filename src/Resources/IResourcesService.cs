using System.Collections.Generic;

namespace trnsACT.Core.Resources
{
    public interface IResourcesService
    {
        IList<Resource> FindAll();

        Resource Find(string reference, 
                      string locale = "", 
                      string text = "");
    }
}
