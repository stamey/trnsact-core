using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IMessageType
    {
        string Category { get; set; }
        string Comments { get; set; }
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        string Description { get; set; }
        int Id { get; set; }
        bool? IsActive { get; set; }
        bool? IsVisible { get; set; }
        string Label { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        int SortOrder { get; set; }
    }
}