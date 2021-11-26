namespace Core.Resources
{
    public class Resource : IResource
    {
        public string locale { get; set; }
        public string reference { get; set; }
        public string role { get; set; }
        public string text { get; set; }
    }
}
