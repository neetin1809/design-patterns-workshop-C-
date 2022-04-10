using System;

namespace Visitor.Core
{
    public abstract class AbstractVisitor
    {
        public virtual void VisitHTMLElement(HTMLElement element)
        { }

        public virtual void VisitBodyElement(BodyElement element)
        { }

        public virtual void VisitTextElement(TextElement element)
        { }

        public virtual void VisitPElement(PElement element)
        { }
    }
}
