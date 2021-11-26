namespace Core.Resources
{
    public interface IResource
    {
        string locale { get; set; }
        string reference { get; set; }
        string role { get; set; }
        string text { get; set; }
    }
}
