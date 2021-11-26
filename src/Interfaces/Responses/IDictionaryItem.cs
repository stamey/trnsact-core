using System;

namespace Core.Interfaces.Responses
{
    public interface IDictionaryItem
    {
        decimal Amount { get; set; }
        string Category { get; set; }
        DateTimeOffset Date { get; set; }
        string Name { get; set; }
        string Value { get; set; }
    }
}
