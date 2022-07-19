using trnsACT.Core.Data.Abstractions;
using System;
using System.Collections.Generic;

namespace trnsACT.Core.Data.Models
{
    public partial class Recipient : IRecipient
    {
        public int Id { get; set; }
        public int EmailId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public int TypeId { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual Email Email { get; set; }
        public virtual RecipientType Type { get; set; }
    }
}
