namespace InterpolApp.Models
{
    public class Link
    {
        public string Href { get; set; }
    }

    public class QueryLinks
    {
        public Link Self { get; set; }
        public Link First { get; set; }
        public Link Next { get; set; }
        public Link Last { get; set; }
    }

    public class NoticeLinks
    {
        public Link Self { get; set; }
        public Link Images { get; set; }
        public Link Thumbnail { get; set; }
    }
}
