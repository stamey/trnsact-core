using trnsACT.Core.Data.Abstractions;
using System;
using System.Collections.Generic;

namespace trnsACT.Core.Data.Models
{
    public partial class Communicator : ICommunicator
    {
        public Communicator()
        {
            Email = new HashSet<Email>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string FromEmailAddress { get; set; }
        public string FromName { get; set; }
        public string MailServerAddress { get; set; }
        public string MailServerUsername { get; set; }
        public string MailServerPassword { get; set; }
        public short MailServerPort { get; set; }
        public bool RequiresSecureConnection { get; set; }
        public string Template { get; set; }
        public string SecurityKey { get; set; }
        public string SecuritySecret { get; set; }
        public bool? IsActive { get; set; }
        public int ParentId { get; set; }
        public DateTimeOffset LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public byte[] RowVer { get; set; }

        public virtual ICollection<Email> Email { get; set; }
    }
}
