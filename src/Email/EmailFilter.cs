namespace trnsACT.Core.Email
{
    public class EmailFilter : IEmailFilter
    {
        public string Addressee { get; set; }
        public int CompanyId { get; set; }
        public bool OnlyHTML { get; set; }
        public bool OnlySent { get; set; }
        public bool OnlyText { get; set; }
        public bool OnlyUnsent { get; set; }
        public string RecipientsContain { get; set; }
        public string Reference { get; set; }
        public string Subject { get; set; }
        public string AccountReference { get; set; }
    }
}
