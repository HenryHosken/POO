namespace POO.ContentContext
{
    public abstract class Content : Base
    {
        public Content(String title, string url)
        {
            Title = title;
            Url = url;
        }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}