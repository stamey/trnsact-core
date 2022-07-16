namespace trnsACT.Core.Resources
{
    public interface IResource
    {
        int id { get; set; }
        string locale { get; set; }
        string reference { get; set; }
        string text { get; set; }
    }
}
