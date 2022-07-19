using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface ILink
    {
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        int EmailId { get; set; }
        int Id { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        string Value { get; set; }
    }
}