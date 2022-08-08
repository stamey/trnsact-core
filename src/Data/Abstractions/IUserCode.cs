using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IUserCode
    {
        string Action { get; set; }
        string Code { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset Expiry { get; set; }
        string Locale { get; set; }
        DateTimeOffset? RedeemedDate { get; set; }
        string Value { get; set; }
        int Id { get; set; }
        byte[] RowVer { get; set; }
        int UserId { get; set; }
    }
}