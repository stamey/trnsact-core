using trnsACT.Core.Data.Abstractions;
using System;

namespace trnsACT.Core.Data.Models
{
    public partial class UserClaim : IUserClaim
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual AppUser User { get; set; }
    }
}
