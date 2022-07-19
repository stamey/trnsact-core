using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IAppUser
    {
        int AccessFailedCount { get; set; }
        int CompanyId { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        string EmailAddress { get; set; }
        int Id { get; set; }
        bool IsActive { get; set; }
        bool IsAgreed { get; set; }
        bool IsApproved { get; set; }
        bool IsConfirmed { get; set; }
        bool HasAnnouncement { get; set; }
        bool IsLockoutEnabled { get; set; }
        bool IsPasswordTemporary { get; set; }
        bool IsTwoFactorEnabled { get; set; }
        DateTimeOffset LastAccessedDate { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        DateTimeOffset? LockedOutUntil { get; set; }
        DateTimeOffset PasswordChangedDate { get; set; }
        string PasswordHash { get; set; }
        string Role { get; set; }
        byte[] RowVer { get; set; }
        string SecurityStamp { get; set; }
        string Theme { get; set; }
        string UserName { get; set; }
        int Visits { get; set; }
    }
}