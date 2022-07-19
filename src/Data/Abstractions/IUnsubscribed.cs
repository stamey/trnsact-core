using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IUnsubscribed
    {
        int CompanyId { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        string EmailAddress { get; set; }
        int Id { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
    }
}