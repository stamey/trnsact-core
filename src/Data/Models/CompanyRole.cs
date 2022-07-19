using trnsACT.Core.Data.Abstractions;
using System;

namespace trnsACT.Core.Data.Models
{
    public partial class CompanyRole : ICompanyRole
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Category { get; set; }
        public bool IsImpersonatingAllowed { get; set; }
        public bool IsImpersonationAllowed { get; set; }
        public int Rank { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual Company Company { get; set; }
    }
}
