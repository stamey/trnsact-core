using trnsACT.Core.Data.Abstractions;
using System;
using System.Collections.Generic;

namespace trnsACT.Core.Data.Models
{
    public partial class Message : IMessage
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int TypeId { get; set; }
        public string Role { get; set; }
        public string Locale { get; set; }
        public string AccountReference { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public DateTime DisplayStartDate { get; set; }
        public DateTime DisplayEndDate { get; set; }
        public bool? IsVisible { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsRead { get; set; }
        public int SortOrder { get; set; }
        public string Tag { get; set; }
        public string Comments { get; set; }
        public int? ParentId { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual MessageType Type { get; set; }
    }
}
