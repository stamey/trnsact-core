using trnsACT.Core.Data.Abstractions;
using System;
using System.Collections.Generic;

namespace trnsACT.Core.Data.Models
{
    public partial class AppUser : IAppUser
    {
        public AppUser()
        {
            UserClaim = new HashSet<UserClaim>();
            UserCode = new HashSet<UserCode>();
            UserTag = new HashSet<UserTag>();
            UserVisit = new HashSet<UserVisit>();
            UserToken = new HashSet<UserToken>();
            Company = new Company();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
        public bool IsAgreed { get; set; }
        public bool IsApproved { get; set; }
        public bool IsConfirmed { get; set; }
        public bool HasAnnouncement { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public bool IsPasswordTemporary { get; set; }
        public bool IsTwoFactorEnabled { get; set; }
        public DateTimeOffset? LockedOutUntil { get; set; }
        public bool IsLockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public DateTimeOffset PasswordChangedDate { get; set; }
        public int Visits { get; set; }
        public string Theme { get; set; }
        public DateTimeOffset LastAccessedDate { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual ICollection<UserClaim> UserClaim { get; set; }
        public virtual ICollection<UserCode> UserCode { get; set; }
        public virtual ICollection<UserTag> UserTag { get; set; }
        public virtual ICollection<UserToken> UserToken { get; set; }
        public virtual ICollection<UserVisit> UserVisit { get; set; }
    }
}
