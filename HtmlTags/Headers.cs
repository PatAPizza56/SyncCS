namespace SyncCS
{
    public struct h1 : WebComponent
    {
        string Content { get; set; }
        public h1(string content) { Content = content; }

        public string Render() => $"<h1>{Content}</h1>";
    }

    public struct h2 : WebComponent
    {
        string Content { get; set; }
        public h2(string content) { Content = content; }

        public string Render() => $"<h2>{Content}</h2>";
    }

    public struct h3 : WebComponent
    {
        string Content { get; set; }
        public h3(string content) { Content = content; }

        public string Render() => $"<h3>{Content}</h3>";
    }

    public struct h4 : WebComponent
    {
        string Content { get; set; }
        public h4(string content) { Content = content; }

        public string Render() => $"<h4>{Content}</h4>";
    }

    public struct h5 : WebComponent
    {
        string Content { get; set; }
        public h5(string content) { Content = content; }

        public string Render() => $"<h5>{Content}</h5>";
    }

    public struct h6 : WebComponent
    {
        string Content { get; set; }
        public h6(string content) { Content = content; }

        public string Render() => $"<{GetType().Name}>{Content}</{GetType().Name}>";
    }
}
