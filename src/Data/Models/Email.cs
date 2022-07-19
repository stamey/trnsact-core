using System;
using System.Collections.Generic;
using trnsACT.Core.Data.Abstractions;

namespace trnsACT.Core.Data.Models
{
    public partial class Email : IEmail
    {
        public Email()
        {
            Link = new HashSet<Link>();
            Recipient = new HashSet<Recipient>();
        }

        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int TypeId { get; set; }
        public string Reference { get; set; }
        public string FromName { get; set; }
        public string FromEmailAddress { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        public bool? IsHtml { get; set; }
        public bool? IsSent { get; set; }
        public string AccountReference { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public DateTimeOffset? SentDate { get; set; }
        public string Comments { get; set; }
        public string Tag { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual Communicator Company { get; set; }
        public virtual MessageType Type { get; set; }
        public virtual ICollection<Link> Link { get; set; }
        public virtual ICollection<Recipient> Recipient { get; set; }
    }
}
