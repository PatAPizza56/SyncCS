namespace SyncCS
{
    class Program
    {
        static void Main(string[] args)
        {
            WebPage page = new WebPage()
            {
                Components = new WebComponent[]
                {
                    new h1("Hello web, this is pizza"),
                    new p(new object[] {"SyncCS is a c# library for creating websites using c#. " +
                        "It works by compiling your c# code into an html file, " +
                        "which then can be run by any browser"}),
                    new h4("More info coming soon!"),
                }
            };

            page.Render();
        }
    }
}
