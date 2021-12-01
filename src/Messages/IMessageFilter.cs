using System;

namespace trnsACT.Core.Messages
{
    public interface IMessageFilter
    {
        string AccountReference { get; set; }
        DateTime AsOfDate { get; set; }
        int CompanyId { get; set; }
        int Id { get; set; }
        string Locale { get; set; }
        string Role { get; set; }
        bool ShowAll { get; set; }
        bool ShowOnlyNotSent { get; set; }
        int TypeId { get; set; }
    }
}