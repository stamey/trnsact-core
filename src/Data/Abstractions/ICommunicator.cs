using System;
using System.Collections.Generic;

namespace trnsACT.Core.Data.Abstractions
{
    public interface ICommunicator
    {
        string CreatedBy { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        string Description { get; set; }
        ICollection<Models.Email> Email { get; set; }
        string FromEmailAddress { get; set; }
        string FromName { get; set; }
        int Id { get; set; }
        bool? IsActive { get; set; }
        string Label { get; set; }
        string LastChangedBy { get; set; }
        DateTimeOffset LastChangedDate { get; set; }
        string MailServerAddress { get; set; }
        string MailServerPassword { get; set; }
        short MailServerPort { get; set; }
        string MailServerUsername { get; set; }
        string Name { get; set; }
        int ParentId { get; set; }
        bool RequiresSecureConnection { get; set; }
        string SecurityKey { get; set; }
        string SecuritySecret { get; set; }
        string Template { get; set; }
    }
}