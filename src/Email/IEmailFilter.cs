namespace trnsACT.Core.Email
{
    public interface IEmailFilter
    {
        string AccountReference { get; set; }
        string Addressee { get; set; }
        int CompanyId { get; set; }
        bool OnlyHTML { get; set; }
        bool OnlySent { get; set; }
        bool OnlyText { get; set; }
        bool OnlyUnsent { get; set; }
        string RecipientsContain { get; set; }
        string Reference { get; set; }
        string Subject { get; set; }
    }
}