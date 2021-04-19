using System;
using System.Text;

namespace SyncCS
{
    public class WebPage
    {
        public WebComponent[] Components { get; set; }

        public void Render()
        {
            StringBuilder content = new StringBuilder();

            content.Append("<html>");
            content.Append("<body>");

            for (int i = 0; i < Components.Length; i++)
            {
                content.Append(Components[i].Render());
            }

            content.Append("</body>");
            content.Append("</html>");

            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Test.html", content.ToString());
        }
    }
}
