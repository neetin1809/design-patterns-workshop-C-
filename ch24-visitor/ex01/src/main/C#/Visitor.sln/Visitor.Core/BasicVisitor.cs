using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Core
{
    public class BasicVisitor : AbstractVisitor
    {
        private List<String> visitedList = new List<string>();

        public List<string> getList() => visitedList;

        public override void VisitHTMLElement(HTMLElement element)
        {
            visitedList.Add("Visited HTML: " + element.ToString());
            visitedList.Add("\n--\n");
        }

        public override void VisitBodyElement(BodyElement element)
        {
            visitedList.Add("Visited Body: " + element.ToString());
            visitedList.Add("\n--\n");
        }

        public override void VisitTextElement(TextElement element)
        {
            visitedList.Add("Visited Text: " + element.ToString());
            visitedList.Add("\n-\n");
        }

        public override void VisitPElement(PElement element)
        {
            visitedList.Add("Visited P: " + element.ToString());
            visitedList.Add("\n-\n");
        }
    }
}
