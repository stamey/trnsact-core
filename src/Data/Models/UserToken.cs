using trnsACT.Core.Data.Abstractions;
using System;

namespace trnsACT.Core.Data.Models
{
    public partial class UserToken : IUserToken
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public int Id { get; set; }
        public DateTimeOffset Expiry { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public byte[] RowVer { get; set; }

        public virtual AppUser User { get; set; }
    }
}
