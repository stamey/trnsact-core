using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IUserTag
    {
        decimal Amount { get; set; }
        string Category { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset? Date { get; set; }
        DateTimeOffset? EndDate { get; set; }
        int Id { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        string Name { get; set; }
        int? ParentId { get; set; }
        byte[] RowVer { get; set; }
        DateTimeOffset? StartDate { get; set; }
        int UserId { get; set; }
        string Value { get; set; }
    }
}