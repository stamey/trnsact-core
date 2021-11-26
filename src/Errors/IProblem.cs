using System.Collections.Generic;

namespace Core.Errors
{
    public interface IProblem
    {
        string Detail { get; set; }
        string Instance { get; set; }
        List<InvalidParameter> InvalidParameters { get; set; }
        int Status { get; set; }
        string Title { get; }
        string Type { get; }
    }
}