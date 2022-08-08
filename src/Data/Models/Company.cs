using System;
using System.Collections.Generic;
using trnsACT.Core.Data.Abstractions;

namespace trnsACT.Core.Data.Models
{
    public partial class Company : ICompany
    {
        public Company()
        {
            CompanyClaim = new HashSet<CompanyClaim>();
            CompanyTag = new HashSet<CompanyTag>();
            CompanyRole = new HashSet<CompanyRole>();
            Email = new HashSet<Email>();
        }

        public int AccessFailureLimit { get; set; }
        public int AccountExpirationInDays { get; set; }
        public virtual ICollection<CompanyClaim> CompanyClaim { get; set; }
        public virtual ICollection<CompanyRole> CompanyRole { get; set; }
        public virtual ICollection<CompanyTag> CompanyTag { get; set; }
        public int CountryCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string DomainName { get; set; }
        public virtual ICollection<Email> Email { get; set; }
        public string FromEmailAddress { get; set; }
        public string FromName { get; set; }
        public int Id { get; set; }
        public int InvitationExpirationInDays { get; set; }
        public bool IsActive { get; set; }
        public string Label { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public int LockoutPeriodInMinutes { get; set; }
        public string MailServerAddress { get; set; }
        public string MailServerPassword { get; set; }
        public short MailServerPort { get; set; }
        public string MailServerUsername { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int PasswordExpirationInDays { get; set; }
        public bool RequiresActivation { get; set; }
        public bool RequiresAgreement { get; set; }
        public bool RequiresApproval { get; set; }
        public bool RequiresConfirmation { get; set; }
        public bool RequiresSecureConnection { get; set; }
        public byte[] RowVer { get; set; }
        public string SecurityKey { get; set; }
        public string SecuritySecret { get; set; }
        public string Template { get; set; }
        public string Theme { get; set; }
        public int VerificationExpirationInMinutes { get; set; }
    }
}