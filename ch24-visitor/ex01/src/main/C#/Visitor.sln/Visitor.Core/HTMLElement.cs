using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Core
{
    public class HTMLElement
    {
        protected string tagName;
        public List<HTMLElement> children = new List<HTMLElement>();

        public HTMLElement(): this("html")
        {
        }

        public HTMLElement(string tagName)
        {
            this.tagName = tagName;
        }

        public void add(HTMLElement element)
        {
            children.Add(element);
        }

        public String toString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<");
            builder.Append(tagName);
            builder.Append(">");
            foreach (HTMLElement element in children)
            {
                builder.Append(element.toString());
            }
            builder.Append("</");
            builder.Append(tagName);
            builder.Append(">");

            return builder.ToString();
        }

        public void visitChildren(AbstractVisitor visitor)
        {
            foreach (HTMLElement item in children)
            {
                item.accept(visitor);
            }
        }

        public void accept(AbstractVisitor visitor)
        {
            visitChildren(visitor);
            visitor.VisitHTMLElement(this);
        }
    }
}
