namespace Core.Interfaces.Responses
{
    public interface IContactResponse
    {
        string AdditionalName { get; set; }
        string EmailAddress { get; set; }
        string FamilyName { get; set; }
        string GivenName { get; set; }
    }
}
