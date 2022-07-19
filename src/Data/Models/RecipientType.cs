using trnsACT.Core.Data.Abstractions;
using System;
using System.Collections.Generic;

namespace trnsACT.Core.Data.Models
{
    public partial class RecipientType : IRecipientType
    {
        public RecipientType()
        {
            Recipient = new HashSet<Recipient>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual ICollection<Recipient> Recipient { get; set; }
    }
}
