using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IRecipient
    {
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        string EmailAddress { get; set; }
        int EmailId { get; set; }
        int Id { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        string Name { get; set; }
        int TypeId { get; set; }
    }
}