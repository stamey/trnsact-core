namespace Core.Accounts
{
    public interface IAction
    {
        string Action { get; set; }
        string Reference { get; set; }
        string Referrer { get; set; }
    }
}
