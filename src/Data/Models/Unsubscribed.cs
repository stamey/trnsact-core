using System;
using System.Collections.Generic;
using trnsACT.Core.Data.Abstractions;

namespace trnsACT.Core.Data.Models
{
    public partial class Unsubscribed : IUnsubscribed
    {
        public int CompanyId { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }
    }
}
