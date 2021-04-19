using System.Text;

namespace SyncCS
{
    public struct p : WebComponent
    {
        object[] Content { get; set; }
        public p(object[] content) { Content = content; }

        public string Render()
        {
            if (Content.Length <= 0) throw new InvalidContentException("Content must contain at least one object");

            StringBuilder returnContent = new StringBuilder();
            returnContent.Append($"<{GetType().Name}>");

            for (int i = 0; i < Content.Length; i++)
            {
                if (Content[i].GetType() == typeof(string))
                {
                    returnContent.Append(Content[i]);
                }
                else if (Content[i].GetType() == typeof(TextComponent))
                {

                }
                else
                {
                    
                    throw new InvalidContentException("Content must contain object of type 'string' or 'TextComponent'");
                }
            }

            returnContent.Append($"</{GetType().Name}>");
            return returnContent.ToString();
        }
    }
}
