using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IMessage
    {
        string AccountReference { get; set; }
        string Comments { get; set; }
        int CompanyId { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        string Description { get; set; }
        DateTime DisplayEndDate { get; set; }
        DateTime DisplayStartDate { get; set; }
        int Id { get; set; }
        bool IsRead { get; set; }
        bool IsUrgent { get; set; }
        bool? IsVisible { get; set; }
        string Label { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        string Locale { get; set; }
        int? ParentId { get; set; }
        string Role { get; set; }
        int SortOrder { get; set; }
        string Tag { get; set; }
        string Text { get; set; }
        int TypeId { get; set; }
    }
}