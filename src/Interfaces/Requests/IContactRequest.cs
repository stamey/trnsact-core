namespace trnsACT.Core.Interfaces.Requests
{
    public interface IContactRequest : IAccountRequest
    {
        string AdditionalName { get; set; }
        string FamilyName { get; set; }
        string GivenName { get; set; }
    }
}
