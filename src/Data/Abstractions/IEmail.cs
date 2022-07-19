using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IEmail
    {
        string AccountReference { get; set; }
        string Comments { get; set; }
        int CompanyId { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        string Description { get; set; }
        string FromEmailAddress { get; set; }
        string FromName { get; set; }
        int Id { get; set; }
        bool? IsHtml { get; set; }
        bool? IsSent { get; set; }
        string Label { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        string Reference { get; set; }
        byte[] RowVer { get; set; }
        DateTimeOffset? SentDate { get; set; }
        string Subject { get; set; }
        string Tag { get; set; }
        string Text { get; set; }
        int TypeId { get; set; }
    }
}