namespace trnsACT.Core.Security
{
    public interface IApiUser
    {
        string AdditionalName { get; }
        int CompanyId { get; }
        string EmailAddress { get; }
        string FamilyName { get; }
        string GivenName { get; }
        string Name { get; }
        string Role { get; }
        string SecurityStamp { get; }
    }
}
