using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IUserToken
    {
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset Expiry { get; set; }
        int Id { get; set; }
        byte[] RowVer { get; set; }
        string Token { get; set; }
        int UserId { get; set; }
    }
}