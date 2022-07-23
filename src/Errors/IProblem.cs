using System.Collections.Generic;

namespace trnsACT.Core.Errors
{
    public interface IProblem
    {
        string Detail { get; set; }
        string Instance { get; set; }
        List<Error> Errors { get; set; }
        int Status { get; set; }
        string Title { get; }
        string Type { get; }
    }
}