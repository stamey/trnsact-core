using trnsACT.Core.Data.Abstractions;
using System;

namespace trnsACT.Core.Data.Models
{
    public partial class CompanyTag : ICompanyTag
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Category { get; set; }
        public bool IsManaged { get; set; }
        public bool IsRequired { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual Company Company { get; set; }
    }
}
