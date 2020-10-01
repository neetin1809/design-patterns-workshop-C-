using System.Collections.Generic;
using System.Text;

namespace Composite_Library
{
    public class HTMLElement
    {
        public string tagName;
        private List<HTMLElement> children = new List<HTMLElement>();

        public HTMLElement()
        {
            this.tagName = "html";
        }

        public HTMLElement(string tagname)
        {
            this.tagName = tagname;
        }

        public void add(HTMLElement element)
        {
            children.Add(element);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("<{0}>", tagName);
            foreach (var item in children)
            {
                builder.Append(item.ToString());
            }
            builder.AppendFormat("</{0}>", tagName);
            return builder.ToString();
        }
    }
}
