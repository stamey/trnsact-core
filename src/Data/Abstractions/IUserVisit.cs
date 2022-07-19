using System;

namespace trnsACT.Core.Data.Abstractions
{
    public interface IUserVisit
    {
        string Browser { get; set; }
        int Id { get; set; }
        string RemoteAddress { get; set; }
        string Name { get; set; }
        byte[] RowVer { get; set; }
        int UserId { get; set; }
        DateTimeOffset VisitDate { get; set; }
    }
}