using System.ComponentModel;
using trnsACT.Core.Errors;

[EditorBrowsable(EditorBrowsableState.Never)]
public static partial class ProblemExtensions
{
    public static string ErrorsToHTMLList(this Problem problem)
    {
        string list = string.Empty;
        if (problem.Errors?.Count > 0)
        {
            list = $"<ul>{problem.Detail}";
            foreach (Error item in problem.Errors)
            {
                string message = (item.Code.Equals("0")) ? item.Message : item.Message + $" ({item.Code})"; 
                list += $"<li>{message}</li>";
            }
            list += "</ul>";
        }
        return list;
    }
}
