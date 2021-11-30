using trnsACT.Core.Accounts;

namespace trnsACT.Core.Tokens
{
    public interface IActionToken: IToken, IAction
    {
        string Locale { get; set; }
    }
}