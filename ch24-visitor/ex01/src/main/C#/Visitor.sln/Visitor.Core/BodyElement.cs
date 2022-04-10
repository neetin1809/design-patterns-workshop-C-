using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Core
{
    public class BodyElement : HTMLElement
    {
        public BodyElement(): base("body")
        {
        }

        public void accept(AbstractVisitor visitor)
        {
            visitChildren(visitor);
            visitor.VisitBodyElement(this);
        }
    }
}
