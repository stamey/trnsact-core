using System.ComponentModel;
using trnsACT.Core.Errors;

[EditorBrowsable(EditorBrowsableState.Never)]
public static partial class ProblemExtensions
{
    public static string InvalidParmetersToHTMLList(this Problem problem)
    {
        string list = string.Empty;
        if (problem.InvalidParameters?.Count > 0)
        {
            list = $"<ul>{problem.Detail}";
            foreach (InvalidParameter item in problem.InvalidParameters)
            {
                list += $"<li>{item.Message}</li>";
            }
            list += "</ul>";
        }
        return list;
    }
}
