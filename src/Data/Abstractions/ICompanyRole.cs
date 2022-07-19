using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface ICompanyRole
    {
        string Category { get; set; }
        int CompanyId { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        int Id { get; set; }
        bool IsImpersonatingAllowed { get; set; }
        bool IsImpersonationAllowed { get; set; }
        string Label { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        string Name { get; set; }
        int Rank { get; set; }
        byte[] RowVer { get; set; }
    }
}