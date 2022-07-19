using System;
using System.Collections.Generic;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IRecipientType
    {
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        int Id { get; set; }
        string Label { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
    }
}