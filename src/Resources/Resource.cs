namespace trnsACT.Core.Resources
{
    public class Resource : IResource
    {
        public int id { get; set; }
        public string locale { get; set; }
        public string reference { get; set; }
        public string text { get; set; }
    }
}
