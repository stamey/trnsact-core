using System;

namespace trnsACT.Core.Messages
{
    public class MessageFilter : IMessageFilter
    {
        public MessageFilter()
        {
            Locale = "en-US";
            AccountReference = "all";
            ShowAll = false;
            AsOfDate = DateTime.Now;
            TypeId = 999;
            Role = "member";
            Id = 0;
            ShowOnlyNotSent = false;
        }
        public string AccountReference { get; set; }
        public DateTime AsOfDate { get; set; }
        public int CompanyId { get; set; }
        public int Id { get; set; }
        public string Locale { get; set; }
        public string Role { get; set; }
        public bool ShowAll { get; set; }
        public bool ShowOnlyNotSent { get; set; }
        public int TypeId { get; set; }
    }
}
