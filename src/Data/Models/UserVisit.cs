using trnsACT.Core.Data.Abstractions;
using System;

namespace trnsACT.Core.Data.Models
{
    public partial class UserVisit : IUserVisit
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public string RemoteAddress { get; set; }
        public string Browser { get; set; }
        public DateTimeOffset VisitDate { get; set; }
        public byte[] RowVer { get; set; }

        public virtual AppUser User { get; set; }
    }
}
