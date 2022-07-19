using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IUserClaim
    {
        string ClaimType { get; set; }
        string ClaimValue { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        int Id { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        byte[] RowVer { get; set; }
        int UserId { get; set; }
    }
}