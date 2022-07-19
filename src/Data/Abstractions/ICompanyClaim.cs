using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface ICompanyClaim
    {
        string Category { get; set; }
        int CompanyId { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        int Id { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        string Name { get; set; }
        byte[] RowVer { get; set; }
        string Value { get; set; }
    }
}