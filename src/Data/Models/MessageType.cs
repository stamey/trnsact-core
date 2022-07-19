using trnsACT.Core.Data.Abstractions;
using System;
using System.Collections.Generic;

namespace trnsACT.Core.Data.Models
{
    public partial class MessageType : IMessageType
    {
        public MessageType()
        {
            Email = new HashSet<Email>();
            Message = new HashSet<Message>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsActive { get; set; }
        public int SortOrder { get; set; }
        public string Comments { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual ICollection<Email> Email { get; set; }
        public virtual ICollection<Message> Message { get; set; }
    }
}
