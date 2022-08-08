using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface ICompany
    {
        int AccessFailureLimit { get; set; }
        int AccountExpirationInDays { get; set; }
        int CountryCode { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        string Currency { get; set; }
        string Description { get; set; }
        string DomainName { get; set; }
        string FromEmailAddress { get; set; }
        string FromName { get; set; }
        int Id { get; set; }
        int InvitationExpirationInDays { get; set; }
        bool IsActive { get; set; }
        string Label { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        int LockoutPeriodInMinutes { get; set; }
        string MailServerAddress { get; set; }
        string MailServerPassword { get; set; }
        short MailServerPort { get; set; }
        string MailServerUsername { get; set; }
        string Name { get; set; }
        int ParentId { get; set; }
        int PasswordExpirationInDays { get; set; }
        bool RequiresActivation { get; set; }
        bool RequiresAgreement { get; set; }
        bool RequiresApproval { get; set; }
        bool RequiresConfirmation { get; set; }
        bool RequiresSecureConnection { get; set; }
        byte[] RowVer { get; set; }
        string SecurityKey { get; set; }
        string SecuritySecret { get; set; }
        string Template { get; set; }
        string Theme { get; set; }
        int VerificationExpirationInMinutes { get; set; }
    }
}